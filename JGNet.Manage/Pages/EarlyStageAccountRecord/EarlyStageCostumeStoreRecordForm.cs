﻿using CCWin;
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using CJBasic.Loggers;
using JieXi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Common
{
    public partial class EarlyStageCostumeStoreRecordForm : Common.BaseForm
    {
        public String ShopID
        {
            get
            {
                return shopID;
            }
        }

        public String Path
        {
            get
            {
                return path;
            }
        }

        private String shopID;
        private String path;

        private String selectShopId = string.Empty;
        public CJBasic.Action<String, String, EarlyStageCostumeStoreRecordForm> ConfirmClick;

        public EarlyStageCostumeStoreRecordForm(String shopID)
        {
            InitializeComponent();
            this.Text = "期初库存导入";
            MenuPermission = Core.RolePermissionMenuEnum.期初库存录入;
            skinLabelFileName.Text = string.Empty;
            skinComboBoxShopID.Initialize(true, false);
            selectShopId = shopID;
           //this.shopID = shopID;
        }

        private void BaseButton_OK_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            this.skinPanel2.Enabled = false;
            if (string.IsNullOrEmpty(path))
            {
                GlobalMessageBox.Show("请选择文件!");
                this.UseWaitCursor = false;
                this.skinPanel2.Enabled = true;
                return;
            }

            ConfirmClick?.Invoke(shopID, path, this);
        }

        public void SetDialogResult(DialogResult result)
        {
            this.skinPanel2.Enabled = true;
            this.DialogResult = result;
            this.UseWaitCursor = false;
        }

        private void BaseButton_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void Cancel()
        {
            this.skinPanel2.Enabled = true;
            this.UseWaitCursor = false;
        }

        private void baseButtonChooseFile_Click(object sender, EventArgs e)
        {

            path = CJBasic.Helpers.FileHelper.GetFileToOpen("请选择导入文件");
            skinLabelFileName.Text = path;
            if (String.IsNullOrEmpty(path))
            {
                //      GlobalMessageBox.Show("请选择文件！");
                return;
            }
            else
            {

                string fileExt =System.IO.Path.GetExtension(path);
                if (fileExt != ".xlsx" && fileExt != ".xls")
                {
                    ShowMessage("你所选择文件格式不正确，请重新上传文件！");
                    return;
                }
            }
        }

        private void skinComboBoxShopID_SelectedIndexChanged(object sender, EventArgs e)
        {
            shopID = ValidateUtil.CheckEmptyValue(skinComboBoxShopID.SelectedValue);
        }

        private void EarlyStageCostumeStoreRecordForm_Load(object sender, EventArgs e)
        {
            skinComboBoxShopID.Enabled = false;
            skinComboBoxShopID.SelectedValue = selectShopId;
        }
    }
}
