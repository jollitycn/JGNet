namespace JGNet.Common.Components
{
    partial class EmOrderDeliverForm2
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
            this.skinRadioButtonOffline = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButtonOnline = new CCWin.SkinControl.SkinRadioButton();
            this.skinComboBoxShopID = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxLogisticId = new JGNet.Common.TextBox();
            this.skinTextBoxLogisticCompany = new CCWin.SkinControl.SkinComboBox();
            this.skinLabelLogisticCompany = new CCWin.SkinControl.SkinLabel();
            this.skinLabelLogisticId = new CCWin.SkinControl.SkinLabel();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
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
            this.BaseButton_Search.Location = new System.Drawing.Point(246, 138);
            this.BaseButton_Search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Search.Name = "BaseButton_Search";
            this.BaseButton_Search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Search.TabIndex = 3;
            this.BaseButton_Search.Text = "确定";
            this.BaseButton_Search.UseVisualStyleBackColor = false;
            this.BaseButton_Search.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinRadioButtonOffline
            // 
            this.skinRadioButtonOffline.AutoSize = true;
            this.skinRadioButtonOffline.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonOffline.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonOffline.DownBack = null;
            this.skinRadioButtonOffline.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonOffline.Location = new System.Drawing.Point(174, 31);
            this.skinRadioButtonOffline.MouseBack = null;
            this.skinRadioButtonOffline.Name = "skinRadioButtonOffline";
            this.skinRadioButtonOffline.NormlBack = null;
            this.skinRadioButtonOffline.SelectedDownBack = null;
            this.skinRadioButtonOffline.SelectedMouseBack = null;
            this.skinRadioButtonOffline.SelectedNormlBack = null;
            this.skinRadioButtonOffline.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButtonOffline.TabIndex = 169;
            this.skinRadioButtonOffline.Tag = "sexRadio";
            this.skinRadioButtonOffline.Text = "无需物流";
            this.skinRadioButtonOffline.UseVisualStyleBackColor = false;
            this.skinRadioButtonOffline.CheckedChanged += new System.EventHandler(this.skinRadioButtonOffline_CheckedChanged);
            // 
            // skinRadioButtonOnline
            // 
            this.skinRadioButtonOnline.AutoSize = true;
            this.skinRadioButtonOnline.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonOnline.Checked = true;
            this.skinRadioButtonOnline.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonOnline.DownBack = null;
            this.skinRadioButtonOnline.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonOnline.Location = new System.Drawing.Point(115, 31);
            this.skinRadioButtonOnline.MouseBack = null;
            this.skinRadioButtonOnline.Name = "skinRadioButtonOnline";
            this.skinRadioButtonOnline.NormlBack = null;
            this.skinRadioButtonOnline.SelectedDownBack = null;
            this.skinRadioButtonOnline.SelectedMouseBack = null;
            this.skinRadioButtonOnline.SelectedNormlBack = null;
            this.skinRadioButtonOnline.Size = new System.Drawing.Size(50, 21);
            this.skinRadioButtonOnline.TabIndex = 170;
            this.skinRadioButtonOnline.TabStop = true;
            this.skinRadioButtonOnline.Tag = "sexRadio";
            this.skinRadioButtonOnline.Text = "快递";
            this.skinRadioButtonOnline.UseVisualStyleBackColor = false;
            this.skinRadioButtonOnline.CheckedChanged += new System.EventHandler(this.skinRadioButtonOnline_CheckedChanged);
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(115, 58);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(164, 22);
            this.skinComboBoxShopID.TabIndex = 168;
            this.skinComboBoxShopID.WaterText = "";
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(50, 61);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 167;
            this.skinLabel3.Text = "发货店铺";
            // 
            // skinTextBoxLogisticId
            // 
            this.skinTextBoxLogisticId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTextBoxLogisticId.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxLogisticId.DownBack = null;
            this.skinTextBoxLogisticId.Icon = null;
            this.skinTextBoxLogisticId.IconIsButton = false;
            this.skinTextBoxLogisticId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxLogisticId.IsPasswordChat = '\0';
            this.skinTextBoxLogisticId.IsSystemPasswordChar = false;
            this.skinTextBoxLogisticId.Lines = new string[0];
            this.skinTextBoxLogisticId.Location = new System.Drawing.Point(115, 107);
            this.skinTextBoxLogisticId.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxLogisticId.MaxLength = 32767;
            this.skinTextBoxLogisticId.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxLogisticId.MouseBack = null;
            this.skinTextBoxLogisticId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxLogisticId.Multiline = false;
            this.skinTextBoxLogisticId.Name = "skinTextBoxLogisticId";
            this.skinTextBoxLogisticId.NormlBack = null;
            this.skinTextBoxLogisticId.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxLogisticId.ReadOnly = false;
            this.skinTextBoxLogisticId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxLogisticId.Size = new System.Drawing.Size(285, 28);
            // 
            // 
            // 
            this.skinTextBoxLogisticId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxLogisticId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxLogisticId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxLogisticId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxLogisticId.SkinTxt.Name = "BaseText";
            this.skinTextBoxLogisticId.SkinTxt.Size = new System.Drawing.Size(275, 18);
            this.skinTextBoxLogisticId.SkinTxt.TabIndex = 0;
            this.skinTextBoxLogisticId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxLogisticId.SkinTxt.WaterText = "";
            this.skinTextBoxLogisticId.TabIndex = 166;
            this.skinTextBoxLogisticId.TabStop = true;
            this.skinTextBoxLogisticId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxLogisticId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxLogisticId.WaterText = "";
            this.skinTextBoxLogisticId.WordWrap = true;
            // 
            // skinTextBoxLogisticCompany
            // 
            this.skinTextBoxLogisticCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTextBoxLogisticCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinTextBoxLogisticCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinTextBoxLogisticCompany.FormattingEnabled = true;
            this.skinTextBoxLogisticCompany.Location = new System.Drawing.Point(115, 82);
            this.skinTextBoxLogisticCompany.Name = "skinTextBoxLogisticCompany";
            this.skinTextBoxLogisticCompany.Size = new System.Drawing.Size(164, 22);
            this.skinTextBoxLogisticCompany.TabIndex = 165;
            this.skinTextBoxLogisticCompany.WaterText = "";
            // 
            // skinLabelLogisticCompany
            // 
            this.skinLabelLogisticCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabelLogisticCompany.AutoSize = true;
            this.skinLabelLogisticCompany.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelLogisticCompany.BorderColor = System.Drawing.Color.White;
            this.skinLabelLogisticCompany.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelLogisticCompany.Location = new System.Drawing.Point(50, 87);
            this.skinLabelLogisticCompany.Name = "skinLabelLogisticCompany";
            this.skinLabelLogisticCompany.Size = new System.Drawing.Size(56, 17);
            this.skinLabelLogisticCompany.TabIndex = 164;
            this.skinLabelLogisticCompany.Text = "物流公司";
            // 
            // skinLabelLogisticId
            // 
            this.skinLabelLogisticId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabelLogisticId.AutoSize = true;
            this.skinLabelLogisticId.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelLogisticId.BorderColor = System.Drawing.Color.White;
            this.skinLabelLogisticId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelLogisticId.Location = new System.Drawing.Point(50, 113);
            this.skinLabelLogisticId.Name = "skinLabelLogisticId";
            this.skinLabelLogisticId.Size = new System.Drawing.Size(56, 17);
            this.skinLabelLogisticId.TabIndex = 163;
            this.skinLabelLogisticId.Text = "物流单号";
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(327, 138);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 3;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // EmOrderDeliverForm2
            // 
            this.AcceptButton = this.BaseButton_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 176);
            this.Controls.Add(this.skinRadioButtonOffline);
            this.Controls.Add(this.skinRadioButtonOnline);
            this.Controls.Add(this.skinComboBoxShopID);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinTextBoxLogisticId);
            this.Controls.Add(this.skinTextBoxLogisticCompany);
            this.Controls.Add(this.skinLabelLogisticCompany);
            this.Controls.Add(this.skinLabelLogisticId);
            this.Controls.Add(this.baseButtonCancel);
            this.Controls.Add(this.BaseButton_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmOrderDeliverForm2";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "发货";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Search;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonOffline;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonOnline;
        private CCWin.SkinControl.SkinComboBox skinComboBoxShopID;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private TextBox skinTextBoxLogisticId;
        private CCWin.SkinControl.SkinComboBox skinTextBoxLogisticCompany;
        private CCWin.SkinControl.SkinLabel skinLabelLogisticCompany;
        private CCWin.SkinControl.SkinLabel skinLabelLogisticId;
        private BaseButton baseButtonCancel;
    }
}