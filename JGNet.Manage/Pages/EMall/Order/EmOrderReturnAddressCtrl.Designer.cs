namespace JGNet.Manage.Pages
{
    partial class EmOrderReturnAddressCtrl
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.skinRadioButton1 = new CCWin.SkinControl.SkinRadioButton();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(679, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 164;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "编辑";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(714, 12);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 12);
            this.linkLabel2.TabIndex = 164;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "删除";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // skinRadioButton1
            // 
            this.skinRadioButton1.AutoSize = true;
            this.skinRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton1.DownBack = null;
            this.skinRadioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton1.Location = new System.Drawing.Point(3, 8);
            this.skinRadioButton1.MouseBack = null;
            this.skinRadioButton1.Name = "skinRadioButton1";
            this.skinRadioButton1.NormlBack = null;
            this.skinRadioButton1.SelectedDownBack = null;
            this.skinRadioButton1.SelectedMouseBack = null;
            this.skinRadioButton1.SelectedNormlBack = null;
            this.skinRadioButton1.Size = new System.Drawing.Size(128, 21);
            this.skinRadioButton1.TabIndex = 165;
            this.skinRadioButton1.TabStop = true;
            this.skinRadioButton1.Text = "skinRadioButton1";
            this.skinRadioButton1.UseVisualStyleBackColor = false;
            this.skinRadioButton1.CheckedChanged += new System.EventHandler(this.skinRadioButton1_CheckedChanged);
            // 
            // EmOrderReturnAddressCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.skinRadioButton1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "EmOrderReturnAddressCtrl";
            this.Size = new System.Drawing.Size(746, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton1;
    }
}
