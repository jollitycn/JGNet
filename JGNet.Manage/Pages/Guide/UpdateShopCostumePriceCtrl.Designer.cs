using JGNet.Common;
using JGNet.Core.InteractEntity;

namespace JGNet.Manage
{
    partial class UpdateShopCostumePriceCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateShopCostumePriceCtrl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outboundDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBoxBigClass = new JGNet.Common.CostumeClassSelector();
            this.label4 = new System.Windows.Forms.Label();
            this.skinComboBox_Brand = new JGNet.Common.BrandComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.costumeFromSupplierTextBox1 = new JGNet.Common.CostumeTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skinComboBoxShopID = new CCWin.SkinControl.SkinComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUpdate = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn1,
            this.costumeNameDataGridViewTextBoxColumn1,
            this.shopNameDataGridViewTextBoxColumn1,
            this.SalePriceColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.ColumnUpdate});
            this.dataGridView1.DataSource = this.outboundDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 611);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // outboundDetailBindingSource
            // 
            this.outboundDetailBindingSource.DataSource = typeof(JGNet.Core.InteractEntity.CostumePrice);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBoxBigClass);
            this.skinPanel1.Controls.Add(this.label4);
            this.skinPanel1.Controls.Add(this.skinComboBox_Brand);
            this.skinPanel1.Controls.Add(this.label3);
            this.skinPanel1.Controls.Add(this.costumeFromSupplierTextBox1);
            this.skinPanel1.Controls.Add(this.label2);
            this.skinPanel1.Controls.Add(this.skinComboBoxShopID);
            this.skinPanel1.Controls.Add(this.label1);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 39);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinComboBoxBigClass
            // 
            this.skinComboBoxBigClass.AutoSize = true;
            this.skinComboBoxBigClass.Location = new System.Drawing.Point(582, 4);
            this.skinComboBoxBigClass.Name = "skinComboBoxBigClass";
            this.skinComboBoxBigClass.SelectedValue = ((JGNet.Costume)(resources.GetObject("skinComboBoxBigClass.SelectedValue")));
            this.skinComboBoxBigClass.Size = new System.Drawing.Size(153, 29);
            this.skinComboBoxBigClass.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 137;
            this.label4.Text = "类别";
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Brand.FormattingEnabled = true;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(399, 8);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectStr = null;
            this.skinComboBox_Brand.ShowAll = true;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(140, 22);
            this.skinComboBox_Brand.SupplierID = null;
            this.skinComboBox_Brand.TabIndex = 136;
            this.skinComboBox_Brand.WaterText = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 135;
            this.label3.Text = "品牌";
            // 
            // costumeFromSupplierTextBox1
            // 
            this.costumeFromSupplierTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.costumeFromSupplierTextBox1.DownBack = null;
            this.costumeFromSupplierTextBox1.FilterValid = true;
            this.costumeFromSupplierTextBox1.Icon = null;
            this.costumeFromSupplierTextBox1.IconIsButton = false;
            this.costumeFromSupplierTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeFromSupplierTextBox1.IsPasswordChat = '\0';
            this.costumeFromSupplierTextBox1.IsSystemPasswordChar = false;
            this.costumeFromSupplierTextBox1.Lines = new string[0];
            this.costumeFromSupplierTextBox1.Location = new System.Drawing.Point(221, 5);
            this.costumeFromSupplierTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.costumeFromSupplierTextBox1.MaxLength = 32767;
            this.costumeFromSupplierTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.costumeFromSupplierTextBox1.MouseBack = null;
            this.costumeFromSupplierTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeFromSupplierTextBox1.Multiline = false;
            this.costumeFromSupplierTextBox1.Name = "costumeFromSupplierTextBox1";
            this.costumeFromSupplierTextBox1.NormlBack = null;
            this.costumeFromSupplierTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.costumeFromSupplierTextBox1.ReadOnly = false;
            this.costumeFromSupplierTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.costumeFromSupplierTextBox1.Size = new System.Drawing.Size(140, 28);
            // 
            // 
            // 
            this.costumeFromSupplierTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costumeFromSupplierTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costumeFromSupplierTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.costumeFromSupplierTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.costumeFromSupplierTextBox1.SkinTxt.Name = "BaseText";
            this.costumeFromSupplierTextBox1.SkinTxt.Size = new System.Drawing.Size(130, 18);
            this.costumeFromSupplierTextBox1.SkinTxt.TabIndex = 0;
            this.costumeFromSupplierTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeFromSupplierTextBox1.SkinTxt.WaterText = "";
            this.costumeFromSupplierTextBox1.TabIndex = 134;
            this.costumeFromSupplierTextBox1.TabStop = true;
            this.costumeFromSupplierTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.costumeFromSupplierTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeFromSupplierTextBox1.WaterText = "";
            this.costumeFromSupplierTextBox1.WordWrap = true;
            this.costumeFromSupplierTextBox1.CostumeSelected += new CJBasic.Action<JGNet.Costume, bool>(this.costumeFromSupplierTextBox1_CostumeSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 133;
            this.label2.Text = "款号";
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(43, 8);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(140, 22);
            this.skinComboBoxShopID.TabIndex = 132;
            this.skinComboBoxShopID.WaterText = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 131;
            this.label1.Text = "店铺";
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(775, 4);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 5;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 39);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView2);
            this.skinSplitContainer1.Panel2Collapsed = true;
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 611);
            this.skinSplitContainer1.SplitterDistance = 280;
            this.skinSplitContainer1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostPrice,
            this.costumeNameDataGridViewTextBoxColumn,
            this.shopNameDataGridViewTextBoxColumn,
            this.costumeIDDataGridViewTextBoxColumn,
            this.shopIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.outboundDetailBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1160, 611);
            this.dataGridView2.TabIndex = 7;
            // 
            // CostPrice
            // 
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "成本价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shopNameDataGridViewTextBoxColumn
            // 
            this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "ShopName";
            this.shopNameDataGridViewTextBoxColumn.HeaderText = "ShopName";
            this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
            this.shopNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shopIdDataGridViewTextBoxColumn
            // 
            this.shopIdDataGridViewTextBoxColumn.DataPropertyName = "ShopId";
            this.shopIdDataGridViewTextBoxColumn.HeaderText = "ShopId";
            this.shopIdDataGridViewTextBoxColumn.Name = "shopIdDataGridViewTextBoxColumn";
            this.shopIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costumeIDDataGridViewTextBoxColumn1
            // 
            this.costumeIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn1.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn1.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn1.Name = "costumeIDDataGridViewTextBoxColumn1";
            this.costumeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn1.Width = 230;
            // 
            // costumeNameDataGridViewTextBoxColumn1
            // 
            this.costumeNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn1.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn1.HeaderText = "商品名称";
            this.costumeNameDataGridViewTextBoxColumn1.Name = "costumeNameDataGridViewTextBoxColumn1";
            this.costumeNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.costumeNameDataGridViewTextBoxColumn1.Width = 230;
            // 
            // shopNameDataGridViewTextBoxColumn1
            // 
            this.shopNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.shopNameDataGridViewTextBoxColumn1.DataPropertyName = "ShopName";
            this.shopNameDataGridViewTextBoxColumn1.HeaderText = "店铺";
            this.shopNameDataGridViewTextBoxColumn1.Name = "shopNameDataGridViewTextBoxColumn1";
            this.shopNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.shopNameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // SalePriceColumn
            // 
            this.SalePriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SalePriceColumn.DataPropertyName = "Price";
            this.SalePriceColumn.HeaderText = "吊牌价";
            this.SalePriceColumn.Name = "SalePriceColumn";
            this.SalePriceColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "SalePrice";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "售价";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 200;
            // 
            // ColumnUpdate
            // 
            this.ColumnUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnUpdate.HeaderText = "编辑";
            this.ColumnUpdate.Name = "ColumnUpdate";
            this.ColumnUpdate.Text = "编辑";
            this.ColumnUpdate.UseColumnTextForLinkValue = true;
            this.ColumnUpdate.Width = 40;
            // 
            // UpdateShopCostumePriceCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "UpdateShopCostumePriceCtrl";
            this.Load += new System.EventHandler(this.ReturnOrderManageCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private Common.Components.BaseButton BaseButton1;
        private System.Windows.Forms.BindingSource outboundDetailBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xL6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinComboBox skinComboBoxShopID;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue2DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue1DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue2DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeValue3DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPriceSumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyWeiXinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyAlipayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyCash2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyBankCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyVipCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyIntegrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDeductedByTicketDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alipay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnionpayCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CostumeTextBox costumeFromSupplierTextBox1;
        private Common.BrandComboBox skinComboBox_Brand;
        private System.Windows.Forms.Label label4;
        private CostumeClassSelector skinComboBoxBigClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnUpdate;
    }
}
