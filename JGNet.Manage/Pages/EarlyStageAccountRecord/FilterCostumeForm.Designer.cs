using JGNet.Common;
using JGNet.Common.Components;

namespace JGNet.Manage.Components
{
    partial class FilterCostumeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterCostumeForm));
            this.skinPanel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.BaseButtonSave = new JGNet.Common.Components.BaseButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxBigClass = new JGNet.Common.CostumeClassSelector();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Year = new JGNet.Manage.Components.YearComboBox();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_ID = new JGNet.Common.TextBox();
            this.skinTextBox_Name = new JGNet.Common.TextBox();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.costumeStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.colorComboBox1 = new JGNet.Manage.ColorComboBox();
            this.skinComboBox_Season = new JGNet.Manage.Components.SeasonComboBox();
            this.skinComboBox_Brand = new JGNet.Manage.BrandComboBox();
            this.skinComboBox_SupplierID = new SupllierComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BorderColor = System.Drawing.Color.White;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinPanel1.Location = new System.Drawing.Point(4, 28);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(516, 167);
            this.skinPanel1.TabIndex = 1;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(28, 36);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 181;
            this.skinLabel1.Text = "款号";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(292, 94);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 175;
            this.skinLabel7.Text = "品牌";
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(292, 65);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(32, 17);
            this.skinLabel11.TabIndex = 188;
            this.skinLabel11.Text = "季节";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(16, 122);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(44, 17);
            this.skinLabel6.TabIndex = 176;
            this.skinLabel6.Text = "供应商";
            // 
            // BaseButtonSave
            // 
            this.BaseButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonSave.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonSave.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonSave.Location = new System.Drawing.Point(338, 150);
            this.BaseButtonSave.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonSave.Name = "BaseButtonSave";
            this.BaseButtonSave.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonSave.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonSave.TabIndex = 171;
            this.BaseButtonSave.Text = "确定";
            this.BaseButtonSave.UseVisualStyleBackColor = false;
            this.BaseButtonSave.Click += new System.EventHandler(this.BaseButtonSave_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(28, 65);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 173;
            this.skinLabel2.Text = "名称";
            // 
            // skinComboBoxBigClass
            // 
            this.skinComboBoxBigClass.AutoSize = true;
            this.skinComboBoxBigClass.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxBigClass.Location = new System.Drawing.Point(63, 88);
            this.skinComboBoxBigClass.Name = "skinComboBoxBigClass";
            this.skinComboBoxBigClass.SelectedValue = ((JGNet.Costume)(resources.GetObject("skinComboBoxBigClass.SelectedValue")));
            this.skinComboBoxBigClass.Size = new System.Drawing.Size(153, 29);
            this.skinComboBoxBigClass.TabIndex = 159;
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(28, 94);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(32, 17);
            this.skinLabel10.TabIndex = 183;
            this.skinLabel10.Text = "类别";
            // 
            // skinComboBox_Year
            // 
            this.skinComboBox_Year.DisplayMember = "key";
            this.skinComboBox_Year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Year.FormattingEnabled = true;
            this.skinComboBox_Year.HideAll = false;
            this.skinComboBox_Year.Location = new System.Drawing.Point(330, 33);
            this.skinComboBox_Year.Name = "skinComboBox_Year";
            this.skinComboBox_Year.Size = new System.Drawing.Size(164, 22);
            this.skinComboBox_Year.TabIndex = 154;
            this.skinComboBox_Year.ValueMember = "value";
            this.skinComboBox_Year.WaterText = "";
            // 
            // skinLabel12
            // 
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(292, 36);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(32, 17);
            this.skinLabel12.TabIndex = 182;
            this.skinLabel12.Text = "年份";
            // 
            // skinTextBox_ID
            // 
            this.skinTextBox_ID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_ID.DownBack = null;
            this.skinTextBox_ID.Icon = null;
            this.skinTextBox_ID.IconIsButton = false;
            this.skinTextBox_ID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_ID.IsPasswordChat = '\0';
            this.skinTextBox_ID.IsSystemPasswordChar = false;
            this.skinTextBox_ID.Lines = new string[0];
            this.skinTextBox_ID.Location = new System.Drawing.Point(63, 30);
            this.skinTextBox_ID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_ID.MaxLength = 32767;
            this.skinTextBox_ID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_ID.MouseBack = null;
            this.skinTextBox_ID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_ID.Multiline = false;
            this.skinTextBox_ID.Name = "skinTextBox_ID";
            this.skinTextBox_ID.NormlBack = null;
            this.skinTextBox_ID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_ID.ReadOnly = false;
            this.skinTextBox_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_ID.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.skinTextBox_ID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_ID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_ID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_ID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_ID.SkinTxt.Name = "BaseText";
            this.skinTextBox_ID.SkinTxt.Size = new System.Drawing.Size(154, 18);
            this.skinTextBox_ID.SkinTxt.TabIndex = 0;
            this.skinTextBox_ID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_ID.SkinTxt.WaterText = "";
            this.skinTextBox_ID.TabIndex = 153;
            this.skinTextBox_ID.TabStop = true;
            this.skinTextBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_ID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_ID.WaterText = "";
            this.skinTextBox_ID.WordWrap = true;
            // 
            // skinTextBox_Name
            // 
            this.skinTextBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Name.DownBack = null;
            this.skinTextBox_Name.Icon = null;
            this.skinTextBox_Name.IconIsButton = false;
            this.skinTextBox_Name.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Name.IsPasswordChat = '\0';
            this.skinTextBox_Name.IsSystemPasswordChar = false;
            this.skinTextBox_Name.Lines = new string[0];
            this.skinTextBox_Name.Location = new System.Drawing.Point(63, 59);
            this.skinTextBox_Name.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Name.MaxLength = 32767;
            this.skinTextBox_Name.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Name.MouseBack = null;
            this.skinTextBox_Name.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Name.Multiline = false;
            this.skinTextBox_Name.Name = "skinTextBox_Name";
            this.skinTextBox_Name.NormlBack = null;
            this.skinTextBox_Name.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Name.ReadOnly = false;
            this.skinTextBox_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Name.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.skinTextBox_Name.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Name.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Name.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Name.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Name.SkinTxt.Name = "BaseText";
            this.skinTextBox_Name.SkinTxt.Size = new System.Drawing.Size(154, 18);
            this.skinTextBox_Name.SkinTxt.TabIndex = 0;
            this.skinTextBox_Name.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Name.SkinTxt.WaterText = "";
            this.skinTextBox_Name.TabIndex = 155;
            this.skinTextBox_Name.TabStop = true;
            this.skinTextBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Name.WaterText = "";
            this.skinTextBox_Name.WordWrap = true;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(419, 150);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 171;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // costumeStoreBindingSource
            // 
            this.costumeStoreBindingSource.DataSource = typeof(JGNet.CostumeStore);
            // 
            // skinLabel14
            // 
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel14.Location = new System.Drawing.Point(292, 122);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(32, 17);
            this.skinLabel14.TabIndex = 194;
            this.skinLabel14.Text = "颜色";
            // 
            // colorComboBox1
            // 
            this.colorComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.colorComboBox1.HideAll = false;
            this.colorComboBox1.HideEmpty = false;
            this.colorComboBox1.Location = new System.Drawing.Point(327, 117);
            this.colorComboBox1.Name = "colorComboBox1";
            this.colorComboBox1.SelectedItem = ((JGNet.CostumeColor)(resources.GetObject("colorComboBox1.SelectedItem")));
            this.colorComboBox1.SelectedText = "";
            this.colorComboBox1.SelectedValue = null;
            this.colorComboBox1.ShowAdd = false;
            this.colorComboBox1.Size = new System.Drawing.Size(190, 27);
            this.colorComboBox1.TabIndex = 195;
            // 
            // skinComboBox_Season
            // 
            this.skinComboBox_Season.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_Season.Location = new System.Drawing.Point(327, 60);
            this.skinComboBox_Season.Name = "skinComboBox_Season";
            this.skinComboBox_Season.SelectedValue = null;
            this.skinComboBox_Season.ShowAdd = false;
            this.skinComboBox_Season.ShowAll = true;
            this.skinComboBox_Season.Size = new System.Drawing.Size(192, 27);
            this.skinComboBox_Season.TabIndex = 156;
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.skinComboBox_Brand.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(327, 89);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectedIndexChanged = null;
            this.skinComboBox_Brand.SelectedItem = ((JGNet.Brand)(resources.GetObject("skinComboBox_Brand.SelectedItem")));
            this.skinComboBox_Brand.SelectedValue = -1;
            this.skinComboBox_Brand.ShowAdd = false;
            this.skinComboBox_Brand.ShowAll = true;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(191, 26);
            this.skinComboBox_Brand.TabIndex = 162;
            // 
            // skinComboBox_SupplierID
            // 
            this.skinComboBox_SupplierID.AutoSize = true;
            this.skinComboBox_SupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_SupplierID.HideAll = false;
            this.skinComboBox_SupplierID.Location = new System.Drawing.Point(63, 119);
            this.skinComboBox_SupplierID.Name = "skinComboBox_SupplierID";
            this.skinComboBox_SupplierID.SelectedItem = ((JGNet.Supplier)(resources.GetObject("skinComboBox_SupplierID.SelectedItem")));
            this.skinComboBox_SupplierID.SelectedValue = null;
            this.skinComboBox_SupplierID.ShowAdd = false;
            this.skinComboBox_SupplierID.Size = new System.Drawing.Size(167, 28);
            this.skinComboBox_SupplierID.TabIndex = 161;
            this.skinComboBox_SupplierID.Title = null;
            // 
            // FilterCostumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 199);
            this.Controls.Add(this.colorComboBox1);
            this.Controls.Add(this.skinLabel14);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel11);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.baseButtonCancel);
            this.Controls.Add(this.BaseButtonSave);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinComboBoxBigClass);
            this.Controls.Add(this.skinLabel10);
            this.Controls.Add(this.skinComboBox_Year);
            this.Controls.Add(this.skinComboBox_Season);
            this.Controls.Add(this.skinComboBox_Brand);
            this.Controls.Add(this.skinLabel12);
            this.Controls.Add(this.skinComboBox_SupplierID);
            this.Controls.Add(this.skinTextBox_ID);
            this.Controls.Add(this.skinTextBox_Name);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterCostumeForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "条件筛选";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private Common.Components.BaseButton BaseButtonSave;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CostumeClassSelector skinComboBoxBigClass;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private YearComboBox skinComboBox_Year;
        private SeasonComboBox skinComboBox_Season;
        private BrandComboBox skinComboBox_Brand;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private SupllierComboBox skinComboBox_SupplierID;
        private Common.TextBox skinTextBox_ID;
        private Common.TextBox skinTextBox_Name;
        private Common.Components.BaseButton baseButtonCancel;
        private System.Windows.Forms.BindingSource costumeStoreBindingSource;
        private ColorComboBox colorComboBox1;
        private CCWin.SkinControl.SkinLabel skinLabel14;
    }
}