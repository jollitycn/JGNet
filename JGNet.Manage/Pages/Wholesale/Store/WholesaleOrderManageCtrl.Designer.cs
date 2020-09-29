using JGNet.Common;

namespace JGNet.Manage
{
    partial class WholesaleOrderManageCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WholesaleOrderManageCtrl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outboundDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBox_State = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.pfType = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_PfCustomer = new JGNet.Common.PfCustomerComboBox();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinTextBox_costumeID = new JGNet.Common.CostumeTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_OrderID = new JGNet.Common.TextBox();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuideName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentBalanceOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCancel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRedo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnPick = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
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
            this.Column1,
            this.ShopName,
            this.GuideName,
            this.CancelUserName,
            this.totalCountDataGridViewTextBoxColumn,
            this.PaymentBalanceOld,
            this.totalPriceDataGridViewTextBoxColumn,
            this.PaymentBalance,
            this.Column3,
            this.entryTimeDataGridViewTextBoxColumn,
            this.Column6,
            this.State,
            this.ColumnCancel,
            this.ColumnRedo,
            this.ColumnPick,
            this.Column4,
            this.Column2});
            this.dataGridView1.DataSource = this.outboundDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 163);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // outboundDetailBindingSource
            // 
            this.outboundDetailBindingSource.DataSource = typeof(JGNet.PfOrder);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBox_State);
            this.skinPanel1.Controls.Add(this.skinLabel8);
            this.skinPanel1.Controls.Add(this.pfType);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.skinComboBox_PfCustomer);
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Controls.Add(this.skinTextBox_costumeID);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinTextBox_OrderID);
            this.skinPanel1.Controls.Add(this.skinLabel10);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 66);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinComboBox_State
            // 
            this.skinComboBox_State.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_State.FormattingEnabled = true;
            this.skinComboBox_State.Location = new System.Drawing.Point(425, 36);
            this.skinComboBox_State.Name = "skinComboBox_State";
            this.skinComboBox_State.Size = new System.Drawing.Size(128, 22);
            this.skinComboBox_State.TabIndex = 195;
            this.skinComboBox_State.WaterText = "";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(390, 39);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 196;
            this.skinLabel8.Text = "状态";
            // 
            // pfType
            // 
            this.pfType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pfType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pfType.FormattingEnabled = true;
            this.pfType.Location = new System.Drawing.Point(610, 8);
            this.pfType.Name = "pfType";
            this.pfType.Size = new System.Drawing.Size(121, 22);
            this.pfType.TabIndex = 194;
            this.pfType.WaterText = "";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(572, 11);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 193;
            this.skinLabel7.Text = "类型";
            this.skinLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinComboBox_PfCustomer
            // 
            this.skinComboBox_PfCustomer.CheckPfCustomer = false;
            this.skinComboBox_PfCustomer.curSelectStr = null;
            this.skinComboBox_PfCustomer.CustomerTypeValue = -1;
            this.skinComboBox_PfCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_PfCustomer.FormattingEnabled = true;
            this.skinComboBox_PfCustomer.HideEmpty = false;
            this.skinComboBox_PfCustomer.Location = new System.Drawing.Point(425, 8);
            this.skinComboBox_PfCustomer.Name = "skinComboBox_PfCustomer";
            this.skinComboBox_PfCustomer.Size = new System.Drawing.Size(128, 22);
            this.skinComboBox_PfCustomer.TabIndex = 187;
            this.skinComboBox_PfCustomer.WaterText = "";
            this.skinComboBox_PfCustomer.ItemSelected += new System.Action<JGNet.PfCustomer>(this.skinComboBox_PfCustomer_ItemSelected);
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
            this.quickDateSelector1.Location = new System.Drawing.Point(362, 35);
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
            this.dateTimePicker_End.Location = new System.Drawing.Point(230, 37);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker_End.TabIndex = 4;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(61, 37);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(122, 21);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(737, 3);
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
            this.skinTextBox_costumeID.Location = new System.Drawing.Point(230, 5);
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
            this.skinTextBox_costumeID.TabIndex = 1;
            this.skinTextBox_costumeID.TabStop = true;
            this.skinTextBox_costumeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_costumeID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_costumeID.WaterText = "";
            this.skinTextBox_costumeID.WordWrap = true;
            this.skinTextBox_costumeID.CostumeSelected += new CJBasic.Action<JGNet.Costume, bool>(this.skinTextBox_costumeID_CostumeSelected);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(196, 11);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 25;
            this.skinLabel1.Text = "款号";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(390, 11);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 23;
            this.skinLabel4.Text = "客户";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.skinTextBox_OrderID.Location = new System.Drawing.Point(61, 5);
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
            this.skinTextBox_OrderID.Size = new System.Drawing.Size(122, 28);
            // 
            // 
            // 
            this.skinTextBox_OrderID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_OrderID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_OrderID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_OrderID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_OrderID.SkinTxt.Name = "BaseText";
            this.skinTextBox_OrderID.SkinTxt.Size = new System.Drawing.Size(112, 18);
            this.skinTextBox_OrderID.SkinTxt.TabIndex = 0;
            this.skinTextBox_OrderID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_OrderID.SkinTxt.WaterText = "";
            this.skinTextBox_OrderID.TabIndex = 0;
            this.skinTextBox_OrderID.TabStop = true;
            this.skinTextBox_OrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_OrderID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_OrderID.WaterText = "";
            this.skinTextBox_OrderID.WordWrap = true;
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(23, 11);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(32, 17);
            this.skinLabel10.TabIndex = 19;
            this.skinLabel10.Text = "单号";
            this.skinLabel10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(196, 39);
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
            this.skinLabel2.Location = new System.Drawing.Point(23, 39);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 10;
            this.skinLabel2.Text = "开始";
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 66);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 584);
            this.skinSplitContainer1.SplitterDistance = 163;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "批发单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 120;
            // 
            // ShopName
            // 
            this.ShopName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShopName.DataPropertyName = "PfCustomerName";
            this.ShopName.HeaderText = "客户";
            this.ShopName.Name = "ShopName";
            this.ShopName.ReadOnly = true;
            this.ShopName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GuideName
            // 
            this.GuideName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GuideName.DataPropertyName = "AdminUserName";
            this.GuideName.HeaderText = "操作人";
            this.GuideName.Name = "GuideName";
            this.GuideName.ReadOnly = true;
            this.GuideName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GuideName.Width = 66;
            // 
            // CancelUserName
            // 
            this.CancelUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CancelUserName.DataPropertyName = "CancelUserName";
            this.CancelUserName.HeaderText = "冲单用户";
            this.CancelUserName.Name = "CancelUserName";
            this.CancelUserName.ReadOnly = true;
            this.CancelUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalCountDataGridViewTextBoxColumn
            // 
            this.totalCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalCountDataGridViewTextBoxColumn.DataPropertyName = "TotalCount";
            this.totalCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.totalCountDataGridViewTextBoxColumn.Name = "totalCountDataGridViewTextBoxColumn";
            this.totalCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCountDataGridViewTextBoxColumn.Width = 66;
            // 
            // PaymentBalanceOld
            // 
            this.PaymentBalanceOld.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PaymentBalanceOld.DataPropertyName = "PaymentBalanceOld";
            this.PaymentBalanceOld.HeaderText = "上欠金额";
            this.PaymentBalanceOld.Name = "PaymentBalanceOld";
            this.PaymentBalanceOld.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPfPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "本次应收金额";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 120;
            // 
            // PaymentBalance
            // 
            this.PaymentBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PaymentBalance.DataPropertyName = "PaymentBalance";
            this.PaymentBalance.HeaderText = "应收总额";
            this.PaymentBalance.Name = "PaymentBalance";
            this.PaymentBalance.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "CreateTime";
            this.Column3.HeaderText = "单据时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // entryTimeDataGridViewTextBoxColumn
            // 
            this.entryTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.entryTimeDataGridViewTextBoxColumn.DataPropertyName = "EntryTime";
            this.entryTimeDataGridViewTextBoxColumn.HeaderText = "制单时间";
            this.entryTimeDataGridViewTextBoxColumn.Name = "entryTimeDataGridViewTextBoxColumn";
            this.entryTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryTimeDataGridViewTextBoxColumn.Width = 90;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "Remarks";
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 54;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.State.DataPropertyName = "StateName";
            this.State.HeaderText = "状态";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.State.Width = 67;
            // 
            // ColumnCancel
            // 
            this.ColumnCancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCancel.HeaderText = "冲单";
            this.ColumnCancel.Name = "ColumnCancel";
            this.ColumnCancel.ReadOnly = true;
            this.ColumnCancel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCancel.Text = "冲单";
            this.ColumnCancel.UseColumnTextForLinkValue = true;
            this.ColumnCancel.Width = 40;
            // 
            // ColumnRedo
            // 
            this.ColumnRedo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnRedo.HeaderText = "重做";
            this.ColumnRedo.Name = "ColumnRedo";
            this.ColumnRedo.ReadOnly = true;
            this.ColumnRedo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnRedo.Text = "重做";
            this.ColumnRedo.UseColumnTextForLinkValue = true;
            this.ColumnRedo.Width = 40;
            // 
            // ColumnPick
            // 
            this.ColumnPick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPick.HeaderText = "提单";
            this.ColumnPick.Name = "ColumnPick";
            this.ColumnPick.ReadOnly = true;
            this.ColumnPick.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPick.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnPick.Text = "提单";
            this.ColumnPick.UseColumnTextForLinkValue = true;
            this.ColumnPick.Width = 40;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "导出";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Text = "导出";
            this.Column4.UseColumnTextForLinkValue = true;
            this.Column4.Width = 40;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "打印";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "打印";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // WholesaleOrderManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "WholesaleOrderManageCtrl";
            this.Load += new System.EventHandler(this.ReturnOrderManageCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private  JGNet.Common.TextBox skinTextBox_OrderID;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private Common.CostumeTextBox skinTextBox_costumeID;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.QuickDateSelector quickDateSelector1;
        private PfCustomerComboBox skinComboBox_PfCustomer;
        private System.Windows.Forms.BindingSource outboundDetailBindingSource;
        private CCWin.SkinControl.SkinComboBox pfType;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinComboBox skinComboBox_State;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuideName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CancelUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentBalanceOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnCancel;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRedo;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnPick;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}
