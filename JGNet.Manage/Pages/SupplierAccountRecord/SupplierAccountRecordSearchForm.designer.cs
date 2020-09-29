namespace JGNet.Manage.Components
{
    partial class SupplierAccountRecordSearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.supplierAccountRecordSearchCtrl1 = new JGNet.Manage.SupplierAccountRecordSearchCtrl();
            this.SuspendLayout();
            // 
            // supplierAccountRecordSearchCtrl1
            // 
            this.supplierAccountRecordSearchCtrl1.Action = null;
            this.supplierAccountRecordSearchCtrl1.AutoSize = true;
            this.supplierAccountRecordSearchCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.supplierAccountRecordSearchCtrl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.supplierAccountRecordSearchCtrl1.CurrentTabPage = null;
            this.supplierAccountRecordSearchCtrl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.supplierAccountRecordSearchCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierAccountRecordSearchCtrl1.HasInvokeTabClose = false;
            this.supplierAccountRecordSearchCtrl1.IsShowOnePage = false;
            this.supplierAccountRecordSearchCtrl1.Location = new System.Drawing.Point(4, 28);
            this.supplierAccountRecordSearchCtrl1.Name = "supplierAccountRecordSearchCtrl1";
            this.supplierAccountRecordSearchCtrl1.RefreshPageDisable = false;
            this.supplierAccountRecordSearchCtrl1.Size = new System.Drawing.Size(856, 570);
            this.supplierAccountRecordSearchCtrl1.SourceCtrlType = null;
            this.supplierAccountRecordSearchCtrl1.SourceTabPage = null;
            this.supplierAccountRecordSearchCtrl1.TabIndex = 0;
            // 
            // SupplierAccountRecordSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 602);
            this.Controls.Add(this.supplierAccountRecordSearchCtrl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierAccountRecordSearchForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "供应商往来账明细";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.SupplierAccountRecordSearchForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SupplierAccountRecordSearchCtrl supplierAccountRecordSearchCtrl1;
    }
}