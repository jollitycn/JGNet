using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    partial class RetailDistributorCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetailDistributorCtrl));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBoxCommission = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.unconsumedComboBox = new CCWin.SkinControl.SkinComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.textBoxName = new JGNet.Common.TextBox();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinTextBoxTitle = new JGNet.Common.TextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.baseButtonImport = new JGNet.Common.Components.BaseButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.skinTreeViewClass = new CCWin.SkinControl.SkinTreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdTimeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accruedCommissionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingCommissionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withdrawCommissionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seeCommissionDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.刪除ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 92);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新增ToolStripMenuItem.Text = "新增下线会员";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改ToolStripMenuItem.Text = "编辑";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.刪除ToolStripMenuItem.Text = "删除";
            this.刪除ToolStripMenuItem.Visible = false;
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(20, 20);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBoxCommission);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.unconsumedComboBox);
            this.skinPanel1.Controls.Add(this.label1);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.textBoxName);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Controls.Add(this.skinTextBoxTitle);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.baseButtonImport);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(767, 81);
            this.skinPanel1.TabIndex = 76;
            // 
            // skinComboBoxCommission
            // 
            this.skinComboBoxCommission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxCommission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxCommission.FormattingEnabled = true;
            this.skinComboBoxCommission.Location = new System.Drawing.Point(77, 47);
            this.skinComboBoxCommission.Name = "skinComboBoxCommission";
            this.skinComboBoxCommission.Size = new System.Drawing.Size(120, 22);
            this.skinComboBoxCommission.TabIndex = 167;
            this.skinComboBoxCommission.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(4, 49);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 166;
            this.skinLabel2.Text = "查看佣金：";
            // 
            // unconsumedComboBox
            // 
            this.unconsumedComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.unconsumedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unconsumedComboBox.FormattingEnabled = true;
            this.unconsumedComboBox.Location = new System.Drawing.Point(539, 9);
            this.unconsumedComboBox.Name = "unconsumedComboBox";
            this.unconsumedComboBox.Size = new System.Drawing.Size(120, 22);
            this.unconsumedComboBox.TabIndex = 165;
            this.unconsumedComboBox.WaterText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 164;
            this.label1.Text = "未消费天数";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(245, 13);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 163;
            this.skinLabel1.Text = "姓名：";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxName.DownBack = null;
            this.textBoxName.Icon = null;
            this.textBoxName.IconIsButton = false;
            this.textBoxName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxName.IsPasswordChat = '\0';
            this.textBoxName.IsSystemPasswordChar = false;
            this.textBoxName.Lines = new string[0];
            this.textBoxName.Location = new System.Drawing.Point(289, 7);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxName.MouseBack = null;
            this.textBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.NormlBack = null;
            this.textBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxName.ReadOnly = false;
            this.textBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxName.Size = new System.Drawing.Size(169, 28);
            // 
            // 
            // 
            this.textBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxName.SkinTxt.Name = "BaseText";
            this.textBoxName.SkinTxt.Size = new System.Drawing.Size(159, 18);
            this.textBoxName.SkinTxt.TabIndex = 0;
            this.textBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxName.SkinTxt.WaterText = "";
            this.textBoxName.TabIndex = 162;
            this.textBoxName.TabStop = true;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxName.WaterText = "";
            this.textBoxName.WordWrap = true;
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(672, 3);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 161;
            this.BaseButton3.Text = "查询";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton3_Click);
            // 
            // skinTextBoxTitle
            // 
            this.skinTextBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxTitle.DownBack = null;
            this.skinTextBoxTitle.Icon = null;
            this.skinTextBoxTitle.IconIsButton = false;
            this.skinTextBoxTitle.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxTitle.IsPasswordChat = '\0';
            this.skinTextBoxTitle.IsSystemPasswordChar = false;
            this.skinTextBoxTitle.Lines = new string[0];
            this.skinTextBoxTitle.Location = new System.Drawing.Point(76, 7);
            this.skinTextBoxTitle.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxTitle.MaxLength = 32767;
            this.skinTextBoxTitle.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxTitle.MouseBack = null;
            this.skinTextBoxTitle.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxTitle.Multiline = false;
            this.skinTextBoxTitle.Name = "skinTextBoxTitle";
            this.skinTextBoxTitle.NormlBack = null;
            this.skinTextBoxTitle.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxTitle.ReadOnly = false;
            this.skinTextBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxTitle.Size = new System.Drawing.Size(163, 28);
            // 
            // 
            // 
            this.skinTextBoxTitle.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxTitle.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxTitle.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxTitle.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxTitle.SkinTxt.Name = "BaseText";
            this.skinTextBoxTitle.SkinTxt.Size = new System.Drawing.Size(153, 18);
            this.skinTextBoxTitle.SkinTxt.TabIndex = 0;
            this.skinTextBoxTitle.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxTitle.SkinTxt.WaterText = "";
            this.skinTextBoxTitle.TabIndex = 160;
            this.skinTextBoxTitle.TabStop = true;
            this.skinTextBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxTitle.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxTitle.WaterText = "";
            this.skinTextBoxTitle.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(16, 13);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(44, 17);
            this.skinLabel7.TabIndex = 159;
            this.skinLabel7.Text = "卡号：";
            // 
            // baseButton1
            // 
            this.baseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.DownBack")));
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(672, 43);
            this.baseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.MouseBack")));
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.NormlBack")));
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 151;
            this.baseButton1.Text = "导出";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Visible = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // baseButtonImport
            // 
            this.baseButtonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonImport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonImport.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonImport.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonImport.Location = new System.Drawing.Point(570, 43);
            this.baseButtonImport.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonImport.Name = "baseButtonImport";
            this.baseButtonImport.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonImport.Size = new System.Drawing.Size(75, 32);
            this.baseButtonImport.TabIndex = 149;
            this.baseButtonImport.Text = "导入";
            this.baseButtonImport.UseVisualStyleBackColor = false;
            this.baseButtonImport.Visible = false;
            this.baseButtonImport.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 650);
            this.panel1.TabIndex = 77;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.skinTreeViewClass);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.skinPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 650);
            this.splitContainer1.SplitterDistance = 389;
            this.splitContainer1.TabIndex = 77;
            this.splitContainer1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.splitContainer1_Scroll);
            // 
            // skinTreeViewClass
            // 
            this.skinTreeViewClass.ContextMenuStrip = this.contextMenuStrip1;
            this.skinTreeViewClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTreeViewClass.ImageIndex = 0;
            this.skinTreeViewClass.ImageList = this.imageList1;
            this.skinTreeViewClass.Indent = 25;
            this.skinTreeViewClass.ItemHeight = 25;
            this.skinTreeViewClass.Location = new System.Drawing.Point(0, 0);
            this.skinTreeViewClass.Name = "skinTreeViewClass";
            this.skinTreeViewClass.PathSeparator = "-";
            this.skinTreeViewClass.SelectedImageIndex = 0;
            this.skinTreeViewClass.Size = new System.Drawing.Size(389, 650);
            this.skinTreeViewClass.TabIndex = 76;
            this.skinTreeViewClass.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.skinTreeViewClass_NodeMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 569);
            this.panel2.TabIndex = 77;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn2,
            this.createdTimeDataGridViewTextBoxColumn2,
            this.accruedCommissionDataGridViewTextBoxColumn2,
            this.remainingCommissionDataGridViewTextBoxColumn2,
            this.withdrawCommissionDataGridViewTextBoxColumn2,
            this.seeCommissionDataGridViewCheckBoxColumn2,
            this.Column1,
            this.Column2});
            this.dataGridView3.DataSource = this.memberBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(767, 569);
            this.dataGridView3.TabIndex = 191;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValueChanged);
            this.dataGridView3.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView3_EditingControlShowing);
            this.dataGridView3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView3_Scroll);
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(JGNet.Member);
            // 
            // phoneNumberDataGridViewTextBoxColumn2
            // 
            this.phoneNumberDataGridViewTextBoxColumn2.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn2.HeaderText = "卡号";
            this.phoneNumberDataGridViewTextBoxColumn2.Name = "phoneNumberDataGridViewTextBoxColumn2";
            this.phoneNumberDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // createdTimeDataGridViewTextBoxColumn2
            // 
            this.createdTimeDataGridViewTextBoxColumn2.DataPropertyName = "CreatedTime";
            this.createdTimeDataGridViewTextBoxColumn2.HeaderText = "注册时间";
            this.createdTimeDataGridViewTextBoxColumn2.Name = "createdTimeDataGridViewTextBoxColumn2";
            this.createdTimeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // accruedCommissionDataGridViewTextBoxColumn2
            // 
            this.accruedCommissionDataGridViewTextBoxColumn2.DataPropertyName = "AccruedCommission";
            this.accruedCommissionDataGridViewTextBoxColumn2.HeaderText = "累计佣金";
            this.accruedCommissionDataGridViewTextBoxColumn2.Name = "accruedCommissionDataGridViewTextBoxColumn2";
            this.accruedCommissionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // remainingCommissionDataGridViewTextBoxColumn2
            // 
            this.remainingCommissionDataGridViewTextBoxColumn2.DataPropertyName = "RemainingCommission";
            this.remainingCommissionDataGridViewTextBoxColumn2.HeaderText = "可提现佣金";
            this.remainingCommissionDataGridViewTextBoxColumn2.Name = "remainingCommissionDataGridViewTextBoxColumn2";
            this.remainingCommissionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // withdrawCommissionDataGridViewTextBoxColumn2
            // 
            this.withdrawCommissionDataGridViewTextBoxColumn2.DataPropertyName = "WithdrawCommission";
            this.withdrawCommissionDataGridViewTextBoxColumn2.HeaderText = "已提现佣金";
            this.withdrawCommissionDataGridViewTextBoxColumn2.Name = "withdrawCommissionDataGridViewTextBoxColumn2";
            this.withdrawCommissionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // seeCommissionDataGridViewCheckBoxColumn2
            // 
            this.seeCommissionDataGridViewCheckBoxColumn2.DataPropertyName = "SeeCommission";
            this.seeCommissionDataGridViewCheckBoxColumn2.FalseValue = "False";
            this.seeCommissionDataGridViewCheckBoxColumn2.HeaderText = "查看佣金";
            this.seeCommissionDataGridViewCheckBoxColumn2.Name = "seeCommissionDataGridViewCheckBoxColumn2";
            this.seeCommissionDataGridViewCheckBoxColumn2.TrueValue = "True";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "佣金明细";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "佣金明细";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "编辑";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "编辑";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // RetailDistributorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "RetailDistributorCtrl";
            this.Load += new System.EventHandler(this.PermissonCtrl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

            }


        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 新增ToolStripMenuItem;
        private ToolStripMenuItem 修改ToolStripMenuItem;
        private ToolStripMenuItem 刪除ToolStripMenuItem;
        private ImageList imageList1;
        private Common.Components.BaseButton baseButtonImport;
        private Common.Components.DownTemplateButton baseButtonDownTemplate;
        private Panel skinPanel1;
        private Panel panel1;
        private Common.Components.BaseButton baseButton1;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private Common.TextBox skinTextBoxTitle;
        private Common.Components.BaseButton BaseButton3;
        private SplitContainer splitContainer1;
        private CCWin.SkinControl.SkinTreeView skinTreeViewClass;
        private Panel panel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.TextBox textBoxName;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinComboBox unconsumedComboBox;
        private Label label1;
        private CCWin.SkinControl.SkinComboBox skinComboBoxCommission;
        private BindingSource memberBindingSource;
        private DataGridView dataGridView3;
        private ToolStripMenuItem 刷新ToolStripMenuItem;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn createdTimeDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn accruedCommissionDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn remainingCommissionDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn withdrawCommissionDataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn seeCommissionDataGridViewCheckBoxColumn2;
        private DataGridViewLinkColumn Column1;
        private DataGridViewLinkColumn Column2;
    }
}
