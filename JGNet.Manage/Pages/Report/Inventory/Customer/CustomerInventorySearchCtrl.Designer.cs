using JGNet.Common;
using JGNet.Core.InteractEntity;
using CJBasic.Widget; 

namespace JGNet.Common
{
    partial class CustomerInventorySearchCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInventorySearchCtrl));
            this.bndingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridView1 = new JGNet.Common.DataMergedView();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinTextBox_costumeID = new JGNet.Common.CostumeTextBox();
            this.skinComboBox_PfCustomer = new JGNet.Common.PfCustomerComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton_search = new JGNet.Common.Components.BaseButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.pfCustomerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.retailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pfCustomerStoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bndingSource)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bndingSource
            // 
            this.bndingSource.DataSource = typeof(JGNet.Core.InteractEntity.PfCustomerInvoicing);
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.CollapsePanel = CCWin.SkinControl.CollapsePanel.Panel2;
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 40);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel2Collapsed = true;
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 610);
            this.skinSplitContainer1.SplitterDistance = 280;
            this.skinSplitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pfCustomerNameDataGridViewTextBoxColumn,
            this.costumeIDDataGridViewTextBoxColumn,
            this.costumeNameDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.sizeNameDataGridViewTextBoxColumn,
            this.deliveryDataGridViewTextBoxColumn,
            this.retailDataGridViewTextBoxColumn,
            this.pfCustomerStoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bndingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("dataGridView1.MergeColumnNames")));
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 610);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.skinTextBox_costumeID);
            this.skinPanel1.Controls.Add(this.skinComboBox_PfCustomer);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.BaseButton_search);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 40);
            this.skinPanel1.TabIndex = 999;
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
            this.baseButton1.TabIndex = 133;
            this.baseButton1.Text = "导出";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // skinTextBox_costumeID
            // 
            this.skinTextBox_costumeID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_costumeID.DownBack = null;
            this.skinTextBox_costumeID.FilterValid = true;
            this.skinTextBox_costumeID.Icon = null;
            this.skinTextBox_costumeID.IconIsButton = false;
            this.skinTextBox_costumeID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_costumeID.IsPasswordChat = '\0';
            this.skinTextBox_costumeID.IsSystemPasswordChar = false;
            this.skinTextBox_costumeID.Lines = new string[0];
            this.skinTextBox_costumeID.Location = new System.Drawing.Point(583, 6);
            this.skinTextBox_costumeID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_costumeID.MaxLength = 32767;
            this.skinTextBox_costumeID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_costumeID.MouseBack = null;
            this.skinTextBox_costumeID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_costumeID.Multiline = false;
            this.skinTextBox_costumeID.Name = "skinTextBox_costumeID";
            this.skinTextBox_costumeID.NormlBack = null;
            this.skinTextBox_costumeID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_costumeID.ReadOnly = false;
            this.skinTextBox_costumeID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_costumeID.Size = new System.Drawing.Size(132, 28);
            // 
            // 
            // 
            this.skinTextBox_costumeID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_costumeID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_costumeID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_costumeID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_costumeID.SkinTxt.Name = "BaseText";
            this.skinTextBox_costumeID.SkinTxt.Size = new System.Drawing.Size(122, 18);
            this.skinTextBox_costumeID.SkinTxt.TabIndex = 0;
            this.skinTextBox_costumeID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_costumeID.SkinTxt.WaterText = "";
            this.skinTextBox_costumeID.TabIndex = 130;
            this.skinTextBox_costumeID.TabStop = true;
            this.skinTextBox_costumeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_costumeID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_costumeID.WaterText = "";
            this.skinTextBox_costumeID.WordWrap = true;
            this.skinTextBox_costumeID.CostumeSelected += new CJBasic.Action<JGNet.Costume, bool>(this.costumeFromSupplierTextBox1_CostumeSelected);
            // 
            // skinComboBox_PfCustomer
            // 
            this.skinComboBox_PfCustomer.CheckPfCustomer = false;
            this.skinComboBox_PfCustomer.curSelectStr = null;
            this.skinComboBox_PfCustomer.CustomerTypeValue = 1;
            this.skinComboBox_PfCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_PfCustomer.FormattingEnabled = true;
            this.skinComboBox_PfCustomer.HideEmpty = false;
            this.skinComboBox_PfCustomer.Location = new System.Drawing.Point(402, 9);
            this.skinComboBox_PfCustomer.Name = "skinComboBox_PfCustomer";
            this.skinComboBox_PfCustomer.Size = new System.Drawing.Size(132, 22);
            this.skinComboBox_PfCustomer.TabIndex = 129;
            this.skinComboBox_PfCustomer.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(548, 12);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 131;
            this.skinLabel1.Text = "款号";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(365, 12);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 132;
            this.skinLabel4.Text = "客户";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // quickDateSelector1
            // 
            this.quickDateSelector1.Arrow = System.Drawing.Color.Black;
            this.quickDateSelector1.Back = System.Drawing.Color.White;
            this.quickDateSelector1.BackRadius = 4;
            this.quickDateSelector1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.quickDateSelector1.Base = System.Drawing.Color.Transparent;
            this.quickDateSelector1.BaseFore = System.Drawing.Color.Black;
            this.quickDateSelector1.BaseForeAnamorphosis = false;
            this.quickDateSelector1.BaseForeAnamorphosisBorder = 4;
            this.quickDateSelector1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.quickDateSelector1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.quickDateSelector1.BaseHoverFore = System.Drawing.Color.White;
            this.quickDateSelector1.BaseItemAnamorphosis = true;
            this.quickDateSelector1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemBorderShow = true;
            this.quickDateSelector1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("quickDateSelector1.BaseItemDown")));
            this.quickDateSelector1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("quickDateSelector1.BaseItemMouse")));
            this.quickDateSelector1.BaseItemNorml = null;
            this.quickDateSelector1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemRadius = 4;
            this.quickDateSelector1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BindTabControl = null;
            this.quickDateSelector1.Dock = System.Windows.Forms.DockStyle.None;
            this.quickDateSelector1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.quickDateSelector1.EndDateTimePicker = this.dateTimePicker_End;
            this.quickDateSelector1.Fore = System.Drawing.Color.Black;
            this.quickDateSelector1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.quickDateSelector1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.quickDateSelector1.HoverFore = System.Drawing.Color.White;
            this.quickDateSelector1.ItemAnamorphosis = true;
            this.quickDateSelector1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemBorderShow = true;
            this.quickDateSelector1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemRadius = 4;
            this.quickDateSelector1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Location = new System.Drawing.Point(330, 8);
            this.quickDateSelector1.Name = "quickDateSelector1";
            this.quickDateSelector1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Size = new System.Drawing.Size(32, 25);
            this.quickDateSelector1.SkinAllColor = true;
            this.quickDateSelector1.StartDateTimePicker = this.dateTimePicker_Start;
            this.quickDateSelector1.TabIndex = 128;
            this.quickDateSelector1.Text = "quickDateSelector1";
            this.quickDateSelector1.TitleAnamorphosis = true;
            this.quickDateSelector1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.quickDateSelector1.TitleRadius = 4;
            this.quickDateSelector1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.PickerValueChanged += new CJBasic.Action<object, System.EventArgs>(this.BaseButton_Search_Click);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(206, 10);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_End.TabIndex = 4;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(41, 10);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // BaseButton_search
            // 
            this.BaseButton_search.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_search.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_search.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_search.Location = new System.Drawing.Point(882, 4);
            this.BaseButton_search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_search.Name = "BaseButton_search";
            this.BaseButton_search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_search.TabIndex = 7;
            this.BaseButton_search.Text = "查询";
            this.BaseButton_search.UseVisualStyleBackColor = false;
            this.BaseButton_search.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(168, 12);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 20;
            this.skinLabel3.Text = "结束";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(3, 12);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 21;
            this.skinLabel2.Text = "开始";
            // 
            // pfCustomerNameDataGridViewTextBoxColumn
            // 
            this.pfCustomerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pfCustomerNameDataGridViewTextBoxColumn.DataPropertyName = "PfCustomerName";
            this.pfCustomerNameDataGridViewTextBoxColumn.HeaderText = "客户";
            this.pfCustomerNameDataGridViewTextBoxColumn.Name = "pfCustomerNameDataGridViewTextBoxColumn";
            this.pfCustomerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pfCustomerNameDataGridViewTextBoxColumn.Width = 380;
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeNameDataGridViewTextBoxColumn
            // 
            this.sizeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeNameDataGridViewTextBoxColumn.DataPropertyName = "SizeName";
            this.sizeNameDataGridViewTextBoxColumn.HeaderText = "尺码";
            this.sizeNameDataGridViewTextBoxColumn.Name = "sizeNameDataGridViewTextBoxColumn";
            this.sizeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDataGridViewTextBoxColumn
            // 
            this.deliveryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deliveryDataGridViewTextBoxColumn.DataPropertyName = "Delivery";
            this.deliveryDataGridViewTextBoxColumn.HeaderText = "发货";
            this.deliveryDataGridViewTextBoxColumn.Name = "deliveryDataGridViewTextBoxColumn";
            this.deliveryDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deliveryDataGridViewTextBoxColumn.Width = 350;
            // 
            // retailDataGridViewTextBoxColumn
            // 
            this.retailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.retailDataGridViewTextBoxColumn.DataPropertyName = "Retail";
            this.retailDataGridViewTextBoxColumn.HeaderText = "销售";
            this.retailDataGridViewTextBoxColumn.Name = "retailDataGridViewTextBoxColumn";
            this.retailDataGridViewTextBoxColumn.ReadOnly = true;
            this.retailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.retailDataGridViewTextBoxColumn.Width = 350;
            // 
            // pfCustomerStoreDataGridViewTextBoxColumn
            // 
            this.pfCustomerStoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pfCustomerStoreDataGridViewTextBoxColumn.DataPropertyName = "PfCustomerStore";
            this.pfCustomerStoreDataGridViewTextBoxColumn.HeaderText = "库存";
            this.pfCustomerStoreDataGridViewTextBoxColumn.Name = "pfCustomerStoreDataGridViewTextBoxColumn";
            this.pfCustomerStoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.pfCustomerStoreDataGridViewTextBoxColumn.Width = 54;
            // 
            // CustomerInventorySearchCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "CustomerInventorySearchCtrl";
            ((System.ComponentModel.ISupportInitialize)(this.bndingSource)).EndInit();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private DataMergedView dataGridView1;
        private System.Windows.Forms.BindingSource bndingSource;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private Common.Components.BaseButton BaseButton_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bigClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkStoreWinCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkStoreWinMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkStoreLostCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkStoreLostMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endMoneyDataGridViewTextBoxColumn;
        private Components.QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CostumeTextBox skinTextBox_costumeID;
        private PfCustomerComboBox skinComboBox_PfCustomer;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private Components.BaseButton baseButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pfCustomerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn deliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn retailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pfCustomerStoreDataGridViewTextBoxColumn;
    }
}
