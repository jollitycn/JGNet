namespace JGNet.Manage.Pages
{
    partial class PfDistributorCommissionCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PfDistributorCommissionCtrl));
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.baseButton4 = new JGNet.Common.Components.BaseButton();
            this.baseButtonDownTemplate = new JGNet.Common.Components.DownTemplateButton();
            this.baseButtonImport = new JGNet.Common.Components.BaseButton();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinTextBoxName = new JGNet.Common.TextBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accruedCommissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.RemainingCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(JGNet.Distributor);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.dataGridView1);
            this.skinPanel1.Controls.Add(this.skinPanel2);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 650);
            this.skinPanel1.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.accruedCommissionDataGridViewTextBoxColumn,
            this.RemainingCommission});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 611);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.skinLabel1);
            this.skinPanel2.Controls.Add(this.quickDateSelector1);
            this.skinPanel2.Controls.Add(this.dateTimePicker_End);
            this.skinPanel2.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel2.Controls.Add(this.skinLabel3);
            this.skinPanel2.Controls.Add(this.skinLabel2);
            this.skinPanel2.Controls.Add(this.baseButton4);
            this.skinPanel2.Controls.Add(this.baseButtonDownTemplate);
            this.skinPanel2.Controls.Add(this.baseButtonImport);
            this.skinPanel2.Controls.Add(this.BaseButton1);
            this.skinPanel2.Controls.Add(this.baseButton2);
            this.skinPanel2.Controls.Add(this.BaseButton3);
            this.skinPanel2.Controls.Add(this.skinTextBoxName);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 39);
            this.skinPanel2.TabIndex = 0;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(378, 11);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 160;
            this.skinLabel1.Text = "分销人员";
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
            this.quickDateSelector1.Location = new System.Drawing.Point(343, 7);
            this.quickDateSelector1.Name = "quickDateSelector1";
            this.quickDateSelector1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Size = new System.Drawing.Size(32, 25);
            this.quickDateSelector1.SkinAllColor = true;
            this.quickDateSelector1.StartDateTimePicker = this.dateTimePicker_Start;
            this.quickDateSelector1.TabIndex = 159;
            this.quickDateSelector1.Text = "quickDateSelector1";
            this.quickDateSelector1.TitleAnamorphosis = true;
            this.quickDateSelector1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.quickDateSelector1.TitleRadius = 4;
            this.quickDateSelector1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(219, 9);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker_End.TabIndex = 156;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(48, 9);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(124, 21);
            this.dateTimePicker_Start.TabIndex = 155;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(181, 11);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 157;
            this.skinLabel3.Text = "结束";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(13, 13);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 158;
            this.skinLabel2.Text = "开始";
            // 
            // baseButton4
            // 
            this.baseButton4.BackColor = System.Drawing.Color.Transparent;
            this.baseButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton4.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton4.DownBack")));
            this.baseButton4.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton4.Location = new System.Drawing.Point(1072, 4);
            this.baseButton4.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton4.MouseBack")));
            this.baseButton4.Name = "baseButton4";
            this.baseButton4.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton4.NormlBack")));
            this.baseButton4.Size = new System.Drawing.Size(75, 32);
            this.baseButton4.TabIndex = 148;
            this.baseButton4.Text = "导出";
            this.baseButton4.UseVisualStyleBackColor = false;
            this.baseButton4.Visible = false;
            this.baseButton4.Click += new System.EventHandler(this.baseButton4_Click);
            // 
            // baseButtonDownTemplate
            // 
            this.baseButtonDownTemplate.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonDownTemplate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonDownTemplate.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.DownBack")));
            this.baseButtonDownTemplate.DownName = null;
            this.baseButtonDownTemplate.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonDownTemplate.FileName = "客户.xls";
            this.baseButtonDownTemplate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonDownTemplate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonDownTemplate.Location = new System.Drawing.Point(910, 4);
            this.baseButtonDownTemplate.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.MouseBack")));
            this.baseButtonDownTemplate.Name = "baseButtonDownTemplate";
            this.baseButtonDownTemplate.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.NormlBack")));
            this.baseButtonDownTemplate.Size = new System.Drawing.Size(75, 32);
            this.baseButtonDownTemplate.TabIndex = 147;
            this.baseButtonDownTemplate.Text = "下载模板";
            this.baseButtonDownTemplate.UseVisualStyleBackColor = false;
            this.baseButtonDownTemplate.Visible = false;
            // 
            // baseButtonImport
            // 
            this.baseButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonImport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonImport.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonImport.DownBack")));
            this.baseButtonImport.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonImport.Location = new System.Drawing.Point(991, 4);
            this.baseButtonImport.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonImport.MouseBack")));
            this.baseButtonImport.Name = "baseButtonImport";
            this.baseButtonImport.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonImport.NormlBack")));
            this.baseButtonImport.Size = new System.Drawing.Size(75, 32);
            this.baseButtonImport.TabIndex = 146;
            this.baseButtonImport.Text = "导入";
            this.baseButtonImport.UseVisualStyleBackColor = false;
            this.baseButtonImport.Visible = false;
            this.baseButtonImport.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.DownBack")));
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(613, 5);
            this.BaseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.MouseBack")));
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.NormlBack")));
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 1;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButtonQuery_Click);
            // 
            // baseButton2
            // 
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.DownBack")));
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(829, 4);
            this.baseButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.MouseBack")));
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.NormlBack")));
            this.baseButton2.Size = new System.Drawing.Size(75, 32);
            this.baseButton2.TabIndex = 2;
            this.baseButton2.Text = "充值";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Visible = false;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = ((System.Drawing.Image)(resources.GetObject("BaseButton3.DownBack")));
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(748, 4);
            this.BaseButton3.MouseBack = ((System.Drawing.Image)(resources.GetObject("BaseButton3.MouseBack")));
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = ((System.Drawing.Image)(resources.GetObject("BaseButton3.NormlBack")));
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "添加";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Visible = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButtonAdd_Click);
            // 
            // skinTextBoxName
            // 
            this.skinTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxName.DownBack = null;
            this.skinTextBoxName.Icon = null;
            this.skinTextBoxName.IconIsButton = false;
            this.skinTextBoxName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.IsPasswordChat = '\0';
            this.skinTextBoxName.IsSystemPasswordChar = false;
            this.skinTextBoxName.Lines = new string[0];
            this.skinTextBoxName.Location = new System.Drawing.Point(437, 7);
            this.skinTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxName.MaxLength = 32767;
            this.skinTextBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxName.MouseBack = null;
            this.skinTextBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.Multiline = false;
            this.skinTextBoxName.Name = "skinTextBoxName";
            this.skinTextBoxName.NormlBack = null;
            this.skinTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxName.ReadOnly = false;
            this.skinTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxName.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.skinTextBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxName.SkinTxt.Name = "BaseText";
            this.skinTextBoxName.SkinTxt.Size = new System.Drawing.Size(154, 18);
            this.skinTextBoxName.SkinTxt.TabIndex = 0;
            this.skinTextBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.SkinTxt.WaterText = "编号或名称";
            this.skinTextBoxName.TabIndex = 0;
            this.skinTextBoxName.TabStop = true;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "编号或名称";
            this.skinTextBoxName.WordWrap = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "分销人员";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // accruedCommissionDataGridViewTextBoxColumn
            // 
            this.accruedCommissionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.accruedCommissionDataGridViewTextBoxColumn.DataPropertyName = "AccruedCommission4Day";
            this.accruedCommissionDataGridViewTextBoxColumn.HeaderText = "佣金";
            this.accruedCommissionDataGridViewTextBoxColumn.Name = "accruedCommissionDataGridViewTextBoxColumn";
            this.accruedCommissionDataGridViewTextBoxColumn.ReadOnly = true;
            this.accruedCommissionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accruedCommissionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accruedCommissionDataGridViewTextBoxColumn.Width = 400;
            // 
            // RemainingCommission
            // 
            this.RemainingCommission.DataPropertyName = "RemainingCommission";
            this.RemainingCommission.HeaderText = "可提现佣金";
            this.RemainingCommission.Name = "RemainingCommission";
            this.RemainingCommission.ReadOnly = true;
            this.RemainingCommission.Width = 400;
            // 
            // PfDistributorCommissionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel1);
            this.Name = "PfDistributorCommissionCtrl";
            this.Load += new System.EventHandler(this.PfCustomerManageCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel skinPanel2;
        private JGNet.Common.TextBox skinTextBoxName;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.BaseButton BaseButton3;
        private Common.Components.BaseButton baseButton2;
        private Common.Components.DownTemplateButton baseButtonDownTemplate;
        private Common.Components.BaseButton baseButtonImport;
        private Common.Components.BaseButton baseButton4;
        private Common.Components.QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn accruedCommissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingCommission;
    }
}
