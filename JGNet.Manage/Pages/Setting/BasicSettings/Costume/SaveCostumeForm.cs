using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Core.MyEnum;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using JGNet.Manage.Model;
using JGNet.Manage.Pages.Setting.BasicSettings.Costume;
using Newtonsoft.Json;
using QCloud.CosApi.Api;
using QCloud.CosApi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SaveCostumeForm :
        BaseForm
    {

        public event Action<Costume> Costume_Newed;
        SaveCostumeFormConfiguration config = null;
        private List<EmCostumePhoto> RemovePhotos { get; set; }
        private List<EmCostumePhoto> CostumePhotos { get; set; }
        public static String CONFIG_PATH = CommonGlobalUtil.AgileConfiguration("Manage.SaveCostumeFormConfiguration");
        private Costume CurItem { get; set; }
        public SaveCostumeForm()
        {
            InitializeComponent();

            new DataGridViewPagingSumCtrl(this.dataGridView).Initialize();
            //   skinComboBox_Brand.SelectedIndexChanged += skinComboBox_Brand_SelectedIndexChanged;
            colorComboBox1.SelectionChangeCommitted += colorComboBox1_SelectionChangeCommitted;

            titleImageControlWidth1.Upload_Click += Upload_Click;
            //同步排序
            titleImageControlWidth1.TitleImageMoveUp += TitleImageMoveUp;
            titleImageControlWidth1.TitleImageMoveDown += TitleImageMoveDown;

            this.Initialize();
            MenuPermission = RolePermissionMenuEnum.商品档案;
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

                return false;

            }

        }
        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = sender as Control;
                byte[] photo = null;
                if (CostumePhotos != null && CostumePhotos.Count  >= 10)
                {
                    GlobalMessageBox.Show("商品图片，最多上传10张！");
                    return;
                }
                string[] paths = CJBasic.Helpers.FileHelper.GetFilesToOpen("请选择要上传的图片");

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
                    if (CostumePhotos != null && CostumePhotos.Count + paths.Length > 10)
                    {
                        GlobalMessageBox.Show("商品图片，最多上传10张！");
                        return;
                    }
                    //if (CostumePhotos.Count + paths.Length > 9)
                    //{
                    //    titleImageControlWidth1.isNoDisplay();
                    //}
                    if (paths != null)
                    {
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
                            img.Save(stream,img.RawFormat);
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
                                    CostumeID=this.skinTextBox_ID.Text,                                     
                                    PhotoName = newFileName
                                };
                            emCostumePhoto.Image = img;
                            if (CostumePhotos == null || CostumePhotos.Count <= 9)
                            {
                                AddPhoto(emCostumePhoto);
                                if (CostumePhotos != null && CostumePhotos.Count > 9)
                                {
                                    //  ctrl.Visible = false;
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

        private void LoadConfig()
        {
            try
            {
                try
                {
                    config = SaveCostumeFormConfiguration.Load(CONFIG_PATH) as SaveCostumeFormConfiguration;
                }
                catch (Exception ex)
                {
                    GlobalUtil.WriteLog(ex);
                }
                if (config == null)
                {
                    config = new SaveCostumeFormConfiguration();

                }
                else
                {
                    if (config.Costume != null)
                    {
                      //  skinComboBox_SupplierID.SelectedValue = config.Costume.SupplierID;
                        skinComboBox_Brand.SelectedValue = config.Costume.BrandID;
                        skinComboBox_Year.SelectedValue = config.Costume.Year.ToString();
                        skinComboBox_Season.skinComboBox.SelectedValue = config.Costume.Season;
                        skinComboBoxBigClass.SelectedValue = config.Costume;
                        //加载上次保存的尺码组信息
                        selectSizeGroup = new SizeGroupSetting();
                        selectSizeGroup.SizeGroup = CommonGlobalCache.GetSizeGroup(config.Costume.SizeGroupName);
                        selectSizeGroup.SelectedSizeNames = config.Costume.SizeNames;
                        skinLabelSizeGroup.Text = selectSizeGroup.SelectedDisplaySizeNames;
                      //  skinCmbProperty.SelectedValue = (CostumeProperty)config.Costume.Property;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
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

        private void Display()
        {
            try
            {
                this.skinTextBox_ID.Text = string.Empty;
                this.skinTextBox_Name.Text = string.Empty;
                this.numericUpDown_Price.Value = 0;
                this.numericUpDownCostPrice.Value = 0;
                this.skinTextBox_Remarks.Text = string.Empty;
                this.ColorList = new List<ListItem<string>>();
                this.dataGridView.DataSource = null;
                this.photo = null;
              //  this.pictureBox1.Image = null;
                this.BaseButton3.Text = "新增";

                this.skinComboBox_SupplierID.HideAll = false;
                this.skinComboBox_SupplierID.Enabled = false;
                 this.skinComboBox_SupplierID.SelectedValue = -1;
                //loadLastSave
                LoadConfig();
                ResetSizeGroupSetting();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private Byte[] photo { get; set; }


        public List<ListItem<String>> ColorList { get; private set; }

      
        private void Initialize()
        {
            try
            {
                SetYear();
                setProperty();
                //  SetSize();
                // AutoInsertTitleImage();

                this.titleImageControlWidth1.Clear();
                if (CurItem != null)
                { //如果是编辑绑定所有显示，点击下拉时变更为有效的供应商选择
                    skinComboBox_SupplierID.EnabledSupplier = false;
                }
                else
                {
                    skinComboBox_SupplierID.EnabledSupplier = true;
                }

                colorComboBox1.Initialize();
                SetParameterConfig();
                this.dataGridView.AutoGenerateColumns = false;

                ColorList = new List<ListItem<String>>();

                Display();
                if (!DataGridViewUtil.CheckPerMission(this, RolePermissionMenuEnum.商品档案,  RolePermissionEnum.查看_备注))
                {
                    this.skinTextBox_Remarks.Visible = false;
                    this.skinLabel16.Visible = false;
                }
                else
                {

                    this.skinTextBox_Remarks.Visible = true;
                    this.skinLabel16.Visible = true;
                }

            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private List<ListItem<String>> ParameterConfigList(List<ListItem<String>> listItems)
        {
            List<ListItem<String>> list = new List<ListItem<String>>();
            //  list.Add(new ListItem<String>(GlobalCache.COMBOX_FIRST_LINE, null));
            list.AddRange(listItems);
            return list;
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
            this.skinCmbProperty.SelectedValue = CostumeProperty.FirstOrder;
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


        /// <summary>
        /// 设置系统配置参数信息，品牌、风格、款型
        /// </summary>
        private void SetParameterConfig()
        {
            skinCheckBoxAutoCostPrice.Checked = GlobalCache.GetParameter(ParameterConfigKey.AutoCostPrice).ParaValue == "1";
        }

        Costume item = null;
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

        private void BaseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                item = GetEntity();
                
                if (!Validate(item)) { return; }
                if (GlobalUtil.EngineUnconnectioned(this))
                { return; }

                RemoveDisposedCostumePhoto();
                UploadCostumePhoto();
                SetProgressInfo("正在保存商品信息……");
                UpdateDisplayIndex();
                if (firstImgUrl != string.Empty)
                {
                    item.EmThumbnail = firstImgUrl;
                }
                InsertCostumeResult result = GlobalCache.ServerProxy.InsertCostume(item);

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
                    //   UploadCostumePhoto(item);
                  
                    GlobalCache.CostumeList_OnChange(item);


                    ///最后一次保存的尺码组和选择的列 


                    //begin 724 商品档案：新增商品后，窗口不要关闭
                    //  this.Hide();
                    //    this.Close();
                    SetProgressVisible(false);
                    ClearNew();
                    if (CostumePhotos != null && CostumePhotos.Count > 0)
                    {
                        CostumePhotos.Clear();
                    }
                    this.titleImageControlWidth1.Clear();
                    GlobalMessageBox.Show("添加成功！");
                    this.skinTextBox_ID.Focus();
                    //end 724 商品档案：新增商品后，窗口不要关闭
                    Costume_Newed?.Invoke(item);




                }
                config.Costume = item;
                config.Save(CONFIG_PATH);
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

        private void ClearNew()
        {
            this.skinTextBox_ID.Text = String.Empty;
            this.skinTextBox_Name.Text = String.Empty;
            this.dataGridView.DataSource = null;
            colorComboBox1.SelectedValue = CommonGlobalUtil.DEFAULT_COLOR_ID;
            ColorList?.Clear();
            // skinLabelSizeGroup.Text = "不选默认为均码";
            ResetSizeGroupSetting();
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
            TitleImage pic = sender as TitleImage;
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
            if (CostumePhotos.Count < 10)
            {
                //判断添加方式，有颜色的放后面，以此解决排序上的更改的问题
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
                photo.Image.Tag = photo;
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
        private void ResetSizeGroupSetting()
        {
            if (config?.Costume != null && String.IsNullOrEmpty(config?.Costume?.SizeNames))
            {
                this.selectSizeGroup = new SizeGroupSetting()
                {
                    SizeGroup = CommonGlobalCache.DefaultSizeGroup,
                    SelectedSizeNames = CostumeSize.F
                };
            }
        }

        /*   private void UploadCostumePhoto(Costume item)
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

        private EmCostumeInfo GetByID(String id)
        {
            EmCostumeInfo result = null;
            try
            {
                GetEmCostumePara infoPara = new GetEmCostumePara()
                {
                    ID = id
                };
                result = GlobalCache.EMallServerProxy.GetEmCostumeInfo(infoPara);
                if (result == null)
                {
                    ShowMessage("找不到该商品！");
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            return result;
        }
        public string firstImgUrl = string.Empty;
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

                        // GlobalCache.ServerProxy.InsertEmCostumePhoto(photo);
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
                                  EmCostumePhoto EmPhoto=CommonGlobalUtil.UploadPhotoToCos(para, photo.CostumeID);
                                  para.EmCostumePhoto = EmPhoto;
                                if (photo.IsMain)
                                {
                                    firstImgUrl = EmPhoto.LinkAddress;
                                }
                                  GlobalCache.ServerProxy.InsertEmCostumePhoto(EmPhoto);
                                 // GlobalCache.ServerProxy.UploadPhotoToCos(para);

                              }
                          }

                        this.BeginInvoke(new CJBasic.CbGeneric<int>(ShowProgress), i);
                    } 
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
      /*  CosCloud VedioCosCloud;

        private EmCostumePhoto UploadPhotoToCos(PhotoData para, string customerID)
        {
            InteractResult<CosCloudSignature> Signatureresult = GlobalCache.ServerProxy.GetCosCloudSignature();
            if (Signatureresult.ExeResult == ExeResult.Success)
            {
                CosCloudSignature cosCloudSignature = Signatureresult.Data;

                VedioCosCloud = new CosCloud(cosCloudSignature.AppID, cosCloudSignature.Signature, 120);


                para.Name = JGNet.Core.ImageHelper.GetNewJpgName(customerID);
                // CosCloud cos = new CosCloud(cosLoginInfo.AppID, cosLoginInfo.SecretId, cosLoginInfo.SecretKey);
                Dictionary<string, string> uploadParasDic = new Dictionary<string, string>();
                uploadParasDic.Add(CosParameters.PARA_BIZ_ATTR, "");
                uploadParasDic.Add(CosParameters.PARA_INSERT_ONLY, "0");
                string result = VedioCosCloud.UploadFile2(cosCloudSignature.BucketName, string.Format("/{0}/{1}", customerID, para.Name),
                    para.Name, para.Datas, uploadParasDic);
                // JObject jObject = (JObject)JsonConvert.DeserializeObject(result);
                ResultJson ResultJ = (ResultJson)JavaScriptConvert.DeserializeObject(result, typeof(ResultJson));
                if (ResultJ.code.ToString() == "0")
                {
                    Data dInfo = ResultJ.data;
                    string source_url = dInfo.source_url.ToString();
                    EmCostumePhoto CurCostmePhotoVideo = new EmCostumePhoto();

                    CurCostmePhotoVideo.LinkAddress = dInfo.source_url;
                    CurCostmePhotoVideo.IsVideo = false;
                    CurCostmePhotoVideo.PhotoName = para.Name;
                    CurCostmePhotoVideo.CostumeID = para.EmCostumePhoto.CostumeID;
                    CurCostmePhotoVideo.DisplayIndex = para.EmCostumePhoto.DisplayIndex;
                     
                    return CurCostmePhotoVideo;
                    //para.LinkAddress = source_url;
                    //???  this.dbManager.DBEmPosterImageService.Insert(para.EmPosterImage);
                }
                else
                {
                    throw new Exception(string.Format("上传【{0}】图片发生错误-【{1}】", para.Name, result));
                }
            }
            return new EmCostumePhoto();
        }*/
        private void DoNotify()
        {
            try
            {
                //图片保存成功，通知商户网站地址，账套信息，款号
                String response = CommonGlobalUtil.BusinessWebCostumePhotoChangeNotify(item.ID);
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
            else if (item.ID.Contains("#"))
            {
                this.skinTextBox_ID.Focus();
                success = false;
                GlobalMessageBox.Show("款号不能使用“#”！");
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
            //else if (item.Price >Convert.ToDecimal(99999999.99))
            //{
            //    numericUpDown_Price.Focus();
            //    success = false;
            //    GlobalMessageBox.Show("价格不能大于99999999.99！");
            //}
            //else if (item.CostPrice > Convert.ToDecimal(99999999.99))
            //{
            //    numericUpDownCostPrice.Focus();
            //    success = false;
            //    GlobalMessageBox.Show("进货价不能大于99999999.99！");
            //}
            //else if (item.SalePrice > Convert.ToDecimal(99999999.99))
            //{
            //     numericTextBoxSalePrice.Focus();
            //    success = false;
            //    GlobalMessageBox.Show("售价不能大于99999999.99！");
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
           /* else if (String.IsNullOrEmpty(this.skinComboBox_SupplierID.SelectedValue?.ToString()))
            {
                skinComboBox_SupplierID.Focus();
                success = false;
                GlobalMessageBox.Show("请选择供应商！");
            }*/
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
           // 949 新增商品售价允许为0，且不提示
            else if (!string.IsNullOrEmpty(numericTextBoxSalePrice.Text) && Convert.ToDecimal(numericTextBoxSalePrice.Text.ToString()) > Convert.ToDecimal(99999999.99))
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
          //  item.EmOnlinePrice = item.Price;
            item.CostPrice = this.numericUpDownCostPrice.Value;
            item.SalePrice = numericTextBoxSalePrice.Value;
            item.SupplierID = ValidateUtil.CheckEmptyValue(this.skinComboBox_SupplierID.SelectedValue);

            String brandId = ValidateUtil.CheckEmptyValue(this.skinComboBox_Brand.SelectedValue);
            if (brandId != null)
            {
                item.BrandID = int.Parse(brandId);
            }
            if (!String.IsNullOrEmpty(this.skinComboBox_Year.SelectedValue?.ToString()))
            {
                item.Year = int.Parse(this.skinComboBox_Year.SelectedValue.ToString());
            }
            item.Property =(byte)(CostumeProperty)this.skinCmbProperty.SelectedValue;
            item.Season = ValidateUtil.CheckEmptyValue(this.skinComboBox_Season.skinComboBox.SelectedValue);
            item.ClassID = this.skinComboBoxBigClass.SelectedValue.ClassID;
          // item.Photo = null;//图片不缓存本地
            List<ListItem<String>> colorList = null;
            if (this.dataGridView != null && this.dataGridView.DataSource != null)
            { colorList = (List<ListItem<String>>)this.dataGridView.DataSource; }
            item.Colors = CommonGlobalUtil.GetColorFromGridView(colorList);
       
            item.Remarks = this.skinTextBox_Remarks.Text.Trim();
            item.IsValid = true;
            item.SizeGroupName = selectSizeGroup.SizeGroup.SizeGroupName;
            item.SizeNames = selectSizeGroup.SelectedSizeNames;
            return item;
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
               // box.Cursor = Cursors.Default;
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
                if (String.IsNullOrEmpty(path))
                {
                    GlobalMessageBox.Show("请选择文件！");
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                Image img = Image.FromFile(path);
                MemoryStream stream = new MemoryStream();
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                photo = stream.ToArray();

                Image map = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);
               // this.pictureBox1.Image = map;
                stream = new MemoryStream();
                map.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
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
                            list.Remove(item);
                            if (list != null && list.Count == 0)
                            {
                                colorComboBox1.SelectedValue = CommonGlobalUtil.DEFAULT_COLOR_ID;
                            }
                            this.dataGridView.DataSource = list;
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
                    numericTextBoxSalePrice.Value = numericUpDown_Price.Value;
                }
                catch (Exception ex)
                {
                    // GlobalUtil.ShowError(ex);
                }
            }
        }

        private void BaseButtonImageRemove_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.pictureBox1.Image = null;
                if (this.CurItem != null)
                {
                  //  UploadCostumePhoto(this.CurItem);
                }
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally { GlobalUtil.UnLockPage(this); }
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

        public void ShowNew(Control parent)
        {
            try
            {
                this.TopMost = true;
                this.ShowDialog(parent);
                //ctrl.Search(para);
                this.TopMost = false;
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void skinTextBox_ID_Leave(object sender, EventArgs e)
        { // 406 新增商品窗口内整改。
          //检查款号是否存在

            //  if (isClose) { return; }
            String costumeID = skinTextBox_ID.Text;
            if (CommonGlobalUtil.CostumeExist(costumeID))
            {
                GlobalMessageBox.Show("款号已存在！");
                skinTextBox_ID.Text = string.Empty;
                skinTextBox_ID.Focus();
            }
        }

        private void skinCheckBoxAutoCostPrice_CheckedChanged(object sender, EventArgs e)
        {
            GlobalUtil.SaveParameters(ParameterConfigKey.AutoCostPrice, this.skinCheckBoxAutoCostPrice.Checked ? "1" : "0");
            numericUpDown_Price_ValueChanged(null);
        }

        private void baseButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            InteractResult result = GlobalCache.ServerProxy.GetAutoCostumeID();
            if (result.ExeResult == ExeResult.Error)
            {
                MessageBox.Show(result.Msg);
            }
            else
            {
                skinTextBox_ID.Text = result.Msg;
            }
        }

        private SizeGroupSetting selectSizeGroup = new SizeGroupSetting()
        {
            SizeGroup = CommonGlobalCache.DefaultSizeGroup,
            SelectedSizeNames = CostumeSize.F
        };
        private void baseButton2_Click(object sender, EventArgs e)
        {
            SizeGroupSelectForm size = new SizeGroupSelectForm(selectSizeGroup, string.Empty);
            size.ShowDialog(this);
            if (size.DialogResult == DialogResult.OK)
            {
                selectSizeGroup = size.Result;
                if (String.IsNullOrEmpty(selectSizeGroup.SelectedDisplaySizeNames))
                {
                }
                else
                {
                    skinLabelSizeGroup.Text = selectSizeGroup.SelectedDisplaySizeNames;
                }
            }
        }
    }
}
