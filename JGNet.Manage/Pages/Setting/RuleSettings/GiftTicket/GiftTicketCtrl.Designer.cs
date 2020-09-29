namespace JGNet.Manage.Pages
{
    partial class GiftTicketCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiftTicketCtrl));
            this.salesPromotionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.skinLabelCostume = new CCWin.SkinControl.SkinLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skinPanel6 = new System.Windows.Forms.Panel();
            this.baseButtonAdd = new JGNet.Common.Components.BaseButton();
            this.denominationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.salesPromotionBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // salesPromotionBindingSource
            // 
            this.salesPromotionBindingSource.DataSource = typeof(JGNet.GiftTicketTemplate);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.groupBox3);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 60);
            this.skinPanel1.TabIndex = 121;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.baseButton2);
            this.groupBox3.Controls.Add(this.skinLabelCostume);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 60);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // baseButton2
            // 
            this.baseButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(1082, 18);
            this.baseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton2.Size = new System.Drawing.Size(75, 32);
            this.baseButton2.TabIndex = 9;
            this.baseButton2.Text = "设置";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabelCostume
            // 
            this.skinLabelCostume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skinLabelCostume.AutoSize = true;
            this.skinLabelCostume.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelCostume.BorderColor = System.Drawing.Color.White;
            this.skinLabelCostume.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelCostume.Location = new System.Drawing.Point(6, 26);
            this.skinLabelCostume.Name = "skinLabelCostume";
            this.skinLabelCostume.Size = new System.Drawing.Size(152, 17);
            this.skinLabelCostume.TabIndex = 150;
            this.skinLabelCostume.Text = "默认所有商品可使用优惠券";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.skinPanel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 590);
            this.panel1.TabIndex = 123;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denominationDataGridViewTextBoxColumn,
            this.ticketDescriptionDataGridViewTextBoxColumn,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridView1.DataSource = this.salesPromotionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 546);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // skinPanel6
            // 
            this.skinPanel6.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel6.Controls.Add(this.baseButtonAdd);
            this.skinPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel6.Location = new System.Drawing.Point(0, 0);
            this.skinPanel6.Name = "skinPanel6";
            this.skinPanel6.Size = new System.Drawing.Size(1160, 44);
            this.skinPanel6.TabIndex = 9;
            // 
            // baseButtonAdd
            // 
            this.baseButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonAdd.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonAdd.DownBack")));
            this.baseButtonAdd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonAdd.Location = new System.Drawing.Point(1082, 6);
            this.baseButtonAdd.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonAdd.MouseBack")));
            this.baseButtonAdd.Name = "baseButtonAdd";
            this.baseButtonAdd.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonAdd.NormlBack")));
            this.baseButtonAdd.Size = new System.Drawing.Size(75, 32);
            this.baseButtonAdd.TabIndex = 2;
            this.baseButtonAdd.Text = "添加";
            this.baseButtonAdd.UseVisualStyleBackColor = false;
            this.baseButtonAdd.Click += new System.EventHandler(this.BaseButtonAdd_Click);
            // 
            // denominationDataGridViewTextBoxColumn
            // 
            this.denominationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.denominationDataGridViewTextBoxColumn.DataPropertyName = "Denomination";
            this.denominationDataGridViewTextBoxColumn.HeaderText = "面额";
            this.denominationDataGridViewTextBoxColumn.Name = "denominationDataGridViewTextBoxColumn";
            this.denominationDataGridViewTextBoxColumn.ReadOnly = true;
            this.denominationDataGridViewTextBoxColumn.Width = 400;
            // 
            // ticketDescriptionDataGridViewTextBoxColumn
            // 
            this.ticketDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ticketDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TicketDescription";
            this.ticketDescriptionDataGridViewTextBoxColumn.HeaderText = "条件";
            this.ticketDescriptionDataGridViewTextBoxColumn.Name = "ticketDescriptionDataGridViewTextBoxColumn";
            this.ticketDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketDescriptionDataGridViewTextBoxColumn.Width = 640;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEdit.HeaderText = "编辑";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
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
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDelete.Text = "删除";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // GiftTicketCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "GiftTicketCtrl";
            this.Load += new System.EventHandler(this.GiftTicketCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesPromotionBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.skinPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource salesPromotionBindingSource;
        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private Common.Components.BaseButton baseButton2;
        private CCWin.SkinControl.SkinLabel skinLabelCostume;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel skinPanel6;
        private Common.Components.BaseButton baseButtonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn denominationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
    }
}
