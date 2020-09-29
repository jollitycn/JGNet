using CCWin.SkinControl;
using JGNet.Common;

namespace JGNet.Manage
{
    partial class CostumeStoreAnalysisCtrl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinComboBoxGroup = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxShopID = new JGNet.Common.ShopComboBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton_Search = new JGNet.Common.Components.BaseButton();
            this.skinComboBoxSeason = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBox_Brand = new JGNet.Common.BrandComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.groupTyopeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPricePercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.skinPanel2.Location = new System.Drawing.Point(0, 36);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 614);
            this.skinPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupTyopeNameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.costPriceDataGridViewTextBoxColumn,
            this.countPercentageDataGridViewTextBoxColumn,
            this.pricePercentageDataGridViewTextBoxColumn,
            this.costPricePercentageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 614);
            this.dataGridView1.TabIndex = 12;
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.Core.InteractEntity.CostumeStoreAnalysisData);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.skinComboBoxGroup);
            this.skinPanel1.Controls.Add(this.skinComboBoxShopID);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.BaseButton_Search);
            this.skinPanel1.Controls.Add(this.skinComboBoxSeason);
            this.skinPanel1.Controls.Add(this.skinComboBox_Brand);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 36);
            this.skinPanel1.TabIndex = 0;
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(818, 3);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 37;
            this.baseButton1.Text = "导出";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // skinComboBoxGroup
            // 
            this.skinComboBoxGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxGroup.FormattingEnabled = true;
            this.skinComboBoxGroup.Location = new System.Drawing.Point(43, 8);
            this.skinComboBoxGroup.Name = "skinComboBoxGroup";
            this.skinComboBoxGroup.Size = new System.Drawing.Size(142, 22);
            this.skinComboBoxGroup.TabIndex = 28;
            this.skinComboBoxGroup.WaterText = "";
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(223, 8);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(142, 22);
            this.skinComboBoxShopID.TabIndex = 35;
            this.skinComboBoxShopID.WaterText = "";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(8, 11);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 30;
            this.skinLabel3.Text = "分组";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(191, 11);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 36;
            this.skinLabel4.Text = "店铺";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BaseButton_Search
            // 
            this.BaseButton_Search.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Search.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Search.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Search.Location = new System.Drawing.Point(737, 4);
            this.BaseButton_Search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Search.Name = "BaseButton_Search";
            this.BaseButton_Search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Search.TabIndex = 34;
            this.BaseButton_Search.Text = "查询";
            this.BaseButton_Search.UseVisualStyleBackColor = false;
            this.BaseButton_Search.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinComboBoxSeason
            // 
            this.skinComboBoxSeason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxSeason.FormattingEnabled = true;
            this.skinComboBoxSeason.Location = new System.Drawing.Point(589, 8);
            this.skinComboBoxSeason.Name = "skinComboBoxSeason";
            this.skinComboBoxSeason.Size = new System.Drawing.Size(142, 22);
            this.skinComboBoxSeason.TabIndex = 29;
            this.skinComboBoxSeason.WaterText = "";
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Brand.FormattingEnabled = true;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(406, 8);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectStr = null;
            this.skinComboBox_Brand.ShowAll = true;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(142, 22);
            this.skinComboBox_Brand.SupplierID = null;
            this.skinComboBox_Brand.TabIndex = 31;
            this.skinComboBox_Brand.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(554, 11);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 32;
            this.skinLabel2.Text = "季节";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(371, 11);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 33;
            this.skinLabel6.Text = "品牌";
            // 
            // groupTyopeNameDataGridViewTextBoxColumn
            // 
            this.groupTyopeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.groupTyopeNameDataGridViewTextBoxColumn.DataPropertyName = "GroupTyopeName";
            this.groupTyopeNameDataGridViewTextBoxColumn.HeaderText = "分组";
            this.groupTyopeNameDataGridViewTextBoxColumn.Name = "groupTyopeNameDataGridViewTextBoxColumn";
            this.groupTyopeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.groupTyopeNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "库存总量";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 180;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "吊牌总额";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 180;
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            this.costPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costPriceDataGridViewTextBoxColumn.DataPropertyName = "CostPrice";
            this.costPriceDataGridViewTextBoxColumn.HeaderText = "成本总额";
            this.costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            this.costPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.costPriceDataGridViewTextBoxColumn.Width = 180;
            // 
            // countPercentageDataGridViewTextBoxColumn
            // 
            this.countPercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.countPercentageDataGridViewTextBoxColumn.DataPropertyName = "CountPercentage";
            dataGridViewCellStyle1.Format = "F1";
            this.countPercentageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.countPercentageDataGridViewTextBoxColumn.HeaderText = "数量占比";
            this.countPercentageDataGridViewTextBoxColumn.Name = "countPercentageDataGridViewTextBoxColumn";
            this.countPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.countPercentageDataGridViewTextBoxColumn.Width = 180;
            // 
            // pricePercentageDataGridViewTextBoxColumn
            // 
            this.pricePercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pricePercentageDataGridViewTextBoxColumn.DataPropertyName = "PricePercentage";
            dataGridViewCellStyle2.Format = "F1";
            this.pricePercentageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.pricePercentageDataGridViewTextBoxColumn.HeaderText = "金额占比";
            this.pricePercentageDataGridViewTextBoxColumn.Name = "pricePercentageDataGridViewTextBoxColumn";
            this.pricePercentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePercentageDataGridViewTextBoxColumn.Width = 180;
            // 
            // costPricePercentageDataGridViewTextBoxColumn
            // 
            this.costPricePercentageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costPricePercentageDataGridViewTextBoxColumn.DataPropertyName = "CostPricePercentage";
            dataGridViewCellStyle3.Format = "F1";
            this.costPricePercentageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.costPricePercentageDataGridViewTextBoxColumn.HeaderText = "成本占比";
            this.costPricePercentageDataGridViewTextBoxColumn.Name = "costPricePercentageDataGridViewTextBoxColumn";
            this.costPricePercentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.costPricePercentageDataGridViewTextBoxColumn.Width = 78;
            // 
            // CostumeStoreAnalysisCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.Name = "CostumeStoreAnalysisCtrl";
            this.Load += new System.EventHandler(this.CostumeManageCtrl_Load);
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.Panel skinPanel2;
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SkinComboBox skinComboBoxGroup;
        private ShopComboBox skinComboBoxShopID;
        private SkinLabel skinLabel3;
        private SkinLabel skinLabel4;
        private Common.Components.BaseButton BaseButton_Search;
        private SkinComboBox skinComboBoxSeason;
        private Common.BrandComboBox skinComboBox_Brand;
        private SkinLabel skinLabel2;
        private SkinLabel skinLabel6;
        private Common.Components.BaseButton baseButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupTyopeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePercentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPricePercentageDataGridViewTextBoxColumn;
    }
}
