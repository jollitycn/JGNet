namespace JGNet.Manage
{
    partial class PriceRangeReportDetailCtrl
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
            this.dataGridViewDetail = new System.Windows.Forms.DataGridView();
            this.bndingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoenyRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetail
            // 
            this.dataGridViewDetail.AllowUserToAddRows = false;
            this.dataGridViewDetail.AllowUserToDeleteRows = false;
            this.dataGridViewDetail.AllowUserToOrderColumns = true;
            this.dataGridViewDetail.AutoGenerateColumns = false;
            this.dataGridViewDetail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shopNameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.CountRate,
            this.moneyDataGridViewTextBoxColumn,
            this.MoenyRate});
            this.dataGridViewDetail.DataSource = this.bndingSource;
            this.dataGridViewDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetail.MultiSelect = false;
            this.dataGridViewDetail.Name = "dataGridViewDetail";
            this.dataGridViewDetail.ReadOnly = true;
            this.dataGridViewDetail.RowTemplate.Height = 23;
            this.dataGridViewDetail.Size = new System.Drawing.Size(1160, 650);
            this.dataGridViewDetail.TabIndex = 3;
            this.dataGridViewDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // bndingSource
            // 
            this.bndingSource.DataSource = typeof(JGNet.Core.InteractEntity.PriceRangeReport);
            // 
            // shopNameDataGridViewTextBoxColumn
            // 
            this.shopNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "ShopName";
            this.shopNameDataGridViewTextBoxColumn.HeaderText = "店铺";
            this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
            this.shopNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "销量";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 200;
            // 
            // CountRate
            // 
            this.CountRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CountRate.DataPropertyName = "CountRate";
            dataGridViewCellStyle1.Format = "P1";
            this.CountRate.DefaultCellStyle = dataGridViewCellStyle1;
            this.CountRate.HeaderText = "销量占比";
            this.CountRate.Name = "CountRate";
            this.CountRate.ReadOnly = true;
            this.CountRate.Width = 200;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "销售总额";
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.moneyDataGridViewTextBoxColumn.Width = 200;
            // 
            // MoenyRate
            // 
            this.MoenyRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MoenyRate.DataPropertyName = "MoenyRate";
            dataGridViewCellStyle2.Format = "P1";
            this.MoenyRate.DefaultCellStyle = dataGridViewCellStyle2;
            this.MoenyRate.HeaderText = "金额占比";
            this.MoenyRate.Name = "MoenyRate";
            this.MoenyRate.ReadOnly = true;
            this.MoenyRate.Width = 78;
            // 
            // PriceRangeReportDetailCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewDetail);
            this.Name = "PriceRangeReportDetailCtrl";
            this.Load += new System.EventHandler(this.PriceRangeReportDetailCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bndingSource;
        private System.Windows.Forms.DataGridView dataGridViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn startCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkStoreWinCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkStoreWinMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkStoreLostCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkStoreLostMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoenyRate;
    }
}
