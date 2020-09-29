using JGNet.Common;
using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class PurchaseOrderCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderCtrl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costumeStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel6 = new System.Windows.Forms.Panel();
            this.baseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton2 = new JGNet.Common.Components.BaseButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoundDetailBrandIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.SumCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.outboundDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel3 = new System.Windows.Forms.Panel();
            this.skinCheckBoxPrintBarcode = new CCWin.SkinControl.SkinCheckBox();
            this.numericTextBoxMoney = new JGNet.Common.NumericTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonPick = new JGNet.Common.Components.BaseButton();
            this.baseButtonHang = new JGNet.Common.Components.BaseButton();
            this.skinCheckBoxPrint = new CCWin.SkinControl.SkinCheckBox();
            this.BaseButtonConfirm = new JGNet.Common.Components.BaseButton();
            this.skinTextBox_Remarks = new JGNet.Common.TextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonDownTemplate = new JGNet.Common.Components.DownTemplateButton();
            this.skinComboBoxShopID = new JGNet.Common.ShopComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonImport = new JGNet.Common.Components.BaseButton();
            this.skinComboBox_SupplierID = new JGNet.Common.Components.SupllierComboBox();
            this.skinLabelCostume = new System.Windows.Forms.Label();
            this.costumeFromSupplierTextBox1 = new JGNet.Common.CostumeTextBox();
            this.imageHelp1 = new JGNet.Common.Components.ImageHelp();
            this.skinTextBox_OrderID = new CCWin.SkinControl.SkinLabel();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumCostMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).BeginInit();
            this.skinPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).BeginInit();
            this.skinPanel3.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 37);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinPanel6);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinPanel3);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1109, 572);
            this.skinSplitContainer1.SplitterDistance = 206;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 1;
            this.skinSplitContainer1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.costumeNameDataGridViewTextBoxColumn,
            this.BrandName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn44,
            this.sumCountDataGridViewTextBoxColumn,
            this.SumCostMoney,
            this.Column4});
            this.dataGridView1.DataSource = this.costumeStoreBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 165);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // costumeStoreBindingSource
            // 
            this.costumeStoreBindingSource.DataSource = typeof(JGNet.CostumeStore);
            // 
            // skinPanel6
            // 
            this.skinPanel6.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel6.Controls.Add(this.baseButton3);
            this.skinPanel6.Controls.Add(this.skinLabel6);
            this.skinPanel6.Controls.Add(this.BaseButton2);
            this.skinPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel6.Location = new System.Drawing.Point(0, 165);
            this.skinPanel6.Name = "skinPanel6";
            this.skinPanel6.Size = new System.Drawing.Size(1109, 41);
            this.skinPanel6.TabIndex = 3;
            // 
            // baseButton3
            // 
            this.baseButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton3.BackColor = System.Drawing.Color.Transparent;
            this.baseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButton3.Location = new System.Drawing.Point(950, 3);
            this.baseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton3.Name = "baseButton3";
            this.baseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton3.Size = new System.Drawing.Size(75, 32);
            this.baseButton3.TabIndex = 12;
            this.baseButton3.Text = "清空";
            this.baseButton3.UseVisualStyleBackColor = false;
            this.baseButton3.Click += new System.EventHandler(this.baseButton3_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.Red;
            this.skinLabel6.Location = new System.Drawing.Point(3, 11);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(200, 17);
            this.skinLabel6.TabIndex = 11;
            this.skinLabel6.Text = "下表的折扣、成本价和数量可以修改";
            this.skinLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BaseButton2
            // 
            this.BaseButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton2.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BaseButton2.Location = new System.Drawing.Point(1031, 3);
            this.BaseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton2.Name = "BaseButton2";
            this.BaseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton2.Size = new System.Drawing.Size(75, 32);
            this.BaseButton2.TabIndex = 5;
            this.BaseButton2.Text = "添加(F3)";
            this.BaseButton2.UseVisualStyleBackColor = false;
            this.BaseButton2.Click += new System.EventHandler(this.BaseButton_Add_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.Column1,
            this.BoundDetailBrandIDDataGridViewTextBoxColumn,
            this.Year,
            this.Season,
            this.colorNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.SalePrice,
            this.Discount,
            this.CostPrice,
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
            this.SumCount,
            this.SumCost,
            this.dataGridViewTextBoxColumn14,
            this.SumMoney,
            this.Comment,
            this.Column2});
            this.dataGridView2.DataSource = this.outboundDetailBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1109, 317);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValidated);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "CostumeName";
            this.Column1.HeaderText = "商品名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // BoundDetailBrandIDDataGridViewTextBoxColumn
            // 
            this.BoundDetailBrandIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BoundDetailBrandIDDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.BoundDetailBrandIDDataGridViewTextBoxColumn.HeaderText = "品牌";
            this.BoundDetailBrandIDDataGridViewTextBoxColumn.Name = "BoundDetailBrandIDDataGridViewTextBoxColumn";
            this.BoundDetailBrandIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.BoundDetailBrandIDDataGridViewTextBoxColumn.Width = 54;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "年份";
            this.Year.Name = "Year";
            this.Year.Width = 54;
            // 
            // Season
            // 
            this.Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Season.DataPropertyName = "Season";
            this.Season.HeaderText = "季节";
            this.Season.Name = "Season";
            this.Season.Width = 54;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 54;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "吊牌价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 66;
            // 
            // SalePrice
            // 
            this.SalePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "售价";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Width = 54;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.Name = "Discount";
            this.Discount.Width = 54;
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "成本价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Width = 66;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "F";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.Width = 40;
            // 
            // xSDataGridViewTextBoxColumn
            // 
            this.xSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xSDataGridViewTextBoxColumn.DataPropertyName = "XS";
            this.xSDataGridViewTextBoxColumn.HeaderText = "XS";
            this.xSDataGridViewTextBoxColumn.Name = "xSDataGridViewTextBoxColumn";
            this.xSDataGridViewTextBoxColumn.Width = 40;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 40;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.Width = 40;
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            this.lDataGridViewTextBoxColumn.Width = 40;
            // 
            // xLDataGridViewTextBoxColumn
            // 
            this.xLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xLDataGridViewTextBoxColumn.DataPropertyName = "XL";
            this.xLDataGridViewTextBoxColumn.HeaderText = "XL";
            this.xLDataGridViewTextBoxColumn.Name = "xLDataGridViewTextBoxColumn";
            this.xLDataGridViewTextBoxColumn.Width = 40;
            // 
            // xL2DataGridViewTextBoxColumn
            // 
            this.xL2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL2DataGridViewTextBoxColumn.DataPropertyName = "XL2";
            this.xL2DataGridViewTextBoxColumn.HeaderText = "2XL";
            this.xL2DataGridViewTextBoxColumn.Name = "xL2DataGridViewTextBoxColumn";
            this.xL2DataGridViewTextBoxColumn.Width = 40;
            // 
            // xL3DataGridViewTextBoxColumn
            // 
            this.xL3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL3DataGridViewTextBoxColumn.DataPropertyName = "XL3";
            this.xL3DataGridViewTextBoxColumn.HeaderText = "3XL";
            this.xL3DataGridViewTextBoxColumn.Name = "xL3DataGridViewTextBoxColumn";
            this.xL3DataGridViewTextBoxColumn.Width = 40;
            // 
            // xL4DataGridViewTextBoxColumn
            // 
            this.xL4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL4DataGridViewTextBoxColumn.DataPropertyName = "XL4";
            this.xL4DataGridViewTextBoxColumn.HeaderText = "4XL";
            this.xL4DataGridViewTextBoxColumn.Name = "xL4DataGridViewTextBoxColumn";
            this.xL4DataGridViewTextBoxColumn.Width = 40;
            // 
            // xL5DataGridViewTextBoxColumn
            // 
            this.xL5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL5DataGridViewTextBoxColumn.DataPropertyName = "XL5";
            this.xL5DataGridViewTextBoxColumn.HeaderText = "5XL";
            this.xL5DataGridViewTextBoxColumn.Name = "xL5DataGridViewTextBoxColumn";
            this.xL5DataGridViewTextBoxColumn.Width = 40;
            // 
            // xL6DataGridViewTextBoxColumn
            // 
            this.xL6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL6DataGridViewTextBoxColumn.DataPropertyName = "XL6";
            this.xL6DataGridViewTextBoxColumn.HeaderText = "6XL";
            this.xL6DataGridViewTextBoxColumn.Name = "xL6DataGridViewTextBoxColumn";
            this.xL6DataGridViewTextBoxColumn.Width = 40;
            // 
            // SumCount
            // 
            this.SumCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumCount.DataPropertyName = "SumCount";
            this.SumCount.HeaderText = "数量";
            this.SumCount.Name = "SumCount";
            this.SumCount.ReadOnly = true;
            this.SumCount.Width = 40;
            // 
            // SumCost
            // 
            this.SumCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumCost.DataPropertyName = "SumCost";
            this.SumCost.HeaderText = "总成本";
            this.SumCost.Name = "SumCost";
            this.SumCost.Width = 66;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SumCost";
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn14.HeaderText = "总成本(取整)";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 10;
            // 
            // SumMoney
            // 
            this.SumMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumMoney.DataPropertyName = "SumMoney";
            this.SumMoney.HeaderText = "总金额";
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.ReadOnly = true;
            this.SumMoney.Width = 66;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "备注";
            this.Comment.Name = "Comment";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "删除";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 50;
            // 
            // outboundDetailBindingSource
            // 
            this.outboundDetailBindingSource.DataSource = typeof(JGNet.BoundDetail);
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.skinCheckBoxPrintBarcode);
            this.skinPanel3.Controls.Add(this.numericTextBoxMoney);
            this.skinPanel3.Controls.Add(this.skinLabel5);
            this.skinPanel3.Controls.Add(this.baseButtonPick);
            this.skinPanel3.Controls.Add(this.baseButtonHang);
            this.skinPanel3.Controls.Add(this.skinCheckBoxPrint);
            this.skinPanel3.Controls.Add(this.BaseButtonConfirm);
            this.skinPanel3.Controls.Add(this.skinTextBox_Remarks);
            this.skinPanel3.Controls.Add(this.skinLabel2);
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel3.Location = new System.Drawing.Point(0, 317);
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.Size = new System.Drawing.Size(1109, 41);
            this.skinPanel3.TabIndex = 5;
            // 
            // skinCheckBoxPrintBarcode
            // 
            this.skinCheckBoxPrintBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinCheckBoxPrintBarcode.AutoSize = true;
            this.skinCheckBoxPrintBarcode.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxPrintBarcode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxPrintBarcode.DownBack = null;
            this.skinCheckBoxPrintBarcode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxPrintBarcode.Location = new System.Drawing.Point(731, 13);
            this.skinCheckBoxPrintBarcode.MouseBack = null;
            this.skinCheckBoxPrintBarcode.Name = "skinCheckBoxPrintBarcode";
            this.skinCheckBoxPrintBarcode.NormlBack = null;
            this.skinCheckBoxPrintBarcode.SelectedDownBack = null;
            this.skinCheckBoxPrintBarcode.SelectedMouseBack = null;
            this.skinCheckBoxPrintBarcode.SelectedNormlBack = null;
            this.skinCheckBoxPrintBarcode.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBoxPrintBarcode.TabIndex = 29;
            this.skinCheckBoxPrintBarcode.Text = "打印条码";
            this.skinCheckBoxPrintBarcode.UseVisualStyleBackColor = false;
            // 
            // numericTextBoxMoney
            // 
            this.numericTextBoxMoney.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBoxMoney.DecimalPlaces = 0;
            this.numericTextBoxMoney.DownBack = null;
            this.numericTextBoxMoney.Icon = null;
            this.numericTextBoxMoney.IconIsButton = false;
            this.numericTextBoxMoney.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxMoney.IsPasswordChat = '\0';
            this.numericTextBoxMoney.IsSystemPasswordChar = false;
            this.numericTextBoxMoney.Lines = new string[0];
            this.numericTextBoxMoney.Location = new System.Drawing.Point(440, 9);
            this.numericTextBoxMoney.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBoxMoney.MaxLength = 29;
            this.numericTextBoxMoney.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBoxMoney.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBoxMoney.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxMoney.MouseBack = null;
            this.numericTextBoxMoney.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxMoney.Multiline = false;
            this.numericTextBoxMoney.Name = "numericTextBoxMoney";
            this.numericTextBoxMoney.NormlBack = null;
            this.numericTextBoxMoney.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBoxMoney.ReadOnly = false;
            this.numericTextBoxMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBoxMoney.ShowZero = false;
            this.numericTextBoxMoney.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.numericTextBoxMoney.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTextBoxMoney.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTextBoxMoney.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTextBoxMoney.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTextBoxMoney.SkinTxt.MaxLength = 29;
            this.numericTextBoxMoney.SkinTxt.Name = "BaseText";
            this.numericTextBoxMoney.SkinTxt.Size = new System.Drawing.Size(120, 18);
            this.numericTextBoxMoney.SkinTxt.TabIndex = 0;
            this.numericTextBoxMoney.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxMoney.SkinTxt.WaterText = "";
            this.numericTextBoxMoney.TabIndex = 28;
            this.numericTextBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBoxMoney.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxMoney.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxMoney.WaterText = "";
            this.numericTextBoxMoney.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(365, 15);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(68, 17);
            this.skinLabel5.TabIndex = 27;
            this.skinLabel5.Text = "付款金额：";
            // 
            // baseButtonPick
            // 
            this.baseButtonPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonPick.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonPick.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonPick.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonPick.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonPick.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonPick.Location = new System.Drawing.Point(950, 6);
            this.baseButtonPick.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonPick.Name = "baseButtonPick";
            this.baseButtonPick.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonPick.Size = new System.Drawing.Size(75, 32);
            this.baseButtonPick.TabIndex = 26;
            this.baseButtonPick.Text = "提单";
            this.baseButtonPick.UseVisualStyleBackColor = false;
            this.baseButtonPick.Click += new System.EventHandler(this.baseButtonPick_Click);
            // 
            // baseButtonHang
            // 
            this.baseButtonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonHang.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonHang.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonHang.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonHang.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonHang.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonHang.Location = new System.Drawing.Point(869, 6);
            this.baseButtonHang.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonHang.Name = "baseButtonHang";
            this.baseButtonHang.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonHang.Size = new System.Drawing.Size(75, 32);
            this.baseButtonHang.TabIndex = 25;
            this.baseButtonHang.Text = "挂单";
            this.baseButtonHang.UseVisualStyleBackColor = false;
            this.baseButtonHang.Click += new System.EventHandler(this.baseButtonHang_Click);
            // 
            // skinCheckBoxPrint
            // 
            this.skinCheckBoxPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinCheckBoxPrint.AutoSize = true;
            this.skinCheckBoxPrint.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxPrint.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxPrint.DownBack = null;
            this.skinCheckBoxPrint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxPrint.Location = new System.Drawing.Point(812, 13);
            this.skinCheckBoxPrint.MouseBack = null;
            this.skinCheckBoxPrint.Name = "skinCheckBoxPrint";
            this.skinCheckBoxPrint.NormlBack = null;
            this.skinCheckBoxPrint.SelectedDownBack = null;
            this.skinCheckBoxPrint.SelectedMouseBack = null;
            this.skinCheckBoxPrint.SelectedNormlBack = null;
            this.skinCheckBoxPrint.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxPrint.TabIndex = 24;
            this.skinCheckBoxPrint.Text = "打印";
            this.skinCheckBoxPrint.UseVisualStyleBackColor = false;
            this.skinCheckBoxPrint.CheckedChanged += new System.EventHandler(this.skinCheckBoxPrint_CheckedChanged);
            // 
            // BaseButtonConfirm
            // 
            this.BaseButtonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonConfirm.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonConfirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonConfirm.Location = new System.Drawing.Point(1031, 6);
            this.BaseButtonConfirm.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonConfirm.Name = "BaseButtonConfirm";
            this.BaseButtonConfirm.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonConfirm.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonConfirm.TabIndex = 8;
            this.BaseButtonConfirm.Text = "确认(F4)";
            this.BaseButtonConfirm.UseVisualStyleBackColor = false;
            this.BaseButtonConfirm.Click += new System.EventHandler(this.BaseButton_Inbound_Click);
            // 
            // skinTextBox_Remarks
            // 
            this.skinTextBox_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Remarks.DownBack = null;
            this.skinTextBox_Remarks.Icon = null;
            this.skinTextBox_Remarks.IconIsButton = false;
            this.skinTextBox_Remarks.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.IsPasswordChat = '\0';
            this.skinTextBox_Remarks.IsSystemPasswordChar = false;
            this.skinTextBox_Remarks.Lines = new string[0];
            this.skinTextBox_Remarks.Location = new System.Drawing.Point(50, 9);
            this.skinTextBox_Remarks.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Remarks.MaxLength = 32767;
            this.skinTextBox_Remarks.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Remarks.MouseBack = null;
            this.skinTextBox_Remarks.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.Multiline = false;
            this.skinTextBox_Remarks.Name = "skinTextBox_Remarks";
            this.skinTextBox_Remarks.NormlBack = null;
            this.skinTextBox_Remarks.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Remarks.ReadOnly = false;
            this.skinTextBox_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Remarks.Size = new System.Drawing.Size(312, 28);
            // 
            // 
            // 
            this.skinTextBox_Remarks.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Remarks.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Remarks.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Remarks.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Remarks.SkinTxt.Name = "BaseText";
            this.skinTextBox_Remarks.SkinTxt.Size = new System.Drawing.Size(302, 18);
            this.skinTextBox_Remarks.SkinTxt.TabIndex = 0;
            this.skinTextBox_Remarks.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.SkinTxt.WaterText = "";
            this.skinTextBox_Remarks.TabIndex = 7;
            this.skinTextBox_Remarks.TabStop = true;
            this.skinTextBox_Remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Remarks.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.WaterText = "";
            this.skinTextBox_Remarks.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(3, 15);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "备注：";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.baseButtonDownTemplate);
            this.skinPanel1.Controls.Add(this.skinComboBoxShopID);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.baseButtonImport);
            this.skinPanel1.Controls.Add(this.skinComboBox_SupplierID);
            this.skinPanel1.Controls.Add(this.skinLabelCostume);
            this.skinPanel1.Controls.Add(this.costumeFromSupplierTextBox1);
            this.skinPanel1.Controls.Add(this.imageHelp1);
            this.skinPanel1.Controls.Add(this.skinTextBox_OrderID);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1109, 37);
            this.skinPanel1.TabIndex = 0;
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButton1.Location = new System.Drawing.Point(909, 3);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 148;
            this.baseButton1.Text = "导出";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(408, 10);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 147;
            this.skinLabel7.Text = "店铺";
            this.skinLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(7, 10);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 146;
            this.skinLabel4.Text = "单据时间";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(69, 8);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(122, 21);
            this.dateTimePicker_Start.TabIndex = 145;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(194, 10);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(44, 17);
            this.skinLabel3.TabIndex = 7;
            this.skinLabel3.Text = "供应商";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // baseButtonDownTemplate
            // 
            this.baseButtonDownTemplate.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonDownTemplate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonDownTemplate.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.DownBack")));
            this.baseButtonDownTemplate.DownName = "采购进货导入模板.xls";
            this.baseButtonDownTemplate.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonDownTemplate.FileName = "importPurchaseOrder.xls";
            this.baseButtonDownTemplate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonDownTemplate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonDownTemplate.Location = new System.Drawing.Point(748, 3);
            this.baseButtonDownTemplate.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.MouseBack")));
            this.baseButtonDownTemplate.Name = "baseButtonDownTemplate";
            this.baseButtonDownTemplate.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.NormlBack")));
            this.baseButtonDownTemplate.Size = new System.Drawing.Size(75, 32);
            this.baseButtonDownTemplate.TabIndex = 143;
            this.baseButtonDownTemplate.Text = "下载模板";
            this.baseButtonDownTemplate.UseVisualStyleBackColor = false;
            this.baseButtonDownTemplate.Click += new System.EventHandler(this.baseButtonDownTemplate_Click);
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(443, 7);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(113, 22);
            this.skinComboBoxShopID.TabIndex = 2;
            this.skinComboBoxShopID.WaterText = "";
            this.skinComboBoxShopID.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxShopID_SelectedIndexChanged);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(559, 10);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "款号";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // baseButtonImport
            // 
            this.baseButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonImport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonImport.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonImport.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonImport.Location = new System.Drawing.Point(829, 2);
            this.baseButtonImport.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonImport.Name = "baseButtonImport";
            this.baseButtonImport.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonImport.Size = new System.Drawing.Size(75, 32);
            this.baseButtonImport.TabIndex = 5;
            this.baseButtonImport.Text = "导入";
            this.baseButtonImport.UseVisualStyleBackColor = false;
            this.baseButtonImport.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // skinComboBox_SupplierID
            // 
            this.skinComboBox_SupplierID.AutoSize = true;
            this.skinComboBox_SupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_SupplierID.EnabledSupplier = true;
            this.skinComboBox_SupplierID.HideAll = true;
            this.skinComboBox_SupplierID.Location = new System.Drawing.Point(241, 7);
            this.skinComboBox_SupplierID.Name = "skinComboBox_SupplierID";
            this.skinComboBox_SupplierID.SelectedItem = null;
            this.skinComboBox_SupplierID.SelectedValue = null;
            this.skinComboBox_SupplierID.ShowAdd = true;
            this.skinComboBox_SupplierID.Size = new System.Drawing.Size(175, 26);
            this.skinComboBox_SupplierID.TabIndex = 0;
            this.skinComboBox_SupplierID.Title = null;
            // 
            // skinLabelCostume
            // 
            this.skinLabelCostume.AutoSize = true;
            this.skinLabelCostume.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelCostume.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelCostume.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.skinLabelCostume.Location = new System.Drawing.Point(715, 5);
            this.skinLabelCostume.Margin = new System.Windows.Forms.Padding(0);
            this.skinLabelCostume.Name = "skinLabelCostume";
            this.skinLabelCostume.Size = new System.Drawing.Size(26, 26);
            this.skinLabelCostume.TabIndex = 142;
            this.skinLabelCostume.Text = "+";
            this.skinLabelCostume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.skinLabelCostume.Click += new System.EventHandler(this.skinLabelCostume_Click);
            // 
            // costumeFromSupplierTextBox1
            // 
            this.costumeFromSupplierTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.costumeFromSupplierTextBox1.DownBack = null;
            this.costumeFromSupplierTextBox1.FilterValid = true;
            this.costumeFromSupplierTextBox1.Icon = null;
            this.costumeFromSupplierTextBox1.IconIsButton = false;
            this.costumeFromSupplierTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeFromSupplierTextBox1.IsPasswordChat = '\0';
            this.costumeFromSupplierTextBox1.IsSystemPasswordChar = false;
            this.costumeFromSupplierTextBox1.Lines = new string[0];
            this.costumeFromSupplierTextBox1.Location = new System.Drawing.Point(590, 5);
            this.costumeFromSupplierTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.costumeFromSupplierTextBox1.MaxLength = 32767;
            this.costumeFromSupplierTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.costumeFromSupplierTextBox1.MouseBack = null;
            this.costumeFromSupplierTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeFromSupplierTextBox1.Multiline = false;
            this.costumeFromSupplierTextBox1.Name = "costumeFromSupplierTextBox1";
            this.costumeFromSupplierTextBox1.NormlBack = null;
            this.costumeFromSupplierTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.costumeFromSupplierTextBox1.ReadOnly = false;
            this.costumeFromSupplierTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.costumeFromSupplierTextBox1.Size = new System.Drawing.Size(124, 28);
            // 
            // 
            // 
            this.costumeFromSupplierTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costumeFromSupplierTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costumeFromSupplierTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.costumeFromSupplierTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.costumeFromSupplierTextBox1.SkinTxt.Name = "BaseText";
            this.costumeFromSupplierTextBox1.SkinTxt.Size = new System.Drawing.Size(114, 18);
            this.costumeFromSupplierTextBox1.SkinTxt.TabIndex = 0;
            this.costumeFromSupplierTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeFromSupplierTextBox1.SkinTxt.WaterText = "";
            this.costumeFromSupplierTextBox1.TabIndex = 3;
            this.costumeFromSupplierTextBox1.TabStop = true;
            this.costumeFromSupplierTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.costumeFromSupplierTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeFromSupplierTextBox1.WaterText = "";
            this.costumeFromSupplierTextBox1.WordWrap = true;
            this.costumeFromSupplierTextBox1.CostumeSelected += new CJBasic.Action<JGNet.Costume, bool>(this.costumeFromSupplierTextBox1_CostumeSelected);
            // 
            // imageHelp1
            // 
            this.imageHelp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageHelp1.BackColor = System.Drawing.Color.Transparent;
            this.imageHelp1.Control = this;
            this.imageHelp1.Image = global::JGNet.Manage.Properties.Resources.采购进货流程;
            this.imageHelp1.Location = new System.Drawing.Point(1084, 6);
            this.imageHelp1.Name = "imageHelp1";
            this.imageHelp1.Size = new System.Drawing.Size(24, 24);
            this.imageHelp1.TabIndex = 14;
            // 
            // skinTextBox_OrderID
            // 
            this.skinTextBox_OrderID.AutoSize = true;
            this.skinTextBox_OrderID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_OrderID.BorderColor = System.Drawing.Color.White;
            this.skinTextBox_OrderID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBox_OrderID.Location = new System.Drawing.Point(374, 10);
            this.skinTextBox_OrderID.Name = "skinTextBox_OrderID";
            this.skinTextBox_OrderID.Size = new System.Drawing.Size(44, 17);
            this.skinTextBox_OrderID.TabIndex = 7;
            this.skinTextBox_OrderID.Text = "收货方";
            this.skinTextBox_OrderID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "XL6";
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn16.HeaderText = "6XL";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 48;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "SumCount";
            this.dataGridViewTextBoxColumn17.HeaderText = "数量";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 54;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "SumCostMoney";
            this.dataGridViewTextBoxColumn18.HeaderText = "总成本";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 66;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn19.HeaderText = "备注";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 54;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "操作";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 54;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "SupplierName";
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn21.HeaderText = "供应商";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 66;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "CostumeID";
            this.dataGridViewTextBoxColumn22.HeaderText = "款号";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 54;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "CostumeName";
            this.dataGridViewTextBoxColumn23.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "BrandName";
            this.dataGridViewTextBoxColumn24.HeaderText = "品牌";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ColorName";
            this.dataGridViewTextBoxColumn25.HeaderText = "颜色";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 54;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn26.HeaderText = "吊牌价";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 66;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn27.HeaderText = "折扣";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 54;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "CostPrice";
            this.dataGridViewTextBoxColumn28.HeaderText = "成本价";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 66;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "F";
            this.dataGridViewTextBoxColumn29.HeaderText = "F";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 36;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "XS";
            this.dataGridViewTextBoxColumn30.HeaderText = "XS";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 42;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn31.HeaderText = "S";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 36;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "M";
            this.dataGridViewTextBoxColumn32.HeaderText = "M";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 36;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "L";
            this.dataGridViewTextBoxColumn33.HeaderText = "L";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 36;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "XL";
            this.dataGridViewTextBoxColumn34.HeaderText = "XL";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 42;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "XL2";
            this.dataGridViewTextBoxColumn35.HeaderText = "2XL";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 48;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "XL3";
            this.dataGridViewTextBoxColumn36.HeaderText = "3XL";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 48;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "XL4";
            this.dataGridViewTextBoxColumn37.HeaderText = "4XL";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 48;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "XL5";
            this.dataGridViewTextBoxColumn38.HeaderText = "5XL";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Width = 48;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "XL6";
            this.dataGridViewTextBoxColumn39.HeaderText = "6XL";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Width = 48;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "SumCount";
            this.dataGridViewTextBoxColumn40.HeaderText = "数量";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 54;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "SumCost";
            this.dataGridViewTextBoxColumn41.HeaderText = "总成本";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 66;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "SumMoney";
            this.dataGridViewTextBoxColumn42.HeaderText = "总金额";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Width = 66;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn43.HeaderText = "备注";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.Width = 54;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewLinkColumn1.HeaderText = "删除";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Text = "删除";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CostumeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "款号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "品牌";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ColorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "颜色";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "吊牌价";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CostPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "成本价";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "F";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn15.HeaderText = "F";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 36;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "XS";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "XS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 42;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "S";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "S";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 36;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "M";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "M";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 36;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "L";
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn8.HeaderText = "L";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 36;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "XL";
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn9.HeaderText = "XL";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 42;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "XL2";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn10.HeaderText = "2XL";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 48;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "XL3";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn11.HeaderText = "3XL";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 48;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "XL4";
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn12.HeaderText = "4XL";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 48;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "XL5";
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn13.HeaderText = "5XL";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 48;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn44.DataPropertyName = "XL6";
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            this.dataGridViewTextBoxColumn44.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn44.HeaderText = "6XL";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.Width = 48;
            // 
            // sumCountDataGridViewTextBoxColumn
            // 
            this.sumCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sumCountDataGridViewTextBoxColumn.DataPropertyName = "SumCount";
            this.sumCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.sumCountDataGridViewTextBoxColumn.Name = "sumCountDataGridViewTextBoxColumn";
            this.sumCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumCountDataGridViewTextBoxColumn.Width = 54;
            // 
            // SumCostMoney
            // 
            this.SumCostMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumCostMoney.DataPropertyName = "SumCostMoney";
            this.SumCostMoney.HeaderText = "总成本";
            this.SumCostMoney.Name = "SumCostMoney";
            this.SumCostMoney.ReadOnly = true;
            this.SumCostMoney.Width = 66;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Remarks";
            this.Column4.HeaderText = "备注";
            this.Column4.Name = "Column4";
            this.Column4.Width = 54;
            // 
            // PurchaseOrderCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "PurchaseOrderCtrl";
            this.Size = new System.Drawing.Size(1109, 609);
            this.Load += new System.EventHandler(this.PurchaseOrderCtrl_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).EndInit();
            this.skinPanel6.ResumeLayout(false);
            this.skinPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).EndInit();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.BindingSource outboundDetailBindingSource;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private  JGNet.Common.TextBox skinTextBox_Remarks;
        private System.Windows.Forms.Panel skinPanel3;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.BindingSource costumeStoreBindingSource;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Panel skinPanel6;
        private DataGridView dataGridView2;
        private SupllierComboBox skinComboBox_SupplierID;
        private CCWin.SkinControl.SkinLabel skinLabel3; 
        private CostumeTextBox costumeFromSupplierTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outboundOrderIDDataGridViewTextBoxColumn;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private ImageHelp imageHelp1;
        private Common.Components.BaseButton BaseButton2;
        private Common.Components.BaseButton BaseButtonConfirm;
        private Label skinLabelCostume; 
        private ShopComboBox skinComboBoxShopID;
        private CCWin.SkinControl.SkinLabel skinTextBox_OrderID;
        private BaseButton baseButtonImport;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxPrint;
        private DownTemplateButton baseButtonDownTemplate;
        private DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private BaseButton baseButton3;
        private BaseButton baseButtonPick;
        private BaseButton baseButtonHang;
        private NumericTextBox numericTextBoxMoney;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private DataGridViewLinkColumn dataGridViewLinkColumn1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxPrintBarcode;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private BaseButton baseButton1;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn BoundDetailBrandIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Season;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn CostPrice;
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
        private DataGridViewTextBoxColumn SumCount;
        private DataGridViewTextBoxColumn SumCost;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn SumMoney;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewLinkColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn sumCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SumCostMoney;
        private DataGridViewTextBoxColumn Column4;
    }
}
