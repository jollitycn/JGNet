using CCWin.SkinControl;
using JGNet.Common;

namespace JGNet.Manage
{
    partial class ConfirmRefundForm
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
            this.BaseButton_Cancel = new JGNet.Common.Components.BaseButton();
            this.BaseButton_OK = new JGNet.Common.Components.BaseButton();
            this.skinLabel_RefundCash = new JGNet.Common.NumericTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBoxPrint = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel_RefundIntegration = new JGNet.Common.NumericTextBox();
            this.skinLabel_RefundStoredCard = new JGNet.Common.NumericTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.panel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel_TotalMoney = new JGNet.Common.NumericTextBox();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.numericTextBoxWeixin = new JGNet.Common.NumericTextBox();
            this.numericTextBoxAlipay = new JGNet.Common.NumericTextBox();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.numericTextBoxBankCard = new JGNet.Common.NumericTextBox();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.numericTextBoxElse = new JGNet.Common.NumericTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseButton_Cancel
            // 
            this.BaseButton_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Cancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Cancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Cancel.Location = new System.Drawing.Point(260, 380);
            this.BaseButton_Cancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Cancel.Name = "BaseButton_Cancel";
            this.BaseButton_Cancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Cancel.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Cancel.TabIndex = 1;
            this.BaseButton_Cancel.Text = "取消";
            this.BaseButton_Cancel.UseVisualStyleBackColor = false;
            this.BaseButton_Cancel.Click += new System.EventHandler(this.BaseButton_Cancel_Click);
            // 
            // BaseButton_OK
            // 
            this.BaseButton_OK.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_OK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_OK.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_OK.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_OK.Location = new System.Drawing.Point(179, 380);
            this.BaseButton_OK.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_OK.Name = "BaseButton_OK";
            this.BaseButton_OK.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_OK.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_OK.TabIndex = 0;
            this.BaseButton_OK.Text = "确定";
            this.BaseButton_OK.UseVisualStyleBackColor = false;
            this.BaseButton_OK.Click += new System.EventHandler(this.BaseButton_OK_Click);
            // 
            // skinLabel_RefundCash
            // 
            this.skinLabel_RefundCash.AutoSize = true;
            this.skinLabel_RefundCash.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_RefundCash.DecimalPlaces = 0;
            this.skinLabel_RefundCash.DownBack = null;
            this.skinLabel_RefundCash.Icon = null;
            this.skinLabel_RefundCash.IconIsButton = false;
            this.skinLabel_RefundCash.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinLabel_RefundCash.IsPasswordChat = '\0';
            this.skinLabel_RefundCash.IsSystemPasswordChar = false;
            this.skinLabel_RefundCash.Lines = new string[0];
            this.skinLabel_RefundCash.Location = new System.Drawing.Point(208, 147);
            this.skinLabel_RefundCash.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel_RefundCash.MaxLength = 32767;
            this.skinLabel_RefundCash.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.skinLabel_RefundCash.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinLabel_RefundCash.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinLabel_RefundCash.MouseBack = null;
            this.skinLabel_RefundCash.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinLabel_RefundCash.Multiline = true;
            this.skinLabel_RefundCash.Name = "skinLabel_RefundCash";
            this.skinLabel_RefundCash.NormlBack = null;
            this.skinLabel_RefundCash.Padding = new System.Windows.Forms.Padding(5);
            this.skinLabel_RefundCash.ReadOnly = false;
            this.skinLabel_RefundCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinLabel_RefundCash.ShowZero = false;
            this.skinLabel_RefundCash.Size = new System.Drawing.Size(108, 31);
            // 
            // 
            // 
            this.skinLabel_RefundCash.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_RefundCash.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.skinLabel_RefundCash.SkinTxt.Multiline = true;
            this.skinLabel_RefundCash.SkinTxt.Name = "BaseText";
            this.skinLabel_RefundCash.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.skinLabel_RefundCash.SkinTxt.TabIndex = 0;
            this.skinLabel_RefundCash.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinLabel_RefundCash.SkinTxt.WaterText = "";
            this.skinLabel_RefundCash.TabIndex = 0;
            this.skinLabel_RefundCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinLabel_RefundCash.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinLabel_RefundCash.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinLabel_RefundCash.WaterText = "";
            this.skinLabel_RefundCash.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(208, 41);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(42, 22);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "金额";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(65, 346);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "总计";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(64, 154);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 0;
            this.skinLabel7.Text = "现金";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(64, 41);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(74, 22);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "退款方式";
            // 
            // skinCheckBoxPrint
            // 
            this.skinCheckBoxPrint.AutoSize = true;
            this.skinCheckBoxPrint.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxPrint.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxPrint.DownBack = null;
            this.skinCheckBoxPrint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxPrint.Location = new System.Drawing.Point(98, 387);
            this.skinCheckBoxPrint.MouseBack = null;
            this.skinCheckBoxPrint.Name = "skinCheckBoxPrint";
            this.skinCheckBoxPrint.NormlBack = null;
            this.skinCheckBoxPrint.SelectedDownBack = null;
            this.skinCheckBoxPrint.SelectedMouseBack = null;
            this.skinCheckBoxPrint.SelectedNormlBack = null;
            this.skinCheckBoxPrint.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBoxPrint.TabIndex = 22;
            this.skinCheckBoxPrint.Text = "打印小票";
            this.skinCheckBoxPrint.UseVisualStyleBackColor = false;
            this.skinCheckBoxPrint.CheckedChanged += new System.EventHandler(this.skinCheckBoxPrint_CheckedChanged);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.Blue;
            this.skinLabel6.Location = new System.Drawing.Point(16, 29);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(75, 17);
            this.skinLabel6.TabIndex = 0;
            this.skinLabel6.Text = "VIP卡余额：";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.Blue;
            this.skinLabel8.Location = new System.Drawing.Point(16, 5);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(104, 17);
            this.skinLabel8.TabIndex = 0;
            this.skinLabel8.Text = "积分可兑换金额：";
            // 
            // skinLabel_RefundIntegration
            // 
            this.skinLabel_RefundIntegration.AutoSize = true;
            this.skinLabel_RefundIntegration.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_RefundIntegration.DecimalPlaces = 0;
            this.skinLabel_RefundIntegration.DownBack = null;
            this.skinLabel_RefundIntegration.Icon = null;
            this.skinLabel_RefundIntegration.IconIsButton = false;
            this.skinLabel_RefundIntegration.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinLabel_RefundIntegration.IsPasswordChat = '\0';
            this.skinLabel_RefundIntegration.IsSystemPasswordChar = false;
            this.skinLabel_RefundIntegration.Lines = new string[0];
            this.skinLabel_RefundIntegration.Location = new System.Drawing.Point(198, 5);
            this.skinLabel_RefundIntegration.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel_RefundIntegration.MaxLength = 32767;
            this.skinLabel_RefundIntegration.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.skinLabel_RefundIntegration.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinLabel_RefundIntegration.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinLabel_RefundIntegration.MouseBack = null;
            this.skinLabel_RefundIntegration.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinLabel_RefundIntegration.Multiline = true;
            this.skinLabel_RefundIntegration.Name = "skinLabel_RefundIntegration";
            this.skinLabel_RefundIntegration.NormlBack = null;
            this.skinLabel_RefundIntegration.Padding = new System.Windows.Forms.Padding(5);
            this.skinLabel_RefundIntegration.ReadOnly = false;
            this.skinLabel_RefundIntegration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinLabel_RefundIntegration.ShowZero = false;
            this.skinLabel_RefundIntegration.Size = new System.Drawing.Size(108, 31);
            // 
            // 
            // 
            this.skinLabel_RefundIntegration.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_RefundIntegration.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.skinLabel_RefundIntegration.SkinTxt.Multiline = true;
            this.skinLabel_RefundIntegration.SkinTxt.Name = "BaseText";
            this.skinLabel_RefundIntegration.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.skinLabel_RefundIntegration.SkinTxt.TabIndex = 0;
            this.skinLabel_RefundIntegration.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinLabel_RefundIntegration.SkinTxt.WaterText = "";
            this.skinLabel_RefundIntegration.TabIndex = 0;
            this.skinLabel_RefundIntegration.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinLabel_RefundIntegration.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinLabel_RefundIntegration.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinLabel_RefundIntegration.WaterText = "";
            this.skinLabel_RefundIntegration.WordWrap = true;
            // 
            // skinLabel_RefundStoredCard
            // 
            this.skinLabel_RefundStoredCard.AutoSize = true;
            this.skinLabel_RefundStoredCard.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_RefundStoredCard.DecimalPlaces = 0;
            this.skinLabel_RefundStoredCard.DownBack = null;
            this.skinLabel_RefundStoredCard.Icon = null;
            this.skinLabel_RefundStoredCard.IconIsButton = false;
            this.skinLabel_RefundStoredCard.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinLabel_RefundStoredCard.IsPasswordChat = '\0';
            this.skinLabel_RefundStoredCard.IsSystemPasswordChar = false;
            this.skinLabel_RefundStoredCard.Lines = new string[0];
            this.skinLabel_RefundStoredCard.Location = new System.Drawing.Point(198, 42);
            this.skinLabel_RefundStoredCard.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel_RefundStoredCard.MaxLength = 32767;
            this.skinLabel_RefundStoredCard.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.skinLabel_RefundStoredCard.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinLabel_RefundStoredCard.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinLabel_RefundStoredCard.MouseBack = null;
            this.skinLabel_RefundStoredCard.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinLabel_RefundStoredCard.Multiline = true;
            this.skinLabel_RefundStoredCard.Name = "skinLabel_RefundStoredCard";
            this.skinLabel_RefundStoredCard.NormlBack = null;
            this.skinLabel_RefundStoredCard.Padding = new System.Windows.Forms.Padding(5);
            this.skinLabel_RefundStoredCard.ReadOnly = false;
            this.skinLabel_RefundStoredCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinLabel_RefundStoredCard.ShowZero = false;
            this.skinLabel_RefundStoredCard.Size = new System.Drawing.Size(108, 31);
            // 
            // 
            // 
            this.skinLabel_RefundStoredCard.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_RefundStoredCard.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.skinLabel_RefundStoredCard.SkinTxt.Multiline = true;
            this.skinLabel_RefundStoredCard.SkinTxt.Name = "BaseText";
            this.skinLabel_RefundStoredCard.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.skinLabel_RefundStoredCard.SkinTxt.TabIndex = 0;
            this.skinLabel_RefundStoredCard.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinLabel_RefundStoredCard.SkinTxt.WaterText = "";
            this.skinLabel_RefundStoredCard.TabIndex = 0;
            this.skinLabel_RefundStoredCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinLabel_RefundStoredCard.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinLabel_RefundStoredCard.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinLabel_RefundStoredCard.WaterText = "";
            this.skinLabel_RefundStoredCard.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(54, 49);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(68, 17);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "会员卡余额";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(54, 12);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "积分";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.skinLabel5);
            this.panel1.Controls.Add(this.skinLabel_RefundIntegration);
            this.panel1.Controls.Add(this.skinLabel_RefundStoredCard);
            this.panel1.Controls.Add(this.skinLabel3);
            this.panel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel1.DownBack = null;
            this.panel1.Location = new System.Drawing.Point(10, 66);
            this.panel1.MouseBack = null;
            this.panel1.Name = "panel1";
            this.panel1.NormlBack = null;
            this.panel1.Size = new System.Drawing.Size(325, 78);
            this.panel1.TabIndex = 24;
            // 
            // skinLabel_TotalMoney
            // 
            this.skinLabel_TotalMoney.AutoSize = true;
            this.skinLabel_TotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_TotalMoney.DecimalPlaces = 0;
            this.skinLabel_TotalMoney.DownBack = null;
            this.skinLabel_TotalMoney.Icon = null;
            this.skinLabel_TotalMoney.IconIsButton = false;
            this.skinLabel_TotalMoney.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinLabel_TotalMoney.IsPasswordChat = '\0';
            this.skinLabel_TotalMoney.IsSystemPasswordChar = false;
            this.skinLabel_TotalMoney.Lines = new string[0];
            this.skinLabel_TotalMoney.Location = new System.Drawing.Point(209, 339);
            this.skinLabel_TotalMoney.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabel_TotalMoney.MaxLength = 32767;
            this.skinLabel_TotalMoney.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.skinLabel_TotalMoney.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinLabel_TotalMoney.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinLabel_TotalMoney.MouseBack = null;
            this.skinLabel_TotalMoney.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinLabel_TotalMoney.Multiline = true;
            this.skinLabel_TotalMoney.Name = "skinLabel_TotalMoney";
            this.skinLabel_TotalMoney.NormlBack = null;
            this.skinLabel_TotalMoney.Padding = new System.Windows.Forms.Padding(5);
            this.skinLabel_TotalMoney.ReadOnly = false;
            this.skinLabel_TotalMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinLabel_TotalMoney.ShowZero = false;
            this.skinLabel_TotalMoney.Size = new System.Drawing.Size(108, 31);
            // 
            // 
            // 
            this.skinLabel_TotalMoney.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_TotalMoney.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.skinLabel_TotalMoney.SkinTxt.Multiline = true;
            this.skinLabel_TotalMoney.SkinTxt.Name = "BaseText";
            this.skinLabel_TotalMoney.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.skinLabel_TotalMoney.SkinTxt.TabIndex = 0;
            this.skinLabel_TotalMoney.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinLabel_TotalMoney.SkinTxt.WaterText = "";
            this.skinLabel_TotalMoney.TabIndex = 25;
            this.skinLabel_TotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinLabel_TotalMoney.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinLabel_TotalMoney.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinLabel_TotalMoney.WaterText = "";
            this.skinLabel_TotalMoney.WordWrap = true;
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(65, 272);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(44, 17);
            this.skinLabel9.TabIndex = 0;
            this.skinLabel9.Text = "支付宝";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(65, 233);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(32, 17);
            this.skinLabel10.TabIndex = 0;
            this.skinLabel10.Text = "微信";
            // 
            // numericTextBoxWeixin
            // 
            this.numericTextBoxWeixin.AutoSize = true;
            this.numericTextBoxWeixin.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBoxWeixin.DecimalPlaces = 0;
            this.numericTextBoxWeixin.DownBack = null;
            this.numericTextBoxWeixin.Icon = null;
            this.numericTextBoxWeixin.IconIsButton = false;
            this.numericTextBoxWeixin.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxWeixin.IsPasswordChat = '\0';
            this.numericTextBoxWeixin.IsSystemPasswordChar = false;
            this.numericTextBoxWeixin.Lines = new string[0];
            this.numericTextBoxWeixin.Location = new System.Drawing.Point(209, 226);
            this.numericTextBoxWeixin.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBoxWeixin.MaxLength = 32767;
            this.numericTextBoxWeixin.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBoxWeixin.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBoxWeixin.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxWeixin.MouseBack = null;
            this.numericTextBoxWeixin.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxWeixin.Multiline = true;
            this.numericTextBoxWeixin.Name = "numericTextBoxWeixin";
            this.numericTextBoxWeixin.NormlBack = null;
            this.numericTextBoxWeixin.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBoxWeixin.ReadOnly = false;
            this.numericTextBoxWeixin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBoxWeixin.ShowZero = false;
            this.numericTextBoxWeixin.Size = new System.Drawing.Size(108, 31);
            // 
            // 
            // 
            this.numericTextBoxWeixin.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericTextBoxWeixin.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericTextBoxWeixin.SkinTxt.Multiline = true;
            this.numericTextBoxWeixin.SkinTxt.Name = "BaseText";
            this.numericTextBoxWeixin.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.numericTextBoxWeixin.SkinTxt.TabIndex = 0;
            this.numericTextBoxWeixin.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxWeixin.SkinTxt.WaterText = "";
            this.numericTextBoxWeixin.TabIndex = 0;
            this.numericTextBoxWeixin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBoxWeixin.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxWeixin.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxWeixin.WaterText = "";
            this.numericTextBoxWeixin.WordWrap = true;
            // 
            // numericTextBoxAlipay
            // 
            this.numericTextBoxAlipay.AutoSize = true;
            this.numericTextBoxAlipay.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBoxAlipay.DecimalPlaces = 0;
            this.numericTextBoxAlipay.DownBack = null;
            this.numericTextBoxAlipay.Icon = null;
            this.numericTextBoxAlipay.IconIsButton = false;
            this.numericTextBoxAlipay.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxAlipay.IsPasswordChat = '\0';
            this.numericTextBoxAlipay.IsSystemPasswordChar = false;
            this.numericTextBoxAlipay.Lines = new string[0];
            this.numericTextBoxAlipay.Location = new System.Drawing.Point(209, 265);
            this.numericTextBoxAlipay.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBoxAlipay.MaxLength = 32767;
            this.numericTextBoxAlipay.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBoxAlipay.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBoxAlipay.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxAlipay.MouseBack = null;
            this.numericTextBoxAlipay.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxAlipay.Multiline = true;
            this.numericTextBoxAlipay.Name = "numericTextBoxAlipay";
            this.numericTextBoxAlipay.NormlBack = null;
            this.numericTextBoxAlipay.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBoxAlipay.ReadOnly = false;
            this.numericTextBoxAlipay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBoxAlipay.ShowZero = false;
            this.numericTextBoxAlipay.Size = new System.Drawing.Size(108, 31);
            // 
            // 
            // 
            this.numericTextBoxAlipay.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericTextBoxAlipay.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericTextBoxAlipay.SkinTxt.Multiline = true;
            this.numericTextBoxAlipay.SkinTxt.Name = "BaseText";
            this.numericTextBoxAlipay.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.numericTextBoxAlipay.SkinTxt.TabIndex = 0;
            this.numericTextBoxAlipay.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxAlipay.SkinTxt.WaterText = "";
            this.numericTextBoxAlipay.TabIndex = 25;
            this.numericTextBoxAlipay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBoxAlipay.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxAlipay.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxAlipay.WaterText = "";
            this.numericTextBoxAlipay.WordWrap = true;
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(65, 194);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(44, 17);
            this.skinLabel11.TabIndex = 0;
            this.skinLabel11.Text = "银联卡";
            // 
            // numericTextBoxBankCard
            // 
            this.numericTextBoxBankCard.AutoSize = true;
            this.numericTextBoxBankCard.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBoxBankCard.DecimalPlaces = 0;
            this.numericTextBoxBankCard.DownBack = null;
            this.numericTextBoxBankCard.Icon = null;
            this.numericTextBoxBankCard.IconIsButton = false;
            this.numericTextBoxBankCard.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxBankCard.IsPasswordChat = '\0';
            this.numericTextBoxBankCard.IsSystemPasswordChar = false;
            this.numericTextBoxBankCard.Lines = new string[0];
            this.numericTextBoxBankCard.Location = new System.Drawing.Point(209, 187);
            this.numericTextBoxBankCard.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBoxBankCard.MaxLength = 32767;
            this.numericTextBoxBankCard.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBoxBankCard.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBoxBankCard.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxBankCard.MouseBack = null;
            this.numericTextBoxBankCard.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxBankCard.Multiline = true;
            this.numericTextBoxBankCard.Name = "numericTextBoxBankCard";
            this.numericTextBoxBankCard.NormlBack = null;
            this.numericTextBoxBankCard.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBoxBankCard.ReadOnly = false;
            this.numericTextBoxBankCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBoxBankCard.ShowZero = false;
            this.numericTextBoxBankCard.Size = new System.Drawing.Size(108, 31);
            // 
            // 
            // 
            this.numericTextBoxBankCard.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericTextBoxBankCard.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericTextBoxBankCard.SkinTxt.Multiline = true;
            this.numericTextBoxBankCard.SkinTxt.Name = "BaseText";
            this.numericTextBoxBankCard.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.numericTextBoxBankCard.SkinTxt.TabIndex = 0;
            this.numericTextBoxBankCard.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxBankCard.SkinTxt.WaterText = "";
            this.numericTextBoxBankCard.TabIndex = 0;
            this.numericTextBoxBankCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBoxBankCard.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxBankCard.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxBankCard.WaterText = "";
            this.numericTextBoxBankCard.WordWrap = true;
            // 
            // skinLabel12
            // 
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(65, 309);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(32, 17);
            this.skinLabel12.TabIndex = 0;
            this.skinLabel12.Text = "其他";
            // 
            // numericTextBoxElse
            // 
            this.numericTextBoxElse.AutoSize = true;
            this.numericTextBoxElse.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBoxElse.DecimalPlaces = 0;
            this.numericTextBoxElse.DownBack = null;
            this.numericTextBoxElse.Icon = null;
            this.numericTextBoxElse.IconIsButton = false;
            this.numericTextBoxElse.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxElse.IsPasswordChat = '\0';
            this.numericTextBoxElse.IsSystemPasswordChar = false;
            this.numericTextBoxElse.Lines = new string[0];
            this.numericTextBoxElse.Location = new System.Drawing.Point(209, 302);
            this.numericTextBoxElse.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBoxElse.MaxLength = 32767;
            this.numericTextBoxElse.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBoxElse.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBoxElse.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxElse.MouseBack = null;
            this.numericTextBoxElse.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxElse.Multiline = true;
            this.numericTextBoxElse.Name = "numericTextBoxElse";
            this.numericTextBoxElse.NormlBack = null;
            this.numericTextBoxElse.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBoxElse.ReadOnly = false;
            this.numericTextBoxElse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBoxElse.ShowZero = false;
            this.numericTextBoxElse.Size = new System.Drawing.Size(108, 31);
            // 
            // 
            // 
            this.numericTextBoxElse.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericTextBoxElse.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericTextBoxElse.SkinTxt.Multiline = true;
            this.numericTextBoxElse.SkinTxt.Name = "BaseText";
            this.numericTextBoxElse.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.numericTextBoxElse.SkinTxt.TabIndex = 0;
            this.numericTextBoxElse.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxElse.SkinTxt.WaterText = "";
            this.numericTextBoxElse.TabIndex = 25;
            this.numericTextBoxElse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBoxElse.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxElse.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxElse.WaterText = "";
            this.numericTextBoxElse.WordWrap = true;
            // 
            // ConfirmRefundForm
            // 
            this.AcceptButton = this.BaseButton_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 419);
            this.Controls.Add(this.numericTextBoxElse);
            this.Controls.Add(this.numericTextBoxAlipay);
            this.Controls.Add(this.skinLabel_TotalMoney);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinCheckBoxPrint);
            this.Controls.Add(this.BaseButton_Cancel);
            this.Controls.Add(this.BaseButton_OK);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.numericTextBoxBankCard);
            this.Controls.Add(this.numericTextBoxWeixin);
            this.Controls.Add(this.skinLabel_RefundCash);
            this.Controls.Add(this.skinLabel11);
            this.Controls.Add(this.skinLabel10);
            this.Controls.Add(this.skinLabel12);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel2);
            this.Name = "ConfirmRefundForm";
            this.Text = "退款";
            this.Load += new System.EventHandler(this.ConfirmRefundForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Cancel;
        private Common.Components.BaseButton BaseButton_OK;
        private NumericTextBox skinLabel_RefundCash;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxPrint;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private NumericTextBox skinLabel_RefundIntegration;
        private NumericTextBox skinLabel_RefundStoredCard;
        private SkinPanel panel1;
        private NumericTextBox skinLabel_TotalMoney;
        private SkinLabel skinLabel9;
        private SkinLabel skinLabel10;
        private NumericTextBox numericTextBoxWeixin;
        private NumericTextBox numericTextBoxAlipay;
        private SkinLabel skinLabel11;
        private NumericTextBox numericTextBoxBankCard;
        private SkinLabel skinLabel12;
        private NumericTextBox numericTextBoxElse;
    }
}