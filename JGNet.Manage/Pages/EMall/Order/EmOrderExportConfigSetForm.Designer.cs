namespace JGNet.Common.Components
{
    partial class EmOrderExportConfigSetForm
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
            this.skinTxtChannelID = new JGNet.Common.TextBox();
            this.skinTxtStoreHouseID = new JGNet.Common.TextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtChannelName = new JGNet.Common.TextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.txtStoreHouseName = new JGNet.Common.TextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.txtSeparateAccountsName = new JGNet.Common.TextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.txtSeparateAccountsID = new JGNet.Common.TextBox();
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
            this.BaseButton_Search.Location = new System.Drawing.Point(201, 162);
            this.BaseButton_Search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Search.Name = "BaseButton_Search";
            this.BaseButton_Search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Search.TabIndex = 3;
            this.BaseButton_Search.Text = "保存";
            this.BaseButton_Search.UseVisualStyleBackColor = false;
            this.BaseButton_Search.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(10, 35);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 84;
            this.skinLabel1.Text = "渠道编号：";
            // 
            // skinTxtChannelID
            // 
            this.skinTxtChannelID.BackColor = System.Drawing.Color.Transparent;
            this.skinTxtChannelID.DownBack = null;
            this.skinTxtChannelID.Icon = null;
            this.skinTxtChannelID.IconIsButton = false;
            this.skinTxtChannelID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTxtChannelID.IsPasswordChat = '\0';
            this.skinTxtChannelID.IsSystemPasswordChar = false;
            this.skinTxtChannelID.Lines = new string[0];
            this.skinTxtChannelID.Location = new System.Drawing.Point(80, 30);
            this.skinTxtChannelID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTxtChannelID.MaxLength = 32767;
            this.skinTxtChannelID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTxtChannelID.MouseBack = null;
            this.skinTxtChannelID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTxtChannelID.Multiline = false;
            this.skinTxtChannelID.Name = "skinTxtChannelID";
            this.skinTxtChannelID.NormlBack = null;
            this.skinTxtChannelID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTxtChannelID.ReadOnly = false;
            this.skinTxtChannelID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTxtChannelID.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.skinTxtChannelID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTxtChannelID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTxtChannelID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTxtChannelID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTxtChannelID.SkinTxt.Name = "BaseText";
            this.skinTxtChannelID.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.skinTxtChannelID.SkinTxt.TabIndex = 0;
            this.skinTxtChannelID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTxtChannelID.SkinTxt.WaterText = "";
            this.skinTxtChannelID.TabIndex = 0;
            this.skinTxtChannelID.TabStop = true;
            this.skinTxtChannelID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTxtChannelID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTxtChannelID.WaterText = "";
            this.skinTxtChannelID.WordWrap = true;
            // 
            // skinTxtStoreHouseID
            // 
            this.skinTxtStoreHouseID.BackColor = System.Drawing.Color.Transparent;
            this.skinTxtStoreHouseID.DownBack = null;
            this.skinTxtStoreHouseID.Icon = null;
            this.skinTxtStoreHouseID.IconIsButton = false;
            this.skinTxtStoreHouseID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTxtStoreHouseID.IsPasswordChat = '\0';
            this.skinTxtStoreHouseID.IsSystemPasswordChar = false;
            this.skinTxtStoreHouseID.Lines = new string[0];
            this.skinTxtStoreHouseID.Location = new System.Drawing.Point(80, 69);
            this.skinTxtStoreHouseID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTxtStoreHouseID.MaxLength = 32767;
            this.skinTxtStoreHouseID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTxtStoreHouseID.MouseBack = null;
            this.skinTxtStoreHouseID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTxtStoreHouseID.Multiline = false;
            this.skinTxtStoreHouseID.Name = "skinTxtStoreHouseID";
            this.skinTxtStoreHouseID.NormlBack = null;
            this.skinTxtStoreHouseID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTxtStoreHouseID.ReadOnly = false;
            this.skinTxtStoreHouseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTxtStoreHouseID.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.skinTxtStoreHouseID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTxtStoreHouseID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTxtStoreHouseID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTxtStoreHouseID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTxtStoreHouseID.SkinTxt.Name = "BaseText";
            this.skinTxtStoreHouseID.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.skinTxtStoreHouseID.SkinTxt.TabIndex = 0;
            this.skinTxtStoreHouseID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTxtStoreHouseID.SkinTxt.WaterText = "";
            this.skinTxtStoreHouseID.TabIndex = 85;
            this.skinTxtStoreHouseID.TabStop = true;
            this.skinTxtStoreHouseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTxtStoreHouseID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTxtStoreHouseID.WaterText = "";
            this.skinTxtStoreHouseID.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(10, 74);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 86;
            this.skinLabel3.Text = "仓库编号：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(232, 35);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 88;
            this.skinLabel2.Text = "渠道名称：";
            // 
            // txtChannelName
            // 
            this.txtChannelName.BackColor = System.Drawing.Color.Transparent;
            this.txtChannelName.DownBack = null;
            this.txtChannelName.Icon = null;
            this.txtChannelName.IconIsButton = false;
            this.txtChannelName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChannelName.IsPasswordChat = '\0';
            this.txtChannelName.IsSystemPasswordChar = false;
            this.txtChannelName.Lines = new string[0];
            this.txtChannelName.Location = new System.Drawing.Point(302, 30);
            this.txtChannelName.Margin = new System.Windows.Forms.Padding(0);
            this.txtChannelName.MaxLength = 32767;
            this.txtChannelName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtChannelName.MouseBack = null;
            this.txtChannelName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChannelName.Multiline = false;
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.NormlBack = null;
            this.txtChannelName.Padding = new System.Windows.Forms.Padding(5);
            this.txtChannelName.ReadOnly = false;
            this.txtChannelName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChannelName.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.txtChannelName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChannelName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChannelName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtChannelName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtChannelName.SkinTxt.Name = "BaseText";
            this.txtChannelName.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.txtChannelName.SkinTxt.TabIndex = 0;
            this.txtChannelName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChannelName.SkinTxt.WaterText = "";
            this.txtChannelName.TabIndex = 87;
            this.txtChannelName.TabStop = true;
            this.txtChannelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChannelName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChannelName.WaterText = "";
            this.txtChannelName.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(232, 73);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(68, 17);
            this.skinLabel4.TabIndex = 90;
            this.skinLabel4.Text = "仓库名称：";
            // 
            // txtStoreHouseName
            // 
            this.txtStoreHouseName.BackColor = System.Drawing.Color.Transparent;
            this.txtStoreHouseName.DownBack = null;
            this.txtStoreHouseName.Icon = null;
            this.txtStoreHouseName.IconIsButton = false;
            this.txtStoreHouseName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtStoreHouseName.IsPasswordChat = '\0';
            this.txtStoreHouseName.IsSystemPasswordChar = false;
            this.txtStoreHouseName.Lines = new string[0];
            this.txtStoreHouseName.Location = new System.Drawing.Point(302, 68);
            this.txtStoreHouseName.Margin = new System.Windows.Forms.Padding(0);
            this.txtStoreHouseName.MaxLength = 32767;
            this.txtStoreHouseName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtStoreHouseName.MouseBack = null;
            this.txtStoreHouseName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtStoreHouseName.Multiline = false;
            this.txtStoreHouseName.Name = "txtStoreHouseName";
            this.txtStoreHouseName.NormlBack = null;
            this.txtStoreHouseName.Padding = new System.Windows.Forms.Padding(5);
            this.txtStoreHouseName.ReadOnly = false;
            this.txtStoreHouseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStoreHouseName.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.txtStoreHouseName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStoreHouseName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStoreHouseName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtStoreHouseName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtStoreHouseName.SkinTxt.Name = "BaseText";
            this.txtStoreHouseName.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.txtStoreHouseName.SkinTxt.TabIndex = 0;
            this.txtStoreHouseName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtStoreHouseName.SkinTxt.WaterText = "";
            this.txtStoreHouseName.TabIndex = 89;
            this.txtStoreHouseName.TabStop = true;
            this.txtStoreHouseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStoreHouseName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtStoreHouseName.WaterText = "";
            this.txtStoreHouseName.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(232, 115);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(68, 17);
            this.skinLabel5.TabIndex = 94;
            this.skinLabel5.Text = "分账名称：";
            // 
            // txtSeparateAccountsName
            // 
            this.txtSeparateAccountsName.BackColor = System.Drawing.Color.Transparent;
            this.txtSeparateAccountsName.DownBack = null;
            this.txtSeparateAccountsName.Icon = null;
            this.txtSeparateAccountsName.IconIsButton = false;
            this.txtSeparateAccountsName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSeparateAccountsName.IsPasswordChat = '\0';
            this.txtSeparateAccountsName.IsSystemPasswordChar = false;
            this.txtSeparateAccountsName.Lines = new string[0];
            this.txtSeparateAccountsName.Location = new System.Drawing.Point(302, 110);
            this.txtSeparateAccountsName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSeparateAccountsName.MaxLength = 32767;
            this.txtSeparateAccountsName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtSeparateAccountsName.MouseBack = null;
            this.txtSeparateAccountsName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSeparateAccountsName.Multiline = false;
            this.txtSeparateAccountsName.Name = "txtSeparateAccountsName";
            this.txtSeparateAccountsName.NormlBack = null;
            this.txtSeparateAccountsName.Padding = new System.Windows.Forms.Padding(5);
            this.txtSeparateAccountsName.ReadOnly = false;
            this.txtSeparateAccountsName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeparateAccountsName.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.txtSeparateAccountsName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeparateAccountsName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSeparateAccountsName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtSeparateAccountsName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtSeparateAccountsName.SkinTxt.Name = "BaseText";
            this.txtSeparateAccountsName.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.txtSeparateAccountsName.SkinTxt.TabIndex = 0;
            this.txtSeparateAccountsName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSeparateAccountsName.SkinTxt.WaterText = "";
            this.txtSeparateAccountsName.TabIndex = 93;
            this.txtSeparateAccountsName.TabStop = true;
            this.txtSeparateAccountsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSeparateAccountsName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSeparateAccountsName.WaterText = "";
            this.txtSeparateAccountsName.WordWrap = true;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(11, 116);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(68, 17);
            this.skinLabel6.TabIndex = 92;
            this.skinLabel6.Text = "分账编号：";
            // 
            // txtSeparateAccountsID
            // 
            this.txtSeparateAccountsID.BackColor = System.Drawing.Color.Transparent;
            this.txtSeparateAccountsID.DownBack = null;
            this.txtSeparateAccountsID.Icon = null;
            this.txtSeparateAccountsID.IconIsButton = false;
            this.txtSeparateAccountsID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSeparateAccountsID.IsPasswordChat = '\0';
            this.txtSeparateAccountsID.IsSystemPasswordChar = false;
            this.txtSeparateAccountsID.Lines = new string[0];
            this.txtSeparateAccountsID.Location = new System.Drawing.Point(80, 111);
            this.txtSeparateAccountsID.Margin = new System.Windows.Forms.Padding(0);
            this.txtSeparateAccountsID.MaxLength = 32767;
            this.txtSeparateAccountsID.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtSeparateAccountsID.MouseBack = null;
            this.txtSeparateAccountsID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSeparateAccountsID.Multiline = false;
            this.txtSeparateAccountsID.Name = "txtSeparateAccountsID";
            this.txtSeparateAccountsID.NormlBack = null;
            this.txtSeparateAccountsID.Padding = new System.Windows.Forms.Padding(5);
            this.txtSeparateAccountsID.ReadOnly = false;
            this.txtSeparateAccountsID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeparateAccountsID.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.txtSeparateAccountsID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeparateAccountsID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSeparateAccountsID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtSeparateAccountsID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtSeparateAccountsID.SkinTxt.Name = "BaseText";
            this.txtSeparateAccountsID.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.txtSeparateAccountsID.SkinTxt.TabIndex = 0;
            this.txtSeparateAccountsID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSeparateAccountsID.SkinTxt.WaterText = "";
            this.txtSeparateAccountsID.TabIndex = 91;
            this.txtSeparateAccountsID.TabStop = true;
            this.txtSeparateAccountsID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSeparateAccountsID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSeparateAccountsID.WaterText = "";
            this.txtSeparateAccountsID.WordWrap = true;
            // 
            // EmOrderExportConfigSetForm
            // 
            this.AcceptButton = this.BaseButton_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 213);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.txtSeparateAccountsName);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.txtSeparateAccountsID);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.txtStoreHouseName);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.txtChannelName);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinTxtStoreHouseID);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTxtChannelID);
            this.Controls.Add(this.BaseButton_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmOrderExportConfigSetForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "导出设置";
            this.Load += new System.EventHandler(this.EmOrderExportConfigSetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Search;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private TextBox skinTxtChannelID;
        private TextBox skinTxtStoreHouseID;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private TextBox txtChannelName;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private TextBox txtStoreHouseName;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private TextBox txtSeparateAccountsName;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private TextBox txtSeparateAccountsID;
    }
}