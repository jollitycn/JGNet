using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Manage.Components;

namespace JGNet.Manage

{
    partial class SaveCostumeManageCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveCostumeManageCtrl));
            this.numericUpDown_Price = new JGNet.Common.NumericTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_ID = new JGNet.Common.TextBox();
            this.skinTextBox_Name = new JGNet.Common.TextBox();
            this.skinTextBox_Remarks = new JGNet.Common.TextBox();
            this.skinComboBox_SupplierID = new JGNet.Common.Components.SupllierComboBox();
            this.skinComboBox_Year = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel16 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.numericUpDownCostPrice = new JGNet.Common.NumericTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBoxAutoCostPrice = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.numericTextBoxSalePrice = new JGNet.Common.NumericTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxBigClass = new JGNet.Common.CostumeClassSelector();
            this.baseButtonSelectSizeGroup = new JGNet.Common.Components.BaseButton();
            this.colorComboBox1 = new JGNet.Manage.ColorComboBox();
            this.skinComboBox_Season = new JGNet.Manage.Components.SeasonComboBox();
            this.skinComboBox_Brand = new JGNet.Manage.BrandComboBox();
            this.skinLabelSizeGroup = new CCWin.SkinControl.SkinLabel();
            this.skinCmbProperty = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinProgressBar1 = new CCWin.SkinControl.SkinProgressBar();
            this.skinLabelProgress = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.titleImageControlWidth1 = new JGNet.Common.Components.TitleImageControlWidth();
            this.skinLabel17 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_Price
            // 
            this.numericUpDown_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown_Price.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDown_Price.DecimalPlaces = 0;
            this.numericUpDown_Price.DownBack = null;
            this.numericUpDown_Price.Icon = null;
            this.numericUpDown_Price.IconIsButton = false;
            this.numericUpDown_Price.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDown_Price.IsPasswordChat = '\0';
            this.numericUpDown_Price.IsSystemPasswordChar = false;
            this.numericUpDown_Price.Lines = new string[0];
            this.numericUpDown_Price.Location = new System.Drawing.Point(153, 151);
            this.numericUpDown_Price.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown_Price.MaxLength = 32767;
            this.numericUpDown_Price.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDown_Price.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericUpDown_Price.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown_Price.MouseBack = null;
            this.numericUpDown_Price.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDown_Price.Multiline = false;
            this.numericUpDown_Price.Name = "numericUpDown_Price";
            this.numericUpDown_Price.NormlBack = null;
            this.numericUpDown_Price.Padding = new System.Windows.Forms.Padding(5);
            this.numericUpDown_Price.ReadOnly = false;
            this.numericUpDown_Price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericUpDown_Price.ShowZero = false;
            this.numericUpDown_Price.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.numericUpDown_Price.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericUpDown_Price.SkinTxt.Name = "BaseText";
            this.numericUpDown_Price.SkinTxt.TabIndex = 0;
            this.numericUpDown_Price.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDown_Price.SkinTxt.WaterText = "";
            this.numericUpDown_Price.TabIndex = 10;
            this.numericUpDown_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericUpDown_Price.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown_Price.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDown_Price.WaterText = "";
            this.numericUpDown_Price.WordWrap = true;
            this.numericUpDown_Price.ValueChanged += new System.Action<object>(this.numericUpDown_Price_ValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column13});
            this.dataGridView.Location = new System.Drawing.Point(152, 255);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(430, 191);
            this.dataGridView.TabIndex = 14;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Key";
            this.Column11.HeaderText = "颜色";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column13.HeaderText = "";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Text = "删除";
            this.Column13.UseColumnTextForLinkValue = true;
            this.Column13.Width = 5;
            // 
            // skinLabel11
            // 
            this.skinLabel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(380, 55);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(32, 17);
            this.skinLabel11.TabIndex = 141;
            this.skinLabel11.Text = "季节";
            // 
            // skinLabel10
            // 
            this.skinLabel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(116, 91);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(32, 17);
            this.skinLabel10.TabIndex = 138;
            this.skinLabel10.Text = "类别";
            // 
            // skinLabel12
            // 
            this.skinLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(380, 25);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(32, 17);
            this.skinLabel12.TabIndex = 133;
            this.skinLabel12.Text = "年份";
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(116, 24);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 132;
            this.skinLabel1.Text = "款号";
            // 
            // skinTextBox_ID
            // 
            this.skinTextBox_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinTextBox_ID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_ID.DownBack = null;
            this.skinTextBox_ID.Icon = null;
            this.skinTextBox_ID.IconIsButton = false;
            this.skinTextBox_ID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_ID.IsPasswordChat = '\0';
            this.skinTextBox_ID.IsSystemPasswordChar = false;
            this.skinTextBox_ID.Lines = new string[0];
            this.skinTextBox_ID.Location = new System.Drawing.Point(151, 18);
            this.skinTextBox_ID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_ID.MaxLength = 32767;
            this.skinTextBox_ID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_ID.MouseBack = null;
            this.skinTextBox_ID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_ID.Multiline = false;
            this.skinTextBox_ID.Name = "skinTextBox_ID";
            this.skinTextBox_ID.NormlBack = null;
            this.skinTextBox_ID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_ID.ReadOnly = false;
            this.skinTextBox_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_ID.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.skinTextBox_ID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_ID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_ID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_ID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_ID.SkinTxt.Name = "BaseText";
            this.skinTextBox_ID.SkinTxt.Size = new System.Drawing.Size(154, 18);
            this.skinTextBox_ID.SkinTxt.TabIndex = 0;
            this.skinTextBox_ID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_ID.SkinTxt.WaterText = "";
            this.skinTextBox_ID.TabIndex = 0;
            this.skinTextBox_ID.TabStop = true;
            this.skinTextBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_ID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_ID.WaterText = "";
            this.skinTextBox_ID.WordWrap = true;
            // 
            // skinTextBox_Name
            // 
            this.skinTextBox_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinTextBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Name.DownBack = null;
            this.skinTextBox_Name.Icon = null;
            this.skinTextBox_Name.IconIsButton = false;
            this.skinTextBox_Name.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Name.IsPasswordChat = '\0';
            this.skinTextBox_Name.IsSystemPasswordChar = false;
            this.skinTextBox_Name.Lines = new string[0];
            this.skinTextBox_Name.Location = new System.Drawing.Point(151, 50);
            this.skinTextBox_Name.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Name.MaxLength = 32767;
            this.skinTextBox_Name.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Name.MouseBack = null;
            this.skinTextBox_Name.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Name.Multiline = false;
            this.skinTextBox_Name.Name = "skinTextBox_Name";
            this.skinTextBox_Name.NormlBack = null;
            this.skinTextBox_Name.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Name.ReadOnly = false;
            this.skinTextBox_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Name.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.skinTextBox_Name.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Name.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Name.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Name.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Name.SkinTxt.Name = "BaseText";
            this.skinTextBox_Name.SkinTxt.Size = new System.Drawing.Size(154, 18);
            this.skinTextBox_Name.SkinTxt.TabIndex = 0;
            this.skinTextBox_Name.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Name.SkinTxt.WaterText = "";
            this.skinTextBox_Name.TabIndex = 2;
            this.skinTextBox_Name.TabStop = true;
            this.skinTextBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Name.WaterText = "";
            this.skinTextBox_Name.WordWrap = true;
            // 
            // skinTextBox_Remarks
            // 
            this.skinTextBox_Remarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinTextBox_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Remarks.DownBack = null;
            this.skinTextBox_Remarks.Icon = null;
            this.skinTextBox_Remarks.IconIsButton = false;
            this.skinTextBox_Remarks.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.IsPasswordChat = '\0';
            this.skinTextBox_Remarks.IsSystemPasswordChar = false;
            this.skinTextBox_Remarks.Lines = new string[0];
            this.skinTextBox_Remarks.Location = new System.Drawing.Point(152, 467);
            this.skinTextBox_Remarks.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Remarks.MaxLength = 32767;
            this.skinTextBox_Remarks.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Remarks.MouseBack = null;
            this.skinTextBox_Remarks.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.Multiline = false;
            this.skinTextBox_Remarks.Name = "skinTextBox_Remarks";
            this.skinTextBox_Remarks.NormlBack = null;
            this.skinTextBox_Remarks.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Remarks.ReadOnly = false;
            this.skinTextBox_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Remarks.Size = new System.Drawing.Size(430, 28);
            // 
            // 
            // 
            this.skinTextBox_Remarks.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Remarks.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Remarks.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Remarks.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Remarks.SkinTxt.Name = "BaseText";
            this.skinTextBox_Remarks.SkinTxt.Size = new System.Drawing.Size(420, 18);
            this.skinTextBox_Remarks.SkinTxt.TabIndex = 0;
            this.skinTextBox_Remarks.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.SkinTxt.WaterText = "";
            this.skinTextBox_Remarks.TabIndex = 12;
            this.skinTextBox_Remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Remarks.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.WaterText = "";
            this.skinTextBox_Remarks.WordWrap = true;
            // 
            // skinComboBox_SupplierID
            // 
            this.skinComboBox_SupplierID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinComboBox_SupplierID.AutoSize = true;
            this.skinComboBox_SupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_SupplierID.EnabledSupplier = false;
            this.skinComboBox_SupplierID.HideAll = true;
            this.skinComboBox_SupplierID.Location = new System.Drawing.Point(153, 119);
            this.skinComboBox_SupplierID.Name = "skinComboBox_SupplierID";
            this.skinComboBox_SupplierID.SelectedItem = null;
            this.skinComboBox_SupplierID.SelectedValue = null;
            this.skinComboBox_SupplierID.ShowAdd = true;
            this.skinComboBox_SupplierID.Size = new System.Drawing.Size(175, 26);
            this.skinComboBox_SupplierID.TabIndex = 8;
            this.skinComboBox_SupplierID.Title = null;
            // 
            // skinComboBox_Year
            // 
            this.skinComboBox_Year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinComboBox_Year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Year.FormattingEnabled = true;
            this.skinComboBox_Year.Location = new System.Drawing.Point(418, 22);
            this.skinComboBox_Year.Name = "skinComboBox_Year";
            this.skinComboBox_Year.Size = new System.Drawing.Size(164, 22);
            this.skinComboBox_Year.TabIndex = 1;
            this.skinComboBox_Year.WaterText = "";
            // 
            // skinLabel8
            // 
            this.skinLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(115, 220);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 112;
            this.skinLabel8.Text = "颜色";
            // 
            // skinLabel16
            // 
            this.skinLabel16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel16.AutoSize = true;
            this.skinLabel16.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel16.BorderColor = System.Drawing.Color.White;
            this.skinLabel16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel16.Location = new System.Drawing.Point(116, 471);
            this.skinLabel16.Name = "skinLabel16";
            this.skinLabel16.Size = new System.Drawing.Size(32, 17);
            this.skinLabel16.TabIndex = 112;
            this.skinLabel16.Text = "备注";
            // 
            // skinLabel6
            // 
            this.skinLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(105, 122);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(44, 17);
            this.skinLabel6.TabIndex = 98;
            this.skinLabel6.Text = "供应商";
            // 
            // skinLabel7
            // 
            this.skinLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(380, 88);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 98;
            this.skinLabel7.Text = "品牌";
            // 
            // skinLabel13
            // 
            this.skinLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel13.Location = new System.Drawing.Point(105, 157);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(44, 17);
            this.skinLabel13.TabIndex = 97;
            this.skinLabel13.Text = "吊牌价";
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(116, 56);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 97;
            this.skinLabel2.Text = "名称";
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(562, 526);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 17;
            this.BaseButton3.Text = "保存";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButtonSave_Click);
            // 
            // numericUpDownCostPrice
            // 
            this.numericUpDownCostPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownCostPrice.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownCostPrice.DecimalPlaces = 1;
            this.numericUpDownCostPrice.DownBack = null;
            this.numericUpDownCostPrice.Icon = null;
            this.numericUpDownCostPrice.IconIsButton = false;
            this.numericUpDownCostPrice.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownCostPrice.IsPasswordChat = '\0';
            this.numericUpDownCostPrice.IsSystemPasswordChar = false;
            this.numericUpDownCostPrice.Lines = new string[0];
            this.numericUpDownCostPrice.Location = new System.Drawing.Point(418, 117);
            this.numericUpDownCostPrice.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownCostPrice.MaxLength = 32767;
            this.numericUpDownCostPrice.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDownCostPrice.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericUpDownCostPrice.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownCostPrice.MouseBack = null;
            this.numericUpDownCostPrice.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownCostPrice.Multiline = false;
            this.numericUpDownCostPrice.Name = "numericUpDownCostPrice";
            this.numericUpDownCostPrice.NormlBack = null;
            this.numericUpDownCostPrice.Padding = new System.Windows.Forms.Padding(5);
            this.numericUpDownCostPrice.ReadOnly = false;
            this.numericUpDownCostPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericUpDownCostPrice.ShowZero = false;
            this.numericUpDownCostPrice.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.numericUpDownCostPrice.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownCostPrice.SkinTxt.Name = "BaseText";
            this.numericUpDownCostPrice.SkinTxt.TabIndex = 0;
            this.numericUpDownCostPrice.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownCostPrice.SkinTxt.WaterText = "";
            this.numericUpDownCostPrice.TabIndex = 11;
            this.numericUpDownCostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericUpDownCostPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownCostPrice.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownCostPrice.WaterText = "";
            this.numericUpDownCostPrice.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(369, 123);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(44, 17);
            this.skinLabel4.TabIndex = 143;
            this.skinLabel4.Text = "进货价";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // skinLabel14
            // 
            this.skinLabel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel14.Location = new System.Drawing.Point(365, 225);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(44, 17);
            this.skinLabel14.TabIndex = 98;
            this.skinLabel14.Text = "尺码组";
            // 
            // skinCheckBoxAutoCostPrice
            // 
            this.skinCheckBoxAutoCostPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinCheckBoxAutoCostPrice.AutoSize = true;
            this.skinCheckBoxAutoCostPrice.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxAutoCostPrice.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxAutoCostPrice.DownBack = null;
            this.skinCheckBoxAutoCostPrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxAutoCostPrice.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.skinCheckBoxAutoCostPrice.Location = new System.Drawing.Point(586, 124);
            this.skinCheckBoxAutoCostPrice.MouseBack = null;
            this.skinCheckBoxAutoCostPrice.Name = "skinCheckBoxAutoCostPrice";
            this.skinCheckBoxAutoCostPrice.NormlBack = null;
            this.skinCheckBoxAutoCostPrice.SelectedDownBack = null;
            this.skinCheckBoxAutoCostPrice.SelectedMouseBack = null;
            this.skinCheckBoxAutoCostPrice.SelectedNormlBack = null;
            this.skinCheckBoxAutoCostPrice.Size = new System.Drawing.Size(15, 14);
            this.skinCheckBoxAutoCostPrice.TabIndex = 196;
            this.skinCheckBoxAutoCostPrice.UseVisualStyleBackColor = false;
            this.skinCheckBoxAutoCostPrice.CheckedChanged += new System.EventHandler(this.skinCheckBoxAutoCostPrice_CheckedChanged);
            // 
            // skinLabel15
            // 
            this.skinLabel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.skinLabel15.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.skinLabel15.Location = new System.Drawing.Point(606, 123);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(32, 17);
            this.skinLabel15.TabIndex = 197;
            this.skinLabel15.Text = "折扣";
            this.skinLabel15.Click += new System.EventHandler(this.skinLabelDiscount_Click);
            // 
            // numericTextBoxSalePrice
            // 
            this.numericTextBoxSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericTextBoxSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBoxSalePrice.DecimalPlaces = 0;
            this.numericTextBoxSalePrice.DownBack = null;
            this.numericTextBoxSalePrice.Icon = null;
            this.numericTextBoxSalePrice.IconIsButton = false;
            this.numericTextBoxSalePrice.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxSalePrice.IsPasswordChat = '\0';
            this.numericTextBoxSalePrice.IsSystemPasswordChar = false;
            this.numericTextBoxSalePrice.Lines = new string[0];
            this.numericTextBoxSalePrice.Location = new System.Drawing.Point(417, 151);
            this.numericTextBoxSalePrice.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBoxSalePrice.MaxLength = 32767;
            this.numericTextBoxSalePrice.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBoxSalePrice.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBoxSalePrice.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxSalePrice.MouseBack = null;
            this.numericTextBoxSalePrice.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxSalePrice.Multiline = false;
            this.numericTextBoxSalePrice.Name = "numericTextBoxSalePrice";
            this.numericTextBoxSalePrice.NormlBack = null;
            this.numericTextBoxSalePrice.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBoxSalePrice.ReadOnly = false;
            this.numericTextBoxSalePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBoxSalePrice.ShowZero = false;
            this.numericTextBoxSalePrice.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.numericTextBoxSalePrice.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericTextBoxSalePrice.SkinTxt.Name = "BaseText";
            this.numericTextBoxSalePrice.SkinTxt.TabIndex = 0;
            this.numericTextBoxSalePrice.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxSalePrice.SkinTxt.WaterText = "";
            this.numericTextBoxSalePrice.TabIndex = 198;
            this.numericTextBoxSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBoxSalePrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxSalePrice.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxSalePrice.WaterText = "";
            this.numericTextBoxSalePrice.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(380, 157);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 199;
            this.skinLabel3.Text = "售价";
            // 
            // skinComboBoxBigClass
            // 
            this.skinComboBoxBigClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinComboBoxBigClass.AutoSize = true;
            this.skinComboBoxBigClass.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxBigClass.Location = new System.Drawing.Point(152, 85);
            this.skinComboBoxBigClass.Name = "skinComboBoxBigClass";
            this.skinComboBoxBigClass.SelectedValue = ((JGNet.Costume)(resources.GetObject("skinComboBoxBigClass.SelectedValue")));
            this.skinComboBoxBigClass.Size = new System.Drawing.Size(153, 29);
            this.skinComboBoxBigClass.TabIndex = 202;
            // 
            // baseButtonSelectSizeGroup
            // 
            this.baseButtonSelectSizeGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseButtonSelectSizeGroup.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSelectSizeGroup.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSelectSizeGroup.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonSelectSizeGroup.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSelectSizeGroup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSelectSizeGroup.Location = new System.Drawing.Point(415, 220);
            this.baseButtonSelectSizeGroup.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonSelectSizeGroup.Name = "baseButtonSelectSizeGroup";
            this.baseButtonSelectSizeGroup.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonSelectSizeGroup.Size = new System.Drawing.Size(75, 32);
            this.baseButtonSelectSizeGroup.TabIndex = 203;
            this.baseButtonSelectSizeGroup.Text = "选择";
            this.baseButtonSelectSizeGroup.UseVisualStyleBackColor = false;
            this.baseButtonSelectSizeGroup.Click += new System.EventHandler(this.baseButton4_Click);
            // 
            // colorComboBox1
            // 
            this.colorComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorComboBox1.HideAll = true;
            this.colorComboBox1.HideEmpty = false;
            this.colorComboBox1.Location = new System.Drawing.Point(149, 215);
            this.colorComboBox1.Name = "colorComboBox1";
            this.colorComboBox1.SelectedItem = null;
            this.colorComboBox1.SelectedText = "";
            this.colorComboBox1.SelectedValue = null;
            this.colorComboBox1.ShowAdd = true;
            this.colorComboBox1.Size = new System.Drawing.Size(192, 27);
            this.colorComboBox1.TabIndex = 153;
            // 
            // skinComboBox_Season
            // 
            this.skinComboBox_Season.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinComboBox_Season.Location = new System.Drawing.Point(415, 49);
            this.skinComboBox_Season.Name = "skinComboBox_Season";
            this.skinComboBox_Season.SelectedValue = null;
            this.skinComboBox_Season.ShowAdd = true;
            this.skinComboBox_Season.ShowAll = false;
            this.skinComboBox_Season.Size = new System.Drawing.Size(192, 27);
            this.skinComboBox_Season.TabIndex = 3;
            // 
            // skinComboBox_Brand
            // 
            this.skinComboBox_Brand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinComboBox_Brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.skinComboBox_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.skinComboBox_Brand.Location = new System.Drawing.Point(415, 83);
            this.skinComboBox_Brand.Name = "skinComboBox_Brand";
            this.skinComboBox_Brand.SelectedIndexChanged = null;
            this.skinComboBox_Brand.SelectedItem = null;
            this.skinComboBox_Brand.SelectedValue = null;
            this.skinComboBox_Brand.ShowAdd = true;
            this.skinComboBox_Brand.ShowAll = false;
            this.skinComboBox_Brand.Size = new System.Drawing.Size(191, 26);
            this.skinComboBox_Brand.TabIndex = 9;
            // 
            // skinLabelSizeGroup
            // 
            this.skinLabelSizeGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabelSizeGroup.AutoSize = true;
            this.skinLabelSizeGroup.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelSizeGroup.BorderColor = System.Drawing.Color.White;
            this.skinLabelSizeGroup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelSizeGroup.Location = new System.Drawing.Point(499, 228);
            this.skinLabelSizeGroup.Name = "skinLabelSizeGroup";
            this.skinLabelSizeGroup.Size = new System.Drawing.Size(92, 17);
            this.skinLabelSizeGroup.TabIndex = 98;
            this.skinLabelSizeGroup.Text = "不选默认为均码";
            // 
            // skinCmbProperty
            // 
            this.skinCmbProperty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinCmbProperty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinCmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinCmbProperty.FormattingEnabled = true;
            this.skinCmbProperty.Location = new System.Drawing.Point(151, 187);
            this.skinCmbProperty.Name = "skinCmbProperty";
            this.skinCmbProperty.Size = new System.Drawing.Size(164, 22);
            this.skinCmbProperty.TabIndex = 204;
            this.skinCmbProperty.WaterText = "";
            // 
            // skinLabel5
            // 
            this.skinLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(113, 190);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 205;
            this.skinLabel5.Text = "属性";
            // 
            // skinProgressBar1
            // 
            this.skinProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinProgressBar1.Back = null;
            this.skinProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.BarBack = null;
            this.skinProgressBar1.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.ForeColor = System.Drawing.Color.Red;
            this.skinProgressBar1.Location = new System.Drawing.Point(917, 490);
            this.skinProgressBar1.Name = "skinProgressBar1";
            this.skinProgressBar1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.Size = new System.Drawing.Size(154, 23);
            this.skinProgressBar1.TabIndex = 212;
            this.skinProgressBar1.Visible = false;
            // 
            // skinLabelProgress
            // 
            this.skinLabelProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabelProgress.AutoSize = true;
            this.skinLabelProgress.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelProgress.BorderColor = System.Drawing.Color.White;
            this.skinLabelProgress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelProgress.Location = new System.Drawing.Point(855, 493);
            this.skinLabelProgress.Name = "skinLabelProgress";
            this.skinLabelProgress.Size = new System.Drawing.Size(56, 17);
            this.skinLabelProgress.TabIndex = 211;
            this.skinLabelProgress.Text = "上传中：";
            this.skinLabelProgress.Visible = false;
            // 
            // skinLabel9
            // 
            this.skinLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(672, 29);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(56, 17);
            this.skinLabel9.TabIndex = 210;
            this.skinLabel9.Text = "商品图片";
            // 
            // titleImageControlWidth1
            // 
            this.titleImageControlWidth1.AllowDrop = true;
            this.titleImageControlWidth1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleImageControlWidth1.AutoSize = true;
            this.titleImageControlWidth1.BackColor = System.Drawing.Color.Transparent;
            this.titleImageControlWidth1.Location = new System.Drawing.Point(675, 56);
            this.titleImageControlWidth1.MinimumSize = new System.Drawing.Size(80, 64);
            this.titleImageControlWidth1.Name = "titleImageControlWidth1";
            this.titleImageControlWidth1.Size = new System.Drawing.Size(487, 358);
            this.titleImageControlWidth1.TabIndex = 209;
            this.titleImageControlWidth1.TitleImageMoveDown = null;
            this.titleImageControlWidth1.TitleImageMoveUp = null;
            // 
            // skinLabel17
            // 
            this.skinLabel17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel17.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel17.BorderColor = System.Drawing.Color.White;
            this.skinLabel17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel17.ForeColor = System.Drawing.SystemColors.GrayText;
            this.skinLabel17.Location = new System.Drawing.Point(679, 417);
            this.skinLabel17.Name = "skinLabel17";
            this.skinLabel17.Size = new System.Drawing.Size(441, 25);
            this.skinLabel17.TabIndex = 213;
            this.skinLabel17.Text = "建议尺寸：800 X 800，所有图片最多上传10张，选择图片前移后移进行排列，";
            // 
            // skinLabel18
            // 
            this.skinLabel18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel18.ForeColor = System.Drawing.SystemColors.GrayText;
            this.skinLabel18.Location = new System.Drawing.Point(679, 433);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(455, 25);
            this.skinLabel18.TabIndex = 214;
            this.skinLabel18.Text = "鼠标右键选择删除图片,第一张为首页显示图";
            // 
            // SaveCostumeManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.Controls.Add(this.skinLabel18);
            this.Controls.Add(this.skinLabel17);
            this.Controls.Add(this.skinProgressBar1);
            this.Controls.Add(this.skinLabelProgress);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.titleImageControlWidth1);
            this.Controls.Add(this.skinCmbProperty);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.baseButtonSelectSizeGroup);
            this.Controls.Add(this.skinComboBoxBigClass);
            this.Controls.Add(this.numericTextBoxSalePrice);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel15);
            this.Controls.Add(this.skinCheckBoxAutoCostPrice);
            this.Controls.Add(this.colorComboBox1);
            this.Controls.Add(this.numericUpDown_Price);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel11);
            this.Controls.Add(this.skinLabelSizeGroup);
            this.Controls.Add(this.skinLabel14);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel13);
            this.Controls.Add(this.skinLabel16);
            this.Controls.Add(this.BaseButton3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.numericUpDownCostPrice);
            this.Controls.Add(this.skinLabel10);
            this.Controls.Add(this.skinComboBox_Year);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinComboBox_Season);
            this.Controls.Add(this.skinComboBox_Brand);
            this.Controls.Add(this.skinLabel12);
            this.Controls.Add(this.skinComboBox_SupplierID);
            this.Controls.Add(this.skinTextBox_Remarks);
            this.Controls.Add(this.skinTextBox_ID);
            this.Controls.Add(this.skinTextBox_Name);
            this.Name = "SaveCostumeManageCtrl";
            this.Size = new System.Drawing.Size(1160, 573);
            this.Load += new System.EventHandler(this.SaveCostumeManageCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion  
        private CCWin.SkinControl.SkinComboBox skinComboBox_Year;
        private CCWin.SkinControl.SkinLabel skinLabel16;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private  JGNet.Common.TextBox skinTextBox_Name;
        private  JGNet.Common.TextBox skinTextBox_ID;
        private  JGNet.Common.TextBox skinTextBox_Remarks;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private JGNet.Manage.BrandComboBox skinComboBox_Brand;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private SupllierComboBox skinComboBox_SupplierID;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private System.Windows.Forms.DataGridView dataGridView;
        private JGNet.Common.NumericTextBox numericUpDown_Price;
        private SeasonComboBox skinComboBox_Season;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private JGNet.Common.NumericTextBox numericUpDownCostPrice;
        private Common.Components.BaseButton BaseButton3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private ColorComboBox colorComboBox1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxAutoCostPrice;
        private CCWin.SkinControl.SkinLabel skinLabel15;
        private NumericTextBox numericTextBoxSalePrice;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CostumeClassSelector skinComboBoxBigClass;
        private BaseButton baseButtonSelectSizeGroup;
        private CCWin.SkinControl.SkinLabel skinLabelSizeGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewLinkColumn Column13;
        private CCWin.SkinControl.SkinComboBox skinCmbProperty;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinProgressBar skinProgressBar1;
        private CCWin.SkinControl.SkinLabel skinLabelProgress;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private TitleImageControlWidth titleImageControlWidth1;
        private CCWin.SkinControl.SkinLabel skinLabel17;
        private CCWin.SkinControl.SkinLabel skinLabel18;
    }
}
