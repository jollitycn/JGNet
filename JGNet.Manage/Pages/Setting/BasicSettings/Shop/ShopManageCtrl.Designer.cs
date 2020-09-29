namespace JGNet.Manage.Pages
{
    partial class ShopManageCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.condition = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinTextBoxName = new JGNet.Common.TextBox();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isGeneralStoreDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MinDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxChangeRemoved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.EnabledLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDisable = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataSource = typeof(JGNet.Shop);
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
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isGeneralStoreDataGridViewCheckBoxColumn,
            this.MinDiscount,
            this.MaxChangeRemoved,
            this.createTimeDataGridViewTextBoxColumn,
            this.Remarks,
            this.Enabled,
            this.Column1,
            this.EnabledLink,
            this.ColumnDisable,
            this.ColumnDelete});
            this.dataGridView1.DataSource = this.shopBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 605);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.condition);
            this.skinPanel2.Controls.Add(this.skinLabel2);
            this.skinPanel2.Controls.Add(this.skinLabel1);
            this.skinPanel2.Controls.Add(this.BaseButton1);
            this.skinPanel2.Controls.Add(this.BaseButton3);
            this.skinPanel2.Controls.Add(this.skinTextBoxName);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 45);
            this.skinPanel2.TabIndex = 49;
            // 
            // condition
            // 
            this.condition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.condition.FormattingEnabled = true;
            this.condition.Location = new System.Drawing.Point(300, 12);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(126, 22);
            this.condition.TabIndex = 132;
            this.condition.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(262, 15);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 99;
            this.skinLabel2.Text = "状态";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(85, 17);
            this.skinLabel1.TabIndex = 98;
            this.skinLabel1.Text = "店铺编号/名称";
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(458, 7);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 1;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButtonQuery_Click);
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(539, 7);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "添加";
            this.BaseButton3.UseVisualStyleBackColor = false;
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
            this.skinTextBoxName.Location = new System.Drawing.Point(91, 9);
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
            this.skinTextBoxName.SkinTxt.WaterText = "店铺编号/名称";
            this.skinTextBoxName.TabIndex = 0;
            this.skinTextBoxName.TabStop = true;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "店铺编号/名称";
            this.skinTextBoxName.WordWrap = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "店铺编号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 190;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "店铺名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 190;
            // 
            // isGeneralStoreDataGridViewCheckBoxColumn
            // 
            this.isGeneralStoreDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isGeneralStoreDataGridViewCheckBoxColumn.DataPropertyName = "IsGeneralStore";
            this.isGeneralStoreDataGridViewCheckBoxColumn.HeaderText = "是否总仓";
            this.isGeneralStoreDataGridViewCheckBoxColumn.Name = "isGeneralStoreDataGridViewCheckBoxColumn";
            this.isGeneralStoreDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isGeneralStoreDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isGeneralStoreDataGridViewCheckBoxColumn.Width = 98;
            // 
            // MinDiscount
            // 
            this.MinDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MinDiscount.DataPropertyName = "MinDiscount";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.MinDiscount.DefaultCellStyle = dataGridViewCellStyle1;
            this.MinDiscount.HeaderText = "最低折扣";
            this.MinDiscount.Name = "MinDiscount";
            this.MinDiscount.ReadOnly = true;
            // 
            // MaxChangeRemoved
            // 
            this.MaxChangeRemoved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaxChangeRemoved.DataPropertyName = "MaxChangeRemoved";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.MaxChangeRemoved.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaxChangeRemoved.HeaderText = "抹零上限";
            this.MaxChangeRemoved.Name = "MaxChangeRemoved";
            this.MaxChangeRemoved.ReadOnly = true;
            this.MaxChangeRemoved.Width = 110;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建日期";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "备注";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Width = 120;
            // 
            // Enabled
            // 
            this.Enabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Enabled.DataPropertyName = "EnbledName";
            this.Enabled.HeaderText = "状态";
            this.Enabled.Name = "Enabled";
            this.Enabled.ReadOnly = true;
            this.Enabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "编辑";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Text = "编辑";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 40;
            // 
            // EnabledLink
            // 
            this.EnabledLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EnabledLink.HeaderText = "启用";
            this.EnabledLink.Name = "EnabledLink";
            this.EnabledLink.ReadOnly = true;
            this.EnabledLink.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EnabledLink.Text = "启用";
            this.EnabledLink.UseColumnTextForLinkValue = true;
            this.EnabledLink.Width = 40;
            // 
            // ColumnDisable
            // 
            this.ColumnDisable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDisable.HeaderText = "禁用";
            this.ColumnDisable.Name = "ColumnDisable";
            this.ColumnDisable.ReadOnly = true;
            this.ColumnDisable.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDisable.Text = "禁用";
            this.ColumnDisable.UseColumnTextForLinkValue = true;
            this.ColumnDisable.Width = 40;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDelete.HeaderText = "删除";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDelete.Text = "删除";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // ShopManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel1);
            this.Name = "ShopManageCtrl";
            this.Load += new System.EventHandler(this.ShopManageCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel skinPanel2;
        private  JGNet.Common.TextBox skinTextBoxName;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.BaseButton BaseButton3;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinComboBox condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnabledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isGeneralStoreDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxChangeRemoved;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enabled;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn EnabledLink;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDisable;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
    }
}
