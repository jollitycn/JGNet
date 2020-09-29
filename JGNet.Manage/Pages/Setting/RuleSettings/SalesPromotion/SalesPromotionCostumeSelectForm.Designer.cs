using JGNet.Common;
using JGNet.Common.Components;

namespace JGNet.Manage.Pages
{
    partial class SalesPromotionCostumeSelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesPromotionCostumeSelectForm));
            this.skinComboBoxYear = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxSupplierID = new JGNet.Common.Components.SupllierComboBox();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Brand = new JGNet.Common.BrandComboBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxSeason = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxBigClass = new JGNet.Common.CostumeClassSelector();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinPanelSelectBtn = new CCWin.SkinControl.SkinPanel();
            this.BaseButton7 = new JGNet.Common.Components.BaseButton();
            this.BaseButton6 = new JGNet.Common.Components.BaseButton();
            this.BaseButton5 = new JGNet.Common.Components.BaseButton();
            this.BaseButton2 = new JGNet.Common.Components.BaseButton();
            this.groupBoxQueryResult = new CCWin.SkinControl.SkinPanel();
            this.dataGridViewQueryResults = new System.Windows.Forms.DataGridView();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.groupBox2 = new CCWin.SkinControl.SkinPanel();
            this.dataGridViewTarget = new System.Windows.Forms.DataGridView();
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinPanelCheck = new CCWin.SkinControl.SkinPanel();
            this.skinCheckBoxUnJoin = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxJoin = new CCWin.SkinControl.SkinCheckBox();
            this.skinPanelQuery = new CCWin.SkinControl.SkinPanel();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.costumeTextBox1 = new JGNet.Common.TextBox();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.BaseButton4 = new JGNet.Common.Components.BaseButton();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSeason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPanel2.SuspendLayout();
            this.skinPanelSelectBtn.SuspendLayout();
            this.groupBoxQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarget)).BeginInit();
            this.skinPanel4.SuspendLayout();
            this.skinPanelCheck.SuspendLayout();
            this.skinPanelQuery.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinComboBoxYear
            // 
            this.skinComboBoxYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxYear.FormattingEnabled = true;
            this.skinComboBoxYear.Location = new System.Drawing.Point(205, 10);
            this.skinComboBoxYear.Name = "skinComboBoxYear";
            this.skinComboBoxYear.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxYear.TabIndex = 1;
            this.skinComboBoxYear.WaterText = "";
            // 
            // skinComboBoxSupplierID
            // 
            this.skinComboBoxSupplierID.AutoSize = true;
            this.skinComboBoxSupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxSupplierID.EnabledSupplier = false;
            this.skinComboBoxSupplierID.HideAll = false;
            this.skinComboBoxSupplierID.Location = new System.Drawing.Point(706, 7);
            this.skinComboBoxSupplierID.Name = "skinComboBoxSupplierID";
            this.skinComboBoxSupplierID.SelectedItem = ((JGNet.Supplier)(resources.GetObject("skinComboBoxSupplierID.SelectedItem")));
            this.skinComboBoxSupplierID.SelectedValue = null;
            this.skinComboBoxSupplierID.ShowAdd = true;
            this.skinComboBoxSupplierID.Size = new System.Drawing.Size(175, 26);
            this.skinComboBoxSupplierID.TabIndex = 4;
            this.skinComboBoxSupplierID.Title = null;
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(659, 12);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(44, 17);
            this.skinLabel10.TabIndex = 16;
            this.skinLabel10.Text = "供应商";
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Brand.FormattingEnabled = true;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(532, 10);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectStr = null;
            this.skinComboBox_Brand.ShowAll = true;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(121, 22);
            this.skinComboBox_Brand.SupplierID = null;
            this.skinComboBox_Brand.TabIndex = 5;
            this.skinComboBox_Brand.WaterText = "";
            this.skinComboBox_Brand.TextUpdate += new System.EventHandler(this.skinComboBox_Brand_TextUpdate);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(497, 12);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 9;
            this.skinLabel6.Text = "品牌";
            // 
            // skinComboBoxSeason
            // 
            this.skinComboBoxSeason.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxSeason.FormattingEnabled = true;
            this.skinComboBoxSeason.Location = new System.Drawing.Point(367, 10);
            this.skinComboBoxSeason.Name = "skinComboBoxSeason";
            this.skinComboBoxSeason.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxSeason.TabIndex = 2;
            this.skinComboBoxSeason.WaterText = "";
            // 
            // skinComboBoxBigClass
            // 
            this.skinComboBoxBigClass.AutoSize = true;
            this.skinComboBoxBigClass.Location = new System.Drawing.Point(917, 6);
            this.skinComboBoxBigClass.Name = "skinComboBoxBigClass";
            this.skinComboBoxBigClass.SelectedValue = ((JGNet.Costume)(resources.GetObject("skinComboBoxBigClass.SelectedValue")));
            this.skinComboBoxBigClass.Size = new System.Drawing.Size(153, 29);
            this.skinComboBoxBigClass.TabIndex = 17;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(332, 12);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "季节";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(882, 12);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "类别";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(170, 12);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "年份";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(4, 12);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "款号";
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.skinPanelSelectBtn);
            this.skinPanel2.Controls.Add(this.groupBoxQueryResult);
            this.skinPanel2.Controls.Add(this.groupBox2);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(4, 70);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(1152, 373);
            this.skinPanel2.TabIndex = 3;
            // 
            // skinPanelSelectBtn
            // 
            this.skinPanelSelectBtn.BackColor = System.Drawing.Color.Transparent;
            this.skinPanelSelectBtn.Controls.Add(this.BaseButton7);
            this.skinPanelSelectBtn.Controls.Add(this.BaseButton6);
            this.skinPanelSelectBtn.Controls.Add(this.BaseButton5);
            this.skinPanelSelectBtn.Controls.Add(this.BaseButton2);
            this.skinPanelSelectBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanelSelectBtn.DownBack = null;
            this.skinPanelSelectBtn.Location = new System.Drawing.Point(535, 6);
            this.skinPanelSelectBtn.MouseBack = null;
            this.skinPanelSelectBtn.Name = "skinPanelSelectBtn";
            this.skinPanelSelectBtn.NormlBack = null;
            this.skinPanelSelectBtn.Size = new System.Drawing.Size(96, 366);
            this.skinPanelSelectBtn.TabIndex = 7;
            // 
            // BaseButton7
            // 
            this.BaseButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton7.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton7.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton7.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton7.Location = new System.Drawing.Point(11, 222);
            this.BaseButton7.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton7.Name = "BaseButton7";
            this.BaseButton7.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton7.Size = new System.Drawing.Size(75, 32);
            this.BaseButton7.TabIndex = 14;
            this.BaseButton7.Text = "<";
            this.BaseButton7.UseVisualStyleBackColor = false;
            this.BaseButton7.Click += new System.EventHandler(this.BaseButtonRemoveSingle_Click);
            // 
            // BaseButton6
            // 
            this.BaseButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton6.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton6.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton6.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton6.Location = new System.Drawing.Point(11, 184);
            this.BaseButton6.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton6.Name = "BaseButton6";
            this.BaseButton6.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton6.Size = new System.Drawing.Size(75, 32);
            this.BaseButton6.TabIndex = 13;
            this.BaseButton6.Text = "<<";
            this.BaseButton6.UseVisualStyleBackColor = false;
            this.BaseButton6.Click += new System.EventHandler(this.BaseButtonRemoveAll_Click);
            // 
            // BaseButton5
            // 
            this.BaseButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton5.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton5.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton5.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton5.Location = new System.Drawing.Point(11, 146);
            this.BaseButton5.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton5.Name = "BaseButton5";
            this.BaseButton5.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton5.Size = new System.Drawing.Size(75, 32);
            this.BaseButton5.TabIndex = 12;
            this.BaseButton5.Text = ">>";
            this.BaseButton5.UseVisualStyleBackColor = false;
            this.BaseButton5.Click += new System.EventHandler(this.BaseButtonAddAll_Click);
            // 
            // BaseButton2
            // 
            this.BaseButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton2.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton2.Location = new System.Drawing.Point(11, 108);
            this.BaseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton2.Name = "BaseButton2";
            this.BaseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton2.Size = new System.Drawing.Size(75, 32);
            this.BaseButton2.TabIndex = 11;
            this.BaseButton2.Text = ">";
            this.BaseButton2.UseVisualStyleBackColor = false;
            this.BaseButton2.Click += new System.EventHandler(this.BaseButtonAddSingle_Click);
            // 
            // groupBoxQueryResult
            // 
            this.groupBoxQueryResult.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxQueryResult.Controls.Add(this.dataGridViewQueryResults);
            this.groupBoxQueryResult.Controls.Add(this.skinPanel1);
            this.groupBoxQueryResult.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.groupBoxQueryResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxQueryResult.DownBack = null;
            this.groupBoxQueryResult.Location = new System.Drawing.Point(0, 0);
            this.groupBoxQueryResult.MouseBack = null;
            this.groupBoxQueryResult.Name = "groupBoxQueryResult";
            this.groupBoxQueryResult.NormlBack = null;
            this.groupBoxQueryResult.Size = new System.Drawing.Size(529, 373);
            this.groupBoxQueryResult.TabIndex = 6;
            this.groupBoxQueryResult.Text = "可选商品";
            // 
            // dataGridViewQueryResults
            // 
            this.dataGridViewQueryResults.AllowUserToAddRows = false;
            this.dataGridViewQueryResults.AllowUserToDeleteRows = false;
            this.dataGridViewQueryResults.AutoGenerateColumns = false;
            this.dataGridViewQueryResults.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.seasonDataGridViewTextBoxColumn});
            this.dataGridViewQueryResults.DataSource = this.costumeBindingSource;
            this.dataGridViewQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQueryResults.Location = new System.Drawing.Point(0, 22);
            this.dataGridViewQueryResults.Name = "dataGridViewQueryResults";
            this.dataGridViewQueryResults.ReadOnly = true;
            this.dataGridViewQueryResults.RowTemplate.Height = 23;
            this.dataGridViewQueryResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQueryResults.Size = new System.Drawing.Size(529, 351);
            this.dataGridViewQueryResults.TabIndex = 12;
            this.dataGridViewQueryResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQueryResults_CellDoubleClick);
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.Costume);
            // 
            // skinPanel1
            // 
            this.skinPanel1.AutoSize = true;
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.BorderColor = System.Drawing.Color.White;
            this.skinPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel1.Controls.Add(this.skinLabel9);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(529, 22);
            this.skinPanel1.TabIndex = 11;
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(217, 3);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(56, 17);
            this.skinLabel9.TabIndex = 0;
            this.skinLabel9.Text = "可选商品";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridViewTarget);
            this.groupBox2.Controls.Add(this.skinPanel4);
            this.groupBox2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.DownBack = null;
            this.groupBox2.Location = new System.Drawing.Point(637, 0);
            this.groupBox2.MouseBack = null;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.NormlBack = null;
            this.groupBox2.Size = new System.Drawing.Size(515, 373);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.Text = "目标商品";
            // 
            // dataGridViewTarget
            // 
            this.dataGridViewTarget.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewTarget.AllowUserToAddRows = false;
            this.dataGridViewTarget.AllowUserToDeleteRows = false;
            this.dataGridViewTarget.AutoGenerateColumns = false;
            this.dataGridViewTarget.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarget.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumnYear,
            this.dataGridViewTextBoxColumnSeason,
            this.CostPrice,
            this.Price});
            this.dataGridViewTarget.DataSource = this.costumeBindingSource;
            this.dataGridViewTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTarget.Location = new System.Drawing.Point(0, 21);
            this.dataGridViewTarget.Name = "dataGridViewTarget";
            this.dataGridViewTarget.RowTemplate.Height = 23;
            this.dataGridViewTarget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTarget.Size = new System.Drawing.Size(515, 352);
            this.dataGridViewTarget.TabIndex = 17;
            this.dataGridViewTarget.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTarget_CellDoubleClick);
            this.dataGridViewTarget.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewTarget_CellValidating);
            // 
            // skinPanel4
            // 
            this.skinPanel4.AutoSize = true;
            this.skinPanel4.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel4.BorderColor = System.Drawing.Color.White;
            this.skinPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel4.Controls.Add(this.skinLabel11);
            this.skinPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel4.DownBack = null;
            this.skinPanel4.Location = new System.Drawing.Point(0, 0);
            this.skinPanel4.MouseBack = null;
            this.skinPanel4.Name = "skinPanel4";
            this.skinPanel4.NormlBack = null;
            this.skinPanel4.Size = new System.Drawing.Size(515, 21);
            this.skinPanel4.TabIndex = 16;
            // 
            // skinLabel11
            // 
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(245, 2);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(56, 17);
            this.skinLabel11.TabIndex = 0;
            this.skinLabel11.Text = "已选商品";
            // 
            // skinPanelCheck
            // 
            this.skinPanelCheck.AutoSize = true;
            this.skinPanelCheck.BackColor = System.Drawing.Color.Transparent;
            this.skinPanelCheck.Controls.Add(this.skinCheckBoxUnJoin);
            this.skinPanelCheck.Controls.Add(this.skinCheckBoxJoin);
            this.skinPanelCheck.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanelCheck.DownBack = null;
            this.skinPanelCheck.Location = new System.Drawing.Point(641, 449);
            this.skinPanelCheck.MouseBack = null;
            this.skinPanelCheck.Name = "skinPanelCheck";
            this.skinPanelCheck.NormlBack = null;
            this.skinPanelCheck.Size = new System.Drawing.Size(414, 26);
            this.skinPanelCheck.TabIndex = 4;
            // 
            // skinCheckBoxUnJoin
            // 
            this.skinCheckBoxUnJoin.AutoSize = true;
            this.skinCheckBoxUnJoin.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxUnJoin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxUnJoin.DownBack = null;
            this.skinCheckBoxUnJoin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxUnJoin.Location = new System.Drawing.Point(147, 2);
            this.skinCheckBoxUnJoin.MouseBack = null;
            this.skinCheckBoxUnJoin.Name = "skinCheckBoxUnJoin";
            this.skinCheckBoxUnJoin.NormlBack = null;
            this.skinCheckBoxUnJoin.SelectedDownBack = null;
            this.skinCheckBoxUnJoin.SelectedMouseBack = null;
            this.skinCheckBoxUnJoin.SelectedNormlBack = null;
            this.skinCheckBoxUnJoin.Size = new System.Drawing.Size(135, 21);
            this.skinCheckBoxUnJoin.TabIndex = 17;
            this.skinCheckBoxUnJoin.Text = "以上产品不参与活动";
            this.skinCheckBoxUnJoin.UseVisualStyleBackColor = false;
            this.skinCheckBoxUnJoin.Visible = false;
            this.skinCheckBoxUnJoin.CheckedChanged += new System.EventHandler(this.skinCheckBoxUnJoin_CheckedChanged);
            // 
            // skinCheckBoxJoin
            // 
            this.skinCheckBoxJoin.AutoSize = true;
            this.skinCheckBoxJoin.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxJoin.Checked = true;
            this.skinCheckBoxJoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxJoin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxJoin.DownBack = null;
            this.skinCheckBoxJoin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxJoin.Location = new System.Drawing.Point(8, 2);
            this.skinCheckBoxJoin.MouseBack = null;
            this.skinCheckBoxJoin.Name = "skinCheckBoxJoin";
            this.skinCheckBoxJoin.NormlBack = null;
            this.skinCheckBoxJoin.SelectedDownBack = null;
            this.skinCheckBoxJoin.SelectedMouseBack = null;
            this.skinCheckBoxJoin.SelectedNormlBack = null;
            this.skinCheckBoxJoin.Size = new System.Drawing.Size(123, 21);
            this.skinCheckBoxJoin.TabIndex = 16;
            this.skinCheckBoxJoin.Text = "以上产品参与活动";
            this.skinCheckBoxJoin.UseVisualStyleBackColor = false;
            this.skinCheckBoxJoin.Visible = false;
            this.skinCheckBoxJoin.CheckedChanged += new System.EventHandler(this.skinCheckBoxJoin_CheckedChanged);
            // 
            // skinPanelQuery
            // 
            this.skinPanelQuery.BackColor = System.Drawing.Color.Transparent;
            this.skinPanelQuery.Controls.Add(this.BaseButton1);
            this.skinPanelQuery.Controls.Add(this.costumeTextBox1);
            this.skinPanelQuery.Controls.Add(this.skinComboBoxYear);
            this.skinPanelQuery.Controls.Add(this.skinComboBoxSupplierID);
            this.skinPanelQuery.Controls.Add(this.skinLabel10);
            this.skinPanelQuery.Controls.Add(this.skinComboBox_Brand);
            this.skinPanelQuery.Controls.Add(this.skinLabel6);
            this.skinPanelQuery.Controls.Add(this.skinComboBoxSeason);
            this.skinPanelQuery.Controls.Add(this.skinComboBoxBigClass);
            this.skinPanelQuery.Controls.Add(this.skinLabel2);
            this.skinPanelQuery.Controls.Add(this.skinLabel4);
            this.skinPanelQuery.Controls.Add(this.skinLabel3);
            this.skinPanelQuery.Controls.Add(this.skinLabel1);
            this.skinPanelQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanelQuery.DownBack = null;
            this.skinPanelQuery.Location = new System.Drawing.Point(4, 28);
            this.skinPanelQuery.MouseBack = null;
            this.skinPanelQuery.Name = "skinPanelQuery";
            this.skinPanelQuery.NormlBack = null;
            this.skinPanelQuery.Size = new System.Drawing.Size(1152, 42);
            this.skinPanelQuery.TabIndex = 2;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(1071, 6);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 9;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // costumeTextBox1
            // 
            this.costumeTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.costumeTextBox1.DownBack = null;
            this.costumeTextBox1.Icon = null;
            this.costumeTextBox1.IconIsButton = false;
            this.costumeTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeTextBox1.IsPasswordChat = '\0';
            this.costumeTextBox1.IsSystemPasswordChar = false;
            this.costumeTextBox1.Lines = new string[0];
            this.costumeTextBox1.Location = new System.Drawing.Point(39, 10);
            this.costumeTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.costumeTextBox1.MaxLength = 32767;
            this.costumeTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.costumeTextBox1.MouseBack = null;
            this.costumeTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.costumeTextBox1.Multiline = false;
            this.costumeTextBox1.Name = "costumeTextBox1";
            this.costumeTextBox1.NormlBack = null;
            this.costumeTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.costumeTextBox1.ReadOnly = false;
            this.costumeTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.costumeTextBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // 
            // 
            this.costumeTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.costumeTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costumeTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.costumeTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.costumeTextBox1.SkinTxt.Name = "BaseText";
            this.costumeTextBox1.SkinTxt.Size = new System.Drawing.Size(111, 18);
            this.costumeTextBox1.SkinTxt.TabIndex = 0;
            this.costumeTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeTextBox1.SkinTxt.WaterText = "";
            this.costumeTextBox1.TabIndex = 0;
            this.costumeTextBox1.TabStop = true;
            this.costumeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.costumeTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.costumeTextBox1.WaterText = "";
            this.costumeTextBox1.WordWrap = true;
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.BaseButton3);
            this.skinPanel3.Controls.Add(this.BaseButton4);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(4, 482);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(1152, 32);
            this.skinPanel3.TabIndex = 4;
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(990, 3);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 18;
            this.BaseButton3.Text = "确认";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // BaseButton4
            // 
            this.BaseButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton4.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton4.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton4.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton4.Location = new System.Drawing.Point(1071, 3);
            this.BaseButton4.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton4.Name = "BaseButton4";
            this.BaseButton4.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton4.Size = new System.Drawing.Size(75, 32);
            this.BaseButton4.TabIndex = 19;
            this.BaseButton4.Text = "取消";
            this.BaseButton4.UseVisualStyleBackColor = false;
            this.BaseButton4.Click += new System.EventHandler(this.BaseButton2_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandDataGridViewTextBoxColumn.HeaderText = "品牌";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandDataGridViewTextBoxColumn.Width = 69;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "供应商";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "吊牌价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 69;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "年份";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 70;
            // 
            // seasonDataGridViewTextBoxColumn
            // 
            this.seasonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seasonDataGridViewTextBoxColumn.DataPropertyName = "Season";
            this.seasonDataGridViewTextBoxColumn.HeaderText = "季节";
            this.seasonDataGridViewTextBoxColumn.Name = "seasonDataGridViewTextBoxColumn";
            this.seasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.seasonDataGridViewTextBoxColumn.Width = 54;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "款号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // dataGridViewTextBoxColumnYear
            // 
            this.dataGridViewTextBoxColumnYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumnYear.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumnYear.HeaderText = "年份";
            this.dataGridViewTextBoxColumnYear.Name = "dataGridViewTextBoxColumnYear";
            this.dataGridViewTextBoxColumnYear.ReadOnly = true;
            this.dataGridViewTextBoxColumnYear.Width = 79;
            // 
            // dataGridViewTextBoxColumnSeason
            // 
            this.dataGridViewTextBoxColumnSeason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumnSeason.DataPropertyName = "Season";
            this.dataGridViewTextBoxColumnSeason.HeaderText = "季节";
            this.dataGridViewTextBoxColumnSeason.Name = "dataGridViewTextBoxColumnSeason";
            this.dataGridViewTextBoxColumnSeason.ReadOnly = true;
            this.dataGridViewTextBoxColumnSeason.Width = 79;
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostPrice.DataPropertyName = "BuyoutPrice";
            this.CostPrice.HeaderText = "一口价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Width = 78;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "吊牌价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 66;
            // 
            // SalesPromotionCostumeSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 518);
            this.Controls.Add(this.skinPanel3);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanelCheck);
            this.Controls.Add(this.skinPanelQuery);
            this.MaximizeBox = false;
            this.Name = "SalesPromotionCostumeSelectForm";
            this.Text = "选择促销商品";
            this.Load += new System.EventHandler(this.SalesPromotionCostumeSelectForm_Load);
            this.skinPanel2.ResumeLayout(false);
            this.skinPanelSelectBtn.ResumeLayout(false);
            this.groupBoxQueryResult.ResumeLayout(false);
            this.groupBoxQueryResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarget)).EndInit();
            this.skinPanel4.ResumeLayout(false);
            this.skinPanel4.PerformLayout();
            this.skinPanelCheck.ResumeLayout(false);
            this.skinPanelCheck.PerformLayout();
            this.skinPanelQuery.ResumeLayout(false);
            this.skinPanelQuery.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinComboBox skinComboBoxYear;
        private SupllierComboBox skinComboBoxSupplierID;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private JGNet.Common.BrandComboBox skinComboBox_Brand;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinComboBox skinComboBoxSeason;
        private CostumeClassSelector skinComboBoxBigClass;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinPanel skinPanelQuery;
        private CCWin.SkinControl.SkinPanel groupBoxQueryResult;
        private CCWin.SkinControl.SkinPanel skinPanelSelectBtn;
        private JGNet.Common.TextBox costumeTextBox1;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.BaseButton BaseButton7;
        private Common.Components.BaseButton BaseButton6;
        private Common.Components.BaseButton BaseButton5;
        private Common.Components.BaseButton BaseButton2;
        private CCWin.SkinControl.SkinPanel groupBox2;
        private CCWin.SkinControl.SkinPanel skinPanelCheck;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxUnJoin;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxJoin;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private Common.Components.BaseButton BaseButton3;
        private Common.Components.BaseButton BaseButton4;
        private System.Windows.Forms.DataGridView dataGridViewQueryResults;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinPanel skinPanel4;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private System.Windows.Forms.DataGridView dataGridViewTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSeason;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}