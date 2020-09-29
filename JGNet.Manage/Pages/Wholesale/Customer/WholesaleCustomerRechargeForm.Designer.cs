using JGNet.Manage;

namespace JGNet.Common.Components
{
    partial class WholesaleCustomerRechargeForm
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
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.BaseButtonConfirm = new JGNet.Common.Components.BaseButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.textBoxAmount = new JGNet.Common.NumericTextBox();
            this.richTextBoxRemark = new System.Windows.Forms.RichTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelBalance = new CCWin.SkinControl.SkinLabel();
            this.skinLabelName = new CCWin.SkinControl.SkinLabel();
            this.textBoxCustomer = new JGNet.Common.PfCustomerComboBox();
            this.SuspendLayout();
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(10, 99);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 168;
            this.skinLabel2.Text = "客户名称";
            // 
            // BaseButtonConfirm
            // 
            this.BaseButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonConfirm.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonConfirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonConfirm.Location = new System.Drawing.Point(101, 228);
            this.BaseButtonConfirm.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonConfirm.Name = "BaseButtonConfirm";
            this.BaseButtonConfirm.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonConfirm.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonConfirm.TabIndex = 4;
            this.BaseButtonConfirm.Text = "保存";
            this.BaseButtonConfirm.UseVisualStyleBackColor = false;
            this.BaseButtonConfirm.Click += new System.EventHandler(this.BaseButtonConfirm_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(10, 135);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 166;
            this.skinLabel1.Text = "充值金额";
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(182, 228);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 5;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(34, 161);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 165;
            this.skinLabel3.Text = "备注";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BackColor = System.Drawing.Color.Transparent;
            this.textBoxAmount.DecimalPlaces = 0;
            this.textBoxAmount.DownBack = null;
            this.textBoxAmount.Icon = null;
            this.textBoxAmount.IconIsButton = false;
            this.textBoxAmount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxAmount.IsPasswordChat = '\0';
            this.textBoxAmount.IsSystemPasswordChar = false;
            this.textBoxAmount.Lines = new string[0];
            this.textBoxAmount.Location = new System.Drawing.Point(73, 129);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAmount.MaxLength = 9;
            this.textBoxAmount.MaxNum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.textBoxAmount.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxAmount.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxAmount.MouseBack = null;
            this.textBoxAmount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxAmount.Multiline = false;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.NormlBack = null;
            this.textBoxAmount.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxAmount.ReadOnly = false;
            this.textBoxAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAmount.ShowZero = false;
            this.textBoxAmount.Size = new System.Drawing.Size(180, 28);
            // 
            // 
            // 
            this.textBoxAmount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAmount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxAmount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxAmount.SkinTxt.MaxLength = 9;
            this.textBoxAmount.SkinTxt.Name = "BaseText";
            this.textBoxAmount.SkinTxt.Size = new System.Drawing.Size(170, 18);
            this.textBoxAmount.SkinTxt.TabIndex = 0;
            this.textBoxAmount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxAmount.SkinTxt.WaterText = "";
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.TabStop = true;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxAmount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxAmount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxAmount.WaterText = "";
            this.textBoxAmount.WordWrap = true;
            // 
            // richTextBoxRemark
            // 
            this.richTextBoxRemark.Location = new System.Drawing.Point(73, 161);
            this.richTextBoxRemark.Name = "richTextBoxRemark";
            this.richTextBoxRemark.Size = new System.Drawing.Size(180, 62);
            this.richTextBoxRemark.TabIndex = 2;
            this.richTextBoxRemark.Text = "";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(34, 67);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 172;
            this.skinLabel4.Text = "余额";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(10, 40);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 172;
            this.skinLabel5.Text = "客户名称";
            // 
            // skinLabelBalance
            // 
            this.skinLabelBalance.AutoSize = true;
            this.skinLabelBalance.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelBalance.BorderColor = System.Drawing.Color.White;
            this.skinLabelBalance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelBalance.Location = new System.Drawing.Point(72, 67);
            this.skinLabelBalance.Name = "skinLabelBalance";
            this.skinLabelBalance.Size = new System.Drawing.Size(32, 17);
            this.skinLabelBalance.TabIndex = 172;
            this.skinLabelBalance.Text = "余额";
            // 
            // skinLabelName
            // 
            this.skinLabelName.AutoSize = true;
            this.skinLabelName.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelName.BorderColor = System.Drawing.Color.White;
            this.skinLabelName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelName.Location = new System.Drawing.Point(72, 40);
            this.skinLabelName.Name = "skinLabelName";
            this.skinLabelName.Size = new System.Drawing.Size(56, 17);
            this.skinLabelName.TabIndex = 172;
            this.skinLabelName.Text = "客户名称";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.CheckPfCustomer = false;
            this.textBoxCustomer.curSelectStr = null;
            this.textBoxCustomer.CustomerTypeValue = -1;
            this.textBoxCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.textBoxCustomer.FormattingEnabled = true;
            this.textBoxCustomer.HideEmpty = false;
            this.textBoxCustomer.Location = new System.Drawing.Point(72, 96);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(181, 22);
            this.textBoxCustomer.TabIndex = 173;
            this.textBoxCustomer.WaterText = "输入编号、名称后回车";
            this.textBoxCustomer.ItemSelected += new System.Action<JGNet.PfCustomer>(this.textBoxCustomer_ItemSelected);
            // 
            // WholesaleCustomerRechargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 267);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.skinLabelName);
            this.Controls.Add(this.skinLabelBalance);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.richTextBoxRemark);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.baseButtonCancel);
            this.Controls.Add(this.BaseButtonConfirm);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WholesaleCustomerRechargeForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "批发-客户充值";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private Common.Components.BaseButton BaseButtonConfirm;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.Components.BaseButton baseButtonCancel;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private NumericTextBox textBoxAmount;
        private System.Windows.Forms.RichTextBox richTextBoxRemark;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabelBalance;
        private CCWin.SkinControl.SkinLabel skinLabelName;
        private PfCustomerComboBox textBoxCustomer;
    }
}