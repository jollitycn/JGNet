using JGNet.Common;

namespace JGNet.Manage
{
    partial class EmCarriageCostTemplateCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmCarriageCostTemplateCtrl));
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinTextBoxTitle = new JGNet.Common.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonSearch = new JGNet.Common.Components.BaseButton();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defaultCarriageCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastEditTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOperatorUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsValid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.dataGridView1);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.Location = new System.Drawing.Point(0, 38);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 612);
            this.skinPanel2.TabIndex = 1;
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
            this.defaultCarriageCostDataGridViewTextBoxColumn,
            this.goodsAddressDataGridViewTextBoxColumn,
            this.deliveryTimeDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.lastEditTimeDataGridViewTextBoxColumn,
            this.lastOperatorUserIDDataGridViewTextBoxColumn,
            this.IsValid,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 612);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.EmCarriageCostTemplate);
            // 
            // skinPanel1
            // 
            this.skinPanel1.AutoSize = true;
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinTextBoxTitle);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.baseButtonSearch);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 38);
            this.skinPanel1.TabIndex = 0;
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
            this.skinTextBoxTitle.Location = new System.Drawing.Point(72, 5);
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
            this.skinTextBoxTitle.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.skinTextBoxTitle.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxTitle.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxTitle.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxTitle.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxTitle.SkinTxt.Name = "BaseText";
            this.skinTextBoxTitle.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.skinTextBoxTitle.SkinTxt.TabIndex = 0;
            this.skinTextBoxTitle.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxTitle.SkinTxt.WaterText = "";
            this.skinTextBoxTitle.TabIndex = 7;
            this.skinTextBoxTitle.TabStop = true;
            this.skinTextBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxTitle.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxTitle.WaterText = "";
            this.skinTextBoxTitle.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 11);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "模板名称：";
            // 
            // baseButtonSearch
            // 
            this.baseButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSearch.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonSearch.DownBack")));
            this.baseButtonSearch.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSearch.Location = new System.Drawing.Point(217, 3);
            this.baseButtonSearch.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonSearch.MouseBack")));
            this.baseButtonSearch.Name = "baseButtonSearch";
            this.baseButtonSearch.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonSearch.NormlBack")));
            this.baseButtonSearch.Size = new System.Drawing.Size(75, 32);
            this.baseButtonSearch.TabIndex = 3;
            this.baseButtonSearch.Text = "查询";
            this.baseButtonSearch.UseVisualStyleBackColor = false;
            this.baseButtonSearch.Click += new System.EventHandler(this.baseButtonSearch_Click);
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.DownBack")));
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(298, 3);
            this.BaseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.MouseBack")));
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.NormlBack")));
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 3;
            this.BaseButton1.Text = "添加";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButtonAdd_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "模板名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 130;
            // 
            // defaultCarriageCostDataGridViewTextBoxColumn
            // 
            this.defaultCarriageCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.defaultCarriageCostDataGridViewTextBoxColumn.DataPropertyName = "DefaultCarriageCost";
            this.defaultCarriageCostDataGridViewTextBoxColumn.HeaderText = "默认运费";
            this.defaultCarriageCostDataGridViewTextBoxColumn.Name = "defaultCarriageCostDataGridViewTextBoxColumn";
            this.defaultCarriageCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.defaultCarriageCostDataGridViewTextBoxColumn.Width = 120;
            // 
            // goodsAddressDataGridViewTextBoxColumn
            // 
            this.goodsAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.goodsAddressDataGridViewTextBoxColumn.DataPropertyName = "GoodsAddress";
            this.goodsAddressDataGridViewTextBoxColumn.HeaderText = "宝贝地址";
            this.goodsAddressDataGridViewTextBoxColumn.Name = "goodsAddressDataGridViewTextBoxColumn";
            this.goodsAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsAddressDataGridViewTextBoxColumn.Width = 350;
            // 
            // deliveryTimeDataGridViewTextBoxColumn
            // 
            this.deliveryTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deliveryTimeDataGridViewTextBoxColumn.DataPropertyName = "DeliveryTime";
            this.deliveryTimeDataGridViewTextBoxColumn.HeaderText = "发货时间(小时)";
            this.deliveryTimeDataGridViewTextBoxColumn.Name = "deliveryTimeDataGridViewTextBoxColumn";
            this.deliveryTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时间";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastEditTimeDataGridViewTextBoxColumn
            // 
            this.lastEditTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lastEditTimeDataGridViewTextBoxColumn.DataPropertyName = "LastEditTime";
            this.lastEditTimeDataGridViewTextBoxColumn.HeaderText = "最后编辑时间";
            this.lastEditTimeDataGridViewTextBoxColumn.Name = "lastEditTimeDataGridViewTextBoxColumn";
            this.lastEditTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastEditTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastOperatorUserIDDataGridViewTextBoxColumn
            // 
            this.lastOperatorUserIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lastOperatorUserIDDataGridViewTextBoxColumn.DataPropertyName = "LastOperatorUserName";
            this.lastOperatorUserIDDataGridViewTextBoxColumn.HeaderText = "最后编辑人";
            this.lastOperatorUserIDDataGridViewTextBoxColumn.Name = "lastOperatorUserIDDataGridViewTextBoxColumn";
            this.lastOperatorUserIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastOperatorUserIDDataGridViewTextBoxColumn.Width = 90;
            // 
            // IsValid
            // 
            this.IsValid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsValid.DataPropertyName = "IsValid";
            this.IsValid.FalseValue = "false";
            this.IsValid.HeaderText = "启用";
            this.IsValid.Name = "IsValid";
            this.IsValid.ReadOnly = true;
            this.IsValid.TrueValue = "true";
            this.IsValid.Width = 35;
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
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "删除";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "删除";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // EmCarriageCostTemplateCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.Name = "EmCarriageCostTemplateCtrl";
            this.Load += new System.EventHandler(this.EmCarriageCostTemplateCtrl_Load);
            this.skinPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.BaseButton baseButtonSearch;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private TextBox skinTextBoxTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultCarriageCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastEditTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOperatorUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsValid;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}
