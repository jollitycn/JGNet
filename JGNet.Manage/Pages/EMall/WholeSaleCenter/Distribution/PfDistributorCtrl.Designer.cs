using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    partial class PfDistributorCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PfDistributorCtrl));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.baseButtonImport = new JGNet.Common.Components.BaseButton();
            this.baseButtonDownTemplate = new JGNet.Common.Components.DownTemplateButton();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBoxType = new CCWin.SkinControl.SkinComboBox();
            this.textBoxTel = new JGNet.Common.TextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.skinTreeViewClass = new CCWin.SkinControl.SkinTreeView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accruedCommissionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WithdrawCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withdrawCommissionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seeCommissionDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewLinkColumn2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PfCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PfCustomerBindingSource)).BeginInit();
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增ToolStripMenuItem.Text = "新增下线客户";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.修改ToolStripMenuItem.Text = "编辑";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.刪除ToolStripMenuItem.Text = "删除";
            this.刪除ToolStripMenuItem.Visible = false;
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(20, 20);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.baseButtonImport.Location = new System.Drawing.Point(788, 41);
            this.baseButtonImport.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonImport.Name = "baseButtonImport";
            this.baseButtonImport.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonImport.Size = new System.Drawing.Size(34, 32);
            this.baseButtonImport.TabIndex = 149;
            this.baseButtonImport.Text = "导入";
            this.baseButtonImport.UseVisualStyleBackColor = false;
            this.baseButtonImport.Visible = false;
            this.baseButtonImport.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // baseButtonDownTemplate
            // 
            this.baseButtonDownTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonDownTemplate.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonDownTemplate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonDownTemplate.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.DownBack")));
            this.baseButtonDownTemplate.DownName = null;
            this.baseButtonDownTemplate.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonDownTemplate.FileName = "类别.xls";
            this.baseButtonDownTemplate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonDownTemplate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonDownTemplate.Location = new System.Drawing.Point(823, 8);
            this.baseButtonDownTemplate.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.MouseBack")));
            this.baseButtonDownTemplate.Name = "baseButtonDownTemplate";
            this.baseButtonDownTemplate.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.NormlBack")));
            this.baseButtonDownTemplate.Size = new System.Drawing.Size(41, 32);
            this.baseButtonDownTemplate.TabIndex = 150;
            this.baseButtonDownTemplate.Text = "下载模板";
            this.baseButtonDownTemplate.UseVisualStyleBackColor = false;
            this.baseButtonDownTemplate.Visible = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBoxType);
            this.skinPanel1.Controls.Add(this.textBoxTel);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel3);
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
            this.skinPanel1.Controls.Add(this.baseButtonDownTemplate);
            this.skinPanel1.Controls.Add(this.baseButtonImport);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(873, 77);
            this.skinPanel1.TabIndex = 76;
            // 
            // skinComboBoxType
            // 
            this.skinComboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxType.FormattingEnabled = true;
            this.skinComboBoxType.Location = new System.Drawing.Point(301, 46);
            this.skinComboBoxType.Name = "skinComboBoxType";
            this.skinComboBoxType.Size = new System.Drawing.Size(120, 22);
            this.skinComboBoxType.TabIndex = 175;
            this.skinComboBoxType.WaterText = "";
            // 
            // textBoxTel
            // 
            this.textBoxTel.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTel.DownBack = null;
            this.textBoxTel.Icon = null;
            this.textBoxTel.IconIsButton = false;
            this.textBoxTel.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxTel.IsPasswordChat = '\0';
            this.textBoxTel.IsSystemPasswordChar = false;
            this.textBoxTel.Lines = new string[0];
            this.textBoxTel.Location = new System.Drawing.Point(76, 45);
            this.textBoxTel.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTel.MaxLength = 32767;
            this.textBoxTel.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxTel.MouseBack = null;
            this.textBoxTel.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxTel.Multiline = false;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.NormlBack = null;
            this.textBoxTel.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxTel.ReadOnly = false;
            this.textBoxTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxTel.Size = new System.Drawing.Size(169, 28);
            // 
            // 
            // 
            this.textBoxTel.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTel.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTel.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxTel.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxTel.SkinTxt.Name = "BaseText";
            this.textBoxTel.SkinTxt.Size = new System.Drawing.Size(159, 18);
            this.textBoxTel.SkinTxt.TabIndex = 0;
            this.textBoxTel.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxTel.SkinTxt.WaterText = "";
            this.textBoxTel.TabIndex = 174;
            this.textBoxTel.TabStop = true;
            this.textBoxTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxTel.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxTel.WaterText = "";
            this.textBoxTel.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(254, 50);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(44, 17);
            this.skinLabel4.TabIndex = 173;
            this.skinLabel4.Text = "类型：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(5, 51);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 172;
            this.skinLabel3.Text = "联系电话：";
            // 
            // skinComboBoxCommission
            // 
            this.skinComboBoxCommission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxCommission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxCommission.FormattingEnabled = true;
            this.skinComboBoxCommission.Location = new System.Drawing.Point(548, 46);
            this.skinComboBoxCommission.Name = "skinComboBoxCommission";
            this.skinComboBoxCommission.Size = new System.Drawing.Size(120, 22);
            this.skinComboBoxCommission.TabIndex = 171;
            this.skinComboBoxCommission.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(475, 48);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 170;
            this.skinLabel2.Text = "查看佣金：";
            // 
            // unconsumedComboBox
            // 
            this.unconsumedComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.unconsumedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unconsumedComboBox.FormattingEnabled = true;
            this.unconsumedComboBox.Location = new System.Drawing.Point(547, 11);
            this.unconsumedComboBox.Name = "unconsumedComboBox";
            this.unconsumedComboBox.Size = new System.Drawing.Size(120, 22);
            this.unconsumedComboBox.TabIndex = 169;
            this.unconsumedComboBox.WaterText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 168;
            this.label1.Text = "未消费天数";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(254, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 167;
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
            this.textBoxName.Location = new System.Drawing.Point(301, 9);
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
            this.textBoxName.TabIndex = 166;
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
            this.BaseButton3.Location = new System.Drawing.Point(684, 26);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 164;
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
            this.skinTextBoxTitle.Location = new System.Drawing.Point(76, 8);
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
            this.skinTextBoxTitle.Size = new System.Drawing.Size(169, 28);
            // 
            // 
            // 
            this.skinTextBoxTitle.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxTitle.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxTitle.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxTitle.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxTitle.SkinTxt.Name = "BaseText";
            this.skinTextBoxTitle.SkinTxt.Size = new System.Drawing.Size(159, 18);
            this.skinTextBoxTitle.SkinTxt.TabIndex = 0;
            this.skinTextBoxTitle.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxTitle.SkinTxt.WaterText = "";
            this.skinTextBoxTitle.TabIndex = 163;
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
            this.skinLabel7.Location = new System.Drawing.Point(29, 12);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(44, 17);
            this.skinLabel7.TabIndex = 162;
            this.skinLabel7.Text = "编号：";
            // 
            // baseButton1
            // 
            this.baseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.DownBack")));
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(827, 42);
            this.baseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.MouseBack")));
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.NormlBack")));
            this.baseButton1.Size = new System.Drawing.Size(37, 32);
            this.baseButton1.TabIndex = 151;
            this.baseButton1.Text = "导出";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Visible = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 650);
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
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer1.Panel2.Controls.Add(this.skinPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1314, 650);
            this.splitContainer1.SplitterDistance = 437;
            this.splitContainer1.TabIndex = 77;
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
            this.skinTreeViewClass.Size = new System.Drawing.Size(437, 650);
            this.skinTreeViewClass.TabIndex = 76;
            this.skinTreeViewClass.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.skinTreeViewClass_NodeMouseClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.createTimeDataGridViewTextBoxColumn,
            this.customerTypeNameDataGridViewTextBoxColumn,
            this.contactPhoneDataGridViewTextBoxColumn,
            this.accruedCommissionDataGridViewTextBoxColumn1,
            this.WithdrawCommission,
            this.withdrawCommissionDataGridViewTextBoxColumn1,
            this.seeCommissionDataGridViewCheckBoxColumn1,
            this.dataGridViewLinkColumn1,
            this.dataGridViewLinkColumn2});
            this.dataGridView3.DataSource = this.PfCustomerBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 77);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(873, 573);
            this.dataGridView3.TabIndex = 192;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellValueChanged);
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "注册时间";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerTypeNameDataGridViewTextBoxColumn
            // 
            this.customerTypeNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerTypeName";
            this.customerTypeNameDataGridViewTextBoxColumn.HeaderText = "类型";
            this.customerTypeNameDataGridViewTextBoxColumn.Name = "customerTypeNameDataGridViewTextBoxColumn";
            this.customerTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactPhoneDataGridViewTextBoxColumn
            // 
            this.contactPhoneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhone";
            this.contactPhoneDataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.contactPhoneDataGridViewTextBoxColumn.Name = "contactPhoneDataGridViewTextBoxColumn";
            this.contactPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accruedCommissionDataGridViewTextBoxColumn1
            // 
            this.accruedCommissionDataGridViewTextBoxColumn1.DataPropertyName = "AccruedCommission";
            this.accruedCommissionDataGridViewTextBoxColumn1.HeaderText = "累积佣金";
            this.accruedCommissionDataGridViewTextBoxColumn1.Name = "accruedCommissionDataGridViewTextBoxColumn1";
            this.accruedCommissionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // WithdrawCommission
            // 
            this.WithdrawCommission.DataPropertyName = "RemainingCommission";
            this.WithdrawCommission.HeaderText = "可提现佣金";
            this.WithdrawCommission.Name = "WithdrawCommission";
            this.WithdrawCommission.ReadOnly = true;
            // 
            // withdrawCommissionDataGridViewTextBoxColumn1
            // 
            this.withdrawCommissionDataGridViewTextBoxColumn1.DataPropertyName = "WithdrawCommission";
            this.withdrawCommissionDataGridViewTextBoxColumn1.HeaderText = "已提现佣金";
            this.withdrawCommissionDataGridViewTextBoxColumn1.Name = "withdrawCommissionDataGridViewTextBoxColumn1";
            this.withdrawCommissionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // seeCommissionDataGridViewCheckBoxColumn1
            // 
            this.seeCommissionDataGridViewCheckBoxColumn1.DataPropertyName = "SeeCommission";
            this.seeCommissionDataGridViewCheckBoxColumn1.FalseValue = "False";
            this.seeCommissionDataGridViewCheckBoxColumn1.HeaderText = "查看佣金";
            this.seeCommissionDataGridViewCheckBoxColumn1.Name = "seeCommissionDataGridViewCheckBoxColumn1";
            this.seeCommissionDataGridViewCheckBoxColumn1.TrueValue = "True";
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "佣金明细";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLinkColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewLinkColumn1.Text = "佣金明细";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn1.Width = 70;
            // 
            // dataGridViewLinkColumn2
            // 
            this.dataGridViewLinkColumn2.HeaderText = "编辑";
            this.dataGridViewLinkColumn2.Name = "dataGridViewLinkColumn2";
            this.dataGridViewLinkColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLinkColumn2.Text = "编辑";
            this.dataGridViewLinkColumn2.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn2.Width = 40;
            // 
            // PfCustomerBindingSource
            // 
            this.PfCustomerBindingSource.DataSource = typeof(JGNet.PfCustomer);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CreateTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "注册时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CustomerTypeName";
            this.dataGridViewTextBoxColumn4.HeaderText = "类型";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ContactPhone";
            this.dataGridViewTextBoxColumn5.HeaderText = "联系电话";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AccruedCommission";
            this.dataGridViewTextBoxColumn6.HeaderText = "累积佣金";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RemainingCommission";
            this.dataGridViewTextBoxColumn7.HeaderText = "可提现佣金";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "WithdrawCommission";
            this.dataGridViewTextBoxColumn8.HeaderText = "已提现佣金";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "SeeCommission";
            this.dataGridViewCheckBoxColumn1.FalseValue = "False";
            this.dataGridViewCheckBoxColumn1.HeaderText = "查看佣金";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "True";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // PfDistributorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PfDistributorCtrl";
            this.Size = new System.Drawing.Size(1314, 650);
            this.Load += new System.EventHandler(this.PermissonCtrl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PfCustomerBindingSource)).EndInit();
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
        private CCWin.SkinControl.SkinTreeView skinTreeViewClass;
        private Common.Components.BaseButton baseButton1;
        private Common.Components.BaseButton BaseButton3;
        private Common.TextBox skinTextBoxTitle;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private SplitContainer splitContainer1;
        private BindingSource PfCustomerBindingSource;
        private CCWin.SkinControl.SkinComboBox unconsumedComboBox;
        private Label label1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.TextBox textBoxName;
        private CCWin.SkinControl.SkinComboBox skinComboBoxCommission;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private Common.TextBox textBoxTel;
        private CCWin.SkinControl.SkinComboBox skinComboBoxType;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accruedCommissionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn WithdrawCommission;
        private DataGridViewTextBoxColumn withdrawCommissionDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn seeCommissionDataGridViewCheckBoxColumn1;
        private DataGridViewLinkColumn dataGridViewLinkColumn1;
        private DataGridViewLinkColumn dataGridViewLinkColumn2;
        private ToolStripMenuItem 刷新ToolStripMenuItem;
    }
}
