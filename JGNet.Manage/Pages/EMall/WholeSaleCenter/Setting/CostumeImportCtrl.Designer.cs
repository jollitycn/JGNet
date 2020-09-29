namespace JGNet.Manage
{
    partial class CostumeImportCtrl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumeImportCtrl));
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.baseButtonChooseFile = new JGNet.Common.Components.BaseButton();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.textBoxPath);
            this.skinPanel1.Controls.Add(this.baseButtonChooseFile);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160,650);
            this.skinPanel1.TabIndex = 79;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPath.Location = new System.Drawing.Point(215, 244);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(408, 21);
            this.textBoxPath.TabIndex = 69;
            // 
            // baseButtonChooseFile
            // 
            this.baseButtonChooseFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseButtonChooseFile.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonChooseFile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonChooseFile.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonChooseFile.DownBack")));
            this.baseButtonChooseFile.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonChooseFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonChooseFile.Location = new System.Drawing.Point(629, 238);
            this.baseButtonChooseFile.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonChooseFile.MouseBack")));
            this.baseButtonChooseFile.Name = "baseButtonChooseFile";
            this.baseButtonChooseFile.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonChooseFile.NormlBack")));
            this.baseButtonChooseFile.Size = new System.Drawing.Size(75, 32);
            this.baseButtonChooseFile.TabIndex = 68;
            this.baseButtonChooseFile.Text = "选择文件";
            this.baseButtonChooseFile.UseVisualStyleBackColor = false;
            this.baseButtonChooseFile.Click += new System.EventHandler(this.baseButtonChooseFile_Click);
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Enabled = false;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(710, 238);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "导入";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(153, 246);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 66;
            this.skinLabel3.Text = "文件路径";
            // 
            // CostumeImportCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel1);
            this.Name = "CostumeImportCtrl";
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel skinPanel1;
        private Common.Components.BaseButton BaseButton3;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.TextBox textBoxPath;
        private Common.Components.BaseButton baseButtonChooseFile;
    }
}
