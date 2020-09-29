using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using CJBasic.Widget;
using CJBasic;
using CJBasic.Loggers;
using JGNet.ForManage;
using JGNet.Core.InteractEntity;
 
using CCWin.SkinControl;
using JGNet.Core.Tools;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Common;
using JGNet.Manage.Components;
using JGNet.Core.Dev.InteractEntity;
using JGNet.Common.Core.Util;
using JieXi.Common;
using System.IO;
using NPOI.HSSF.UserModel;
using System.Collections;
using JGNet.Core.MyEnum;
using QCloud.CosApi.Api;

namespace JGNet.Manage

{
    public partial class CostumeManageCtrl : BaseUserControl
    {
        private CostumeListPagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private Costume curCostume;

        public CosLoginInfo CosLoginInfo { get; private set; }
        public CosCloud CosCloud { get; private set; }
        SingleImageForm imageCtrl;
        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }

        public CostumeManageCtrl()
        {
            InitializeComponent();

            MenuPermission =RolePermissionMenuEnum.商品档案;
            //  this.Controls.Add(imageCtrl);
            DateTimeUtil.DateTimePicker_All(dateTimePicker_Start, dateTimePicker_End);
            List<ListItem<IsQueryValid>> stateList = new List<ListItem<IsQueryValid>>();
            stateList.Add(new ListItem<IsQueryValid>(EnumHelper.GetDescription(IsQueryValid.True), IsQueryValid.True));
            stateList.Add(new ListItem<IsQueryValid>(EnumHelper.GetDescription(IsQueryValid.False), IsQueryValid.False));
            stateList.Add(new ListItem<IsQueryValid>(EnumHelper.GetDescription(IsQueryValid.All), IsQueryValid.All));
            skinComboBox_State.DisplayMember = "Key";
            skinComboBox_State.ValueMember = "Value";
            skinComboBox_State.DataSource = stateList;
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click);
            //该行的作用
            dataGridViewPagingSumCtrl.SpecAutoSizeModeColumns(new DataGridViewColumn[] {
            remarksDataGridViewTextBoxColumn });
            dataGridViewPagingSumCtrl.Initialize();
           
        }
        private void setProperty()
        {
            List<ListItem<CostumeProperty>> stateList = new List<ListItem<CostumeProperty>>();
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.All), CostumeProperty.All));
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.FirstOrder), CostumeProperty.FirstOrder));
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.PursuitOrder), CostumeProperty.PursuitOrder));
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.Buyout), CostumeProperty.Buyout));
            stateList.Add(new ListItem<CostumeProperty>(Core.Tools.EnumHelper.GetDescription(CostumeProperty.AgentSell), CostumeProperty.AgentSell));
            this.skinCmbProperty.DisplayMember = "Key";
            skinCmbProperty.ValueMember = "Value";
            skinCmbProperty.DataSource = stateList;
        }
        private void ImageCtrl_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.skinCheckBoxShowImage.Checked = false;
        }

        private void dataGridViewPagingSumCtrl_CurrentPageIndexChanged(int index)
        {
            try
            {
                if (this.pagePara == null)
                {
                    return;
                }
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                pagePara.PageIndex = index;
                CostumeListPage listPage = GlobalCache.ServerProxy.GetCostumeListPage(this.pagePara);

                this.BindingDataSource(listPage);

            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void BaseButton_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                this.skinCheckBoxShowImage.Checked = false;
                this.pagePara.PageIndex = 0;
                this.pagePara.PageSize = this.dataGridViewPagingSumCtrl.PageSize;
                this.pagePara.CostumeID = this.skinTextBoxID.SkinTxt.Text;
                this.pagePara.Season = ((ListItem<String>)this.skinComboBoxSeason.skinComboBox.SelectedItem).Value;
                this.pagePara.BrandID = (this.skinComboBox_Brand.SelectedValue != null && int.Parse(this.skinComboBox_Brand.SelectedValue.ToString()) != -1) ? int.Parse(this.skinComboBox_Brand.SelectedValue.ToString()) : -1;
                this.pagePara.ClassID = skinComboBoxBigClass.SelectedValue.ClassID; 
                //this.pagePara.SubSmallClass = this.skinComboBoxBigClass.SelectedValue?.SubSmallClass;
                this.pagePara.SupplierID = this.skinComboBoxSupplierID.SelectedValue != null ? this.skinComboBoxSupplierID.SelectedValue.ToString() : null;
                //   this.pagePara.Models = this.skinComboBoxModels.SelectedValue != null ? this.skinComboBoxModels.SelectedValue.ToString() : null;
                this.pagePara.Property =(CostumeProperty)this.skinCmbProperty.SelectedValue;
                this.pagePara.StartDate = new Date(dateTimePicker_Start.Value);
                this.pagePara.EndDate = new Date(dateTimePicker_End.Value);
                this.pagePara.IsOpenTime = true;

                if (this.skinComboBoxYear.SelectedValue != null)
                {
                    String year = this.skinComboBoxYear.SelectedValue.ToString();
                    if (!String.IsNullOrEmpty(year))
                    {
                        this.pagePara.Year = int.Parse(year);
                    }
                }
                //  this.pagePara.Style = this.skinComboBoxStyle.SelectedValue != null ? this.skinComboBoxStyle.SelectedValue.ToString() : null;

                /* if (skinCheckBoxOnlyDisable.Checked)
                 {
                     this.pagePara.IsQueryValid = IsQueryValid.False;
                 }
                 else
                 {
                     this.pagePara.IsQueryValid = IsQueryValid.All;
                 }
                 */
                if (this.skinComboBox_State.SelectedValue.ToString() == IsQueryValid.True.ToString())
                {
                    this.pagePara.IsQueryValid = IsQueryValid.True;
                  //  this.DeleteColumn.Visible = false;
                }
                else if (this.skinComboBox_State.SelectedValue.ToString() == IsQueryValid.False.ToString())
                {
                    this.pagePara.IsQueryValid = IsQueryValid.False;
                }
                else
                {
                    this.pagePara.IsQueryValid = IsQueryValid.All;
                }

                CostumeListPage listPage = GlobalCache.ServerProxy.GetCostumeListPage(this.pagePara);
                changeDisplay();
             /*   if (skinCheckBoxOnlyDisable.Checked)
                {
                    Column3.Visible = true;
                    Column2.Visible = false;
                }
                else
                {
                    Column3.Visible = false;
                    Column2.Visible = true;
                }*/
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.BindingDataSource(listPage);

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
        private void changeDisplay()
        {
            switch (this.skinComboBox_State.SelectedValue)
            {
                case IsQueryValid.False:
                    Column3.Visible = true;
                    Column2.Visible = false;
                    break;
                case IsQueryValid.True:
                    Column3.Visible = false;
                    Column2.Visible = true;
                    break;
                default:
                    skinComboBox_State.SelectedValue = IsQueryValid.All;
                    Column3.Visible = true;
                    Column2.Visible = true;
                    break;
            }
        }
        private void BindingDataSource(CostumeListPage listPage)
        {
            this.SetOtherValue(listPage.CostumeList);
            dataGridViewPagingSumCtrl.BindingDataSource(listPage?.CostumeList, null, listPage?.TotalEntityCount);
        }

        /// <summary>
        /// 将集合中GuideName赋值
        /// </summary>
        /// <param name="memberList"></param>
        private void SetOtherValue(List<Costume> list)
        {
            foreach (Costume item in list)
            {
                String name = GlobalCache.GetSupplierName(item.SupplierID);
                item.SupplierName = name;
                item.BrandName = GlobalCache.GetBrandName(item.BrandID);
            }
        }

        private void CostumeManageCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                pagePara = new CostumeListPagePara();
                skinTextBoxID.Text = string.Empty;
               CommonGlobalUtil.SetBrand(this.skinComboBox_Brand);
                CommonGlobalUtil.SetYear(skinComboBoxYear);
                //  CommonGlobalUtil.SetSupplier(skinComboBoxSupplierID);
                setProperty();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            SaveCostumeForm form = new SaveCostumeForm();
            form.Costume_Newed += Form_Costume_Newed;
            form.ShowNew(this);
        }

        private void Form_Costume_Newed(Costume obj)
        {
            this.RefreshPage();
        }

        public event CJBasic.Action<Costume, BaseUserControl> OpenModifyDialog;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (GlobalUtil.EngineUnconnectioned(this))
                    { return; }
                    List<Costume> list = (List<Costume>)this.dataGridView1.DataSource;
                    Costume item = (Costume)list[e.RowIndex];
                    if (e.ColumnIndex == ColumnPrintBarcode.Index) {
                        this.PrintBarCode(item);
                    }
                    else if (e.ColumnIndex == Column1.Index)
                    {//编辑
                        this.OpenModifyDialog(item, this);
                    }
                    else if (e.ColumnIndex == DeleteColumn.Index)
                    {
                        if (GlobalMessageBox.Show("确定删除该商品吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            InteractResult resultCancel = GlobalCache.ServerProxy.DeleteCostume(item.ID);
                            switch (resultCancel.ExeResult)
                            {
                                case ExeResult.Success:
                                    GlobalMessageBox.Show("删除成功！");
                                    GlobalCache.CostumeList_OnRemove(item);
                                    RefreshPage();
                                    break;
                                case ExeResult.Error:
                                    GlobalMessageBox.Show(resultCancel.Msg);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else if (e.ColumnIndex == Column2.Index)
                    {  //判断库存 
                        UpdateCostumeValidPara para = new UpdateCostumeValidPara()
                        {
                            CostumeID = item.ID,
                            IsValid = false
                        };
                        InteractResult result = GlobalCache.ServerProxy.UpdateCostumeValid(para);
                        switch (result.ExeResult)
                        {
                            case ExeResult.Success:
                                GlobalMessageBox.Show("禁用成功！");
                                item.IsValid = false;
                                GlobalCache.CostumeList_OnChange(item);
                                RefreshPage();
                                break;
                            case ExeResult.Error:
                                GlobalMessageBox.Show(result.Msg);
                                break;
                            default:
                                break;
                        }
                    }
                    else if (e.ColumnIndex == Column3.Index)
                    {
                        UpdateCostumeValidPara paraCancel = new UpdateCostumeValidPara()
                        {
                            CostumeID = item.ID,
                            IsValid = true
                        };
                        InteractResult resultCancel = GlobalCache.ServerProxy.UpdateCostumeValid(paraCancel);
                        switch (resultCancel.ExeResult)
                        {
                            case ExeResult.Success:
                                GlobalMessageBox.Show("取消禁用成功！");
                                item.IsValid = true;
                                GlobalCache.CostumeList_OnChange(item);
                                RefreshPage();
                                break;
                            case ExeResult.Error:
                                GlobalMessageBox.Show(resultCancel.Msg);
                                break;
                            default:
                                break;
                        }
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

        private void PrintBarCode(Costume item)
        {
            //弹出选择窗口
            PrintBarcodeForm form = new PrintBarcodeForm(item);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                WebResponseObj<BarCode4CostumeInfo> result = CommonGlobalCache.ServerProxy.GetBarCode4Costume(form.Result);
                CostumeBarcodePrinter printer = new CostumeBarcodePrinter();
                printer.Print(result.Data, form.Result.Times);
            }
        }

        private void skinCheckBoxShowImage_CheckedChanged(object sender, EventArgs e)
        {
           
            if (skinCheckBoxShowImage.Checked)
            {
                dataGridView1_SelectionChanged(sender, e);
            }
            else
            {
                imageCtrl?.Close();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    if (GlobalUtil.EngineUnconnectioned(this))
                    {
                        return;
                    }

                    Costume item = (Costume)dataGridView1.CurrentRow.DataBoundItem;
                    if (curCostume != item && skinCheckBoxShowImage.Checked)
                    {
                        if (imageCtrl != null)
                        {
                            imageCtrl?.Close();
                            imageCtrl = null;
                        }
                        imageCtrl = new SingleImageForm();
                        skinCheckBoxShowImage.CheckedChanged -= skinCheckBoxShowImage_CheckedChanged;
                        skinCheckBoxShowImage.Checked = true;
                        skinCheckBoxShowImage.CheckedChanged += skinCheckBoxShowImage_CheckedChanged;

                        imageCtrl.FormClosing += ImageCtrl_FormClosing;
                        imageCtrl.Text = "款号：" + item.ID;
                        imageCtrl.OnLoadingState();
                        Image img = null;
                        //InteractResult<string> result = GlobalCache.ServerProxy.GetMainCostumePhotoAddress(item.ID);
                        // if (result.ExeResult == ExeResult.Success)
                        // {
                        //     String savePath = GlobalUtil.EmallDir + Path.GetFileName(result.Data);

                        try
                        {
                            /*  if (!File.Exists(savePath))
                              {
                                  CosCloud.DownloadFile(CosLoginInfo.BucketName, result.Data, savePath);
                              }
                              img = JGNet.Core.ImageHelper.FromFileStream(savePath);*/
                            if (item.EmThumbnail != null)
                            {
                                String url = item.EmThumbnail;
                                System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                                System.Net.WebResponse webres = webreq.GetResponse();
                                using (System.IO.Stream stream = webres.GetResponseStream())
                                {
                                    img = Image.FromStream(stream);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            //下载失败，可能文件被占用，直接使用该文件即可。
                            //文件找不到使用默认图片，找不到
                        }
                        //}
                            if (img != null)
                            {
                                imageCtrl.Image = img;
                            }
                            else
                            {
                                imageCtrl.Image = null;
                            }
                            imageCtrl?.BringToFront();
                            imageCtrl?.Show();
                            curCostume = item;
                        
                    }
                }
                catch (Exception ex)
                {
                  //  GlobalUtil.ShowError(ex);
                }
                finally
                {
                    GlobalUtil.UnLockPage(this);
                }
            }
        }

        private void skinTextBoxID_CostumeSelected(Costume obj, bool isEnter)
        {
            if (isEnter)
            {
                if (imageCtrl != null)
                {
                    imageCtrl.Text = "该商品没有图片";
                    imageCtrl.Image = null;
                }
                this.pagePara.IdAccurate = true;
                this.BaseButton_Search_Click(null, null);
                this.pagePara.IdAccurate = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!ReportShowZero)
            {
                DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
            }
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return; }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Costume costume = (Costume)row.DataBoundItem;

            if (Column2.Index == e.ColumnIndex)
            {
                e.Value = costume.IsValid ? "禁用" : String.Empty;
            }
            else if (DeleteColumn.Index == e.ColumnIndex)
            {
                e.Value = !costume.IsValid ? "删除" : String.Empty;
            }
             else if (Column3.Index == e.ColumnIndex)
             {
                 e.Value = !costume.IsValid ? "取消禁用" : String.Empty;
             }
        }

      

        private String path;
        private void baseButtonImport_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetFileToOpen("请选择导入文件");
            if (String.IsNullOrEmpty(path))
            {
                return;
            }


            string fileExt = Path.GetExtension(path);
            if (fileExt != ".xlsx" && fileExt != ".xls")
            {
                ShowMessage("你所选择文件格式不正确，请重新上传文件！");
                return;
            }
            if (GlobalMessageBox.Show("是否开始导入" + System.IO.Path.GetFileName(path), "友情提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                path = null;
                return;
            }
          /*  if (NPOIHelper.IsFileInUse(path))
            {
                ShowMessage("你所选择文件已被打开，请关闭后再重新导入！");
                return;
            }*/

            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoImport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) {
                GlobalUtil.ShowError(ex); }

        }
        private List<EmCostumePhoto> ExcelToImage(string sourcePath, string savepath)
        {
            List<EmCostumePhoto> listPhotos = new List<EmCostumePhoto>();
            try
            {
                using (FileStream fsReader = File.OpenRead(path))
                {
                    HSSFWorkbook wk = new HSSFWorkbook(fsReader);
                    IList pictures = wk.GetAllPictures();
                    int i = 0;
                    foreach (HSSFPictureData pic in pictures)
                    {
                        EmCostumePhoto cutPhoto = new EmCostumePhoto();

                     

                        //if (pic.Data.Length == 19504) //跳过不需要保存的图片，其中pic.data有图片长度
                        //    continue;
                        string ext = pic.SuggestFileExtension();//获取扩展名
                        string path = string.Empty;
                         byte[] photo = null;
                        Image img=null;
                        if (ext.Equals("icon") || ext.Equals("jpeg") || ext.Equals("bmp") || ext.Equals("gif") || ext.Equals("png"))
                        {
                                
                             img = Image.FromStream(new MemoryStream(pic.Data));//从pic.Data数据流创建图片
                            
                            path = Path.Combine(savepath, string.Format("pic{0}." + ext, i++));
                            img.Save(path);//保存
                           photo = pic.Data;
                            
                         //   ShowMessage(pic.Data.Length.ToString());
                         

                        }
                        img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);



                        MemoryStream stream = new MemoryStream();
                        img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        photo = stream.ToArray();

                        Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                        EmCostumePhoto emCostumePhoto = null;
                        String newFileName = JGNet.Core.ImageHelper.GetNewFileName(Path.GetFileName(path));
                        String savePath = GlobalUtil.EmallDir + newFileName;
                        Core.ImageHelper.Compress(img, savePath, 50);

                        path = savePath;

                        emCostumePhoto = new EmCostumePhoto()
                        {
                            Image = img,
                            SavePath = path,
                            Bytes = photo,
                           // CostumeID = this.skinTextBox_ID.Text,
                            PhotoName = newFileName
                        };
                        emCostumePhoto.Image = img;


                      //  cutPhoto.Photo = photo;
                        listPhotos.Add(emCostumePhoto); ;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;

            }
            return listPhotos;
        }

                /// <summary>
                /// 导入数据
                /// </summary>
                private void DoImport()
        {
            try
            {


                List<Costume> emptyStore = new List<Costume>();
                List<Costume> stores = new List<Costume>();
                List<Costume> repeatItems = new List<Costume>();
                DataTable dt = NPOIHelper.FormatToDatatable(path, 0);
                List<int> NoNullRows = new List<int>(); //必填项不为空集合
                List<int> IDRepeatRows = new List<int>(); //款号重复集合
                List<int> ErrorSizeRows = new List<int>(); //尺码格式不正确
                List<int> ErrorGroupNameRows = new List<int>(); //尺码组名称不存在
                List<int> ErrorIdOrName = new List<int>(); //款号或名称长度不正确

                List<EmCostumePhoto> listPhoto = ExcelToImage(path, GlobalUtil.EmallDir);
                
                #region //数据处理
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                      
                    DataRow row = dt.Rows[i];
                    int index = 0;
                    Costume store = new Costume();
                    try
                    {
                        if (!ImportValidate(row))
                        {
                            //款号 商品名称    颜色名称（使用逗号分隔）	吊牌价 成本价 售价 品牌  供应商名称 年份  季节 类别编码    尺码组名称 含有的尺码（使用逗号分隔）	备注
                            
                            store.ID = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Name = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Colors = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Price = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.CostPrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.SalePrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.EmOnlinePrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.PfOnlinePrice = CommonGlobalUtil.ConvertToDecimal(row[index++]);
                            store.BrandName = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SupplierName= CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Year = CommonGlobalUtil.ConvertToInt32(row[index++]);
                            store.Season= CommonGlobalUtil.ConvertToString(row[index++]);
                            // Image image =(Image) row[index++];
                           
                            // store.ClassCode = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.BigClass= CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SmallClass = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SubSmallClass = CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SizeGroupName= CommonGlobalUtil.ConvertToString(row[index++]);
                            store.SizeNames= CommonGlobalUtil.ConvertToString(row[index++]);
                            store.Remarks= CommonGlobalUtil.ConvertToString(row[index++]);
                            //图片放最后面
                            index++;
                            int curRow = i + 2;
                            if (String.IsNullOrEmpty(store.ID) || String.IsNullOrEmpty(store.Name) || String.IsNullOrEmpty(store.Colors) || String.IsNullOrEmpty(store.SizeGroupName) || String.IsNullOrEmpty(store.SizeNames))
                            {
                                //必填项为空
                                // emptyStore.Add(store);
                                NoNullRows.Add(curRow);
                                continue;
                            }
                            else
                            {
                               /* if (store.ID.Length > 50 || store.Name.Length > 50)
                                {
                                    ErrorIdOrName.Add(curRow);
                                    continue;
                                }*/
                                //判断尺码组以及尺码是否格式正确 CommonGlobalCache.SizeGroupList
                                List<SizeGroup> SizeGroupList = CommonGlobalCache.SizeGroupList;
                              
                                int isNoGName = 0;
                                foreach (var sGroup in SizeGroupList)
                                {
                                    if (sGroup.ShowName == store.SizeGroupName)  //尺码组名称存在
                                    {
                                        //判断尺码格式是否正确  M,S,XL  
                                        //sGroup.NameOfF
                                        String[] tempSizeList = store.SizeNames.Split(',');
                                        if (tempSizeList != null)
                                        {
                                            bool isRight = true; //当前尺码是否格式完全正确
                                            for (int t = 0; t < tempSizeList.Length; t++)
                                            {
                                                if (tempSizeList[t] == sGroup.NameOfF || tempSizeList[t] == sGroup.NameOfL ||
                                                    tempSizeList[t] == sGroup.NameOfM || tempSizeList[t] == sGroup.NameOfS ||
                                                    tempSizeList[t] == sGroup.NameOfXL || tempSizeList[t] == sGroup.NameOfXL2 ||
                                                     tempSizeList[t] == sGroup.NameOfXL3 || tempSizeList[t] == sGroup.NameOfXL4 ||
                                                     tempSizeList[t] == sGroup.NameOfXL5 || tempSizeList[t] == sGroup.NameOfXL6 ||
                                                     tempSizeList[t] == sGroup.NameOfXS)
                                                {
                                                    //逗号分隔后当前尺码跟数据库尺码匹配
                                                }
                                                else
                                                {
                                                    isRight = false; //当前含有的尺码有错误的格式
                                                    ErrorSizeRows.Add(curRow);
                                                    continue;
                                                }
                                            }
                                            if (isRight == false)
                                            {
                                                continue; //跳出循环，正确的尺码组没有正确的尺码
                                            }
                                        }
                                        else
                                        {

                                            ErrorSizeRows.Add(curRow);   //格式不正确，没有尺码

                                        }
                                    }
                                    else
                                    {
                                        isNoGName++;
                                        if (isNoGName == SizeGroupList.Count)
                                        {
                                            ErrorGroupNameRows.Add(curRow);   //尺码组不存在，格式不正确
                                        }
                                    }
                                }

                                //判断是否重复款号
                                if (stores.Find(t => t.ID == store.ID ) != null)
                                  {
                                      IDRepeatRows.Add(curRow);
                                      continue;
                                  }

                                  stores.Add(store);
                            }
                        }
                    }
                    //catch (IOException ex)
                    //{
                    //    ShowMessage(ex.Message);
                    //}
                    catch (Exception ex)
                    {

                    }
                }
                #endregion


                #region  //数据检验
                if (NoNullRows.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in NoNullRows)
                    {
                        str += "第" + item  + "行\r\n";
                    }
                    ShowError("必填项没有填写，请补充完整！\r\n" + str);
                    return;
                }
                if (ErrorIdOrName.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in ErrorGroupNameRows)
                    {
                        str += "第" + item + "行" + "\r\n";
                    }
                    ShowError("款号超过50个字符或商品名称超过50个汉字，请检查列表信息！\r\n" + str);
                    return;
                }
                 if (IDRepeatRows.Count > 0)
                 {
                     String str = string.Empty;
                     foreach (var item in IDRepeatRows)
                     {
                         str += "第" + item + "行" + "\r\n";
                     }
                     ShowError("重复的款号，系统已过滤，详见错误报告！\r\n" + str);
                     //  return;
                 }

                if (ErrorGroupNameRows.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in ErrorGroupNameRows)
                    {
                        str += "第" + item + "行" + "\r\n";
                    }
                    ShowError("尺码组不存在，请检查列表信息！\r\n" + str);
                    return;
                }

                if (ErrorSizeRows.Count > 0)
                {
                    String str = string.Empty;
                    foreach (var item in ErrorSizeRows)
                    {
                        str += "第" + item + "行" + "\r\n";
                    }
                    ShowError("尺码不存在或尺码格式错误，请检查列表信息！\r\n" + str);
                    return;
                }

                if (stores != null && stores.Count > 0)
                 {
                    if (stores.Count == listPhoto.Count)
                    {

                    }
                    else
                    {
                        
                        if (GlobalMessageBox.Show("导入的数据和图片不对应，如果导入会影响到导入的图片与款号不对应，是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            return;
                        }
                         
                    }
                 }
                 else
                 {
                     ShowMessage("没有数据可以导入，请检查列表信息！");
                     return;
                 }

                #endregion

                path = null;


                #region  //数据录入
                InteractResult result = GlobalCache.ServerProxy.ImportCostumes(stores);
                  switch (result.ExeResult)
                  {
                      case ExeResult.Error:
                          GlobalMessageBox.Show(result.Msg);
                          break;
                      case ExeResult.Success:
                          foreach (var item in stores)
                          {
                              Costume costume = CommonGlobalCache.GetCostume(item.ID);
                              if (costume != null)
                              {
                                //重新给商品名称  
                                //ShowMessage(item.ID);
                                  item.Name = costume.Name;
                              }
                          }

                        for (int i = 0; i < stores.Count; i++)
                        {
                            if (listPhoto.Count > 0 && listPhoto.Count>i)
                            {
                                listPhoto[i].CostumeID = stores[i].ID;
                                 
                                //这里还是要给新图片名称，下面取回来对应过去。才有LINKADDRESS
                                PhotoData para = new PhotoData()
                                {
                                    Datas = listPhoto[i].Bytes,
                                    EmCostumePhoto = listPhoto[i],
                                    Name = listPhoto[i].PhotoName,
                                     
                                };
                                GlobalCache.ServerProxy.UploadPhotoToCos(para);

                                /* GlobalCache.ServerProxy.UploadCostumePhoto(new UploadCostumePhotoPara()
                                 {

                                     ID = stores[i].ID,
                                     Photo = listPhoto[i].Photo,

                                 });*/
                            }
                            
                        }
                         // AddItems4Display(stores);

                          ShowMessage("导入成功！");
                          break;
                      default:
                          break;
                  }

                #endregion

            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                UnLockPage();
            }
        }
    

        private bool ImportValidate(DataRow row)
        {    //
            bool unValidate = true;
            for (int i = 0; i < 22; i++)
            {
                String value = CommonGlobalUtil.ConvertToString(row[i]);
                if (!String.IsNullOrEmpty(value))
                {
                    //有值
                   // ShowMessage(value);
                    unValidate = false;
                    break;
                }

            }
            return unValidate;
        }

        private void baseButtonDownTemplate_Click(object sender, EventArgs e)
        {

        }

        private void baseButton2_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetPathToSave("保存文件", "商品档案" + new Date(DateTime.Now).ToDateInteger() + ".xls", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
            if (String.IsNullOrEmpty(path))
            {
                return;
            }

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }

                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoExport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex) { CommonGlobalUtil.ShowError(ex); }
        }

        private void DoExport()
        {
            try
            {
                if (dataGridView1.DataSource != null && dataGridView1.Rows.Count > 0)
                {
                    List<Costume> list = (List<Costume>)this.dataGridView1.DataSource;
                    List<String> keys = new List<string>();
                    List<String> values = new List<string>();
                    foreach (DataGridViewColumn item in dataGridView1.Columns)
                    {
                        if (item.Visible)
                        {
                            if (item.Name != "ColumnPrintBarcode" && item.Name != "DeleteColumn" && item.Name != "Column2" && item.Name != "Column1" && item.Name != "Column3")
                            {
                                keys.Add(item.DataPropertyName);
                                values.Add(item.HeaderText);
                            }





                        }
                    }



                    NPOIHelper.Keys = keys.ToArray();
                    NPOIHelper.Values = values.ToArray();
                    NPOIHelper.ExportExcel(DataGridViewUtil.ToDataTable(list), path);

                    GlobalMessageBox.Show("导出完毕！");
                }
            }
            catch (Exception ex)
            { ShowError(ex); }
            finally
            {
                UnLockPage();
            }
        }
    }

}
