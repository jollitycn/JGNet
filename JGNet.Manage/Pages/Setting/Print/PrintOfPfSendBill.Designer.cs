using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    partial class PrintOfPfSendBill
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
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridViewSys = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ischeckDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.printSysInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewColumns = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ischeckDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.printColumnsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericTxtCount = new JGNet.Common.NumericTextBox();
            this.txtDataName = new JGNet.Common.TextBox();
            this.lblCount = new CCWin.SkinControl.SkinLabel();
            this.lblName = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblName10 = new CCWin.SkinControl.SkinLabel();
            this.lblName9 = new CCWin.SkinControl.SkinLabel();
            this.lblName8 = new CCWin.SkinControl.SkinLabel();
            this.lblCurDataName = new CCWin.SkinControl.SkinLabel();
            this.lblName7 = new CCWin.SkinControl.SkinLabel();
            this.lblName1 = new CCWin.SkinControl.SkinLabel();
            this.lblName5 = new CCWin.SkinControl.SkinLabel();
            this.lblName3 = new CCWin.SkinControl.SkinLabel();
            this.lblName6 = new CCWin.SkinControl.SkinLabel();
            this.lblName4 = new CCWin.SkinControl.SkinLabel();
            this.lblName2 = new CCWin.SkinControl.SkinLabel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.baseButtonSave = new JGNet.Common.Components.BaseButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printSysInfoBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printColumnsInfoBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.panel4);
            this.skinSplitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinLabel1);
            this.skinSplitContainer1.Panel2.Controls.Add(this.panel7);
            this.skinSplitContainer1.Panel2.Controls.Add(this.dataGridView3);
            this.skinSplitContainer1.Panel2.Controls.Add(this.panel2);
            this.skinSplitContainer1.Panel2.Controls.Add(this.panel1);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1145, 677);
            this.skinSplitContainer1.SplitterDistance = 271;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 72;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 600);
            this.panel4.TabIndex = 78;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridViewSys);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 233);
            this.panel6.TabIndex = 134;
            // 
            // dataGridViewSys
            // 
            this.dataGridViewSys.AllowUserToAddRows = false;
            this.dataGridViewSys.AllowUserToDeleteRows = false;
            this.dataGridViewSys.AutoGenerateColumns = false;
            this.dataGridViewSys.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.ischeckDataGridViewCheckBoxColumn1});
            this.dataGridViewSys.DataSource = this.printSysInfoBindingSource;
            this.dataGridViewSys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSys.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSys.MultiSelect = false;
            this.dataGridViewSys.Name = "dataGridViewSys";
            this.dataGridViewSys.RowHeadersVisible = false;
            this.dataGridViewSys.RowTemplate.Height = 23;
            this.dataGridViewSys.Size = new System.Drawing.Size(271, 233);
            this.dataGridViewSys.TabIndex = 133;
            this.dataGridViewSys.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSys_CellContentClick);
            this.dataGridViewSys.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSys_CellValueChanged);
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "ischeck";
            this.Column5.FalseValue = "false";
            this.Column5.HeaderText = "选择";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.TrueValue = "true";
            this.Column5.Width = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "系统变量";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 210;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ischeckDataGridViewCheckBoxColumn1
            // 
            this.ischeckDataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ischeckDataGridViewCheckBoxColumn1.DataPropertyName = "ischeck";
            this.ischeckDataGridViewCheckBoxColumn1.HeaderText = "ischeck";
            this.ischeckDataGridViewCheckBoxColumn1.Name = "ischeckDataGridViewCheckBoxColumn1";
            this.ischeckDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // printSysInfoBindingSource
            // 
            this.printSysInfoBindingSource.DataSource = typeof(JGNet.Core.InteractEntity.PrintSysInfo);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewColumns);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 367);
            this.panel5.TabIndex = 136;
            // 
            // dataGridViewColumns
            // 
            this.dataGridViewColumns.AllowUserToAddRows = false;
            this.dataGridViewColumns.AllowUserToDeleteRows = false;
            this.dataGridViewColumns.AutoGenerateColumns = false;
            this.dataGridViewColumns.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.nameDataGridViewTextBoxColumn,
            this.ischeckDataGridViewCheckBoxColumn});
            this.dataGridViewColumns.DataSource = this.printColumnsInfoBindingSource;
            this.dataGridViewColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewColumns.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewColumns.MultiSelect = false;
            this.dataGridViewColumns.Name = "dataGridViewColumns";
            this.dataGridViewColumns.RowHeadersVisible = false;
            this.dataGridViewColumns.RowTemplate.Height = 23;
            this.dataGridViewColumns.Size = new System.Drawing.Size(271, 367);
            this.dataGridViewColumns.TabIndex = 134;
            this.dataGridViewColumns.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewColumns_CellValueChanged);
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ischeck";
            this.dataGridViewCheckBoxColumn2.FalseValue = "false";
            this.dataGridViewCheckBoxColumn2.HeaderText = "选择";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewCheckBoxColumn2.TrueValue = "true";
            this.dataGridViewCheckBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "表格列名";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // ischeckDataGridViewCheckBoxColumn
            // 
            this.ischeckDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ischeckDataGridViewCheckBoxColumn.DataPropertyName = "ischeck";
            this.ischeckDataGridViewCheckBoxColumn.HeaderText = "ischeck";
            this.ischeckDataGridViewCheckBoxColumn.Name = "ischeckDataGridViewCheckBoxColumn";
            this.ischeckDataGridViewCheckBoxColumn.Visible = false;
            // 
            // printColumnsInfoBindingSource
            // 
            this.printColumnsInfoBindingSource.DataSource = typeof(JGNet.Core.InteractEntity.PrintColumnsInfo);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericTxtCount);
            this.panel3.Controls.Add(this.txtDataName);
            this.panel3.Controls.Add(this.lblCount);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(271, 77);
            this.panel3.TabIndex = 73;
            // 
            // numericTxtCount
            // 
            this.numericTxtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericTxtCount.BackColor = System.Drawing.Color.Transparent;
            this.numericTxtCount.DecimalPlaces = 0;
            this.numericTxtCount.DownBack = null;
            this.numericTxtCount.Icon = null;
            this.numericTxtCount.IconIsButton = false;
            this.numericTxtCount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTxtCount.IsPasswordChat = '\0';
            this.numericTxtCount.IsSystemPasswordChar = false;
            this.numericTxtCount.Lines = new string[] {
        "1"};
            this.numericTxtCount.Location = new System.Drawing.Point(80, 10);
            this.numericTxtCount.Margin = new System.Windows.Forms.Padding(0);
            this.numericTxtCount.MaxLength = 29;
            this.numericTxtCount.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTxtCount.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTxtCount.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTxtCount.MouseBack = null;
            this.numericTxtCount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTxtCount.Multiline = false;
            this.numericTxtCount.Name = "numericTxtCount";
            this.numericTxtCount.NormlBack = null;
            this.numericTxtCount.Padding = new System.Windows.Forms.Padding(5);
            this.numericTxtCount.ReadOnly = false;
            this.numericTxtCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTxtCount.ShowZero = false;
            this.numericTxtCount.Size = new System.Drawing.Size(176, 28);
            // 
            // 
            // 
            this.numericTxtCount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTxtCount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTxtCount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTxtCount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTxtCount.SkinTxt.MaxLength = 29;
            this.numericTxtCount.SkinTxt.Name = "BaseText";
            this.numericTxtCount.SkinTxt.Size = new System.Drawing.Size(166, 18);
            this.numericTxtCount.SkinTxt.TabIndex = 0;
            this.numericTxtCount.SkinTxt.Text = "1";
            this.numericTxtCount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTxtCount.SkinTxt.WaterText = "";
            this.numericTxtCount.TabIndex = 0;
            this.numericTxtCount.Text = "1";
            this.numericTxtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTxtCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTxtCount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTxtCount.WaterText = "";
            this.numericTxtCount.WordWrap = true;
            // 
            // txtDataName
            // 
            this.txtDataName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataName.BackColor = System.Drawing.Color.Transparent;
            this.txtDataName.DownBack = null;
            this.txtDataName.Icon = null;
            this.txtDataName.IconIsButton = false;
            this.txtDataName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDataName.IsPasswordChat = '\0';
            this.txtDataName.IsSystemPasswordChar = false;
            this.txtDataName.Lines = new string[] {
        "批发发货单"};
            this.txtDataName.Location = new System.Drawing.Point(80, 43);
            this.txtDataName.Margin = new System.Windows.Forms.Padding(0);
            this.txtDataName.MaxLength = 32767;
            this.txtDataName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDataName.MouseBack = null;
            this.txtDataName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDataName.Multiline = false;
            this.txtDataName.Name = "txtDataName";
            this.txtDataName.NormlBack = null;
            this.txtDataName.Padding = new System.Windows.Forms.Padding(5);
            this.txtDataName.ReadOnly = false;
            this.txtDataName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDataName.Size = new System.Drawing.Size(176, 28);
            // 
            // 
            // 
            this.txtDataName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDataName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtDataName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDataName.SkinTxt.Name = "BaseText";
            this.txtDataName.SkinTxt.Size = new System.Drawing.Size(166, 18);
            this.txtDataName.SkinTxt.TabIndex = 0;
            this.txtDataName.SkinTxt.Text = "批发发货单";
            this.txtDataName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDataName.SkinTxt.WaterText = "";
            this.txtDataName.TabIndex = 12;
            this.txtDataName.TabStop = true;
            this.txtDataName.Text = "批发发货单";
            this.txtDataName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDataName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDataName.WaterText = "";
            this.txtDataName.WordWrap = true;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.BorderColor = System.Drawing.Color.White;
            this.lblCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.Location = new System.Drawing.Point(9, 15);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(68, 17);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "打印份数：";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(9, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "单据名称：";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Red;
            this.skinLabel1.Location = new System.Drawing.Point(10, 247);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(128, 17);
            this.skinLabel1.TabIndex = 93;
            this.skinLabel1.Text = "拖动调整表格打印列宽";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.lblName10);
            this.panel7.Controls.Add(this.lblName9);
            this.panel7.Controls.Add(this.lblName8);
            this.panel7.Controls.Add(this.lblCurDataName);
            this.panel7.Controls.Add(this.lblName7);
            this.panel7.Controls.Add(this.lblName1);
            this.panel7.Controls.Add(this.lblName5);
            this.panel7.Controls.Add(this.lblName3);
            this.panel7.Controls.Add(this.lblName6);
            this.panel7.Controls.Add(this.lblName4);
            this.panel7.Controls.Add(this.lblName2);
            this.panel7.Location = new System.Drawing.Point(3, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(860, 228);
            this.panel7.TabIndex = 90;
            // 
            // lblName10
            // 
            this.lblName10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName10.AutoSize = true;
            this.lblName10.BackColor = System.Drawing.Color.Transparent;
            this.lblName10.BorderColor = System.Drawing.Color.White;
            this.lblName10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName10.Location = new System.Drawing.Point(20, 197);
            this.lblName10.Name = "lblName10";
            this.lblName10.Size = new System.Drawing.Size(56, 17);
            this.lblName10.TabIndex = 92;
            this.lblName10.Text = "系统变量";
            this.lblName10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName9
            // 
            this.lblName9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName9.AutoSize = true;
            this.lblName9.BackColor = System.Drawing.Color.Transparent;
            this.lblName9.BorderColor = System.Drawing.Color.White;
            this.lblName9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName9.Location = new System.Drawing.Point(542, 160);
            this.lblName9.Name = "lblName9";
            this.lblName9.Size = new System.Drawing.Size(56, 17);
            this.lblName9.TabIndex = 91;
            this.lblName9.Text = "系统变量";
            this.lblName9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName8
            // 
            this.lblName8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName8.AutoSize = true;
            this.lblName8.BackColor = System.Drawing.Color.Transparent;
            this.lblName8.BorderColor = System.Drawing.Color.White;
            this.lblName8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName8.Location = new System.Drawing.Point(279, 160);
            this.lblName8.Name = "lblName8";
            this.lblName8.Size = new System.Drawing.Size(56, 17);
            this.lblName8.TabIndex = 90;
            this.lblName8.Text = "系统变量";
            this.lblName8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCurDataName
            // 
            this.lblCurDataName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurDataName.AutoSize = true;
            this.lblCurDataName.BackColor = System.Drawing.Color.Transparent;
            this.lblCurDataName.BorderColor = System.Drawing.Color.White;
            this.lblCurDataName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurDataName.Location = new System.Drawing.Point(333, 38);
            this.lblCurDataName.Name = "lblCurDataName";
            this.lblCurDataName.Size = new System.Drawing.Size(68, 17);
            this.lblCurDataName.TabIndex = 76;
            this.lblCurDataName.Text = "单据名称：";
            this.lblCurDataName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName7
            // 
            this.lblName7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName7.AutoSize = true;
            this.lblName7.BackColor = System.Drawing.Color.Transparent;
            this.lblName7.BorderColor = System.Drawing.Color.White;
            this.lblName7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName7.Location = new System.Drawing.Point(20, 160);
            this.lblName7.Name = "lblName7";
            this.lblName7.Size = new System.Drawing.Size(56, 17);
            this.lblName7.TabIndex = 89;
            this.lblName7.Text = "系统变量";
            this.lblName7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName1
            // 
            this.lblName1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName1.AutoSize = true;
            this.lblName1.BackColor = System.Drawing.Color.Transparent;
            this.lblName1.BorderColor = System.Drawing.Color.White;
            this.lblName1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName1.Location = new System.Drawing.Point(20, 85);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(56, 17);
            this.lblName1.TabIndex = 77;
            this.lblName1.Text = "系统变量";
            this.lblName1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName5
            // 
            this.lblName5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName5.AutoSize = true;
            this.lblName5.BackColor = System.Drawing.Color.Transparent;
            this.lblName5.BorderColor = System.Drawing.Color.White;
            this.lblName5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName5.Location = new System.Drawing.Point(279, 120);
            this.lblName5.Name = "lblName5";
            this.lblName5.Size = new System.Drawing.Size(56, 17);
            this.lblName5.TabIndex = 85;
            this.lblName5.Text = "系统变量";
            this.lblName5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName3
            // 
            this.lblName3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName3.AutoSize = true;
            this.lblName3.BackColor = System.Drawing.Color.Transparent;
            this.lblName3.BorderColor = System.Drawing.Color.White;
            this.lblName3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName3.Location = new System.Drawing.Point(542, 85);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(56, 17);
            this.lblName3.TabIndex = 81;
            this.lblName3.Text = "系统变量";
            this.lblName3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName6
            // 
            this.lblName6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName6.AutoSize = true;
            this.lblName6.BackColor = System.Drawing.Color.Transparent;
            this.lblName6.BorderColor = System.Drawing.Color.White;
            this.lblName6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName6.Location = new System.Drawing.Point(542, 120);
            this.lblName6.Name = "lblName6";
            this.lblName6.Size = new System.Drawing.Size(56, 17);
            this.lblName6.TabIndex = 87;
            this.lblName6.Text = "系统变量";
            this.lblName6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName4
            // 
            this.lblName4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName4.AutoSize = true;
            this.lblName4.BackColor = System.Drawing.Color.Transparent;
            this.lblName4.BorderColor = System.Drawing.Color.White;
            this.lblName4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName4.Location = new System.Drawing.Point(20, 120);
            this.lblName4.Name = "lblName4";
            this.lblName4.Size = new System.Drawing.Size(56, 17);
            this.lblName4.TabIndex = 83;
            this.lblName4.Text = "系统变量";
            this.lblName4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblName2
            // 
            this.lblName2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName2.AutoSize = true;
            this.lblName2.BackColor = System.Drawing.Color.Transparent;
            this.lblName2.BorderColor = System.Drawing.Color.White;
            this.lblName2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName2.Location = new System.Drawing.Point(279, 85);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(56, 17);
            this.lblName2.TabIndex = 79;
            this.lblName2.Text = "系统变量";
            this.lblName2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.Location = new System.Drawing.Point(10, 266);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(846, 129);
            this.dataGridView3.TabIndex = 75;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.baseButtonSave);
            this.panel2.Location = new System.Drawing.Point(3, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 76);
            this.panel2.TabIndex = 74;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSave.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonSave.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSave.Location = new System.Drawing.Point(385, 22);
            this.baseButtonSave.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonSave.Name = "baseButtonSave";
            this.baseButtonSave.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonSave.Size = new System.Drawing.Size(75, 32);
            this.baseButtonSave.TabIndex = 2;
            this.baseButtonSave.Text = "保存";
            this.baseButtonSave.UseVisualStyleBackColor = false;
            this.baseButtonSave.Click += new System.EventHandler(this.baseButtonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 10);
            this.panel1.TabIndex = 72;
            // 
            // PrintOfPfSendBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Name = "PrintOfPfSendBill";
            this.Size = new System.Drawing.Size(1145, 677);
            this.Load += new System.EventHandler(this.PrintSettingCtrl_Load);
            this.SizeChanged += new System.EventHandler(this.PrintOfPfSendBill_SizeChanged);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.PerformLayout();
            this.skinSplitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printSysInfoBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printColumnsInfoBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

            }

         

        #endregion
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
         
        private Panel panel1;
        private CCWin.SkinControl.SkinLabel lblCount;
        private Panel panel3;
        private CCWin.SkinControl.SkinLabel lblName;
        private Common.TextBox txtDataName;
        private Panel panel2;
        private Common.Components.BaseButton baseButtonSave;
        private Common.NumericTextBox numericTxtCount;
        private DataGridView dataGridView3;
        private CCWin.SkinControl.SkinLabel lblCurDataName;
        private CCWin.SkinControl.SkinLabel lblName7;
        private CCWin.SkinControl.SkinLabel lblName6;
        private CCWin.SkinControl.SkinLabel lblName5;
        private CCWin.SkinControl.SkinLabel lblName4;
        private CCWin.SkinControl.SkinLabel lblName3;
        private CCWin.SkinControl.SkinLabel lblName2;
        private CCWin.SkinControl.SkinLabel lblName1;
        private Panel panel4;
        private BindingSource printSysInfoBindingSource;
        private BindingSource printColumnsInfoBindingSource;
        private DataGridView dataGridViewSys;
        private Panel panel6;
        private Panel panel5;
        private DataGridView dataGridViewColumns;
        private Panel panel7;
        private CCWin.SkinControl.SkinLabel lblName8;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel lblName9;
        private CCWin.SkinControl.SkinLabel lblName10;
        private DataGridViewCheckBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn ischeckDataGridViewCheckBoxColumn1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ischeckDataGridViewCheckBoxColumn;
    }
}
