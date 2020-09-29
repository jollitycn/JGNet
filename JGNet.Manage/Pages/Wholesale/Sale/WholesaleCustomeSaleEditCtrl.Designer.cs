﻿using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class WholesaleCustomeSaleEditCtrl
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
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.retailDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new CCWin.SkinControl.SkinPanel();
            this.skinLabelOrderID = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton_AddCostume = new JGNet.Common.Components.BaseButton();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.customerComboBox = new JGNet.Common.PfCustomerComboBox();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.skinTextBox_bugCount = new JGNet.Common.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.CostumeCurrentShopTextBox1 = new JGNet.Common.PfCostumeCurrentShopTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Size = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBox_Color = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.costumeStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.dataGridView1);
            this.skinPanel1.Controls.Add(this.panel1);
            this.skinPanel1.Controls.Add(this.skinPanel2);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(836, 508);
            this.skinPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.costumeNameDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.SizeDisplayName,
            this.BuyCount,
            this.Column1});
            this.dataGridView1.DataSource = this.retailDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(836, 396);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // retailDetailBindingSource
            // 
            this.retailDetailBindingSource.DataSource = typeof(JGNet.PfCustomerRetailDetail);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.skinLabelOrderID);
            this.panel1.Controls.Add(this.skinLabel6);
            this.panel1.Controls.Add(this.baseButton1);
            this.panel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.DownBack = null;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.MouseBack = null;
            this.panel1.Name = "panel1";
            this.panel1.NormlBack = null;
            this.panel1.Size = new System.Drawing.Size(836, 46);
            this.panel1.TabIndex = 6;
            // 
            // skinLabelOrderID
            // 
            this.skinLabelOrderID.AutoSize = true;
            this.skinLabelOrderID.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelOrderID.BorderColor = System.Drawing.Color.White;
            this.skinLabelOrderID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelOrderID.Location = new System.Drawing.Point(65, 15);
            this.skinLabelOrderID.Name = "skinLabelOrderID";
            this.skinLabelOrderID.Size = new System.Drawing.Size(56, 17);
            this.skinLabelOrderID.TabIndex = 186;
            this.skinLabelOrderID.Text = "销售单号";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(3, 15);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(56, 17);
            this.skinLabel6.TabIndex = 186;
            this.skinLabel6.Text = "销售单号";
            // 
            // baseButton1
            // 
            this.baseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(758, 7);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 6;
            this.baseButton1.Text = "保存";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton3_Click);
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.skinLabel8);
            this.skinPanel2.Controls.Add(this.BaseButton_AddCostume);
            this.skinPanel2.Controls.Add(this.skinLabel7);
            this.skinPanel2.Controls.Add(this.skinLabel4);
            this.skinPanel2.Controls.Add(this.skinLabel5);
            this.skinPanel2.Controls.Add(this.customerComboBox);
            this.skinPanel2.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel2.Controls.Add(this.skinTextBox_bugCount);
            this.skinPanel2.Controls.Add(this.skinLabel1);
            this.skinPanel2.Controls.Add(this.CostumeCurrentShopTextBox1);
            this.skinPanel2.Controls.Add(this.skinLabel2);
            this.skinPanel2.Controls.Add(this.skinComboBox_Size);
            this.skinPanel2.Controls.Add(this.skinComboBox_Color);
            this.skinPanel2.Controls.Add(this.skinLabel3);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(836, 66);
            this.skinPanel2.TabIndex = 0;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.Red;
            this.skinLabel8.Location = new System.Drawing.Point(647, 38);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(104, 17);
            this.skinLabel8.TabIndex = 186;
            this.skinLabel8.Text = "下表可以修改数量";
            // 
            // BaseButton_AddCostume
            // 
            this.BaseButton_AddCostume.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_AddCostume.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_AddCostume.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_AddCostume.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_AddCostume.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_AddCostume.Location = new System.Drawing.Point(566, 30);
            this.BaseButton_AddCostume.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_AddCostume.Name = "BaseButton_AddCostume";
            this.BaseButton_AddCostume.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_AddCostume.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_AddCostume.TabIndex = 4;
            this.BaseButton_AddCostume.Text = "添加";
            this.BaseButton_AddCostume.UseVisualStyleBackColor = false;
            this.BaseButton_AddCostume.Click += new System.EventHandler(this.BaseButton_AddCostume_Click);
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(18, 9);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 5;
            this.skinLabel7.Text = "客户";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(206, 9);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 185;
            this.skinLabel4.Text = "业务时间";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(433, 38);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "数量";
            // 
            // customerComboBox
            // 
            this.customerComboBox.CheckPfCustomer = false;
            this.customerComboBox.curSelectStr = null;
            this.customerComboBox.CustomerTypeValue = -1;
            this.customerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.HideEmpty = false;
            this.customerComboBox.Location = new System.Drawing.Point(53, 6);
            this.customerComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.customerComboBox.MinimumSize = new System.Drawing.Size(28, 0);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(140, 22);
            this.customerComboBox.TabIndex = 6;
            this.customerComboBox.WaterText = "请选择……";
            this.customerComboBox.ItemSelected += new System.Action<JGNet.PfCustomer>(this.memberIDTextBox2_ItemSelected);
            this.customerComboBox.Leave += new System.EventHandler(this.memberIDTextBox2_Leave);
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(268, 7);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(142, 21);
            this.dateTimePicker_Start.TabIndex = 184;
            // 
            // skinTextBox_bugCount
            // 
            this.skinTextBox_bugCount.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_bugCount.DownBack = null;
            this.skinTextBox_bugCount.Icon = null;
            this.skinTextBox_bugCount.IconIsButton = false;
            this.skinTextBox_bugCount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_bugCount.IsPasswordChat = '\0';
            this.skinTextBox_bugCount.IsSystemPasswordChar = false;
            this.skinTextBox_bugCount.Lines = new string[0];
            this.skinTextBox_bugCount.Location = new System.Drawing.Point(467, 32);
            this.skinTextBox_bugCount.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_bugCount.MaxLength = 32767;
            this.skinTextBox_bugCount.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_bugCount.MouseBack = null;
            this.skinTextBox_bugCount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_bugCount.Multiline = false;
            this.skinTextBox_bugCount.Name = "skinTextBox_bugCount";
            this.skinTextBox_bugCount.NormlBack = null;
            this.skinTextBox_bugCount.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_bugCount.ReadOnly = false;
            this.skinTextBox_bugCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_bugCount.Size = new System.Drawing.Size(74, 28);
            // 
            // 
            // 
            this.skinTextBox_bugCount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_bugCount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_bugCount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_bugCount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_bugCount.SkinTxt.Name = "BaseText";
            this.skinTextBox_bugCount.SkinTxt.Size = new System.Drawing.Size(64, 18);
            this.skinTextBox_bugCount.SkinTxt.TabIndex = 0;
            this.skinTextBox_bugCount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_bugCount.SkinTxt.WaterText = "";
            this.skinTextBox_bugCount.TabIndex = 3;
            this.skinTextBox_bugCount.TabStop = true;
            this.skinTextBox_bugCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_bugCount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_bugCount.WaterText = "";
            this.skinTextBox_bugCount.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(18, 38);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "款号";
            // 
            // CostumeCurrentShopTextBox1
            // 
            this.CostumeCurrentShopTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.CostumeCurrentShopTextBox1.CustomerID = null;
            this.CostumeCurrentShopTextBox1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.CostumeCurrentShopTextBox1.FilterValid = true;
            this.CostumeCurrentShopTextBox1.Icon = null;
            this.CostumeCurrentShopTextBox1.IconIsButton = false;
            this.CostumeCurrentShopTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.CostumeCurrentShopTextBox1.IsPasswordChat = '\0';
            this.CostumeCurrentShopTextBox1.IsSystemPasswordChar = false;
            this.CostumeCurrentShopTextBox1.Lines = new string[0];
            this.CostumeCurrentShopTextBox1.Location = new System.Drawing.Point(53, 32);
            this.CostumeCurrentShopTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.CostumeCurrentShopTextBox1.MaxLength = 32767;
            this.CostumeCurrentShopTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.CostumeCurrentShopTextBox1.MouseBack = null;
            this.CostumeCurrentShopTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.CostumeCurrentShopTextBox1.Multiline = false;
            this.CostumeCurrentShopTextBox1.Name = "CostumeCurrentShopTextBox1";
            this.CostumeCurrentShopTextBox1.NormlBack = null;
            this.CostumeCurrentShopTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.CostumeCurrentShopTextBox1.ReadOnly = false;
            this.CostumeCurrentShopTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CostumeCurrentShopTextBox1.Size = new System.Drawing.Size(140, 28);
            // 
            // 
            // 
            this.CostumeCurrentShopTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CostumeCurrentShopTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostumeCurrentShopTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.CostumeCurrentShopTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.CostumeCurrentShopTextBox1.SkinTxt.Name = "BaseText";
            this.CostumeCurrentShopTextBox1.SkinTxt.Size = new System.Drawing.Size(130, 18);
            this.CostumeCurrentShopTextBox1.SkinTxt.TabIndex = 0;
            this.CostumeCurrentShopTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CostumeCurrentShopTextBox1.SkinTxt.WaterText = "输入款号或条形码回车";
            this.CostumeCurrentShopTextBox1.TabIndex = 0;
            this.CostumeCurrentShopTextBox1.TabStop = true;
            this.CostumeCurrentShopTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CostumeCurrentShopTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CostumeCurrentShopTextBox1.WaterText = "输入款号或条形码回车";
            this.CostumeCurrentShopTextBox1.WordWrap = true;
            this.CostumeCurrentShopTextBox1.CostumeSelected += new System.Action<JGNet.CostumeItem>(this.CostumeCurrentShopTextBox1_CostumeSelected);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(205, 38);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "颜色";
            // 
            // skinComboBox_Size
            // 
            this.skinComboBox_Size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Size.FormattingEnabled = true;
            this.skinComboBox_Size.Location = new System.Drawing.Point(353, 35);
            this.skinComboBox_Size.Name = "skinComboBox_Size";
            this.skinComboBox_Size.Size = new System.Drawing.Size(74, 22);
            this.skinComboBox_Size.TabIndex = 2;
            this.skinComboBox_Size.WaterText = "";
            // 
            // skinComboBox_Color
            // 
            this.skinComboBox_Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Color.FormattingEnabled = true;
            this.skinComboBox_Color.Location = new System.Drawing.Point(239, 35);
            this.skinComboBox_Color.Name = "skinComboBox_Color";
            this.skinComboBox_Color.Size = new System.Drawing.Size(74, 22);
            this.skinComboBox_Color.TabIndex = 1;
            this.skinComboBox_Color.WaterText = "";
            this.skinComboBox_Color.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_Color_SelectedIndexChanged);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(319, 38);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "尺码";
            // 
            // costumeStoreBindingSource
            // 
            this.costumeStoreBindingSource.DataSource = typeof(JGNet.CostumeStore);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(JGNet.Member);
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // SizeDisplayName
            // 
            this.SizeDisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SizeDisplayName.DataPropertyName = "SizeDisplayName";
            this.SizeDisplayName.HeaderText = "尺码";
            this.SizeDisplayName.Name = "SizeDisplayName";
            this.SizeDisplayName.ReadOnly = true;
            this.SizeDisplayName.Width = 200;
            // 
            // BuyCount
            // 
            this.BuyCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BuyCount.DataPropertyName = "BuyCount";
            this.BuyCount.HeaderText = "数量";
            this.BuyCount.Name = "BuyCount";
            this.BuyCount.Width = 160;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 40;
            // 
            // WholesaleCustomeSaleEditCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel1);
            this.Name = "WholesaleCustomeSaleEditCtrl";
            this.Size = new System.Drawing.Size(836, 508);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SkinPanel skinPanel1;
        private BindingSource memberBindingSource;
        private BindingSource retailDetailBindingSource;
        private SkinLabel skinLabel7;
        private BindingSource costumeStoreBindingSource;
        private DataGridView dataGridView1;
        private SkinPanel panel1;
        private BaseButton baseButton1;
        private PfCustomerComboBox customerComboBox;
        private DateTimePicker dateTimePicker_Start;
        private SkinLabel skinLabel4;
        private SkinPanel skinPanel2;
        private SkinLabel skinLabel1;
        private PfCostumeCurrentShopTextBox CostumeCurrentShopTextBox1;
        private SkinLabel skinLabel2;
        private SkinLabel skinLabel5;
        private SkinLabel skinLabel3;
        private Common.TextBox skinTextBox_bugCount;
        private BaseButton BaseButton_AddCostume;
        private SkinComboBox skinComboBox_Color;
        private SkinComboBox skinComboBox_Size;
        private SkinLabel skinLabel6;
        private SkinLabel skinLabelOrderID;
        private SkinLabel skinLabel8;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SizeDisplayName;
        private DataGridViewTextBoxColumn BuyCount;
        private DataGridViewLinkColumn Column1;
    }
}