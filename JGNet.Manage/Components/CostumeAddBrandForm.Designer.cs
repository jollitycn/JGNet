namespace JGNet.Common.Components
{
    partial class CostumeAddBrandForm
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
            this.skinTextBoxID = new JGNet.Common.TextBox();
            this.textBoxSort = new JGNet.Common.NumericTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBoxEnable = new CCWin.SkinControl.SkinCheckBox();
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
            this.BaseButton_Search.Location = new System.Drawing.Point(113, 144);
            this.BaseButton_Search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Search.Name = "BaseButton_Search";
            this.BaseButton_Search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Search.TabIndex = 3;
            this.BaseButton_Search.Text = "保存";
            this.BaseButton_Search.UseVisualStyleBackColor = false;
            this.BaseButton_Search.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(14, 78);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 83;
            this.skinLabel2.Text = "显示排序";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(41, 40);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 84;
            this.skinLabel1.Text = "名称";
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
            this.skinTextBoxID.Location = new System.Drawing.Point(80, 30);
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
            this.skinTextBoxID.Size = new System.Drawing.Size(206, 34);
            // 
            // 
            // 
            this.skinTextBoxID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxID.SkinTxt.Multiline = true;
            this.skinTextBoxID.SkinTxt.Name = "BaseText";
            this.skinTextBoxID.SkinTxt.Size = new System.Drawing.Size(196, 24);
            this.skinTextBoxID.SkinTxt.TabIndex = 0;
            this.skinTextBoxID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.SkinTxt.WaterText = "";
            this.skinTextBoxID.TabIndex = 0;
            this.skinTextBoxID.TabStop = true;
            this.skinTextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.WaterText = "";
            this.skinTextBoxID.WordWrap = true;
            // 
            // textBoxSort
            // 
            this.textBoxSort.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSort.DecimalPlaces = 0;
            this.textBoxSort.DownBack = null;
            this.textBoxSort.Icon = null;
            this.textBoxSort.IconIsButton = false;
            this.textBoxSort.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxSort.IsPasswordChat = '\0';
            this.textBoxSort.IsSystemPasswordChar = false;
            this.textBoxSort.Lines = new string[] {
        "100"};
            this.textBoxSort.Location = new System.Drawing.Point(80, 69);
            this.textBoxSort.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSort.MaxLength = 32767;
            this.textBoxSort.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.textBoxSort.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxSort.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxSort.MouseBack = null;
            this.textBoxSort.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxSort.Multiline = true;
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.NormlBack = null;
            this.textBoxSort.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxSort.ReadOnly = false;
            this.textBoxSort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSort.ShowZero = true;
            this.textBoxSort.Size = new System.Drawing.Size(206, 34);
            // 
            // 
            // 
            this.textBoxSort.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSort.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSort.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxSort.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxSort.SkinTxt.Multiline = true;
            this.textBoxSort.SkinTxt.Name = "BaseText";
            this.textBoxSort.SkinTxt.Size = new System.Drawing.Size(196, 24);
            this.textBoxSort.SkinTxt.TabIndex = 0;
            this.textBoxSort.SkinTxt.Text = "100";
            this.textBoxSort.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxSort.SkinTxt.WaterText = "";
            this.textBoxSort.TabIndex = 85;
            this.textBoxSort.TabStop = true;
            this.textBoxSort.Text = "100";
            this.textBoxSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxSort.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.textBoxSort.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxSort.WaterText = "";
            this.textBoxSort.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(38, 119);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 86;
            this.skinLabel3.Text = "状态";
            // 
            // skinCheckBoxEnable
            // 
            this.skinCheckBoxEnable.AutoSize = true;
            this.skinCheckBoxEnable.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxEnable.Checked = true;
            this.skinCheckBoxEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxEnable.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxEnable.DownBack = null;
            this.skinCheckBoxEnable.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxEnable.Location = new System.Drawing.Point(80, 117);
            this.skinCheckBoxEnable.MouseBack = null;
            this.skinCheckBoxEnable.Name = "skinCheckBoxEnable";
            this.skinCheckBoxEnable.NormlBack = null;
            this.skinCheckBoxEnable.SelectedDownBack = null;
            this.skinCheckBoxEnable.SelectedMouseBack = null;
            this.skinCheckBoxEnable.SelectedNormlBack = null;
            this.skinCheckBoxEnable.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxEnable.TabIndex = 87;
            this.skinCheckBoxEnable.Text = "启用";
            this.skinCheckBoxEnable.UseVisualStyleBackColor = false;
            // 
            // CostumeAddBrandForm
            // 
            this.AcceptButton = this.BaseButton_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 183);
            this.Controls.Add(this.skinCheckBoxEnable);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.textBoxSort);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBoxID);
            this.Controls.Add(this.BaseButton_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CostumeAddBrandForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "添加品牌";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Search;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private TextBox skinTextBoxID;
        private NumericTextBox textBoxSort;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxEnable;
    }
}