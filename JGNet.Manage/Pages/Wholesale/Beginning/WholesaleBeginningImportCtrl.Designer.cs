using JGNet.Common;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class WholesaleBeginningImportCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WholesaleBeginningImportCtrl));
            this.cashRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBox_PfCustomer = new JGNet.Common.PfCustomerComboBox();
            this.downTemplateButton1 = new JGNet.Common.Components.DownTemplateButton();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.costumeStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.baseButtonSave = new JGNet.Common.Components.BaseButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BigClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SmallClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubSmallClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeGroupShowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xL6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cashRecordBindingSource
            // 
            this.cashRecordBindingSource.DataSource = typeof(JGNet.PfCustomerStore);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBox_PfCustomer);
            this.skinPanel1.Controls.Add(this.downTemplateButton1);
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 44);
            this.skinPanel1.TabIndex = 4;
            // 
            // skinComboBox_PfCustomer
            // 
            this.skinComboBox_PfCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinComboBox_PfCustomer.CheckPfCustomer = false;
            this.skinComboBox_PfCustomer.curSelectStr = null;
            this.skinComboBox_PfCustomer.CustomerTypeValue = -1;
            this.skinComboBox_PfCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_PfCustomer.FormattingEnabled = true;
            this.skinComboBox_PfCustomer.HideEmpty = false;
            this.skinComboBox_PfCustomer.Location = new System.Drawing.Point(850, 10);
            this.skinComboBox_PfCustomer.Name = "skinComboBox_PfCustomer";
            this.skinComboBox_PfCustomer.Size = new System.Drawing.Size(128, 22);
            this.skinComboBox_PfCustomer.TabIndex = 217;
            this.skinComboBox_PfCustomer.WaterText = "";
            this.skinComboBox_PfCustomer.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_PfCustomer_SelectedIndexChanged);
            // 
            // downTemplateButton1
            // 
            this.downTemplateButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downTemplateButton1.BackColor = System.Drawing.Color.Transparent;
            this.downTemplateButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.downTemplateButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("downTemplateButton1.DownBack")));
            this.downTemplateButton1.DownName = "客户期初库存导入模板.xls";
            this.downTemplateButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.downTemplateButton1.FileName = "客户期初库存导入模板.xls";
            this.downTemplateButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.downTemplateButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.downTemplateButton1.Location = new System.Drawing.Point(1076, 6);
            this.downTemplateButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("downTemplateButton1.MouseBack")));
            this.downTemplateButton1.Name = "downTemplateButton1";
            this.downTemplateButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("downTemplateButton1.NormlBack")));
            this.downTemplateButton1.Size = new System.Drawing.Size(75, 32);
            this.downTemplateButton1.TabIndex = 208;
            this.downTemplateButton1.Text = "下载模板";
            this.downTemplateButton1.UseVisualStyleBackColor = false;
            this.downTemplateButton1.Click += new System.EventHandler(this.downTemplateButton1_Click);
            // 
            // baseButton1
            // 
            this.baseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(995, 6);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 207;
            this.baseButton1.Text = "导入";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(810, 12);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 145;
            this.skinLabel6.Text = "客户";
            // 
            // costumeStoreBindingSource
            // 
            this.costumeStoreBindingSource.DataSource = typeof(JGNet.CostumeStore);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.baseButtonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 41);
            this.panel1.TabIndex = 7;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSave.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonSave.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSave.Location = new System.Drawing.Point(1082, 6);
            this.baseButtonSave.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonSave.Name = "baseButtonSave";
            this.baseButtonSave.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonSave.Size = new System.Drawing.Size(75, 32);
            this.baseButtonSave.TabIndex = 179;
            this.baseButtonSave.Text = "保存";
            this.baseButtonSave.UseVisualStyleBackColor = false;
            this.baseButtonSave.Click += new System.EventHandler(this.baseButtonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.costumeNameDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.Price,
            this.CostPrice,
            this.BrandName,
            this.SupplierName,
            this.Year,
            this.Season,
            this.BigClass,
            this.SmallClass,
            this.SubSmallClass,
            this.SizeGroupShowName,
            this.fDataGridViewTextBoxColumn,
            this.xSDataGridViewTextBoxColumn,
            this.sDataGridViewTextBoxColumn,
            this.mDataGridViewTextBoxColumn,
            this.lDataGridViewTextBoxColumn,
            this.xLDataGridViewTextBoxColumn,
            this.xL2DataGridViewTextBoxColumn,
            this.xL3DataGridViewTextBoxColumn,
            this.xL4DataGridViewTextBoxColumn,
            this.xL5DataGridViewTextBoxColumn,
            this.xL6DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cashRecordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 565);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "吊牌价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 90;
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostPrice.DataPropertyName = "PfPrice";
            this.CostPrice.HeaderText = "批发价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            this.CostPrice.Width = 90;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "品牌";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 50;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "供应商";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 60;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "年份";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 46;
            // 
            // Season
            // 
            this.Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Season.DataPropertyName = "Season";
            this.Season.HeaderText = "季节";
            this.Season.Name = "Season";
            this.Season.ReadOnly = true;
            this.Season.Width = 47;
            // 
            // BigClass
            // 
            this.BigClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BigClass.DataPropertyName = "BigClass";
            this.BigClass.HeaderText = "一级类别";
            this.BigClass.Name = "BigClass";
            this.BigClass.ReadOnly = true;
            this.BigClass.Width = 80;
            // 
            // SmallClass
            // 
            this.SmallClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SmallClass.DataPropertyName = "SmallClass";
            this.SmallClass.HeaderText = "二级类别";
            this.SmallClass.Name = "SmallClass";
            this.SmallClass.Width = 80;
            // 
            // SubSmallClass
            // 
            this.SubSmallClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SubSmallClass.DataPropertyName = "SubSmallClass";
            this.SubSmallClass.HeaderText = "三级类别";
            this.SubSmallClass.Name = "SubSmallClass";
            this.SubSmallClass.Width = 80;
            // 
            // SizeGroupShowName
            // 
            this.SizeGroupShowName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SizeGroupShowName.DataPropertyName = "SizeGroupShowName";
            this.SizeGroupShowName.HeaderText = "尺码组名称";
            this.SizeGroupShowName.Name = "SizeGroupShowName";
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "F";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.Width = 47;
            // 
            // xSDataGridViewTextBoxColumn
            // 
            this.xSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xSDataGridViewTextBoxColumn.DataPropertyName = "XS";
            this.xSDataGridViewTextBoxColumn.HeaderText = "XS";
            this.xSDataGridViewTextBoxColumn.Name = "xSDataGridViewTextBoxColumn";
            this.xSDataGridViewTextBoxColumn.Width = 46;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 47;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.Width = 46;
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            this.lDataGridViewTextBoxColumn.Width = 47;
            // 
            // xLDataGridViewTextBoxColumn
            // 
            this.xLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xLDataGridViewTextBoxColumn.DataPropertyName = "XL";
            this.xLDataGridViewTextBoxColumn.HeaderText = "XL";
            this.xLDataGridViewTextBoxColumn.Name = "xLDataGridViewTextBoxColumn";
            this.xLDataGridViewTextBoxColumn.Width = 46;
            // 
            // xL2DataGridViewTextBoxColumn
            // 
            this.xL2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL2DataGridViewTextBoxColumn.DataPropertyName = "XL2";
            this.xL2DataGridViewTextBoxColumn.HeaderText = "XL2";
            this.xL2DataGridViewTextBoxColumn.Name = "xL2DataGridViewTextBoxColumn";
            this.xL2DataGridViewTextBoxColumn.Width = 47;
            // 
            // xL3DataGridViewTextBoxColumn
            // 
            this.xL3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL3DataGridViewTextBoxColumn.DataPropertyName = "XL3";
            this.xL3DataGridViewTextBoxColumn.HeaderText = "XL3";
            this.xL3DataGridViewTextBoxColumn.Name = "xL3DataGridViewTextBoxColumn";
            this.xL3DataGridViewTextBoxColumn.Width = 46;
            // 
            // xL4DataGridViewTextBoxColumn
            // 
            this.xL4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL4DataGridViewTextBoxColumn.DataPropertyName = "XL4";
            this.xL4DataGridViewTextBoxColumn.HeaderText = "XL4";
            this.xL4DataGridViewTextBoxColumn.Name = "xL4DataGridViewTextBoxColumn";
            this.xL4DataGridViewTextBoxColumn.Width = 47;
            // 
            // xL5DataGridViewTextBoxColumn
            // 
            this.xL5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL5DataGridViewTextBoxColumn.DataPropertyName = "XL5";
            this.xL5DataGridViewTextBoxColumn.HeaderText = "XL5";
            this.xL5DataGridViewTextBoxColumn.Name = "xL5DataGridViewTextBoxColumn";
            this.xL5DataGridViewTextBoxColumn.Width = 46;
            // 
            // xL6DataGridViewTextBoxColumn
            // 
            this.xL6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL6DataGridViewTextBoxColumn.DataPropertyName = "XL6";
            this.xL6DataGridViewTextBoxColumn.HeaderText = "XL6";
            this.xL6DataGridViewTextBoxColumn.Name = "xL6DataGridViewTextBoxColumn";
            this.xL6DataGridViewTextBoxColumn.Width = 48;
            // 
            // WholesaleBeginningImportCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "WholesaleBeginningImportCtrl";
            this.Load += new System.EventHandler(this.SupplierAccountSearchCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cashRecordBindingSource;
        private System.Windows.Forms.Panel skinPanel1;
        private Panel panel1;
        private BindingSource costumeStoreBindingSource;
        private Common.Components.BaseButton baseButtonSave;
        private Common.Components.BaseButton baseButton1;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private DataGridView dataGridView1;
        private Common.Components.DownTemplateButton downTemplateButton1;
        private PfCustomerComboBox skinComboBox_PfCustomer;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn CostPrice;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Season;
        private DataGridViewTextBoxColumn BigClass;
        private DataGridViewTextBoxColumn SmallClass;
        private DataGridViewTextBoxColumn SubSmallClass;
        private DataGridViewTextBoxColumn SizeGroupShowName;
        private DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xSDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xL6DataGridViewTextBoxColumn;
    }
}
