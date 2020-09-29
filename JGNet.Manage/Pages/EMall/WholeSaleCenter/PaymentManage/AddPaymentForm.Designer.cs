using CCWin.SkinControl;
using JGNet.Common.Components;

namespace JGNet.Manage
{
    partial class AddPaymentForm
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
            this.BaseButtonSave = new JGNet.Common.Components.BaseButton();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.numericTextBox1 = new JGNet.Common.NumericTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.textBoxRemark = new JGNet.Common.TextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxName = new JGNet.Common.TextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.numericTextBox2 = new JGNet.Common.NumericTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.pfCustomerIDTextBox1 = new JGNet.Common.PfCustomerIDTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseButtonSave
            // 
            this.BaseButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonSave.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonSave.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonSave.Location = new System.Drawing.Point(149, 268);
            this.BaseButtonSave.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonSave.Name = "BaseButtonSave";
            this.BaseButtonSave.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonSave.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonSave.TabIndex = 171;
            this.BaseButtonSave.Text = "新增";
            this.BaseButtonSave.UseVisualStyleBackColor = false;
            this.BaseButtonSave.Click += new System.EventHandler(this.BaseButtonSaveAccount_Click);
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(230, 268);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 171;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBox1.DecimalPlaces = 0;
            this.numericTextBox1.DownBack = null;
            this.numericTextBox1.Icon = null;
            this.numericTextBox1.IconIsButton = false;
            this.numericTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBox1.IsPasswordChat = '\0';
            this.numericTextBox1.IsSystemPasswordChar = false;
            this.numericTextBox1.Lines = new string[0];
            this.numericTextBox1.Location = new System.Drawing.Point(101, 142);
            this.numericTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBox1.MaxLength = 32767;
            this.numericTextBox1.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBox1.MinNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numericTextBox1.MouseBack = null;
            this.numericTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBox1.Multiline = false;
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.NormlBack = null;
            this.numericTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBox1.ReadOnly = false;
            this.numericTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBox1.ShowZero = false;
            this.numericTextBox1.Size = new System.Drawing.Size(312, 28);
            // 
            // 
            // 
            this.numericTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTextBox1.SkinTxt.Name = "BaseText";
            this.numericTextBox1.SkinTxt.Size = new System.Drawing.Size(302, 18);
            this.numericTextBox1.SkinTxt.TabIndex = 0;
            this.numericTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBox1.SkinTxt.WaterText = "";
            this.numericTextBox1.TabIndex = 179;
            this.numericTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBox1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBox1.WaterText = "";
            this.numericTextBox1.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(53, 147);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 178;
            this.skinLabel7.Text = "金额";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(101, 225);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(129, 21);
            this.dateTimePicker_Start.TabIndex = 180;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(30, 226);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 181;
            this.skinLabel3.Text = "付款日期";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.textBoxRemark);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinTextBoxName);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.numericTextBox2);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.pfCustomerIDTextBox1);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.BaseButtonSave);
            this.skinPanel1.Controls.Add(this.baseButtonCancel);
            this.skinPanel1.Controls.Add(this.numericTextBox1);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 28);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(447, 331);
            this.skinPanel1.TabIndex = 182;
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.BackColor = System.Drawing.Color.Transparent;
            this.textBoxRemark.DownBack = null;
            this.textBoxRemark.Icon = null;
            this.textBoxRemark.IconIsButton = false;
            this.textBoxRemark.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxRemark.IsPasswordChat = '\0';
            this.textBoxRemark.IsSystemPasswordChar = false;
            this.textBoxRemark.Lines = new string[0];
            this.textBoxRemark.Location = new System.Drawing.Point(101, 185);
            this.textBoxRemark.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRemark.MaxLength = 32767;
            this.textBoxRemark.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxRemark.MouseBack = null;
            this.textBoxRemark.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxRemark.Multiline = false;
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.NormlBack = null;
            this.textBoxRemark.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxRemark.ReadOnly = false;
            this.textBoxRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxRemark.Size = new System.Drawing.Size(311, 28);
            // 
            // 
            // 
            this.textBoxRemark.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRemark.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRemark.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxRemark.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxRemark.SkinTxt.Name = "BaseText";
            this.textBoxRemark.SkinTxt.Size = new System.Drawing.Size(301, 18);
            this.textBoxRemark.SkinTxt.TabIndex = 0;
            this.textBoxRemark.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxRemark.SkinTxt.WaterText = "";
            this.textBoxRemark.TabIndex = 190;
            this.textBoxRemark.TabStop = true;
            this.textBoxRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxRemark.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxRemark.WaterText = "";
            this.textBoxRemark.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(51, 191);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 189;
            this.skinLabel5.Text = "备注";
            // 
            // skinTextBoxName
            // 
            this.skinTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxName.DownBack = null;
            this.skinTextBoxName.Enabled = false;
            this.skinTextBoxName.Icon = null;
            this.skinTextBoxName.IconIsButton = false;
            this.skinTextBoxName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.IsPasswordChat = '\0';
            this.skinTextBoxName.IsSystemPasswordChar = false;
            this.skinTextBoxName.Lines = new string[0];
            this.skinTextBoxName.Location = new System.Drawing.Point(102, 59);
            this.skinTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxName.MaxLength = 32767;
            this.skinTextBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxName.MouseBack = null;
            this.skinTextBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.Multiline = false;
            this.skinTextBoxName.Name = "skinTextBoxName";
            this.skinTextBoxName.NormlBack = null;
            this.skinTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxName.ReadOnly = false;
            this.skinTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxName.Size = new System.Drawing.Size(311, 28);
            // 
            // 
            // 
            this.skinTextBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxName.SkinTxt.Name = "BaseText";
            this.skinTextBoxName.SkinTxt.Size = new System.Drawing.Size(301, 18);
            this.skinTextBoxName.SkinTxt.TabIndex = 0;
            this.skinTextBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.SkinTxt.WaterText = "";
            this.skinTextBoxName.TabIndex = 188;
            this.skinTextBoxName.TabStop = true;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "";
            this.skinTextBoxName.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(10, 59);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(80, 17);
            this.skinLabel4.TabIndex = 187;
            this.skinLabel4.Text = "分销人员名称";
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(149, 268);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 186;
            this.baseButton1.Text = "保存";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Visible = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // numericTextBox2
            // 
            this.numericTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBox2.DecimalPlaces = 0;
            this.numericTextBox2.DownBack = null;
            this.numericTextBox2.Icon = null;
            this.numericTextBox2.IconIsButton = false;
            this.numericTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBox2.IsPasswordChat = '\0';
            this.numericTextBox2.IsSystemPasswordChar = false;
            this.numericTextBox2.Lines = new string[0];
            this.numericTextBox2.Location = new System.Drawing.Point(101, 98);
            this.numericTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBox2.MaxLength = 32767;
            this.numericTextBox2.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBox2.MinNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.numericTextBox2.MouseBack = null;
            this.numericTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBox2.Multiline = false;
            this.numericTextBox2.Name = "numericTextBox2";
            this.numericTextBox2.NormlBack = null;
            this.numericTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBox2.ReadOnly = true;
            this.numericTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBox2.ShowZero = false;
            this.numericTextBox2.Size = new System.Drawing.Size(312, 28);
            // 
            // 
            // 
            this.numericTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTextBox2.SkinTxt.Name = "BaseText";
            this.numericTextBox2.SkinTxt.ReadOnly = true;
            this.numericTextBox2.SkinTxt.Size = new System.Drawing.Size(302, 18);
            this.numericTextBox2.SkinTxt.TabIndex = 0;
            this.numericTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBox2.SkinTxt.WaterText = "";
            this.numericTextBox2.TabIndex = 185;
            this.numericTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBox2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBox2.WaterText = "";
            this.numericTextBox2.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(22, 102);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 184;
            this.skinLabel2.Text = "可提现佣金";
            // 
            // pfCustomerIDTextBox1
            // 
            this.pfCustomerIDTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.pfCustomerIDTextBox1.CheckMember = false;
            this.pfCustomerIDTextBox1.DownBack = null;
            this.pfCustomerIDTextBox1.Icon = null;
            this.pfCustomerIDTextBox1.IconIsButton = false;
            this.pfCustomerIDTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.pfCustomerIDTextBox1.IsPasswordChat = '\0';
            this.pfCustomerIDTextBox1.IsSystemPasswordChar = false;
            this.pfCustomerIDTextBox1.Lines = new string[0];
            this.pfCustomerIDTextBox1.Location = new System.Drawing.Point(101, 18);
            this.pfCustomerIDTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pfCustomerIDTextBox1.MaxLength = 32767;
            this.pfCustomerIDTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.pfCustomerIDTextBox1.MouseBack = null;
            this.pfCustomerIDTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.pfCustomerIDTextBox1.Multiline = false;
            this.pfCustomerIDTextBox1.Name = "pfCustomerIDTextBox1";
            this.pfCustomerIDTextBox1.NormlBack = null;
            this.pfCustomerIDTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pfCustomerIDTextBox1.ReadOnly = false;
            this.pfCustomerIDTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pfCustomerIDTextBox1.Size = new System.Drawing.Size(312, 28);
            // 
            // 
            // 
            this.pfCustomerIDTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pfCustomerIDTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pfCustomerIDTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.pfCustomerIDTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.pfCustomerIDTextBox1.SkinTxt.Name = "BaseText";
            this.pfCustomerIDTextBox1.SkinTxt.Size = new System.Drawing.Size(302, 18);
            this.pfCustomerIDTextBox1.SkinTxt.TabIndex = 0;
            this.pfCustomerIDTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pfCustomerIDTextBox1.SkinTxt.WaterText = "输入编号/名称并回车";
            this.pfCustomerIDTextBox1.TabIndex = 183;
            this.pfCustomerIDTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pfCustomerIDTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pfCustomerIDTextBox1.WaterText = "输入编号/名称并回车";
            this.pfCustomerIDTextBox1.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(34, 25);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 182;
            this.skinLabel1.Text = "分销人员";
            // 
            // AddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 363);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPaymentForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "添加付款记录";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.SupplierAccountSearchForm_Shown);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Common.Components.BaseButton BaseButtonSave;
        private Common.Components.BaseButton baseButtonCancel;
        private Common.NumericTextBox numericTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private SkinPanel skinPanel1;
        private SkinLabel skinLabel1;
        private Common.PfCustomerIDTextBox pfCustomerIDTextBox1;
        private Common.NumericTextBox numericTextBox2;
        private SkinLabel skinLabel2;
        private BaseButton baseButton1;
        private SkinLabel skinLabel4;
        private Common.TextBox skinTextBoxName;
        private Common.TextBox textBoxRemark;
        private SkinLabel skinLabel5;
    }
}