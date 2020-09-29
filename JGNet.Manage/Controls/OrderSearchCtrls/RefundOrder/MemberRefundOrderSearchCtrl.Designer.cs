using JGNet.Common;

namespace JGNet.Manage
{
    partial class MemberRefundOrderSearchCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberRefundOrderSearchCtrl));
            this.refundDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refundOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumeClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_RefundDetail = new System.Windows.Forms.DataGridView();
            this.dataGridView_RefundOrder = new System.Windows.Forms.DataGridView();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.CostumeCurrentShopTextBox1 = new JGNet.Common.CostumeCurrentShopTextBox();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.skinTextBox_MemberID = new JGNet.Common.TextBox();
            this.skinTextBox_OrderID = new JGNet.Common.TextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memeberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guideIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostumeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.refundDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RefundDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RefundOrder)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // refundDetailBindingSource
            // 
            this.refundDetailBindingSource.DataSource = typeof(JGNet.RetailDetail);
            // 
            // refundOrderBindingSource
            // 
            this.refundOrderBindingSource.DataSource = typeof(JGNet.RetailOrder);
            // 
            // costumeClassBindingSource
            // 
            this.costumeClassBindingSource.DataSource = typeof(JGNet.CostumeClass);
            // 
            // dataGridView_RefundDetail
            // 
            this.dataGridView_RefundDetail.AllowUserToAddRows = false;
            this.dataGridView_RefundDetail.AllowUserToDeleteRows = false;
            this.dataGridView_RefundDetail.AutoGenerateColumns = false;
            this.dataGridView_RefundDetail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_RefundDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RefundDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.CostumeName,
            this.colorNameDataGridViewTextBoxColumn,
            this.SizeDisplayName,
            this.priceDataGridViewTextBoxColumn,
            this.buyCountDataGridViewTextBoxColumn,
            this.sumMoneyDataGridViewTextBoxColumn});
            this.dataGridView_RefundDetail.DataSource = this.refundDetailBindingSource;
            this.dataGridView_RefundDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_RefundDetail.Location = new System.Drawing.Point(0, 500);
            this.dataGridView_RefundDetail.Name = "dataGridView_RefundDetail";
            this.dataGridView_RefundDetail.ReadOnly = true;
            this.dataGridView_RefundDetail.RowHeadersVisible = false;
            this.dataGridView_RefundDetail.RowTemplate.Height = 23;
            this.dataGridView_RefundDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_RefundDetail.Size = new System.Drawing.Size(1160, 150);
            this.dataGridView_RefundDetail.TabIndex = 8;
            this.dataGridView_RefundDetail.Visible = false;
            // 
            // dataGridView_RefundOrder
            // 
            this.dataGridView_RefundOrder.AllowUserToAddRows = false;
            this.dataGridView_RefundOrder.AllowUserToDeleteRows = false;
            this.dataGridView_RefundOrder.AutoGenerateColumns = false;
            this.dataGridView_RefundOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_RefundOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RefundOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.OriginOrderID,
            this.shopIDDataGridViewTextBoxColumn,
            this.memeberIDDataGridViewTextBoxColumn,
            this.totalCountDataGridViewTextBoxColumn,
            this.guideIDDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView_RefundOrder.DataSource = this.refundOrderBindingSource;
            this.dataGridView_RefundOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RefundOrder.Location = new System.Drawing.Point(0, 67);
            this.dataGridView_RefundOrder.Name = "dataGridView_RefundOrder";
            this.dataGridView_RefundOrder.ReadOnly = true;
            this.dataGridView_RefundOrder.RowTemplate.Height = 23;
            this.dataGridView_RefundOrder.Size = new System.Drawing.Size(1160, 583);
            this.dataGridView_RefundOrder.TabIndex = 7;
            this.dataGridView_RefundOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RetailOrder_CellClick);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Controls.Add(this.CostumeCurrentShopTextBox1);
            this.skinPanel1.Controls.Add(this.skinCheckBox1);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinTextBox_MemberID);
            this.skinPanel1.Controls.Add(this.skinTextBox_OrderID);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel11);
            this.skinPanel1.Controls.Add(this.skinLabel10);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 67);
            this.skinPanel1.TabIndex = 4;
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
            this.quickDateSelector1.Location = new System.Drawing.Point(392, 35);
            this.quickDateSelector1.Name = "quickDateSelector1";
            this.quickDateSelector1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Size = new System.Drawing.Size(32, 25);
            this.quickDateSelector1.SkinAllColor = true;
            this.quickDateSelector1.StartDateTimePicker = this.dateTimePicker_Start;
            this.quickDateSelector1.TabIndex = 18;
            this.quickDateSelector1.Text = "quickDateSelector1";
            this.quickDateSelector1.TitleAnamorphosis = true;
            this.quickDateSelector1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.quickDateSelector1.TitleRadius = 4;
            this.quickDateSelector1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.PickerValueChanged += new CJBasic.Action<object, System.EventArgs>(this.BaseButton_Search_Click);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(245, 37);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker_End.TabIndex = 5;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(65, 37);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker_Start.TabIndex = 4;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(569, 2);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 6;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // CostumeCurrentShopTextBox1
            // 
            this.CostumeCurrentShopTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.CostumeCurrentShopTextBox1.DownBack = null;
            this.CostumeCurrentShopTextBox1.FilterValid = true;
            this.CostumeCurrentShopTextBox1.Icon = null;
            this.CostumeCurrentShopTextBox1.IconIsButton = false;
            this.CostumeCurrentShopTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.CostumeCurrentShopTextBox1.IsPasswordChat = '\0';
            this.CostumeCurrentShopTextBox1.IsSystemPasswordChar = false;
            this.CostumeCurrentShopTextBox1.Lines = new string[0];
            this.CostumeCurrentShopTextBox1.Location = new System.Drawing.Point(424, 4);
            this.CostumeCurrentShopTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.CostumeCurrentShopTextBox1.MaxLength = 32767;
            this.CostumeCurrentShopTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.CostumeCurrentShopTextBox1.MouseBack = null;
            this.CostumeCurrentShopTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.CostumeCurrentShopTextBox1.Multiline = false;
            this.CostumeCurrentShopTextBox1.Name = "CostumeCurrentShopTextBox1";
            this.CostumeCurrentShopTextBox1.NormlBack = null;
            this.CostumeCurrentShopTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.CostumeCurrentShopTextBox1.ReadOnly = false;
            this.CostumeCurrentShopTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CostumeCurrentShopTextBox1.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.CostumeCurrentShopTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CostumeCurrentShopTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostumeCurrentShopTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.CostumeCurrentShopTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.CostumeCurrentShopTextBox1.SkinTxt.Name = "BaseText";
            this.CostumeCurrentShopTextBox1.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.CostumeCurrentShopTextBox1.SkinTxt.TabIndex = 0;
            this.CostumeCurrentShopTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CostumeCurrentShopTextBox1.SkinTxt.WaterText = "输入款号或条形码回车";
            this.CostumeCurrentShopTextBox1.TabIndex = 2;
            this.CostumeCurrentShopTextBox1.TabStop = true;
            this.CostumeCurrentShopTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CostumeCurrentShopTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CostumeCurrentShopTextBox1.WaterText = "输入款号或条形码回车";
            this.CostumeCurrentShopTextBox1.WordWrap = true;
            this.CostumeCurrentShopTextBox1.CostumeSelected += new System.Action<JGNet.CostumeItem>(this.CostumeCurrentShopTextBox1_CostumeSelected);
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DownBack = null;
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.Location = new System.Drawing.Point(6, 40);
            this.skinCheckBox1.MouseBack = null;
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = null;
            this.skinCheckBox1.SelectedDownBack = null;
            this.skinCheckBox1.SelectedMouseBack = null;
            this.skinCheckBox1.SelectedNormlBack = null;
            this.skinCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.skinCheckBox1.TabIndex = 3;
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            // 
            // skinTextBox_MemberID
            // 
            this.skinTextBox_MemberID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_MemberID.DownBack = null;
            this.skinTextBox_MemberID.Icon = null;
            this.skinTextBox_MemberID.IconIsButton = false;
            this.skinTextBox_MemberID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_MemberID.IsPasswordChat = '\0';
            this.skinTextBox_MemberID.IsSystemPasswordChar = false;
            this.skinTextBox_MemberID.Lines = new string[0];
            this.skinTextBox_MemberID.Location = new System.Drawing.Point(64, 4);
            this.skinTextBox_MemberID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_MemberID.MaxLength = 32767;
            this.skinTextBox_MemberID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_MemberID.MouseBack = null;
            this.skinTextBox_MemberID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_MemberID.Multiline = false;
            this.skinTextBox_MemberID.Name = "skinTextBox_MemberID";
            this.skinTextBox_MemberID.NormlBack = null;
            this.skinTextBox_MemberID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_MemberID.ReadOnly = false;
            this.skinTextBox_MemberID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_MemberID.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.skinTextBox_MemberID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_MemberID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_MemberID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_MemberID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_MemberID.SkinTxt.Name = "BaseText";
            this.skinTextBox_MemberID.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.skinTextBox_MemberID.SkinTxt.TabIndex = 0;
            this.skinTextBox_MemberID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_MemberID.SkinTxt.WaterText = "";
            this.skinTextBox_MemberID.TabIndex = 0;
            this.skinTextBox_MemberID.TabStop = true;
            this.skinTextBox_MemberID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_MemberID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_MemberID.WaterText = "";
            this.skinTextBox_MemberID.WordWrap = true;
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
            this.skinTextBox_OrderID.Location = new System.Drawing.Point(244, 4);
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
            this.skinTextBox_OrderID.TabIndex = 1;
            this.skinTextBox_OrderID.TabStop = true;
            this.skinTextBox_OrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_OrderID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_OrderID.WaterText = "";
            this.skinTextBox_OrderID.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(209, 37);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "结束";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(27, 38);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "开始";
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(3, 10);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(56, 17);
            this.skinLabel11.TabIndex = 0;
            this.skinLabel11.Text = "会员卡号";
            this.skinLabel11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(389, 10);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(32, 17);
            this.skinLabel10.TabIndex = 0;
            this.skinLabel10.Text = "款号";
            this.skinLabel10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(209, 9);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "单号";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 497);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1160, 3);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "退货单号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 152;
            // 
            // OriginOrderID
            // 
            this.OriginOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OriginOrderID.DataPropertyName = "OriginOrderID";
            this.OriginOrderID.HeaderText = "销售单号";
            this.OriginOrderID.Name = "OriginOrderID";
            this.OriginOrderID.ReadOnly = true;
            this.OriginOrderID.Width = 152;
            // 
            // shopIDDataGridViewTextBoxColumn
            // 
            this.shopIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.shopIDDataGridViewTextBoxColumn.DataPropertyName = "ShopName";
            this.shopIDDataGridViewTextBoxColumn.HeaderText = "店铺";
            this.shopIDDataGridViewTextBoxColumn.Name = "shopIDDataGridViewTextBoxColumn";
            this.shopIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopIDDataGridViewTextBoxColumn.Width = 152;
            // 
            // memeberIDDataGridViewTextBoxColumn
            // 
            this.memeberIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.memeberIDDataGridViewTextBoxColumn.DataPropertyName = "MemeberID";
            this.memeberIDDataGridViewTextBoxColumn.HeaderText = "会员卡号";
            this.memeberIDDataGridViewTextBoxColumn.Name = "memeberIDDataGridViewTextBoxColumn";
            this.memeberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memeberIDDataGridViewTextBoxColumn.Width = 151;
            // 
            // totalCountDataGridViewTextBoxColumn
            // 
            this.totalCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalCountDataGridViewTextBoxColumn.DataPropertyName = "TotalCount";
            this.totalCountDataGridViewTextBoxColumn.HeaderText = "总数量";
            this.totalCountDataGridViewTextBoxColumn.Name = "totalCountDataGridViewTextBoxColumn";
            this.totalCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCountDataGridViewTextBoxColumn.Width = 152;
            // 
            // guideIDDataGridViewTextBoxColumn
            // 
            this.guideIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.guideIDDataGridViewTextBoxColumn.DataPropertyName = "GuideName";
            this.guideIDDataGridViewTextBoxColumn.HeaderText = "导购员";
            this.guideIDDataGridViewTextBoxColumn.Name = "guideIDDataGridViewTextBoxColumn";
            this.guideIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.guideIDDataGridViewTextBoxColumn.Width = 152;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "开单日期";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 152;
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
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn.Width = 165;
            // 
            // CostumeName
            // 
            this.CostumeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostumeName.DataPropertyName = "CostumeName";
            this.CostumeName.HeaderText = "商品名称";
            this.CostumeName.Name = "CostumeName";
            this.CostumeName.ReadOnly = true;
            this.CostumeName.Width = 166;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 165;
            // 
            // SizeDisplayName
            // 
            this.SizeDisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SizeDisplayName.DataPropertyName = "SizeDisplayName";
            this.SizeDisplayName.HeaderText = "尺码";
            this.SizeDisplayName.Name = "SizeDisplayName";
            this.SizeDisplayName.ReadOnly = true;
            this.SizeDisplayName.Width = 165;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "吊牌价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 165;
            // 
            // buyCountDataGridViewTextBoxColumn
            // 
            this.buyCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.buyCountDataGridViewTextBoxColumn.DataPropertyName = "BuyCount";
            this.buyCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.buyCountDataGridViewTextBoxColumn.Name = "buyCountDataGridViewTextBoxColumn";
            this.buyCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyCountDataGridViewTextBoxColumn.Width = 166;
            // 
            // sumMoneyDataGridViewTextBoxColumn
            // 
            this.sumMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sumMoneyDataGridViewTextBoxColumn.DataPropertyName = "SumMoney";
            this.sumMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.sumMoneyDataGridViewTextBoxColumn.Name = "sumMoneyDataGridViewTextBoxColumn";
            this.sumMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumMoneyDataGridViewTextBoxColumn.Width = 165;
            // 
            // MemberRefundOrderSearchCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridView_RefundDetail);
            this.Controls.Add(this.dataGridView_RefundOrder);
            this.Controls.Add(this.skinPanel1);
            this.Name = "MemberRefundOrderSearchCtrl";
            this.Load += new System.EventHandler(this.MemberRefundOrderSearchCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refundDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RefundDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RefundOrder)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_RefundDetail;
        private System.Windows.Forms.DataGridView dataGridView_RefundOrder;
        private System.Windows.Forms.Panel skinPanel1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private  JGNet.Common.TextBox skinTextBox_MemberID;
        private  JGNet.Common.TextBox skinTextBox_OrderID;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.BindingSource refundDetailBindingSource;
        private System.Windows.Forms.BindingSource refundOrderBindingSource;
        private System.Windows.Forms.BindingSource costumeClassBindingSource;
        private CostumeCurrentShopTextBox CostumeCurrentShopTextBox1;
        private System.Windows.Forms.Splitter splitter1;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memeberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guideIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostumeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMoneyDataGridViewTextBoxColumn;
    }
}
