using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using System.Reflection;
using CJBasic.Security;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core;
using JGNet.Common;
using System.IO;
using CCWin.SkinControl;
using JGNet.Common.Core.Util;
using QCloud.CosApi.Api;
using Newtonsoft.Json;
using System.Xml;
using JGNet.Common.Models;
using JGNet.Common.Components;
using QCloud.CosApi.Common;
using JGNet.Core.Tools;

namespace JGNet.Manage.Pages
{
    public partial class EditEmallCtrl : BaseModifyUserControl
    {

        private EMall curEMall = null;

        private List<EmPosterImage> CostumePhotos { get; set; }
        private List<EmPosterImage> RemovePhotos { get; set; }

        private List<CostumeClass2> CostumeClassPhotos { get; set; }
        private List<CostumeClass2> RemoveClassPhotos { get; set; }

        private List<EmPosterImage> AdvCostumePhotos { get; set; }
        private List<EmPosterImage> AdvRemovePhotos { get; set; }

        public CosLoginInfo CosLoginInfo { get; private set; }
        public CosCloud CosCloud { get; private set; }
        public EditEmallCtrl()
        {
            InitializeComponent();
            SetUpCos();
            bannerImageControl1.Upload_Click += Upload_Click;
            //同步排序
            bannerImageControl1.TitleImageMoveUp += TitleImageMoveUp;
            bannerImageControl1.TitleImageMoveDown += TitleImageMoveDown;


            AdvertImageControl.Upload_Click += AdvUpload_Click;
            AdvertImageControl.TitleImageMoveUp += AdvTitleImageMoveUp;
            AdvertImageControl.TitleImageMoveDown += AdvTitleImageMoveDown;

            SetClass();
            //this.ClassImageControl.IsDisplayAddImage = false;
            ClassImageControl.Upload_Click += ClassUpload_Class;
            ClassImageControl.TitleImageMoveUp += ClassTitleImageMoveUp;
            ClassImageControl.TitleImageMoveDown += ClassTitleImageMoveDown;

            MenuPermission = RolePermissionMenuEnum.店铺信息;
        }
        private void TitleImageMoveUp(TitleImage sender, EventArgs e)
        {
            if (sender != null && sender.Tag != null &&
                 sender.Tag is EmPosterImage)
            {
                EmPosterImage moved = sender.Tag as EmPosterImage;
                int index = CostumePhotos.IndexOf(moved);
                if (index > 0)
                {
                    CostumePhotos.Remove(moved);
                    CostumePhotos.Insert(index - 1, moved);
                }
            }
        }

        private void AdvTitleImageMoveUp(TitleImage sender, EventArgs e)
        {
            if (sender != null && sender.Tag != null &&
                 sender.Tag is EmPosterImage)
            {
                EmPosterImage moved = sender.Tag as EmPosterImage;
                int index = AdvCostumePhotos.IndexOf(moved);
                if (index > 0)
                {
                    AdvCostumePhotos.Remove(moved);
                    AdvCostumePhotos.Insert(index - 1, moved);
                }
            }
        }
        //类别图片往上移动
        private void ClassTitleImageMoveUp(TitleImageOfCostumeClass sender, EventArgs e)
        {
            if (sender != null && sender.Tag != null &&
                 sender.Tag is CostumeClass2)
            {
                CostumeClass2 moved = sender.Tag as CostumeClass2;
                int index = CostumeClassPhotos.IndexOf(moved);
                if (index > 0)
                {
                    CostumeClassPhotos.Remove(moved);
                    CostumeClassPhotos.Insert(index - 1, moved);
                }
            }
        }
        private void TitleImageMoveDown(TitleImage sender, EventArgs e)
        {
            if (sender != null && sender.Tag != null &&
                 sender.Tag is EmPosterImage)
            {
                EmPosterImage moved = sender.Tag as EmPosterImage;
                int index = CostumePhotos.IndexOf(moved);
                if (index < CostumePhotos.Count - 1)
                {
                    CostumePhotos.Remove(moved);
                    CostumePhotos.Insert(index + 1, moved);
                }
            }
        }
        private void AdvTitleImageMoveDown(TitleImage sender, EventArgs e)
        {
            if (sender != null && sender.Tag != null &&
                 sender.Tag is EmPosterImage)
            {
                EmPosterImage moved = sender.Tag as EmPosterImage;
                int index = AdvCostumePhotos.IndexOf(moved);
                if (index < AdvCostumePhotos.Count - 1)
                {
                    AdvCostumePhotos.Remove(moved);
                    AdvCostumePhotos.Insert(index + 1, moved);
                }
            }
        }

