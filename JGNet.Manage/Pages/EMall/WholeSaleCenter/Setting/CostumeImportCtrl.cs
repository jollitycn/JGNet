using System; 

using System.Windows.Forms; 
using CJBasic.Security;
using JGNet.Common.Core;   
using CJBasic;
using System.IO;
using JGNet.Core.InteractEntity;
using System.Data;
using JieXi.Common;
using System.Collections.Generic;
using System.Drawing;
using JGNet.Common.Core.Util;
using JGNet.Common;
using System.Threading;

namespace JGNet.Manage
{
    public partial class CostumeImportCtrl : BaseModifyUserControl
    { 
         
        public CostumeImportCtrl()
        {
            InitializeComponent();
        } 

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            skinPanel1.Enabled = false;
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoImport);
                cb.BeginInvoke(null, null); ShowProgressForm();
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void DoImport()
        {
            try
            { 
                ImportExcel(path);
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
         
        private void CompleteEdit()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.CompleteEdit));
            }
            else
            {
                CompleteProgressForm();
                if (progressStop)
                {
                    this.Enabled = true;
                }
                else
                {
                    
                    //   GlobalMessageBox.Show("操作完毕！");
                    this.Enabled = true;
                }
            }
        }

         

        private void ImportExcel(String importPath)
        {
            try
            {
                
                List<ImportPfInfosPara> items = new List<ImportPfInfosPara>();
                List<ImportPfInfosPara> incorrectItems = new List<ImportPfInfosPara>();
                DataTable dt = NPOIHelper.FormatToDatatable(importPath, 0);


                if (dt.Rows.Count == 0)
                {
                    //没有任何记录
                    ShowMessage("没有可以导入的信息！");
                    CompleteEdit();
                    return;
                }
                InitProgress(dt.Rows.Count);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    UpdateProgress("加载数据："); 
                    if (progressStop)
                    {
                        break;
                    }
                    
                    DataRow row = dt.Rows[i];
                    ImportPfInfosPara item = new ImportPfInfosPara();
                    try
                    {
                        item.Index = i + 1;
                        item.CostumeID = CommonGlobalUtil.ConvertToString(row[0]);
                        item.BarCodeValue = CommonGlobalUtil.ConvertToString(row[1]);
                        item.Name = CommonGlobalUtil.ConvertToString(row[2]);
                        item.Colors = CommonGlobalUtil.ConvertToString(row[3]).Replace("，",",");
                        item.BigClass = CommonGlobalUtil.ConvertToString(row[4]);
                        item.Price = Convert.ToDecimal(row[5]);
                        item.PhotoName = CommonGlobalUtil.ConvertToString(row[6]);
                        item.IsNew = CommonGlobalUtil.ConvertToString(row[7])=="是";
                        item.IsHot = CommonGlobalUtil.ConvertToString(row[8])=="是";
                    }
                    catch (Exception ex)
                    {
                    }

                    if (!(String.IsNullOrEmpty(item.CostumeID) || String.IsNullOrEmpty(item.Name)))
                    {
                        item.CostumeID= CommonGlobalCache.GetCorrectCostumeID(item.CostumeID);
                        items.Add(item);
                    }
                    else
                    {
                        incorrectItems.Add(item);
                    }

                }
                if (incorrectItems.Count > 0)
                {
                    String str = string.Empty;
                    str = str.Substring(0, str.LastIndexOf(","));
                    ShowError("以下行数中，款号/名称为空，请重新检查！\r\n" + str);
                    return;
                }
                if (items == null || items.Count == 0)
                { 
                    ShowMessage("没有数据可以导入，请检查会员信息！");
                    return;
                }

                String failImgs=String.Empty;
                String tooLargeImgs = String.Empty;
                InitProgress(items.Count);
                foreach (var item in items)
                {
                    if (progressStop)
                    {
                        break;
                    }
                    UpdateProgress( "检查图片：");
                    //if (!String.IsNullOrEmpty(item.PhotoName))
                    //{
                    //找图片并上传
                    try
                    {
                        String imagePath = Path.GetDirectoryName(path) + "//" + item.PhotoName;
                        if (!File.Exists(imagePath))
                        {
                            failImgs += "第" + item.Index + "行 款号：" + item.CostumeID;
                            failImgs += "\r\n";
                        }
                        else
                        {
                            Image img = JGNet.Core.ImageHelper.FromFileStream(imagePath);
                            MemoryStream stream = new MemoryStream();
                            byte[] photo = stream.ToArray();
                            img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);
                            stream = new MemoryStream();
                            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                            photo = stream.ToArray();
                            if (photo.Length > 2097152)
                            {
                                tooLargeImgs += "第" + item.Index + "行 款号："  + item.CostumeID;
                                tooLargeImgs += "\r\n";
                                //return;
                            }
                        }

                       
                    }
                    catch (Exception ex)
                    {
                        FailedProgress(ex);  
                    }
                   // }
                }

                if (!String.IsNullOrEmpty(failImgs))
                {
                    FailedProgress(new Exception("以下图片不存在：" + "\r\n" + failImgs));  

                    return;
                }
                else if (!String.IsNullOrEmpty(tooLargeImgs))
                {
                    FailedProgress(new Exception("以下图片太大：" + "\r\n" + tooLargeImgs));  
                    return;
                }

                InteractResult result = GlobalCache.ServerProxy.ImportPfInfos(items);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        // ShowMessage(result.Msg);
                        FailedProgress(new Exception(result.Msg)); 
                        return;
                    default:
                        break;
                }
                try
                {
                    InitProgress(items.Count);
                    foreach (var item in items)
                    {
                        if (progressStop)
                        {
                            break;
                        } 
                      
                        UpdateProgress( "图片上传：");
                        //if (!String.IsNullOrEmpty(item.PhotoName))
                        //{
                        //找图片并上传
                        String[] colors = item.Colors.Split(',');

                        String imagePath = Path.GetDirectoryName(path) + "//" + item.PhotoName;
                        String newFileName = JGNet.Core.ImageHelper.GetNewFileName(item.CostumeID, item.PhotoName);
                        Image img = JGNet.Core.ImageHelper.FromFileStream(imagePath);
                        MemoryStream stream = new MemoryStream();
                        byte[] photo = stream.ToArray();
                        img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);
                        stream = new MemoryStream();
                        img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        photo = stream.ToArray();
                        EmCostumePhoto emPhoto = new EmCostumePhoto()
                        {
                            Image = img,
                            SavePath = imagePath,
                            IsMain = true,
                            CostumeID = item.CostumeID,
                            //ColorName = ValidateUtil.CheckEmptyValue(this.skinComboBox_Color.SelectedValue),
                            Bytes = photo,
                            PhotoName = newFileName
                        };
                        PhotoData data = new PhotoData()
                        {
                            Datas = emPhoto.Bytes,
                            EmCostumePhoto = emPhoto,
                            Name = item.PhotoName
                        };

                         WriteLog("UploadPhotoToCos:" + item.CostumeID);
                        GlobalCache.ServerProxy.UploadPhotoToCos(data);
                      //  Thread.Sleep(1000);
                    }
                    ShowMessage("导入成功！");
                }
                catch (Exception ex)
                {
                   FailedProgress(ex);
                     
                }

                CompleteEdit();
            }
            catch (Exception ex)
            {
                ShowError(ex); 
            }
            finally
            {
                UnLockPage();
                EnablePanel();
            }
        } 

        private void EnablePanel()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CbGeneric(this.EnablePanel));
            }
            else
            {
                skinPanel1.Enabled = true; 
            }
        }
        
        private void Display()
        {
            ResetAll();
        }

        private void ResetAll()
        { 
            this.textBoxPath.Text = null; 
        }
          

        String path;
        private void baseButtonChooseFile_Click(object sender, EventArgs e)
        {
            path = CJBasic.Helpers.FileHelper.GetFileToOpen("请选择导入文件");
            textBoxPath.Text = path;
            if (String.IsNullOrEmpty(path))
            {
                this.BaseButton3.Enabled = false;
            }
            else
            {

                string fileExt = Path.GetExtension(path);
                if (fileExt != ".xlsx" && fileExt != ".xls")
                {
                    ShowMessage("你所选择文件格式不正确，请重新上传文件！");
                    return;
                }
                this.BaseButton3.Enabled = true;

            }
        }
    }

}
