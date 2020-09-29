using JGNet.Common;

namespace JGNet.Manage
{
    partial class WholesaleEmOrderDeliveryCtrl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinCheckBox1 = new CCWin.SkinControl.SkinCheckBox();
            this.BaseButtonConfirm = new JGNet.Common.Components.BaseButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinLabelOrderId = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostumeStoreCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emOnlinePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumDeliveryMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.skinCheckBox1);
            this.panel2.Controls.Add(this.BaseButtonConfirm);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 607);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 43);
            this.panel2.TabIndex = 114;
            // 
            // skinCheckBox1
            // 
            this.skinCheckBox1.AutoSize = true;
            this.skinCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox1.DownBack = null;
            this.skinCheckBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox1.Location = new System.Drawing.Point(11, 12);
            this.skinCheckBox1.MouseBack = null;
            this.skinCheckBox1.Name = "skinCheckBox1";
            this.skinCheckBox1.NormlBack = null;
            this.skinCheckBox1.SelectedDownBack = null;
            this.skinCheckBox1.SelectedMouseBack = null;
            this.skinCheckBox1.SelectedNormlBack = null;
            this.skinCheckBox1.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBox1.TabIndex = 163;
            this.skinCheckBox1.Text = "全选";
            this.skinCheckBox1.UseVisualStyleBackColor = false;
            this.skinCheckBox1.CheckedChanged += new System.EventHandler(this.skinCheckBox1_CheckedChanged);
            // 
            // BaseButtonConfirm
            // 
            this.BaseButtonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BaseButtonConfirm.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonConfirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonConfirm.Location = new System.Drawing.Point(1082, 6);
            this.BaseButtonConfirm.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonConfirm.Name = "BaseButtonConfirm";
            this.BaseButtonConfirm.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonConfirm.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonConfirm.TabIndex = 162;
            this.BaseButtonConfirm.Text = "发货";
            this.BaseButtonConfirm.UseVisualStyleBackColor = false;
            this.BaseButtonConfirm.Click += new System.EventHandler(this.BaseButtonConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.skinLabelOrderId);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 37);
            this.panel1.TabIndex = 117;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.costumeIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.sizeNameDataGridViewTextBoxColumn,
            this.CostumeStoreCount,
            this.emOnlinePriceDataGridViewTextBoxColumn,
            this.DeliveryCount,
            this.SumDeliveryMoney});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 570);
            this.dataGridView1.TabIndex = 118;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.PfCustomerDetail);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "IsSelected";
            this.Column1.FalseValue = "false";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.TrueValue = "true";
            this.Column1.Width = 124;
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 124;
            // 
            // sizeNameDataGridViewTextBoxColumn
            // 
            this.sizeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeNameDataGridViewTextBoxColumn.DataPropertyName = "SizeDisplayName";
            this.sizeNameDataGridViewTextBoxColumn.HeaderText = "尺码";
            this.sizeNameDataGridViewTextBoxColumn.Name = "sizeNameDataGridViewTextBoxColumn";
            this.sizeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // CostumeStoreCount
            // 
            this.CostumeStoreCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostumeStoreCount.DataPropertyName = "CostumeStoreCount";
            this.CostumeStoreCount.HeaderText = "库存";
            this.CostumeStoreCount.Name = "CostumeStoreCount";
            this.CostumeStoreCount.ReadOnly = true;
            this.CostumeStoreCount.Width = 124;
            // 
            // emOnlinePriceDataGridViewTextBoxColumn
            // 
            this.emOnlinePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emOnlinePriceDataGridViewTextBoxColumn.DataPropertyName = "PfPrice";
            this.emOnlinePriceDataGridViewTextBoxColumn.HeaderText = "批发价";
            this.emOnlinePriceDataGridViewTextBoxColumn.Name = "emOnlinePriceDataGridViewTextBoxColumn";
            this.emOnlinePriceDataGridViewTextBoxColumn.Width = 124;
            // 
            // DeliveryCount
            // 
            this.DeliveryCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeliveryCount.DataPropertyName = "Count";
            this.DeliveryCount.HeaderText = "数量";
            this.DeliveryCount.Name = "DeliveryCount";
            this.DeliveryCount.Width = 124;
            // 
            // SumDeliveryMoney
            // 
            this.SumDeliveryMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumDeliveryMoney.DataPropertyName = "SumMoney";
            this.SumDeliveryMoney.HeaderText = "总金额";
            this.SumDeliveryMoney.Name = "SumDeliveryMoney";
            this.SumDeliveryMoney.ReadOnly = true;
            this.SumDeliveryMoney.Width = 66;
            // 
            // WholesaleEmOrderDeliveryCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "WholesaleEmOrderDeliveryCtrl";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private System.Windows.Forms.Panel panel2;
        private Common.Components.BaseButton BaseButtonConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinLabel skinLabelOrderId;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostumeStoreCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn emOnlinePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumDeliveryMoney;
    }
}
