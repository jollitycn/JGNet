using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Core.InteractEntity;

namespace JGNet.Manage
{
    partial class GetPurchaseSummaryCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetPurchaseSummaryCtrl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outboundDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_OrderID = new JGNet.Common.TextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Brand = new JGNet.Common.BrandComboBox();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.colletStyle = new CCWin.SkinControl.SkinComboBox();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinTextBox_costumeID = new JGNet.Common.CostumeTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxSupplierID = new JGNet.Common.Components.SupllierComboBox();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeValue1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeValue2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeValue3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeValue10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BidCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeValue1,
            this.TypeValue2,
            this.TypeValue3,
            this.TypeValue4,
            this.TypeValue5,
            this.TypeValue6,
            this.TypeValue7,
            this.TypeValue8,
            this.TypeValue9,
            this.TypeValue10,
            this.AllCount,
            this.Bid,
            this.BidCount});
            this.dataGridView1.DataSource = this.outboundDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 585);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // outboundDetailBindingSource
            // 
            this.outboundDetailBindingSource.DataSource = typeof(JGNet.Core.InteractEntity.PurchaseSummaryInfo);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinLabel10);
            this.skinPanel1.Controls.Add(this.skinTextBox_OrderID);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinComboBox_Brand);
            this.skinPanel1.Controls.Add(this.skinLabel11);
            this.skinPanel1.Controls.Add(this.baseButton2);
            this.skinPanel1.Controls.Add(this.colletStyle);
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Controls.Add(this.skinTextBox_costumeID);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinComboBoxSupplierID);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 65);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(3, 40);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 143;
            this.skinLabel5.Text = "汇总方式";
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(15, 11);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(44, 17);
            this.skinLabel10.TabIndex = 142;
            this.skinLabel10.Text = "供应商";
            // 
            // skinTextBox_OrderID
            // 
            this.skinTextBox_OrderID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_OrderID.DownBack = null;
            this.skinTextBox_OrderID.Icon = null;
            this.skinTextBox_OrderID.IconIsButton = false;
            this.skinTextBox_OrderID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_OrderID.IsPasswordChat = '\0';
            this.skinTextBox_OrderID.IsSystemPasswordChar = false;
            this.skinTextBox_OrderID.Lines = new string[0];
            this.skinTextBox_OrderID.Location = new System.Drawing.Point(456, 6);
            this.skinTextBox_OrderID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_OrderID.MaxLength = 32767;
            this.skinTextBox_OrderID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_OrderID.MouseBack = null;
            this.skinTextBox_OrderID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_OrderID.Multiline = false;
            this.skinTextBox_OrderID.Name = "skinTextBox_OrderID";
            this.skinTextBox_OrderID.NormlBack = null;
            this.skinTextBox_OrderID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_OrderID.ReadOnly = false;
            this.skinTextBox_OrderID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_OrderID.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.skinTextBox_OrderID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_OrderID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_OrderID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_OrderID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_OrderID.SkinTxt.Name = "BaseText";
            this.skinTextBox_OrderID.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.skinTextBox_OrderID.SkinTxt.TabIndex = 0;
            this.skinTextBox_OrderID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_OrderID.SkinTxt.WaterText = "";
            this.skinTextBox_OrderID.TabIndex = 139;
            this.skinTextBox_OrderID.TabStop = true;
            this.skinTextBox_OrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_OrderID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_OrderID.WaterText = "";
            this.skinTextBox_OrderID.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(419, 12);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 140;
            this.skinLabel4.Text = "单号";
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.DisplayMember = "AutoID";
            this.skinComboBox_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Brand.FormattingEnabled = true;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(271, 8);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectStr = null;
            this.skinComboBox_Brand.ShowAll = true;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(142, 22);
            this.skinComboBox_Brand.SupplierID = null;
            this.skinComboBox_Brand.TabIndex = 137;
            this.skinComboBox_Brand.ValueMember = "AutoID";
            this.skinComboBox_Brand.WaterText = "";
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(236, 11);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(32, 17);
            this.skinLabel11.TabIndex = 138;
            this.skinLabel11.Text = "品牌";
            this.skinLabel11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // baseButton2
            // 
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(363, 32);
            this.baseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton2.Size = new System.Drawing.Size(50, 32);
            this.baseButton2.TabIndex = 134;
            this.baseButton2.Text = "...";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // colletStyle
            // 
            this.colletStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colletStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colletStyle.FormattingEnabled = true;
            this.colletStyle.Location = new System.Drawing.Point(64, 37);
            this.colletStyle.Name = "colletStyle";
            this.colletStyle.Size = new System.Drawing.Size(293, 22);
            this.colletStyle.TabIndex = 133;
            this.colletStyle.WaterText = "";
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
            this.quickDateSelector1.Location = new System.Drawing.Point(785, 36);
            this.quickDateSelector1.Name = "quickDateSelector1";
            this.quickDateSelector1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Size = new System.Drawing.Size(32, 25);
            this.quickDateSelector1.SkinAllColor = true;
            this.quickDateSelector1.StartDateTimePicker = this.dateTimePicker_Start;
            this.quickDateSelector1.TabIndex = 130;
            this.quickDateSelector1.Text = "quickDateSelector1";
            this.quickDateSelector1.TitleAnamorphosis = true;
            this.quickDateSelector1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.quickDateSelector1.TitleRadius = 4;
            this.quickDateSelector1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.PickerValueChanged += new CJBasic.Action<object, System.EventArgs>(this.BaseButton_Search_Click);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(640, 38);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker_End.TabIndex = 4;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(457, 38);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(882, 3);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 5;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinTextBox_costumeID
            // 
            this.skinTextBox_costumeID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_costumeID.DownBack = null;
            this.skinTextBox_costumeID.FilterValid = false;
            this.skinTextBox_costumeID.Icon = null;
            this.skinTextBox_costumeID.IconIsButton = false;
            this.skinTextBox_costumeID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_costumeID.IsPasswordChat = '\0';
            this.skinTextBox_costumeID.IsSystemPasswordChar = false;
            this.skinTextBox_costumeID.Lines = new string[0];
            this.skinTextBox_costumeID.Location = new System.Drawing.Point(639, 5);
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
            this.skinTextBox_costumeID.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.skinTextBox_costumeID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_costumeID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_costumeID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_costumeID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_costumeID.SkinTxt.Name = "BaseText";
            this.skinTextBox_costumeID.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.skinTextBox_costumeID.SkinTxt.TabIndex = 0;
            this.skinTextBox_costumeID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_costumeID.SkinTxt.WaterText = "";
            this.skinTextBox_costumeID.TabIndex = 1;
            this.skinTextBox_costumeID.TabStop = true;
            this.skinTextBox_costumeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_costumeID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_costumeID.WaterText = "";
            this.skinTextBox_costumeID.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(605, 11);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 25;
            this.skinLabel1.Text = "款号";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(605, 40);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 9;
            this.skinLabel3.Text = "结束";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(419, 40);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 10;
            this.skinLabel2.Text = "开始";
            // 
            // skinComboBoxSupplierID
            // 
            this.skinComboBoxSupplierID.AutoSize = true;
            this.skinComboBoxSupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxSupplierID.EnabledSupplier = true;
            this.skinComboBoxSupplierID.HideAll = false;
            this.skinComboBoxSupplierID.Location = new System.Drawing.Point(62, 7);
            this.skinComboBoxSupplierID.Name = "skinComboBoxSupplierID";
            this.skinComboBoxSupplierID.SelectedItem = ((JGNet.Supplier)(resources.GetObject("skinComboBoxSupplierID.SelectedItem")));
            this.skinComboBoxSupplierID.SelectedValue = null;
            this.skinComboBoxSupplierID.ShowAdd = false;
            this.skinComboBoxSupplierID.Size = new System.Drawing.Size(182, 26);
            this.skinComboBoxSupplierID.TabIndex = 141;
            this.skinComboBoxSupplierID.Title = null;
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 65);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView2);
            this.skinSplitContainer1.Panel2Collapsed = true;
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 585);
            this.skinSplitContainer1.SplitterDistance = 156;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostPrice,
            this.typeDataGridViewTextBoxColumn,
            this.typeValue1DataGridViewTextBoxColumn,
            this.typeValue2DataGridViewTextBoxColumn,
            this.typeValue3DataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.costPriceSumDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.outboundDetailBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1160, 585);
            this.dataGridView2.TabIndex = 7;
            // 
            // CostPrice
            // 
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "成本价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeValue1DataGridViewTextBoxColumn
            // 
            this.typeValue1DataGridViewTextBoxColumn.DataPropertyName = "TypeValue1";
            this.typeValue1DataGridViewTextBoxColumn.HeaderText = "TypeValue1";
            this.typeValue1DataGridViewTextBoxColumn.Name = "typeValue1DataGridViewTextBoxColumn";
            this.typeValue1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeValue2DataGridViewTextBoxColumn
            // 
            this.typeValue2DataGridViewTextBoxColumn.DataPropertyName = "TypeValue2";
            this.typeValue2DataGridViewTextBoxColumn.HeaderText = "TypeValue2";
            this.typeValue2DataGridViewTextBoxColumn.Name = "typeValue2DataGridViewTextBoxColumn";
            this.typeValue2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeValue3DataGridViewTextBoxColumn
            // 
            this.typeValue3DataGridViewTextBoxColumn.DataPropertyName = "TypeValue3";
            this.typeValue3DataGridViewTextBoxColumn.HeaderText = "TypeValue3";
            this.typeValue3DataGridViewTextBoxColumn.Name = "typeValue3DataGridViewTextBoxColumn";
            this.typeValue3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.HeaderText = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            this.costPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costPriceSumDataGridViewTextBoxColumn
            // 
            this.costPriceSumDataGridViewTextBoxColumn.DataPropertyName = "CostPriceSum";
            this.costPriceSumDataGridViewTextBoxColumn.HeaderText = "CostPriceSum";
            this.costPriceSumDataGridViewTextBoxColumn.Name = "costPriceSumDataGridViewTextBoxColumn";
            this.costPriceSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TypeValue1
            // 
            this.TypeValue1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue1.DataPropertyName = "TypeValue1";
            this.TypeValue1.HeaderText = "TypeValue1";
            this.TypeValue1.Name = "TypeValue1";
            this.TypeValue1.ReadOnly = true;
            this.TypeValue1.Visible = false;
            // 
            // TypeValue2
            // 
            this.TypeValue2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue2.DataPropertyName = "TypeValue2";
            this.TypeValue2.HeaderText = "TypeValue2";
            this.TypeValue2.Name = "TypeValue2";
            this.TypeValue2.ReadOnly = true;
            this.TypeValue2.Visible = false;
            // 
            // TypeValue3
            // 
            this.TypeValue3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue3.DataPropertyName = "TypeValue3";
            this.TypeValue3.HeaderText = "TypeValue3";
            this.TypeValue3.Name = "TypeValue3";
            this.TypeValue3.ReadOnly = true;
            this.TypeValue3.Visible = false;
            // 
            // TypeValue4
            // 
            this.TypeValue4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue4.DataPropertyName = "TypeValue4";
            this.TypeValue4.HeaderText = "商品名称";
            this.TypeValue4.Name = "TypeValue4";
            this.TypeValue4.ReadOnly = true;
            this.TypeValue4.Visible = false;
            // 
            // TypeValue5
            // 
            this.TypeValue5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue5.DataPropertyName = "TypeValue5";
            this.TypeValue5.HeaderText = "单号";
            this.TypeValue5.Name = "TypeValue5";
            this.TypeValue5.ReadOnly = true;
            this.TypeValue5.Visible = false;
            this.TypeValue5.Width = 130;
            // 
            // TypeValue6
            // 
            this.TypeValue6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue6.DataPropertyName = "TypeValue6";
            this.TypeValue6.HeaderText = "颜色";
            this.TypeValue6.Name = "TypeValue6";
            this.TypeValue6.ReadOnly = true;
            this.TypeValue6.Visible = false;
            // 
            // TypeValue7
            // 
            this.TypeValue7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue7.DataPropertyName = "TypeValue7";
            this.TypeValue7.HeaderText = "日期";
            this.TypeValue7.Name = "TypeValue7";
            this.TypeValue7.ReadOnly = true;
            this.TypeValue7.Visible = false;
            // 
            // TypeValue8
            // 
            this.TypeValue8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue8.DataPropertyName = "TypeValue8";
            this.TypeValue8.HeaderText = "类别";
            this.TypeValue8.Name = "TypeValue8";
            this.TypeValue8.ReadOnly = true;
            this.TypeValue8.Visible = false;
            // 
            // TypeValue9
            // 
            this.TypeValue9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue9.DataPropertyName = "TypeValue9";
            this.TypeValue9.HeaderText = "季节";
            this.TypeValue9.Name = "TypeValue9";
            this.TypeValue9.ReadOnly = true;
            this.TypeValue9.Visible = false;
            // 
            // TypeValue10
            // 
            this.TypeValue10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeValue10.DataPropertyName = "TypeValue10";
            this.TypeValue10.HeaderText = "年份";
            this.TypeValue10.Name = "TypeValue10";
            this.TypeValue10.ReadOnly = true;
            this.TypeValue10.Visible = false;
            // 
            // AllCount
            // 
            this.AllCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AllCount.DataPropertyName = "Count";
            this.AllCount.HeaderText = "数量";
            this.AllCount.Name = "AllCount";
            this.AllCount.ReadOnly = true;
            this.AllCount.Width = 520;
            // 
            // Bid
            // 
            this.Bid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Bid.DataPropertyName = "CostPrice";
            this.Bid.HeaderText = "进价";
            this.Bid.Name = "Bid";
            this.Bid.ReadOnly = true;
            this.Bid.Width = 520;
            // 
            // BidCount
            // 
            this.BidCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BidCount.DataPropertyName = "CostPriceSum";
            this.BidCount.HeaderText = "进价额";
            this.BidCount.Name = "BidCount";
            this.BidCount.ReadOnly = true;
            this.BidCount.Width = 66;
            // 
            // GetPurchaseSummaryCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "GetPurchaseSummaryCtrl";
            this.Load += new System.EventHandler(this.ReturnOrderManageCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Common.CostumeTextBox skinTextBox_costumeID;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.BindingSource outboundDetailBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMoneyDataGridViewTextBoxColumn;
        private CCWin.SkinControl.SkinComboBox colletStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceSumDataGridViewTextBoxColumn;
        private Common.Components.BaseButton baseButton2;
        private Common.BrandComboBox skinComboBox_Brand;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private TextBox skinTextBox_OrderID;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private SupllierComboBox skinComboBoxSupplierID;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue9;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeValue10;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BidCount;
    }
}
