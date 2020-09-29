using JGNet.Common;
using JGNet.Core.InteractEntity;
using CJBasic.Widget; 

namespace JGNet.Common
{
    partial class CostumeInventorySearchCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumeInventorySearchCtrl));
            this.bndingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridView1 = new JGNet.Common.DataMergedView();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBoxSeason = new JGNet.Manage.Components.SeasonComboBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBoxSizeName = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxColor = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_costumeID = new JGNet.Common.CostumeTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxBigClass = new JGNet.Common.CostumeClassSelector();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton_search = new JGNet.Common.Components.BaseButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Brand = new JGNet.Manage.BrandComboBox();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.inMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pfSalesCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pfSalesMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.retailCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.retailMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.FRetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XSRetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LRetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XLRetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL2RetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL3RetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL4RetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL5RetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL6RetailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailSumCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailSumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XSCostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LCostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XLCostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL2CostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL3CostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL4CostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL5CostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL6CostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeStoreCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeStoreMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bndingSource)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bndingSource
            // 
            this.bndingSource.DataSource = typeof(JGNet.Core.InteractEntity.CostumeInvoicing);
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.CollapsePanel = CCWin.SkinControl.CollapsePanel.Panel2;
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 65);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel2Collapsed = true;
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 585);
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
            this.costumeIDDataGridViewTextBoxColumn,
            this.costumeNameDataGridViewTextBoxColumn,
            this.BrandName,
            this.Season,
            this.colorNameDataGridViewTextBoxColumn,
            this.inCountDataGridViewTextBoxColumn,
            this.inMoneyDataGridViewTextBoxColumn,
            this.pfSalesCountDataGridViewTextBoxColumn,
            this.pfSalesMoneyDataGridViewTextBoxColumn,
            this.retailCountDataGridViewTextBoxColumn,
            this.retailMoneyDataGridViewTextBoxColumn,
            this.FRetailCount,
            this.XSRetailCount,
            this.SRetailCount,
            this.MRetailCount,
            this.LRetailCount,
            this.XLRetailCount,
            this.XL2RetailCount,
            this.XL3RetailCount,
            this.XL4RetailCount,
            this.XL5RetailCount,
            this.XL6RetailCount,
            this.RetailSumCount,
            this.RetailSumMoney,
            this.FCostumeStoreCount,
            this.XSCostumeStoreCount,
            this.SCostumeStoreCount,
            this.MCostumeStoreCount,
            this.LCostumeStoreCount,
            this.XLCostumeStoreCount,
            this.XL2CostumeStoreCount,
            this.XL3CostumeStoreCount,
            this.XL4CostumeStoreCount,
            this.XL5CostumeStoreCount,
            this.XL6CostumeStoreCount,
            this.costumeStoreCountDataGridViewTextBoxColumn,
            this.costumeStoreMoneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bndingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("dataGridView1.MergeColumnNames")));
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 585);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBoxSeason);
            this.skinPanel1.Controls.Add(this.skinLabel8);
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.skinCheckBoxSizeName);
            this.skinPanel1.Controls.Add(this.skinCheckBoxColor);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinTextBox_costumeID);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinComboBoxBigClass);
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.BaseButton_search);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinComboBox_Brand);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 65);
            this.skinPanel1.TabIndex = 999;
            // 
            // skinComboBoxSeason
            // 
            this.skinComboBoxSeason.Location = new System.Drawing.Point(375, 5);
            this.skinComboBoxSeason.Name = "skinComboBoxSeason";
            this.skinComboBoxSeason.SelectedValue = null;
            this.skinComboBoxSeason.ShowAdd = false;
            this.skinComboBoxSeason.ShowAll = true;
            this.skinComboBoxSeason.Size = new System.Drawing.Size(108, 26);
            this.skinComboBoxSeason.TabIndex = 201;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(344, 10);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 202;
            this.skinLabel8.Text = "季节";
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(872, 5);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 178;
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
            this.skinLabel7.Location = new System.Drawing.Point(181, 9);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 177;
            this.skinLabel7.Text = "品牌";
            // 
            // skinCheckBoxSizeName
            // 
            this.skinCheckBoxSizeName.AutoSize = true;
            this.skinCheckBoxSizeName.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxSizeName.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxSizeName.DownBack = null;
            this.skinCheckBoxSizeName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxSizeName.Location = new System.Drawing.Point(734, 9);
            this.skinCheckBoxSizeName.MouseBack = null;
            this.skinCheckBoxSizeName.Name = "skinCheckBoxSizeName";
            this.skinCheckBoxSizeName.NormlBack = null;
            this.skinCheckBoxSizeName.SelectedDownBack = null;
            this.skinCheckBoxSizeName.SelectedMouseBack = null;
            this.skinCheckBoxSizeName.SelectedNormlBack = null;
            this.skinCheckBoxSizeName.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxSizeName.TabIndex = 134;
            this.skinCheckBoxSizeName.Text = "尺码";
            this.skinCheckBoxSizeName.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxColor
            // 
            this.skinCheckBoxColor.AutoSize = true;
            this.skinCheckBoxColor.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxColor.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxColor.DownBack = null;
            this.skinCheckBoxColor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxColor.Location = new System.Drawing.Point(677, 9);
            this.skinCheckBoxColor.MouseBack = null;
            this.skinCheckBoxColor.Name = "skinCheckBoxColor";
            this.skinCheckBoxColor.NormlBack = null;
            this.skinCheckBoxColor.SelectedDownBack = null;
            this.skinCheckBoxColor.SelectedMouseBack = null;
            this.skinCheckBoxColor.SelectedNormlBack = null;
            this.skinCheckBoxColor.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxColor.TabIndex = 134;
            this.skinCheckBoxColor.Text = "颜色";
            this.skinCheckBoxColor.UseVisualStyleBackColor = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 9);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 133;
            this.skinLabel1.Text = "款号";
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
            this.skinTextBox_costumeID.Location = new System.Drawing.Point(38, 3);
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
            this.skinTextBox_costumeID.Size = new System.Drawing.Size(124, 28);
            // 
            // 
            // 
            this.skinTextBox_costumeID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_costumeID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_costumeID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_costumeID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_costumeID.SkinTxt.Name = "BaseText";
            this.skinTextBox_costumeID.SkinTxt.Size = new System.Drawing.Size(114, 18);
            this.skinTextBox_costumeID.SkinTxt.TabIndex = 0;
            this.skinTextBox_costumeID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_costumeID.SkinTxt.WaterText = "";
            this.skinTextBox_costumeID.TabIndex = 132;
            this.skinTextBox_costumeID.TabStop = true;
            this.skinTextBox_costumeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_costumeID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_costumeID.WaterText = "";
            this.skinTextBox_costumeID.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(483, 11);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 130;
            this.skinLabel5.Text = "类别";
            this.skinLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinComboBoxBigClass
            // 
            this.skinComboBoxBigClass.AutoSize = true;
            this.skinComboBoxBigClass.Location = new System.Drawing.Point(518, 5);
            this.skinComboBoxBigClass.Name = "skinComboBoxBigClass";
            this.skinComboBoxBigClass.SelectedValue = ((JGNet.Costume)(resources.GetObject("skinComboBoxBigClass.SelectedValue")));
            this.skinComboBoxBigClass.Size = new System.Drawing.Size(153, 29);
            this.skinComboBoxBigClass.TabIndex = 131;
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
            this.quickDateSelector1.Location = new System.Drawing.Point(343, 36);
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
            this.dateTimePicker_End.Location = new System.Drawing.Point(219, 38);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_End.TabIndex = 4;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(38, 38);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // BaseButton_search
            // 
            this.BaseButton_search.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_search.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_search.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_search.Location = new System.Drawing.Point(791, 5);
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
            this.skinLabel3.Location = new System.Drawing.Point(181, 40);
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
            this.skinLabel2.Location = new System.Drawing.Point(3, 42);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 21;
            this.skinLabel2.Text = "开始";
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.skinComboBox_Brand.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(216, 4);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectedIndexChanged = null;
            this.skinComboBox_Brand.SelectedItem = ((JGNet.Brand)(resources.GetObject("skinComboBox_Brand.SelectedItem")));
            this.skinComboBox_Brand.SelectedValue = -1;
            this.skinComboBox_Brand.ShowAdd = false;
            this.skinComboBox_Brand.ShowAll = true;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(151, 26);
            this.skinComboBox_Brand.TabIndex = 176;
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
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "品牌";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            // 
            // Season
            // 
            this.Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Season.DataPropertyName = "Season";
            this.Season.HeaderText = "季节";
            this.Season.Name = "Season";
            this.Season.ReadOnly = true;
            this.Season.Width = 90;
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
            // inCountDataGridViewTextBoxColumn
            // 
            this.inCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.inCountDataGridViewTextBoxColumn.DataPropertyName = "InCount";
            this.inCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.inCountDataGridViewTextBoxColumn.Name = "inCountDataGridViewTextBoxColumn";
            this.inCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.inCountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inCountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inCountDataGridViewTextBoxColumn.Width = 80;
            // 
            // inMoneyDataGridViewTextBoxColumn
            // 
            this.inMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.inMoneyDataGridViewTextBoxColumn.DataPropertyName = "InMoney";
            this.inMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.inMoneyDataGridViewTextBoxColumn.Name = "inMoneyDataGridViewTextBoxColumn";
            this.inMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.inMoneyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inMoneyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.inMoneyDataGridViewTextBoxColumn.Width = 80;
            // 
            // pfSalesCountDataGridViewTextBoxColumn
            // 
            this.pfSalesCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pfSalesCountDataGridViewTextBoxColumn.DataPropertyName = "PfSalesCount";
            this.pfSalesCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.pfSalesCountDataGridViewTextBoxColumn.Name = "pfSalesCountDataGridViewTextBoxColumn";
            this.pfSalesCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.pfSalesCountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pfSalesCountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pfSalesCountDataGridViewTextBoxColumn.Width = 80;
            // 
            // pfSalesMoneyDataGridViewTextBoxColumn
            // 
            this.pfSalesMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pfSalesMoneyDataGridViewTextBoxColumn.DataPropertyName = "PfSalesMoney";
            this.pfSalesMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.pfSalesMoneyDataGridViewTextBoxColumn.Name = "pfSalesMoneyDataGridViewTextBoxColumn";
            this.pfSalesMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.pfSalesMoneyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pfSalesMoneyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.pfSalesMoneyDataGridViewTextBoxColumn.Width = 80;
            // 
            // retailCountDataGridViewTextBoxColumn
            // 
            this.retailCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.retailCountDataGridViewTextBoxColumn.DataPropertyName = "RetailCount";
            this.retailCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.retailCountDataGridViewTextBoxColumn.Name = "retailCountDataGridViewTextBoxColumn";
            this.retailCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.retailCountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.retailCountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.retailCountDataGridViewTextBoxColumn.Width = 80;
            // 
            // retailMoneyDataGridViewTextBoxColumn
            // 
            this.retailMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.retailMoneyDataGridViewTextBoxColumn.DataPropertyName = "RetailMoney";
            this.retailMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.retailMoneyDataGridViewTextBoxColumn.Name = "retailMoneyDataGridViewTextBoxColumn";
            this.retailMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.retailMoneyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.retailMoneyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.retailMoneyDataGridViewTextBoxColumn.Width = 80;
            // 
            // FRetailCount
            // 
            this.FRetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FRetailCount.DataPropertyName = "FRetailCount";
            this.FRetailCount.HeaderText = "F";
            this.FRetailCount.Name = "FRetailCount";
            this.FRetailCount.ReadOnly = true;
            this.FRetailCount.Width = 36;
            // 
            // XSRetailCount
            // 
            this.XSRetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XSRetailCount.DataPropertyName = "XSRetailCount";
            this.XSRetailCount.HeaderText = "XS";
            this.XSRetailCount.Name = "XSRetailCount";
            this.XSRetailCount.ReadOnly = true;
            this.XSRetailCount.Width = 42;
            // 
            // SRetailCount
            // 
            this.SRetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SRetailCount.DataPropertyName = "SRetailCount";
            this.SRetailCount.HeaderText = "S";
            this.SRetailCount.Name = "SRetailCount";
            this.SRetailCount.ReadOnly = true;
            this.SRetailCount.Width = 36;
            // 
            // MRetailCount
            // 
            this.MRetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MRetailCount.DataPropertyName = "MRetailCount";
            this.MRetailCount.HeaderText = "M";
            this.MRetailCount.Name = "MRetailCount";
            this.MRetailCount.ReadOnly = true;
            this.MRetailCount.Width = 36;
            // 
            // LRetailCount
            // 
            this.LRetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LRetailCount.DataPropertyName = "LRetailCount";
            this.LRetailCount.HeaderText = "L";
            this.LRetailCount.Name = "LRetailCount";
            this.LRetailCount.ReadOnly = true;
            this.LRetailCount.Width = 36;
            // 
            // XLRetailCount
            // 
            this.XLRetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XLRetailCount.DataPropertyName = "XLRetailCount";
            this.XLRetailCount.HeaderText = "XL";
            this.XLRetailCount.Name = "XLRetailCount";
            this.XLRetailCount.ReadOnly = true;
            this.XLRetailCount.Width = 42;
            // 
            // XL2RetailCount
            // 
            this.XL2RetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL2RetailCount.DataPropertyName = "XL2RetailCount";
            this.XL2RetailCount.HeaderText = "XL2";
            this.XL2RetailCount.Name = "XL2RetailCount";
            this.XL2RetailCount.ReadOnly = true;
            this.XL2RetailCount.Width = 48;
            // 
            // XL3RetailCount
            // 
            this.XL3RetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL3RetailCount.DataPropertyName = "XL3RetailCount";
            this.XL3RetailCount.HeaderText = "XL3";
            this.XL3RetailCount.Name = "XL3RetailCount";
            this.XL3RetailCount.ReadOnly = true;
            this.XL3RetailCount.Width = 48;
            // 
            // XL4RetailCount
            // 
            this.XL4RetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL4RetailCount.DataPropertyName = "XL4RetailCount";
            this.XL4RetailCount.HeaderText = "XL4";
            this.XL4RetailCount.Name = "XL4RetailCount";
            this.XL4RetailCount.ReadOnly = true;
            this.XL4RetailCount.Width = 48;
            // 
            // XL5RetailCount
            // 
            this.XL5RetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL5RetailCount.DataPropertyName = "XL5RetailCount";
            this.XL5RetailCount.HeaderText = "XL5";
            this.XL5RetailCount.Name = "XL5RetailCount";
            this.XL5RetailCount.ReadOnly = true;
            this.XL5RetailCount.Width = 48;
            // 
            // XL6RetailCount
            // 
            this.XL6RetailCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL6RetailCount.DataPropertyName = "XL6RetailCount";
            this.XL6RetailCount.HeaderText = "XL6";
            this.XL6RetailCount.Name = "XL6RetailCount";
            this.XL6RetailCount.ReadOnly = true;
            this.XL6RetailCount.Width = 48;
            // 
            // RetailSumCount
            // 
            this.RetailSumCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RetailSumCount.DataPropertyName = "RetailSumCount";
            this.RetailSumCount.HeaderText = "数量";
            this.RetailSumCount.Name = "RetailSumCount";
            this.RetailSumCount.ReadOnly = true;
            this.RetailSumCount.Width = 80;
            // 
            // RetailSumMoney
            // 
            this.RetailSumMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RetailSumMoney.DataPropertyName = "RetailSumMoney";
            this.RetailSumMoney.HeaderText = "金额";
            this.RetailSumMoney.Name = "RetailSumMoney";
            this.RetailSumMoney.ReadOnly = true;
            this.RetailSumMoney.Width = 80;
            // 
            // FCostumeStoreCount
            // 
            this.FCostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FCostumeStoreCount.DataPropertyName = "FCostumeStoreCount";
            this.FCostumeStoreCount.HeaderText = "F";
            this.FCostumeStoreCount.Name = "FCostumeStoreCount";
            this.FCostumeStoreCount.ReadOnly = true;
            this.FCostumeStoreCount.Width = 36;
            // 
            // XSCostumeStoreCount
            // 
            this.XSCostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XSCostumeStoreCount.DataPropertyName = "XSCostumeStoreCount";
            this.XSCostumeStoreCount.HeaderText = "XS";
            this.XSCostumeStoreCount.Name = "XSCostumeStoreCount";
            this.XSCostumeStoreCount.ReadOnly = true;
            this.XSCostumeStoreCount.Width = 42;
            // 
            // SCostumeStoreCount
            // 
            this.SCostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SCostumeStoreCount.DataPropertyName = "SCostumeStoreCount";
            this.SCostumeStoreCount.HeaderText = "S";
            this.SCostumeStoreCount.Name = "SCostumeStoreCount";
            this.SCostumeStoreCount.ReadOnly = true;
            this.SCostumeStoreCount.Width = 36;
            // 
            // MCostumeStoreCount
            // 
            this.MCostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MCostumeStoreCount.DataPropertyName = "MCostumeStoreCount";
            this.MCostumeStoreCount.HeaderText = "M";
            this.MCostumeStoreCount.Name = "MCostumeStoreCount";
            this.MCostumeStoreCount.ReadOnly = true;
            this.MCostumeStoreCount.Width = 36;
            // 
            // LCostumeStoreCount
            // 
            this.LCostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LCostumeStoreCount.DataPropertyName = "LCostumeStoreCount";
            this.LCostumeStoreCount.HeaderText = "L";
            this.LCostumeStoreCount.Name = "LCostumeStoreCount";
            this.LCostumeStoreCount.ReadOnly = true;
            this.LCostumeStoreCount.Width = 36;
            // 
            // XLCostumeStoreCount
            // 
            this.XLCostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XLCostumeStoreCount.DataPropertyName = "XLCostumeStoreCount";
            this.XLCostumeStoreCount.HeaderText = "XL";
            this.XLCostumeStoreCount.Name = "XLCostumeStoreCount";
            this.XLCostumeStoreCount.ReadOnly = true;
            this.XLCostumeStoreCount.Width = 42;
            // 
            // XL2CostumeStoreCount
            // 
            this.XL2CostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL2CostumeStoreCount.DataPropertyName = "XL2CostumeStoreCount";
            this.XL2CostumeStoreCount.HeaderText = "XL2";
            this.XL2CostumeStoreCount.Name = "XL2CostumeStoreCount";
            this.XL2CostumeStoreCount.ReadOnly = true;
            this.XL2CostumeStoreCount.Width = 48;
            // 
            // XL3CostumeStoreCount
            // 
            this.XL3CostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL3CostumeStoreCount.DataPropertyName = "XL3CostumeStoreCount";
            this.XL3CostumeStoreCount.HeaderText = "XL3";
            this.XL3CostumeStoreCount.Name = "XL3CostumeStoreCount";
            this.XL3CostumeStoreCount.ReadOnly = true;
            this.XL3CostumeStoreCount.Width = 48;
            // 
            // XL4CostumeStoreCount
            // 
            this.XL4CostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL4CostumeStoreCount.DataPropertyName = "XL4CostumeStoreCount";
            this.XL4CostumeStoreCount.HeaderText = "XL4";
            this.XL4CostumeStoreCount.Name = "XL4CostumeStoreCount";
            this.XL4CostumeStoreCount.ReadOnly = true;
            this.XL4CostumeStoreCount.Width = 48;
            // 
            // XL5CostumeStoreCount
            // 
            this.XL5CostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL5CostumeStoreCount.DataPropertyName = "XL5CostumeStoreCount";
            this.XL5CostumeStoreCount.HeaderText = "XL5";
            this.XL5CostumeStoreCount.Name = "XL5CostumeStoreCount";
            this.XL5CostumeStoreCount.ReadOnly = true;
            this.XL5CostumeStoreCount.Width = 48;
            // 
            // XL6CostumeStoreCount
            // 
            this.XL6CostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.XL6CostumeStoreCount.DataPropertyName = "XL6CostumeStoreCount";
            this.XL6CostumeStoreCount.HeaderText = "XL6";
            this.XL6CostumeStoreCount.Name = "XL6CostumeStoreCount";
            this.XL6CostumeStoreCount.ReadOnly = true;
            this.XL6CostumeStoreCount.Width = 48;
            // 
            // costumeStoreCountDataGridViewTextBoxColumn
            // 
            this.costumeStoreCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeStoreCountDataGridViewTextBoxColumn.DataPropertyName = "CostumeStoreCount";
            this.costumeStoreCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.costumeStoreCountDataGridViewTextBoxColumn.Name = "costumeStoreCountDataGridViewTextBoxColumn";
            this.costumeStoreCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeStoreCountDataGridViewTextBoxColumn.Width = 54;
            // 
            // costumeStoreMoneyDataGridViewTextBoxColumn
            // 
            this.costumeStoreMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeStoreMoneyDataGridViewTextBoxColumn.DataPropertyName = "CostumeStoreMoney";
            this.costumeStoreMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.costumeStoreMoneyDataGridViewTextBoxColumn.Name = "costumeStoreMoneyDataGridViewTextBoxColumn";
            this.costumeStoreMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeStoreMoneyDataGridViewTextBoxColumn.Width = 54;
            // 
            // CostumeInventorySearchCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "CostumeInventorySearchCtrl";
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
        private Components.QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CostumeTextBox skinTextBox_costumeID;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CostumeClassSelector skinComboBoxBigClass;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxSizeName;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn startCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outMoneyDataGridViewTextBoxColumn;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private Manage.BrandComboBox skinComboBox_Brand;
        private Components.BaseButton baseButton1;
        private Manage.Components.SeasonComboBox skinComboBoxSeason;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Season;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn inCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn inMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn pfSalesCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn pfSalesMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn retailCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn retailMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FRetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XSRetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LRetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XLRetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL2RetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL3RetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL4RetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL5RetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL6RetailCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailSumCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailSumMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XSCostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn LCostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XLCostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL2CostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL3CostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL4CostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL5CostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL6CostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeStoreCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeStoreMoneyDataGridViewTextBoxColumn;
    }
}
