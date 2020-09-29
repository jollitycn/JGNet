using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Manage.Components;

namespace JGNet.Manage
{
    partial class CostumeManageCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumeManageCtrl));
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBoxYear = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBox_Brand = new JGNet.Common.BrandComboBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel3 = new System.Windows.Forms.Panel();
            this.skinCmbProperty = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonDownTemplate = new JGNet.Common.Components.DownTemplateButton();
            this.baseButtonImport = new JGNet.Common.Components.BaseButton();
            this.skinComboBox_State = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxSeason = new JGNet.Manage.Components.SeasonComboBox();
            this.skinCheckBoxShowImage = new CCWin.SkinControl.SkinCheckBox();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinComboBoxBigClass = new JGNet.Common.CostumeClassSelector();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinTextBoxID = new JGNet.Common.CostumeTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxSupplierID = new JGNet.Common.Components.SupllierComboBox();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmOnlinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PfOnlinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrintBarcode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.dataGridView1);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.Location = new System.Drawing.Point(0, 73);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 577);
            this.skinPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierNameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Column4,
            this.CostPrice,
            this.EmOnlinePrice,
            this.PfOnlinePrice,
            this.brandDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.seasonDataGridViewTextBoxColumn,
            this.ClassName,
            this.colorsDataGridViewTextBoxColumn,
            this.Property,
            this.CreateTime,
            this.remarksDataGridViewTextBoxColumn,
            this.ColumnPrintBarcode,
            this.Column3,
            this.Column1,
            this.Column2,
            this.DeleteColumn});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 577);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.Costume);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBoxYear);
            this.skinPanel1.Controls.Add(this.skinComboBox_Brand);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinPanel3);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 73);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinComboBoxYear
            // 
            this.skinComboBoxYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxYear.FormattingEnabled = true;
            this.skinComboBoxYear.Location = new System.Drawing.Point(179, 9);
            this.skinComboBoxYear.Name = "skinComboBoxYear";
            this.skinComboBoxYear.Size = new System.Drawing.Size(100, 22);
            this.skinComboBoxYear.TabIndex = 1;
            this.skinComboBoxYear.WaterText = "";
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Brand.FormattingEnabled = true;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(39, 42);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectStr = null;
            this.skinComboBox_Brand.ShowAll = true;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(100, 22);
            this.skinComboBox_Brand.SupplierID = null;
            this.skinComboBox_Brand.TabIndex = 6;
            this.skinComboBox_Brand.WaterText = "";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(4, 44);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 9;
            this.skinLabel6.Text = "品牌";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(283, 12);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "季节";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(144, 12);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "年份";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(4, 12);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "款号";
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.skinCmbProperty);
            this.skinPanel3.Controls.Add(this.skinLabel9);
            this.skinPanel3.Controls.Add(this.baseButton2);
            this.skinPanel3.Controls.Add(this.quickDateSelector1);
            this.skinPanel3.Controls.Add(this.dateTimePicker_End);
            this.skinPanel3.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel3.Controls.Add(this.skinLabel7);
            this.skinPanel3.Controls.Add(this.skinLabel8);
            this.skinPanel3.Controls.Add(this.baseButtonDownTemplate);
            this.skinPanel3.Controls.Add(this.baseButtonImport);
            this.skinPanel3.Controls.Add(this.skinComboBox_State);
            this.skinPanel3.Controls.Add(this.skinLabel5);
            this.skinPanel3.Controls.Add(this.skinLabel10);
            this.skinPanel3.Controls.Add(this.skinComboBoxSeason);
            this.skinPanel3.Controls.Add(this.skinCheckBoxShowImage);
            this.skinPanel3.Controls.Add(this.BaseButton1);
            this.skinPanel3.Controls.Add(this.skinComboBoxBigClass);
            this.skinPanel3.Controls.Add(this.BaseButton3);
            this.skinPanel3.Controls.Add(this.skinTextBoxID);
            this.skinPanel3.Controls.Add(this.skinLabel4);
            this.skinPanel3.Controls.Add(this.skinComboBoxSupplierID);
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel3.Location = new System.Drawing.Point(0, 0);
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.Size = new System.Drawing.Size(1160, 73);
            this.skinPanel3.TabIndex = 19;
            // 
            // skinCmbProperty
            // 
            this.skinCmbProperty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbProperty.FormattingEnabled = true;
            this.skinCmbProperty.Location = new System.Drawing.Point(832, 9);
            this.skinCmbProperty.Name = "skinCmbProperty";
            this.skinCmbProperty.Size = new System.Drawing.Size(78, 22);
            this.skinCmbProperty.TabIndex = 151;
            this.skinCmbProperty.WaterText = "";
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(797, 11);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(32, 17);
            this.skinLabel9.TabIndex = 152;
            this.skinLabel9.Text = "属性";
            // 
            // baseButton2
            // 
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(1080, 38);
            this.baseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton2.Size = new System.Drawing.Size(75, 32);
            this.baseButton2.TabIndex = 150;
            this.baseButton2.Text = "导出";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
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
            this.quickDateSelector1.Location = new System.Drawing.Point(595, 39);
            this.quickDateSelector1.Name = "quickDateSelector1";
            this.quickDateSelector1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Size = new System.Drawing.Size(32, 25);
            this.quickDateSelector1.SkinAllColor = true;
            this.quickDateSelector1.StartDateTimePicker = this.dateTimePicker_Start;
            this.quickDateSelector1.TabIndex = 149;
            this.quickDateSelector1.Text = "quickDateSelector1";
            this.quickDateSelector1.TitleAnamorphosis = true;
            this.quickDateSelector1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.quickDateSelector1.TitleRadius = 4;
            this.quickDateSelector1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.PickerValueChanged += new CJBasic.Action<object, System.EventArgs>(this.BaseButton_Search_Click);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(482, 41);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker_End.TabIndex = 146;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(314, 41);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(108, 21);
            this.dateTimePicker_Start.TabIndex = 145;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(448, 43);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 147;
            this.skinLabel7.Text = "结束";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(283, 44);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 148;
            this.skinLabel8.Text = "开始";
            // 
            // baseButtonDownTemplate
            // 
            this.baseButtonDownTemplate.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonDownTemplate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonDownTemplate.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.DownBack")));
            this.baseButtonDownTemplate.DownName = "商品档案.xls";
            this.baseButtonDownTemplate.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonDownTemplate.FileName = "商品档案.xls";
            this.baseButtonDownTemplate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonDownTemplate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonDownTemplate.Location = new System.Drawing.Point(918, 37);
            this.baseButtonDownTemplate.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.MouseBack")));
            this.baseButtonDownTemplate.Name = "baseButtonDownTemplate";
            this.baseButtonDownTemplate.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.NormlBack")));
            this.baseButtonDownTemplate.Size = new System.Drawing.Size(75, 32);
            this.baseButtonDownTemplate.TabIndex = 144;
            this.baseButtonDownTemplate.Text = "下载模板";
            this.baseButtonDownTemplate.UseVisualStyleBackColor = false;
            this.baseButtonDownTemplate.Click += new System.EventHandler(this.baseButtonDownTemplate_Click);
            // 
            // baseButtonImport
            // 
            this.baseButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonImport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonImport.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonImport.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonImport.Location = new System.Drawing.Point(999, 38);
            this.baseButtonImport.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonImport.Name = "baseButtonImport";
            this.baseButtonImport.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonImport.Size = new System.Drawing.Size(75, 32);
            this.baseButtonImport.TabIndex = 100;
            this.baseButtonImport.Text = "导入";
            this.baseButtonImport.UseVisualStyleBackColor = false;
            this.baseButtonImport.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // skinComboBox_State
            // 
            this.skinComboBox_State.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_State.FormattingEnabled = true;
            this.skinComboBox_State.Location = new System.Drawing.Point(178, 41);
            this.skinComboBox_State.Name = "skinComboBox_State";
            this.skinComboBox_State.Size = new System.Drawing.Size(100, 22);
            this.skinComboBox_State.TabIndex = 99;
            this.skinComboBox_State.WaterText = "";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(144, 43);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 18;
            this.skinLabel5.Text = "状态";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(436, 12);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(44, 17);
            this.skinLabel10.TabIndex = 16;
            this.skinLabel10.Text = "供应商";
            // 
            // skinComboBoxSeason
            // 
            this.skinComboBoxSeason.Location = new System.Drawing.Point(314, 7);
            this.skinComboBoxSeason.Name = "skinComboBoxSeason";
            this.skinComboBoxSeason.SelectedValue = null;
            this.skinComboBoxSeason.ShowAdd = false;
            this.skinComboBoxSeason.ShowAll = true;
            this.skinComboBoxSeason.Size = new System.Drawing.Size(108, 26);
            this.skinComboBoxSeason.TabIndex = 2;
            // 
            // skinCheckBoxShowImage
            // 
            this.skinCheckBoxShowImage.AutoSize = true;
            this.skinCheckBoxShowImage.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxShowImage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxShowImage.DownBack = null;
            this.skinCheckBoxShowImage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxShowImage.Location = new System.Drawing.Point(720, 41);
            this.skinCheckBoxShowImage.MouseBack = null;
            this.skinCheckBoxShowImage.Name = "skinCheckBoxShowImage";
            this.skinCheckBoxShowImage.NormlBack = null;
            this.skinCheckBoxShowImage.SelectedDownBack = null;
            this.skinCheckBoxShowImage.SelectedMouseBack = null;
            this.skinCheckBoxShowImage.SelectedNormlBack = null;
            this.skinCheckBoxShowImage.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBoxShowImage.TabIndex = 5;
            this.skinCheckBoxShowImage.Text = "显示图片";
            this.skinCheckBoxShowImage.UseVisualStyleBackColor = false;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(999, 5);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 11;
            this.BaseButton1.Text = "添加";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButtonAdd_Click);
            // 
            // skinComboBoxBigClass
            // 
            this.skinComboBoxBigClass.AutoSize = true;
            this.skinComboBoxBigClass.Location = new System.Drawing.Point(642, 6);
            this.skinComboBoxBigClass.Name = "skinComboBoxBigClass";
            this.skinComboBoxBigClass.SelectedValue = ((JGNet.Costume)(resources.GetObject("skinComboBoxBigClass.SelectedValue")));
            this.skinComboBoxBigClass.Size = new System.Drawing.Size(153, 29);
            this.skinComboBoxBigClass.TabIndex = 17;
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(916, 4);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 10;
            this.BaseButton3.Text = "查询";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinTextBoxID
            // 
            this.skinTextBoxID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxID.DownBack = null;
            this.skinTextBoxID.FilterValid = false;
            this.skinTextBoxID.Icon = null;
            this.skinTextBoxID.IconIsButton = false;
            this.skinTextBoxID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxID.IsPasswordChat = '\0';
            this.skinTextBoxID.IsSystemPasswordChar = false;
            this.skinTextBoxID.Lines = new string[0];
            this.skinTextBoxID.Location = new System.Drawing.Point(39, 6);
            this.skinTextBoxID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxID.MaxLength = 32767;
            this.skinTextBoxID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxID.MouseBack = null;
            this.skinTextBoxID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxID.Multiline = false;
            this.skinTextBoxID.Name = "skinTextBoxID";
            this.skinTextBoxID.NormlBack = null;
            this.skinTextBoxID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxID.ReadOnly = false;
            this.skinTextBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxID.Size = new System.Drawing.Size(100, 28);
            // 
            // 
            // 
            this.skinTextBoxID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxID.SkinTxt.Name = "BaseText";
            this.skinTextBoxID.SkinTxt.Size = new System.Drawing.Size(90, 18);
            this.skinTextBoxID.SkinTxt.TabIndex = 0;
            this.skinTextBoxID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.SkinTxt.WaterText = "";
            this.skinTextBoxID.TabIndex = 0;
            this.skinTextBoxID.TabStop = true;
            this.skinTextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.WaterText = "";
            this.skinTextBoxID.WordWrap = true;
            this.skinTextBoxID.CostumeSelected += new CJBasic.Action<JGNet.Costume, bool>(this.skinTextBoxID_CostumeSelected);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(608, 12);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "类别";
            // 
            // skinComboBoxSupplierID
            // 
            this.skinComboBoxSupplierID.AutoSize = true;
            this.skinComboBoxSupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxSupplierID.EnabledSupplier = true;
            this.skinComboBoxSupplierID.HideAll = false;
            this.skinComboBoxSupplierID.Location = new System.Drawing.Point(482, 9);
            this.skinComboBoxSupplierID.Name = "skinComboBoxSupplierID";
            this.skinComboBoxSupplierID.SelectedItem = ((JGNet.Supplier)(resources.GetObject("skinComboBoxSupplierID.SelectedItem")));
            this.skinComboBoxSupplierID.SelectedValue = null;
            this.skinComboBoxSupplierID.ShowAdd = false;
            this.skinComboBoxSupplierID.Size = new System.Drawing.Size(142, 26);
            this.skinComboBoxSupplierID.TabIndex = 4;
            this.skinComboBoxSupplierID.Title = null;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "供应商";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.supplierNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 55;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "SalePrice";
            this.Column4.HeaderText = "售价";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 55;
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "成本价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            this.CostPrice.Width = 55;
            // 
            // EmOnlinePrice
            // 
            this.EmOnlinePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmOnlinePrice.DataPropertyName = "EmOnlinePrice";
            this.EmOnlinePrice.HeaderText = "线上零售价";
            this.EmOnlinePrice.Name = "EmOnlinePrice";
            this.EmOnlinePrice.ReadOnly = true;
            this.EmOnlinePrice.Width = 80;
            // 
            // PfOnlinePrice
            // 
            this.PfOnlinePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PfOnlinePrice.DataPropertyName = "PfOnlinePrice";
            this.PfOnlinePrice.HeaderText = "线上批发价";
            this.PfOnlinePrice.Name = "PfOnlinePrice";
            this.PfOnlinePrice.ReadOnly = true;
            this.PfOnlinePrice.Width = 80;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandDataGridViewTextBoxColumn.HeaderText = "品牌";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.brandDataGridViewTextBoxColumn.Width = 56;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "年份";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 55;
            // 
            // seasonDataGridViewTextBoxColumn
            // 
            this.seasonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seasonDataGridViewTextBoxColumn.DataPropertyName = "Season";
            this.seasonDataGridViewTextBoxColumn.HeaderText = "季节";
            this.seasonDataGridViewTextBoxColumn.Name = "seasonDataGridViewTextBoxColumn";
            this.seasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonDataGridViewTextBoxColumn.Width = 55;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "类别";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClassName.Width = 55;
            // 
            // colorsDataGridViewTextBoxColumn
            // 
            this.colorsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorsDataGridViewTextBoxColumn.DataPropertyName = "Colors";
            this.colorsDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorsDataGridViewTextBoxColumn.Name = "colorsDataGridViewTextBoxColumn";
            this.colorsDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorsDataGridViewTextBoxColumn.Width = 55;
            // 
            // Property
            // 
            this.Property.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Property.DataPropertyName = "CostumePropertyName";
            this.Property.HeaderText = "属性";
            this.Property.Name = "Property";
            this.Property.ReadOnly = true;
            this.Property.Width = 55;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "建档时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 90;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 54;
            // 
            // ColumnPrintBarcode
            // 
            this.ColumnPrintBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPrintBarcode.HeaderText = "打印条码";
            this.ColumnPrintBarcode.Name = "ColumnPrintBarcode";
            this.ColumnPrintBarcode.ReadOnly = true;
            this.ColumnPrintBarcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPrintBarcode.Text = "打印条码";
            this.ColumnPrintBarcode.UseColumnTextForLinkValue = true;
            this.ColumnPrintBarcode.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "SupplierName";
            this.Column3.HeaderText = "取消禁用";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Text = "取消禁用";
            this.Column3.UseColumnTextForLinkValue = true;
            this.Column3.Width = 80;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "编辑";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Text = "编辑";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "禁用";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "禁用";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteColumn.HeaderText = "删除";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteColumn.Text = "删除";
            this.DeleteColumn.UseColumnTextForLinkValue = true;
            this.DeleteColumn.Width = 40;
            // 
            // CostumeManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.Name = "CostumeManageCtrl";
            this.Load += new System.EventHandler(this.CostumeManageCtrl_Load);
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.Panel skinPanel2;
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private SeasonComboBox skinComboBoxSeason;
        private CostumeClassSelector skinComboBoxBigClass;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private JGNet.Common.BrandComboBox skinComboBox_Brand;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private SupllierComboBox skinComboBoxSupplierID;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinComboBox skinComboBoxYear;
        private System.Windows.Forms.Panel skinPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Common.CostumeTextBox skinTextBoxID;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.BaseButton BaseButton3;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxShowImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn styleDataGridViewTextBoxColumn;
        private SkinLabel skinLabel5;
        private SkinComboBox skinComboBox_State;
        private BaseButton baseButtonImport;
        private DownTemplateButton baseButtonDownTemplate;
        private QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private SkinLabel skinLabel7;
        private SkinLabel skinLabel8;
        private BaseButton baseButton2;
        private SkinComboBox skinCmbProperty;
        private SkinLabel skinLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmOnlinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PfOnlinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Property;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnPrintBarcode;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn DeleteColumn;
    }
}
