namespace JGNet.Manage.Components
{
    partial class EmOrderNewAddressForm
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
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.skinLabelLogisticCompany = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxCity = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxCityArea = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxProvince = new CCWin.SkinControl.SkinComboBox();
            this.textBoxDetailAddr = new JGNet.Common.TextBox();
            this.skinTextBoxHotline = new JGNet.Common.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.textBox1 = new JGNet.Common.TextBox();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // BaseButtonConfirm
            // 
            this.BaseButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BaseButtonConfirm.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonConfirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonConfirm.Location = new System.Drawing.Point(322, 192);
            this.BaseButtonConfirm.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonConfirm.Name = "BaseButtonConfirm";
            this.BaseButtonConfirm.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonConfirm.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonConfirm.TabIndex = 2;
            this.BaseButtonConfirm.Text = "确定";
            this.BaseButtonConfirm.UseVisualStyleBackColor = false;
            this.BaseButtonConfirm.Click += new System.EventHandler(this.BaseButtonConfirm_Click);
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(403, 192);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 2;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // skinLabelLogisticCompany
            // 
            this.skinLabelLogisticCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabelLogisticCompany.AutoSize = true;
            this.skinLabelLogisticCompany.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelLogisticCompany.BorderColor = System.Drawing.Color.White;
            this.skinLabelLogisticCompany.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelLogisticCompany.Location = new System.Drawing.Point(19, 106);
            this.skinLabelLogisticCompany.Name = "skinLabelLogisticCompany";
            this.skinLabelLogisticCompany.Size = new System.Drawing.Size(56, 17);
            this.skinLabelLogisticCompany.TabIndex = 156;
            this.skinLabelLogisticCompany.Text = "所在地区";
            // 
            // skinComboBoxCity
            // 
            this.skinComboBoxCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBoxCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxCity.FormattingEnabled = true;
            this.skinComboBoxCity.Location = new System.Drawing.Point(216, 101);
            this.skinComboBoxCity.Name = "skinComboBoxCity";
            this.skinComboBoxCity.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxCity.TabIndex = 168;
            this.skinComboBoxCity.WaterText = "";
            this.skinComboBoxCity.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxCity_SelectedIndexChanged);
            // 
            // skinComboBoxCityArea
            // 
            this.skinComboBoxCityArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBoxCityArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxCityArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxCityArea.FormattingEnabled = true;
            this.skinComboBoxCityArea.Location = new System.Drawing.Point(357, 100);
            this.skinComboBoxCityArea.Name = "skinComboBoxCityArea";
            this.skinComboBoxCityArea.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxCityArea.TabIndex = 167;
            this.skinComboBoxCityArea.WaterText = "";
            // 
            // skinComboBoxProvince
            // 
            this.skinComboBoxProvince.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBoxProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxProvince.FormattingEnabled = true;
            this.skinComboBoxProvince.Location = new System.Drawing.Point(78, 101);
            this.skinComboBoxProvince.Name = "skinComboBoxProvince";
            this.skinComboBoxProvince.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxProvince.TabIndex = 169;
            this.skinComboBoxProvince.WaterText = "";
            this.skinComboBoxProvince.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxProvince_SelectedIndexChanged);
            // 
            // textBoxDetailAddr
            // 
            this.textBoxDetailAddr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDetailAddr.BackColor = System.Drawing.Color.Transparent;
            this.textBoxDetailAddr.DownBack = null;
            this.textBoxDetailAddr.Icon = null;
            this.textBoxDetailAddr.IconIsButton = false;
            this.textBoxDetailAddr.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxDetailAddr.IsPasswordChat = '\0';
            this.textBoxDetailAddr.IsSystemPasswordChar = false;
            this.textBoxDetailAddr.Lines = new string[0];
            this.textBoxDetailAddr.Location = new System.Drawing.Point(78, 126);
            this.textBoxDetailAddr.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxDetailAddr.MaxLength = 32767;
            this.textBoxDetailAddr.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxDetailAddr.MouseBack = null;
            this.textBoxDetailAddr.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxDetailAddr.Multiline = false;
            this.textBoxDetailAddr.Name = "textBoxDetailAddr";
            this.textBoxDetailAddr.NormlBack = null;
            this.textBoxDetailAddr.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxDetailAddr.ReadOnly = false;
            this.textBoxDetailAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxDetailAddr.Size = new System.Drawing.Size(400, 28);
            // 
            // 
            // 
            this.textBoxDetailAddr.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetailAddr.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDetailAddr.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxDetailAddr.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxDetailAddr.SkinTxt.Name = "BaseText";
            this.textBoxDetailAddr.SkinTxt.Size = new System.Drawing.Size(390, 18);
            this.textBoxDetailAddr.SkinTxt.TabIndex = 0;
            this.textBoxDetailAddr.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxDetailAddr.SkinTxt.WaterText = "";
            this.textBoxDetailAddr.TabIndex = 170;
            this.textBoxDetailAddr.TabStop = true;
            this.textBoxDetailAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxDetailAddr.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxDetailAddr.WaterText = "";
            this.textBoxDetailAddr.WordWrap = true;
            // 
            // skinTextBoxHotline
            // 
            this.skinTextBoxHotline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBoxHotline.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxHotline.DownBack = null;
            this.skinTextBoxHotline.Icon = null;
            this.skinTextBoxHotline.IconIsButton = false;
            this.skinTextBoxHotline.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxHotline.IsPasswordChat = '\0';
            this.skinTextBoxHotline.IsSystemPasswordChar = false;
            this.skinTextBoxHotline.Lines = new string[0];
            this.skinTextBoxHotline.Location = new System.Drawing.Point(78, 69);
            this.skinTextBoxHotline.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxHotline.MaxLength = 32767;
            this.skinTextBoxHotline.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxHotline.MouseBack = null;
            this.skinTextBoxHotline.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxHotline.Multiline = false;
            this.skinTextBoxHotline.Name = "skinTextBoxHotline";
            this.skinTextBoxHotline.NormlBack = null;
            this.skinTextBoxHotline.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxHotline.ReadOnly = false;
            this.skinTextBoxHotline.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxHotline.Size = new System.Drawing.Size(400, 28);
            // 
            // 
            // 
            this.skinTextBoxHotline.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxHotline.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxHotline.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxHotline.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxHotline.SkinTxt.Name = "BaseText";
            this.skinTextBoxHotline.SkinTxt.Size = new System.Drawing.Size(390, 18);
            this.skinTextBoxHotline.SkinTxt.TabIndex = 0;
            this.skinTextBoxHotline.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxHotline.SkinTxt.WaterText = "";
            this.skinTextBoxHotline.TabIndex = 171;
            this.skinTextBoxHotline.TabStop = true;
            this.skinTextBoxHotline.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxHotline.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxHotline.WaterText = "";
            this.skinTextBoxHotline.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(19, 75);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 156;
            this.skinLabel1.Text = "电话号码";
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(31, 41);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 156;
            this.skinLabel2.Text = "收货人";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.DownBack = null;
            this.textBox1.Icon = null;
            this.textBox1.IconIsButton = false;
            this.textBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox1.IsPasswordChat = '\0';
            this.textBox1.IsSystemPasswordChar = false;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(78, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 32767;
            this.textBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox1.MouseBack = null;
            this.textBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.NormlBack = null;
            this.textBox1.Padding = new System.Windows.Forms.Padding(5);
            this.textBox1.ReadOnly = false;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.Size = new System.Drawing.Size(400, 28);
            // 
            // 
            // 
            this.textBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox1.SkinTxt.Name = "BaseText";
            this.textBox1.SkinTxt.Size = new System.Drawing.Size(390, 18);
            this.textBox1.SkinTxt.TabIndex = 0;
            this.textBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox1.SkinTxt.WaterText = "";
            this.textBox1.TabIndex = 171;
            this.textBox1.TabStop = true;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox1.WaterText = "";
            this.textBox1.WordWrap = true;
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DownBack = null;
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.Location = new System.Drawing.Point(379, 165);
            this.skinCheckBox1.MouseBack = null;
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = null;
            this.skinCheckBox1.SelectedDownBack = null;
            this.skinCheckBox1.SelectedMouseBack = null;
            this.skinCheckBox1.SelectedNormlBack = null;
            this.skinCheckBox1.Size = new System.Drawing.Size(99, 21);
            this.skinCheckBox1.TabIndex = 172;
            this.skinCheckBox1.Text = "设为默认地址";
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(19, 131);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 156;
            this.skinLabel3.Text = "详细地址";
            // 
            // EmOrderNewAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 231);
            this.Controls.Add(this.skinCheckBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.skinTextBoxHotline);
            this.Controls.Add(this.textBoxDetailAddr);
            this.Controls.Add(this.skinComboBoxCity);
            this.Controls.Add(this.skinComboBoxCityArea);
            this.Controls.Add(this.skinComboBoxProvince);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabelLogisticCompany);
            this.Controls.Add(this.baseButtonCancel);
            this.Controls.Add(this.BaseButtonConfirm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmOrderNewAddressForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "新增收货地址";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EmOrderNewAddressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Components.BaseButton BaseButtonConfirm;
        private Common.Components.BaseButton baseButtonCancel;
        private CCWin.SkinControl.SkinLabel skinLabelLogisticCompany;
        private CCWin.SkinControl.SkinComboBox skinComboBoxCity;
        private CCWin.SkinControl.SkinComboBox skinComboBoxCityArea;
        private CCWin.SkinControl.SkinComboBox skinComboBoxProvince;
        private Common.TextBox textBoxDetailAddr;
        private Common.TextBox skinTextBoxHotline;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private Common.TextBox textBox1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
    }
}