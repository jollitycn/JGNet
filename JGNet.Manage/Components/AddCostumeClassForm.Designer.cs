using CCWin.SkinControl;

namespace JGNet.Common.Components
{
    partial class AddCostumeClassForm
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
            this.skinTextBoxID = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxName = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.costumeTextBoxSort = new JGNet.Common.NumericTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxCode = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // BaseButton_Search
            // 
            this.BaseButton_Search.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Search.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Search.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Search.Location = new System.Drawing.Point(214, 189);
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
            this.skinLabel2.Location = new System.Drawing.Point(17, 153);
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
            this.skinLabel1.Location = new System.Drawing.Point(17, 40);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 84;
            this.skinLabel1.Text = "类别名称";
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
            this.skinTextBoxID.Location = new System.Drawing.Point(83, 31);
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
            this.skinTextBoxName.Location = new System.Drawing.Point(83, 106);
            this.skinTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxName.MaxLength = 32767;
            this.skinTextBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxName.MouseBack = null;
            this.skinTextBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.Multiline = true;
            this.skinTextBoxName.Name = "skinTextBoxName";
            this.skinTextBoxName.NormlBack = null;
            this.skinTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxName.ReadOnly = true;
            this.skinTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxName.Size = new System.Drawing.Size(206, 34);
            // 
            // 
            // 
            this.skinTextBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxName.SkinTxt.Multiline = true;
            this.skinTextBoxName.SkinTxt.Name = "BaseText";
            this.skinTextBoxName.SkinTxt.ReadOnly = true;
            this.skinTextBoxName.SkinTxt.Size = new System.Drawing.Size(196, 24);
            this.skinTextBoxName.SkinTxt.TabIndex = 0;
            this.skinTextBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.SkinTxt.WaterText = "";
            this.skinTextBoxName.TabIndex = 85;
            this.skinTextBoxName.TabStop = true;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "";
            this.skinTextBoxName.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(17, 115);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 83;
            this.skinLabel3.Text = "隶属类别";
            // 
            // costumeTextBoxSort
            // 
            this.costumeTextBoxSort.BackColor = System.Drawing.Color.Transparent;
            this.costumeTextBoxSort.DecimalPlaces = 0;
            this.costumeTextBoxSort.DownBack = null;
            this.costumeTextBoxSort.Icon = null;
            this.costumeTextBoxSort.IconIsButton = false;
            this.costumeTextBoxSort.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeTextBoxSort.IsPasswordChat = '\0';
            this.costumeTextBoxSort.IsSystemPasswordChar = false;
            this.costumeTextBoxSort.Lines = new string[0];
            this.costumeTextBoxSort.Location = new System.Drawing.Point(83, 144);
            this.costumeTextBoxSort.Margin = new System.Windows.Forms.Padding(0);
            this.costumeTextBoxSort.MaxLength = 3;
            this.costumeTextBoxSort.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.costumeTextBoxSort.MinimumSize = new System.Drawing.Size(28, 28);
            this.costumeTextBoxSort.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.costumeTextBoxSort.MouseBack = null;
            this.costumeTextBoxSort.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeTextBoxSort.Multiline = true;
            this.costumeTextBoxSort.Name = "costumeTextBoxSort";
            this.costumeTextBoxSort.NormlBack = null;
            this.costumeTextBoxSort.Padding = new System.Windows.Forms.Padding(5);
            this.costumeTextBoxSort.ReadOnly = false;
            this.costumeTextBoxSort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.costumeTextBoxSort.ShowZero = true;
            this.costumeTextBoxSort.Size = new System.Drawing.Size(206, 34);
            // 
            // 
            // 
            this.costumeTextBoxSort.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costumeTextBoxSort.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costumeTextBoxSort.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.costumeTextBoxSort.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.costumeTextBoxSort.SkinTxt.MaxLength = 3;
            this.costumeTextBoxSort.SkinTxt.Multiline = true;
            this.costumeTextBoxSort.SkinTxt.Name = "BaseText";
            this.costumeTextBoxSort.SkinTxt.Size = new System.Drawing.Size(196, 24);
            this.costumeTextBoxSort.SkinTxt.TabIndex = 0;
            this.costumeTextBoxSort.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeTextBoxSort.SkinTxt.WaterText = "";
            this.costumeTextBoxSort.TabIndex = 85;
            this.costumeTextBoxSort.TabStop = true;
            this.costumeTextBoxSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.costumeTextBoxSort.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.costumeTextBoxSort.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeTextBoxSort.WaterText = "";
            this.costumeTextBoxSort.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(17, 78);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 87;
            this.skinLabel4.Text = "类别编码";
            // 
            // skinTextBoxCode
            // 
            this.skinTextBoxCode.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxCode.DownBack = null;
            this.skinTextBoxCode.Icon = null;
            this.skinTextBoxCode.IconIsButton = false;
            this.skinTextBoxCode.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxCode.IsPasswordChat = '\0';
            this.skinTextBoxCode.IsSystemPasswordChar = false;
            this.skinTextBoxCode.Lines = new string[0];
            this.skinTextBoxCode.Location = new System.Drawing.Point(83, 69);
            this.skinTextBoxCode.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxCode.MaxLength = 32767;
            this.skinTextBoxCode.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxCode.MouseBack = null;
            this.skinTextBoxCode.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxCode.Multiline = true;
            this.skinTextBoxCode.Name = "skinTextBoxCode";
            this.skinTextBoxCode.NormlBack = null;
            this.skinTextBoxCode.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxCode.ReadOnly = false;
            this.skinTextBoxCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxCode.Size = new System.Drawing.Size(206, 34);
            // 
            // 
            // 
            this.skinTextBoxCode.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxCode.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxCode.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxCode.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxCode.SkinTxt.Multiline = true;
            this.skinTextBoxCode.SkinTxt.Name = "BaseText";
            this.skinTextBoxCode.SkinTxt.Size = new System.Drawing.Size(196, 24);
            this.skinTextBoxCode.SkinTxt.TabIndex = 0;
            this.skinTextBoxCode.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxCode.SkinTxt.WaterText = "";
            this.skinTextBoxCode.TabIndex = 86;
            this.skinTextBoxCode.TabStop = true;
            this.skinTextBoxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxCode.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxCode.WaterText = "";
            this.skinTextBoxCode.WordWrap = true;
            // 
            // AddCostumeClassForm
            // 
            this.AcceptButton = this.BaseButton_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 228);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinTextBoxCode);
            this.Controls.Add(this.costumeTextBoxSort);
            this.Controls.Add(this.skinTextBoxName);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBoxID);
            this.Controls.Add(this.BaseButton_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCostumeClassForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "新增类型";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Search;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private SkinTextBox skinTextBoxID;
        private SkinTextBox skinTextBoxName;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private NumericTextBox costumeTextBoxSort;
        private SkinLabel skinLabel4;
        private SkinTextBox skinTextBoxCode;
    }
}