using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.Dev.InteractEntity;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using JGNet.Core.Util;
using CJBasic;
using QCloud.CosApi.Api;
using QCloud.CosApi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

using System.Windows.Forms;
using static CCWin.SkinControl.SkinChatRichTextBox;

namespace JGNet.Manage.Components
{
    public partial class SaveEmCostumeForm :
        BaseForm
    {
        public event Action<EmCostumeInfo> Costume_Save;
        private EmCostumeInfo CurItem { get; set; }
        private List<EmCostumePhoto> CostumePhotos { get; set; }
        private List<EmCostumePhoto> RemovePhotos { get; set; }
        public CosLoginInfo CosLoginInfo { get; private set; }
        private List<EmCostumePhoto> CostumeOfTitlePhotos { get; set; }
        public CosCloud CosCloud { get; private set; }
        String editID;
        private bool isEdit;
        decimal customerPrice;
        public SaveEmCostumeForm(String id, bool isEdit, decimal price)
        {
            InitializeComponent();
            editID = id;
            customerPrice = price;
            this.isEdit = isEdit;
            titleImageControl.Upload_Click += Upload_Click;
            //同步排序
            titleImageControl.TitleImageMoveUp += TitleImageMoveUp;
            titleImageControl.TitleImageMoveDown += TitleImageMoveDown;
            this.Initialize();
            if (isEdit)
            {
                baseButton2.Visible = true;
                BaseButton3.Visible = false;
                //this.txtOnlinePrice.Value = customerPrice;
                //Costume cItem = CommonGlobalCache.GetCostume(id);
                //this.numericTextBoxPfPrice.Value = cItem.PfPrice;
                //this.numericTextBoxOnlinePrice.Value = cItem.SalePrice;
                //this.skinTextBoxTitle.Text = cItem.Name;
              
               // ShowMessage(DefaultCommissionTemplate.ToString());
               this.skinComboBoxCommTemp.SelectedValue = DefaultCommissionTemplate; 
            }
            else
            {
                baseButton2.Visible = false;
                BaseButton3.Visible = true;
            }

            skinTextBoxID.Enabled = false;
             LoadCostume();
        }

        private void TitleImageMoveUp(TitleImage sender, EventArgs e)
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
        private void TitleImageMoveDown(TitleImage sender, EventArgs e)
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

        private void SetTemplate(int CarriageTemplateID)
        {
            try
            {
                //如果标题为空，那么这个产品未上架，则读取上一次上架之后保存的模板状态  
                EmCarriageCostTemplate template = null; 
                if (CarriageTemplateID != 0)
                {
                    CarriageCost cost = GlobalCache.EMallServerProxy.GetCarriageCost(CarriageTemplateID);
                    template = cost.CarriageCostTemplate;
                }


                if (template == null || template.AutoID == 0)
                {
                    skinCheckBox_State.Checked = true;
                }
                else
                {
                    skinCheckBox_State.Checked = false;
                    costumeTextBox1_ResultSelected(template);
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
        public void ShowDialog(EmCostumeManageCtrl emManage)
        {
            this.Show(emManage);
            
            Display(true);
        }
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

        public void Display(Boolean enableID = false)
        {
            
                ResetAll();
            
            if (CurItem != null)
            {
                skinTextBoxID.Enabled = enableID;
                skinComboBoxBigClass.SelectedValue = GlobalCache.GetCostume(CurItem.ID);
                skinTextBoxID.Text = CurItem.ID;
                skinTextBox_Name.Text = CurItem.Name;
                skinTextBoxTitle.Text = CurItem.EmTitle;
                rtfRichTextBox_Detail.Text = CurItem.EmDetails;
                numericTextBoxOnlinePrice.Value = CurItem.EmOnlinePrice;
                txtOnlinePrice.Value = CurItem.EmPrice;
                skinCbxNew.Checked = CurItem.IsNew;
                skinCbxHot.Checked = CurItem.IsHot;
                if (!isEdit)
                {
                    this.skinComboBoxCommTemp.SelectedValue = CurItem.CommissionTemplateID;
                    if (CurItem.PfShowOnline && !isEdit)
                    {
                        this.skinCheckBoxPF.Checked = true;
                    }
                    else
                    {
                        this.skinCheckBoxPF.Checked = false;
                    }
                    if (CurItem.EmShowOnline && !isEdit)

                    {
                        this.skinCheckBoxSale.Checked = true;
                    }
                    else
                    {
                        this.skinCheckBoxSale.Checked = false;
                    }
                }
                else
                {
                    this.skinCheckBoxPF.Checked = true;
                    this.skinCheckBoxSale.Checked = true;
                }
                //if (!CurItem.EmEverOnline && !CurItem.PfEverOnline)
                //{
                //    numericTextBoxOnlinePrice.Value = customerPrice;
                //}
                numericTextBoxPfPrice.Value = CurItem.PfOnlinePrice;
               /* if (isEdit)
                {
                   
                }
                else
                {
                  
                }*/
                //  panelSync.Visible = !CurItem.PfShowOnline && CommonGlobalCache.BusinessAccount.OnlinePfEnabled;
                try
                {
                    config = EmCarriageCostTemplateAgileConfiguration.Load(CONFIG_PATH) as EmCarriageCostTemplateAgileConfiguration;
                }
                catch (Exception ex)
                {
                    GlobalUtil.WriteLog(ex);
                }
                if (config == null)
                {
                    config = new EmCarriageCostTemplateAgileConfiguration()
                    {
                        EmCarriageCostTemplate = new EmCarriageCostTemplate()
                    };
                }
                if (CurItem.CarriageCostTemplateID == 0)
                {

                    if (!isEdit)
                    {
                        template = config.EmCarriageCostTemplate;
                        if (template == null || template.AutoID == 0)
                        {
                            skinCheckBox_State.Checked = true;
                        }
                        else
                        {
                            skinCheckBox_State.Checked = false;
                            costumeTextBox1_ResultSelected(template);
                        }
                    }
                    else
                    {
                        skinCheckBox_State.Checked = true;
                    }
                }
                else
                {
                    skinComboBoxTemplate.SelectedValue = CurItem.CarriageCostTemplateID;
                    skinCheckBox_State.Checked = false;
                }

                this.CurItem.EmCostumePhotos.Sort((x, y) =>
                {
                    int sort = x.DisplayIndex.CompareTo(y.DisplayIndex);
                    return sort;
                });
                //根据displayindex排序
                // CostumePhotos = CurItem.EmCostumePhotos;
                //图片
                DateTime start = DateTime.Now;
                LoadPic(CurItem);  
                DateTime endtime = DateTime.Now;
                TimeSpan span = (TimeSpan)(endtime - start);

                WriteLog("图片加载开始时间：" + start + " 结束时间：" + endtime + " 总耗时数：" + span.TotalSeconds + "秒");
                List<EmCostumePhoto> videolist = CurItem.EmCostumePhotos.FindAll(t => t.IsVideo == true);
                if (videolist.Count > 0)
                {
                    this.txtVideo.SkinTxt.Text = videolist[0].LinkAddress;
                    SourceVideoName = videolist[0].PhotoName;
                    SourceVideoInfo = videolist[0];
                    this.baseButtonChooseFile.Text = "删除视频";
                }
            }
        }
        private EmCostumePhoto SourceVideoInfo = null;
        private string SourceVideoName = string.Empty;
        EmCarriageCostTemplateAgileConfiguration config;

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
        private void LoadPic(EmCostumeInfo info)
        {
            try
            {
                this.titleImageControl.Clear();
                flowLayoutPanel2.Controls.Clear();
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                if (!Directory.Exists(GlobalUtil.EmallDir))
                {
                    Directory.CreateDirectory(GlobalUtil.EmallDir);
                    WriteLog("目录创建成功！");
                }
                else
                {

                    WriteLog("目录已存在！");
                }

                if (info != null && info.EmCostumePhotos != null && info.EmCostumePhotos.Count > 0)
                {

                    Boolean setThumb = false;
                    int titleCount = 0, colorCount = 0;
                    List<EmCostumePhoto> titleEmCostumePhoto = new List<EmCostumePhoto>();
                    List<EmCostumePhoto> imagelist = info.EmCostumePhotos.FindAll(t => t.IsVideo == false);

                    DateTime start = DateTime.Now;
                    foreach (var item in imagelist)
                    {

                        DateTime startOne = DateTime.Now;
                        // String savePath = GlobalUtil.EmallDir + Path.GetFileName(item.LinkAddress);
                        //item.LinkAddress.Substring(item.LinkAddress.LastIndexOf());
                        //引用前必须释放所有图片文件的使用权
                        Image img = null;
                        try
                        {
                            /*  if (!File.Exists(savePath))
                              {
                                  CosCloud.DownloadFile(CosLoginInfo.BucketName, item.LinkAddress, savePath);
                              }
                              if (!IsImage(savePath))
                              {
                                  continue;
                              }
                              img = JGNet.Core.ImageHelper.FromFileStream(savePath);*/
                            if (!IsCheckImg(item.LinkAddress))
                            {
                                continue;
                            }
                            if (item.LinkAddress != null)
                            {
                                String url = item.LinkAddress;
                                System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                                System.Net.WebResponse webres = webreq.GetResponse();
                                using (System.IO.Stream stream = webres.GetResponseStream())
                                {
                                    img = Image.FromStream(stream);
                                }
                            }

                           // img = Image.FromStream(System.Net.WebRequest.Create(item.LinkAddress).GetResponse().GetResponseStream());

                        }
                        catch (Exception ex)
                        {
                            //下载失败，可能文件被占用，直接使用该文件即可。
                            //文件找不到使用默认图片，找不到
                        }
                        // AddPhoto(new EmCostumePhoto() { Image = img, SavePath = savePath });
                        if (String.IsNullOrEmpty(item.ColorName))
                        {
                            if (!setThumb)
                            {
                                item.Thumb = CurItem.EmThumbnail;
                                setThumb = true;
                            }
                            item.Image = img;
                            AddPhoto(item);
                            InsertImage(this.titleImageControl, item, img);
                            //this.CostumePhotos 
                            titleEmCostumePhoto.Add(item);
                            titleCount++;
                        }
                        else
                        {
                            item.Image = img;
                            AddPhoto(item);
                            InsertImage(this.flowLayoutPanel2, item, img);
                            colorCount++;
                        }

                        DateTime endtimeOne = DateTime.Now;
                        TimeSpan spanOne = (TimeSpan)(endtimeOne - startOne);

                        WriteLog("图片每一次遍历开始时间：" + startOne + " 结束时间：" + endtimeOne + " 总耗时数：" + spanOne.TotalSeconds + "秒");
                    }

                    DateTime endtime = DateTime.Now;
                    TimeSpan span = (TimeSpan)(endtime - start);

                    WriteLog("图片遍历开始时间：" + start + " 结束时间：" + endtime + " 总耗时数：" + span.TotalSeconds + "秒");
                    if (colorCount == 0)
                    {
                        AutoInsertFlowLayoutImage(titleEmCostumePhoto);
                    }
                    // ShowMessage("主图片=" + titleCount + "型号图片=" + colorCount);
                }
                else
                {

                    //如果是没有上架过的，直接获取商品档案的图片信息
                    try
                    {
                        InteractResult<List<EmCostumePhoto>> result = GlobalCache.ServerProxy.GetCostumePhotoAddressList(this.CurItem?.ID);
                        if (result != null && result.Data.Count > 0)
                        {

                            Boolean setThumb = false;
                            List<EmCostumePhoto> titleEmCostumePhoto = new List<EmCostumePhoto>();
                            int titleCount = 0, colorCount = 0;
                            foreach (var item in info.EmCostumePhotos)
                            {
                             //   String savePath = GlobalUtil.EmallDir + Path.GetFileName(item.LinkAddress);
                                //item.LinkAddress.Substring(item.LinkAddress.LastIndexOf());
                                //引用前必须释放所有图片文件的使用权
                                Image img = null;
                                try
                                {
                                    /*  if (!File.Exists(savePath))
                                      {
                                          CosCloud.DownloadFile(CosLoginInfo.BucketName, item.LinkAddress, savePath);
                                      }

                                      if (!IsImage(savePath))
                                      {
                                          WriteLog("\r\n存在非图片路径：" + item.LinkAddress + "\r款号=" + item.CostumeID + "\rAutoID=" + item.AutoID);
                                          continue;
                                      }
                                      img = JGNet.Core.ImageHelper.FromFileStream(savePath);
                                      */
                                    if (item.LinkAddress != null)
                                    {
                                        String url = item.LinkAddress;
                                        System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                                        System.Net.WebResponse webres = webreq.GetResponse();
                                        using (System.IO.Stream stream = webres.GetResponseStream())
                                        {
                                            img = Image.FromStream(stream);
                                        }
                                    }

                                  //  img = Image.FromStream(System.Net.WebRequest.Create(item.LinkAddress).GetResponse().GetResponseStream());
                               
                                }
                                catch (Exception ex)
                                {
                                    //下载失败，可能文件被占用，直接使用该文件即可。
                                    //文件找不到使用默认图片，找不到
                                }
                                // AddPhoto(new EmCostumePhoto() { Image = img, SavePath = savePath });
                                if (String.IsNullOrEmpty(item.ColorName))
                                {
                                    if (!setThumb)
                                    {
                                        item.Thumb = CurItem.EmThumbnail;
                                        setThumb = true;
                                    }
                                    item.Image = img;
                                    AddPhoto(item);
                                    InsertImage(this.titleImageControl, item, img);
                                    titleEmCostumePhoto.Add(item);

                                    titleCount++;
                                }
                                else
                                {
                                    item.Image = img;
                                    AddPhoto(item);
                                    InsertImage(this.flowLayoutPanel2, item, img);
                                    colorCount++;
                                }
                            }

                            if (colorCount == 0)
                            {
                                AutoInsertFlowLayoutImage(titleEmCostumePhoto);
                            }
                            //ShowMessage("主图片="+this.titleImageControl.Controls.Count+"型号图片="+this.flowLayoutPanel2.Controls.Count);

                        }
                        else
                        {

                            AutoInsertTitleImage();
                            AutoInsertFlowLayoutImage();
                        }

                        /* if (photo != null)
                         {

                             MemoryStream stream = new MemoryStream(photo);
                             Image img = new Bitmap(stream);
                             Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                             EmCostumePhoto emCostumePhoto = null;
                             String path = this.CurItem?.ID + ".jpg";
                             String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBoxID.Text, Path.GetFileName(path));
                             String savePath = GlobalUtil.EmallDir + newFileName;
                             Core.ImageHelper.Compress(img, savePath, 50);
                             emCostumePhoto = new EmCostumePhoto()
                             {
                                 Image = img,
                                 SavePath = savePath,
                                 Bytes = photo,
                                 PhotoName = newFileName
                             };
                             AddPhoto(emCostumePhoto);
                             InsertImage(this.titleImageControl, emCostumePhoto, thumbnailImage);
                         }
                         else
                         {
                             AutoInsertTitleImage();
                             AutoInsertFlowLayoutImage();
                         }*/
                    }
                    catch (Exception ex)
                    {
                        GlobalUtil.ShowError(ex);
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


        /// <summary>
        /// 添加展示图片使用缩率图
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="emCostumePhoto"></param>
        /// <param name="img"></param>
        private bool isDefaultAdd = false;
        private void InsertImage(TitleImageControl flowLayoutPanel, EmCostumePhoto emCostumePhoto, Image img)
        {
            Image thumbnailImage = img?.GetThumbnailImage(64, 64, null, new IntPtr());
            TitleImage pic = new TitleImage()
            {
                Image = thumbnailImage,
                Tag = emCostumePhoto
            };
            pic.Disposed += ColorPic_Disposed;
            if (CostumeOfTitlePhotos == null) { CostumeOfTitlePhotos = new List<EmCostumePhoto>(); }
            if (!isDefaultAdd) { CostumeOfTitlePhotos.Add(emCostumePhoto); }
            flowLayoutPanel.AddTitleImage(pic);

        }

        /// <summary>
        /// 添加展示图片使用缩率图
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="emCostumePhoto"></param>
        /// <param name="img"></param>
        private void InsertImage(FlowLayoutPanel flowLayoutPanel, EmCostumePhoto emCostumePhoto, Image img)
        {
            Image thumbnailImage = img?.GetThumbnailImage(64, 64, null, new IntPtr());
            if (flowLayoutPanel == flowLayoutPanel2)
            {
                //颜色的增加标题
                TitleImage colorPic = new TitleImage()
                {
                    Title = emCostumePhoto.ColorName,
                    Image = thumbnailImage,//ShowDeleteBtn  = true
                    Tag = emCostumePhoto
                };
                colorPic.Disposed += ColorPic_Disposed;
                flowLayoutPanel.Controls.Add(colorPic);

            }
            else
            {
                InsertImage(titleImageControl, emCostumePhoto, img);
            }

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

        private void ResetAll()
        { 
            titleImageControl.Clear();
            flowLayoutPanel2.Controls.Clear();
            CostumePhotos?.Clear();
            this.skinTextBoxTitle.Text = string.Empty;
            this.rtfRichTextBox_Detail.Text = string.Empty;
            this.numericTextBoxOnlinePrice.Value = 0;
        }

        private void LoadCostume()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                skinTextBoxID_CostumeSelected(GlobalCache.CostumeList.Find(t => t.ID == editID), true);
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

        private void Initialize()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                //  SetUpCos();
                //   CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.sDoPhoto);
                CommonGlobalUtil.SetTemplates(skinComboBoxTemplate);
                CommonGlobalUtil.SetCommissionTemplate(skinComboBoxCommTemp, DefaultCommissionTemplate);
              //  Display();
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

       /* private void SetTemplates()
        {
            List<EmCarriageCostTemplate> list = GlobalCache.EMallServerProxy.GetValidCarriageCostTemplates();

            skinComboBoxTemplate.DisplayMember = "Name";
            skinComboBoxTemplate.ValueMember = "AutoID";
            skinComboBoxTemplate.DataSource = list;
        }*/
        private int DefaultCommissionTemplate=0; 
      /*  private void SetCommissionTemplate()
        { 
            InteractResult<List<CommissionTemplate>> interResult = CommonGlobalCache.ServerProxy.GetCommissionTemplates();
            if (interResult.Data.Count > 0)
            {
                foreach (CommissionTemplate commtemplate in interResult.Data)
                {
                    if (commtemplate.IsDefault == true)
                    {
                        DefaultCommissionTemplate = commtemplate.AutoID; 
                    }
                }

            }

            List<CommissionTemplate> List = new List<CommissionTemplate>();
            List.Add(new CommissionTemplate() { Name = "无", AutoID = 0, });
            List.AddRange(interResult.Data);

            skinComboBoxCommTemp.DisplayMember = "Name";
            skinComboBoxCommTemp.ValueMember = "AutoID";
            skinComboBoxCommTemp.DataSource = List;
        }*/

      /*  private void SetUpCos()
        {
            this.CosLoginInfo = GlobalCache.CosLoginInfo;
            //创建cos对象
            this.CosCloud = new CosCloud(CosLoginInfo.AppID, CosLoginInfo.SecretId, CosLoginInfo.SecretKey);
        }
        */

        private void BaseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                CurItem = GetEntity();
                if (!Validate(CurItem)) { return; }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                this.BaseButton3.Enabled = false;
                //   skinProgressBar1.Value = 0;
                CurItem.EmShowOnline = CurItem.IsRetail;
                CurItem.PfShowOnline = CurItem.IsPf;
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoUpdate);
                cb.BeginInvoke(null, null);
                //  DoUpdate();

            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);

            }
        }



        public static String CONFIG_PATH = CommonGlobalUtil.AgileConfiguration("Manage.EmCarriageCostTemplate");

        private EmCostumePhoto CurCostmePhotoVideo = null;
        private bool VideoUpdate(out string ErrorMsg)
        {
            ErrorMsg = "";
            bool updateSuccess = false;
            //重新生成文件名  json读取返回结果  
            InteractResult<CosCloudSignature> result = GlobalCache.ServerProxy.GetCosCloudSignature();
            if (result.ExeResult == ExeResult.Success)
            {
                CosCloudSignature cosCloudSignature = result.Data;

                VedioCosCloud = new CosCloud(cosCloudSignature.AppID, cosCloudSignature.Signature, 120);

                Dictionary<string, string> uploadParasDic = new Dictionary<string, string>();
                uploadParasDic.Add(CosParameters.PARA_BIZ_ATTR, "");
                uploadParasDic.Add(CosParameters.PARA_INSERT_ONLY, "0");
                string newFilename = GetNewFileName(this.skinTextBoxID.SkinTxt.Text.Trim(), CJBasic.Helpers.FileHelper.GetFileNameNoPath(txtVideo.SkinTxt.Text), txtVideo.SkinTxt.Text);
                string resultCloud = VedioCosCloud.UploadFile2(cosCloudSignature.BucketName, string.Format("/{0}/{1}", CommonGlobalCache.BusinessAccount.ID, newFilename), newFilename, AuthGetFileData(videoPath), uploadParasDic);
                //  JsonConvert.DeserializeObject(resultCloud);

                ResultJson ResultJ = (ResultJson)JavaScriptConvert.DeserializeObject(resultCloud, typeof(ResultJson));

                if (ResultJ.code.ToString() == "0")
                {
                    CurCostmePhotoVideo = new EmCostumePhoto();
                    Data dInfo = ResultJ.data;
                    CurCostmePhotoVideo.LinkAddress = dInfo.source_url;
                    CurCostmePhotoVideo.IsVideo = true;
                    CurCostmePhotoVideo.PhotoName = newFilename;
                    CurCostmePhotoVideo.CostumeID = this.skinTextBoxID.SkinTxt.Text;
                    txtVideo.SkinTxt.Text = dInfo.source_url;
                    WriteLog("视频上传成功：路径=" + dInfo.source_url);
                    updateSuccess = true;
                }
                else
                {
                    ErrorMsg = "视频上传失败！";

                }

            }
            else
            {
                ErrorMsg = "获取腾讯云失败：" + result.Msg;

            }


            return updateSuccess;
        }
        


        private void DoUpdate()
        {
            try
            {

                SetProgressVisible(true);
                RemoveDisposedCostumePhoto();
                UploadCostumePhoto();
                SetProgressInfo("正在保存商品信息……");
                UpdateDisplayIndex();
                if (txtVideo.SkinTxt.Text != "" )
                {
                    if (baseButtonChooseFile.Text == "选择视频")
                    {
                        string ErrorMsg = string.Empty;
                        SetProgressInfo("视频上传中，请稍等");
                        bool isSuccess = VideoUpdate(out ErrorMsg); //上传视频
                        if (isSuccess)
                        {

                            if (SourceVideoInfo != null)
                            {
                                DeleteResult deleetVideo = GlobalCache.ServerProxy.DeletePhotoToCos(SourceVideoInfo.PhotoName);
                            }
                            InteractResult vedioResult = GlobalCache.ServerProxy.InsertEmCostumePhoto4Video(CurCostmePhotoVideo);
                            if (vedioResult.ExeResult == ExeResult.Success)
                            {
                                SetProgressInfo("视频上传成功，继续保存商品资料");
                            }
                        }
                        else
                        {
                            ShowMessage(ErrorMsg);
                        }
                    }
                }
                else
                {
                    if (SourceVideoInfo != null)
                    {
                        DeleteResult deleetVideo = GlobalCache.ServerProxy.DeletePhotoToCos(SourceVideoInfo.PhotoName);
                    }
                }
                InteractResult result = GlobalCache.EMallServerProxy.UpateEmCostumeInfo(CurItem);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        GlobalCache.OnUpateEmCostumeInfo(CurItem);
                        SetProgressInfo("上传中：");
                        SetProgressVisible(false);

                       // ShowMessage("保存成功!");
                        GlobalMessageBox.Show("保存成功！");
                        //保存模板状态,上架才需要保存模板信息 
                        this.RemovePhotos?.Clear();
                        Costume_Save?.Invoke(CurItem);
                        CloseForm();
                        break;
                    case ExeResult.Error:
                        ShowMessage(result.Msg);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                this.BaseButton3.Enabled = true;
                UnLockPage();
            }
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

        private void DoShelves()
        {
            try
            {
                SetProgressVisible(true);
                RemoveDisposedCostumePhoto();
                UploadCostumePhoto();
                SetProgressInfo("正在上架商品信息……");
                UpdateDisplayIndex();
                if (txtVideo.SkinTxt.Text != "")
                {
                    if (baseButtonChooseFile.Text == "选择视频")
                    {
                        string ErrorMsg = string.Empty;
                        SetProgressInfo("视频上传中，请稍等");
                        bool isSuccess = VideoUpdate(out ErrorMsg); //上传视频
                        if (isSuccess)
                        {
                            if (SourceVideoInfo != null)
                            {
                                DeleteResult deleetVideo = GlobalCache.ServerProxy.DeletePhotoToCos(SourceVideoInfo.PhotoName);
                            }
                            InteractResult vedioResult = GlobalCache.ServerProxy.InsertEmCostumePhoto4Video(CurCostmePhotoVideo);
                            if (vedioResult.ExeResult == ExeResult.Success)
                            {
                                SetProgressInfo("视频上传成功，继续保存商品资料");
                            }
                        }
                        else
                        {
                            ShowMessage(ErrorMsg);
                        }
                    }
                }
                else
                {
                    if (SourceVideoInfo != null)
                    {
                        DeleteResult deleetVideo = GlobalCache.ServerProxy.DeletePhotoToCos(SourceVideoInfo.PhotoName);
                    }
                }


                InteractResult result = GlobalCache.EMallServerProxy.ShelvesEmCostumeInfo(CurItem);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        CurItem.EmShowOnline = true;
                        GlobalCache.OnUpateEmCostumeInfo(CurItem);
                        SetProgressInfo("上传中：");
                        SetProgressVisible(false);
                        GlobalMessageBox.Show("上架成功!");
                        //保存模板状态 
                        if (template == null)
                        {
                            template = new EmCarriageCostTemplate();
                            if (config != null)
                            {
                                config.EmCarriageCostTemplate = template;
                                config.Save(CONFIG_PATH);
                            }
                            template = null;
                        }
                        this.RemovePhotos?.Clear();
                        Costume_Save?.Invoke(CurItem);
                        CloseForm();
                        break;
                    case ExeResult.Error:
                        ShowMessage(result.Msg);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                baseButton2.Enabled = true;
                UnLockPage();
            }
        }
        /// <summary>
        /// 上架
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void baseButton2_Click(object sender, EventArgs e)
        {
            try
            {
                CurItem = GetEntity();
                if (!Validate(CurItem)) { return; }
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                baseButton2.Enabled = false;

                //skinProgressBar1.Value = 0;
                if (GlobalCache.CostumeList.Exists(t => t.ID == CurItem.ID && t.EmShowOnline))
                {
                    GlobalMessageBox.Show(this.FindForm(), "不能重复上架！");
                    baseButton2.Enabled = true;
                    UnLockPage();
                    return;
                }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoShelves);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
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
                       // ShowMessage("保存时：" + photo.ColorName);

                        if (String.IsNullOrEmpty(photo.LinkAddress))
                        {
                            //文件重复？提示？缩略图每次都变？？？？
                            if (!String.IsNullOrEmpty(photo.SavePath))
                            {
                                //这里还是要给新图片名称，下面取回来对应过去。才有LINKADDRESS
                                //MemoryStream StreamData = new MemoryStream();
                                //photo.Image.Save(StreamData, photo.Image.RawFormat);
                                PhotoData para = new PhotoData()
                                {
                                    Datas = photo.Bytes,
                                    EmCostumePhoto = photo,
                                    Name = photo.PhotoName,
                                };
                                EmCostumePhoto EmPhoto = CommonGlobalUtil.UploadPhotoToCos(para, photo.CostumeID);

                                //ShowMessage(photo.ColorName);
                                EmPhoto.ColorName = photo.ColorName;
                                
                                

                                GlobalCache.ServerProxy.InsertEmCostumePhoto(EmPhoto);
                                //  GlobalCache.ServerProxy.UploadPhotoToCos(para);
                            }
                        }

                        this.BeginInvoke(new CJBasic.CbGeneric<int>(ShowProgress), i);
                    }
                    //重新加载图片获取AUTOID
                    EmCostumeInfo info = GetByID(CurItem.ID);
                    foreach (var displayData in CostumePhotos)
                    {
                        foreach (var serverData in info.EmCostumePhotos)
                        {
                            if (displayData.PhotoName == serverData.PhotoName)
                            {
                                CJBasic.Helpers.ReflectionHelper.CopyProperty(serverData, displayData);
                            }
                        }
                    }

                    GlobalUtil.Debug("得到CostumePhotos：" + CostumePhotos.Count);
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
        private void AddRemovePhotos(EmCostumePhoto item)
        {
            if (RemovePhotos == null)
            {
                RemovePhotos = new List<EmCostumePhoto>();
            }
            RemovePhotos.Add(item);
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
        private bool Validate(EmCostumeInfo item)
        {
            bool success = true;
            if (String.IsNullOrEmpty(item.ID))
            {
                this.skinTextBoxID.Focus();
                success = false;
                GlobalMessageBox.Show("请输入款号！");
            }
            else if (item.PfOnlinePrice <= 0)
            {
                this.numericTextBoxPfPrice.Focus();
                success = false;
                GlobalMessageBox.Show("批发价必须大于0！");
            }
            else if (item.PfOnlinePrice > Convert.ToDecimal(99999999.99))
            {

                this.numericTextBoxPfPrice.Focus();
                success = false;
                GlobalMessageBox.Show("批发价不能大于99999999.99！");
            }
            else if (item.EmOnlinePrice <= 0)
            {
                this.numericTextBoxOnlinePrice.Focus();
                success = false;
                GlobalMessageBox.Show("线上价必须大于0！");
            }
            else if (item.EmOnlinePrice > Convert.ToDecimal(99999999.99))
            {
                this.numericTextBoxOnlinePrice.Focus();
                success = false;
                GlobalMessageBox.Show("线上价不能大于99999999.99！");
            }
            else if (item.EmPrice <= 0)
            {
                this.txtOnlinePrice.Focus();
                success = false;
                GlobalMessageBox.Show("线上吊牌价必须大于等于0！");
            }
            else if (item.EmPrice > Convert.ToDecimal(99999999.99))
            {
                this.txtOnlinePrice.Focus();
                success = false;
                GlobalMessageBox.Show("线上吊牌不能大于99999999.99！");
            }


            else if (!GlobalCache.CostumeList.Exists(t => t.ID == item.ID))
            {
                this.skinTextBoxID.Focus();
                success = false;
                GlobalMessageBox.Show("款号不存在！");
            }
            else if (String.IsNullOrEmpty(item.Name))
            {
                skinTextBox_Name.Focus();
                success = false;
                GlobalMessageBox.Show("请输入名称！");
            }
            else if (String.IsNullOrEmpty(item.EmTitle))
            {
                skinTextBoxTitle.Focus();
                success = false;
                GlobalMessageBox.Show("请输入标题！");
            }
            else if (!CostumePhotos.Exists(t => String.IsNullOrEmpty(t.ColorName)))
            {
                success = false;
                GlobalMessageBox.Show("请上传商品图片！");
            }
            else if (!CostumePhotos.Exists(t => !String.IsNullOrEmpty(t.ColorName)))
            {
                success = false;
                GlobalMessageBox.Show("请设置商品型号！");
            }
            else if (String.IsNullOrEmpty(ValidateUtil.CheckEmptyValue(skinComboBoxTemplate.SelectedValue)) && !skinCheckBox_State.Checked)
            {
                success = false;
                GlobalMessageBox.Show("请选择运费方式！");
            }
            else if (this.skinCheckBoxSale.Checked == false && this.skinCheckBoxPF.Checked == false)
            {
                success = false;
                GlobalMessageBox.Show("请选择类型！");
            }

            return success;
        }
        private EmCostumeInfo GetEntity()
        {
            EmCostumeInfo item = null;
            item = new EmCostumeInfo()
            {
                ID = this.skinTextBoxID.Text.Trim(),
                Name = this.skinTextBox_Name.Text.Trim(),
                EmTitle = this.skinTextBoxTitle.Text.Trim(),
                EmDetails = this.rtfRichTextBox_Detail.Text.Trim(),
                EmOnlinePrice = numericTextBoxOnlinePrice.Value,
                PfOnlinePrice = numericTextBoxPfPrice.Value,
                EmShowOnline = true,
                EmCostumePhotos = GetPhoto(),
                CarriageCostTemplateID = template == null ? 0 : template.AutoID,
                ClassID = skinComboBoxBigClass.SelectedValue.ClassID,
                IsPf = this.skinCheckBoxPF.Checked,
                IsRetail = this.skinCheckBoxSale.Checked,
                CommissionTemplateID = (int)this.skinComboBoxCommTemp.SelectedValue,
                EmPrice = txtOnlinePrice.Value,
                 IsHot= this.skinCbxHot.Checked,
                IsNew = this.skinCbxNew.Checked,
            };
            item.PfEverOnline = true;
            //if (skinCheckBoxIsSync.Checked)
            //{
            //    item.PfEverOnline = skinCheckBoxIsSync.Checked;
            //}
            //else
            //{ item.PfEverOnline = CurItem.PfEverOnline; }

            Costume info = GlobalCache.CostumeList.Find(t => t.ID == item.ID);
            //提交的时候EmCostumeInfo没用。
            item.Colors = info?.Colors;
            return item;
        }
        private List<EmCostumePhoto> GetPhoto()
        {
            if (CostumePhotos != null)
            {
                for (int i = 0; i < CostumePhotos.Count; i++)
                {
                    var photo = CostumePhotos[i];
                    if (i == 0)
                    {
                        photo.IsMain = true;
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(photo.ColorName))
                        {
                            photo.IsMain = false;
                        }
                        else { photo.IsMain = true; }
                    }
                    photo.CostumeID = CurItem.ID;
                }
            }
            return CostumePhotos;
        }
        /// <summary>
        /// 选择确认之后，自动添加到颜色列表中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinComboBox_Color_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String str = ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedItem);
            if (CostumePhotos != null && CostumePhotos.Exists(t => t.ColorName == str))
            {
                GlobalMessageBox.Show("相同颜色已存在！");
                return;
            }
            else
            {
                AddColorToListView(str);
            }

        }
        private void AddColorToListView(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                this.skinComboBox_Color.Focus();
                return;
            }
            if (CostumeOfTitlePhotos != null && CostumeOfTitlePhotos.Count > 0)
            { 
                ColorPictureListForm colorList = new ColorPictureListForm(this.skinTextBoxID.SkinTxt.Text, CostumeOfTitlePhotos);
                colorList.DiscountConfirm += SingleDiscountForm_DiscountConfirm;
                colorList.ShowDialog();
            }
            else
            {
                Upload_Click(flowLayoutPanel2, null);
            }
        }



        private void SingleDiscountForm_DiscountConfirm(EmCostumePhoto emPhoto)
        {

            if (emPhoto != null)
            {
                byte[] photo = null;
                // if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                string strTime = DateTime.Now.ToString();
                Image img = null;
                String savePath;
                System.IO.Stream streamImg = null;
                if (emPhoto.LinkAddress != "")
                {
                  //  savePath = GlobalUtil.EmallDir + Path.GetFileName(emPhoto.LinkAddress);
                    //引用前必须释放所有图片文件的使用权

                    try
                    {
                        /* if (!File.Exists(savePath))
                         {
                             CosCloud.DownloadFile(CosLoginInfo.BucketName, emPhoto.LinkAddress, savePath);
                         }
                         img = JGNet.Core.ImageHelper.FromFileStream(savePath);
                         */

                        if (emPhoto.LinkAddress != null)
                        {
                            String url = emPhoto.LinkAddress;
                            System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                            System.Net.WebResponse webres = webreq.GetResponse();
                            using ( streamImg = webres.GetResponseStream())
                            {
                                img = Image.FromStream(streamImg);
                            }
                        }

                       // img = Image.FromStream(System.Net.WebRequest.Create(emPhoto.LinkAddress).GetResponse().GetResponseStream());
                    }
                    catch (Exception ex)
                    {
                        //下载失败，可能文件被占用，直接使用该文件即可。
                        //文件找不到使用默认图片，找不到
                    }
                }
                else
                {
                  //  savePath = GlobalUtil.EmallDir + Path.GetFileName(emPhoto.SavePath);
                    //引用前必须释放所有图片文件的使用权

                    try
                    {
                        /*  if (!File.Exists(savePath))
                          {
                              CosCloud.DownloadFile(CosLoginInfo.BucketName, emPhoto.SavePath, savePath);
                          }
                          img = JGNet.Core.ImageHelper.FromFileStream(savePath);
                          */

                        /*  if (emPhoto.SavePath != null)  //不能用这种，会导致一般性错误
                          {
                              String url = emPhoto.SavePath;
                              System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                              System.Net.WebResponse webres = webreq.GetResponse();
                              using (streamImg = webres.GetResponseStream())
                              {
                                  img = Image.FromStream(streamImg);
                              }
                              streamImg.Dispose();
                          }*/
                        if (emPhoto.SavePath != null)
                        {
                            img = Image.FromStream(System.Net.WebRequest.Create(emPhoto.SavePath).GetResponse().GetResponseStream());
                        }

                    }
                    catch (Exception ex)
                    {
                        //下载失败，可能文件被占用，直接使用该文件即可。
                        //文件找不到使用默认图片，找不到
                    }
                }
                 

                MemoryStream stream = new MemoryStream();
                //photo = stream.ToArray();
                //  stream = new MemoryStream(); 
                if (img.RawFormat != null)
                {
                    img.Save(stream, img.RawFormat);
                }
                else
                {

                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
              
                 photo = stream.ToArray();
                
                 

                Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                EmCostumePhoto emCostumePhoto = null;
                string fileNameurl = string.Empty;
                if (emPhoto.LinkAddress == "")
                {
                    fileNameurl = emPhoto.SavePath;
                }
                else
                {
                    fileNameurl = emPhoto.LinkAddress;
                }
                String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBoxID.Text, fileNameurl);
                savePath = GlobalUtil.EmallDir + newFileName;
                Core.ImageHelper.Compress(img, savePath, 50);
                // ShowMessage(this.skinComboBox_Color.SelectedValue.ToString());
                
                 emCostumePhoto = new EmCostumePhoto()
                {
                    Image = img,
                    SavePath = savePath,
                    IsMain = this.skinComboBox_Color.SelectedIndex == 0 ? true : false,
                    ColorName = ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedValue.ToString()),
                    Bytes = photo,
                    PhotoName = newFileName
                };
               // ShowMessage("AddPhoto前：" + this.skinComboBox_Color.SelectedValue.ToString());
                AddPhoto(emCostumePhoto);
                InsertImage(this.flowLayoutPanel2, emCostumePhoto, thumbnailImage);
              
            }

            /* if (this.retailDetailList == null || this.retailDetailList.Count == 0)
             {
                 return;
             }
             BaseButtonSingleDiscount.Text = "取消整单打折";
             skinComboBox_Promotion.Enabled = false;
             // 放在这里整单打折OK
             CheckGiftTicket();
             singleDiscount = discount;
             skinLabelSingleDiscount.Text = (discount / 10.0).ToString() + "折";
             //if (String.IsNullOrEmpty(remarks))
             //{
             //    remarks = String.Empty;
             //}

             foreach (RetailDetail detail in this.retailDetailList)
             {
                 detail.Discount = discount;
                 if (balanceRound)
                 {
                     detail.SinglePrice = Math.Round(detail.Price * detail.Discount * (decimal)0.01, MidpointRounding.AwayFromZero);
                     // detail.SalePrice = detail.SinglePrice;
                 }
                 else
                 {
                     detail.SinglePrice = Math.Round(detail.Price * detail.Discount * (decimal)0.01, 2, MidpointRounding.AwayFromZero);
                     //  detail.SalePrice = detail.SinglePrice;
                 }

                 detail.SumMoney = detail.BuyCount * detail.SinglePrice;
                 detail.SumMoneyActual = detail.SumMoney;
                 // detail.Remarks = remarks;
             }

             this.currentIsInSingleDiscount = true;
             currentIsPromotionMJ = false;
             this.currentIsPromotionDiscount = false;
             this.dataGridView1.Refresh();
             this.SetTotalLabel_MoneyAndCount();*/

        }


        /// <summary>
        /// 添加图片实体类
        /// </summary>
        /// <param name="photo"></param>
        private void AddPhoto(EmCostumePhoto photo)
        {
            WriteLog("Begin");
            try
            {
                if (CostumePhotos == null) { CostumePhotos = new List<EmCostumePhoto>(); }
                WriteLog("Come1" + CostumePhotos.Count);
                //判断添加方式，有颜色的放后面，以此解决排序上的更改的问题
                if (String.IsNullOrEmpty(photo.ColorName))
                {
                    //将商品详情方最后
                    int index = this.CostumePhotos.FindLastIndex(t => String.IsNullOrEmpty(t.ColorName));
                    this.CostumePhotos.Insert(index + 1, photo);
                    WriteLog("Come1 CostumePhotos=" + CostumePhotos.Count + "index=" + index);
                }
                else
                {
                    this.CostumePhotos.Add(photo);
                   // ShowMessage("AddPhoto中："+ photo.ColorName);
                }


                photo.Image.Tag = photo;
                WriteLog("photo.Image.Tag=" + photo.Image.Tag);
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex.Message + ex.StackTrace);
                WriteLog(ex.Message + ex.StackTrace);

            }
            WriteLog("End");
        }

        #region
        /// <summary>
        /// 自动新增加一张商品型号图片
        /// </summary>
        public void AutoInsertFlowLayoutImage(List<EmCostumePhoto> titleEmPhotos = null)
        {
            try
            {
                string[] colorsList = CurItem.Colors.Split(',');
                if (this.skinComboBox_Color.Items.Count > 0)
                {
                    if (titleEmPhotos != null && titleEmPhotos.Count > 0)
                    {
                        if (titleEmPhotos.Count < colorsList.Length)
                        {
                            int titleCount = titleEmPhotos.Count;
                            for (int i = 0; i < colorsList.Length; i++)
                            {
                                byte[] photo = null;
                                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                                string strTime = DateTime.Now.ToString();
                               String savePath = GlobalUtil.EmallDir + Path.GetFileName(titleEmPhotos[0].LinkAddress);
                                //引用前必须释放所有图片文件的使用权
                                Image img = null;
                                try
                                {
                                    /* if (!File.Exists(savePath))
                                     {
                                         CosCloud.DownloadFile(CosLoginInfo.BucketName, titleEmPhotos[0].LinkAddress, savePath);
                                     }
                                     img = JGNet.Core.ImageHelper.FromFileStream(savePath);
                                     */
                                    if (titleEmPhotos[0].LinkAddress != null)
                                    {
                                        String url = titleEmPhotos[0].LinkAddress;
                                        System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                                        System.Net.WebResponse webres = webreq.GetResponse();
                                        using (System.IO.Stream streamImg = webres.GetResponseStream())
                                        {
                                            img = Image.FromStream(streamImg);
                                        }
                                    }

                                   // img = Image.FromStream(System.Net.WebRequest.Create(titleEmPhotos[0].LinkAddress).GetResponse().GetResponseStream());
                                }
                                catch (Exception ex)
                                {
                                    //下载失败，可能文件被占用，直接使用该文件即可。
                                    //文件找不到使用默认图片，找不到
                                }
                                MemoryStream stream = new MemoryStream();
                                photo = stream.ToArray();
                                stream = new MemoryStream();
                                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                photo = stream.ToArray();

                                Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                                EmCostumePhoto emCostumePhoto = null;
                                String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBoxID.Text, strTime);
                                savePath = GlobalUtil.EmallDir + newFileName;
                                Core.ImageHelper.Compress(img, savePath, 50);

                                emCostumePhoto = new EmCostumePhoto()
                                {
                                    Image = img,
                                    SavePath = savePath,
                                    IsMain = i == 0 ? true : false,
                                    ColorName = ValidateUtil.CheckEmptyValue(colorsList[i]),
                                    Bytes = photo,
                                    PhotoName = newFileName
                                };

                                AddPhoto(emCostumePhoto);
                                InsertImage(this.flowLayoutPanel2, emCostumePhoto, thumbnailImage);

                            }

                        }
                        else
                        {
                            for (int i = 0; i < colorsList.Length; i++)
                            {

                                byte[] photo = null;
                                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                                string strTime = DateTime.Now.ToString();
                                String savePath = GlobalUtil.EmallDir + Path.GetFileName(titleEmPhotos[i].LinkAddress);
                                //item.LinkAddress.Substring(item.LinkAddress.LastIndexOf());
                                //引用前必须释放所有图片文件的使用权
                                Image img = null;
                                try
                                {
                                    /* if (!File.Exists(savePath))
                                     {
                                         CosCloud.DownloadFile(CosLoginInfo.BucketName, titleEmPhotos[i].LinkAddress, savePath);
                                     }
                                     img = JGNet.Core.ImageHelper.FromFileStream(savePath);*/

                                    if (titleEmPhotos[0].LinkAddress != null)
                                    {
                                        String url = titleEmPhotos[0].LinkAddress;
                                        System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                                        System.Net.WebResponse webres = webreq.GetResponse();
                                        using (System.IO.Stream streamImg = webres.GetResponseStream())
                                        {
                                            img = Image.FromStream(streamImg);
                                        }
                                    }
                                    //  img = Image.FromStream(System.Net.WebRequest.Create(titleEmPhotos[i].LinkAddress).GetResponse().GetResponseStream());
                                }
                                catch (Exception ex)
                                {
                                    //下载失败，可能文件被占用，直接使用该文件即可。
                                    //文件找不到使用默认图片，找不到
                                }


                                MemoryStream stream = new MemoryStream();
                                photo = stream.ToArray();
                                // img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);
                                //  img = JGNet.Core.ImageHelper.GetNewSizeImage(titleEmPhotos[titleCount - 1].Image, 800);
                                stream = new MemoryStream();
                                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                                photo = stream.ToArray();

                                Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                                EmCostumePhoto emCostumePhoto = null;
                                String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBoxID.Text, strTime);
                                savePath = GlobalUtil.EmallDir + newFileName;
                                Core.ImageHelper.Compress(img, savePath, 50);

                                emCostumePhoto = new EmCostumePhoto()
                                {
                                    Image = img,
                                    SavePath = savePath,
                                    IsMain = i == 0 ? true : false,
                                    ColorName = ValidateUtil.CheckEmptyValue(colorsList[i]),
                                    Bytes = photo,
                                    PhotoName = newFileName
                                };

                                // Image thumbnailImage = titleEmPhotos[i].Image.GetThumbnailImage(64, 64, null, new IntPtr());
                                AddPhoto(emCostumePhoto);
                                InsertImage(this.flowLayoutPanel2, emCostumePhoto, thumbnailImage);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < colorsList.Length; i++)
                        {
                            byte[] photo = null;
                            if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                            string strTime = DateTime.Now.ToString();
                            //this.pictureBox1.Image = global::JGNet.Manage.Properties.Resources.plus;
                            Image img = null;
                            MemoryStream stream = new MemoryStream();
                            photo = stream.ToArray();
                            // img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);
                            img = JGNet.Core.ImageHelper.GetNewSizeImage(global::JGNet.Manage.Properties.Resources._64, 800);
                            stream = new MemoryStream();
                            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            photo = stream.ToArray();

                            Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                            EmCostumePhoto emCostumePhoto = null;
                            String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBoxID.Text, strTime);
                            String savePath = GlobalUtil.EmallDir + newFileName;
                            Core.ImageHelper.Compress(img, savePath, 50);
                            // imtPath = savePath;
                            emCostumePhoto = new EmCostumePhoto()
                            {
                                Image = img,
                                SavePath = savePath,
                                IsMain = true,
                                ColorName = ValidateUtil.CheckEmptyValue(colorsList[i]),
                                Bytes = photo,
                                PhotoName = newFileName
                            };

                            AddPhoto(emCostumePhoto);
                            InsertImage(this.flowLayoutPanel2, emCostumePhoto, thumbnailImage);
                        }
                        /*  if (sender is FlowLayoutPanel)
                          {
                              InsertImage(sender as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                          }
                          else
                          {
                              InsertImage(ctrl.Parent as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                          }*/
                    }
                }

            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }
        #endregion

        #region
        /// <summary>
        /// 自动新增加一张主图片
        /// </summary>
        private void AutoInsertTitleImage()
        {
            try
            {

                byte[] photo = null;

                if (GlobalUtil.EngineUnconnectioned(this)) { return; }

                string strTime = DateTime.Now.ToString();
                isDefaultAdd = true;
                Image img = null;
                MemoryStream stream = new MemoryStream();
                photo = stream.ToArray();
                img = JGNet.Core.ImageHelper.GetNewSizeImage(global::JGNet.Manage.Properties.Resources._800, 800);

                stream = new MemoryStream();
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                photo = stream.ToArray();

                Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                EmCostumePhoto emCostumePhoto = null;
                String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBoxID.Text, strTime);
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
                InsertImage(this.titleImageControl, emCostumePhoto, thumbnailImage);


            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }
        #endregion
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
                
                if (CostumePhotos != null && CostumePhotos.Count >= 20)
                {
                    GlobalMessageBox.Show("商品图片（包括型号图片），最多上传20张！");
                    return;
                }
                string[] paths = CJBasic.Helpers.FileHelper.GetFilesToOpen("请选择要上传的图片");


                if (paths != null)
                {
                    if (CostumePhotos != null && CostumePhotos.Count + paths.Length > 20)
                    {
                        GlobalMessageBox.Show("商品图片（包括型号图片），最多上传20张！");
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
                            //if (img.RawFormat != null)
                            //{
                            //    img.Save(stream, img.RawFormat);
                            //}
                            //else
                            //{
                                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                          //  }
                            photo = stream.ToArray();
                          //  GlobalMessageBox.Show("photo.Length=" + photo.Length+img.RawFormat.ToString());
                            if (photo.Length > 2097152)
                            {
                                GlobalMessageBox.Show("图片太大，请重新上传！");
                                return;
                            }

                            stream.Dispose();
                            photo = null;
                            img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);



                            stream = new MemoryStream();
                            //if (img.RawFormat != null)
                            //{
                            //    img.Save(stream, img.RawFormat);
                            //}
                            //else
                            //{

                                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                           // }
                            photo = stream.ToArray();
                            
                            Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                            EmCostumePhoto emCostumePhoto = null;
                            String newFileName = JGNet.Core.ImageHelper.GetNewFileName(this.skinTextBoxID.Text, Path.GetFileName(path));
                            String savePath = GlobalUtil.EmallDir + newFileName;
                            Core.ImageHelper.Compress(img, savePath, 50);

                            path = savePath;
                            if (sender == flowLayoutPanel2)
                            {
                                emCostumePhoto = new EmCostumePhoto()
                                {
                                    Image = img,
                                    SavePath = path,
                                    IsMain = true,
                                    ColorName = ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedValue),
                                    Bytes = photo,
                                    PhotoName = newFileName
                                };
                            }
                            else
                            {
                                emCostumePhoto = new EmCostumePhoto()
                                {
                                    Image = img,
                                    SavePath = path,
                                    Bytes = photo,
                                    PhotoName = newFileName
                                };
                            }
                            AddPhoto(emCostumePhoto);
                            if (isDefaultAdd) { isDefaultAdd = false; }
                            if (sender is FlowLayoutPanel)
                            {
                                InsertImage(sender as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                            }
                            else
                            {
                                InsertImage(ctrl.Parent as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                            }
                            stream.Dispose();
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

     /* public  new DialogResult ShowDialog()
        {
            Display(true);
            return DialogResult.OK;
        }*/
        private void skinTextBoxID_CostumeSelected(Costume item, bool isEnter)
        {
            if (isEnter)
            {
                if (item != null)
                {
                    CurItem = GetByID(item.ID);
                    if (isEdit)
                    {
                        CurItem.EmTitle = item.Name; 
                        CurItem.PfOnlinePrice = item.Price;
                        if (CurItem.EmOnlinePrice == 0 || string.IsNullOrEmpty(CurItem.EmOnlinePrice.ToString()))
                        { 
                          CurItem.EmOnlinePrice = item.Price;
                        }
                    }
                    SetTemplate(CurItem.CarriageCostTemplateID);
                    this.skinComboBox_Color.DataSource = CurItem.Colors.Split(',');
                }
                else
                {
                    CurItem = null;
                    this.skinComboBox_Color.DataSource = null;
                }
                //this.DialogResult = DialogResult.OK;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
               // Display(true);
            }
        }
        private EmCarriageCostTemplate template;
        private void costumeTextBox1_ResultSelected(EmCarriageCostTemplate obj)
        {
            if (obj != null)
            {
                template = obj;
                skinComboBoxTemplate.SelectedValue = obj.AutoID;
                skinCheckBox_State.Checked = false;
            }
        }
        private void skinCheckBox_State_CheckedChanged(object sender, EventArgs e)
        {
            if (skinCheckBox_State.Checked)
            {
                template = null;
                // this.textBoxTemplate.Text = string.Empty;
                skinComboBoxTemplate.SelectedIndex = -1;
            }
        }
        private void skinComboBoxTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skinComboBoxTemplate.SelectedIndex != -1)
            {
                this.skinCheckBox_State.Checked = false;
                template = skinComboBoxTemplate.SelectedItem as EmCarriageCostTemplate;
            }
        }

        private void titleImageControl_Load(object sender, EventArgs e)
        {

        }
        public String VideoPath
        {
            get
            {
                return videoPath;
            }
        }

        private String videoPath;
        private string vidoFileName = string.Empty;
        private byte[] videoOfByte = null;
        private void baseButtonChooseFile_Click(object sender, EventArgs e)
        {

            if (this.baseButtonChooseFile.Text == "选择视频")
            {
                videoPath = CJBasic.Helpers.FileHelper.GetFileToOpen("请选择视频文件");
                if (videoPath != null && videoPath != "")
                {
                    //string fileName = videoPath.Substring(videoPath.LastIndexOf("\\") + 1); //文件名称
                    //vidoFileName = fileName;
                    //string type = videoPath.Substring(videoPath.LastIndexOf(".") + 1); //文件格式

                    string type = CJBasic.Helpers.FileHelper.GetExtendName(videoPath);
                    if (type == ".swf" || type == ".mkv" || type == ".3gp" || type == ".flv" || type == ".mp4" || type == ".rmvb" || type == ".avi" || type == ".mpeg" || type == ".ra" || type == ".ram" || type == ".mov" || type == ".wmv")
                    {
                        //mp4  .avi .3gp .mkv
                    }
                    else
                    {
                        GlobalMessageBox.Show("请选择正确的视频文件！");
                        txtVideo.SkinTxt.Text = "";
                        return;
                    }
                    //CJBasic.Helpers.FileHelper.ReadFileReturnBytes
                    //CJBasic.Helpers.FileHelper.sa
                    //   byte[] videobyte= AuthGetFileData(videoPath);  //二进制
                    //  videoOfByte = videobyte;
                    //this.txtRidao.Text = path;
                    //  FileStream fileStramVideo=File.Create(videoPath);
                    txtVideo.SkinTxt.Text = videoPath;

                    if (String.IsNullOrEmpty(videoPath))
                    {
                        //      GlobalMessageBox.Show("请选择文件！");
                        return;
                    }
                }
            }
            else if (this.baseButtonChooseFile.Text == "删除视频")
            {
                this.txtVideo.SkinTxt.Text = "";
                this.baseButtonChooseFile.Text = "选择视频";
            }


        }
        protected byte[] AuthGetFileData(string fileUrl)
        {
            FileStream fs = new FileStream(fileUrl, FileMode.Open, FileAccess.Read);
            try
            {
                byte[] buffur = new byte[fs.Length];
                fs.Read(buffur, 0, (int)fs.Length);

                return buffur;
            }
            catch (Exception ex)
            {
                //MessageBoxHelper.ShowPrompt(ex.Message);
                return null;
            }
            finally
            {
                if (fs != null)
                {

                    //关闭资源
                    fs.Close();
                }
            }
        }

        public CosCloud VedioCosCloud;

        public static string GetNewFileName(String costumeID, string fileName, string sourcePath)
        {
            //  String fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            // String extension = Path.GetExtension(fileName);
            String newFileName = costumeID + "_" + String.Format("{0:yyyyMMddHHmmssff}", DateTime.Now) + ran.Next(100, 999) + CJBasic.Helpers.FileHelper.GetExtendName(sourcePath);
            //String newFileName = costumeID+String.Format("{0:yyyyMMddHHmmssff}", DateTime.Now) + ran.Next(100, 999) + CJBasic.Helpers.FileHelper.GetExtendName(sourcePath);
            return newFileName;
        }

        private static Random ran = new Random();
        private static string TimeStr()
        {
            int RandKey = ran.Next(100, 999);
            return String.Format("{0:yyyyMMddHHmmssff}", DateTime.Now) + RandKey;

        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            //重新生成文件名  json读取返回结果  
            InteractResult<CosCloudSignature> result = GlobalCache.ServerProxy.GetCosCloudSignature();
            if (result.ExeResult == ExeResult.Success)
            {
                CosCloudSignature cosCloudSignature = result.Data;

                VedioCosCloud = new CosCloud(cosCloudSignature.AppID, cosCloudSignature.Signature, 120);

                Dictionary<string, string> uploadParasDic = new Dictionary<string, string>();
                uploadParasDic.Add(CosParameters.PARA_BIZ_ATTR, "");
                uploadParasDic.Add(CosParameters.PARA_INSERT_ONLY, "0");
                //ImageHelp.GetNewFileName();
                string newFilename = GetNewFileName(this.skinTextBoxID.SkinTxt.Text.Trim(), CJBasic.Helpers.FileHelper.GetFileNameNoPath(txtVideo.SkinTxt.Text), txtVideo.SkinTxt.Text);

                string resultCloud = VedioCosCloud.UploadFile2(cosCloudSignature.BucketName, string.Format("/{0}/{1}", CommonGlobalCache.BusinessAccount.ID, newFilename), newFilename, AuthGetFileData(videoPath), uploadParasDic);
                //  JsonConvert.DeserializeObject(resultCloud);
                ResultJson ResultJ = (ResultJson)JavaScriptConvert.DeserializeObject(resultCloud, typeof(ResultJson));
                EmCostumePhoto EmCostumePhotoVedio = new EmCostumePhoto();
                if (ResultJ.code.ToString() == "0")
                {
                    Data dInfo = ResultJ.data;
                    EmCostumePhotoVedio.LinkAddress = dInfo.source_url;
                    EmCostumePhotoVedio.IsVideo = true;
                    EmCostumePhotoVedio.PhotoName = newFilename;
                    //  this.rtfRichTextBox_Detail.Text = dInfo.source_url;
                    //    ShowMessage("成功上传视频3" + dInfo.access_url);
                    WriteLog("成功上传视频：视频路径=" + dInfo.source_url);
                }
                else
                {
                    ShowMessage("视频上传失败！");
                    return;
                }

            }
            else
            {
                GlobalMessageBox.Show("获取腾讯云失败：" + result.Msg);
                return;
            }
        }
    }
}
