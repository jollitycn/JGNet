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
using System.IO;
using JieXi.Common;
using JGNet.Common.Core.Util;

namespace JGNet.Manage

{
    public partial class EmCostumeManageCtrl : BaseUserControl
    {
        private GetEmCostumePagePara pagePara;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        SingleImageForm imageCtrl;
        public override void RefreshPage()
        {
            if (pagePara != null)
            {
                this.dataGridViewPagingSumCtrl_CurrentPageIndexChanged(pagePara.PageIndex);
            }
        }

        public EmCostumeManageCtrl()
        {
            InitializeComponent();
            //  this.Controls.Add(imageCtrl);
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(this.dataGridView1, dataGridViewPagingSumCtrl_CurrentPageIndexChanged, BaseButton_Search_Click) { };
            dataGridViewPagingSumCtrl.Initialize();
            dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings( Column5);

            dataGridViewPagingSumCtrl.SelectionChanged = dataGridView1_SelectionChanged;
            dataGridViewPagingSumCtrl.OrderSearch += Search;

            //  CommonGlobalUtil.SetBigClass(skinComboBoxBigClass);
            CommonGlobalUtil.SetCostumeManageType(skinComboType);

            MenuPermission = RolePermissionMenuEnum.商品管理;

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
                EmCostumePage listPage = GlobalCache.EMallServerProxy.GetEmCostumePage(this.pagePara);

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
            this.skinCheckBoxShowImage.Checked = false;
            //该行的作用
            dataGridViewPagingSumCtrl.OrderPara = this.pagePara;
            pagePara = new GetEmCostumePagePara()
            {
                ///////////////////////////////////////
                IsOnlyShowRecommand = skinCheckBoxIsOnlyShowRecommand.Checked,
                EmShowOnline = skinRadioButtonOnline.Checked,
                PageIndex = 0,
                ID = skinTextBoxID.Text,
                PageSize = dataGridViewPagingSumCtrl.PageSize,
                ClassID = skinComboBoxBigClass.SelectedValue.ClassID,
                 IsOnlyNew=  skinCheckBoxNew.Checked,
                 IsOnlyHot= skinCheckBoxHot.Checked,
                  Type = (EmCostumeInfoType)this.skinComboType.SelectedValue,
                  
            //SubSmallClass = this.skinComboBoxBigClass.SelectedValue?.SubSmallClass
        };
            Search(null, null);
        }


        private void Search(object sender, EventArgs args)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                } 

                EmCostumePage listPage = GlobalCache.EMallServerProxy.GetEmCostumePage(this.pagePara);
                dataGridViewPagingSumCtrl.OrderPara = pagePara;
                this.dataGridViewPagingSumCtrl.Initialize(listPage);
                if (pagePara.EmShowOnline)
                {
                   // EmOnlinePrice.DataPropertyName = "EmOnlinePrice";

                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(Column2, Column1, CreateTime, Column4, QuantityOfSale, EmTitle, IsHot, IsNew, PfShowOnline, EmShowOnline);
                    dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(Column5);
                }
                else
                {
                  //  EmOnlinePrice.DataPropertyName = "Price";
                    dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(Column2, Column1, CreateTime, Column4, QuantityOfSale, EmTitle, IsHot, IsNew, PfShowOnline, EmShowOnline);
                    dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(Column5);
                }
                /*   if (this.skinRadioButtonOffline.Checked)
                   {
                       // dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(PfOnlinePrice);
                       // PfOnlinePrice.Visible = false;
                       dataGridViewPagingSumCtrl.AppendNotShowInColumnSettings(PfOnlinePrice);
                   }
                   else
                   {
                       dataGridViewPagingSumCtrl.RemoveNotShowInColumnSettings(PfOnlinePrice);
                   }*/

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

        private void BindingDataSource(EmCostumePage listPage)
        {
            this.dataGridViewPagingSumCtrl.BindingDataSource<EmCostume>(listPage?.EmCostumes,null, listPage?.TotalEntityCount);
          
        }


