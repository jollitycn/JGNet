namespace JGNet.Manage
{
    partial class SingleDiscountForm
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_Discount = new JGNet.Common.TextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton_OK = new JGNet.Common.Components.BaseButton();
            this.BaseButton_Cancel = new JGNet.Common.Components.BaseButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(20, 57);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "折扣";
            // 
            // skinTextBox_Discount
            // 
            this.skinTextBox_Discount.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Discount.DownBack = null;
            this.skinTextBox_Discount.Icon = null;
            this.skinTextBox_Discount.IconIsButton = false;
            this.skinTextBox_Discount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Discount.IsPasswordChat = '\0';
            this.skinTextBox_Discount.IsSystemPasswordChar = false;
            this.skinTextBox_Discount.Lines = new string[0];
            this.skinTextBox_Discount.Location = new System.Drawing.Point(68, 51);
            this.skinTextBox_Discount.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Discount.MaxLength = 32767;
            this.skinTextBox_Discount.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Discount.MouseBack = null;
            this.skinTextBox_Discount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Discount.Multiline = false;
            this.skinTextBox_Discount.Name = "skinTextBox_Discount";
            this.skinTextBox_Discount.NormlBack = null;
            this.skinTextBox_Discount.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Discount.ReadOnly = false;
            this.skinTextBox_Discount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Discount.Size = new System.Drawing.Size(98, 28);
            // 
            // 
            // 
            this.skinTextBox_Discount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Discount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Discount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Discount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Discount.SkinTxt.Name = "BaseText";
            this.skinTextBox_Discount.SkinTxt.Size = new System.Drawing.Size(88, 18);
            this.skinTextBox_Discount.SkinTxt.TabIndex = 0;
            this.skinTextBox_Discount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Discount.SkinTxt.WaterText = "输入折扣";
            this.skinTextBox_Discount.TabIndex = 0;
            this.skinTextBox_Discount.TabStop = true;
            this.skinTextBox_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Discount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Discount.WaterText = "输入折扣";
            this.skinTextBox_Discount.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(182, 57);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(113, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "例如：9折请输入90";
            // 
            // BaseButton_OK
            // 
            this.BaseButton_OK.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_OK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_OK.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_OK.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_OK.Location = new System.Drawing.Point(91, 106);
            this.BaseButton_OK.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_OK.Name = "BaseButton_OK";
            this.BaseButton_OK.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_OK.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_OK.TabIndex = 2;
            this.BaseButton_OK.Text = "确认";
            this.BaseButton_OK.UseVisualStyleBackColor = false;
            this.BaseButton_OK.Click += new System.EventHandler(this.BaseButton_OK_Click);
            // 
            // BaseButton_Cancel
            // 
            this.BaseButton_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Cancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Cancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Cancel.Location = new System.Drawing.Point(172, 106);
            this.BaseButton_Cancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Cancel.Name = "BaseButton_Cancel";
            this.BaseButton_Cancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Cancel.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Cancel.TabIndex = 3;
            this.BaseButton_Cancel.Text = "取消";
            this.BaseButton_Cancel.UseVisualStyleBackColor = false;
            this.BaseButton_Cancel.Click += new System.EventHandler(this.BaseButton_Cancel_Click);
            // 
            // SingleDiscountForm
            // 
            this.AcceptButton = this.BaseButton_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 150);
            this.Controls.Add(this.BaseButton_Cancel);
            this.Controls.Add(this.BaseButton_OK);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinTextBox_Discount);
            this.Controls.Add(this.skinLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SingleDiscountForm";
            this.Text = "整单打折";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private  JGNet.Common.TextBox skinTextBox_Discount;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private Common.Components.BaseButton BaseButton_OK;
        private Common.Components.BaseButton BaseButton_Cancel;
    }
}