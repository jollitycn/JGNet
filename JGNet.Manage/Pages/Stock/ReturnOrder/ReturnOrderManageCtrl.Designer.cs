using JGNet.Common;
using JGNet.Common.Components;

namespace JGNet.Manage
{
    partial class ReturnOrderManageCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnOrderManageCtrl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnOrder = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DestShopNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuideName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCancel = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRedo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnPick = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnPrintBarcode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnPrint = new System.Windows.Forms.DataGridViewLinkColumn();
            this.outboundDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.txtRemark = new JGNet.Common.TextBox();
            this.skinComboBoxShopID = new JGNet.Common.ShopComboBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_State = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.rtType = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinTextBox_costumeID = new JGNet.Common.CostumeTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxSupplierID = new JGNet.Common.Components.SupllierComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_OrderID = new JGNet.Common.TextBox();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ColumnOrder,
            this.DestShopNameColumn,
            this.ShopName,
            this.GuideName,
            this.Column2,
            this.totalCountDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.Column3,
            this.entryTimeDataGridViewTextBoxColumn,
            this.State,
            this.Column6,
            this.ColumnCancel,
            this.ColumnRedo,
            this.ColumnPick,
            this.ColumnPrintBarcode,
            this.Column4,
            this.ColumnPrint});
            this.dataGridView1.DataSource = this.outboundDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "                                     ";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(968, 131);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // ColumnOrder
            // 
            this.ColumnOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnOrder.DataPropertyName = "ID";
            this.ColumnOrder.HeaderText = "采购单号";
            this.ColumnOrder.Name = "ColumnOrder";
            this.ColumnOrder.ReadOnly = true;
            this.ColumnOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DestShopNameColumn
            // 
            this.DestShopNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DestShopNameColumn.DataPropertyName = "DestShopName";
            this.DestShopNameColumn.HeaderText = "店铺";
            this.DestShopNameColumn.Name = "DestShopNameColumn";
            this.DestShopNameColumn.ReadOnly = true;
            this.DestShopNameColumn.Width = 90;
            // 
            // ShopName
            // 
            this.ShopName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShopName.DataPropertyName = "SupplierName";
            this.ShopName.HeaderText = "供应商";
            this.ShopName.Name = "ShopName";
            this.ShopName.ReadOnly = true;
            this.ShopName.Width = 80;
            // 
            // GuideName
            // 
            this.GuideName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GuideName.DataPropertyName = "UserName";
            this.GuideName.HeaderText = "操作人";
            this.GuideName.Name = "GuideName";
            this.GuideName.ReadOnly = true;
            this.GuideName.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "CancelUserName";
            this.Column2.HeaderText = "冲单用户";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column2.Width = 80;
            // 
            // totalCountDataGridViewTextBoxColumn
            // 
            this.totalCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalCountDataGridViewTextBoxColumn.DataPropertyName = "TotalCount";
            this.totalCountDataGridViewTextBoxColumn.HeaderText = "总数量";
            this.totalCountDataGridViewTextBoxColumn.Name = "totalCountDataGridViewTextBoxColumn";
            this.totalCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCountDataGridViewTextBoxColumn.Width = 80;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总成本";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "CreateTime";
            this.Column3.HeaderText = "单据时间";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // entryTimeDataGridViewTextBoxColumn
            // 
            this.entryTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.entryTimeDataGridViewTextBoxColumn.DataPropertyName = "EntryTime";
            this.entryTimeDataGridViewTextBoxColumn.HeaderText = "制单时间";
            this.entryTimeDataGridViewTextBoxColumn.Name = "entryTimeDataGridViewTextBoxColumn";
            this.entryTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // State
            // 
            this.State.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.State.DataPropertyName = "StateName";
            this.State.HeaderText = "状态";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 40;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "Remarks";
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // ColumnCancel
            // 
            this.ColumnCancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCancel.HeaderText = "冲单";
            this.ColumnCancel.Name = "ColumnCancel";
            this.ColumnCancel.ReadOnly = true;
            this.ColumnCancel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.ColumnPick.Text = "提单";
            this.ColumnPick.UseColumnTextForLinkValue = true;
            this.ColumnPick.Width = 40;
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
            this.ColumnPrintBarcode.Width = 70;
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
            // ColumnPrint
            // 
            this.ColumnPrint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPrint.HeaderText = "打印";
            this.ColumnPrint.Name = "ColumnPrint";
            this.ColumnPrint.ReadOnly = true;
            this.ColumnPrint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPrint.Text = "打印";
            this.ColumnPrint.UseColumnTextForLinkValue = true;
            this.ColumnPrint.Width = 40;
            // 
            // outboundDetailBindingSource
            // 
            this.outboundDetailBindingSource.DataSource = typeof(JGNet.PurchaseOrder);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel8);
            this.skinPanel1.Controls.Add(this.txtRemark);
            this.skinPanel1.Controls.Add(this.skinComboBoxShopID);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.skinComboBox_State);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.rtType);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Controls.Add(this.skinTextBox_costumeID);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinComboBoxSupplierID);
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
            this.skinPanel1.Size = new System.Drawing.Size(968, 75);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(762, 10);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 202;
            this.skinLabel8.Text = "备注";
            this.skinLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.Color.Transparent;
            this.txtRemark.DownBack = null;
            this.txtRemark.Icon = null;
            this.txtRemark.IconIsButton = false;
            this.txtRemark.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtRemark.IsPasswordChat = '\0';
            this.txtRemark.IsSystemPasswordChar = false;
            this.txtRemark.Lines = new string[0];
            this.txtRemark.Location = new System.Drawing.Point(797, 6);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(0);
            this.txtRemark.MaxLength = 32767;
            this.txtRemark.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtRemark.MouseBack = null;
            this.txtRemark.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtRemark.Multiline = false;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.NormlBack = null;
            this.txtRemark.Padding = new System.Windows.Forms.Padding(5);
            this.txtRemark.ReadOnly = false;
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemark.Size = new System.Drawing.Size(158, 28);
            // 
            // 
            // 
            this.txtRemark.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRemark.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtRemark.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtRemark.SkinTxt.Name = "BaseText";
            this.txtRemark.SkinTxt.Size = new System.Drawing.Size(148, 18);
            this.txtRemark.SkinTxt.TabIndex = 0;
            this.txtRemark.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRemark.SkinTxt.WaterText = "";
            this.txtRemark.TabIndex = 201;
            this.txtRemark.TabStop = true;
            this.txtRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRemark.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtRemark.WaterText = "";
            this.txtRemark.WordWrap = true;
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(614, 6);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(142, 22);
            this.skinComboBoxShopID.TabIndex = 199;
            this.skinComboBoxShopID.WaterText = "";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(576, 9);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 200;
            this.skinLabel6.Text = "店铺";
            this.skinLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinComboBox_State
            // 
            this.skinComboBox_State.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_State.FormattingEnabled = true;
            this.skinComboBox_State.Location = new System.Drawing.Point(224, 43);
            this.skinComboBox_State.Name = "skinComboBox_State";
            this.skinComboBox_State.Size = new System.Drawing.Size(142, 22);
            this.skinComboBox_State.TabIndex = 197;
            this.skinComboBox_State.WaterText = "";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(186, 46);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 198;
            this.skinLabel5.Text = "状态";
            // 
            // rtType
            // 
            this.rtType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rtType.FormattingEnabled = true;
            this.rtType.Location = new System.Drawing.Point(41, 43);
            this.rtType.Name = "rtType";
            this.rtType.Size = new System.Drawing.Size(142, 22);
            this.rtType.TabIndex = 196;
            this.rtType.WaterText = "";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(3, 46);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 195;
            this.skinLabel7.Text = "类型";
            this.skinLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.quickDateSelector1.Location = new System.Drawing.Point(761, 42);
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
            this.dateTimePicker_End.Location = new System.Drawing.Point(614, 44);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker_End.TabIndex = 4;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(419, 44);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.DownBack")));
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(878, 40);
            this.BaseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.MouseBack")));
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.NormlBack")));
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
            this.skinTextBox_costumeID.Location = new System.Drawing.Point(224, 3);
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
            this.skinLabel1.Location = new System.Drawing.Point(186, 9);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 25;
            this.skinLabel1.Text = "款号";
            // 
            // skinComboBoxSupplierID
            // 
            this.skinComboBoxSupplierID.AutoSize = true;
            this.skinComboBoxSupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxSupplierID.EnabledSupplier = true;
            this.skinComboBoxSupplierID.HideAll = false;
            this.skinComboBoxSupplierID.Location = new System.Drawing.Point(419, 6);
            this.skinComboBoxSupplierID.Name = "skinComboBoxSupplierID";
            this.skinComboBoxSupplierID.SelectedItem = ((JGNet.Supplier)(resources.GetObject("skinComboBoxSupplierID.SelectedItem")));
            this.skinComboBoxSupplierID.SelectedValue = null;
            this.skinComboBoxSupplierID.ShowAdd = false;
            this.skinComboBoxSupplierID.Size = new System.Drawing.Size(175, 26);
            this.skinComboBoxSupplierID.TabIndex = 2;
            this.skinComboBoxSupplierID.Title = null;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(369, 9);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(44, 17);
            this.skinLabel4.TabIndex = 23;
            this.skinLabel4.Text = "供应商";
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
            this.skinTextBox_OrderID.Location = new System.Drawing.Point(41, 3);
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
            this.skinLabel10.Location = new System.Drawing.Point(3, 9);
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
            this.skinLabel3.Location = new System.Drawing.Point(576, 46);
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
            this.skinLabel2.Location = new System.Drawing.Point(381, 46);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 10;
            this.skinLabel2.Text = "开始";
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.CollapsePanel = CCWin.SkinControl.CollapsePanel.Panel2;
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 75);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView2);
            this.skinSplitContainer1.Size = new System.Drawing.Size(968, 500);
            this.skinSplitContainer1.SplitterDistance = 131;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.costumeNameDataGridViewTextBoxColumn,
            this.Column1,
            this.colorNameDataGridViewTextBoxColumn,
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
            this.CostPrice,
            this.priceDataGridViewTextBoxColumn,
            this.sumCountDataGridViewTextBoxColumn,
            this.sumMoneyDataGridViewTextBoxColumn});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(968, 131);
            this.dataGridView2.TabIndex = 7;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "BrandName";
            this.Column1.HeaderText = "品牌";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
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
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "F";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.ReadOnly = true;
            this.fDataGridViewTextBoxColumn.Width = 48;
            // 
            // xSDataGridViewTextBoxColumn
            // 
            this.xSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xSDataGridViewTextBoxColumn.DataPropertyName = "XS";
            this.xSDataGridViewTextBoxColumn.HeaderText = "XS";
            this.xSDataGridViewTextBoxColumn.Name = "xSDataGridViewTextBoxColumn";
            this.xSDataGridViewTextBoxColumn.ReadOnly = true;
            this.xSDataGridViewTextBoxColumn.Width = 49;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 49;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.ReadOnly = true;
            this.mDataGridViewTextBoxColumn.Width = 48;
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            this.lDataGridViewTextBoxColumn.ReadOnly = true;
            this.lDataGridViewTextBoxColumn.Width = 49;
            // 
            // xLDataGridViewTextBoxColumn
            // 
            this.xLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xLDataGridViewTextBoxColumn.DataPropertyName = "XL";
            this.xLDataGridViewTextBoxColumn.HeaderText = "XL";
            this.xLDataGridViewTextBoxColumn.Name = "xLDataGridViewTextBoxColumn";
            this.xLDataGridViewTextBoxColumn.ReadOnly = true;
            this.xLDataGridViewTextBoxColumn.Width = 49;
            // 
            // xL2DataGridViewTextBoxColumn
            // 
            this.xL2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL2DataGridViewTextBoxColumn.DataPropertyName = "XL2";
            this.xL2DataGridViewTextBoxColumn.HeaderText = "2XL";
            this.xL2DataGridViewTextBoxColumn.Name = "xL2DataGridViewTextBoxColumn";
            this.xL2DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL2DataGridViewTextBoxColumn.Width = 49;
            // 
            // xL3DataGridViewTextBoxColumn
            // 
            this.xL3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL3DataGridViewTextBoxColumn.DataPropertyName = "XL3";
            this.xL3DataGridViewTextBoxColumn.HeaderText = "3XL";
            this.xL3DataGridViewTextBoxColumn.Name = "xL3DataGridViewTextBoxColumn";
            this.xL3DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL3DataGridViewTextBoxColumn.Width = 48;
            // 
            // xL4DataGridViewTextBoxColumn
            // 
            this.xL4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL4DataGridViewTextBoxColumn.DataPropertyName = "XL4";
            this.xL4DataGridViewTextBoxColumn.HeaderText = "4XL";
            this.xL4DataGridViewTextBoxColumn.Name = "xL4DataGridViewTextBoxColumn";
            this.xL4DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL4DataGridViewTextBoxColumn.Width = 49;
            // 
            // xL5DataGridViewTextBoxColumn
            // 
            this.xL5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL5DataGridViewTextBoxColumn.DataPropertyName = "XL5";
            this.xL5DataGridViewTextBoxColumn.HeaderText = "5XL";
            this.xL5DataGridViewTextBoxColumn.Name = "xL5DataGridViewTextBoxColumn";
            this.xL5DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL5DataGridViewTextBoxColumn.Width = 49;
            // 
            // xL6DataGridViewTextBoxColumn
            // 
            this.xL6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL6DataGridViewTextBoxColumn.DataPropertyName = "XL6";
            this.xL6DataGridViewTextBoxColumn.HeaderText = "6XL";
            this.xL6DataGridViewTextBoxColumn.Name = "xL6DataGridViewTextBoxColumn";
            this.xL6DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL6DataGridViewTextBoxColumn.Width = 48;
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "成本价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            this.CostPrice.Width = 60;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "吊牌价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 60;
            // 
            // sumCountDataGridViewTextBoxColumn
            // 
            this.sumCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sumCountDataGridViewTextBoxColumn.DataPropertyName = "SumCount";
            this.sumCountDataGridViewTextBoxColumn.HeaderText = "总量";
            this.sumCountDataGridViewTextBoxColumn.Name = "sumCountDataGridViewTextBoxColumn";
            this.sumCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumCountDataGridViewTextBoxColumn.Width = 48;
            // 
            // sumMoneyDataGridViewTextBoxColumn
            // 
            this.sumMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sumMoneyDataGridViewTextBoxColumn.DataPropertyName = "SumCost";
            this.sumMoneyDataGridViewTextBoxColumn.HeaderText = "总成本";
            this.sumMoneyDataGridViewTextBoxColumn.Name = "sumMoneyDataGridViewTextBoxColumn";
            this.sumMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumMoneyDataGridViewTextBoxColumn.Width = 66;
            // 
            // ReturnOrderManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "ReturnOrderManageCtrl";
            this.Size = new System.Drawing.Size(968, 575);
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
        private  JGNet.Common.TextBox skinTextBox_OrderID;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private SupllierComboBox skinComboBoxSupplierID;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private Common.CostumeTextBox skinTextBox_costumeID;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource outboundDetailBindingSource;
        private CCWin.SkinControl.SkinComboBox rtType;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinComboBox skinComboBox_State;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private ShopComboBox skinComboBoxShopID;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private TextBox txtRemark;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestShopNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuideName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnCancel;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRedo;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnPick;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnPrintBarcode;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
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
    }
}
