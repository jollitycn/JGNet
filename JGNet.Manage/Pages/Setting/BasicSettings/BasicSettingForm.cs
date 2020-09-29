using JGNet.Common;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using JGNet.Core.Util;
using JGNet.Manage.Pages;
using JGNet.Manage.Pages.BasicSettings.Costume;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage.Components
{
    public partial class BasicSettingForm : BaseForm
    {
        //SupplierManageCtrl supplierManageCtrl;
        CostumeBrandCtrl costumeBrandCtrl;
        CostumeClassCtrl2019 costumeClassCtrl;
        CostumeColorCtrl costumeColorCtrl;
        CostumeSeasonCtrl costumeSeasonCtrl;
        SizeGroupCtrl sizeGroupCtrl;
        public BasicSettingForm()
        {
            InitializeComponent();
            MenuPermission = RolePermissionMenuEnum.基础资料;
            costumeBrandCtrl = new CostumeBrandCtrl();
            skinTabPage2.Controls.Add(costumeBrandCtrl);
            costumeBrandCtrl.Dock = DockStyle.Fill;
            if (!HasPermission(RolePermissionMenuEnum.品牌, RolePermissionEnum.查看))
            {
                skinTabControl1.TabPages.Remove(skinTabPage2);
            } 
            costumeClassCtrl = new CostumeClassCtrl2019();
            skinTabPage3.Controls.Add(costumeClassCtrl);
            costumeClassCtrl.Dock = DockStyle.Fill;
            if (!HasPermission(RolePermissionMenuEnum.类别, RolePermissionEnum.查看))
            {
                skinTabControl1.TabPages.Remove(skinTabPage3);
            } 
            costumeColorCtrl = new CostumeColorCtrl();
            skinTabPage4.Controls.Add(costumeColorCtrl);
            costumeColorCtrl.Dock = DockStyle.Fill;
            if (!HasPermission(RolePermissionMenuEnum.颜色, RolePermissionEnum.查看))
            {
                skinTabControl1.TabPages.Remove(skinTabPage4);
            } 
            sizeGroupCtrl = new SizeGroupCtrl();
            skinTabPage5.Controls.Add(sizeGroupCtrl);
            sizeGroupCtrl.Dock = DockStyle.Fill;
            if (!HasPermission(RolePermissionMenuEnum.尺码, RolePermissionEnum.查看))
            {
                skinTabControl1.TabPages.Remove(skinTabPage5);
            } 
            costumeSeasonCtrl = new CostumeSeasonCtrl();
            skinTabPage6.Controls.Add(costumeSeasonCtrl);
            costumeSeasonCtrl.Dock = DockStyle.Fill;
            if (!HasPermission(RolePermissionMenuEnum.季节, RolePermissionEnum.查看))
            {
                skinTabControl1.TabPages.Remove(skinTabPage6);
            } 
            if (skinTabControl1.TabPages.Count > 0)
            {
                skinTabControl1.SelectTab(0);
            }
        }

        bool barCodeChanged = false;
        private void barCodeCtrl1_CheckChanged(bool changed)
        {
            barCodeChanged = changed;
        }

        private void BaseButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommonGlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }
               //// integralCtrl1.BaseButtonSave_Click(sender, e);
               // InteractResult result=  optionCtrl1.BaseButtonSave_Click(sender, e);
               // if (result.ExeResult == ExeResult.Error) {
               //     GlobalMessageBox.Show(result.Msg);
               //     return;
               // }



               // if (barCodeChanged)
               // {
               //     if (GlobalMessageBox.Show("修改模板后将清空已生成的商品条码", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
               //     {
               //         barCodeCtrl1.BaseButtonSave_Click(sender, e);
               //     }
               //     else {
               //         barCodeCtrl1.LoadConfig();
               //         barCodeChanged = false;
               //     }
               // }  

             //  changePasswordAdminUserCtrl1.BaseButtonSave_Click(sender, e);
                GlobalMessageBox.Show("保存成功！");
            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }
            finally
            {
                CommonGlobalUtil.UnLockPage(this);
            }

        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barCodeCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void BasicSettingForm_Load(object sender, EventArgs e)
        {
            PermissonUtil.CheckPermissons(costumeBrandCtrl);
            PermissonUtil.CheckPermissons(costumeClassCtrl);
            PermissonUtil.CheckPermissons(costumeColorCtrl);
            PermissonUtil.CheckPermissons(costumeSeasonCtrl);
            PermissonUtil.CheckPermissons(sizeGroupCtrl);
        }
    }
}
