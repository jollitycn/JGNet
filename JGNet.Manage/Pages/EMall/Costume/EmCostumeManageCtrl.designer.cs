using JGNet.Common;

namespace JGNet.Manage
{
    partial class EmCostumeManageCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmCostumeManageCtrl));
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmOnlinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PfOnlinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOfSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmShowOnline = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PfShowOnline = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsNew = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsHot = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinComboType = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBoxHot = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxNew = new CCWin.SkinControl.SkinCheckBox();
            this.baseButtonImport = new JGNet.Common.Components.BaseButton();
            this.skinComboBoxBigClass = new JGNet.Common.CostumeClassSelector();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel3 = new System.Windows.Forms.Panel();
            this.skinRadioButtonOffline = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButtonOnline = new CCWin.SkinControl.SkinRadioButton();
            this.skinCheckBoxShowImage = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxIsOnlyShowRecommand = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinTextBoxID = new JGNet.Manage.EmCostumeTextBox();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.dataGridView1);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.Location = new System.Drawing.Point(0, 74);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 576);
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
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Column3,
            this.EmOnlinePrice,
            this.PfOnlinePrice,
            this.EmPrice,
            this.QuantityOfSale,
            this.EmTitle,
            this.EmShowOnline,
            this.PfShowOnline,
            this.IsNew,
            this.IsHot,
            this.CreateTime,
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column5});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 576);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 75;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 75;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "BrandName";
            this.Column3.HeaderText = "品牌";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 74;
            // 
            // EmOnlinePrice
            // 
            this.EmOnlinePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmOnlinePrice.DataPropertyName = "EmOnlinePrice";
            this.EmOnlinePrice.HeaderText = "线上零售价";
            this.EmOnlinePrice.Name = "EmOnlinePrice";
            this.EmOnlinePrice.ReadOnly = true;
            this.EmOnlinePrice.Width = 75;
            // 
            // PfOnlinePrice
            // 
            this.PfOnlinePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PfOnlinePrice.DataPropertyName = "PfOnlinePrice";
            this.PfOnlinePrice.HeaderText = "线上批发价";
            this.PfOnlinePrice.Name = "PfOnlinePrice";
            this.PfOnlinePrice.Width = 75;
            // 
            // EmPrice
            // 
            this.EmPrice.DataPropertyName = "EmPrice";
            this.EmPrice.HeaderText = "线上吊牌价";
            this.EmPrice.Name = "EmPrice";
            // 
            // QuantityOfSale
            // 
            this.QuantityOfSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QuantityOfSale.DataPropertyName = "QuantityOfSale";
            this.QuantityOfSale.HeaderText = "销量";
            this.QuantityOfSale.Name = "QuantityOfSale";
            this.QuantityOfSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QuantityOfSale.Width = 75;
            // 
            // EmTitle
            // 
            this.EmTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmTitle.DataPropertyName = "EmTitle";
            this.EmTitle.HeaderText = "标题";
            this.EmTitle.Name = "EmTitle";
            this.EmTitle.ReadOnly = true;
            this.EmTitle.Width = 74;
            // 
            // EmShowOnline
            // 
            this.EmShowOnline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmShowOnline.DataPropertyName = "EmShowOnline";
            this.EmShowOnline.HeaderText = "零售";
            this.EmShowOnline.Name = "EmShowOnline";
            this.EmShowOnline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EmShowOnline.Width = 75;
            // 
            // PfShowOnline
            // 
            this.PfShowOnline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PfShowOnline.DataPropertyName = "PfShowOnline";
            this.PfShowOnline.HeaderText = "批发";
            this.PfShowOnline.Name = "PfShowOnline";
            this.PfShowOnline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PfShowOnline.Width = 75;
            // 
            // IsNew
            // 
            this.IsNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsNew.DataPropertyName = "IsNew";
            this.IsNew.FalseValue = "False";
            this.IsNew.HeaderText = "新品";
            this.IsNew.Name = "IsNew";
            this.IsNew.TrueValue = "true";
            this.IsNew.Width = 75;
            // 
            // IsHot
            // 
            this.IsHot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsHot.DataPropertyName = "IsHot";
            this.IsHot.FalseValue = "false";
            this.IsHot.HeaderText = "热卖";
            this.IsHot.Name = "IsHot";
            this.IsHot.TrueValue = "true";
            this.IsHot.Width = 75;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreateTime.DataPropertyName = "EmOnlineTime";
            this.CreateTime.HeaderText = "上架时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 120;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "EmOfflineTime";
            this.Column4.HeaderText = "下架时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
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
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "下架";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "下架";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "上架";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Text = "上架";
            this.Column5.UseColumnTextForLinkValue = true;
            this.Column5.Width = 40;
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.Core.InteractEntity.EmCostume);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinComboType);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinCheckBoxHot);
            this.skinPanel1.Controls.Add(this.skinCheckBoxNew);
            this.skinPanel1.Controls.Add(this.baseButtonImport);
            this.skinPanel1.Controls.Add(this.skinComboBoxBigClass);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinPanel3);
            this.skinPanel1.Controls.Add(this.skinCheckBoxShowImage);
            this.skinPanel1.Controls.Add(this.skinCheckBoxIsOnlyShowRecommand);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Controls.Add(this.skinTextBoxID);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 74);
            this.skinPanel1.TabIndex = 0;
            this.skinPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPanel1_Paint);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Red;
            this.skinLabel3.Location = new System.Drawing.Point(4, 51);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(120, 17);
            this.skinLabel3.TabIndex = 133;
            this.skinLabel3.Text = "（销量可直接修改） ";
            // 
            // skinComboType
            // 
            this.skinComboType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboType.FormattingEnabled = true;
            this.skinComboType.Location = new System.Drawing.Point(383, 19);
            this.skinComboType.Name = "skinComboType";
            this.skinComboType.Size = new System.Drawing.Size(97, 22);
            this.skinComboType.TabIndex = 132;
            this.skinComboType.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(346, 22);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 21;
            this.skinLabel2.Text = "类型";
            // 
            // skinCheckBoxHot
            // 
            this.skinCheckBoxHot.AutoSize = true;
            this.skinCheckBoxHot.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxHot.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxHot.DownBack = null;
            this.skinCheckBoxHot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxHot.Location = new System.Drawing.Point(850, 21);
            this.skinCheckBoxHot.MouseBack = null;
            this.skinCheckBoxHot.Name = "skinCheckBoxHot";
            this.skinCheckBoxHot.NormlBack = null;
            this.skinCheckBoxHot.SelectedDownBack = null;
            this.skinCheckBoxHot.SelectedMouseBack = null;
            this.skinCheckBoxHot.SelectedNormlBack = null;
            this.skinCheckBoxHot.Size = new System.Drawing.Size(87, 21);
            this.skinCheckBoxHot.TabIndex = 20;
            this.skinCheckBoxHot.Text = "只列出热卖";
            this.skinCheckBoxHot.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxNew
            // 
            this.skinCheckBoxNew.AutoSize = true;
            this.skinCheckBoxNew.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxNew.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxNew.DownBack = null;
            this.skinCheckBoxNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxNew.Location = new System.Drawing.Point(757, 21);
            this.skinCheckBoxNew.MouseBack = null;
            this.skinCheckBoxNew.Name = "skinCheckBoxNew";
            this.skinCheckBoxNew.NormlBack = null;
            this.skinCheckBoxNew.SelectedDownBack = null;
            this.skinCheckBoxNew.SelectedMouseBack = null;
            this.skinCheckBoxNew.SelectedNormlBack = null;
            this.skinCheckBoxNew.Size = new System.Drawing.Size(87, 21);
            this.skinCheckBoxNew.TabIndex = 19;
            this.skinCheckBoxNew.Text = "只列出新品";
            this.skinCheckBoxNew.UseVisualStyleBackColor = false;
            // 
            // baseButtonImport
            // 
            this.baseButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonImport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonImport.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonImport.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonImport.Location = new System.Drawing.Point(1022, 16);
            this.baseButtonImport.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonImport.Name = "baseButtonImport";
            this.baseButtonImport.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonImport.Size = new System.Drawing.Size(69, 32);
            this.baseButtonImport.TabIndex = 18;
            this.baseButtonImport.Text = "导入";
            this.baseButtonImport.UseVisualStyleBackColor = false;
            this.baseButtonImport.Visible = false;
            this.baseButtonImport.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // skinComboBoxBigClass
            // 
            this.skinComboBoxBigClass.AutoSize = true;
            this.skinComboBoxBigClass.Location = new System.Drawing.Point(40, 16);
            this.skinComboBoxBigClass.Name = "skinComboBoxBigClass";
            this.skinComboBoxBigClass.SelectedValue = ((JGNet.Costume)(resources.GetObject("skinComboBoxBigClass.SelectedValue")));
            this.skinComboBoxBigClass.Size = new System.Drawing.Size(151, 29);
            this.skinComboBoxBigClass.TabIndex = 0;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(4, 22);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 17;
            this.skinLabel4.Text = "类别";
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel3.Controls.Add(this.skinRadioButtonOffline);
            this.skinPanel3.Controls.Add(this.skinRadioButtonOnline);
            this.skinPanel3.Location = new System.Drawing.Point(505, 16);
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.Size = new System.Drawing.Size(165, 28);
            this.skinPanel3.TabIndex = 16;
            // 
            // skinRadioButtonOffline
            // 
            this.skinRadioButtonOffline.AutoSize = true;
            this.skinRadioButtonOffline.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonOffline.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonOffline.DownBack = null;
            this.skinRadioButtonOffline.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonOffline.Location = new System.Drawing.Point(76, 2);
            this.skinRadioButtonOffline.MouseBack = null;
            this.skinRadioButtonOffline.Name = "skinRadioButtonOffline";
            this.skinRadioButtonOffline.NormlBack = null;
            this.skinRadioButtonOffline.SelectedDownBack = null;
            this.skinRadioButtonOffline.SelectedMouseBack = null;
            this.skinRadioButtonOffline.SelectedNormlBack = null;
            this.skinRadioButtonOffline.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButtonOffline.TabIndex = 6;
            this.skinRadioButtonOffline.Tag = "sexRadio";
            this.skinRadioButtonOffline.Text = "线下商品";
            this.skinRadioButtonOffline.UseVisualStyleBackColor = false;
            this.skinRadioButtonOffline.CheckedChanged += new System.EventHandler(this.skinRadioButtonOffline_CheckedChanged);
            // 
            // skinRadioButtonOnline
            // 
            this.skinRadioButtonOnline.AutoSize = true;
            this.skinRadioButtonOnline.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonOnline.Checked = true;
            this.skinRadioButtonOnline.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonOnline.DownBack = null;
            this.skinRadioButtonOnline.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonOnline.Location = new System.Drawing.Point(3, 2);
            this.skinRadioButtonOnline.MouseBack = null;
            this.skinRadioButtonOnline.Name = "skinRadioButtonOnline";
            this.skinRadioButtonOnline.NormlBack = null;
            this.skinRadioButtonOnline.SelectedDownBack = null;
            this.skinRadioButtonOnline.SelectedMouseBack = null;
            this.skinRadioButtonOnline.SelectedNormlBack = null;
            this.skinRadioButtonOnline.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButtonOnline.TabIndex = 6;
            this.skinRadioButtonOnline.TabStop = true;
            this.skinRadioButtonOnline.Tag = "sexRadio";
            this.skinRadioButtonOnline.Text = "线上商品";
            this.skinRadioButtonOnline.UseVisualStyleBackColor = false;
            this.skinRadioButtonOnline.CheckedChanged += new System.EventHandler(this.skinRadioButtonOnline_CheckedChanged);
            // 
            // skinCheckBoxShowImage
            // 
            this.skinCheckBoxShowImage.AutoSize = true;
            this.skinCheckBoxShowImage.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxShowImage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxShowImage.DownBack = null;
            this.skinCheckBoxShowImage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxShowImage.Location = new System.Drawing.Point(676, 21);
            this.skinCheckBoxShowImage.MouseBack = null;
            this.skinCheckBoxShowImage.Name = "skinCheckBoxShowImage";
            this.skinCheckBoxShowImage.NormlBack = null;
            this.skinCheckBoxShowImage.SelectedDownBack = null;
            this.skinCheckBoxShowImage.SelectedMouseBack = null;
            this.skinCheckBoxShowImage.SelectedNormlBack = null;
            this.skinCheckBoxShowImage.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBoxShowImage.TabIndex = 1;
            this.skinCheckBoxShowImage.Text = "显示图片";
            this.skinCheckBoxShowImage.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxIsOnlyShowRecommand
            // 
            this.skinCheckBoxIsOnlyShowRecommand.AutoSize = true;
            this.skinCheckBoxIsOnlyShowRecommand.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxIsOnlyShowRecommand.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxIsOnlyShowRecommand.DownBack = null;
            this.skinCheckBoxIsOnlyShowRecommand.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxIsOnlyShowRecommand.Location = new System.Drawing.Point(826, 47);
            this.skinCheckBoxIsOnlyShowRecommand.MouseBack = null;
            this.skinCheckBoxIsOnlyShowRecommand.Name = "skinCheckBoxIsOnlyShowRecommand";
            this.skinCheckBoxIsOnlyShowRecommand.NormlBack = null;
            this.skinCheckBoxIsOnlyShowRecommand.SelectedDownBack = null;
            this.skinCheckBoxIsOnlyShowRecommand.SelectedMouseBack = null;
            this.skinCheckBoxIsOnlyShowRecommand.SelectedNormlBack = null;
            this.skinCheckBoxIsOnlyShowRecommand.Size = new System.Drawing.Size(111, 21);
            this.skinCheckBoxIsOnlyShowRecommand.TabIndex = 1;
            this.skinCheckBoxIsOnlyShowRecommand.Text = "只列出推荐商品";
            this.skinCheckBoxIsOnlyShowRecommand.UseVisualStyleBackColor = false;
            this.skinCheckBoxIsOnlyShowRecommand.Visible = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(203, 22);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "款号";
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(943, 16);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(73, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "查询";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinTextBoxID
            // 
            this.skinTextBoxID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxID.DownBack = null;
            this.skinTextBoxID.EmOnline = true;
            this.skinTextBoxID.FilterValid = true;
            this.skinTextBoxID.Icon = null;
            this.skinTextBoxID.IconIsButton = false;
            this.skinTextBoxID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxID.IsPasswordChat = '\0';
            this.skinTextBoxID.IsSystemPasswordChar = false;
            this.skinTextBoxID.Lines = new string[0];
            this.skinTextBoxID.Location = new System.Drawing.Point(237, 16);
            this.skinTextBoxID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxID.MaxLength = 32767;
            this.skinTextBoxID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxID.MouseBack = null;
            this.skinTextBoxID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxID.Multiline = false;
            this.skinTextBoxID.Name = "skinTextBoxID";
            this.skinTextBoxID.NormlBack = null;
            this.skinTextBoxID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxID.ReadOnly = false;
            this.skinTextBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxID.Size = new System.Drawing.Size(95, 28);
            // 
            // 
            // 
            this.skinTextBoxID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxID.SkinTxt.Name = "BaseText";
            this.skinTextBoxID.SkinTxt.Size = new System.Drawing.Size(85, 18);
            this.skinTextBoxID.SkinTxt.TabIndex = 0;
            this.skinTextBoxID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.SkinTxt.WaterText = "";
            this.skinTextBoxID.TabIndex = 0;
            this.skinTextBoxID.TabStop = true;
            this.skinTextBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxID.WaterText = "";
            this.skinTextBoxID.WordWrap = true;
            // 
            // EmCostumeManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.Name = "EmCostumeManageCtrl";
            this.Load += new System.EventHandler(this.EmCostumeManageCtrl_Load);
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.Panel skinPanel2;
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxIsOnlyShowRecommand;
        private Common.Components.BaseButton BaseButton3;
        private Manage.EmCostumeTextBox skinTextBoxID;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxShowImage;
        private System.Windows.Forms.Panel skinPanel3;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonOffline;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonOnline;
        private CostumeClassSelector skinComboBoxBigClass;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private Common.Components.BaseButton baseButtonImport;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxHot;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxNew;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinComboBox skinComboType;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmOnlinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PfOnlinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOfSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmTitle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EmShowOnline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PfShowOnline;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNew;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsHot;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column5;
    }
}
