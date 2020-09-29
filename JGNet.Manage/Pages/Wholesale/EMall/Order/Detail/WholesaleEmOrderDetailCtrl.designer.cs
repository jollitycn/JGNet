using JGNet.Common;

namespace JGNet.Manage
{
    partial class WholesaleEmOrderDetailCtrl
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
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinLabelRemarks = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelOrderId = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PfPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.PfCustomerDetail);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.sizeNameDataGridViewTextBoxColumn,
            this.PfPrice,
            this.DeliveryCount,
            this.SumMoney});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 615);
            this.dataGridView1.TabIndex = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.skinLabelRemarks);
            this.panel1.Controls.Add(this.skinLabel2);
            this.panel1.Controls.Add(this.skinLabelOrderId);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 35);
            this.panel1.TabIndex = 119;
            // 
            // skinLabelRemarks
            // 
            this.skinLabelRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabelRemarks.AutoSize = true;
            this.skinLabelRemarks.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelRemarks.BorderColor = System.Drawing.Color.White;
            this.skinLabelRemarks.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelRemarks.Location = new System.Drawing.Point(587, 10);
            this.skinLabelRemarks.Name = "skinLabelRemarks";
            this.skinLabelRemarks.Size = new System.Drawing.Size(80, 17);
            this.skinLabelRemarks.TabIndex = 161;
            this.skinLabelRemarks.Text = "批发订单号：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(537, 10);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 161;
            this.skinLabel2.Text = "备注：";
            // 
            // skinLabelOrderId
            // 
            this.skinLabelOrderId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabelOrderId.AutoSize = true;
            this.skinLabelOrderId.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelOrderId.BorderColor = System.Drawing.Color.White;
            this.skinLabelOrderId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelOrderId.Location = new System.Drawing.Point(294, 10);
            this.skinLabelOrderId.Name = "skinLabelOrderId";
            this.skinLabelOrderId.Size = new System.Drawing.Size(56, 17);
            this.skinLabelOrderId.TabIndex = 160;
            this.skinLabelOrderId.Text = "发货店铺";
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(208, 10);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(80, 17);
            this.skinLabel1.TabIndex = 160;
            this.skinLabel1.Text = "批发订单号：";
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // sizeNameDataGridViewTextBoxColumn
            // 
            this.sizeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeNameDataGridViewTextBoxColumn.DataPropertyName = "SizeDisplayName";
            this.sizeNameDataGridViewTextBoxColumn.HeaderText = "尺码";
            this.sizeNameDataGridViewTextBoxColumn.Name = "sizeNameDataGridViewTextBoxColumn";
            this.sizeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // PfPrice
            // 
            this.PfPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PfPrice.DataPropertyName = "PfPrice";
            this.PfPrice.HeaderText = "批发价";
            this.PfPrice.Name = "PfPrice";
            this.PfPrice.Width = 186;
            // 
            // DeliveryCount
            // 
            this.DeliveryCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeliveryCount.DataPropertyName = "Count";
            this.DeliveryCount.HeaderText = "数量";
            this.DeliveryCount.Name = "DeliveryCount";
            this.DeliveryCount.Width = 186;
            // 
            // SumMoney
            // 
            this.SumMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumMoney.DataPropertyName = "SumMoney";
            this.SumMoney.HeaderText = "总金额";
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.ReadOnly = true;
            this.SumMoney.Width = 66;
            // 
            // WholesaleEmOrderDetailCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "WholesaleEmOrderDetailCtrl";
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabelOrderId;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabelRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PfPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMoney;
    }
}
