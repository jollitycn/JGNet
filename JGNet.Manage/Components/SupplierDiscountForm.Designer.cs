namespace JGNet.Manage.Components
{
    partial class SupplierDiscountForm
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
            this.BaseButton_Search = new JGNet.Common.Components.BaseButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelDefault = new CCWin.SkinControl.SkinLabel();
            this.numericUpDownSupplierDiscount = new JGNet.Common.NumericTextBox();
            this.SuspendLayout();
            // 
            // BaseButton_Search
            // 
            this.BaseButton_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton_Search.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Search.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Search.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Search.Location = new System.Drawing.Point(200, 106);
            this.BaseButton_Search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Search.Name = "BaseButton_Search";
            this.BaseButton_Search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Search.TabIndex = 3;
            this.BaseButton_Search.Text = "确定";
            this.BaseButton_Search.UseVisualStyleBackColor = false;
            this.BaseButton_Search.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(16, 40);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(128, 17);
            this.skinLabel1.TabIndex = 84;
            this.skinLabel1.Text = "当前进货折扣默认值：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(16, 72);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(128, 17);
            this.skinLabel3.TabIndex = 84;
            this.skinLabel3.Text = "输入修改后的默认值：";
            // 
            // skinLabelDefault
            // 
            this.skinLabelDefault.AutoSize = true;
            this.skinLabelDefault.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelDefault.BorderColor = System.Drawing.Color.White;
            this.skinLabelDefault.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelDefault.Location = new System.Drawing.Point(150, 40);
            this.skinLabelDefault.Name = "skinLabelDefault";
            this.skinLabelDefault.Size = new System.Drawing.Size(128, 17);
            this.skinLabelDefault.TabIndex = 84;
            this.skinLabelDefault.Text = "当前进货折扣默认值：";
            // 
            // numericUpDownSupplierDiscount
            // 
            this.numericUpDownSupplierDiscount.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownSupplierDiscount.DecimalPlaces = 0;
            this.numericUpDownSupplierDiscount.DownBack = null;
            this.numericUpDownSupplierDiscount.Icon = null;
            this.numericUpDownSupplierDiscount.IconIsButton = false;
            this.numericUpDownSupplierDiscount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownSupplierDiscount.IsPasswordChat = '\0';
            this.numericUpDownSupplierDiscount.IsSystemPasswordChar = false;
            this.numericUpDownSupplierDiscount.Lines = new string[0];
            this.numericUpDownSupplierDiscount.Location = new System.Drawing.Point(153, 66);
            this.numericUpDownSupplierDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownSupplierDiscount.MaxLength = 32767;
            this.numericUpDownSupplierDiscount.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDownSupplierDiscount.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericUpDownSupplierDiscount.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownSupplierDiscount.MouseBack = null;
            this.numericUpDownSupplierDiscount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownSupplierDiscount.Multiline = false;
            this.numericUpDownSupplierDiscount.Name = "numericUpDownSupplierDiscount";
            this.numericUpDownSupplierDiscount.NormlBack = null;
            this.numericUpDownSupplierDiscount.Padding = new System.Windows.Forms.Padding(5);
            this.numericUpDownSupplierDiscount.ReadOnly = false;
            this.numericUpDownSupplierDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericUpDownSupplierDiscount.Size = new System.Drawing.Size(122, 28);
            // 
            // 
            // 
            this.numericUpDownSupplierDiscount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownSupplierDiscount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownSupplierDiscount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericUpDownSupplierDiscount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericUpDownSupplierDiscount.SkinTxt.Name = "BaseText";
            this.numericUpDownSupplierDiscount.SkinTxt.Size = new System.Drawing.Size(112, 18);
            this.numericUpDownSupplierDiscount.SkinTxt.TabIndex = 0;
            this.numericUpDownSupplierDiscount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownSupplierDiscount.SkinTxt.WaterText = "";
            this.numericUpDownSupplierDiscount.TabIndex = 85;
            this.numericUpDownSupplierDiscount.TabStop = true;
            this.numericUpDownSupplierDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericUpDownSupplierDiscount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownSupplierDiscount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownSupplierDiscount.WaterText = "";
            this.numericUpDownSupplierDiscount.WordWrap = true;
            // 
            // SupplierDiscountForm
            // 
            this.AcceptButton = this.BaseButton_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 143);
            this.Controls.Add(this.numericUpDownSupplierDiscount);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabelDefault);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.BaseButton_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierDiscountForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Search;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabelDefault;
        private Common.NumericTextBox numericUpDownSupplierDiscount;
    }
}