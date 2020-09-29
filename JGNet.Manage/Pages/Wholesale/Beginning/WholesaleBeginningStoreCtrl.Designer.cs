using JGNet.Common;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class WholesaleBeginningStoreCtrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WholesaleBeginningStoreCtrl));
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBox_PfCustomer = new JGNet.Common.PfCustomerComboBox();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.costumeTextBox1 = new JGNet.Common.CostumeTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Brand = new JGNet.Manage.BrandComboBox();
            this.baseButtonSearch = new JGNet.Common.Components.BaseButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.baseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.baseButtonSave = new JGNet.Common.Components.BaseButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cashRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PfPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BigClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmallClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubSmallClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeGroupShowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBox_PfCustomer);
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.costumeTextBox1);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.skinComboBox_Brand);
            this.skinPanel1.Controls.Add(this.baseButtonSearch);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.baseButton3);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 40);
            this.skinPanel1.TabIndex = 4;
            // 
            // skinComboBox_PfCustomer
            // 
            this.skinComboBox_PfCustomer.CheckPfCustomer = false;
            this.skinComboBox_PfCustomer.curSelectStr = null;
            this.skinComboBox_PfCustomer.CustomerTypeValue = -1;
            this.skinComboBox_PfCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_PfCustomer.FormattingEnabled = true;
            this.skinComboBox_PfCustomer.HideEmpty = false;
            this.skinComboBox_PfCustomer.Location = new System.Drawing.Point(53, 8);
            this.skinComboBox_PfCustomer.Name = "skinComboBox_PfCustomer";
            this.skinComboBox_PfCustomer.Size = new System.Drawing.Size(128, 22);
            this.skinComboBox_PfCustomer.TabIndex = 216;
            this.skinComboBox_PfCustomer.WaterText = "";
            this.skinComboBox_PfCustomer.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_PfCustomer_SelectedIndexChanged);
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(963, 4);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 215;
            this.baseButton1.Text = "导出";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // costumeTextBox1
            // 
            this.costumeTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.costumeTextBox1.DownBack = null;
            this.costumeTextBox1.FilterValid = true;
            this.costumeTextBox1.Icon = null;
            this.costumeTextBox1.IconIsButton = false;
            this.costumeTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeTextBox1.IsPasswordChat = '\0';
            this.costumeTextBox1.IsSystemPasswordChar = false;
            this.costumeTextBox1.Lines = new string[0];
            this.costumeTextBox1.Location = new System.Drawing.Point(228, 6);
            this.costumeTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.costumeTextBox1.MaxLength = 32767;
            this.costumeTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.costumeTextBox1.MouseBack = null;
            this.costumeTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeTextBox1.Multiline = false;
            this.costumeTextBox1.Name = "costumeTextBox1";
            this.costumeTextBox1.NormlBack = null;
            this.costumeTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.costumeTextBox1.ReadOnly = false;
            this.costumeTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.costumeTextBox1.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.costumeTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costumeTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costumeTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.costumeTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.costumeTextBox1.SkinTxt.Name = "BaseText";
            this.costumeTextBox1.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.costumeTextBox1.SkinTxt.TabIndex = 0;
            this.costumeTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeTextBox1.SkinTxt.WaterText = "";
            this.costumeTextBox1.TabIndex = 214;
            this.costumeTextBox1.TabStop = true;
            this.costumeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.costumeTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeTextBox1.WaterText = "";
            this.costumeTextBox1.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(193, 11);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 213;
            this.skinLabel1.Text = "款号";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(388, 11);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 212;
            this.skinLabel7.Text = "品牌";
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.skinComboBox_Brand.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(423, 6);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectedIndexChanged = null;
            this.skinComboBox_Brand.SelectedItem = ((JGNet.Brand)(resources.GetObject("skinComboBox_Brand.SelectedItem")));
            this.skinComboBox_Brand.SelectedValue = -1;
            this.skinComboBox_Brand.ShowAdd = false;
            this.skinComboBox_Brand.ShowAll = true;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(191, 26);
            this.skinComboBox_Brand.TabIndex = 211;
            // 
            // baseButtonSearch
            // 
            this.baseButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSearch.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonSearch.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSearch.Location = new System.Drawing.Point(801, 4);
            this.baseButtonSearch.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonSearch.Name = "baseButtonSearch";
            this.baseButtonSearch.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonSearch.Size = new System.Drawing.Size(75, 32);
            this.baseButtonSearch.TabIndex = 209;
            this.baseButtonSearch.Text = "查询";
            this.baseButtonSearch.UseVisualStyleBackColor = false;
            this.baseButtonSearch.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(15, 11);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 145;
            this.skinLabel6.Text = "客户";
            // 
            // baseButton3
            // 
            this.baseButton3.BackColor = System.Drawing.Color.Transparent;
            this.baseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton3.Location = new System.Drawing.Point(882, 4);
            this.baseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton3.Name = "baseButton3";
            this.baseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton3.Size = new System.Drawing.Size(75, 32);
            this.baseButton3.TabIndex = 4;
            this.baseButton3.Text = "添加";
            this.baseButton3.UseVisualStyleBackColor = false;
            this.baseButton3.Click += new System.EventHandler(this.BaseButtonSaveAccount_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Red;
            this.skinLabel2.Location = new System.Drawing.Point(3, 14);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(272, 17);
            this.skinLabel2.TabIndex = 147;
            this.skinLabel2.Text = "期初库存录完后，请前往商品档案完善商品属性。";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.skinLabel2);
            this.panel1.Controls.Add(this.baseButtonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 41);
            this.panel1.TabIndex = 7;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSave.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonSave.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSave.Location = new System.Drawing.Point(1082, 6);
            this.baseButtonSave.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonSave.Name = "baseButtonSave";
            this.baseButtonSave.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonSave.Size = new System.Drawing.Size(75, 32);
            this.baseButtonSave.TabIndex = 179;
            this.baseButtonSave.Text = "保存";
            this.baseButtonSave.UseVisualStyleBackColor = false;
            this.baseButtonSave.Click += new System.EventHandler(this.baseButtonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.costumeNameDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.Price,
            this.PfPrice,
            this.BrandName,
            this.SupplierName,
            this.Year,
            this.Season,
            this.BigClass,
            this.SmallClass,
            this.SubSmallClass,
            this.SizeGroupShowName,
            this.fDataGridViewTextBoxColumn,
            this.xSDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.mDataGridViewTextBoxColumn,
            this.lDataGridViewTextBoxColumn,
            this.xLDataGridViewTextBoxColumn,
            this.xL2DataGridViewTextBoxColumn,
            this.xL3DataGridViewTextBoxColumn,
            this.xL4DataGridViewTextBoxColumn,
            this.xL5DataGridViewTextBoxColumn,
            this.xL6DataGridViewTextBoxColumn,
            this.Column2,
            this.Column1});
            this.dataGridView1.DataSource = this.cashRecordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 569);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // cashRecordBindingSource
            // 
            this.cashRecordBindingSource.DataSource = typeof(JGNet.PfCustomerStore);
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "吊牌价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // PfPrice
            // 
            this.PfPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PfPrice.DataPropertyName = "PfPrice";
            this.PfPrice.HeaderText = "批发价";
            this.PfPrice.Name = "PfPrice";
            this.PfPrice.ReadOnly = true;
            this.PfPrice.Width = 80;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "品牌";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 43;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "供应商";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 80;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "年份";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 43;
            // 
            // Season
            // 
            this.Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Season.DataPropertyName = "Season";
            this.Season.HeaderText = "季节";
            this.Season.Name = "Season";
            this.Season.ReadOnly = true;
            this.Season.Width = 60;
            // 
            // BigClass
            // 
            this.BigClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BigClass.DataPropertyName = "BigClass";
            this.BigClass.HeaderText = "一级类别";
            this.BigClass.Name = "BigClass";
            this.BigClass.ReadOnly = true;
            this.BigClass.Width = 90;
            // 
            // SmallClass
            // 
            this.SmallClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SmallClass.DataPropertyName = "SmallClass";
            this.SmallClass.HeaderText = "二级类别";
            this.SmallClass.Name = "SmallClass";
            this.SmallClass.Width = 90;
            // 
            // SubSmallClass
            // 
            this.SubSmallClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SubSmallClass.DataPropertyName = "SubSmallClass";
            this.SubSmallClass.HeaderText = "三级类别";
            this.SubSmallClass.Name = "SubSmallClass";
            this.SubSmallClass.Width = 90;
            // 
            // SizeGroupShowName
            // 
            this.SizeGroupShowName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SizeGroupShowName.DataPropertyName = "SizeGroupShowName";
            this.SizeGroupShowName.HeaderText = "尺码组名称";
            this.SizeGroupShowName.Name = "SizeGroupShowName";
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "F";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.Width = 42;
            // 
            // xSDataGridViewTextBoxColumn
            // 
            this.xSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xSDataGridViewTextBoxColumn.DataPropertyName = "XS";
            this.xSDataGridViewTextBoxColumn.HeaderText = "XS";
            this.xSDataGridViewTextBoxColumn.Name = "xSDataGridViewTextBoxColumn";
            this.xSDataGridViewTextBoxColumn.Width = 43;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 43;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.Width = 43;
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            this.lDataGridViewTextBoxColumn.Width = 43;
            // 
            // xLDataGridViewTextBoxColumn
            // 
            this.xLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xLDataGridViewTextBoxColumn.DataPropertyName = "XL";
            this.xLDataGridViewTextBoxColumn.HeaderText = "XL";
            this.xLDataGridViewTextBoxColumn.Name = "xLDataGridViewTextBoxColumn";
            this.xLDataGridViewTextBoxColumn.Width = 43;
            // 
            // xL2DataGridViewTextBoxColumn
            // 
            this.xL2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL2DataGridViewTextBoxColumn.DataPropertyName = "XL2";
            this.xL2DataGridViewTextBoxColumn.HeaderText = "XL2";
            this.xL2DataGridViewTextBoxColumn.Name = "xL2DataGridViewTextBoxColumn";
            this.xL2DataGridViewTextBoxColumn.Width = 43;
            // 
            // xL3DataGridViewTextBoxColumn
            // 
            this.xL3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL3DataGridViewTextBoxColumn.DataPropertyName = "XL3";
            this.xL3DataGridViewTextBoxColumn.HeaderText = "XL3";
            this.xL3DataGridViewTextBoxColumn.Name = "xL3DataGridViewTextBoxColumn";
            this.xL3DataGridViewTextBoxColumn.Width = 43;
            // 
            // xL4DataGridViewTextBoxColumn
            // 
            this.xL4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL4DataGridViewTextBoxColumn.DataPropertyName = "XL4";
            this.xL4DataGridViewTextBoxColumn.HeaderText = "XL4";
            this.xL4DataGridViewTextBoxColumn.Name = "xL4DataGridViewTextBoxColumn";
            this.xL4DataGridViewTextBoxColumn.Width = 43;
            // 
            // xL5DataGridViewTextBoxColumn
            // 
            this.xL5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL5DataGridViewTextBoxColumn.DataPropertyName = "XL5";
            this.xL5DataGridViewTextBoxColumn.HeaderText = "XL5";
            this.xL5DataGridViewTextBoxColumn.Name = "xL5DataGridViewTextBoxColumn";
            this.xL5DataGridViewTextBoxColumn.Width = 43;
            // 
            // xL6DataGridViewTextBoxColumn
            // 
            this.xL6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL6DataGridViewTextBoxColumn.DataPropertyName = "XL6";
            this.xL6DataGridViewTextBoxColumn.HeaderText = "XL6";
            this.xL6DataGridViewTextBoxColumn.Name = "xL6DataGridViewTextBoxColumn";
            this.xL6DataGridViewTextBoxColumn.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "CostPrice";
            this.Column2.HeaderText = "编辑";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Text = "编辑";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "SumCount";
            this.Column1.HeaderText = "删除";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 40;
            // 
            // WholesaleBeginningStoreCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "WholesaleBeginningStoreCtrl";
            this.Load += new System.EventHandler(this.SupplierAccountSearchCtrl_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cashRecordBindingSource;
        private System.Windows.Forms.Panel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private Common.Components.BaseButton baseButton3;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Common.Components.BaseButton baseButtonSave;
        private Common.Components.BaseButton baseButtonSearch;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private BrandComboBox skinComboBox_Brand;
        private CostumeTextBox costumeTextBox1;
        private Common.Components.BaseButton baseButton1;
        private PfCustomerComboBox skinComboBox_PfCustomer;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn PfPrice;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Season;
        private DataGridViewTextBoxColumn BigClass;
        private DataGridViewTextBoxColumn SmallClass;
        private DataGridViewTextBoxColumn SubSmallClass;
        private DataGridViewTextBoxColumn SizeGroupShowName;
        private DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL6DataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Column2;
        private DataGridViewLinkColumn Column1;
    }
}
