using JGNet.Common;
using JGNet.Core.InteractEntity;

namespace JGNet.Manage
{
    partial class GetRetailSummaryCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetRetailSummaryCtrl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outboundDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.skinComboBoxShopID = new CCWin.SkinControl.SkinComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyWeiXinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyAlipayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyCash2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyBankCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyVipCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyIntegrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDeductedByTicketDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeChat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alipay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnionpayCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dateDataGridViewTextBoxColumn1,
            this.WeChat,
            this.Alipay,
            this.MoneyOther,
            this.Cash,
            this.UnionpayCard,
            this.Card,
            this.Integrate,
            this.Ticket,
            this.Sum});
            this.dataGridView1.DataSource = this.outboundDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 604);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // outboundDetailBindingSource
            // 
            this.outboundDetailBindingSource.DataSource = typeof(JGNet.Core.InteractEntity.RetailSummaryInfo);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton2);
            this.skinPanel1.Controls.Add(this.skinComboBoxShopID);
            this.skinPanel1.Controls.Add(this.label1);
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 46);
            this.skinPanel1.TabIndex = 0;
            this.skinPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPanel1_Paint);
            // 
            // baseButton2
            // 
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(649, 5);
            this.baseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton2.Size = new System.Drawing.Size(75, 32);
            this.baseButton2.TabIndex = 133;
            this.baseButton2.Text = "导出";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(45, 11);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(129, 22);
            this.skinComboBoxShopID.TabIndex = 132;
            this.skinComboBoxShopID.WaterText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 131;
            this.label1.Text = "店铺";
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
            this.quickDateSelector1.Location = new System.Drawing.Point(522, 10);
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
            this.dateTimePicker_End.Location = new System.Drawing.Point(396, 12);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_End.TabIndex = 4;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(225, 12);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(568, 6);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 5;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(360, 14);
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
            this.skinLabel2.Location = new System.Drawing.Point(189, 14);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 10;
            this.skinLabel2.Text = "开始";
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 46);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView2);
            this.skinSplitContainer1.Panel2Collapsed = true;
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 604);
            this.skinSplitContainer1.SplitterDistance = 280;
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
            this.dateDataGridViewTextBoxColumn,
            this.moneyWeiXinDataGridViewTextBoxColumn,
            this.moneyAlipayDataGridViewTextBoxColumn,
            this.moneyCash2DataGridViewTextBoxColumn,
            this.moneyBankCardDataGridViewTextBoxColumn,
            this.moneyVipCardDataGridViewTextBoxColumn,
            this.moneyIntegrationDataGridViewTextBoxColumn,
            this.moneyDeductedByTicketDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.outboundDetailBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1160, 604);
            this.dataGridView2.TabIndex = 7;
            // 
            // CostPrice
            // 
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "成本价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyWeiXinDataGridViewTextBoxColumn
            // 
            this.moneyWeiXinDataGridViewTextBoxColumn.DataPropertyName = "MoneyWeiXin";
            this.moneyWeiXinDataGridViewTextBoxColumn.HeaderText = "MoneyWeiXin";
            this.moneyWeiXinDataGridViewTextBoxColumn.Name = "moneyWeiXinDataGridViewTextBoxColumn";
            this.moneyWeiXinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyAlipayDataGridViewTextBoxColumn
            // 
            this.moneyAlipayDataGridViewTextBoxColumn.DataPropertyName = "MoneyAlipay";
            this.moneyAlipayDataGridViewTextBoxColumn.HeaderText = "MoneyAlipay";
            this.moneyAlipayDataGridViewTextBoxColumn.Name = "moneyAlipayDataGridViewTextBoxColumn";
            this.moneyAlipayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyCash2DataGridViewTextBoxColumn
            // 
            this.moneyCash2DataGridViewTextBoxColumn.DataPropertyName = "MoneyCash2";
            this.moneyCash2DataGridViewTextBoxColumn.HeaderText = "MoneyCash2";
            this.moneyCash2DataGridViewTextBoxColumn.Name = "moneyCash2DataGridViewTextBoxColumn";
            this.moneyCash2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyBankCardDataGridViewTextBoxColumn
            // 
            this.moneyBankCardDataGridViewTextBoxColumn.DataPropertyName = "MoneyBankCard";
            this.moneyBankCardDataGridViewTextBoxColumn.HeaderText = "MoneyBankCard";
            this.moneyBankCardDataGridViewTextBoxColumn.Name = "moneyBankCardDataGridViewTextBoxColumn";
            this.moneyBankCardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyVipCardDataGridViewTextBoxColumn
            // 
            this.moneyVipCardDataGridViewTextBoxColumn.DataPropertyName = "MoneyVipCard";
            this.moneyVipCardDataGridViewTextBoxColumn.HeaderText = "MoneyVipCard";
            this.moneyVipCardDataGridViewTextBoxColumn.Name = "moneyVipCardDataGridViewTextBoxColumn";
            this.moneyVipCardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyIntegrationDataGridViewTextBoxColumn
            // 
            this.moneyIntegrationDataGridViewTextBoxColumn.DataPropertyName = "MoneyIntegration";
            this.moneyIntegrationDataGridViewTextBoxColumn.HeaderText = "MoneyIntegration";
            this.moneyIntegrationDataGridViewTextBoxColumn.Name = "moneyIntegrationDataGridViewTextBoxColumn";
            this.moneyIntegrationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyDeductedByTicketDataGridViewTextBoxColumn
            // 
            this.moneyDeductedByTicketDataGridViewTextBoxColumn.DataPropertyName = "MoneyDeductedByTicket";
            this.moneyDeductedByTicketDataGridViewTextBoxColumn.HeaderText = "MoneyDeductedByTicket";
            this.moneyDeductedByTicketDataGridViewTextBoxColumn.Name = "moneyDeductedByTicketDataGridViewTextBoxColumn";
            this.moneyDeductedByTicketDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn1.Width = 140;
            // 
            // WeChat
            // 
            this.WeChat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WeChat.DataPropertyName = "MoneyWeiXin";
            this.WeChat.HeaderText = "微信";
            this.WeChat.Name = "WeChat";
            this.WeChat.ReadOnly = true;
            this.WeChat.Width = 140;
            // 
            // Alipay
            // 
            this.Alipay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Alipay.DataPropertyName = "MoneyAlipay";
            this.Alipay.HeaderText = "支付宝";
            this.Alipay.Name = "Alipay";
            this.Alipay.ReadOnly = true;
            this.Alipay.Width = 130;
            // 
            // MoneyOther
            // 
            this.MoneyOther.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MoneyOther.DataPropertyName = "MoneyOther";
            this.MoneyOther.HeaderText = "其他";
            this.MoneyOther.Name = "MoneyOther";
            this.MoneyOther.ReadOnly = true;
            this.MoneyOther.Width = 120;
            // 
            // Cash
            // 
            this.Cash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cash.DataPropertyName = "ShowCash";
            this.Cash.HeaderText = "现金";
            this.Cash.Name = "Cash";
            this.Cash.ReadOnly = true;
            this.Cash.Width = 120;
            // 
            // UnionpayCard
            // 
            this.UnionpayCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UnionpayCard.DataPropertyName = "MoneyBankCard";
            this.UnionpayCard.HeaderText = "银联卡";
            this.UnionpayCard.Name = "UnionpayCard";
            this.UnionpayCard.ReadOnly = true;
            this.UnionpayCard.Width = 120;
            // 
            // Card
            // 
            this.Card.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Card.DataPropertyName = "MoneyVipCard";
            this.Card.HeaderText = "储值卡";
            this.Card.Name = "Card";
            this.Card.ReadOnly = true;
            this.Card.Width = 120;
            // 
            // Integrate
            // 
            this.Integrate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Integrate.DataPropertyName = "MoneyIntegration";
            this.Integrate.HeaderText = "积分";
            this.Integrate.Name = "Integrate";
            this.Integrate.ReadOnly = true;
            this.Integrate.Width = 112;
            // 
            // Ticket
            // 
            this.Ticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ticket.DataPropertyName = "MoneyDeductedByTicket";
            this.Ticket.HeaderText = "优惠券";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            this.Ticket.Width = 111;
            // 
            // Sum
            // 
            this.Sum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "合计";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            this.Sum.Width = 54;
            // 
            // GetRetailSummaryCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "GetRetailSummaryCtrl";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinComboBox skinComboBoxShopID;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue2DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceSumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyWeiXinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyAlipayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyCash2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyBankCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyVipCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyIntegrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDeductedByTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private Common.Components.BaseButton baseButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alipay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnionpayCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}
