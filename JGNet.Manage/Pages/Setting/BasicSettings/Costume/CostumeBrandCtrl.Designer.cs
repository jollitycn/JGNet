namespace JGNet.Manage.Pages.BasicSettings.Costume
{
    partial class CostumeBrandCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumeBrandCtrl));
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButton3 = new JGNet.Common.Components.BaseButton();
            this.baseButtonDownTemplate = new JGNet.Common.Components.DownTemplateButton();
            this.baseButtonImport = new JGNet.Common.Components.BaseButton();
            this.textBox1 = new JGNet.Common.TextBox();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.brandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isEnableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.autoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstCharSpellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDisableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton3);
            this.skinPanel1.Controls.Add(this.baseButtonDownTemplate);
            this.skinPanel1.Controls.Add(this.baseButtonImport);
            this.skinPanel1.Controls.Add(this.textBox1);
            this.skinPanel1.Controls.Add(this.baseButton2);
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 40);
            this.skinPanel1.TabIndex = 4;
            // 
            // baseButton3
            // 
            this.baseButton3.BackColor = System.Drawing.Color.Transparent;
            this.baseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton3.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton3.DownBack")));
            this.baseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton3.Location = new System.Drawing.Point(576, 6);
            this.baseButton3.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton3.MouseBack")));
            this.baseButton3.Name = "baseButton3";
            this.baseButton3.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton3.NormlBack")));
            this.baseButton3.Size = new System.Drawing.Size(75, 32);
            this.baseButton3.TabIndex = 149;
            this.baseButton3.Text = "导出";
            this.baseButton3.UseVisualStyleBackColor = false;
            this.baseButton3.Click += new System.EventHandler(this.baseButton3_Click);
            // 
            // baseButtonDownTemplate
            // 
            this.baseButtonDownTemplate.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonDownTemplate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonDownTemplate.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.DownBack")));
            this.baseButtonDownTemplate.DownName = null;
            this.baseButtonDownTemplate.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonDownTemplate.FileName = "品牌.xls";
            this.baseButtonDownTemplate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonDownTemplate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonDownTemplate.Location = new System.Drawing.Point(414, 6);
            this.baseButtonDownTemplate.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.MouseBack")));
            this.baseButtonDownTemplate.Name = "baseButtonDownTemplate";
            this.baseButtonDownTemplate.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.NormlBack")));
            this.baseButtonDownTemplate.Size = new System.Drawing.Size(75, 32);
            this.baseButtonDownTemplate.TabIndex = 148;
            this.baseButtonDownTemplate.Text = "下载模板";
            this.baseButtonDownTemplate.UseVisualStyleBackColor = false;
            this.baseButtonDownTemplate.Click += new System.EventHandler(this.baseButtonDownTemplate_Click);
            // 
            // baseButtonImport
            // 
            this.baseButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonImport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonImport.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonImport.DownBack")));
            this.baseButtonImport.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonImport.Location = new System.Drawing.Point(495, 6);
            this.baseButtonImport.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonImport.MouseBack")));
            this.baseButtonImport.Name = "baseButtonImport";
            this.baseButtonImport.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonImport.NormlBack")));
            this.baseButtonImport.Size = new System.Drawing.Size(75, 32);
            this.baseButtonImport.TabIndex = 147;
            this.baseButtonImport.Text = "导入";
            this.baseButtonImport.UseVisualStyleBackColor = false;
            this.baseButtonImport.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.DownBack = null;
            this.textBox1.Icon = null;
            this.textBox1.IconIsButton = false;
            this.textBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox1.IsPasswordChat = '\0';
            this.textBox1.IsSystemPasswordChar = false;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(64, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 32767;
            this.textBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox1.MouseBack = null;
            this.textBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.NormlBack = null;
            this.textBox1.Padding = new System.Windows.Forms.Padding(5);
            this.textBox1.ReadOnly = false;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox1.SkinTxt.Name = "BaseText";
            this.textBox1.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox1.SkinTxt.TabIndex = 0;
            this.textBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox1.SkinTxt.WaterText = "名称/编号";
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = true;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox1.WaterText = "名称/编号";
            this.textBox1.WordWrap = true;
            // 
            // baseButton2
            // 
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.DownBack")));
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(333, 6);
            this.baseButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.MouseBack")));
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.NormlBack")));
            this.baseButton2.Size = new System.Drawing.Size(75, 32);
            this.baseButton2.TabIndex = 146;
            this.baseButton2.Text = "添加";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.DownBack")));
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(252, 6);
            this.baseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.MouseBack")));
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.NormlBack")));
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 145;
            this.baseButton1.Text = "查询";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 12);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(61, 17);
            this.skinLabel1.TabIndex = 144;
            this.skinLabel1.Text = "名称/编号";
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
            this.Column3,
            this.Column2,
            this.ColumnEdit,
            this.ColumnDelete,
            this.isEnableDataGridViewCheckBoxColumn,
            this.autoIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.firstCharSpellDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.orderNoDataGridViewTextBoxColumn,
            this.isDisableDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.brandBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 610);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "名称";
            this.Column1.Name = "Column1";
            this.Column1.Width = 360;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "FirstCharSpell";
            this.Column3.HeaderText = "首拼字母缩写";
            this.Column3.Name = "Column3";
            this.Column3.Width = 355;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IsEnable";
            this.Column2.FalseValue = "false";
            this.Column2.HeaderText = "启用";
            this.Column2.Name = "Column2";
            this.Column2.TrueValue = "true";
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEdit.HeaderText = "修改";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEdit.Text = "编辑";
            this.ColumnEdit.UseColumnTextForLinkValue = true;
            this.ColumnEdit.Width = 40;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDelete.HeaderText = "删除";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDelete.Text = "删除";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // brandBindingSource
            // 
            this.brandBindingSource.DataSource = typeof(JGNet.Brand);
            // 
            // isEnableDataGridViewCheckBoxColumn
            // 
            this.isEnableDataGridViewCheckBoxColumn.DataPropertyName = "IsEnable";
            this.isEnableDataGridViewCheckBoxColumn.HeaderText = "IsEnable";
            this.isEnableDataGridViewCheckBoxColumn.Name = "isEnableDataGridViewCheckBoxColumn";
            // 
            // autoIDDataGridViewTextBoxColumn
            // 
            this.autoIDDataGridViewTextBoxColumn.DataPropertyName = "AutoID";
            this.autoIDDataGridViewTextBoxColumn.HeaderText = "AutoID";
            this.autoIDDataGridViewTextBoxColumn.Name = "autoIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // firstCharSpellDataGridViewTextBoxColumn
            // 
            this.firstCharSpellDataGridViewTextBoxColumn.DataPropertyName = "FirstCharSpell";
            this.firstCharSpellDataGridViewTextBoxColumn.HeaderText = "FirstCharSpell";
            this.firstCharSpellDataGridViewTextBoxColumn.Name = "firstCharSpellDataGridViewTextBoxColumn";
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            // 
            // isDisableDataGridViewCheckBoxColumn
            // 
            this.isDisableDataGridViewCheckBoxColumn.DataPropertyName = "IsDisable";
            this.isDisableDataGridViewCheckBoxColumn.HeaderText = "IsDisable";
            this.isDisableDataGridViewCheckBoxColumn.Name = "isDisableDataGridViewCheckBoxColumn";
            // 
            // CostumeBrandCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "CostumeBrandCtrl";
            this.Load += new System.EventHandler(this.CostumeBrandCtrl_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Common.Components.BaseButton baseButton1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.TextBox textBox1;
        private Common.Components.BaseButton baseButton2;
        private Common.Components.DownTemplateButton baseButtonDownTemplate;
        private Common.Components.BaseButton baseButtonImport;
        private Common.Components.BaseButton baseButton3;
        private System.Windows.Forms.BindingSource brandBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEnableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstCharSpellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDisableDataGridViewCheckBoxColumn;
    }
}
