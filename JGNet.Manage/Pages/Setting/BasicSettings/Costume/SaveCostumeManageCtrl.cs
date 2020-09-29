using CCWin;
using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.MyEnum;
using JGNet.Core.Tools;
using JGNet.ForManage;
using JGNet.Manage.Components;
using JGNet.Manage.Model;
using JGNet.Manage.Pages.RuleSettings;
using JGNet.Manage.Pages.Setting.BasicSettings.Costume;
using CJBasic.Helpers;
using CJBasic.Loggers;
using CJPlus;
using QCloud.CosApi.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace JGNet.Manage

{
    public partial class SaveCostumeManageCtrl : BaseModifyUserControl
    {

        private Costume CurItem { get; set; }
        private Byte[] photo { get; set; }
        public List<ListItem<String>> ColorList { get; private set; }
        public bool currentIsValid = true;
        public event Action<Costume> Costume_Newed;
        private bool isHasPermissionMark = true;
        private List<EmCostumePhoto> RemovePhotos { get; set; }
        private List<EmCostumePhoto> CostumePhotos { get; set; }
        public CosLoginInfo CosLoginInfo { get; private set; }
        public CosCloud CosCloud { get; private set; }
        public SaveCostumeManageCtrl()
        {
            InitializeComponent();
            new DataGridViewPagingSumCtrl(this.dataGridView).Initialize();
            //  skinComboBox_Brand.SelectedIndexChanged += skinComboBox_Brand_SelectedIndexChanged;
            colorComboBox1.SelectionChangeCommitted += colorComboBox1_SelectionChangeCommitted;

            this.titleImageControlWidth1.Upload_Click += Upload_Click;
            titleImageControlWidth1.TitleImageMoveUp += TitleImageMoveUp;
            titleImageControlWidth1.TitleImageMoveDown += TitleImageMoveDown;
        }


        private void colorComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SkinComboBox combobox = sender as SkinComboBox;
            if (combobox.SelectedItem != null)
            {
                CostumeColor color = (CostumeColor)combobox.SelectedItem;
                if (color.ID != null)
                {
                    AddColorToListView(color.Name);
                }
            }
        }

        public SaveCostumeManageCtrl(Costume item)
        {
            InitializeComponent();

            new DataGridViewPagingSumCtrl(this.dataGridView).Initialize();
            colorComboBox1.SelectionChangeCommitted += colorComboBox1_SelectionChangeCommitted;
            this.CurItem = item;


            MenuPermission = RolePermissionMenuEnum.商品档案;
        }

        public override void RefreshPage()
        {
            Initialize();

        }

        public void Display()
        {
            if (CurItem != null)
            {
                this.BaseButton3.Text = "保存";
                this.skinTextBox_ID.Enabled = false;
                this.skinTextBox_ID.Text = this.CurItem.ID;
                this.skinTextBox_Name.Text = this.CurItem.Name;
                this.numericUpDown_Price.Value = this.CurItem.Price;
                //20190223編輯的時候直接獲取之前的成本價，不需要根據打勾判斷
                //if (this.skinCheckBoxAutoCostPrice.Checked)
                //{
                //    numericUpDown_Price_ValueChanged(null);
                //} else
                //{
                this.numericUpDownCostPrice.Value = this.CurItem.CostPrice;
                this.numericTextBoxSalePrice.Value = this.CurItem.SalePrice;
                // }
                this.skinComboBox_SupplierID.SelectedValue = this.CurItem.SupplierID;
                this.skinComboBox_Brand.SelectedValue = this.CurItem.BrandID;
                this.skinComboBox_Year.SelectedValue = this.CurItem.Year.ToString();
                this.skinComboBox_Season.skinComboBox.SelectedValue = this.CurItem.Season;
                this.skinComboBoxBigClass.SelectedValue = this.CurItem;
                // this.comboBox_model.skinComboBox.SelectedValue = this.CurItem.Models;
                // this.skinComboBox_Style.skinComboBox.SelectedValue = this.CurItem.Style;
                this.skinTextBox_Remarks.Text = this.CurItem.Remarks;
                this.currentIsValid = this.CurItem.IsValid;
                this.skinCmbProperty.SelectedValue = (CostumeProperty)this.CurItem.Property;
                this.selectSizeGroup = new SizeGroupSetting()
                {
                    SizeGroup = CommonGlobalCache.GetSizeGroup(this.CurItem.SizeGroupName),
                    SelectedSizeNames = this.CurItem.SizeNames
                };

                //颜色列表

                if (!String.IsNullOrEmpty(this.CurItem.Colors))
                {
                    String[] colors = this.CurItem.Colors.Split(',');
                    foreach (var item in colors)
                    {
                        ColorList.Add(new ListItem<string>(item, item));
                    }
                    this.dataGridView.DataSource = ColorList;
                }
                try
                {
                    LoadPic();
                }
                catch (Exception ex)
                {
                    GlobalUtil.ShowError(ex);
                }
                //try
                //{
                //    if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                //    CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.LoadPic);
                //    cb.BeginInvoke(null, null);
                //}
                //catch (Exception ex) { GlobalUtil.ShowError(ex); }


            }
            else
            {
                ResetAll();
            }
        }


        /*   private void LoadPic(EmCostumeInfo info)
           {
               try
               {
                   this.titleImageControlWidth1.Clear();

                   if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                   Directory.CreateDirectory(GlobalUtil.EmallDir);
                   if (info != null && info.EmCostumePhotos != null && info.EmCostumePhotos.Count > 0)
                   {

                       Boolean setThumb = false;
                       foreach (var item in info.EmCostumePhotos)
                       {
                           String savePath = GlobalUtil.EmallDir + Path.GetFileName(item.LinkAddress);
                           //item.LinkAddress.Substring(item.LinkAddress.LastIndexOf());
                           //引用前必须释放所有图片文件的使用权
                           Image img = null;
                           try
                           {
                               //if (!File.Exists(savePath))
                               //{
                               //    CosCloud.DownloadFile(CosLoginInfo.BucketName, item.LinkAddress, savePath);
                               //}
                               img = JGNet.Core.ImageHelper.FromFileStream(savePath);
                           }
                           catch (Exception ex)
                           {
                               //下载失败，可能文件被占用，直接使用该文件即可。
                               //文件找不到使用默认图片，找不到
                           }
                           // AddPhoto(new EmCostumePhoto() { Image = img, SavePath = savePath });

                               if (!setThumb)
                               {
                                   item.Thumb = CurItem.EmThumbnail;
                                   setThumb = true;
                               }
                               InsertImage(this.titleImageControlWidth1, item, img);

                       }
                   }

               }
               catch (Exception ex)
               {
                   GlobalUtil.ShowError(ex);
               }
               finally
               {
                   GlobalUtil.UnLockPage(this);
               } 
           }
           */


        private void createImage(EmCostumePhoto emPhoto)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }

                //  Image img = JGNet.Core.ImageHelper.FromFileStream(emPhoto.LinkAddress);



            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }


        private void LoadPic()
        {
            this.titleImageControlWidth1.Clear();
            InteractResult<List<EmCostumePhoto>> result = GlobalCache.ServerProxy.GetCostumePhotoAddressList(this.CurItem?.ID);
            WriteLog("款号id=" + this.CurItem?.ID + "result数量=" + result.Data.Count);
            if (result.ExeResult == ExeResult.Success)
            {
                if (result.Data != null && result.Data.Count > 0)
                {
                    if (result.Data.Count > 9)
                    {
                        //   titleImageControlWidth1.isNoDisplay(); // ctrl.Visible = false;
                    }
                    int count = 0;
                    if (result.Data.Count > 10)
                    {
                        count = 10;
                    }
                    else
                    {
                        count = result.Data.Count;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        if (!Directory.Exists(GlobalUtil.EmallDir))
                        {
                            Directory.CreateDirectory(GlobalUtil.EmallDir);
                            WriteLog("目录创建成功！");
                        }
                        else
                        {
                            WriteLog("目录已存在！");
                        }


                        Boolean setThumb = false;

                        String savePath = GlobalUtil.EmallDir + Path.GetFileName(result.Data[i].LinkAddress);
                        //item.LinkAddress.Substring(item.LinkAddress.LastIndexOf());
                        //引用前必须释放所有图片文件的使用权
                        Image img = null;
                        try
                        {
                            /*  if (!File.Exists(savePath))
                              {
                                  WriteLog("\r\n图片路径：" + result.Data[i].LinkAddress + "\r款号=" + result.Data[i].CostumeID + "\rAutoID=" + result.Data[i].AutoID + "存储桶=" + CosLoginInfo.BucketName + "目录路径savePath=：" + savePath);
                                    CosCloud.DownloadFile(CosLoginInfo.BucketName, result.Data[i].LinkAddress, savePath);

                              }

                              if (!IsImage(savePath))
                              {
                                  WriteLog("\r\n存在非图片路径：" + result.Data[i].LinkAddress + "\r款号=" + result.Data[i].CostumeID + "\rAutoID=" + result.Data[i].AutoID + "存储桶=" + CosLoginInfo.BucketName+ "目录路径savePath=：" + savePath);

                                  continue;
                              }
                              img = JGNet.Core.ImageHelper.FromFileStream(savePath);*/
                            if (!IsCheckImg(result.Data[i].LinkAddress))
                            {
                                WriteLog("\r\n存在非图片路径：" + result.Data[i].LinkAddress + "\r款号=" + result.Data[i].CostumeID + "\rAutoID=" + result.Data[i].AutoID + "存储桶=" + CosLoginInfo.BucketName + "目录路径savePath=：" + savePath);

                                continue;
                            }
                            img = Image.FromStream(System.Net.WebRequest.Create(result.Data[i].LinkAddress).GetResponse().GetResponseStream());
                        }
                        catch (Exception ex)
                        {
                            GlobalUtil.ShowError(ex);

                            WriteLog("Message：" + ex.Message + "StackTrace：" + ex.StackTrace);
                            //下载失败，可能文件被占用，直接使用该文件即可。
                            //文件找不到使用默认图片，找不到
                        }
                        // AddPhoto(new EmCostumePhoto() { Image = img, SavePath = savePath });
                        //if (String.IsNullOrEmpty(emPhoto.ColorName))
                        //{
                        if (!setThumb)
                        {
                            result.Data[i].Thumb = CurItem.EmThumbnail;
                            setThumb = true;
                        }
                        if (result.Data[i].Image == null && img != null)
                        {
                            result.Data[i].Image = img;
                        }
                        else
                        {

                        }
                        /*else
                        {
                            MemoryStream stream = new MemoryStream(emPhoto.Image);
                            Image img1 = new Bitmap(stream);
                            emPhoto.Image = img1;
                        }*/
                        // emPhoto.SavePath = savePath;

                        //emPhoto = new EmCostumePhoto()
                        //{
                        //    Image = img,
                        //    SavePath = savePath,
                        //    Bytes = photo,
                        //    PhotoName = newFileName
                        //};


                        WriteLog("图片颜色=" + result.Data[i].ColorName + "CostumeID=" + result.Data[i].CostumeID + "Image=" + result.Data[i].Image + "");
                        if (result.Data[i] != null)
                        {
                            AddPhoto(result.Data[i]);

                            InsertImage(this.titleImageControlWidth1, result.Data[i], img);
                        }
                        //}
                        //else
                        //{
                        //    InsertImage(this.flowLayoutPanel2, item, img);
                        //}
                    }
                }

            }


        }

        public Boolean IsCheckImg(string path)
        {
            try

            {

                System.Drawing.Image img = Image.FromStream(System.Net.WebRequest.Create(path).GetResponse().GetResponseStream());

                return true;

            }

            catch (Exception e)

            {

                return false;

            }
        }
        /*   private void ShowImage (Image image){
               if (this.InvokeRequired)
               {
                   this.BeginInvoke(new CJBasic.CbGeneric<Image>(this.ShowImage), image);
               }
               else
               {
                   this.pictureBox1.Image = image;
               }
           }
           */
        private void ResetAll()
        {
            this.skinTextBox_ID.Text = string.Empty;
            this.skinTextBox_Name.Text = string.Empty;
            this.numericUpDown_Price.Value = 0;
            this.numericUpDownCostPrice.Value = 0;
            this.skinTextBox_Remarks.Text = string.Empty;
            this.ColorList = new List<ListItem<string>>();
            this.dataGridView.DataSource = null;
            // SetCostumeColor();
            this.photo = null;
            // this.pictureBox1.Image = null;
            this.BaseButton3.Text = "新增";
        }

        private void SaveCostumeManageCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();
            this.titleImageControlWidth1.Upload_Click += Upload_Click;

            titleImageControlWidth1.TitleImageMoveUp += TitleImageMoveUp;
            titleImageControlWidth1.TitleImageMoveDown += TitleImageMoveDown;
        }

        private void Initialize()
        {
            try
            {
                SetYear();
                SetSize();
                setProperty();
                if (CurItem != null)
                {
                    skinComboBox_SupplierID.EnabledSupplier = false;
                }
                else
                {
                    skinComboBox_SupplierID.EnabledSupplier = true;
                }
                SetUpCos();
                SetParameterConfig();
                colorComboBox1.Initialize();
                this.dataGridView.AutoGenerateColumns = false;
                ColorList = new List<ListItem<String>>();
                Display();
                if (!DataGridViewUtil.CheckPerMission(this, RolePermissionMenuEnum.商品档案, RolePermissionEnum.查看_备注))
                {
                    this.skinTextBox_Remarks.Visible = false;
                    this.skinLabel16.Visible = false;
                    isHasPermissionMark = false;
                }
                else
                {

                    this.skinTextBox_Remarks.Visible = true;
                    this.skinLabel16.Visible = true;
                    isHasPermissionMark = true;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void SetSize()
        {
            //skinComboBoxSize.ValueMember = "SizeGroupName";
            //skinComboBoxSize.DisplayMember = "DisplayName";
            //skinComboBoxSize.DataSource = GlobalCache.SizeGroupList?.FindAll(t => t.Enabled);
            //skinComboBoxSize.SelectedItem =
            SizeGroup sizeGroup = GlobalCache.GetSizeGroup(this.CurItem?.SizeGroupName);
            skinLabelSizeGroup.Text = CommonGlobalUtil.GetSizeDisplayNames(sizeGroup, this.CurItem?.SizeNames);
        }


        private List<ListItem<String>> ParameterConfigList(List<ListItem<String>> listItems)
        {
            List<ListItem<String>> list = new List<ListItem<String>>();
            //  list.Add(new ListItem<String>(GlobalCache.COMBOX_FIRST_LINE, null));
            list.AddRange(listItems);
            return list;
        }

        private void SetYear()
        {
            List<ListItem<String>> list = new List<ListItem<String>>();
            //  list.Add(new ListItem<String>(GlobalCache.COMBOX_FIRST_LINE, null));
            List<int> years = YearHelper.GetYearList(DateTime.Now);
            foreach (int item in years)
            {
                list.Add(new ListItem<String>(item.ToString(), item.ToString()));

            }
            this.skinComboBox_Year.DataSource = list;
            this.skinComboBox_Year.DisplayMember = "key";
            this.skinComboBox_Year.ValueMember = "value";


            //默认选择当年
            this.skinComboBox_Year.SelectedValue = DateTime.Now.Year.ToString();

        }
        private void setProperty()
        {
            List<ListItem<CostumeProperty>> stateList = new List<ListItem<CostumeProperty>>();
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.FirstOrder), CostumeProperty.FirstOrder));
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.PursuitOrder), CostumeProperty.PursuitOrder));
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.Buyout), CostumeProperty.Buyout));
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.AgentSell), CostumeProperty.AgentSell));
            this.skinCmbProperty.DisplayMember = "Key";
            skinCmbProperty.ValueMember = "Value";
            skinCmbProperty.DataSource = stateList;
        }

        /// <summary>
        /// 设置系统配置参数信息，品牌、风格、款型
        /// </summary>
        private void SetParameterConfig()
        {
            // this.comboBox_model.Initialize(ParameterConfigKey.CostumeModel, "款型", ParameterConfigList(GlobalCache.GetParameterConfig(ParameterConfigKey.CostumeModel)), "款式");
            // this.skinComboBox_Style.Initialize(ParameterConfigKey.CostumeStyle, "风格", ParameterConfigList(GlobalCache.GetParameterConfig(ParameterConfigKey.CostumeStyle)), "风格");
            // this.skinComboBox_Season.Initialize(ParameterConfigKey.Season, "季节", ParameterConfigList(GlobalCache.GetParameterConfig(ParameterConfigKey.Season)), "季节");
            skinCheckBoxAutoCostPrice.Checked = GlobalCache.GetParameter(ParameterConfigKey.AutoCostPrice).ParaValue == "1";
        }

        Costume item = null;
        private void BaseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                item = GetEntity();
                if (!Validate(item)) { return; }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }

                if (this.CurItem != null)
                {
                    //线上商城原属性不替换
                    //item.EmShowOnline = CurItem.EmShowOnline;
                    //item.EmOnlinePrice = CurItem.EmOnlinePrice;
                    //item.EmTitle = CurItem.EmTitle;
                    //item.EmThumbnail = CurItem.EmThumbnail == null ? string.Empty : CurItem.EmThumbnail;
                    //item.CreateTime = CurItem.CreateTime;
                    // item.Price = CurItem.Price;
                    // item.CostPrice = CurItem.Price;
                    item.SalePrice = numericTextBoxSalePrice.Value;
                    //item.ClassID = CurItem.ClassID;
                    //item.BrandID = CurItem.BrandID;
                    //item.Year = CurItem.Year;
                    //    item.SizeNames = CurItem.SizeNames;

                    EditCostume editCostume = new EditCostume();
                    editCostume.Year = item.Year;
                    editCostume.BrandID = item.BrandID;
                    editCostume.ClassID = item.ClassID;
                    editCostume.Colors = item.Colors;
                    editCostume.CostPrice = item.CostPrice;
                    editCostume.Name = item.Name;
                    editCostume.Price = item.Price;
                    editCostume.Property = (CostumeProperty)item.Property;
                    editCostume.SalePrice = item.SalePrice;
                    editCostume.Season = item.Season;
                    editCostume.SizeGroupName = item.SizeGroupName;
                    editCostume.SizeNames = item.SizeNames;
                    editCostume.SupplierID = item.SupplierID;
                    editCostume.ID = item.ID;
                    if (!isHasPermissionMark) { editCostume.IsFilterRemarks = true; }
                    else
                    {
                        editCostume.IsFilterRemarks = false;
                    }

                    editCostume.Remarks = item.Remarks;



                    RemoveDisposedCostumePhoto();
                    UploadCostumePhoto();
                    SetProgressInfo("正在保存商品信息……");
                    UpdateDisplayIndex();
                    //  ReflectionHelper.CopyProperty(item, editCostume);
                    InteractResult result = GlobalCache.ServerProxy.EditCostume(editCostume);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            //  UploadCostumePhoto(item);
                            GlobalMessageBox.Show("保存成功！");
                            GlobalCache.CostumeList_OnChange(item);
                            CurItem = item;
                            TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    InsertCostumeResult result =
                    GlobalCache.ServerProxy.InsertCostume(item);
                    if (result == InsertCostumeResult.Error)
                    {
                        GlobalMessageBox.Show("内部错误！");
                        return;
                    }
                    else if (result == InsertCostumeResult.Exist)
                    {
                        GlobalMessageBox.Show("该商品已存在！");
                        return;
                    }
                    else
                    {
                        // UploadCostumePhoto(item); 
                        SetProgressVisible(false);
                        GlobalMessageBox.Show("添加成功！");
                        GlobalCache.CostumeList_OnChange(item);
                        // CurItem = item;

                        ResetAll();
                        Costume_Newed?.Invoke(item);
                        //  TabPage_Close(this.CurrentTabPage, this.SourceCtrlType);
                    }

                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        /*  private void UploadCostumePhoto(Costume item)
          {
              //有切换图片//原来有图片被删除了，才更新图片,与该image无关
              if (photo != null)
              {
                  UploadCostumePhotoPara para = new UploadCostumePhotoPara()
                  {
                      ID = item.ID,

                      //从picbox获取bytes
                      Photo = GetPhoto()
                  };
                  GlobalCache.ServerProxy.UploadCostumePhoto(para);

                  CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoNotify);
                  cb.BeginInvoke(null, null);
              }
          }*/

        private void DoNotify()
        {
            try
            {
                //图片保存成功，通知商户网站地址，账套信息，款号
                String response = CommonGlobalUtil.BusinessWebCostumePhotoChangeNotify(CurItem.ID);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private byte[] GetPhoto()
        {

            byte[] photo = null;
            // Image image = this.pictureBox1.Image;
            /*  if (image != null)
              {
                  MemoryStream stream = new MemoryStream();
                  image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                  photo = stream.ToArray();

              }*/
            return photo;
        }

        private bool Validate(Costume item)
        {
            bool success = true;
            if (String.IsNullOrEmpty(item.ID))
            {
                this.skinTextBox_ID.Focus();
                success = false;
                GlobalMessageBox.Show("请输入款号！");
            }
            else if (String.IsNullOrEmpty(item.Name))
            {
                skinTextBox_Name.Focus();
                success = false;
                GlobalMessageBox.Show("请输入名称！");
            }
            else if (String.IsNullOrEmpty(item.Colors))
            {

                colorComboBox1.Focus();
                success = false;
                GlobalMessageBox.Show("请选择颜色！");
            }
            //else if (item.Price == 0)
            //{
            //    numericUpDown_Price.Focus();
            //    success = false;
            //    GlobalMessageBox.Show("价格不能为0！");
            //}
            //else if (item.CostPrice == 0)
            //{
            //    numericUpDownCostPrice.Focus();
            //    success = false;
            //    GlobalMessageBox.Show("进货价不能为0！");
            //}
            else if (String.IsNullOrEmpty(this.skinComboBox_Year.SelectedValue?.ToString()))
            {
                skinComboBox_Year.Focus();
                success = false;
                GlobalMessageBox.Show("请选择年份！");
            }
            else if (String.IsNullOrEmpty(this.skinComboBox_Season.skinComboBox.SelectedValue?.ToString()))
            {
                skinComboBox_Season.skinComboBox.Focus();
                success = false;
                GlobalMessageBox.Show("请选择季节！");
            }
            //else if (String.IsNullOrEmpty(this.skinComboBox_Style.skinComboBox.SelectedValue?.ToString()))
            //{
            //    skinComboBox_Style.skinComboBox.Focus();
            //    success = false;
            //    GlobalMessageBox.Show("请选择风格！");
            //}
            //else if (String.IsNullOrEmpty(this.comboBox_model.skinComboBox.SelectedValue?.ToString()))
            //{
            //    comboBox_model.skinComboBox.Focus();
            //    success = false;
            //    GlobalMessageBox.Show("请选择款型！");
            //}
            //else if (this.skinComboBoxBigClass.SelectedValue.ClassID == -1)
            //{
            //    skinComboBoxBigClass.Focus();
            //    success = false;
            //    GlobalMessageBox.Show("请选择类别！");
            //}
            else if (String.IsNullOrEmpty(this.skinComboBox_SupplierID.SelectedValue?.ToString()))
            {
                skinComboBox_SupplierID.Focus();
                success = false;
                GlobalMessageBox.Show("请选择供应商！");
            }
            else if (String.IsNullOrEmpty(this.skinComboBox_Brand.skinComboBox.SelectedValue?.ToString()))
            {
                skinComboBox_Brand.skinComboBox.Focus();
                success = false;
                GlobalMessageBox.Show("请选择品牌！");
            }
            else if (!string.IsNullOrEmpty(numericUpDown_Price.Text) && Convert.ToDecimal(numericUpDown_Price.Text.ToString()) > Convert.ToDecimal(99999999.99))
            {
                GlobalMessageBox.Show("吊牌价不能大于99999999.99！");
                numericUpDown_Price.Focus();
            }
            else if (!string.IsNullOrEmpty(numericUpDownCostPrice.Text) && Convert.ToDecimal(numericUpDownCostPrice.Text.ToString()) > Convert.ToDecimal(99999999.99))
            {
                GlobalMessageBox.Show("进货价不能大于99999999.99！");
                numericUpDownCostPrice.Focus();
            }
            //949 新增商品售价允许为0，且不提示
            else if (!string.IsNullOrEmpty(numericTextBoxSalePrice.Text) && Convert.ToDecimal(numericTextBoxSalePrice.Text.ToString())>Convert.ToDecimal(99999999.99))
            {
                GlobalMessageBox.Show("售价不能大于99999999.99！");
                numericTextBoxSalePrice.Focus();
            }

            return success;
        }
        private Costume GetEntity()
        {
            Costume item = new Costume();

            item.ID = this.skinTextBox_ID.Text.Trim();
            item.Name = this.skinTextBox_Name.Text.Trim();
            item.Price = this.numericUpDown_Price.Value;
            //20180602增加默认线上价格
            item.EmOnlinePrice = item.Price;
            item.CostPrice = this.numericUpDownCostPrice.Value;
            item.SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBox_SupplierID.SelectedValue);
            item.Property = (byte)(CostumeProperty)this.skinCmbProperty.SelectedValue;
            String brandId = ValidateUtil.CheckEmptyValue(this.skinComboBox_Brand.SelectedValue);
            if (brandId != null)
            {
                item.BrandID = int.Parse(brandId);
            }
            if (!String.IsNullOrEmpty(this.skinComboBox_Year.SelectedValue?.ToString()))
            {
                item.Year = int.Parse(this.skinComboBox_Year.SelectedValue.ToString());
            }
            item.Season = ValidateUtil.CheckEmptyValue(this.skinComboBox_Season.skinComboBox.SelectedValue);
            item.ClassID = this.skinComboBoxBigClass.SelectedValue.ClassID;
            //item.BigClass = this.skinComboBoxBigClass.SelectedValue?.BigClass;
            //item.SmallClass = this.skinComboBoxBigClass.SelectedValue?.SmallClass;
            //item.SubSmallClass = this.skinComboBoxBigClass.SelectedValue?.SubSmallClass;
            //if (item.SmallClass == null)
            //{
            //    item.SmallClass = "";
            //}

            //  item.Models = ValidateUtil.CheckEmptyValue(this.comboBox_model.skinComboBox.SelectedValue);
            //  item.Style = ValidateUtil.CheckEmptyValue(this.skinComboBox_Style.skinComboBox.SelectedValue);
          //  item.Photo = null;//图片不缓存本地
            List<ListItem<String>> colorList = null;
            if (this.dataGridView != null && this.dataGridView.DataSource != null)
            { colorList = (List<ListItem<String>>)this.dataGridView.DataSource; }
            item.Colors = CommonGlobalUtil.GetColorFromGridView(colorList);
            item.Remarks = this.skinTextBox_Remarks.Text.Trim();
            item.IsValid = currentIsValid;


            item.SizeGroupName = selectSizeGroup.SizeGroup.SizeGroupName;

            //  item.SizeGroupName = ValidateUtil.CheckEmptyValue(this.skinComboBoxSize.SelectedValue);
            item.SizeNames = selectSizeGroup.SelectedSizeNames;

            return item;
        }

        public void Refresh(Costume e)
        {
            CurItem = e;
            Display();

        }

        private void skinComboBox_Color_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                List<CostumeColor> listNew = new List<CostumeColor>();
                //  skinComboBox_Brand.Items.Clear();
                SkinComboBox box = (SkinComboBox)sender;
                String str = box.Text;
                foreach (var item in GlobalCache.CostumeColorList)
                {
                    if ((item.ID + item.Name + item.FirstCharSpell).ToUpper().Contains(str.ToUpper()))
                    {
                        listNew.Add(item);
                    }
                }

                if (listNew.Count == 0)
                {
                    listNew = GlobalCache.CostumeColorList;
                }

                box.DataSource = listNew;
                box.Text = str;
                box.SelectionStart = str.Length;
                box.DroppedDown = true;//自动展开下拉框
                box.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void AddColorToListView(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                this.colorComboBox1.Focus();
                return;
            }

            if (!ColorList.Exists(t => t.Key == str))
            {
                this.dataGridView.DataSource = null;
                this.ColorList.Add(new ListItem<string>(str, str));
                this.dataGridView.DataSource = ColorList;
            }

        }

        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = CJBasic.Helpers.FileHelper.GetFileToOpen2("请选择要上传的图片", "提示", ".jpg", ".png", "jpeg", ".bmp");
                if (String.IsNullOrEmpty(path))
                {
                    photo = null;
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                Image img = Image.FromFile(path);
                MemoryStream stream = new MemoryStream();
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                photo = stream.ToArray();

                Image map = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);
                //   this.pictureBox1.Image = map;
                stream = new MemoryStream();
                map.Save(stream, map.RawFormat);
                photo = stream.ToArray();
                if (photo.Length > 2097152)
                {
                    GlobalMessageBox.Show("图片太大，请重新上传！");
                    return;
                }
            }
            catch (OutOfMemoryException ex) { GlobalUtil.ShowError("文件有损坏或内存不足！"); }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    List<ListItem<String>> list = (List<ListItem<String>>)this.dataGridView.DataSource;

                    ListItem<String> item = (ListItem<String>)list[e.RowIndex];
                    switch (this.dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {

                        case "删除":
                            this.dataGridView.DataSource = null;
                            InteractResult result = GlobalCache.ServerProxy.IsCostumeStoreCountZero(this.CurItem.ID, item.Value);
                            switch (result.ExeResult)
                            {
                                case ExeResult.Success:
                                    list.Remove(item);
                                    this.dataGridView.DataSource = list;
                                    break;
                                case ExeResult.Error:
                                    GlobalMessageBox.Show(result.Msg);
                                    this.dataGridView.DataSource = list;
                                    break;
                                default:
                                    break;
                            }

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void skinComboBox_SupplierID_DropDown(object sender, EventArgs e)
        {
            skinComboBox_SupplierID.EnabledSupplier = true;
        }

        private void numericUpDown_Price_ValueChanged(object sender)
        {
            if (skinCheckBoxAutoCostPrice.Checked)
            {
                try
                {
                    decimal discount = 1;

                    List<ListItem<string>> config = GlobalCache.GetParameterConfig(ParameterConfigKey.SupplierDiscount);
                    if (config != null && config.Count > 0)
                    {
                        discount = Convert.ToDecimal(config[0].Value);
                    }

                    numericUpDownCostPrice.Value = Math.Round(numericUpDown_Price.Value * discount, 0, MidpointRounding.AwayFromZero);
                    //  numericTextBoxSalePrice.Value = numericUpDown_Price.Value;
                }
                catch (Exception ex)
                {
                    // GlobalUtil.ShowError(ex);
                }
            }
        }

        private void UploadCostumePhoto()
        {
            try
            {
                if (CostumePhotos != null)
                {
                    bool isMainFlag = false;
                    for (int i = 0; i < CostumePhotos.Count; i++)
                    {

                        EmCostumePhoto photo = CostumePhotos[i];
                        photo.DisplayIndex = i;
                        photo.CostumeID = this.skinTextBox_ID.Text;
                        if (i == 0)
                        {
                            if (photo.ColorName == "")
                            {
                                photo.IsMain = true;
                                isMainFlag = true;
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            if (isMainFlag == false)
                            {
                                if (photo.ColorName == "")
                                {
                                    photo.IsMain = true;
                                    isMainFlag = true;
                                }
                            }
                        }
                        if (String.IsNullOrEmpty(photo.LinkAddress))
                        {
                            //文件重复？提示？缩略图每次都变？？？？
                            if (!String.IsNullOrEmpty(photo.SavePath))
                            {
                                //这里还是要给新图片名称，下面取回来对应过去。才有LINKADDRESS
                                PhotoData para = new PhotoData()
                                {
                                    Datas = photo.Bytes,
                                    EmCostumePhoto = photo,
                                    Name = photo.PhotoName,

                                };
                                EmCostumePhoto EmPhoto = CommonGlobalUtil.UploadPhotoToCos(para, photo.CostumeID);
                                para.EmCostumePhoto = EmPhoto;
                                GlobalCache.ServerProxy.InsertEmCostumePhoto(EmPhoto);
                                //  GlobalCache.ServerProxy.UploadPhotoToCos(para);
                            }
                        }

                        this.BeginInvoke(new CJBasic.CbGeneric<int>(ShowProgress), i);
                    }
                    //重新加载图片获取AUTOID
                    //   EmCostumeInfo info = GetByID(CurItem.ID);
                    /*   foreach (var displayData in CostumePhotos)
                       {
                           foreach (var serverData in info.EmCostumePhotos)
                           {
                               if (displayData.PhotoName == serverData.PhotoName)
                               {
                                   CJBasic.Helpers.ReflectionHelper.CopyProperty(serverData, displayData);
                               }
                           }
                       }*/

                    // GlobalUtil.Debug("得到CostumePhotos：" + CostumePhotos.Count);
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
            finally
            {
                SetProgressVisible(false);
            }
        }
        private void AutoInsertTitleImage()
        {
            try
            {

                byte[] photo = null;

                if (GlobalUtil.EngineUnconnectioned(this)) { return; }

                string strTime = DateTime.Now.ToString();

                Image img = null;
                MemoryStream stream = new MemoryStream();
                photo = stream.ToArray();
                img = JGNet.Core.ImageHelper.GetNewSizeImage(global::JGNet.Manage.Properties.Resources._800, 800);

                stream = new MemoryStream();
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                photo = stream.ToArray();

                Image thumbnailImage = img.GetThumbnailImage(100, 100, null, new IntPtr());
                EmCostumePhoto emCostumePhoto = null;
                String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBox_ID.Text, strTime);
                String savePath = GlobalUtil.EmallDir + newFileName;
                Core.ImageHelper.Compress(img, savePath, 50);
                // imtPath = savePath;
                emCostumePhoto = new EmCostumePhoto()
                {
                    Image = img,
                    SavePath = savePath,
                    Bytes = photo,
                    PhotoName = newFileName
                };

                AddPhoto(emCostumePhoto);
                InsertImage(this.titleImageControlWidth1, emCostumePhoto, thumbnailImage);
                /*  if (sender is FlowLayoutPanel)
                  {
                      InsertImage(sender as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                  }
                  else
                  {
                      InsertImage(ctrl.Parent as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                  }*/


            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }
        private void AddRemovePhotos(EmCostumePhoto item)
        {
            if (RemovePhotos == null)
            {
                RemovePhotos = new List<EmCostumePhoto>();
            }
            RemovePhotos.Add(item);
        }
        /// <summary>
        /// 删除图片的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPic_Disposed(object sender, EventArgs e)
        {
            TitleImageOfCostume pic = sender as TitleImageOfCostume;
            CostumePhotos.Remove(pic.Tag as EmCostumePhoto);
            AddRemovePhotos(pic.Tag as EmCostumePhoto);
        }
        /// <summary>
        /// 添加展示图片使用缩率图
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="emCostumePhoto"></param>
        /// <param name="img"></param>
        private void InsertImage(FlowLayoutPanel flowLayoutPanel, EmCostumePhoto emCostumePhoto, Image img)
        {
            Image thumbnailImage = img?.GetThumbnailImage(100, 100, null, new IntPtr());
            //if (flowLayoutPanel == flowLayoutPanel2)
            //{
            //    //颜色的增加标题
            //    TitleImage colorPic = new TitleImage()
            //    {
            //        Title = emCostumePhoto.ColorName,
            //        Image = thumbnailImage,//ShowDeleteBtn  = true
            //        Tag = emCostumePhoto
            //    };
            //    colorPic.Disposed += ColorPic_Disposed; ;
            //    flowLayoutPanel.Controls.Add(colorPic);
            //}
            //else
            //{

            InsertImage(titleImageControlWidth1, emCostumePhoto, img);
            //}

        }
        private void SetUpCos()
        {
            this.CosLoginInfo = GlobalCache.CosLoginInfo;
            //创建cos对象
            this.CosCloud = new CosCloud(CosLoginInfo.AppID, CosLoginInfo.SecretId, CosLoginInfo.SecretKey);
        }
        /// <summary>
        /// 添加展示图片使用缩率图
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="emCostumePhoto"></param>
        /// <param name="img"></param>
        private void InsertImage(TitleImageControlWidth flowLayoutPanel, EmCostumePhoto emCostumePhoto, Image img)
        {
            Image thumbnailImage = img?.GetThumbnailImage(100, 100, null, new IntPtr());
            TitleImageOfCostume pic = new TitleImageOfCostume()
            {
                Image = thumbnailImage,
                Tag = emCostumePhoto
            };
            pic.Disposed += ColorPic_Disposed;
            flowLayoutPanel.AddTitleImage(pic);

        }
        private void UpdateDisplayIndex()
        {
            try
            {
                if (CostumePhotos != null)
                {
                    List<UpdateDisplayIndex> para = new List<UpdateDisplayIndex>();

                    for (int i = 0; i < CostumePhotos.Count; i++)
                    {
                        CostumePhotos[i].DisplayIndex = i;
                        para.Add(new Core.InteractEntity.UpdateDisplayIndex()
                        {
                            PhotoName = CostumePhotos[i].PhotoName,
                            DisplayIndex = CostumePhotos[i].DisplayIndex
                        });
                    }
                    GlobalCache.ServerProxy.UpdateDisplayIndexs(para);
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 添加图片实体类
        /// </summary>
        /// <param name="photo"></param>
        private void AddPhoto(EmCostumePhoto photo)
        {

            if (CostumePhotos == null) { CostumePhotos = new List<EmCostumePhoto>(); }
            //判断添加方式，有颜色的放后面，以此解决排序上的更改的问题
            if (photo != null)
            {
                if (String.IsNullOrEmpty(photo.ColorName))
                {
                    //将商品详情方最后
                    int index = this.CostumePhotos.FindLastIndex(t => String.IsNullOrEmpty(t.ColorName));
                    this.CostumePhotos.Insert(index + 1, photo);
                }
                else
                {
                    this.CostumePhotos.Add(photo);
                }
                if (photo != null)
                {
                    photo.Image.Tag = photo;
                }
                else
                {
                    WriteLog("photo为空");
                }
            }
        }
        private void SetProgressVisible(bool visible)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<bool>(this.SetProgressVisible), visible);
            }
            else
            {
                if (visible)
                {
                    skinProgressBar1.Value = 0;
                }

                skinLabelProgress.Visible = visible;
                skinProgressBar1.Visible = visible;
            }
        }

        private void SetProgressInfo(String content)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<String>(this.SetProgressInfo), content);
            }
            else
            {
                skinLabelProgress.Visible = true;
                skinLabelProgress.Text = content;
            }
        }
        private void ShowProgress(int i)
        {
            skinProgressBar1.Minimum = 0;
            skinProgressBar1.Maximum = CostumePhotos.Count;
            skinProgressBar1.Value = i + 1;
        }

        private void RemoveDisposedCostumePhoto()
        {

            if (RemovePhotos != null)
            {
                for (int i = 0; i < RemovePhotos.Count; i++)
                {
                    EmCostumePhoto photo = RemovePhotos[i];

                    if (!String.IsNullOrEmpty(photo.LinkAddress))
                    {
                        //删除原来的文件
                        GlobalCache.ServerProxy.DeletePhotoToCos(photo.PhotoName);
                    }
                }

            }
        }
        private void TitleImageMoveUp(TitleImageOfCostume sender, EventArgs e)
        {
            if (sender != null && sender.Tag != null &&
                 sender.Tag is EmCostumePhoto)
            {
                EmCostumePhoto moved = sender.Tag as EmCostumePhoto;
                int index = CostumePhotos.IndexOf(moved);
                if (index > 0)
                {
                    CostumePhotos.Remove(moved);
                    CostumePhotos.Insert(index - 1, moved);
                }
            }
        }
        private void TitleImageMoveDown(TitleImageOfCostume sender, EventArgs e)
        {
            if (sender != null && sender.Tag != null &&
                 sender.Tag is EmCostumePhoto)
            {
                EmCostumePhoto moved = sender.Tag as EmCostumePhoto;
                int index = CostumePhotos.IndexOf(moved);
                if (index < CostumePhotos.Count - 1)
                {
                    CostumePhotos.Remove(moved);
                    CostumePhotos.Insert(index + 1, moved);
                }
            }
        }
        public Boolean IsImage(string path)
        {
            try
            {
                System.Drawing.Image img = System.Drawing.Image.FromFile(path);

                return true;

            }

            catch (Exception e)

            {
                // GlobalUtil.ShowError(e.Message);
                WriteLog("\r\nMessage：" + e.Message + "\rStackTrace：" + e.StackTrace);
                return false;

            }

        }
        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = sender as Control;
                byte[] photo = null;
                if (CostumePhotos != null && CostumePhotos.Count >= 10)
                {
                    GlobalMessageBox.Show("商品图片，最多上传10张！");
                    return;
                }
                string[] paths = CJBasic.Helpers.FileHelper.GetFilesToOpen("请选择要上传的图片");

                if (paths != null)
                {
                    if (CostumePhotos != null && CostumePhotos.Count + paths.Length > 10)
                    {
                        GlobalMessageBox.Show("商品图片，最多上传10张！");
                        return;
                    }
                    if (paths != null)
                    {

                        bool flagHasOtherFile = false;
                        foreach (var checkimg in paths)
                        {
                            if (!IsImage(checkimg))
                            {
                                flagHasOtherFile = true;
                                break;
                            }
                        }
                        if (flagHasOtherFile)
                        {
                            GlobalMessageBox.Show("上传的文件中包含非图片，请确认后再上传！");
                            return;
                        }

                        foreach (var vPath in paths)
                        {
                            String path = vPath;
                            if (String.IsNullOrEmpty(path))
                            {
                                photo = null;
                                return;
                            }

                            if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                            Image img = JGNet.Core.ImageHelper.FromFileStream(path);
                            MemoryStream stream = new MemoryStream();
                            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            photo = stream.ToArray();
                            if (photo.Length > 2097152)
                            {
                                GlobalMessageBox.Show("图片太大，请重新上传！");
                                return;
                            }


                            img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);



                            stream = new MemoryStream();
                            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            photo = stream.ToArray();

                            Image thumbnailImage = img.GetThumbnailImage(100, 100, null, new IntPtr());
                            EmCostumePhoto emCostumePhoto = null;
                            String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBox_ID.Text, Path.GetFileName(path));
                            String savePath = GlobalUtil.EmallDir + newFileName;
                            Core.ImageHelper.Compress(img, savePath, 50);

                            path = savePath;

                            emCostumePhoto = new EmCostumePhoto()
                            {
                                Image = img,
                                SavePath = path,
                                Bytes = photo,
                                CostumeID = this.skinTextBox_ID.Text,
                                PhotoName = newFileName

                            };
                            // GlobalMessageBox.Show("comE：" + CostumePhotos.Count.ToString());
                            emCostumePhoto.Image = img;
                            if (CostumePhotos == null || CostumePhotos.Count <= 9)
                            {
                                AddPhoto(emCostumePhoto);
                                if (CostumePhotos != null && CostumePhotos.Count > 9)
                                {
                                    // ctrl.Visible = false;
                                }
                                if (sender is FlowLayoutPanel)
                                {
                                    InsertImage(sender as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                                }
                                else
                                {
                                    InsertImage(ctrl.Parent as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }


        /*   private void BaseButtonImageRemove_Click(object sender, EventArgs e)
           {
               try
               {
                 //  this.pictureBox1.Image = null;
                   if (this.CurItem != null)
                   {
                       UploadCostumePhoto(this.CurItem);
                   }
               }
               catch (Exception ex) { GlobalUtil.ShowError(ex); }
               finally { GlobalUtil.UnLockPage(this); }
           }*/

        private void skinCheckBoxShowImage_Click(object sender, EventArgs e)
        {
            CountCostprice(true);
        }

        private void CountCostprice(bool count)
        {
            if (count)
            {
                try
                {
                    SupplierDiscountForm addForm = new SupplierDiscountForm();
                    if (skinCheckBoxAutoCostPrice.Checked)
                    {
                        if (addForm.ShowDialog(this.ParentForm) == DialogResult.OK)
                        {
                            decimal discount = addForm.Result;
                            numericUpDownCostPrice.Value = Math.Round(numericUpDown_Price.Value * discount, 0, MidpointRounding.AwayFromZero);
                        }
                    }
                }
                catch (Exception ex) { GlobalUtil.ShowError(ex); }
                finally
                {
                }
            }
        }

        private void skinLabelDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierDiscountForm addForm = new SupplierDiscountForm();
                if (skinCheckBoxAutoCostPrice.Checked)
                {
                    if (addForm.ShowDialog(this.ParentForm) == DialogResult.OK)
                    {
                        decimal discount = addForm.Result;
                        numericUpDownCostPrice.Value = Math.Round(numericUpDown_Price.Value * discount, 0, MidpointRounding.AwayFromZero);
                    }
                }
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
            }
        }

        private void skinCheckBoxAutoCostPrice_CheckedChanged(object sender, EventArgs e)
        {
            GlobalUtil.SaveParameters(ParameterConfigKey.AutoCostPrice, this.skinCheckBoxAutoCostPrice.Checked ? "1" : "0");
            numericUpDown_Price_ValueChanged(null);
        }

        private SizeGroupSetting selectSizeGroup;

        private void baseButton4_Click(object sender, EventArgs e)
        {
            SizeGroupSelectForm size = new SizeGroupSelectForm(selectSizeGroup, skinTextBox_ID.Text);
            size.ShowDialog(this);
            if (size.DialogResult == DialogResult.OK)
            {
                selectSizeGroup = size.Result;
                skinLabelSizeGroup.Text = selectSizeGroup.SelectedDisplaySizeNames;
            }
        }
    }
}
