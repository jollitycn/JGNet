using CCWin.SkinControl;
using JGNet.Common.Components;

namespace JGNet.Manage.Components
{
    partial class SupplierAccountSearchForm
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
            this.skinTextBoxRemark = new JGNet.Common.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxSaveSupplier = new JGNet.Common.Components.SupllierComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxSaveType = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
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
            this.BaseButtonSave.Location = new System.Drawing.Point(270, 233);
            this.BaseButtonSave.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonSave.Name = "BaseButtonSave";
            this.BaseButtonSave.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonSave.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonSave.TabIndex = 171;
            this.BaseButtonSave.Text = "保存";
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
            this.baseButtonCancel.Location = new System.Drawing.Point(351, 233);
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
            this.numericTextBox1.Location = new System.Drawing.Point(78, 138);
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
            this.numericTextBox1.Size = new System.Drawing.Size(348, 28);
            // 
            // 
            // 
            this.numericTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTextBox1.SkinTxt.Name = "BaseText";
            this.numericTextBox1.SkinTxt.Size = new System.Drawing.Size(338, 18);
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
            // skinTextBoxRemark
            // 
            this.skinTextBoxRemark.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxRemark.DownBack = null;
            this.skinTextBoxRemark.Icon = null;
            this.skinTextBoxRemark.IconIsButton = false;
            this.skinTextBoxRemark.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxRemark.IsPasswordChat = '\0';
            this.skinTextBoxRemark.IsSystemPasswordChar = false;
            this.skinTextBoxRemark.Lines = new string[0];
            this.skinTextBoxRemark.Location = new System.Drawing.Point(78, 195);
            this.skinTextBoxRemark.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxRemark.MaxLength = 32767;
            this.skinTextBoxRemark.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxRemark.MouseBack = null;
            this.skinTextBoxRemark.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxRemark.Multiline = false;
            this.skinTextBoxRemark.Name = "skinTextBoxRemark";
            this.skinTextBoxRemark.NormlBack = null;
            this.skinTextBoxRemark.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxRemark.ReadOnly = false;
            this.skinTextBoxRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxRemark.Size = new System.Drawing.Size(348, 28);
            // 
            // 
            // 
            this.skinTextBoxRemark.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxRemark.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxRemark.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxRemark.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxRemark.SkinTxt.Name = "BaseText";
            this.skinTextBoxRemark.SkinTxt.Size = new System.Drawing.Size(338, 18);
            this.skinTextBoxRemark.SkinTxt.TabIndex = 0;
            this.skinTextBoxRemark.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxRemark.SkinTxt.WaterText = "";
            this.skinTextBoxRemark.TabIndex = 174;
            this.skinTextBoxRemark.TabStop = true;
            this.skinTextBoxRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxRemark.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxRemark.WaterText = "";
            this.skinTextBoxRemark.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(28, 108);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 176;
            this.skinLabel1.Text = "供应商";
            // 
            // skinComboBoxSaveSupplier
            // 
            this.skinComboBoxSaveSupplier.AutoSize = true;
            this.skinComboBoxSaveSupplier.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxSaveSupplier.EnabledSupplier = false;
            this.skinComboBoxSaveSupplier.HideAll = true;
            this.skinComboBoxSaveSupplier.Location = new System.Drawing.Point(78, 105);
            this.skinComboBoxSaveSupplier.Name = "skinComboBoxSaveSupplier";
            this.skinComboBoxSaveSupplier.SelectedItem = null;
            this.skinComboBoxSaveSupplier.SelectedValue = null;
            this.skinComboBoxSaveSupplier.ShowAdd = false;
            this.skinComboBoxSaveSupplier.Size = new System.Drawing.Size(379, 26);
            this.skinComboBoxSaveSupplier.TabIndex = 172;
            this.skinComboBoxSaveSupplier.Title = null;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(40, 201);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 177;
            this.skinLabel2.Text = "备注";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(40, 144);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 178;
            this.skinLabel7.Text = "金额";
            // 
            // skinComboBoxSaveType
            // 
            this.skinComboBoxSaveType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxSaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxSaveType.FormattingEnabled = true;
            this.skinComboBoxSaveType.Location = new System.Drawing.Point(78, 39);
            this.skinComboBoxSaveType.Name = "skinComboBoxSaveType";
            this.skinComboBoxSaveType.Size = new System.Drawing.Size(348, 22);
            this.skinComboBoxSaveType.TabIndex = 173;
            this.skinComboBoxSaveType.WaterText = "";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(16, 42);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(56, 17);
            this.skinLabel6.TabIndex = 175;
            this.skinLabel6.Text = "付款类型";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(78, 7);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(348, 21);
            this.dateTimePicker_Start.TabIndex = 180;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(16, 9);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 181;
            this.skinLabel3.Text = "付款日期";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinComboBox1);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.BaseButtonSave);
            this.skinPanel1.Controls.Add(this.baseButtonCancel);
            this.skinPanel1.Controls.Add(this.numericTextBox1);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.skinTextBoxRemark);
            this.skinPanel1.Controls.Add(this.skinComboBoxSaveType);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.skinComboBoxSaveSupplier);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 28);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(455, 294);
            this.skinPanel1.TabIndex = 182;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Red;
            this.skinLabel4.Location = new System.Drawing.Point(80, 171);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(181, 17);
            this.skinLabel4.TabIndex = 182;
            this.skinLabel4.Text = "*注：金额为正代表向供应商付款";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(16, 75);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 184;
            this.skinLabel5.Text = "付款方式";
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.Location = new System.Drawing.Point(78, 72);
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(348, 22);
            this.skinComboBox1.TabIndex = 183;
            this.skinComboBox1.WaterText = "";
            // 
            // SupplierAccountSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 326);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierAccountSearchForm";
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
        private Common.TextBox skinTextBoxRemark;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private SupllierComboBox skinComboBoxSaveSupplier;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinComboBox skinComboBoxSaveType;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private SkinPanel skinPanel1;
        private SkinLabel skinLabel4;
        private SkinLabel skinLabel5;
        private SkinComboBox skinComboBox1;
    }
}