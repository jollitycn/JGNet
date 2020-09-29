using JGNet.Manage;

namespace JGNet.Common.Components
{
    partial class PrintBarcodeForm
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.textBoxAmount = new JGNet.Common.NumericTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelCostumeID = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Color = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBox_Size = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // BaseButtonConfirm
            // 
            this.BaseButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonConfirm.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonConfirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonConfirm.Location = new System.Drawing.Point(16, 152);
            this.BaseButtonConfirm.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonConfirm.Name = "BaseButtonConfirm";
            this.BaseButtonConfirm.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonConfirm.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonConfirm.TabIndex = 4;
            this.BaseButtonConfirm.Text = "打印";
            this.BaseButtonConfirm.UseVisualStyleBackColor = false;
            this.BaseButtonConfirm.Click += new System.EventHandler(this.BaseButtonConfirm_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(34, 124);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 166;
            this.skinLabel1.Text = "张数";
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(97, 152);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 5;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
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
            this.textBoxAmount.Lines = new string[] {
        "1"};
            this.textBoxAmount.Location = new System.Drawing.Point(72, 118);
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
            this.textBoxAmount.Size = new System.Drawing.Size(100, 28);
            // 
            // 
            // 
            this.textBoxAmount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAmount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAmount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxAmount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxAmount.SkinTxt.MaxLength = 9;
            this.textBoxAmount.SkinTxt.Name = "BaseText";
            this.textBoxAmount.SkinTxt.Size = new System.Drawing.Size(90, 18);
            this.textBoxAmount.SkinTxt.TabIndex = 0;
            this.textBoxAmount.SkinTxt.Text = "1";
            this.textBoxAmount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxAmount.SkinTxt.WaterText = "";
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.TabStop = true;
            this.textBoxAmount.Text = "1";
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textBoxAmount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxAmount.WaterText = "";
            this.textBoxAmount.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(34, 34);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 172;
            this.skinLabel5.Text = "款号";
            // 
            // skinLabelCostumeID
            // 
            this.skinLabelCostumeID.AutoSize = true;
            this.skinLabelCostumeID.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelCostumeID.BorderColor = System.Drawing.Color.White;
            this.skinLabelCostumeID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelCostumeID.Location = new System.Drawing.Point(72, 34);
            this.skinLabelCostumeID.Name = "skinLabelCostumeID";
            this.skinLabelCostumeID.Size = new System.Drawing.Size(32, 17);
            this.skinLabelCostumeID.TabIndex = 172;
            this.skinLabelCostumeID.Text = "款号";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(34, 62);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 174;
            this.skinLabel3.Text = "颜色";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(34, 92);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 175;
            this.skinLabel4.Text = "尺码";
            // 
            // skinComboBox_Color
            // 
            this.skinComboBox_Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Color.FormattingEnabled = true;
            this.skinComboBox_Color.Location = new System.Drawing.Point(72, 59);
            this.skinComboBox_Color.Name = "skinComboBox_Color";
            this.skinComboBox_Color.Size = new System.Drawing.Size(100, 22);
            this.skinComboBox_Color.TabIndex = 176;
            this.skinComboBox_Color.WaterText = "";
            // 
            // skinComboBox_Size
            // 
            this.skinComboBox_Size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Size.FormattingEnabled = true;
            this.skinComboBox_Size.Location = new System.Drawing.Point(72, 89);
            this.skinComboBox_Size.Name = "skinComboBox_Size";
            this.skinComboBox_Size.Size = new System.Drawing.Size(100, 22);
            this.skinComboBox_Size.TabIndex = 177;
            this.skinComboBox_Size.WaterText = "";
            // 
            // PrintBarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 191);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinComboBox_Color);
            this.Controls.Add(this.skinComboBox_Size);
            this.Controls.Add(this.skinLabelCostumeID);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.baseButtonCancel);
            this.Controls.Add(this.BaseButtonConfirm);
            this.Controls.Add(this.skinLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintBarcodeForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "打印条码";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButtonConfirm;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.Components.BaseButton baseButtonCancel;
        private NumericTextBox textBoxAmount;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabelCostumeID;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinComboBox skinComboBox_Color;
        private CCWin.SkinControl.SkinComboBox skinComboBox_Size;
    }
}