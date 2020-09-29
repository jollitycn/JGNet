using System;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Manage.Components;

namespace JGNet.Manage

{
    partial class SaveCarriageCostTemplateCtrl
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
            this.skinTextBoxTitle = new JGNet.Common.TextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBox_State = new CCWin.SkinControl.SkinCheckBox();
            this.skinComboBoxCityArea = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxCity = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxDeliveryTime = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxProvince = new CCWin.SkinControl.SkinComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numericTextBoxDefaultCarriageCost = new JGNet.Common.NumericTextBox();
            this.baseButtonAdd = new JGNet.Common.Components.BaseButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.areaStrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinTextBoxTitle
            // 
            this.skinTextBoxTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBoxTitle.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxTitle.DownBack = null;
            this.skinTextBoxTitle.Icon = null;
            this.skinTextBoxTitle.IconIsButton = false;
            this.skinTextBoxTitle.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxTitle.IsPasswordChat = '\0';
            this.skinTextBoxTitle.IsSystemPasswordChar = false;
            this.skinTextBoxTitle.Lines = new string[0];
            this.skinTextBoxTitle.Location = new System.Drawing.Point(76, 15);
            this.skinTextBoxTitle.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxTitle.MaxLength = 32767;
            this.skinTextBoxTitle.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxTitle.MouseBack = null;
            this.skinTextBoxTitle.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxTitle.Multiline = false;
            this.skinTextBoxTitle.Name = "skinTextBoxTitle";
            this.skinTextBoxTitle.NormlBack = null;
            this.skinTextBoxTitle.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxTitle.ReadOnly = false;
            this.skinTextBoxTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxTitle.Size = new System.Drawing.Size(875, 28);
            // 
            // 
            // 
            this.skinTextBoxTitle.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxTitle.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxTitle.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxTitle.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxTitle.SkinTxt.Name = "BaseText";
            this.skinTextBoxTitle.SkinTxt.Size = new System.Drawing.Size(865, 18);
            this.skinTextBoxTitle.SkinTxt.TabIndex = 0;
            this.skinTextBoxTitle.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxTitle.SkinTxt.WaterText = "";
            this.skinTextBoxTitle.TabIndex = 1;
            this.skinTextBoxTitle.TabStop = true;
            this.skinTextBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxTitle.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxTitle.WaterText = "";
            this.skinTextBoxTitle.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(13, 52);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(56, 17);
            this.skinLabel7.TabIndex = 158;
            this.skinLabel7.Text = "发货时间";
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(443, 487);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 6;
            this.BaseButton3.Text = "保存";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButtonSave_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(13, 21);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(56, 17);
            this.skinLabel6.TabIndex = 156;
            this.skinLabel6.Text = "模板名称";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.skinLabel8);
            this.panel1.Controls.Add(this.skinCheckBox_State);
            this.panel1.Controls.Add(this.skinComboBoxCityArea);
            this.panel1.Controls.Add(this.skinComboBoxCity);
            this.panel1.Controls.Add(this.skinComboBoxDeliveryTime);
            this.panel1.Controls.Add(this.skinComboBoxProvince);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.numericTextBoxDefaultCarriageCost);
            this.panel1.Controls.Add(this.skinLabel6);
            this.panel1.Controls.Add(this.baseButtonAdd);
            this.panel1.Controls.Add(this.BaseButton3);
            this.panel1.Controls.Add(this.skinLabel2);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Controls.Add(this.skinLabel3);
            this.panel1.Controls.Add(this.skinLabel5);
            this.panel1.Controls.Add(this.skinLabel7);
            this.panel1.Controls.Add(this.skinTextBoxTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 549);
            this.panel1.TabIndex = 1;
            // 
            // skinLabel8
            // 
            this.skinLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(41, 451);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 163;
            this.skinLabel8.Text = "状态";
            // 
            // skinCheckBox_State
            // 
            this.skinCheckBox_State.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBox_State.AutoSize = true;
            this.skinCheckBox_State.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox_State.Checked = true;
            this.skinCheckBox_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox_State.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox_State.DownBack = null;
            this.skinCheckBox_State.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox_State.Location = new System.Drawing.Point(76, 449);
            this.skinCheckBox_State.MouseBack = null;
            this.skinCheckBox_State.Name = "skinCheckBox_State";
            this.skinCheckBox_State.NormlBack = null;
            this.skinCheckBox_State.SelectedDownBack = null;
            this.skinCheckBox_State.SelectedMouseBack = null;
            this.skinCheckBox_State.SelectedNormlBack = null;
            this.skinCheckBox_State.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBox_State.TabIndex = 162;
            this.skinCheckBox_State.Text = "启用";
            this.skinCheckBox_State.UseVisualStyleBackColor = false;
            // 
            // skinComboBoxCityArea
            // 
            this.skinComboBoxCityArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBoxCityArea.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxCityArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxCityArea.FormattingEnabled = true;
            this.skinComboBoxCityArea.Location = new System.Drawing.Point(330, 72);
            this.skinComboBoxCityArea.Name = "skinComboBoxCityArea";
            this.skinComboBoxCityArea.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxCityArea.TabIndex = 161;
            this.skinComboBoxCityArea.WaterText = "";
            // 
            // skinComboBoxCity
            // 
            this.skinComboBoxCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBoxCity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxCity.FormattingEnabled = true;
            this.skinComboBoxCity.Location = new System.Drawing.Point(203, 72);
            this.skinComboBoxCity.Name = "skinComboBoxCity";
            this.skinComboBoxCity.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxCity.TabIndex = 161;
            this.skinComboBoxCity.WaterText = "";
            this.skinComboBoxCity.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxCity_SelectedIndexChanged);
            // 
            // skinComboBoxDeliveryTime
            // 
            this.skinComboBoxDeliveryTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBoxDeliveryTime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxDeliveryTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxDeliveryTime.FormattingEnabled = true;
            this.skinComboBoxDeliveryTime.Location = new System.Drawing.Point(76, 47);
            this.skinComboBoxDeliveryTime.Name = "skinComboBoxDeliveryTime";
            this.skinComboBoxDeliveryTime.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxDeliveryTime.TabIndex = 161;
            this.skinComboBoxDeliveryTime.WaterText = "";
            // 
            // skinComboBoxProvince
            // 
            this.skinComboBoxProvince.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBoxProvince.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxProvince.FormattingEnabled = true;
            this.skinComboBoxProvince.Location = new System.Drawing.Point(76, 72);
            this.skinComboBoxProvince.Name = "skinComboBoxProvince";
            this.skinComboBoxProvince.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxProvince.TabIndex = 161;
            this.skinComboBoxProvince.WaterText = "";
            this.skinComboBoxProvince.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxProvince_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.areaStrDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(76, 174);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(875, 269);
            this.dataGridView1.TabIndex = 160;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(JGNet.Common.Models.CarriageCost);
            // 
            // numericTextBoxDefaultCarriageCost
            // 
            this.numericTextBoxDefaultCarriageCost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericTextBoxDefaultCarriageCost.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBoxDefaultCarriageCost.DecimalPlaces = 0;
            this.numericTextBoxDefaultCarriageCost.DownBack = null;
            this.numericTextBoxDefaultCarriageCost.Icon = null;
            this.numericTextBoxDefaultCarriageCost.IconIsButton = false;
            this.numericTextBoxDefaultCarriageCost.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxDefaultCarriageCost.IsPasswordChat = '\0';
            this.numericTextBoxDefaultCarriageCost.IsSystemPasswordChar = false;
            this.numericTextBoxDefaultCarriageCost.Lines = new string[0];
            this.numericTextBoxDefaultCarriageCost.Location = new System.Drawing.Point(76, 99);
            this.numericTextBoxDefaultCarriageCost.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBoxDefaultCarriageCost.MaxLength = 32767;
            this.numericTextBoxDefaultCarriageCost.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBoxDefaultCarriageCost.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBoxDefaultCarriageCost.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxDefaultCarriageCost.MouseBack = null;
            this.numericTextBoxDefaultCarriageCost.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxDefaultCarriageCost.Multiline = false;
            this.numericTextBoxDefaultCarriageCost.Name = "numericTextBoxDefaultCarriageCost";
            this.numericTextBoxDefaultCarriageCost.NormlBack = null;
            this.numericTextBoxDefaultCarriageCost.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBoxDefaultCarriageCost.ReadOnly = false;
            this.numericTextBoxDefaultCarriageCost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBoxDefaultCarriageCost.ShowZero = false;
            this.numericTextBoxDefaultCarriageCost.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.numericTextBoxDefaultCarriageCost.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTextBoxDefaultCarriageCost.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTextBoxDefaultCarriageCost.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTextBoxDefaultCarriageCost.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTextBoxDefaultCarriageCost.SkinTxt.Name = "BaseText";
            this.numericTextBoxDefaultCarriageCost.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.numericTextBoxDefaultCarriageCost.SkinTxt.TabIndex = 0;
            this.numericTextBoxDefaultCarriageCost.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxDefaultCarriageCost.SkinTxt.WaterText = "";
            this.numericTextBoxDefaultCarriageCost.TabIndex = 159;
            this.numericTextBoxDefaultCarriageCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBoxDefaultCarriageCost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxDefaultCarriageCost.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxDefaultCarriageCost.WaterText = "";
            this.numericTextBoxDefaultCarriageCost.WordWrap = true;
            // 
            // baseButtonAdd
            // 
            this.baseButtonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baseButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonAdd.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonAdd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonAdd.Location = new System.Drawing.Point(76, 136);
            this.baseButtonAdd.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonAdd.Name = "baseButtonAdd";
            this.baseButtonAdd.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonAdd.Size = new System.Drawing.Size(185, 32);
            this.baseButtonAdd.TabIndex = 6;
            this.baseButtonAdd.Text = "添加指定地区运费";
            this.baseButtonAdd.UseVisualStyleBackColor = false;
            this.baseButtonAdd.Click += new System.EventHandler(this.baseButtonAdd_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(264, 105);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(116, 17);
            this.skinLabel2.TabIndex = 132;
            this.skinLabel2.Text = "元（除指定地区外）";
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(13, 105);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 132;
            this.skinLabel1.Text = "默认运费";
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(12, 77);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 132;
            this.skinLabel3.Text = "宝贝地址";
            // 
            // skinLabel5
            // 
            this.skinLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(203, 50);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 158;
            this.skinLabel5.Text = "小时";
            // 
            // areaStrDataGridViewTextBoxColumn
            // 
            this.areaStrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.areaStrDataGridViewTextBoxColumn.DataPropertyName = "AreaStr";
            this.areaStrDataGridViewTextBoxColumn.HeaderText = "配送区域";
            this.areaStrDataGridViewTextBoxColumn.Name = "areaStrDataGridViewTextBoxColumn";
            this.areaStrDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaStrDataGridViewTextBoxColumn.Width = 400;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "运费";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 360;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "编辑";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "编辑";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Text = "删除";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // SaveCarriageCostTemplateCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "SaveCarriageCostTemplateCtrl";
            this.Size = new System.Drawing.Size(960, 549);
            this.Load += new System.EventHandler(this.SaveCarriageCostTemplateCtrl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox skinTextBoxTitle;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private BaseButton BaseButton3;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private NumericTextBox numericTextBoxDefaultCarriageCost;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private BaseButton baseButtonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinComboBox skinComboBoxCityArea;
        private CCWin.SkinControl.SkinComboBox skinComboBoxCity;
        private CCWin.SkinControl.SkinComboBox skinComboBoxProvince;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CCWin.SkinControl.SkinComboBox skinComboBoxDeliveryTime;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox_State;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaStrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}
