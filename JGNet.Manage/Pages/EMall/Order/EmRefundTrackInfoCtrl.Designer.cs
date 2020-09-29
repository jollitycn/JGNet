namespace JGNet.Manage.Pages
{
    partial class EmRefundTrackInfoCtrl
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
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelMsg = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // skinLabel6
            // 
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(268, 9);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(140, 17);
            this.skinLabel6.TabIndex = 1;
            this.skinLabel6.Text = "2010-10-10 00:00:00";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(3, 9);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(200, 17);
            this.skinLabel5.TabIndex = 2;
            this.skinLabel5.Text = "商家同意退款，微信商户平台退款中";
            // 
            // skinLabelMsg
            // 
            this.skinLabelMsg.AutoSize = true;
            this.skinLabelMsg.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelMsg.BorderColor = System.Drawing.Color.White;
            this.skinLabelMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelMsg.Location = new System.Drawing.Point(3, 26);
            this.skinLabelMsg.Name = "skinLabelMsg";
            this.skinLabelMsg.Size = new System.Drawing.Size(200, 17);
            this.skinLabelMsg.TabIndex = 2;
            this.skinLabelMsg.Text = "商家同意退款，微信商户平台退款中";
            // 
            // EmRefundTrackInfoCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabelMsg);
            this.Controls.Add(this.skinLabel5);
            this.Name = "EmRefundTrackInfoCtrl";
            this.Size = new System.Drawing.Size(411, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabelMsg;
    }
}
