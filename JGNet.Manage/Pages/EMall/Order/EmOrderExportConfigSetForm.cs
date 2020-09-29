using JGNet.Common.Core;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using JGNet.Manage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common.Components
{
    public partial class EmOrderExportConfigSetForm : BaseForm
    {
         
     
        public CostumeColor Result { get { return color; } }

        private CostumeColor color;
        private OperationEnum action;
        public EmOrderExportConfigSetForm()
        {
            InitializeComponent();
            //this.color = color;
            //this.action = action;

            Initialize();
        }

        private void Initialize()
        { 
            InteractResult<EmOrderExportInfo> result = GlobalCache.ServerProxy.GetEmOrderExportInfo();
            if (result.ExeResult == ExeResult.Success)
            {
                if (result.Data != null)
                {
                    EmOrderExportInfo ExportConfigInfo = result.Data;
                    skinTxtChannelID.SkinTxt.Text = ExportConfigInfo.ChannelID;
                    txtChannelName.SkinTxt.Text = ExportConfigInfo.ChannelName;
                    skinTxtStoreHouseID.SkinTxt.Text = ExportConfigInfo.WarehouseID;
                    txtStoreHouseName.SkinTxt.Text = ExportConfigInfo.WarehouseName;
                    txtSeparateAccountsID.SkinTxt.Text = ExportConfigInfo.LedgerAccountID;
                    txtSeparateAccountsName.SkinTxt.Text = ExportConfigInfo.LedgerAccountName;

                }
            }

        }

     
        private void BaseButton1_Click(object sender, EventArgs e)
        {
            try
            {
                EmOrderExportInfo ExportConfigInfo =  new EmOrderExportInfo();
                 ExportConfigInfo.ChannelID= skinTxtChannelID.SkinTxt.Text;
                   ExportConfigInfo.ChannelName= txtChannelName.SkinTxt.Text;
                 ExportConfigInfo.WarehouseID= skinTxtStoreHouseID.SkinTxt.Text;
                  ExportConfigInfo.WarehouseName= txtStoreHouseName.SkinTxt.Text;
                 ExportConfigInfo.LedgerAccountID= txtSeparateAccountsID.SkinTxt.Text;
                ExportConfigInfo.LedgerAccountName= txtSeparateAccountsName.SkinTxt.Text;

                try
                {
                    InteractResult result = GlobalCache.ServerProxy.SetEmOrderExportInfo(ExportConfigInfo);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            GlobalMessageBox.Show("保存成功！");
                this.DialogResult = DialogResult.OK;
                            break;
                        case ExeResult.Error:
                            GlobalMessageBox.Show(result.Msg);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    GlobalUtil.ShowError(ex);
                }

                /*  string name = skinTxtStoreHouseID.Text;
                  string id = skinTxtChannelID.Text;

                  List<CostumeColor> costumeColor = GlobalCache.CostumeColorList;

                  if (string.IsNullOrEmpty(id))
                  {
                      GlobalMessageBox.Show("色号不能为空！");
                      this.skinTxtChannelID.Focus();
                      return;
                  }
                  else if (string.IsNullOrEmpty(name))
                  {
                      GlobalMessageBox.Show("名称不能为空！");
                      this.skinTxtStoreHouseID.Focus();
                      return;
                  }
                  else
                  {

                      if (this.color != null)
                      {

                          //编辑的时候，判断是否有重复ID。排除自己
                         List< CostumeColor> colorChecked = costumeColor.FindAll(t => t.ID == id);
                          if (colorChecked != null && colorChecked.Count > 1)
                          {
                              GlobalMessageBox.Show("该色号已存在！");
                              this.skinTxtChannelID.Focus();
                              return;
                          }
                      }
                      else
                      {
                          CostumeColor colorChecked = costumeColor.Find(t => t.ID == id);
                          if (colorChecked != null)
                          {
                              GlobalMessageBox.Show("该色号已存在！");
                              this.skinTxtChannelID.Focus();
                              return;
                          }
                      }

                      if (this.color != null)
                      {

                          //编辑的时候，判断是否有重复ID。排除自己
                          List<CostumeColor> colorChecked = costumeColor.FindAll(t => t.Name == name);
                          if (colorChecked != null && colorChecked.Count > 1)
                          {
                              GlobalMessageBox.Show("名称已存在！");
                              this.skinTxtStoreHouseID.Focus();
                              return;
                          }
                      }
                      else
                      {
                          CostumeColor colorChecked = costumeColor.Find(t => t.Name == name);
                          if (colorChecked != null)
                          {
                              GlobalMessageBox.Show("名称已存在！");
                              this.skinTxtStoreHouseID.Focus();
                              return;
                          }
                      }
                  }*/




                /*    if (action == OperationEnum.Edit)
                    {
                        color.ID = id;
                        color.Name = name;
                        color.FirstCharSpell = DisplayUtil.GetPYString(name);
                    }
                    else
                    {
                        this.color = new CostumeColor()
                        {
                            ID = id,
                            Name = name,
                            FirstCharSpell = DisplayUtil.GetPYString(name),
                        };

                    }*/

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

        private void EmOrderExportConfigSetForm_Load(object sender, EventArgs e)
        {
           Initialize();
        }
    }
}
