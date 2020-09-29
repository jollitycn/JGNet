using CCWin.SkinControl;
using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Common
{
    partial class RefundDirectCtrl
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
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.guideComboBox1 = new JGNet.Common.GuideComboBox();
            this.skinTextBox_RefundReason = new JGNet.Common.TextBox();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.costumeStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.skinComboBoxShopID = new JGNet.Common.ShopComboBox();
            this.skinLabel22 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.memberIDTextBox2 = new JGNet.Common.MemberIDTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.CostumeCurrentShopTextBox1 = new JGNet.Common.CostumeFromShopTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_bugCount = new JGNet.Common.TextBox();
            this.BaseButton_AddCostume = new JGNet.Common.Components.BaseButton();
            this.skinComboBox_Color = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBox_Size = new CCWin.SkinControl.SkinComboBox();
            this.panel8 = new CCWin.SkinControl.SkinPanel();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuideName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.skinPanel1.Size = new System.Drawing.Size(836, 597);
            this.skinPanel1.TabIndex = 0;
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
            this.SizeDisplayName,
            this.priceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.buyCountDataGridViewTextBoxColumn,
            this.sumMoneyDataGridViewTextBoxColumn,
            this.GuideName,
            this.Column1});
            this.dataGridView1.DataSource = this.retailDetailBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 132);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(836, 419);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // retailDetailBindingSource
            // 
            this.retailDetailBindingSource.DataSource = typeof(JGNet.RetailDetail);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.skinLabel6);
            this.panel1.Controls.Add(this.baseButton1);
            this.panel1.Controls.Add(this.skinLabel12);
            this.panel1.Controls.Add(this.guideComboBox1);
            this.panel1.Controls.Add(this.skinTextBox_RefundReason);
            this.panel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.DownBack = null;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.MouseBack = null;
            this.panel1.Name = "panel1";
            this.panel1.NormlBack = null;
            this.panel1.Size = new System.Drawing.Size(836, 46);
            this.panel1.TabIndex = 6;
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(3, 16);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(56, 17);
            this.skinLabel6.TabIndex = 158;
            this.skinLabel6.Text = "退货原因";
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
            this.baseButton1.Location = new System.Drawing.Point(758, 8);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 6;
            this.baseButton1.Text = "确认(F4)";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton3_Click);
            // 
            // skinLabel12
            // 
            this.skinLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.Location = new System.Drawing.Point(621, 16);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(44, 17);
            this.skinLabel12.TabIndex = 4;
            this.skinLabel12.Text = "导购员";
            // 
            // guideComboBox1
            // 
            this.guideComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guideComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guideComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guideComboBox1.FormattingEnabled = true;
            this.guideComboBox1.Location = new System.Drawing.Point(668, 13);
            this.guideComboBox1.Name = "guideComboBox1";
            this.guideComboBox1.ShopID = null;
            this.guideComboBox1.Size = new System.Drawing.Size(80, 22);
            this.guideComboBox1.TabIndex = 5;
            this.guideComboBox1.WaterText = "";
            this.guideComboBox1.SelectedIndexChanged += new System.EventHandler(this.guideComboBox1_SelectedIndexChanged);
            // 
            // skinTextBox_RefundReason
            // 
            this.skinTextBox_RefundReason.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_RefundReason.DownBack = null;
            this.skinTextBox_RefundReason.Icon = null;
            this.skinTextBox_RefundReason.IconIsButton = false;
            this.skinTextBox_RefundReason.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_RefundReason.IsPasswordChat = '\0';
            this.skinTextBox_RefundReason.IsSystemPasswordChar = false;
            this.skinTextBox_RefundReason.Lines = new string[0];
            this.skinTextBox_RefundReason.Location = new System.Drawing.Point(62, 10);
            this.skinTextBox_RefundReason.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_RefundReason.MaxLength = 32767;
            this.skinTextBox_RefundReason.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_RefundReason.MouseBack = null;
            this.skinTextBox_RefundReason.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_RefundReason.Multiline = false;
            this.skinTextBox_RefundReason.Name = "skinTextBox_RefundReason";
            this.skinTextBox_RefundReason.NormlBack = null;
            this.skinTextBox_RefundReason.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_RefundReason.ReadOnly = false;
            this.skinTextBox_RefundReason.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_RefundReason.Size = new System.Drawing.Size(228, 28);
            // 
            // 
            // 
            this.skinTextBox_RefundReason.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_RefundReason.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_RefundReason.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_RefundReason.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_RefundReason.SkinTxt.Name = "BaseText";
            this.skinTextBox_RefundReason.SkinTxt.Size = new System.Drawing.Size(218, 18);
            this.skinTextBox_RefundReason.SkinTxt.TabIndex = 0;
            this.skinTextBox_RefundReason.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_RefundReason.SkinTxt.WaterText = "";
            this.skinTextBox_RefundReason.TabIndex = 4;
            this.skinTextBox_RefundReason.TabStop = true;
            this.skinTextBox_RefundReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_RefundReason.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_RefundReason.WaterText = "";
            this.skinTextBox_RefundReason.WordWrap = true;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.dataGridView2);
            this.skinPanel2.Controls.Add(this.panel3);
            this.skinPanel2.Controls.Add(this.panel2);
            this.skinPanel2.Controls.Add(this.panel8);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(836, 132);
            this.skinPanel2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colorNameDataGridViewTextBoxColumn1,
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
            this.dataGridView2.DataSource = this.costumeStoreBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 36);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(704, 85);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView2_DataBindingComplete);
            // 
            // costumeStoreBindingSource
            // 
            this.costumeStoreBindingSource.DataSource = typeof(JGNet.CostumeStore);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.skinComboBoxShopID);
            this.panel3.Controls.Add(this.skinLabel22);
            this.panel3.Controls.Add(this.skinLabel19);
            this.panel3.Controls.Add(this.dateTimePicker_Start);
            this.panel3.Controls.Add(this.memberIDTextBox2);
            this.panel3.Controls.Add(this.skinLabel7);
            this.panel3.Controls.Add(this.skinLabel1);
            this.panel3.Controls.Add(this.CostumeCurrentShopTextBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 36);
            this.panel3.TabIndex = 14;
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(41, 7);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(107, 22);
            this.skinComboBoxShopID.TabIndex = 161;
            this.skinComboBoxShopID.WaterText = "";
            this.skinComboBoxShopID.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxShopID_SelectedIndexChanged);
            // 
            // skinLabel22
            // 
            this.skinLabel22.AutoSize = true;
            this.skinLabel22.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel22.BorderColor = System.Drawing.Color.White;
            this.skinLabel22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel22.Location = new System.Drawing.Point(3, 10);
            this.skinLabel22.Name = "skinLabel22";
            this.skinLabel22.Size = new System.Drawing.Size(32, 17);
            this.skinLabel22.TabIndex = 162;
            this.skinLabel22.Text = "店铺";
            this.skinLabel22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel19
            // 
            this.skinLabel19.AutoSize = true;
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel19.Location = new System.Drawing.Point(154, 10);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(56, 17);
            this.skinLabel19.TabIndex = 150;
            this.skinLabel19.Text = "单据时间";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(216, 8);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(122, 21);
            this.dateTimePicker_Start.TabIndex = 149;
            // 
            // memberIDTextBox2
            // 
            this.memberIDTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.memberIDTextBox2.CheckMember = false;
            this.memberIDTextBox2.DownBack = null;
            this.memberIDTextBox2.Icon = null;
            this.memberIDTextBox2.IconIsButton = false;
            this.memberIDTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.memberIDTextBox2.IsPasswordChat = '\0';
            this.memberIDTextBox2.IsSystemPasswordChar = false;
            this.memberIDTextBox2.Lines = new string[0];
            this.memberIDTextBox2.Location = new System.Drawing.Point(383, 4);
            this.memberIDTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.memberIDTextBox2.MaxLength = 32767;
            this.memberIDTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.memberIDTextBox2.MouseBack = null;
            this.memberIDTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.memberIDTextBox2.Multiline = false;
            this.memberIDTextBox2.Name = "memberIDTextBox2";
            this.memberIDTextBox2.NormlBack = null;
            this.memberIDTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.memberIDTextBox2.ReadOnly = false;
            this.memberIDTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memberIDTextBox2.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.memberIDTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberIDTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberIDTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.memberIDTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.memberIDTextBox2.SkinTxt.Name = "BaseText";
            this.memberIDTextBox2.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.memberIDTextBox2.SkinTxt.TabIndex = 0;
            this.memberIDTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.memberIDTextBox2.SkinTxt.WaterText = "输入卡号/姓名并回车";
            this.memberIDTextBox2.TabIndex = 4;
            this.memberIDTextBox2.TabStop = true;
            this.memberIDTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.memberIDTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.memberIDTextBox2.WaterText = "输入卡号/姓名并回车";
            this.memberIDTextBox2.WordWrap = true;
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(348, 10);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 5;
            this.skinLabel7.Text = "会员";
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(534, 10);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "款号";
            // 
            // CostumeCurrentShopTextBox1
            // 
            this.CostumeCurrentShopTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CostumeCurrentShopTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.CostumeCurrentShopTextBox1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.CostumeCurrentShopTextBox1.FilterValid = true;
            this.CostumeCurrentShopTextBox1.Icon = null;
            this.CostumeCurrentShopTextBox1.IconIsButton = false;
            this.CostumeCurrentShopTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.CostumeCurrentShopTextBox1.IsPasswordChat = '\0';
            this.CostumeCurrentShopTextBox1.IsSystemPasswordChar = false;
            this.CostumeCurrentShopTextBox1.Lines = new string[0];
            this.CostumeCurrentShopTextBox1.Location = new System.Drawing.Point(569, 4);
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
            this.CostumeCurrentShopTextBox1.ShopID = null;
            this.CostumeCurrentShopTextBox1.Size = new System.Drawing.Size(117, 28);
            // 
            // 
            // 
            this.CostumeCurrentShopTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CostumeCurrentShopTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostumeCurrentShopTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.CostumeCurrentShopTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.CostumeCurrentShopTextBox1.SkinTxt.Name = "BaseText";
            this.CostumeCurrentShopTextBox1.SkinTxt.Size = new System.Drawing.Size(107, 18);
            this.CostumeCurrentShopTextBox1.SkinTxt.TabIndex = 0;
            this.CostumeCurrentShopTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CostumeCurrentShopTextBox1.SkinTxt.WaterText = "输入款号或条形码回车";
            this.CostumeCurrentShopTextBox1.SupplierID = null;
            this.CostumeCurrentShopTextBox1.TabIndex = 0;
            this.CostumeCurrentShopTextBox1.TabStop = true;
            this.CostumeCurrentShopTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CostumeCurrentShopTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CostumeCurrentShopTextBox1.WaterText = "输入款号或条形码回车";
            this.CostumeCurrentShopTextBox1.WordWrap = true;
            this.CostumeCurrentShopTextBox1.CostumeSelected += new CJBasic.Action<JGNet.CostumeItem, bool>(this.CostumeCurrentShopTextBox1_CostumeSelected);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.skinLabel2);
            this.panel2.Controls.Add(this.skinLabel5);
            this.panel2.Controls.Add(this.skinLabel3);
            this.panel2.Controls.Add(this.skinTextBox_bugCount);
            this.panel2.Controls.Add(this.BaseButton_AddCostume);
            this.panel2.Controls.Add(this.skinComboBox_Color);
            this.panel2.Controls.Add(this.skinComboBox_Size);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(704, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 121);
            this.panel2.TabIndex = 15;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(5, 6);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "颜色";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(5, 59);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "数量";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(5, 32);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "尺码";
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
            this.skinTextBox_bugCount.Location = new System.Drawing.Point(39, 54);
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
            // BaseButton_AddCostume
            // 
            this.BaseButton_AddCostume.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_AddCostume.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_AddCostume.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_AddCostume.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_AddCostume.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_AddCostume.Location = new System.Drawing.Point(39, 84);
            this.BaseButton_AddCostume.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_AddCostume.Name = "BaseButton_AddCostume";
            this.BaseButton_AddCostume.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_AddCostume.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_AddCostume.TabIndex = 4;
            this.BaseButton_AddCostume.Text = "添加(F3)";
            this.BaseButton_AddCostume.UseVisualStyleBackColor = false;
            this.BaseButton_AddCostume.Click += new System.EventHandler(this.BaseButton_AddCostume_Click);
            // 
            // skinComboBox_Color
            // 
            this.skinComboBox_Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Color.FormattingEnabled = true;
            this.skinComboBox_Color.Location = new System.Drawing.Point(39, 3);
            this.skinComboBox_Color.Name = "skinComboBox_Color";
            this.skinComboBox_Color.Size = new System.Drawing.Size(74, 22);
            this.skinComboBox_Color.TabIndex = 1;
            this.skinComboBox_Color.WaterText = "";
            this.skinComboBox_Color.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_Color_SelectedIndexChanged);
            // 
            // skinComboBox_Size
            // 
            this.skinComboBox_Size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Size.FormattingEnabled = true;
            this.skinComboBox_Size.Location = new System.Drawing.Point(39, 29);
            this.skinComboBox_Size.Name = "skinComboBox_Size";
            this.skinComboBox_Size.Size = new System.Drawing.Size(74, 22);
            this.skinComboBox_Size.TabIndex = 2;
            this.skinComboBox_Size.WaterText = "";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.DownBack = null;
            this.panel8.Location = new System.Drawing.Point(0, 121);
            this.panel8.MouseBack = null;
            this.panel8.Name = "panel8";
            this.panel8.NormlBack = null;
            this.panel8.Size = new System.Drawing.Size(836, 11);
            this.panel8.TabIndex = 13;
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
            this.costumeIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // SizeDisplayName
            // 
            this.SizeDisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SizeDisplayName.DataPropertyName = "SizeDisplayName";
            this.SizeDisplayName.HeaderText = "尺码";
            this.SizeDisplayName.Name = "SizeDisplayName";
            this.SizeDisplayName.ReadOnly = true;
            this.SizeDisplayName.Width = 120;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "吊牌价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 120;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "折扣";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Width = 120;
            // 
            // buyCountDataGridViewTextBoxColumn
            // 
            this.buyCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.buyCountDataGridViewTextBoxColumn.DataPropertyName = "RefundCount";
            this.buyCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.buyCountDataGridViewTextBoxColumn.Name = "buyCountDataGridViewTextBoxColumn";
            this.buyCountDataGridViewTextBoxColumn.Width = 105;
            // 
            // sumMoneyDataGridViewTextBoxColumn
            // 
            this.sumMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sumMoneyDataGridViewTextBoxColumn.DataPropertyName = "SumMoney";
            this.sumMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.sumMoneyDataGridViewTextBoxColumn.Name = "sumMoneyDataGridViewTextBoxColumn";
            // 
            // GuideName
            // 
            this.GuideName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GuideName.DataPropertyName = "GuideID";
            this.GuideName.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.GuideName.HeaderText = "导购员";
            this.GuideName.Name = "GuideName";
            this.GuideName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GuideName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GuideName.Width = 120;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 45;
            // 
            // colorNameDataGridViewTextBoxColumn1
            // 
            this.colorNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn1.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn1.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn1.Name = "colorNameDataGridViewTextBoxColumn1";
            this.colorNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "F";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.ReadOnly = true;
            this.fDataGridViewTextBoxColumn.Width = 80;
            // 
            // xSDataGridViewTextBoxColumn
            // 
            this.xSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xSDataGridViewTextBoxColumn.DataPropertyName = "XS";
            this.xSDataGridViewTextBoxColumn.HeaderText = "XS";
            this.xSDataGridViewTextBoxColumn.Name = "xSDataGridViewTextBoxColumn";
            this.xSDataGridViewTextBoxColumn.ReadOnly = true;
            this.xSDataGridViewTextBoxColumn.Width = 80;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDataGridViewTextBoxColumn.Width = 80;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.ReadOnly = true;
            this.mDataGridViewTextBoxColumn.Width = 80;
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            this.lDataGridViewTextBoxColumn.ReadOnly = true;
            this.lDataGridViewTextBoxColumn.Width = 80;
            // 
            // xLDataGridViewTextBoxColumn
            // 
            this.xLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xLDataGridViewTextBoxColumn.DataPropertyName = "XL";
            this.xLDataGridViewTextBoxColumn.HeaderText = "XL";
            this.xLDataGridViewTextBoxColumn.Name = "xLDataGridViewTextBoxColumn";
            this.xLDataGridViewTextBoxColumn.ReadOnly = true;
            this.xLDataGridViewTextBoxColumn.Width = 80;
            // 
            // xL2DataGridViewTextBoxColumn
            // 
            this.xL2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL2DataGridViewTextBoxColumn.DataPropertyName = "XL2";
            this.xL2DataGridViewTextBoxColumn.HeaderText = "2XL";
            this.xL2DataGridViewTextBoxColumn.Name = "xL2DataGridViewTextBoxColumn";
            this.xL2DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL2DataGridViewTextBoxColumn.Width = 80;
            // 
            // xL3DataGridViewTextBoxColumn
            // 
            this.xL3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL3DataGridViewTextBoxColumn.DataPropertyName = "XL3";
            this.xL3DataGridViewTextBoxColumn.HeaderText = "3XL";
            this.xL3DataGridViewTextBoxColumn.Name = "xL3DataGridViewTextBoxColumn";
            this.xL3DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL3DataGridViewTextBoxColumn.Width = 80;
            // 
            // xL4DataGridViewTextBoxColumn
            // 
            this.xL4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL4DataGridViewTextBoxColumn.DataPropertyName = "XL4";
            this.xL4DataGridViewTextBoxColumn.HeaderText = "4XL";
            this.xL4DataGridViewTextBoxColumn.Name = "xL4DataGridViewTextBoxColumn";
            this.xL4DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL4DataGridViewTextBoxColumn.Width = 80;
            // 
            // xL5DataGridViewTextBoxColumn
            // 
            this.xL5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL5DataGridViewTextBoxColumn.DataPropertyName = "XL5";
            this.xL5DataGridViewTextBoxColumn.HeaderText = "5XL";
            this.xL5DataGridViewTextBoxColumn.Name = "xL5DataGridViewTextBoxColumn";
            this.xL5DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL5DataGridViewTextBoxColumn.Width = 80;
            // 
            // xL6DataGridViewTextBoxColumn
            // 
            this.xL6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL6DataGridViewTextBoxColumn.DataPropertyName = "XL6";
            this.xL6DataGridViewTextBoxColumn.HeaderText = "6XL";
            this.xL6DataGridViewTextBoxColumn.Name = "xL6DataGridViewTextBoxColumn";
            this.xL6DataGridViewTextBoxColumn.ReadOnly = true;
            this.xL6DataGridViewTextBoxColumn.Width = 48;
            // 
            // RefundDirectCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel1);
            this.Name = "RefundDirectCtrl";
            this.Size = new System.Drawing.Size(836, 597);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SkinPanel skinPanel1;
        private SkinPanel skinPanel2;
        private BindingSource memberBindingSource;
        private BindingSource retailDetailBindingSource;
        private Panel panel3;
        private MemberIDTextBox memberIDTextBox2;
        private SkinLabel skinLabel7;
        private SkinLabel skinLabel1;
        private CostumeFromShopTextBox CostumeCurrentShopTextBox1;
        private Panel panel2;
        private SkinLabel skinLabel2;
        private SkinLabel skinLabel5;
        private SkinLabel skinLabel3;
        private TextBox skinTextBox_bugCount;
        private BaseButton BaseButton_AddCostume;
        private SkinComboBox skinComboBox_Color;
        private SkinComboBox skinComboBox_Size;
        private SkinPanel panel8;
        private BindingSource costumeStoreBindingSource;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private SkinPanel panel1;
        private SkinLabel skinLabel6;
        private SkinLabel skinLabel12;
        private GuideComboBox guideComboBox1;
        private TextBox skinTextBox_RefundReason;
        private BaseButton baseButton1;
        private SkinLabel skinLabel19;
        private DateTimePicker dateTimePicker_Start;
        private ShopComboBox skinComboBoxShopID;
        private SkinLabel skinLabel22;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SizeDisplayName;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn buyCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumMoneyDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn GuideName;
        private DataGridViewLinkColumn Column1;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn1;
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