using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class WorkDeskMenuItemCtrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuItem1 = new JGNet.Common.Components.WorkDeskMenuItem();
            this.menuItem8 = new JGNet.Common.Components.WorkDeskMenuItem();
            this.menuItem14 = new JGNet.Common.Components.WorkDeskMenuItem();
            this.skinFlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.workDeskMenuItem2 = new JGNet.Common.Components.WorkDeskMenuItem();
            this.workDeskMenuItem1 = new JGNet.Common.Components.WorkDeskMenuItem();
            this.workDeskMenuItem3 = new JGNet.Common.Components.WorkDeskMenuItem();
            this.skinFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItem1
            // 
            this.menuItem1.Action = null;
            this.menuItem1.CurrentTabPage = null;
            this.menuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItem1.Image = global::JGNet.Manage.Properties.Resources.调拨;
            this.menuItem1.Location = new System.Drawing.Point(3, 93);
            this.menuItem1.MenuPermission = JGNet.Common.Core.RolePermissionMenuEnum.不限;
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Permission = JGNet.Common.Core.RolePermissionEnum.不限;
            this.menuItem1.RefreshPageDisable = false;
            this.menuItem1.Size = new System.Drawing.Size(74, 84);
            this.menuItem1.SourceCtrlType = null;
            this.menuItem1.TabIndex = 4;
            this.menuItem1.Title = "调拨";
            this.menuItem1.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Action = null;
            this.menuItem8.CurrentTabPage = null;
            this.menuItem8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItem8.Image = global::JGNet.Manage.Properties.Resources.收银;
            this.menuItem8.Location = new System.Drawing.Point(3, 3);
            this.menuItem8.MenuPermission = JGNet.Common.Core.RolePermissionMenuEnum.不限;
            this.menuItem8.Name = "menuItem8";
            this.menuItem8.Permission = JGNet.Common.Core.RolePermissionEnum.不限;
            this.menuItem8.RefreshPageDisable = false;
            this.menuItem8.Size = new System.Drawing.Size(74, 84);
            this.menuItem8.SourceCtrlType = null;
            this.menuItem8.TabIndex = 3;
            this.menuItem8.Title = "收银";
            this.menuItem8.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuItem14
            // 
            this.menuItem14.Action = null;
            this.menuItem14.CurrentTabPage = null;
            this.menuItem14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuItem14.Image = global::JGNet.Manage.Properties.Resources.采购退货;
            this.menuItem14.Location = new System.Drawing.Point(243, 3);
            this.menuItem14.MenuPermission = JGNet.Common.Core.RolePermissionMenuEnum.不限;
            this.menuItem14.Name = "menuItem14";
            this.menuItem14.Permission = JGNet.Common.Core.RolePermissionEnum.不限;
            this.menuItem14.RefreshPageDisable = false;
            this.menuItem14.Size = new System.Drawing.Size(74, 84);
            this.menuItem14.SourceCtrlType = null;
            this.menuItem14.TabIndex = 3;
            this.menuItem14.Title = "采购退货";
            this.menuItem14.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // skinFlowLayoutPanel1
            // 
            this.skinFlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinFlowLayoutPanel1.Controls.Add(this.menuItem8);
            this.skinFlowLayoutPanel1.Controls.Add(this.workDeskMenuItem2);
            this.skinFlowLayoutPanel1.Controls.Add(this.workDeskMenuItem1);
            this.skinFlowLayoutPanel1.Controls.Add(this.menuItem14);
            this.skinFlowLayoutPanel1.Controls.Add(this.menuItem1);
            this.skinFlowLayoutPanel1.Controls.Add(this.workDeskMenuItem3);
            this.skinFlowLayoutPanel1.Location = new System.Drawing.Point(6, 8);
            this.skinFlowLayoutPanel1.Name = "skinFlowLayoutPanel1";
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(359, 523);
            this.skinFlowLayoutPanel1.TabIndex = 12;
            // 
            // workDeskMenuItem2
            // 
            this.workDeskMenuItem2.Action = null;
            this.workDeskMenuItem2.CurrentTabPage = null;
            this.workDeskMenuItem2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.workDeskMenuItem2.Image = global::JGNet.Manage.Properties.Resources.退货;
            this.workDeskMenuItem2.Location = new System.Drawing.Point(83, 3);
            this.workDeskMenuItem2.MenuPermission = JGNet.Common.Core.RolePermissionMenuEnum.不限;
            this.workDeskMenuItem2.Name = "workDeskMenuItem2";
            this.workDeskMenuItem2.Permission = JGNet.Common.Core.RolePermissionEnum.不限;
            this.workDeskMenuItem2.RefreshPageDisable = false;
            this.workDeskMenuItem2.Size = new System.Drawing.Size(74, 84);
            this.workDeskMenuItem2.SourceCtrlType = null;
            this.workDeskMenuItem2.TabIndex = 6;
            this.workDeskMenuItem2.Title = "退货";
            this.workDeskMenuItem2.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // workDeskMenuItem1
            // 
            this.workDeskMenuItem1.Action = null;
            this.workDeskMenuItem1.CurrentTabPage = null;
            this.workDeskMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.workDeskMenuItem1.Image = global::JGNet.Manage.Properties.Resources.采购进货;
            this.workDeskMenuItem1.Location = new System.Drawing.Point(163, 3);
            this.workDeskMenuItem1.MenuPermission = JGNet.Common.Core.RolePermissionMenuEnum.不限;
            this.workDeskMenuItem1.Name = "workDeskMenuItem1";
            this.workDeskMenuItem1.Permission = JGNet.Common.Core.RolePermissionEnum.不限;
            this.workDeskMenuItem1.RefreshPageDisable = false;
            this.workDeskMenuItem1.Size = new System.Drawing.Size(74, 84);
            this.workDeskMenuItem1.SourceCtrlType = null;
            this.workDeskMenuItem1.TabIndex = 5;
            this.workDeskMenuItem1.Title = "采购进货";
            this.workDeskMenuItem1.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // workDeskMenuItem3
            // 
            this.workDeskMenuItem3.Action = null;
            this.workDeskMenuItem3.CurrentTabPage = null;
            this.workDeskMenuItem3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.workDeskMenuItem3.Image = global::JGNet.Manage.Properties.Resources.盘点;
            this.workDeskMenuItem3.Location = new System.Drawing.Point(83, 93);
            this.workDeskMenuItem3.MenuPermission = JGNet.Common.Core.RolePermissionMenuEnum.不限;
            this.workDeskMenuItem3.Name = "workDeskMenuItem3";
            this.workDeskMenuItem3.Permission = JGNet.Common.Core.RolePermissionEnum.不限;
            this.workDeskMenuItem3.RefreshPageDisable = false;
            this.workDeskMenuItem3.Size = new System.Drawing.Size(74, 84);
            this.workDeskMenuItem3.SourceCtrlType = null;
            this.workDeskMenuItem3.TabIndex = 7;
            this.workDeskMenuItem3.Title = "盘点录入";
            this.workDeskMenuItem3.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // WorkDeskMenuItemCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "WorkDeskMenuItemCtrl";
            this.Load += new System.EventHandler(this.WorkDeskMenuItemCtrl_Load);
            this.skinFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Common.Components.WorkDeskMenuItem menuItem1;
        private Common.Components.WorkDeskMenuItem menuItem8;
        private Common.Components.WorkDeskMenuItem menuItem14;
        private FlowLayoutPanel skinFlowLayoutPanel1;
        private Common.Components.WorkDeskMenuItem workDeskMenuItem1;
        private Common.Components.WorkDeskMenuItem workDeskMenuItem2;
        private Common.Components.WorkDeskMenuItem workDeskMenuItem3;
    }
}
