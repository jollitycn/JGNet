using JGNet.Common;

namespace JGNet.Manage
{
    partial class EmRefundOrderManageCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmRefundOrderManageCtrl));
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxRefundState = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxOrderState = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelOrderState = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.textBoxPhoneOrName = new JGNet.Common.TextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxOrderId = new JGNet.Common.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinTextBoxID = new JGNet.Manage.EmCostumeTextBox();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmRefundOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoneyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmRetailOrderStateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundStateColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinPanel2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.splitContainer1);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.Location = new System.Drawing.Point(0, 74);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 576);
            this.skinPanel2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 576);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.EmRefundOrderID,
            this.MemberID,
            this.SaleCountColumn,
            this.TotalMoneyColumn,
            this.CreateTime,
            this.EmRetailOrderStateColumn,
            this.RefundStateColumn,
            this.Column2});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 219);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.EmRefundOrder);
            // 
            // skinPanel1
            // 
            this.skinPanel1.AutoSize = true;
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.skinComboBoxRefundState);
            this.skinPanel1.Controls.Add(this.skinComboBoxOrderState);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabelOrderState);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.textBoxPhoneOrName);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinTextBoxOrderId);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Controls.Add(this.skinTextBoxID);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 74);
            this.skinPanel1.TabIndex = 0;
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
            this.quickDateSelector1.Location = new System.Drawing.Point(745, 43);
            this.quickDateSelector1.Name = "quickDateSelector1";
            this.quickDateSelector1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Size = new System.Drawing.Size(32, 25);
            this.quickDateSelector1.SkinAllColor = true;
            this.quickDateSelector1.StartDateTimePicker = this.dateTimePicker_Start;
            this.quickDateSelector1.TabIndex = 126;
            this.quickDateSelector1.Text = "quickDateSelector1";
            this.quickDateSelector1.TitleAnamorphosis = true;
            this.quickDateSelector1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.quickDateSelector1.TitleRadius = 4;
            this.quickDateSelector1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(611, 45);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker_End.TabIndex = 104;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(434, 45);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker_Start.TabIndex = 103;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(573, 47);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 105;
            this.skinLabel5.Text = "结束";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(399, 47);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 106;
            this.skinLabel6.Text = "开始";
            // 
            // skinComboBoxRefundState
            // 
            this.skinComboBoxRefundState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxRefundState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxRefundState.FormattingEnabled = true;
            this.skinComboBoxRefundState.Location = new System.Drawing.Point(254, 44);
            this.skinComboBoxRefundState.Name = "skinComboBoxRefundState";
            this.skinComboBoxRefundState.Size = new System.Drawing.Size(130, 22);
            this.skinComboBoxRefundState.TabIndex = 101;
            this.skinComboBoxRefundState.WaterText = "";
            // 
            // skinComboBoxOrderState
            // 
            this.skinComboBoxOrderState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxOrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxOrderState.FormattingEnabled = true;
            this.skinComboBoxOrderState.Location = new System.Drawing.Point(62, 44);
            this.skinComboBoxOrderState.Name = "skinComboBoxOrderState";
            this.skinComboBoxOrderState.Size = new System.Drawing.Size(130, 22);
            this.skinComboBoxOrderState.TabIndex = 101;
            this.skinComboBoxOrderState.WaterText = "";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(195, 47);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 102;
            this.skinLabel4.Text = "退款状态";
            // 
            // skinLabelOrderState
            // 
            this.skinLabelOrderState.AutoSize = true;
            this.skinLabelOrderState.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelOrderState.BorderColor = System.Drawing.Color.White;
            this.skinLabelOrderState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelOrderState.Location = new System.Drawing.Point(3, 47);
            this.skinLabelOrderState.Name = "skinLabelOrderState";
            this.skinLabelOrderState.Size = new System.Drawing.Size(56, 17);
            this.skinLabelOrderState.TabIndex = 102;
            this.skinLabelOrderState.Text = "订单状态";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(387, 14);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(44, 17);
            this.skinLabel3.TabIndex = 100;
            this.skinLabel3.Text = "收货人";
            // 
            // textBoxPhoneOrName
            // 
            this.textBoxPhoneOrName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPhoneOrName.DownBack = null;
            this.textBoxPhoneOrName.Icon = null;
            this.textBoxPhoneOrName.IconIsButton = false;
            this.textBoxPhoneOrName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxPhoneOrName.IsPasswordChat = '\0';
            this.textBoxPhoneOrName.IsSystemPasswordChar = false;
            this.textBoxPhoneOrName.Lines = new string[0];
            this.textBoxPhoneOrName.Location = new System.Drawing.Point(434, 8);
            this.textBoxPhoneOrName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxPhoneOrName.MaxLength = 32767;
            this.textBoxPhoneOrName.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxPhoneOrName.MouseBack = null;
            this.textBoxPhoneOrName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxPhoneOrName.Multiline = false;
            this.textBoxPhoneOrName.Name = "textBoxPhoneOrName";
            this.textBoxPhoneOrName.NormlBack = null;
            this.textBoxPhoneOrName.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxPhoneOrName.ReadOnly = false;
            this.textBoxPhoneOrName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPhoneOrName.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.textBoxPhoneOrName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhoneOrName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPhoneOrName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxPhoneOrName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxPhoneOrName.SkinTxt.Name = "BaseText";
            this.textBoxPhoneOrName.SkinTxt.Size = new System.Drawing.Size(120, 18);
            this.textBoxPhoneOrName.SkinTxt.TabIndex = 0;
            this.textBoxPhoneOrName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxPhoneOrName.SkinTxt.WaterText = "手机/姓名";
            this.textBoxPhoneOrName.TabIndex = 99;
            this.textBoxPhoneOrName.TabStop = true;
            this.textBoxPhoneOrName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPhoneOrName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxPhoneOrName.WaterText = "手机/姓名";
            this.textBoxPhoneOrName.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(3, 14);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 100;
            this.skinLabel2.Text = "订单编号";
            // 
            // skinTextBoxOrderId
            // 
            this.skinTextBoxOrderId.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxOrderId.DownBack = null;
            this.skinTextBoxOrderId.Icon = null;
            this.skinTextBoxOrderId.IconIsButton = false;
            this.skinTextBoxOrderId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxOrderId.IsPasswordChat = '\0';
            this.skinTextBoxOrderId.IsSystemPasswordChar = false;
            this.skinTextBoxOrderId.Lines = new string[0];
            this.skinTextBoxOrderId.Location = new System.Drawing.Point(62, 8);
            this.skinTextBoxOrderId.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxOrderId.MaxLength = 32767;
            this.skinTextBoxOrderId.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxOrderId.MouseBack = null;
            this.skinTextBoxOrderId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxOrderId.Multiline = false;
            this.skinTextBoxOrderId.Name = "skinTextBoxOrderId";
            this.skinTextBoxOrderId.NormlBack = null;
            this.skinTextBoxOrderId.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxOrderId.ReadOnly = false;
            this.skinTextBoxOrderId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxOrderId.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.skinTextBoxOrderId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxOrderId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxOrderId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxOrderId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxOrderId.SkinTxt.Name = "BaseText";
            this.skinTextBoxOrderId.SkinTxt.Size = new System.Drawing.Size(120, 18);
            this.skinTextBoxOrderId.SkinTxt.TabIndex = 0;
            this.skinTextBoxOrderId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxOrderId.SkinTxt.WaterText = "";
            this.skinTextBoxOrderId.TabIndex = 99;
            this.skinTextBoxOrderId.TabStop = true;
            this.skinTextBoxOrderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxOrderId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxOrderId.WaterText = "";
            this.skinTextBoxOrderId.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(219, 14);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "款号";
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(795, 39);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "查询";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinTextBoxID
            // 
            this.skinTextBoxID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxID.DownBack = null;
            this.skinTextBoxID.EmOnline = true;
            this.skinTextBoxID.FilterValid = true;
            this.skinTextBoxID.Icon = null;
            this.skinTextBoxID.IconIsButton = false;
            this.skinTextBoxID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxID.IsPasswordChat = '\0';
            this.skinTextBoxID.IsSystemPasswordChar = false;
            this.skinTextBoxID.Lines = new string[0];
            this.skinTextBoxID.Location = new System.Drawing.Point(254, 8);
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
            this.skinTextBoxID.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.skinTextBoxID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxID.SkinTxt.Name = "BaseText";
            this.skinTextBoxID.SkinTxt.Size = new System.Drawing.Size(120, 18);
            this.skinTextBoxID.SkinTxt.TabIndex = 0;
            this.skinTextBoxID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.SkinTxt.WaterText = "款号/名称";
            this.skinTextBoxID.TabIndex = 0;
            this.skinTextBoxID.TabStop = true;
            this.skinTextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.WaterText = "款号/名称";
            this.skinTextBoxID.WordWrap = true;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "EmRetailOrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "订单编号";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderIDDataGridViewTextBoxColumn.Width = 132;
            // 
            // EmRefundOrderID
            // 
            this.EmRefundOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmRefundOrderID.DataPropertyName = "ID";
            this.EmRefundOrderID.HeaderText = "退货单号";
            this.EmRefundOrderID.Name = "EmRefundOrderID";
            this.EmRefundOrderID.ReadOnly = true;
            this.EmRefundOrderID.Width = 133;
            // 
            // MemberID
            // 
            this.MemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MemberID.DataPropertyName = "MemeberID";
            this.MemberID.HeaderText = "会员卡号";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Width = 132;
            // 
            // SaleCountColumn
            // 
            this.SaleCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SaleCountColumn.DataPropertyName = "TotalCount";
            this.SaleCountColumn.HeaderText = "退货数量";
            this.SaleCountColumn.Name = "SaleCountColumn";
            this.SaleCountColumn.ReadOnly = true;
            this.SaleCountColumn.Width = 132;
            // 
            // TotalMoneyColumn
            // 
            this.TotalMoneyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TotalMoneyColumn.DataPropertyName = "TotalMoneyRefund";
            this.TotalMoneyColumn.HeaderText = "应退金额";
            this.TotalMoneyColumn.Name = "TotalMoneyColumn";
            this.TotalMoneyColumn.ReadOnly = true;
            this.TotalMoneyColumn.Width = 132;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "申请退款时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 133;
            // 
            // EmRetailOrderStateColumn
            // 
            this.EmRetailOrderStateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmRetailOrderStateColumn.DataPropertyName = "EmRetailOrderStateName";
            this.EmRetailOrderStateColumn.HeaderText = "订单状态";
            this.EmRetailOrderStateColumn.Name = "EmRetailOrderStateColumn";
            this.EmRetailOrderStateColumn.ReadOnly = true;
            this.EmRetailOrderStateColumn.Width = 132;
            // 
            // RefundStateColumn
            // 
            this.RefundStateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RefundStateColumn.DataPropertyName = "RefundStateName";
            this.RefundStateColumn.HeaderText = "退货状态";
            this.RefundStateColumn.Name = "RefundStateColumn";
            this.RefundStateColumn.ReadOnly = true;
            this.RefundStateColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RefundStateColumn.Width = 132;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "查看物流";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "查看物流";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 59;
            // 
            // EmRefundOrderManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.Name = "EmRefundOrderManageCtrl";
            this.Load += new System.EventHandler(this.EmRefundOrderManageCtrl_Load);
            this.skinPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.Panel skinPanel2;
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Common.Components.BaseButton BaseButton3;
        private Manage.EmCostumeTextBox skinTextBoxID;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private TextBox skinTextBoxOrderId;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private TextBox textBoxPhoneOrName;
        private CCWin.SkinControl.SkinComboBox skinComboBoxOrderState;
        private CCWin.SkinControl.SkinLabel skinLabelOrderState;
        private CCWin.SkinControl.SkinComboBox skinComboBoxRefundState;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Common.Components.QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmRefundOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoneyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmRetailOrderStateColumn;
        private System.Windows.Forms.DataGridViewLinkColumn RefundStateColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}
