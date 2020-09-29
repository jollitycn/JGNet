using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class SaveOffLineCustomerForm
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
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxName = new JGNet.Common.TextBox();
            this.skinTextBoxID = new JGNet.Common.TextBox();
            this.textBoxPwd = new JGNet.Common.TextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_Percent = new JGNet.Common.NumericTextBox();
            this.textBoxBusinessAccount = new JGNet.Common.TextBox();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.skinRadioButtonBuyout = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButtonSale = new CCWin.SkinControl.SkinRadioButton();
            this.skinTextBox_Contact = new JGNet.Common.TextBox();
            this.skinTextBox_ContactPhone = new JGNet.Common.TextBox();
            this.skinTextBox_Remarks = new JGNet.Common.TextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_BankInfo = new JGNet.Common.TextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBox_Enabled = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBoxShowPwd = new CCWin.SkinControl.SkinCheckBox();
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
            this.BaseButton_Search.Location = new System.Drawing.Point(238, 483);
            this.BaseButton_Search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Search.Name = "BaseButton_Search";
            this.BaseButton_Search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Search.TabIndex = 3;
            this.BaseButton_Search.Text = "确定";
            this.BaseButton_Search.UseVisualStyleBackColor = false;
            this.BaseButton_Search.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(69, 98);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 83;
            this.skinLabel2.Text = "客户名称";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(69, 58);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 84;
            this.skinLabel1.Text = "客户编号";
            // 
            // skinTextBoxName
            // 
            this.skinTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxName.DownBack = null;
            this.skinTextBoxName.Icon = null;
            this.skinTextBoxName.IconIsButton = false;
            this.skinTextBoxName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.IsPasswordChat = '\0';
            this.skinTextBoxName.IsSystemPasswordChar = false;
            this.skinTextBoxName.Lines = new string[0];
            this.skinTextBoxName.Location = new System.Drawing.Point(140, 89);
            this.skinTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxName.MaxLength = 32767;
            this.skinTextBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxName.MouseBack = null;
            this.skinTextBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.Multiline = true;
            this.skinTextBoxName.Name = "skinTextBoxName";
            this.skinTextBoxName.NormlBack = null;
            this.skinTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxName.ReadOnly = false;
            this.skinTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxName.Size = new System.Drawing.Size(346, 34);
            // 
            // 
            // 
            this.skinTextBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxName.SkinTxt.Multiline = true;
            this.skinTextBoxName.SkinTxt.Name = "BaseText";
            this.skinTextBoxName.SkinTxt.Size = new System.Drawing.Size(336, 24);
            this.skinTextBoxName.SkinTxt.TabIndex = 0;
            this.skinTextBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.SkinTxt.WaterText = "名称";
            this.skinTextBoxName.TabIndex = 1;
            this.skinTextBoxName.TabStop = true;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "名称";
            this.skinTextBoxName.WordWrap = true;
            this.skinTextBoxName.Leave += new System.EventHandler(this.skinTextBoxName_Leave);
            // 
            // skinTextBoxID
            // 
            this.skinTextBoxID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxID.DownBack = null;
            this.skinTextBoxID.Icon = null;
            this.skinTextBoxID.IconIsButton = false;
            this.skinTextBoxID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxID.IsPasswordChat = '\0';
            this.skinTextBoxID.IsSystemPasswordChar = false;
            this.skinTextBoxID.Lines = new string[0];
            this.skinTextBoxID.Location = new System.Drawing.Point(140, 49);
            this.skinTextBoxID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxID.MaxLength = 32767;
            this.skinTextBoxID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxID.MouseBack = null;
            this.skinTextBoxID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxID.Multiline = true;
            this.skinTextBoxID.Name = "skinTextBoxID";
            this.skinTextBoxID.NormlBack = null;
            this.skinTextBoxID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxID.ReadOnly = false;
            this.skinTextBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxID.Size = new System.Drawing.Size(346, 34);
            // 
            // 
            // 
            this.skinTextBoxID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxID.SkinTxt.Multiline = true;
            this.skinTextBoxID.SkinTxt.Name = "BaseText";
            this.skinTextBoxID.SkinTxt.Size = new System.Drawing.Size(336, 24);
            this.skinTextBoxID.SkinTxt.TabIndex = 0;
            this.skinTextBoxID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.SkinTxt.WaterText = "编号";
            this.skinTextBoxID.TabIndex = 0;
            this.skinTextBoxID.TabStop = true;
            this.skinTextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.WaterText = "编号";
            this.skinTextBoxID.WordWrap = true;
            this.skinTextBoxID.Leave += new System.EventHandler(this.skinTextBoxID_Leave);
            // 
            // textBoxPwd
            // 
            this.textBoxPwd.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPwd.DownBack = null;
            this.textBoxPwd.Icon = null;
            this.textBoxPwd.IconIsButton = false;
            this.textBoxPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxPwd.IsPasswordChat = '●';
            this.textBoxPwd.IsSystemPasswordChar = true;
            this.textBoxPwd.Lines = new string[0];
            this.textBoxPwd.Location = new System.Drawing.Point(141, 171);
            this.textBoxPwd.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPwd.MaxLength = 32767;
            this.textBoxPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxPwd.MouseBack = null;
            this.textBoxPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxPwd.Multiline = false;
            this.textBoxPwd.Name = "textBoxPwd";
            this.textBoxPwd.NormlBack = null;
            this.textBoxPwd.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxPwd.ReadOnly = false;
            this.textBoxPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPwd.Size = new System.Drawing.Size(216, 28);
            // 
            // 
            // 
            this.textBoxPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxPwd.SkinTxt.Name = "BaseText";
            this.textBoxPwd.SkinTxt.PasswordChar = '●';
            this.textBoxPwd.SkinTxt.Size = new System.Drawing.Size(206, 18);
            this.textBoxPwd.SkinTxt.TabIndex = 0;
            this.textBoxPwd.SkinTxt.UseSystemPasswordChar = true;
            this.textBoxPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxPwd.SkinTxt.WaterText = "密码";
            this.textBoxPwd.TabIndex = 1;
            this.textBoxPwd.TabStop = true;
            this.textBoxPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxPwd.WaterText = "密码";
            this.textBoxPwd.WordWrap = true;
            this.textBoxPwd.Leave += new System.EventHandler(this.textBoxPwd_Leave);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(87, 175);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 83;
            this.skinLabel3.Text = "密码";
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(319, 483);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 3;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(69, 394);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 83;
            this.skinLabel4.Text = "批发折扣";
            // 
            // skinTextBox_Percent
            // 
            this.skinTextBox_Percent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinTextBox_Percent.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Percent.DecimalPlaces = 0;
            this.skinTextBox_Percent.DownBack = null;
            this.skinTextBox_Percent.Icon = null;
            this.skinTextBox_Percent.IconIsButton = false;
            this.skinTextBox_Percent.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Percent.IsPasswordChat = '\0';
            this.skinTextBox_Percent.IsSystemPasswordChar = false;
            this.skinTextBox_Percent.Lines = new string[0];
            this.skinTextBox_Percent.Location = new System.Drawing.Point(138, 389);
            this.skinTextBox_Percent.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Percent.MaxLength = 4;
            this.skinTextBox_Percent.MaxNum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.skinTextBox_Percent.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Percent.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinTextBox_Percent.MouseBack = null;
            this.skinTextBox_Percent.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Percent.Multiline = false;
            this.skinTextBox_Percent.Name = "skinTextBox_Percent";
            this.skinTextBox_Percent.NormlBack = null;
            this.skinTextBox_Percent.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Percent.ReadOnly = false;
            this.skinTextBox_Percent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Percent.ShowZero = false;
            this.skinTextBox_Percent.Size = new System.Drawing.Size(206, 28);
            // 
            // 
            // 
            this.skinTextBox_Percent.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.skinTextBox_Percent.SkinTxt.MaxLength = 4;
            this.skinTextBox_Percent.SkinTxt.Name = "BaseText";
            this.skinTextBox_Percent.SkinTxt.TabIndex = 0;
            this.skinTextBox_Percent.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Percent.SkinTxt.WaterText = "折扣";
            this.skinTextBox_Percent.TabIndex = 165;
            this.skinTextBox_Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Percent.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinTextBox_Percent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Percent.WaterText = "折扣";
            this.skinTextBox_Percent.WordWrap = true;
            // 
            // textBoxBusinessAccount
            // 
            this.textBoxBusinessAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxBusinessAccount.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBusinessAccount.DownBack = null;
            this.textBoxBusinessAccount.Icon = null;
            this.textBoxBusinessAccount.IconIsButton = false;
            this.textBoxBusinessAccount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxBusinessAccount.IsPasswordChat = '\0';
            this.textBoxBusinessAccount.IsSystemPasswordChar = false;
            this.textBoxBusinessAccount.Lines = new string[0];
            this.textBoxBusinessAccount.Location = new System.Drawing.Point(138, 132);
            this.textBoxBusinessAccount.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBusinessAccount.MaxLength = 32767;
            this.textBoxBusinessAccount.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxBusinessAccount.MouseBack = null;
            this.textBoxBusinessAccount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxBusinessAccount.Multiline = false;
            this.textBoxBusinessAccount.Name = "textBoxBusinessAccount";
            this.textBoxBusinessAccount.NormlBack = null;
            this.textBoxBusinessAccount.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxBusinessAccount.ReadOnly = false;
            this.textBoxBusinessAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxBusinessAccount.Size = new System.Drawing.Size(346, 28);
            // 
            // 
            // 
            this.textBoxBusinessAccount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBusinessAccount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBusinessAccount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxBusinessAccount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxBusinessAccount.SkinTxt.Name = "BaseText";
            this.textBoxBusinessAccount.SkinTxt.Size = new System.Drawing.Size(336, 18);
            this.textBoxBusinessAccount.SkinTxt.TabIndex = 0;
            this.textBoxBusinessAccount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxBusinessAccount.SkinTxt.WaterText = "";
            this.textBoxBusinessAccount.TabIndex = 166;
            this.textBoxBusinessAccount.TabStop = true;
            this.textBoxBusinessAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxBusinessAccount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxBusinessAccount.WaterText = "";
            this.textBoxBusinessAccount.WordWrap = true;
            // 
            // skinLabel12
            // 
            this.skinLabel12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(84, 137);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(32, 17);
            this.skinLabel12.TabIndex = 167;
            this.skinLabel12.Text = "账套";
            // 
            // skinLabel13
            // 
            this.skinLabel13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel13.Location = new System.Drawing.Point(84, 208);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(32, 17);
            this.skinLabel13.TabIndex = 178;
            this.skinLabel13.Text = "类型";
            // 
            // skinRadioButtonBuyout
            // 
            this.skinRadioButtonBuyout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinRadioButtonBuyout.AutoSize = true;
            this.skinRadioButtonBuyout.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonBuyout.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonBuyout.DownBack = null;
            this.skinRadioButtonBuyout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonBuyout.Location = new System.Drawing.Point(197, 208);
            this.skinRadioButtonBuyout.MouseBack = null;
            this.skinRadioButtonBuyout.Name = "skinRadioButtonBuyout";
            this.skinRadioButtonBuyout.NormlBack = null;
            this.skinRadioButtonBuyout.SelectedDownBack = null;
            this.skinRadioButtonBuyout.SelectedMouseBack = null;
            this.skinRadioButtonBuyout.SelectedNormlBack = null;
            this.skinRadioButtonBuyout.Size = new System.Drawing.Size(50, 21);
            this.skinRadioButtonBuyout.TabIndex = 176;
            this.skinRadioButtonBuyout.Tag = "sexRadio";
            this.skinRadioButtonBuyout.Text = "买断";
            this.skinRadioButtonBuyout.UseVisualStyleBackColor = false;
            // 
            // skinRadioButtonSale
            // 
            this.skinRadioButtonSale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinRadioButtonSale.AutoSize = true;
            this.skinRadioButtonSale.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonSale.Checked = true;
            this.skinRadioButtonSale.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonSale.DownBack = null;
            this.skinRadioButtonSale.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonSale.Location = new System.Drawing.Point(141, 208);
            this.skinRadioButtonSale.MouseBack = null;
            this.skinRadioButtonSale.Name = "skinRadioButtonSale";
            this.skinRadioButtonSale.NormlBack = null;
            this.skinRadioButtonSale.SelectedDownBack = null;
            this.skinRadioButtonSale.SelectedMouseBack = null;
            this.skinRadioButtonSale.SelectedNormlBack = null;
            this.skinRadioButtonSale.Size = new System.Drawing.Size(50, 21);
            this.skinRadioButtonSale.TabIndex = 177;
            this.skinRadioButtonSale.TabStop = true;
            this.skinRadioButtonSale.Tag = "sexRadio";
            this.skinRadioButtonSale.Text = "代卖";
            this.skinRadioButtonSale.UseVisualStyleBackColor = false;
            // 
            // skinTextBox_Contact
            // 
            this.skinTextBox_Contact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_Contact.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Contact.DownBack = null;
            this.skinTextBox_Contact.Icon = null;
            this.skinTextBox_Contact.IconIsButton = false;
            this.skinTextBox_Contact.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Contact.IsPasswordChat = '\0';
            this.skinTextBox_Contact.IsSystemPasswordChar = false;
            this.skinTextBox_Contact.Lines = new string[0];
            this.skinTextBox_Contact.Location = new System.Drawing.Point(138, 239);
            this.skinTextBox_Contact.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Contact.MaxLength = 32767;
            this.skinTextBox_Contact.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Contact.MouseBack = null;
            this.skinTextBox_Contact.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Contact.Multiline = false;
            this.skinTextBox_Contact.Name = "skinTextBox_Contact";
            this.skinTextBox_Contact.NormlBack = null;
            this.skinTextBox_Contact.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Contact.ReadOnly = false;
            this.skinTextBox_Contact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Contact.Size = new System.Drawing.Size(346, 28);
            // 
            // 
            // 
            this.skinTextBox_Contact.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Contact.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Contact.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Contact.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Contact.SkinTxt.Name = "BaseText";
            this.skinTextBox_Contact.SkinTxt.Size = new System.Drawing.Size(336, 18);
            this.skinTextBox_Contact.SkinTxt.TabIndex = 0;
            this.skinTextBox_Contact.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Contact.SkinTxt.WaterText = "";
            this.skinTextBox_Contact.TabIndex = 168;
            this.skinTextBox_Contact.TabStop = true;
            this.skinTextBox_Contact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Contact.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Contact.WaterText = "";
            this.skinTextBox_Contact.WordWrap = true;
            // 
            // skinTextBox_ContactPhone
            // 
            this.skinTextBox_ContactPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_ContactPhone.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_ContactPhone.DownBack = null;
            this.skinTextBox_ContactPhone.Icon = null;
            this.skinTextBox_ContactPhone.IconIsButton = false;
            this.skinTextBox_ContactPhone.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_ContactPhone.IsPasswordChat = '\0';
            this.skinTextBox_ContactPhone.IsSystemPasswordChar = false;
            this.skinTextBox_ContactPhone.Lines = new string[0];
            this.skinTextBox_ContactPhone.Location = new System.Drawing.Point(138, 275);
            this.skinTextBox_ContactPhone.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_ContactPhone.MaxLength = 32767;
            this.skinTextBox_ContactPhone.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_ContactPhone.MouseBack = null;
            this.skinTextBox_ContactPhone.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_ContactPhone.Multiline = false;
            this.skinTextBox_ContactPhone.Name = "skinTextBox_ContactPhone";
            this.skinTextBox_ContactPhone.NormlBack = null;
            this.skinTextBox_ContactPhone.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_ContactPhone.ReadOnly = false;
            this.skinTextBox_ContactPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_ContactPhone.Size = new System.Drawing.Size(346, 28);
            // 
            // 
            // 
            this.skinTextBox_ContactPhone.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_ContactPhone.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_ContactPhone.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_ContactPhone.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_ContactPhone.SkinTxt.Name = "BaseText";
            this.skinTextBox_ContactPhone.SkinTxt.Size = new System.Drawing.Size(336, 18);
            this.skinTextBox_ContactPhone.SkinTxt.TabIndex = 0;
            this.skinTextBox_ContactPhone.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_ContactPhone.SkinTxt.WaterText = "";
            this.skinTextBox_ContactPhone.TabIndex = 169;
            this.skinTextBox_ContactPhone.TabStop = true;
            this.skinTextBox_ContactPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_ContactPhone.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_ContactPhone.WaterText = "";
            this.skinTextBox_ContactPhone.WordWrap = true;
            // 
            // skinTextBox_Remarks
            // 
            this.skinTextBox_Remarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Remarks.DownBack = null;
            this.skinTextBox_Remarks.Icon = null;
            this.skinTextBox_Remarks.IconIsButton = false;
            this.skinTextBox_Remarks.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.IsPasswordChat = '\0';
            this.skinTextBox_Remarks.IsSystemPasswordChar = false;
            this.skinTextBox_Remarks.Lines = new string[0];
            this.skinTextBox_Remarks.Location = new System.Drawing.Point(138, 350);
            this.skinTextBox_Remarks.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Remarks.MaxLength = 32767;
            this.skinTextBox_Remarks.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Remarks.MouseBack = null;
            this.skinTextBox_Remarks.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.Multiline = false;
            this.skinTextBox_Remarks.Name = "skinTextBox_Remarks";
            this.skinTextBox_Remarks.NormlBack = null;
            this.skinTextBox_Remarks.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Remarks.ReadOnly = false;
            this.skinTextBox_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Remarks.Size = new System.Drawing.Size(346, 28);
            // 
            // 
            // 
            this.skinTextBox_Remarks.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Remarks.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Remarks.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Remarks.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Remarks.SkinTxt.Name = "BaseText";
            this.skinTextBox_Remarks.SkinTxt.Size = new System.Drawing.Size(336, 18);
            this.skinTextBox_Remarks.SkinTxt.TabIndex = 0;
            this.skinTextBox_Remarks.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.SkinTxt.WaterText = "";
            this.skinTextBox_Remarks.TabIndex = 171;
            this.skinTextBox_Remarks.TabStop = true;
            this.skinTextBox_Remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Remarks.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.WaterText = "";
            this.skinTextBox_Remarks.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(65, 315);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(56, 17);
            this.skinLabel7.TabIndex = 174;
            this.skinLabel7.Text = "银行账户";
            // 
            // skinLabel5
            // 
            this.skinLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(77, 244);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(44, 17);
            this.skinLabel5.TabIndex = 172;
            this.skinLabel5.Text = "联系人";
            // 
            // skinTextBox_BankInfo
            // 
            this.skinTextBox_BankInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_BankInfo.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_BankInfo.DownBack = null;
            this.skinTextBox_BankInfo.Icon = null;
            this.skinTextBox_BankInfo.IconIsButton = false;
            this.skinTextBox_BankInfo.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_BankInfo.IsPasswordChat = '\0';
            this.skinTextBox_BankInfo.IsSystemPasswordChar = false;
            this.skinTextBox_BankInfo.Lines = new string[0];
            this.skinTextBox_BankInfo.Location = new System.Drawing.Point(138, 311);
            this.skinTextBox_BankInfo.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_BankInfo.MaxLength = 32767;
            this.skinTextBox_BankInfo.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_BankInfo.MouseBack = null;
            this.skinTextBox_BankInfo.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_BankInfo.Multiline = false;
            this.skinTextBox_BankInfo.Name = "skinTextBox_BankInfo";
            this.skinTextBox_BankInfo.NormlBack = null;
            this.skinTextBox_BankInfo.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_BankInfo.ReadOnly = false;
            this.skinTextBox_BankInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_BankInfo.Size = new System.Drawing.Size(346, 28);
            // 
            // 
            // 
            this.skinTextBox_BankInfo.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_BankInfo.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_BankInfo.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_BankInfo.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_BankInfo.SkinTxt.Name = "BaseText";
            this.skinTextBox_BankInfo.SkinTxt.Size = new System.Drawing.Size(336, 18);
            this.skinTextBox_BankInfo.SkinTxt.TabIndex = 0;
            this.skinTextBox_BankInfo.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_BankInfo.SkinTxt.WaterText = "";
            this.skinTextBox_BankInfo.TabIndex = 170;
            this.skinTextBox_BankInfo.TabStop = true;
            this.skinTextBox_BankInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_BankInfo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_BankInfo.WaterText = "";
            this.skinTextBox_BankInfo.WordWrap = true;
            // 
            // skinLabel6
            // 
            this.skinLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(89, 354);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 175;
            this.skinLabel6.Text = "备注";
            // 
            // skinLabel8
            // 
            this.skinLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(65, 280);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(56, 17);
            this.skinLabel8.TabIndex = 173;
            this.skinLabel8.Text = "联系电话";
            // 
            // skinLabel9
            // 
            this.skinLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(89, 434);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(32, 17);
            this.skinLabel9.TabIndex = 180;
            this.skinLabel9.Text = "状态";
            // 
            // skinCheckBox_Enabled
            // 
            this.skinCheckBox_Enabled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBox_Enabled.AutoSize = true;
            this.skinCheckBox_Enabled.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox_Enabled.Checked = true;
            this.skinCheckBox_Enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox_Enabled.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox_Enabled.DownBack = null;
            this.skinCheckBox_Enabled.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox_Enabled.Location = new System.Drawing.Point(141, 430);
            this.skinCheckBox_Enabled.MouseBack = null;
            this.skinCheckBox_Enabled.Name = "skinCheckBox_Enabled";
            this.skinCheckBox_Enabled.NormlBack = null;
            this.skinCheckBox_Enabled.SelectedDownBack = null;
            this.skinCheckBox_Enabled.SelectedMouseBack = null;
            this.skinCheckBox_Enabled.SelectedNormlBack = null;
            this.skinCheckBox_Enabled.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBox_Enabled.TabIndex = 179;
            this.skinCheckBox_Enabled.Text = "启用";
            this.skinCheckBox_Enabled.UseVisualStyleBackColor = false;
            // 
            // skinLabel11
            // 
            this.skinLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.ForeColor = System.Drawing.Color.Red;
            this.skinLabel11.Location = new System.Drawing.Point(361, 404);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(128, 17);
            this.skinLabel11.TabIndex = 181;
            this.skinLabel11.Text = "(例如35折输入数字35)";
            this.skinLabel11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinCheckBoxShowPwd
            // 
            this.skinCheckBoxShowPwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxShowPwd.AutoSize = true;
            this.skinCheckBoxShowPwd.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxShowPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxShowPwd.DownBack = null;
            this.skinCheckBoxShowPwd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxShowPwd.Location = new System.Drawing.Point(368, 178);
            this.skinCheckBoxShowPwd.MouseBack = null;
            this.skinCheckBoxShowPwd.Name = "skinCheckBoxShowPwd";
            this.skinCheckBoxShowPwd.NormlBack = null;
            this.skinCheckBoxShowPwd.SelectedDownBack = null;
            this.skinCheckBoxShowPwd.SelectedMouseBack = null;
            this.skinCheckBoxShowPwd.SelectedNormlBack = null;
            this.skinCheckBoxShowPwd.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBoxShowPwd.TabIndex = 182;
            this.skinCheckBoxShowPwd.Text = "显示密码";
            this.skinCheckBoxShowPwd.UseVisualStyleBackColor = false;
            this.skinCheckBoxShowPwd.CheckedChanged += new System.EventHandler(this.textBoxPwd_Leave);
            // 
            // SaveOffLineCustomerForm
            // 
            this.AcceptButton = this.BaseButton_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 583);
            this.Controls.Add(this.skinCheckBoxShowPwd);
            this.Controls.Add(this.skinLabel11);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.skinCheckBox_Enabled);
            this.Controls.Add(this.skinLabel13);
            this.Controls.Add(this.skinRadioButtonBuyout);
            this.Controls.Add(this.skinRadioButtonSale);
            this.Controls.Add(this.skinTextBox_Contact);
            this.Controls.Add(this.skinTextBox_ContactPhone);
            this.Controls.Add(this.skinTextBox_Remarks);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinTextBox_BankInfo);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.textBoxBusinessAccount);
            this.Controls.Add(this.skinLabel12);
            this.Controls.Add(this.skinTextBox_Percent);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.textBoxPwd);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBoxName);
            this.Controls.Add(this.skinTextBoxID);
            this.Controls.Add(this.baseButtonCancel);
            this.Controls.Add(this.BaseButton_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveOffLineCustomerForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "新增下线客户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Search;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.TextBox skinTextBoxName;
        private Common.TextBox skinTextBoxID;
        private Common.TextBox textBoxPwd;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private Common.Components.BaseButton baseButtonCancel;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private Common.NumericTextBox skinTextBox_Percent;
        private Common.TextBox textBoxBusinessAccount;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonBuyout;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonSale;
        private Common.TextBox skinTextBox_Contact;
        private Common.TextBox skinTextBox_ContactPhone;
        private Common.TextBox skinTextBox_Remarks;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private Common.TextBox skinTextBox_BankInfo;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox_Enabled;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxShowPwd;
    }
}