        //类别图片往下移动
        private void ClassTitleImageMoveDown(TitleImageOfCostumeClass sender, EventArgs e)
        {
            if (sender != null && sender.Tag != null &&
                 sender.Tag is CostumeClass2)
            {
                CostumeClass2 moved = sender.Tag as CostumeClass2;
                int index = CostumeClassPhotos.IndexOf(moved);
                if (index < CostumeClassPhotos.Count - 1)
                {
                    CostumeClassPhotos.Remove(moved);
                    CostumeClassPhotos.Insert(index + 1, moved);
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
        //AdvUpload_Click
        private void AdvUpload_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = sender as Control;
                byte[] photo = null;
                if (AdvCostumePhotos != null)
                {
                    if (AdvCostumePhotos.Count >= 5)
                    {
                        GlobalMessageBox.Show("广告图片，最多上传5张！");
                        return;
                    }
                }
                string[] paths = CJBasic.Helpers.FileHelper.GetFilesToOpen("请选择要上传的图片");

                if (paths != null)
                {
                    if (AdvCostumePhotos != null && AdvCostumePhotos.Count + paths.Length > 5)
                    {
                        GlobalMessageBox.Show("广告图片，最多上传5张！");
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
                            img.Save(stream, img.RawFormat);
                            photo = stream.ToArray();
                            if (photo.Length > 2097152)
                            {
                                GlobalMessageBox.Show("图片太大，请重新上传！");
                                return;
                            }


                            img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);

                            stream = new MemoryStream();

                            System.Drawing.Imaging.ImageFormat imgFormat = getImageFormat(path);
                            img.Save(stream, imgFormat);
                            photo = stream.ToArray();

                            Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                            EmPosterImage emCostumePhoto = null;
                            String newFileName = JGNet.Core.ImageHelper.GetNewFileName(curEMall.BusinessAccountID
                                //  this.skinTextBox_ID.Text
                                , Path.GetFileName(path));
                            String savePath = GlobalUtil.EmallDir + newFileName;
                            Core.ImageHelper.Compress(img, savePath, 50);

                            path = savePath;

                            emCostumePhoto = new EmPosterImage()
                            {
                                BusinessAccountID = curEMall.BusinessAccountID,
                                Image = img,
                                SavePath = path,
                                Bytes = photo,
                                Type = 1,
                                // CostumeID = this.skinTextBox_ID.Text,                                  
                                PhotoName = newFileName
                            };
                            emCostumePhoto.Image = img;
                            //  GlobalMessageBox.Show("上传商品图片名称=" + emCostumePhoto.PhotoName);
                            //  WriteLog("图片="+emCostumePhoto.PhotoName);

                            if (AdvCostumePhotos == null || AdvCostumePhotos.Count < 5)
                            {
                                AdvAddPhoto(emCostumePhoto);

                                if (AdvCostumePhotos != null && AdvCostumePhotos.Count >= 5)
                                {
                                    //  ctrl.Visible = false;
                                    //  GlobalMessageBox.Show("上传店铺图片不能大于5张");
                                }
                                InsertAdvImage(this.AdvertImageControl, emCostumePhoto, thumbnailImage);
                            }
                            //if (sender is FlowLayoutPanel)
                            //{
                            //    InsertImage(sender as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                            //}
                            //else
                            //{
                            //    InsertImage(ctrl.Parent as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                            //}
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
        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = sender as Control;
                byte[] photo = null;
                if (CostumePhotos != null)
                {
                    if (CostumePhotos.Count >= 5)
                    {
                        GlobalMessageBox.Show("海报图片，最多上传5张！");
                        return;
                    }
                }
                string[] paths = CJBasic.Helpers.FileHelper.GetFilesToOpen("请选择要上传的图片");

                if (paths != null)
                {
                    if (CostumePhotos != null && CostumePhotos.Count + paths.Length > 5)
                    {
                        GlobalMessageBox.Show("海报图片，最多上传5张！");
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
                            img.Save(stream, img.RawFormat);
                            photo = stream.ToArray();
                            if (photo.Length > 2097152)
                            {
                                GlobalMessageBox.Show("图片太大，请重新上传！");
                                return;
                            }


                            img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);

                            stream = new MemoryStream();

                            System.Drawing.Imaging.ImageFormat imgFormat = getImageFormat(path);
                            img.Save(stream, imgFormat);
                            photo = stream.ToArray();

                            Image thumbnailImage = img.GetThumbnailImage(64, 64, null, new IntPtr());
                            EmPosterImage emCostumePhoto = null;
                            String newFileName = JGNet.Core.ImageHelper.GetNewFileName(curEMall.BusinessAccountID
                                //  this.skinTextBox_ID.Text
                                , Path.GetFileName(path));
                            String savePath = GlobalUtil.EmallDir + newFileName;
                            Core.ImageHelper.Compress(img, savePath, 50);

                            path = savePath;

                            emCostumePhoto = new EmPosterImage()
                            {
                                BusinessAccountID = curEMall.BusinessAccountID,
                                Image = img,
                                SavePath = path,
                                Bytes = photo,
                                Type = 0,
                                // CostumeID = this.skinTextBox_ID.Text,                                  
                                PhotoName = newFileName
                            };
                            emCostumePhoto.Image = img;
                            //  GlobalMessageBox.Show("上传商品图片名称=" + emCostumePhoto.PhotoName);
                            //  WriteLog("图片="+emCostumePhoto.PhotoName);

                            if (CostumePhotos == null || CostumePhotos.Count < 5)
                            {
                                AddPhoto(emCostumePhoto);

                                if (CostumePhotos != null && CostumePhotos.Count >= 5)
                                {
                                    //  ctrl.Visible = false;
                                    //  GlobalMessageBox.Show("上传店铺图片不能大于5张");
                                }
                                InsertImage(this.bannerImageControl1, emCostumePhoto, thumbnailImage);
                            }
                            //if (sender is FlowLayoutPanel)
                            //{
                            //    InsertImage(sender as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                            //}
                            //else
                            //{
                            //    InsertImage(ctrl.Parent as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                            //}
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
        private void ClassUpload_Class(object sender, EventArgs e)
        {
            try
            {
                Control ctrl = sender as Control;
                byte[] photo = null;
                //if (CostumeClassPhotos != null)
                //{
                //    GlobalMessageBox.Show("商品图片数量=" + CostumeClassPhotos.Count);
                //}
                if (CostumeClassPhotos != null)
                {
                    if (CostumeClassPhotos.Count >= 6)
                    {
                        GlobalMessageBox.Show("类别分类图片，最多上传6张！");
                        return;
                    }
                }
                string[] paths = CJBasic.Helpers.FileHelper.GetFilesToOpen("请选择要上传的图片");

                if (paths != null)
                {
                    if (CostumeClassPhotos != null && CostumeClassPhotos.Count + paths.Length > 6)
                    {
                        GlobalMessageBox.Show("类别分类图片，最多上传6张！");
                        return;
                    }

                    if (paths != null)
                    {
                        bool flagClassHasOtherFile = false;
                        foreach (var checkimg in paths)
                        {
                            if (!IsImage(checkimg))
                            {
                                flagClassHasOtherFile = true;
                                break;
                            }
                        }
                        if (flagClassHasOtherFile)
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
                            img.Save(stream, img.RawFormat);
                            photo = stream.ToArray();
                            if (photo.Length > 2097152)
                            {
                                GlobalMessageBox.Show("图片太大，请重新上传！");
                                return;
                            }


                            img = JGNet.Core.ImageHelper.GetNewSizeImage(img, 800);

                            System.Drawing.Imaging.ImageFormat imgFormat = getImageFormat(path);
                            stream = new MemoryStream();
                            img.Save(stream, imgFormat);
                            photo = stream.ToArray();

                            Image thumbnailImage = img.GetThumbnailImage(54, 54, null, new IntPtr());
                            CostumeClass2 costumeClass2 = null;
                            //  EmPosterImage emCostumePhoto = null;
                            String newFileName = JGNet.Core.ImageHelper.GetNewFileName(curEMall.BusinessAccountID
                                //  this.skinTextBox_ID.Text
                                , Path.GetFileName(path));
                            String savePath = GlobalUtil.EmallDir + newFileName;
                           
                            Core.ImageHelper.Compress(img, savePath, 50);
                            path = savePath;

                            //  CommonGlobalCache.GetCostumeClass4Code
                            //sName = CommonGlobalCache.ServerProx.GetClassCode4ID（Convert.ToInt32( (ValidateUtil.CheckEmptyValue(skinComboBox_Class.SelectedValue))).ClassName;


                            CostumeClass2 classItem = (CostumeClass2)this.skinComboBox_Class.SelectedItem;
                            costumeClass2 = new CostumeClass2()
                            {
                                PhotoUrl = path,
                                ClassCode = classItem.ClassCode,
                                AutoID = classItem.AutoID,
                                ClassName = classItem.ClassName,
                                Datas = photo,
                                /* BusinessAccountID = curEMall.BusinessAccountID,
                                 Image = img,
                                 SavePath = path,
                                 Bytes = photo,
                                 // CostumeID = this.skinTextBox_ID.Text,                                  
                                 PhotoName = newFileName*/
                            };
                            costumeClass2.PhotoUrl = path;

                           
                            //  GlobalMessageBox.Show("上传商品图片名称=" + emCostumePhoto.PhotoName);
                            //  WriteLog("图片="+emCostumePhoto.PhotoName);

                            if (CostumeClassPhotos == null || CostumeClassPhotos.Count < 6)
                            {
                                AddClassPhoto(costumeClass2);

                                if (CostumeClassPhotos != null && CostumeClassPhotos.Count >= 6)
                                {
                                    //  ctrl.Visible = false;
                                    //  GlobalMessageBox.Show("上传店铺图片不能大于5张");
                                }
                                InsertClassImage(this.ClassImageControl, costumeClass2, thumbnailImage);
                            }
                            //if (sender is FlowLayoutPanel)
                            //{
                            //    InsertImage(sender as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                            //}
                            //else
                            //{
                            //    InsertImage(ctrl.Parent as FlowLayoutPanel, emCostumePhoto, thumbnailImage);
                            //}
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

        private void RemoveDisposedCostumeClassPhoto()
        {

            string strLog = "\r\n界面删除类别图片总数量=" + deleteClassCount + " \r 数据库上RemoveClassPhotos数量=";
            if (RemoveClassPhotos != null)
            {
                strLog += +RemoveClassPhotos.Count + "\r\n";
                for (int i = 0; i < RemoveClassPhotos.Count; i++)
                {
                    CostumeClass2 photo = RemoveClassPhotos[i];
                    strLog += "删除服务器（数据库）类别图片上第" + i + "张图片：" + photo.PhotoUrl + "\r\n";
                    if (!String.IsNullOrEmpty(photo.PhotoUrl))
                    {
                        //删除原来的文件
                        GlobalCache.ServerProxy.DeleteClassPhotoUrl(photo.AutoID);
                    }
                }

            }
            //if (RemovePhotos != null && RemovePhotos.Count > 0)
            //{
            //    RemovePhotos.Clear();
            //}
            WriteLog(strLog);
        }
        private void RemoveDisposedCostumePhoto()
        {

            string strLog = "\r\n界面删除总数量=" + deleteCount + " \r 数据库上RemovePhotos数量=";
            if (RemovePhotos != null)
            {
                strLog += +RemovePhotos.Count + "\r\n";
                for (int i = 0; i < RemovePhotos.Count; i++)
                {
                    EmPosterImage photo = RemovePhotos[i];
                    strLog += "删除服务器（数据库）上第" + i + "张图片：" + photo.LinkAddress + "\r\n";
                    if (!String.IsNullOrEmpty(photo.LinkAddress))
                    {
                        //删除原来的文件
                        GlobalCache.ServerProxy.DeletePosterImage(photo.PhotoName);
                    }
                }

            }
            //if (RemovePhotos != null && RemovePhotos.Count > 0)
            //{
            //    RemovePhotos.Clear();
            //}
            WriteLog(strLog);
        }
        private void RemoveDisposedAdvPhoto()
        {

            string strLog = "\r\n界面删除总数量=" + deleteAdvCount + " \r 数据库上AdvRemovePhotos数量=";
            if (AdvRemovePhotos != null)
            {
                strLog += +AdvRemovePhotos.Count + "\r\n";
                for (int i = 0; i < AdvRemovePhotos.Count; i++)
                {
                    EmPosterImage photo = AdvRemovePhotos[i];
                    strLog += "删除服务器（数据库）上第" + i + "张图片：" + photo.LinkAddress + "\r\n";
                    if (!String.IsNullOrEmpty(photo.LinkAddress))
                    {
                        //删除原来的文件
                        GlobalCache.ServerProxy.DeletePosterImage(photo.PhotoName);
                    }
                }

            }
            //if (RemovePhotos != null && RemovePhotos.Count > 0)
            //{
            //    RemovePhotos.Clear();
            //}
            WriteLog(strLog);
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
            if (CostumePhotos.Count >= i + 1)
            {
                skinProgressBar1.Value = i + 1;
            }
        }
        private void UpdateDisplayIndex()
        {
            try
            {
                if (CostumePhotos != null)
                {
                    List<UpdateDisplayIndex> para = new List<UpdateDisplayIndex>();
                    WriteLog("更新下标时图片总数=" + CostumePhotos.Count);
                    for (int i = 0; i < CostumePhotos.Count; i++)
                    {
                        CostumePhotos[i].DisplayIndex = i;
                        para.Add(new Core.InteractEntity.UpdateDisplayIndex()
                        {
                            PhotoName = CostumePhotos[i].PhotoName,
                            // DisplayIndex = CostumePhotos[i].DisplayIndex
                            DisplayIndex = i,
                        });
                    }
                    GlobalCache.ServerProxy.UpdatePosterImageIndexs(para);
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show(ex.Message);
            }
        }

        private void UpdateDisplayAdvIndex()
        {
            try
            {
                if (AdvCostumePhotos != null)
                {
                    List<UpdateDisplayIndex> para = new List<UpdateDisplayIndex>();
                    WriteLog("更新下标时图片总数=" + AdvCostumePhotos.Count);
                    for (int i = 0; i < AdvCostumePhotos.Count; i++)
                    {
                        AdvCostumePhotos[i].DisplayIndex = i;
                        para.Add(new Core.InteractEntity.UpdateDisplayIndex()
                        {
                            PhotoName = AdvCostumePhotos[i].PhotoName,
                            // DisplayIndex = CostumePhotos[i].DisplayIndex
                            DisplayIndex = i,
                        });
                    }
                    GlobalCache.ServerProxy.UpdatePosterImageIndexs(para);
                }
            }
            catch (Exception ex)
            {
                GlobalMessageBox.Show(ex.Message);
            }
        }


        private void AddRemovePhotos(EmPosterImage item)
        {
            if (RemovePhotos == null)
            {
                RemovePhotos = new List<EmPosterImage>();
            }
            WriteLog("将当前删除图片添加到List：" + item.LinkAddress + "\r\n");
            RemovePhotos.Add(item);
        }

        private void AddRemoveClassPhotos(CostumeClass2 item)
        {
            if (RemoveClassPhotos == null)
            {
                RemoveClassPhotos = new List<CostumeClass2>();
            }
            // WriteLog("将当前删除图片添加到List：" + item.LinkAddress + "\r\n");
            RemoveClassPhotos.Add(item);
        }

        private int deleteCount = 0;
        private int deleteClassCount = 0;
        private int deleteAdvCount = 0;
        /// <summary>
        /// 删除图片的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPic_Disposed(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                deleteCount++;
                TitleImage pic = sender as TitleImage;
                CostumePhotos.Remove(pic.Tag as EmPosterImage);
                AddRemovePhotos(pic.Tag as EmPosterImage);

                EmPosterImage eImage = (EmPosterImage)pic.Tag;
                WriteLog("删除图片：" + eImage.LinkAddress + "\r" + eImage.PhotoName + "\r\n");
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

        //广告图片移除
        /// <summary>
        /// 广告图片移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdvPic_Disposed(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                deleteAdvCount++;
                TitleImage pic = sender as TitleImage;
                AdvCostumePhotos.Remove(pic.Tag as EmPosterImage);
                AddRemovePhotos(pic.Tag as EmPosterImage);

                EmPosterImage eImage = (EmPosterImage)pic.Tag;
                WriteLog("删除图片：" + eImage.LinkAddress + "\r" + eImage.PhotoName + "\r\n");
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
        /// <summary>
        /// 类别图片移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassPic_Disposed(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                deleteClassCount++;
                TitleImageOfCostumeClass pic = sender as TitleImageOfCostumeClass;
                CostumeClassPhotos.Remove(pic.Tag as CostumeClass2);
                AddRemoveClassPhotos(pic.Tag as CostumeClass2);

                CostumeClass2 eImage = (CostumeClass2)pic.Tag;
                // WriteLog("删除图片：" + eImage.LinkAddress + "\r" + eImage.PhotoName + "\r\n");
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


        /// <summary>
        /// 添加图片实体类
        /// </summary>
        /// <param name="photo"></param>
        private void AddPhoto(EmPosterImage photo)
        {
            if (CostumePhotos == null) { CostumePhotos = new List<EmPosterImage>(); }
            this.CostumePhotos.Add(photo);
            photo.Image.Tag = photo;
        }

        /// <summary>
        /// 添加广告图片实体类
        /// </summary>
        /// <param name="photo"></param>
        private void AdvAddPhoto(EmPosterImage photo)
        {
            if (AdvCostumePhotos == null) { AdvCostumePhotos = new List<EmPosterImage>(); }
            this.AdvCostumePhotos.Add(photo);
            photo.Image.Tag = photo;
        }
        /// <summary>
        /// 添加类型图片实体类
        /// </summary>
        /// <param name="photo"></param>
        private void AddClassPhoto(CostumeClass2 photo)
        {
            if (CostumeClassPhotos == null) { CostumeClassPhotos = new List<CostumeClass2>(); }
            this.CostumeClassPhotos.Add(photo);
            // photo.Image.Tag = photo;
        }
        /// <summary>
        /// 添加展示图片使用缩率图
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="emCostumePhoto"></param>
        /// <param name="img"></param>
        /*  private void InsertImage(FlowLayoutPanel flowLayoutPanel, EmPosterImage emCostumePhoto, Image img)
          {
              Image thumbnailImage = img?.GetThumbnailImage(64, 64, null, new IntPtr());
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
              InsertImage(this.bannerImageControl1, emCostumePhoto, img);
              //}

          }*/

        private void InsertClassImage(ClassImageControl flowLayoutPanel, CostumeClass2 emCostumePhoto, Image img)
        {
            Image thumbnailImage = img?.GetThumbnailImage(50, 50, null, new IntPtr());

            TitleImageOfCostumeClass pic = new TitleImageOfCostumeClass()
            {
                Image = thumbnailImage,
                Tag = emCostumePhoto,
                Title = emCostumePhoto.ClassName,
            };
            pic.Disposed += ClassPic_Disposed;
            flowLayoutPanel.AddTitleImage(pic);

        }
        /// <summary>
        /// 添加展示图片使用缩率图
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="emCostumePhoto"></param>
        /// <param name="img"></param>
        private void InsertImage(BannerImageControl flowLayoutPanel, EmPosterImage emCostumePhoto, Image img)
        {
            Image thumbnailImage = img?.GetThumbnailImage(64, 64, null, new IntPtr());
            TitleImage pic = new TitleImage()
            {
                Image = thumbnailImage,
                Tag = emCostumePhoto,
                //   Title=emCostumePhoto.PhotoName
            };
            pic.Disposed += ColorPic_Disposed;
            flowLayoutPanel.AddTitleImage(pic);

        }
        /// <summary>
        /// 新增一张广告图片
        /// </summary>
        /// <param name="flowLayoutPanel"></param>
        /// <param name="emCostumePhoto"></param>
        /// <param name="img"></param>
        private void InsertAdvImage(BannerImageControl flowLayoutPanel, EmPosterImage emCostumePhoto, Image img)
        {
            Image thumbnailImage = img?.GetThumbnailImage(64, 64, null, new IntPtr());
            TitleImage pic = new TitleImage()
            {
                Image = thumbnailImage,
                Tag = emCostumePhoto,
                //   Title=emCostumePhoto.PhotoName
            };
            pic.Disposed += AdvPic_Disposed;
            flowLayoutPanel.AddTitleImage(pic);

        }

        private void LoadPosterImages()
        {

            try
            {
                //加载广告图片
                if (curEMall.PosterImages != null)
                {
                    int posterImageNum = 0;
                    foreach (EmPosterImage emPhoto in curEMall.PosterImages)
                    {
                        posterImageNum++;
                        if (posterImageNum > 5)
                        {
                            break;
                        }
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

                        String savePath = GlobalUtil.EmallDir + Path.GetFileName(emPhoto.LinkAddress);
                        //引用前必须释放所有图片文件的使用权
                        Image img = null;
                        try
                        {
                            if (!IsCheckImg(emPhoto.LinkAddress))
                            {
                                continue;
                            }
                            img = Image.FromStream(System.Net.WebRequest.Create(emPhoto.LinkAddress).GetResponse().GetResponseStream());
                        }
                        catch (Exception ex)
                        {
                            //下载失败，可能文件被占用，直接使用该文件即可。
                            //文件找不到使用默认图片，找不到
                        }
                        emPhoto.Image = img;

                        MemoryStream stream = new MemoryStream();
                        //photo = stream.ToArray();
                        //  stream = new MemoryStream(); 
                        /*  if (img.RawFormat != null)
                          {
                              img.Save(stream, img.RawFormat);
                          }
                          else
                          {*/
                        // Path.GetExtension

                        System.Drawing.Imaging.ImageFormat imgFormat = getImageFormat(emPhoto.LinkAddress);
                        
                        img.Save(stream, imgFormat);
                        // }

                        emPhoto.Bytes = stream.ToArray();

                        AddPhoto(emPhoto);
                        InsertImage(this.bannerImageControl1, emPhoto, img);

                    }

                }
            }
            catch (Exception ex)
            {
                WriteLog("Message：" + ex.Message + "StackTrace：" + ex.StackTrace);
                GlobalUtil.ShowError(ex);
            }
        }

        private void LoadAdvImages()
        {
            try
            {  
            //加载广告图片
            if (curEMall.AdsList != null)
            {
                this.AdvertImageControl.Clear();
                int advImageNum = 0;
                foreach (EmPosterImage emPhoto in curEMall.AdsList)
                {
                    advImageNum++;
                    if (advImageNum > 5)
                    {
                        break;
                    }
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

                    String savePath = GlobalUtil.EmallDir + Path.GetFileName(emPhoto.LinkAddress);
                    //item.LinkAddress.Substring(item.LinkAddress.LastIndexOf());
                    //引用前必须释放所有图片文件的使用权
                    Image img = null;
                    try
                    {
                        /* if (!File.Exists(savePath))
                         {
                             CosCloud.DownloadFile(CosLoginInfo.BucketName, emPhoto.LinkAddress, savePath);
                         }

                         if (!IsImage(savePath))
                         {
                             continue;
                         }
                         img = JGNet.Core.ImageHelper.FromFileStream(savePath);*/
                        if (!IsCheckImg(emPhoto.LinkAddress))
                        {
                            continue;
                        }
                        img = Image.FromStream(System.Net.WebRequest.Create(emPhoto.LinkAddress).GetResponse().GetResponseStream());
                    }
                    catch (Exception ex)
                    {
                        //下载失败，可能文件被占用，直接使用该文件即可。
                        //文件找不到使用默认图片，找不到
                    }
                 
                    emPhoto.Image = img;

                    MemoryStream stream = new MemoryStream();
                        //photo = stream.ToArray();
                        //  stream = new MemoryStream(); 
                        /*  if (img.RawFormat != null)
                          {
                              img.Save(stream, img.RawFormat);
                          }
                          else
                          {*/

                        System.Drawing.Imaging.ImageFormat imgFormat = getImageFormat(emPhoto.LinkAddress);
                        img.Save(stream, imgFormat);
                   // }

                    emPhoto.Bytes = stream.ToArray();

                    AdvAddPhoto(emPhoto);
                    InsertAdvImage(this.AdvertImageControl, emPhoto, img);
                    //}
                    //else
                    //{
                    //    InsertImage(this.flowLayoutPanel2, item, img);
                    //}
                }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Message：" + ex.Message + "StackTrace：" + ex.StackTrace);
                GlobalUtil.ShowError(ex);
            }
        }
        private void LoadClassImages()
        {
            try
            {
                if (curEMall.CostumeClass2s != null)
                {
                    ClassImageControl.Clear();
                    List<CostumeClass2> classList = curEMall.CostumeClass2s;
                    int classImageNum = 0;
                    foreach (CostumeClass2 emPhoto in classList)
                    {

                        classImageNum++;
                        if (classImageNum > 6)
                        {
                            break;
                        }
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

                        String savePath = GlobalUtil.EmallDir + Path.GetFileName(emPhoto.PhotoUrl);

                        Image img = null;
                        try
                        {
                            if (!IsCheckImg(emPhoto.PhotoUrl))
                            {
                                continue;
                            }
                            img = Image.FromStream(System.Net.WebRequest.Create(emPhoto.PhotoUrl).GetResponse().GetResponseStream());

                        }
                        catch (Exception ex)
                        {
                            //下载失败，可能文件被占用，直接使用该文件即可。
                            //文件找不到使用默认图片，找不到
                        }
                        //  emPhoto.Image = img; 

                        MemoryStream stream = new MemoryStream();
                        // ShowMessage(Path.GetFileName(emPhoto.PhotoUrl));
                        System.Drawing.Imaging.ImageFormat imgFormat = getImageFormat(emPhoto.PhotoUrl);
                        img.Save(stream, imgFormat);

                        emPhoto.Datas = stream.ToArray();

                        AddClassPhoto(emPhoto);
                        InsertClassImage(this.ClassImageControl, emPhoto, img);

                    }
                }
            }
            catch (Exception ex)
            {
                WriteLog("Message：" + ex.Message + "StackTrace：" + ex.StackTrace);
                GlobalUtil.ShowError(ex);
            }
        }
        private void LoadPic()
        {
            try
            {
                this.bannerImageControl1.Clear(); 
                //获取广告图片
                // InteractResult<List<EmPosterImage>> result = GlobalCache.ServerProxy.GetEmPosterImages();
                 
                //获取类别图片

                if (curEMall != null)
                {
                    LoadPosterImages();
                    LoadAdvImages();
                    LoadClassImages(); 
                    this.skinCheckBox_DisplayOfAdv.Checked = curEMall.IsShowAdsPhoto;
                    this.skinCheckBox_DisplayOfClass.Checked = curEMall.IsShowClassPhoto;
                }
            }
            catch (Exception ex)
            {
                WriteLog("Message：" + ex.Message+ "StackTrace：" + ex.StackTrace);
                GlobalUtil.ShowError(ex);
            }
        }
        private List<Zone> resultList;//当前被绑定的源 
        private void EditEmallCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                // bannerImageControl1.Upload_Click += Upload_Click;
                string jsonText = File.ReadAllText(@"CitySelectForm.dat");
                resultList = (List<Zone>)JavaScriptConvert.DeserializeObject(jsonText, typeof(List<Zone>));
                List<Province> provinces = new List<Province>();
                foreach (var zone in resultList)
                {
                    provinces.AddRange(zone.Province);
                }
                skinComboBoxProvince.DisplayMember = "Name";
                skinComboBoxProvince.ValueMember = "Name";
                skinComboBoxProvince.DataSource = provinces;


                curEMall = GlobalCache.EMallServerProxy.GetEMall();

                if (curEMall == null)
                {

                    curEMall = new EMall();
                }
                else {
                    WriteLog("获取LogoUrl=" + curEMall.LogoUrl+ "\r BusinessAccountID=" + curEMall.BusinessAccountID+ "\r Name=" + curEMall.Name + "\r PosterImage=" + curEMall.PosterImage);   
                }
                // AutoInsertTitleImage();

               SetClass();
                Display();
                LoadPic();
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }
        InteractResult<List<CostumeClass2>> classList= GlobalCache.ServerProxy.GetBigClassList();
        private void SetClass()
        {
            //skinComboBox_Class
           
            if (classList.Data != null)
            { 
                skinComboBox_Class.DisplayMember = "ClassName";
                skinComboBox_Class.ValueMember = "AutoID";
                skinComboBox_Class.DataSource = classList.Data;
            }
        }
        private void SetUpCos()
        {
            this.CosLoginInfo = GlobalCache.CosLoginInfo;
            if (CosLoginInfo != null)
            {
                //创建cos对象
                this.CosCloud = new CosCloud(CosLoginInfo.AppID, CosLoginInfo.SecretId, CosLoginInfo.SecretKey);
            }
        }
        //  EmCostumePhoto banner = null;
        private void UploadBannerImag()
        {
            try
            {
               // GlobalCache.ServerProxy.InsertEmCostumePhoto(new EmCostumePhoto);
                if (CostumePhotos != null)
                {
                    //  WriteLog("图片数量="+CostumePhotos.Count);
                    string strPhoto = "";
                    foreach (EmPosterImage em in CostumePhotos)
                    {
                        strPhoto += "PhotoName=" + em.PhotoName + "地址=" + em.SavePath + "\r\n";
                    }

                    for (int i = 0; i < CostumePhotos.Count; i++)
                    {

                        EmPosterImage photo = CostumePhotos[i];
                        photo.DisplayIndex = i;
                        // photo.CostumeID = this.skinTextBox_ID.Text;
                        photo.BusinessAccountID = curEMall.BusinessAccountID;
                        //  photo.PhotoName = photo.PhotoName+i;
                        if (String.IsNullOrEmpty(photo.LinkAddress))
                        {
                            //文件重复？提示？缩略图每次都变？？？？
                            if (!String.IsNullOrEmpty(photo.SavePath))
                            {
                                //这里还是要给新图片名称，下面取回来对应过去。才有LINKADDRESS
                                PosterImage para = new PosterImage()
                                {
                                    EmPosterImage = photo,
                                    Datas = photo.Bytes,


                                };
                                strPhoto += "上传第" + i + "张图片" + photo.PhotoName + "\r\n";
                                //  GlobalCache.ServerProxy.UploadPosterImageToCos(para);
                                EmPosterImage emPhoto= UploadPosterImageTocos(para,0,Path.GetExtension(photo.SavePath));
                                GlobalCache.ServerProxy.InsertEmPosterImage(emPhoto);
                            }
                        }

                        this.BeginInvoke(new CJBasic.CbGeneric<int>(ShowProgress), i);
                    }
                    // CostumePhotos.Clear();
                    GlobalUtil.WriteLog("图片信息=" + strPhoto);


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

        private void UploadClassImg()
        { 
            try
            { 
                if (CostumeClassPhotos != null)
                {
                    //  WriteLog("图片数量="+CostumePhotos.Count);
                    string strPhoto = "";
                    foreach (CostumeClass2 classItem in CostumeClassPhotos)
                    {
                        strPhoto += "AutoID=" + classItem.AutoID + "ClassName=" + classItem.ClassName + "\r\n";
                    }

                    for (int i = 0; i < CostumeClassPhotos.Count; i++)
                    {

                        CostumeClass2 photo = CostumeClassPhotos[i];
                      //  photo.DisplayIndex = i;
                        // photo.CostumeID = this.skinTextBox_ID.Text;
                      //  photo.BusinessAccountID = curEMall.BusinessAccountID;
                        //  photo.PhotoName = photo.PhotoName+i;
                        //if (String.IsNullOrEmpty(photo.LinkAddress))
                        //{
                            //文件重复？提示？缩略图每次都变？？？？
                            if (!String.IsNullOrEmpty(photo.PhotoUrl))
                            {
                                //这里还是要给新图片名称，下面取回来对应过去。才有LINKADDRESS
                                CostumeClass2 para = new CostumeClass2()
                                {
                                     AutoID= photo.AutoID,
                                      ClassName=photo.ClassName,
                                        PhotoUrl=photo.PhotoUrl,
                                       Datas=photo.Datas,
                                   // Datas = photo.Bytes,


                                };
                                strPhoto += "上传第" + i + "张图片" + photo.ClassName + "\r\n";
                            //  GlobalCache.ServerProxy.UploadPosterImageToCos(para);
                            CostumeClass2 emPhoto = UploadClassImageTocos(para,curEMall.BusinessAccountID,photo.Datas,Path.GetExtension(photo.PhotoUrl));
                            GlobalCache.ServerProxy.UpdateClassPhotoUrl(para.AutoID, emPhoto.PhotoUrl);
                                //GlobalCache.ServerProxy.InsertEmPosterImage(emPhoto);
                            }
                        //}

                        this.BeginInvoke(new CJBasic.CbGeneric<int>(ShowProgress), i);
                    }
                    // CostumePhotos.Clear();
                    GlobalUtil.WriteLog("图片信息=" + strPhoto);


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

        private void UploadAdvImag()
        {
            try
            {
                // GlobalCache.ServerProxy.InsertEmCostumePhoto(new EmCostumePhoto);
                if (AdvCostumePhotos != null)
                {
                    //  WriteLog("图片数量="+CostumePhotos.Count);
                    string strPhoto = "";
                    foreach (EmPosterImage em in AdvCostumePhotos)
                    {
                        strPhoto += "PhotoName=" + em.PhotoName + "地址=" + em.SavePath + "\r\n";
                    }

                    for (int i = 0; i < AdvCostumePhotos.Count; i++)
                    {

                        EmPosterImage photo = AdvCostumePhotos[i];
                        photo.DisplayIndex = i;
                        // photo.CostumeID = this.skinTextBox_ID.Text;
                        photo.BusinessAccountID = curEMall.BusinessAccountID;
                        //  photo.PhotoName = photo.PhotoName+i;
                        if (String.IsNullOrEmpty(photo.LinkAddress))
                        {
                            //文件重复？提示？缩略图每次都变？？？？
                            if (!String.IsNullOrEmpty(photo.SavePath))
                            {
                                //这里还是要给新图片名称，下面取回来对应过去。才有LINKADDRESS
                                PosterImage para = new PosterImage()
                                {
                                    EmPosterImage = photo,
                                    Datas = photo.Bytes,
                                     

                                };
                                strPhoto += "上传第" + i + "张图片" + photo.PhotoName + "\r\n";
                                //  GlobalCache.ServerProxy.UploadPosterImageToCos(para);

                                EmPosterImage emPhoto = UploadPosterImageTocos(para, 1,Path.GetExtension(photo.SavePath) );
                                GlobalCache.ServerProxy.InsertEmPosterImage(emPhoto);
                            }
                        }

                        this.BeginInvoke(new CJBasic.CbGeneric<int>(ShowProgress), i);
                    }
                    // CostumePhotos.Clear();
                    GlobalUtil.WriteLog("图片信息=" + strPhoto);


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



        CosCloud VedioCosCloud;

        
             private CostumeClass2 UploadClassImageTocos(CostumeClass2 para,string BusinessAccountID, byte[] imgcontent,string imgextType)
        {
            try
            {
                InteractResult<CosCloudSignature> Signatureresult = GlobalCache.ServerProxy.GetCosCloudSignature();
                if (Signatureresult.ExeResult == ExeResult.Success)
                {
                    CosCloudSignature cosCloudSignature = Signatureresult.Data;

                    VedioCosCloud = new CosCloud(cosCloudSignature.AppID, cosCloudSignature.Signature, 120);


                   // para.EmPosterImage.PhotoName = JGNet.Core.ImageHelper.GetNewJpgName( BusinessAccountID);
                    // CosCloud cos = new CosCloud(cosLoginInfo.AppID, cosLoginInfo.SecretId, cosLoginInfo.SecretKey);
                    Dictionary<string, string> uploadParasDic = new Dictionary<string, string>();
                    uploadParasDic.Add(CosParameters.PARA_BIZ_ATTR, "");
                    uploadParasDic.Add(CosParameters.PARA_INSERT_ONLY, "0");
                    string result = VedioCosCloud.UploadFile2(cosCloudSignature.BucketName, string.Format("/{0}/{1}", BusinessAccountID, para.ClassName+ imgextType),
                        para.ClassName+ imgextType, imgcontent, uploadParasDic);
                    // JObject jObject = (JObject)JsonConvert.DeserializeObject(result);
                    ResultJson ResultJ = (ResultJson)JavaScriptConvert.DeserializeObject(result, typeof(ResultJson));
                    if (ResultJ.code.ToString() == "0")
                    {
                        Data dInfo = ResultJ.data;
                        string source_url = dInfo.source_url.ToString();
                       // para.EmPosterImage.LinkAddress = source_url;
                        CostumeClass2 emPhoto = new CostumeClass2();
                        emPhoto.PhotoUrl = dInfo.source_url;
                        emPhoto.AutoID = para.AutoID;
                        emPhoto.ClassName = para.ClassName;
                        //emPhoto.BusinessAccountID = para.EmPosterImage.BusinessAccountID;
                        //emPhoto.DisplayIndex = para.EmPosterImage.DisplayIndex;

                        //emPhoto.Type = type;
                        return emPhoto;
                    }
                    else
                    {
                        throw new Exception(string.Format("上传【{0}】类别图发生错误-【{1}】", para.ClassName, result));
                    }
                    // return para.EmPosterImage.LinkAddress;
                }
            }
            catch (Exception ee)
            {
                //  this.loggerManager.InsertErrorLog(string.Format("{0}.{1}", this.namespaceAndClassName, MethodBase.GetCurrentMethod().Name), ee);
                // return null;
            }
            return new CostumeClass2();
        }

        private EmPosterImage UploadPosterImageTocos(PosterImage para,byte type,string ImgExtType)
        {
            try
            {
                InteractResult<CosCloudSignature> Signatureresult = GlobalCache.ServerProxy.GetCosCloudSignature();
                if (Signatureresult.ExeResult == ExeResult.Success)
                {
                    CosCloudSignature cosCloudSignature = Signatureresult.Data;

                    VedioCosCloud = new CosCloud(cosCloudSignature.AppID, cosCloudSignature.Signature, 120);


                    para.EmPosterImage.PhotoName = JGNet.Core.ImageHelper.GetNewImageName(para.EmPosterImage.BusinessAccountID, ImgExtType);
                   // CosCloud cos = new CosCloud(cosLoginInfo.AppID, cosLoginInfo.SecretId, cosLoginInfo.SecretKey);
                    Dictionary<string, string> uploadParasDic = new Dictionary<string, string>();
                    uploadParasDic.Add(CosParameters.PARA_BIZ_ATTR, "");
                    uploadParasDic.Add(CosParameters.PARA_INSERT_ONLY, "0");
                    string result = VedioCosCloud.UploadFile2(cosCloudSignature.BucketName, string.Format("/{0}/{1}", para.EmPosterImage.BusinessAccountID, para.EmPosterImage.PhotoName),
                        para.EmPosterImage.PhotoName, para.Datas, uploadParasDic);
                   // JObject jObject = (JObject)JsonConvert.DeserializeObject(result);
                    ResultJson ResultJ = (ResultJson)JavaScriptConvert.DeserializeObject(result, typeof(ResultJson));
                    if (ResultJ.code.ToString() == "0")
                    {
                        Data dInfo = ResultJ.data;
                        string source_url = dInfo.source_url.ToString();
                        para.EmPosterImage.LinkAddress = source_url;
                        EmPosterImage emPhoto = new EmPosterImage();
                        emPhoto.LinkAddress = dInfo.source_url; 
                        emPhoto.PhotoName = para.EmPosterImage.PhotoName;
                        emPhoto.BusinessAccountID = para.EmPosterImage.BusinessAccountID;
                        emPhoto.DisplayIndex = para.EmPosterImage.DisplayIndex;

                        emPhoto.Type = type; 
                        return emPhoto;
                    }
                    else
                    {
                        throw new Exception(string.Format("上传【{0}】海报图发生错误-【{1}】", para.EmPosterImage.PhotoName, result));
                    }
                   // return para.EmPosterImage.LinkAddress;
                }
            }
            catch (Exception ee)
            {
              //  this.loggerManager.InsertErrorLog(string.Format("{0}.{1}", this.namespaceAndClassName, MethodBase.GetCurrentMethod().Name), ee);
               // return null;
            }
            return new EmPosterImage();
        }


        private void skinComboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            Province p = skinComboBoxProvince.SelectedItem as Province;
            skinComboBoxCity.DisplayMember = "Name";
            skinComboBoxCity.ValueMember = "Name";
            skinComboBoxCity.DataSource = p.Sub;
            skinComboBoxCity_SelectedIndexChanged(null, null);
        }

        private void skinComboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            City p = skinComboBoxCity.SelectedItem as City;
            skinComboBoxCityArea.DisplayMember = "Name";
            skinComboBoxCityArea.ValueMember = "Name";
            skinComboBoxCityArea.DataSource = p.Sub;

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;

                }
              string LogoStrUrl= UploadCostumeLogoPhoto();
               // ShowMessage("Logo上传到腾讯云后URL="+LogoStrUrl);
                RemoveDisposedCostumePhoto();
                RemoveDisposedCostumeClassPhoto();
                RemoveDisposedAdvPhoto();
                // UploadCostumePhoto();

                UploadBannerImag();  //海报图片

                UploadClassImg();     //类别图片
                UploadAdvImag();  //广告图片

                SetProgressInfo("正在保存店铺信息……");
                UpdateDisplayIndex();
                UpdateDisplayAdvIndex();
                // UpdatePosterImageIndexs();

                string postimg = "";
                /* if (this.pictureBox2.Image != null && keepImage != "" && !isUpdateImg)
                 {

                     postimg = keepImage; 
                     curEMall = new EMall()
                     {
                         BusinessAccountID = GlobalCache.BusinessAccount.ID,

                         //ShopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue),
                         Name = skinTextBoxName.Text,
                         Comment = richTextBoxComment.Text,
                         Announce = richTextBoxAnnounce.Text,
                         Hotline = skinTextBoxHotline.Text,
                          PosterImage=postimg,
                         ShopAddress = skinComboBoxProvince.SelectedValue + "-" + skinComboBoxCity.SelectedValue + "-" + skinComboBoxCityArea.SelectedValue + "," + textBoxDetailAddr.Text,
                     };

                 }
                 else
                 {*/
                curEMall = new EMall()
                {
                    BusinessAccountID = GlobalCache.BusinessAccount.ID,
                    //ShopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue),
                    Name = skinTextBoxName.Text,
                    Comment = richTextBoxComment.Text,
                    Announce = richTextBoxAnnounce.Text,
                    Hotline = skinTextBoxHotline.Text,
                     LogoUrl= LogoStrUrl,
                      PosterImageHeight=Convert.ToInt32(textBoxCount.Value),
                      IsShowAdsPhoto =skinCheckBox_DisplayOfAdv.Checked,
                       IsShowClassPhoto=skinCheckBox_DisplayOfClass.Checked,                        
                    ShopAddress = skinComboBoxProvince.SelectedValue + "-" + skinComboBoxCity.SelectedValue + "-" + skinComboBoxCityArea.SelectedValue + "," + textBoxDetailAddr.Text,
                };
                //  }


                  InteractResult result = GlobalCache.EMall_OnUpdate(curEMall);
                switch (result.ExeResult)
                {
                    case  ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        /*  if (this.pictureBox2.Image != null && keepImage != "" && !isUpdateImg)
                          { }
                          else
                          {
                              UploadBanner();
                          }*/
                        SetProgressVisible(false);
                        if (RemovePhotos != null && RemovePhotos.Count > 0)
                        {
                            RemovePhotos.Clear();
                        }
                        GlobalMessageBox.Show("保存成功！");
                        //  CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.EMall_Updated);
                        //  cb.BeginInvoke(null, null);
                       // TabPageClose(this.CurrentTabPage, this.SourceCtrlType);
                        break;
                }
                //switch (result)
                //{
                //    case UpdateResult.Error:
                //        GlobalMessageBox.Show("内部错误！");
                //        break;
                //    default:
                //        /*  if (this.pictureBox2.Image != null && keepImage != "" && !isUpdateImg)
                //          { }
                //          else
                //          {
                //              UploadBanner();
                //          }*/
                //        SetProgressVisible(false);
                //        if (RemovePhotos != null && RemovePhotos.Count > 0)
                //        {
                //            RemovePhotos.Clear();
                //        }
                //        GlobalMessageBox.Show("保存成功！");
                //        //  CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.EMall_Updated);
                //        //  cb.BeginInvoke(null, null);
                //        TabPageClose(this.CurrentTabPage, this.SourceCtrlType);
                //        break;
                //}
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

        //private void EMall_Updated()
        //{
        //    GlobalCache.EMall_Updated();
        //}

        private string UploadCostumeLogoPhoto()
        {
            //有切换图片//原来有图片被删除了，才更新图片,与该image无关
            /* if (photo != null)
             {
                 UpdateEMallLogoPara para = new UpdateEMallLogoPara()
                 {
                     BusinessAccountID = GlobalCache.BusinessAccount.ID,

                     //从picbox获取bytes
                     Logo = GetPhoto()
                 };

                 GlobalCache.EMallServerProxy.UpdateEMallLogo(para);
             }*/

            Image image = this.pictureBox1.Image;
            if (image != null)
            {
                InteractResult<CosCloudSignature> Signatureresult = CommonGlobalCache.ServerProxy.GetCosCloudSignature();
                if (Signatureresult.ExeResult == ExeResult.Success)
                {
                    CosCloudSignature cosCloudSignature = Signatureresult.Data;

                    VedioCosCloud = new CosCloud(cosCloudSignature.AppID, cosCloudSignature.Signature, 120);
                   
                    photo = GetPhoto();

                    string logoName = CommonGlobalCache.BusinessAccount.ID + "_" + ".jpg";
                    // CosCloud cos = new CosCloud(cosLoginInfo.AppID, cosLoginInfo.SecretId, cosLoginInfo.SecretKey);
                    Dictionary<string, string> uploadParasDic = new Dictionary<string, string>();
                    uploadParasDic.Add(CosParameters.PARA_BIZ_ATTR, "");
                    uploadParasDic.Add(CosParameters.PARA_INSERT_ONLY, "0");
                    string result = VedioCosCloud.UploadFile2(cosCloudSignature.BucketName, string.Format("/{0}/{1}", CommonGlobalCache.BusinessAccount.ID, logoName),
                        logoName, photo, uploadParasDic);
                    // JObject jObject = (JObject)JsonConvert.DeserializeObject(result);
                    ResultJson ResultJ = (ResultJson)JavaScriptConvert.DeserializeObject(result, typeof(ResultJson));
                    if (ResultJ.code.ToString() == "0")
                    {
                        Data dInfo = ResultJ.data;
                        string source_url = dInfo.source_url.ToString();
                        return source_url;
                       
                    }
                    else
                    {
                        throw new Exception(string.Format("上传【{0}】图片发生错误-【{1}】", logoName, result));
                    }
                }
            }
            return string.Empty;
        }
        private byte[] GetPhoto()
        {

            byte[] photo = null;
            Image image = this.pictureBox1.Image;
            if (image != null)
            {
                MemoryStream stream = new MemoryStream();

                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                photo = stream.ToArray();

            }
            return photo;
        }
        private string keepImage = string.Empty;
        private void Display()
        {
            if (curEMall != null)
            {
                //if (!String.IsNullOrEmpty(curEMall.ShopID))
                //{
                //    skinComboBoxShopID.SelectedValue = curEMall.ShopID;
                //    //20180628线上商城关联了店铺之后，一旦设置不给修改
                //    skinComboBoxShopID.Enabled = false;
                //}
                 
                skinTextBoxName.Text = curEMall.Name;
                richTextBoxComment.Text = curEMall.Comment;
                richTextBoxAnnounce.Text = curEMall.Announce;
                skinTextBoxHotline.Text = curEMall.Hotline;
                textBoxCount.Value = curEMall.PosterImageHeight;
                //this.skinCheckBox_DisplayOfAdv.Checked = curEMall.IsShowAdsPhoto;
               // this.skinCheckBox_DisplayOfClass.Checked = curEMall.IsShowClassPhoto;
                //load image
                //   byte[] imageByte = GlobalCache.EMallServerProxy.GetEMallLogo();
                WriteLog("LogoUrl=" + curEMall.LogoUrl);
                if (curEMall.LogoUrl!=null && curEMall.LogoUrl != "")
                {
                    this.pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(curEMall.LogoUrl).GetResponse().GetResponseStream()); ;
                }
               
                
                // banner = LoadEmCostumePhoto(curEMall.PosterImage);
                keepImage = curEMall.PosterImage;
                // this.pictureBox2.Image = banner.Image;
                //ShowMessage(banner.LinkAddress+"PhotoName="+banner.PhotoName+"Path="+banner.SavePath);
                //设置默认的宝贝地址

                if (curEMall.ShopAddress != null)
                {
                    String[] addresses = curEMall.ShopAddress.Split('-');
                    if (addresses.Length == 3)
                    {
                        List<Province> provinces = skinComboBoxProvince.DataSource as List<Province>;
                        if (provinces.FindAll(t => t.Name == addresses[0]).Count > 0)
                        {
                            //skinComboBoxProvince.DataSource
                            skinComboBoxProvince.SelectedValue = addresses[0];
                        }
                        else
                        {
                            if (provinces.Count > 0)
                            {
                                skinComboBoxProvince.SelectedValue = provinces[0].Name;
                            }
                        }

                        List<City> citys = skinComboBoxCity.DataSource as List<City>;
                        if (citys != null && citys.Count > 0)
                        {
                            if (citys.FindAll(t => t.Name == addresses[1]).Count > 0)
                            {
                                skinComboBoxCity.SelectedValue = addresses[1];
                            }
                            else
                            {
                                if (citys.Count > 0)
                                {
                                    skinComboBoxCity.SelectedValue = citys[0].Name;
                                }
                            }
                        }

                        List<CityArea> areas = skinComboBoxCityArea.DataSource as List<CityArea>;
                        String detailAddress = null;
                         
                        if (addresses[2] != null)
                        {
                            String[] detailAddresses = addresses[2].Split(',');
                            if (detailAddresses.Length > 0)
                            {
                                if (areas!=null && areas.Count > 0)
                                {
                                    if (areas.FindAll(t => t.Name == detailAddresses[0]).Count > 0)
                                    {
                                        skinComboBoxCityArea.SelectedValue = detailAddresses[0];
                                    }
                                    else
                                    {
                                        if (areas.Count > 0)
                                        {
                                            skinComboBoxCityArea.SelectedValue = areas[0].Name;
                                        }
                                    }
                                }
                            }




                           
                            for (int i = 1; i < detailAddresses.Length; i++)
                            {
                                detailAddress += detailAddresses[i] + ",";
                            }
                        }
                        detailAddress = detailAddress.Substring(0, detailAddress.Length - 1);
                        textBoxDetailAddr.Text = detailAddress;
                    }
                }

            }
            else
            {

                ResetAll();
            }
        }
        private EmCostumePhoto LoadEmCostumePhoto(String linkAddress)
        {
            EmCostumePhoto emCostumePhoto
                 = new EmCostumePhoto() { LinkAddress = linkAddress };
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this)) { return null; }

                if (!Directory.Exists(GlobalUtil.EmallDir))
                {
                    Directory.CreateDirectory(GlobalUtil.EmallDir);
                    WriteLog("目录创建成功！");
                }
                else
                {

                    WriteLog("目录已存在！");
                }

                if (!String.IsNullOrEmpty(linkAddress))
                {
                    String savePath = GlobalUtil.EmallDir + Path.GetFileName(linkAddress); //item.LinkAddress.Substring(item.LinkAddress.LastIndexOf());
                                                                                           //引用前必须释放所有图片文件的使用权
                    Image img = null;
                    try
                    {
                        if (!File.Exists(savePath))
                        {
                            CosCloud.DownloadFile(CosLoginInfo.BucketName, linkAddress, savePath);
                        }
                        img = JGNet.Core.ImageHelper.FromFileStream(savePath);
                        emCostumePhoto.Image = img;
                        emCostumePhoto.SavePath = savePath;
                    }
                    catch (Exception ex)
                    {
                            //下载失败，可能文件被占用，直接使用该文件即可。
                            //文件找不到使用默认图片，找不到

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
            return emCostumePhoto;

        }

        private void ResetAll()
        {
            curEMall = null;
            WriteLog("curEMall?.Name=" + curEMall?.Name+ "curEMall?.LogoUrl"+curEMall?.LogoUrl);
            skinTextBoxName.Text = curEMall?.Name;
            richTextBoxComment.Text = curEMall?.Comment;
            richTextBoxAnnounce.Text = curEMall?.Announce;
            skinTextBoxHotline.Text = curEMall?.Hotline;
            //load image
            this.pictureBox1.Image = null;

        }
        private Byte[] photo { get; set; }
        //public CosLoginInfo CosLoginInfo { get; private set; }
        //public CosCloud CosCloud { get; private set; }


        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  if (curEMall != null)
            //   {
            //      curEMall.ShopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue);
            //  }
        }

        private bool isUpdateImg = false;
        private System.Drawing.Imaging.ImageFormat getImageFormat(string filePath)
        {
            string ext=Path.GetExtension(filePath);
            //ShowMessage(ext);
            System.Drawing.Imaging.ImageFormat imgFormat = null;
            if (ext.ToLower() == ".gif"  )
            {
                imgFormat = System.Drawing.Imaging.ImageFormat.Gif;
            }
            else if (ext.ToLower() == ".png")
            {
                imgFormat = System.Drawing.Imaging.ImageFormat.Png;
            }
            else if (ext.ToLower() == ".icon")
            {
                imgFormat= System.Drawing.Imaging.ImageFormat.Icon;
            }
            else if (ext.ToLower() == ".bmp")
            {
                imgFormat = System.Drawing.Imaging.ImageFormat.Bmp;
            }
            else  
            {
                imgFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            }
            return imgFormat;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] photo = null;
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
                System.Drawing.Imaging.ImageFormat imgFormat=getImageFormat(path);
                MemoryStream stream = new MemoryStream();
                img.Save(stream, imgFormat);
                photo = stream.ToArray();
                if (photo.Length > 2097152)
                {
                    GlobalMessageBox.Show("图片太大，请重新上传！");
                    return;
                }
                /*  banner = new EmCostumePhoto()
                  {
                      Bytes = photo,
                      SavePath = path,
                      Image = img,
                      PhotoName = JGNet.Core.ImageHelper.GetNewFileName("BANNER", Path.GetFileName(path))
                  };*/
                //  this.pictureBox2.Image = img;
                isUpdateImg = true;

            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
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
        private void pictureBox1_Click(object sender, EventArgs e)
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
                Image map = JGNet.Core.ImageHelper.GetNewSizeImage(img, 64);

                System.Drawing.Imaging.ImageFormat imgFormat = getImageFormat(path);
                map.Save(stream, imgFormat);
                photo = stream.ToArray();
                if (photo.Length > 1048576)
                {
                    GlobalMessageBox.Show("图片不能超过1M");
                    return;
                }
                // 2097152
                

                this.pictureBox1.Image = map;
                stream = new MemoryStream();
                map.Save(stream, imgFormat);
                photo = stream.ToArray();
                // this.pictureBox1.Image = map;
                //Image img2 = Image.FromStream(stream);
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        private void skinComboBoxCityArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skinComboBox_Class_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CostumeClass2 classItem =(CostumeClass2) this.skinComboBox_Class.SelectedItem;
            String str = ValidateUtil.CheckEmptyValue(this.skinComboBox_Class.SelectedValue);
          //  GlobalMessageBox.Show(this.skinComboBox_Class.SelectedValue.ToString()+"Text="+this.skinComboBox_Class.SelectedText.ToString()+"ITem="+ this.skinComboBox_Class.SelectedItem.ToString());
            if (CostumeClassPhotos != null && CostumeClassPhotos.Exists(t => t.AutoID == classItem.AutoID))
            {
                GlobalMessageBox.Show("相同类别已存在！");
                return;
            }
            else
            {
                AddClassToListView(classItem);
            }
        }
        private void AddClassToListView(CostumeClass2 classItem)
        {
            if (String.IsNullOrEmpty(classItem.AutoID.ToString()))
            {
                this.skinComboBox_Class.Focus();
                return;
            }
            //if (CostumeOfTitlePhotos != null && CostumeOfTitlePhotos.Count > 0)
            //{
            //    ColorPictureListForm colorList = new ColorPictureListForm(this.skinTextBoxID.SkinTxt.Text, CostumeOfTitlePhotos);
            //    colorList.DiscountConfirm += SingleDiscountForm_DiscountConfirm;
            //    colorList.ShowDialog();
            //}
            //else
            //{
            ClassUpload_Class(this.ClassImageControl, null);
            //}
        }

        private void skinComboBox_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
         /*   String str = ValidateUtil.CheckEmptyValue(this.skinComboBox_Class.SelectedValue);
            GlobalMessageBox.Show(this.skinComboBox_Class.SelectedValue.ToString() + "Text5=" + this.skinComboBox_Class.SelectedText.ToString() + "ITem5=" + this.skinComboBox_Class.SelectedItem.ToString());
            if (CostumeClassPhotos != null && CostumeClassPhotos.Exists(t => t.ClassCode == str))
            {
                GlobalMessageBox.Show("相同类别已存在！");
                return;
            }
            else
            {
                AddClassToListView(str);
            }*/
        }

        private void skinComboBox_Class_SelectedValueChanged(object sender, EventArgs e)
        {
           /* String str = ValidateUtil.CheckEmptyValue(this.skinComboBox_Class.SelectedValue);
            GlobalMessageBox.Show(ValidateUtil.CheckEmptyValue(this.skinComboBox_Class.SelectedValue) + "Text3=" + this.skinComboBox_Class.SelectedText.ToString() );
            if (CostumeClassPhotos != null && CostumeClassPhotos.Exists(t => t.ClassCode == str))
            {
                GlobalMessageBox.Show("相同类别已存在！");
                return;
            }
            else
            {
                AddClassToListView(str);
            }*/
        }

        private void skinCheckBox_DisplayOfClass_CheckedChanged(object sender, EventArgs e)
        {
            if (CostumeClassPhotos == null || (CostumeClassPhotos!=null && CostumeClassPhotos.Count == 0))
            {
                if (this.skinCheckBox_DisplayOfClass.Checked)
                {
                    GlobalMessageBox.Show("请先选择一个类别图片！");
                    skinCheckBox_DisplayOfClass.Checked = false;
                }
            }
        }

        private void skinCheckBox_DisplayOfAdv_CheckedChanged(object sender, EventArgs e)
        {
            
                 if (AdvCostumePhotos == null || (AdvCostumePhotos != null && AdvCostumePhotos.Count == 0))
            {
                if (this.skinCheckBox_DisplayOfAdv.Checked)
                {
                    GlobalMessageBox.Show("请先选择一个广告图片！");
                    skinCheckBox_DisplayOfAdv.Checked = false;
                }
            }
        }
    }

}
