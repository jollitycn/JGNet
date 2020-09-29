namespace JGNet.Manage.Components
{
    partial class EmOrderRefundReasonForm
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
            this.components = new System.ComponentModel.Container();
            this.BaseButtonConfirm = new JGNet.Common.Components.BaseButton();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.rtfRichTextBox_Detail = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BaseButtonConfirm
            // 
            this.BaseButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BaseButtonConfirm.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonConfirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonConfirm.Location = new System.Drawing.Point(341, 192);
            this.BaseButtonConfirm.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonConfirm.Name = "BaseButtonConfirm";
            this.BaseButtonConfirm.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonConfirm.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonConfirm.TabIndex = 2;
            this.BaseButtonConfirm.Text = "确定";
            this.BaseButtonConfirm.UseVisualStyleBackColor = false;
            this.BaseButtonConfirm.Click += new System.EventHandler(this.BaseButtonConfirm_Click);
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(422, 192);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 2;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(7, 39);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 156;
            this.skinLabel2.Text = "拒绝原因：";
            // 
            // rtfRichTextBox_Detail
            // 
            this.rtfRichTextBox_Detail.Location = new System.Drawing.Point(71, 39);
            this.rtfRichTextBox_Detail.Name = "rtfRichTextBox_Detail";
            this.rtfRichTextBox_Detail.Size = new System.Drawing.Size(426, 147);
            this.rtfRichTextBox_Detail.TabIndex = 166;
            this.rtfRichTextBox_Detail.Text = "";
            // 
            // EmOrderRefundReasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 231);
            this.Controls.Add(this.rtfRichTextBox_Detail);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.baseButtonCancel);
            this.Controls.Add(this.BaseButtonConfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmOrderRefundReasonForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "拒绝退款";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Components.BaseButton BaseButtonConfirm;
        private Common.Components.BaseButton baseButtonCancel;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.RichTextBox rtfRichTextBox_Detail;
    }
}