        private void EmCostumeManageCtrl_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                pagePara = new GetEmCostumePagePara();
            }
            catch (Exception ex)
            {

                GlobalUtil.ShowError(ex);
            }
        }

        private void BaseButtonAdd_Click(object sender, EventArgs e)
        {
            this.OpenModifyDialog(null);
        }

        // public event CJBasic.Action<EmCostume, BaseUserControl> OpenModifyDialog;
        private void OpenModifyDialog(EmCostume e)
        {
            SaveEmCostumeForm form = new SaveEmCostumeForm(e?.ID, String.IsNullOrEmpty(e.EmTitle),e.Price);
            string tabName = (String.IsNullOrEmpty(e.EmTitle) ? "商品上架" : "编辑商品");
            form.Text = tabName;
            form.Costume_Save += Costume_Save;
            form.ShowDialog(this);
            //form.ShowDialog(this);
            //ShowMessage(form.ShowDialog(this).ToString());
            //if (form.ShowDialog(this) == DialogResult.OK)
            //{
            //    form.Display(true);
            //    ShowMessage("加载图片");
            //}
            // 创建句柄时报错
          //  form.Dispose();

        }

        private void Costume_Save(EmCostumeInfo obj)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric<EmCostumeInfo>(Costume_Save), obj);
            }
            else
            {
                this.RefreshPage();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; }
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    
                    EmCostume item = (EmCostume)this.dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {
                        case "编辑":
                            this.OpenModifyDialog(item);
                            break;
                        case "下架":
                            if (GlobalMessageBox.Show("下架后，店铺内将不再展示该商品，确定下架？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                UpdateEmShowOnlineIsFalse(item);
                            }
                            break;
                        case "上架":
                            //if (GlobalMessageBox.Show("确认上架该商品？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            //{
                            //    UpdateEmShowOnlineIsTrue(item);
                            //}

                            this.OpenModifyDialog(item);

                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            
        }





        private void UpdateEmShowOnlineIsTrue(EmCostume item)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                GlobalCache.CostumeList.Find(t => t.ID == item.ID).EmShowOnline = true;
                UpdateResult result = GlobalCache.EMallServerProxy.UpdateEmShowOnlineIsTrue(item.ID);
                switch (result)
                {
                    case UpdateResult.Success:
                        GlobalMessageBox.Show("上架成功！");
                        BaseButton_Search_Click(null, null);
                        break;
                    case UpdateResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
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
        #region  //下架商品
        private void UpdateEmShowOnlineIsFalse(EmCostume item)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                GlobalCache.CostumeList.Find(t => t.ID == item.ID).EmShowOnline = false;
                UpdateResult result = GlobalCache.EMallServerProxy.UpdateEmShowOnlineIsFalse(item.ID);
                switch (result)
                {
                    case UpdateResult.Success:
                        GlobalMessageBox.Show("下架成功！");
                        RefreshPage();
                        break;
                    case UpdateResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
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
        #endregion

        #region   //设置是否是新品
        private void UpIsNew(string itemID, bool isNew)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                } 
                InteractResult result = GlobalCache.EMallServerProxy.IsCostumeNew(itemID, isNew);
                switch (result.ExeResult)
                {
                    case  ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
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
        #endregion

        #region    //设置是否热卖
        private void UpIsHot(string itemID, bool isHot)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = GlobalCache.EMallServerProxy.IsCostumeHot(itemID, isHot);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show(result.Msg);
                        break;
                    default:
                        break;
                }
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
        #endregion

        #region  //设置是否零售
        private void UpEmShowOnLine(string itemID, bool EmShowOnLine)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = GlobalCache.ServerProxy.UpdateEmShowOnline(itemID, EmShowOnLine);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
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
        #endregion

        #region  //设置是否批发
        private void UpPfShowOnLine(string itemID, bool EmShowOnLine)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = GlobalCache.ServerProxy.UpdatePfShowOnline(itemID, EmShowOnLine);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
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
        #endregion
        #region  //设置是否为推荐商品
        private void Recommend(EmCostume item)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                UpdateEmRecommandPara para = new UpdateEmRecommandPara()
                {
                    EmIsRecommand = item.EmIsRecommand,
                    ID = item.ID
                };
                UpdateResult result = GlobalCache.EMallServerProxy.UpdateEmRecommand(para);
                switch (result)
                {
                    case UpdateResult.Success: 
                        break;
                    case UpdateResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
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
        #endregion

        private void UpSaleNum(string itemID, int SaleNum)
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
                InteractResult result = GlobalCache.ServerProxy.UpdateEmSales(itemID, SaleNum);
                switch (result.ExeResult)
                {
                    case ExeResult.Success:
                        break;
                    case ExeResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
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


        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
                {
                    DataGridView view = (DataGridView)sender;
                    List<EmCostume> list = (List<EmCostume>)view.DataSource;
                    EmCostume item = (EmCostume)list[e.RowIndex];
                    switch (view.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.HeaderText)
                    {
                       /* case "推荐":
                            item.EmIsRecommand = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                            Recommend(item);
                            break;*/
                        case "新品":
                            item.IsNew = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                             UpIsNew(item.ID, item.IsNew);
                            break;
                        case "热卖":
                            item.IsHot = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                             UpIsHot(item.ID, item.IsHot);
                            break;
                        case "零售":
                            item.EmShowOnline = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                            if (!item.EmShowOnline && item.PfShowOnline==false) {
                                GlobalMessageBox.Show("线上商品必须是批发或者零售，请确定后再进行修改！");
                                this.RefreshPage();
                                break;
                            }
                            UpEmShowOnLine(item.ID, item.EmShowOnline);
                            break;
                        case "批发":
                            item.PfShowOnline = (bool)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;
                            if (!item.PfShowOnline && item.EmShowOnline == false)
                            {
                                GlobalMessageBox.Show("线上商品必须是批发或者零售，请确定后再进行修改！");
                                this.RefreshPage();
                                break;
                            }
                            UpPfShowOnLine(item.ID, item.PfShowOnline);
                            break;
                        case "销量":
                            item.QuantityOfSale =(int)this.dataGridView1[e.ColumnIndex, e.RowIndex].Value;

                            UpSaleNum(item.ID, item.QuantityOfSale);
                            break;
                        default: break;
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
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
        private EmCostume curCostume;

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

                    EmCostume item = (EmCostume)dataGridView1.CurrentRow.DataBoundItem;
                    // item.EmThumbnailData
                    if (curCostume != item && skinCheckBoxShowImage.Checked)
                    {
                        if (imageCtrl != null)
                        {
                            imageCtrl?.Close();
                            imageCtrl = null;
                        }
                        imageCtrl = new SingleImageForm();
                        imageCtrl.FormClosing += ImageCtrl_FormClosing; 
                        imageCtrl.Text = "款号：" + item.ID;
                        imageCtrl.OnLoadingState(); skinCheckBoxShowImage.CheckedChanged -= skinCheckBoxShowImage_CheckedChanged;
                        skinCheckBoxShowImage.Checked = true;
                        skinCheckBoxShowImage.CheckedChanged += skinCheckBoxShowImage_CheckedChanged;
                        Costume CurItem= CommonGlobalCache.GetCostume(item.ID);
                        // byte[] bytes = GlobalCache.ServerProxy.GetCostumePhoto(item.ID);
                        if (item.EmShowOnline)
                        {
                            if (!String.IsNullOrEmpty(item.EmThumbnail))
                            {
                                String url = item.EmThumbnail;
                                System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                                System.Net.WebResponse webres = webreq.GetResponse();
                                using (System.IO.Stream stream = webres.GetResponseStream())
                                {
                                    imageCtrl.Image = Image.FromStream(stream);
                                }
                            }
                            else
                            {
                                imageCtrl.Image = null;
                            }
                        }
                        else
                        {
                            if (!String.IsNullOrEmpty(CurItem.EmThumbnail))
                            {
                                String url = CurItem.EmThumbnail;
                                System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                                System.Net.WebResponse webres = webreq.GetResponse();
                                using (System.IO.Stream stream = webres.GetResponseStream())
                                {
                                    imageCtrl.Image = Image.FromStream(stream);
                                }
                            }
                            else
                            {
                                imageCtrl.Image = null;
                            }
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

        private void skinRadioButtonOnline_CheckedChanged(object sender, EventArgs e)
        {
            skinTextBoxID.EmOnline = skinRadioButtonOnline.Checked;
        }

        private void skinRadioButtonOffline_CheckedChanged(object sender, EventArgs e)
        {
            skinTextBoxID.EmOnline = skinRadioButtonOnline.Checked;
        }

        CommonImportForm importForm = null;
        String importPath = string.Empty;
        private void baseButtonImport_Click(object sender, EventArgs e)
        {
            importForm = new CommonImportForm("导入商品","线上商品导入.xls");
             

                importForm.ConfirmClick += form_ConfirmClick;
                if (importForm.ShowDialog() != DialogResult.OK)
                {
                    importPath = string.Empty;
                    return;
                } 
        }

        private void form_ConfirmClick(string path)
        {
            importPath = path;


            string fileExt = Path.GetExtension(path);
            if (fileExt != ".xlsx" && fileExt != ".xls")
            {
                ShowMessage("你所选择文件格式不正确，请重新上传文件！");
                return;
            }
            if (GlobalMessageBox.Show("是否开始导入" + System.IO.Path.GetFileName(path), "友情提示", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                importPath = null;
                CloseForm();
                return;
            }

            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this)) { return; }
                CJBasic.CbGeneric cb = new CJBasic.CbGeneric(this.DoImport);
                cb.BeginInvoke(null, null);
            }
            catch (Exception ex)
            {
                CommonGlobalUtil.ShowError(ex);
            }
        }

        private void CloseForm()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new CJBasic.CbGeneric(this.CloseForm));
            }
            else
            {
                importForm.Cancel();
            }
        }

        private void DoImport()
        {
            try
            {
                ImportExcel(importPath);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
            finally
            {
                CloseForm();
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
            }
        }

        private void ImportExcel(String importPath)
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
                        item.Colors = CommonGlobalUtil.ConvertToString(row[3]).Replace("，", ",");
                        item.BigClass = CommonGlobalUtil.ConvertToString(row[4]);
                        item.Price = Convert.ToDecimal(row[5]);
                        item.PhotoName = CommonGlobalUtil.ConvertToString(row[6]);
                        item.IsNew = CommonGlobalUtil.ConvertToString(row[7]) == "是";
                        item.IsHot = CommonGlobalUtil.ConvertToString(row[8]) == "是";
                    }
                    catch (Exception ex)
                    {
                    }

                    if (!(String.IsNullOrEmpty(item.CostumeID) || String.IsNullOrEmpty(item.Name)))
                    {
                        item.CostumeID = CommonGlobalCache.GetCorrectCostumeID(item.CostumeID);
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

                String failImgs = String.Empty;
                String tooLargeImgs = String.Empty;
                InitProgress(items.Count);
                foreach (var item in items)
                {
                    if (progressStop)
                    {
                        break;
                    }
                    UpdateProgress("检查图片：");
                    //if (!String.IsNullOrEmpty(item.PhotoName))
                    //{
                    //找图片并上传
                    try
                    {
                        String imagePath = Path.GetDirectoryName(importPath) + "//" + item.PhotoName;
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
                                tooLargeImgs += "第" + item.Index + "行 款号：" + item.CostumeID;
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

                        UpdateProgress("图片上传：");
                        //if (!String.IsNullOrEmpty(item.PhotoName))
                        //{
                        //找图片并上传
                        String[] colors = item.Colors.Split(',');

                        String imagePath = Path.GetDirectoryName(importPath) + "//" + item.PhotoName;
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

        private void skinPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (!ReportShowZero)
            {
                DataGridViewUtil.CellFormatting_ReportShowZero(e, ReportShowZero);
            }
        }
    }
}
