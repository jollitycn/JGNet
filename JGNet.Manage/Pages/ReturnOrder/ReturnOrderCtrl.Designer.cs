using JGNet.Common;
using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class ReturnOrderCtrl
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
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.skinLabel_OutboundOrderID = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.imageHelp1 = new JGNet.Common.Components.ImageHelp();
            this.skinComboBoxSupplierID = new JGNet.Common.Components.SupllierComboBox();
            this.skinComboBoxShopID = new JGNet.Common.ShopComboBox();
            this.skinPanel5 = new System.Windows.Forms.Panel();
            this.CostumeCurrentShopTextBox1 = new JGNet.Common.CostumeFromShopTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_OrderID = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_Remarks = new JGNet.Common.TextBox();
            this.skinPanel3 = new System.Windows.Forms.Panel();
            this.numericTextBoxMoney = new JGNet.Common.NumericTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.baseButtonPick = new JGNet.Common.Components.BaseButton();
            this.baseButtonHang = new JGNet.Common.Components.BaseButton();
            this.skinCheckBoxPrint = new CCWin.SkinControl.SkinCheckBox();
            this.BaseButtonConfirm = new JGNet.Common.Components.BaseButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.costumeStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel6 = new System.Windows.Forms.Panel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton2 = new JGNet.Common.Components.BaseButton();
            this.outboundDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.SumCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumCostMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPanel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).BeginInit();
            this.skinPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinPanel2);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 45);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.skinLabel_OutboundOrderID);
            this.skinPanel2.Controls.Add(this.skinLabel4);
            this.skinPanel2.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel2.Controls.Add(this.imageHelp1);
            this.skinPanel2.Controls.Add(this.skinComboBoxSupplierID);
            this.skinPanel2.Controls.Add(this.skinComboBoxShopID);
            this.skinPanel2.Controls.Add(this.skinPanel5);
            this.skinPanel2.Controls.Add(this.CostumeCurrentShopTextBox1);
            this.skinPanel2.Controls.Add(this.skinLabel1);
            this.skinPanel2.Controls.Add(this.skinLabel3);
            this.skinPanel2.Controls.Add(this.skinTextBox_OrderID);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 45);
            this.skinPanel2.TabIndex = 9;
            this.skinPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPanel2_Paint);
            // 
            // skinLabel_OutboundOrderID
            // 
            this.skinLabel_OutboundOrderID.AutoSize = true;
            this.skinLabel_OutboundOrderID.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_OutboundOrderID.BorderColor = System.Drawing.Color.White;
            this.skinLabel_OutboundOrderID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_OutboundOrderID.Location = new System.Drawing.Point(435, 15);
            this.skinLabel_OutboundOrderID.Name = "skinLabel_OutboundOrderID";
            this.skinLabel_OutboundOrderID.Size = new System.Drawing.Size(0, 17);
            this.skinLabel_OutboundOrderID.TabIndex = 1;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(5, 13);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 150;
            this.skinLabel4.Text = "单据时间";
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(65, 11);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(140, 21);
            this.dateTimePicker_Start.TabIndex = 149;
            // 
            // imageHelp1
            // 
            this.imageHelp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageHelp1.BackColor = System.Drawing.Color.Transparent;
            this.imageHelp1.Control = this;
            this.imageHelp1.Image = global::JGNet.Manage.Properties.Resources.采购退货流程;
            this.imageHelp1.Location = new System.Drawing.Point(1130, 11);
            this.imageHelp1.Name = "imageHelp1";
            this.imageHelp1.Size = new System.Drawing.Size(24, 24);
            this.imageHelp1.TabIndex = 14;
            // 
            // skinComboBoxSupplierID
            // 
            this.skinComboBoxSupplierID.AutoSize = true;
            this.skinComboBoxSupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxSupplierID.EnabledSupplier = true;
            this.skinComboBoxSupplierID.HideAll = true;
            this.skinComboBoxSupplierID.Location = new System.Drawing.Point(258, 9);
            this.skinComboBoxSupplierID.Name = "skinComboBoxSupplierID";
            this.skinComboBoxSupplierID.SelectedItem = null;
            this.skinComboBoxSupplierID.SelectedValue = null;
            this.skinComboBoxSupplierID.ShowAdd = true;
            this.skinComboBoxSupplierID.Size = new System.Drawing.Size(175, 26);
            this.skinComboBoxSupplierID.TabIndex = 0;
            this.skinComboBoxSupplierID.Title = null;
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(468, 10);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(140, 22);
            this.skinComboBoxShopID.TabIndex = 1;
            this.skinComboBoxShopID.WaterText = "";
            this.skinComboBoxShopID.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxShopID_SelectedIndexChanged);
            // 
            // skinPanel5
            // 
            this.skinPanel5.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel5.Location = new System.Drawing.Point(0, 42);
            this.skinPanel5.Name = "skinPanel5";
            this.skinPanel5.Size = new System.Drawing.Size(960, 289);
            this.skinPanel5.TabIndex = 4;
            // 
            // CostumeCurrentShopTextBox1
            // 
            this.CostumeCurrentShopTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.CostumeCurrentShopTextBox1.DownBack = null;
            this.CostumeCurrentShopTextBox1.FilterValid = true;
            this.CostumeCurrentShopTextBox1.Icon = null;
            this.CostumeCurrentShopTextBox1.IconIsButton = false;
            this.CostumeCurrentShopTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.CostumeCurrentShopTextBox1.IsPasswordChat = '\0';
            this.CostumeCurrentShopTextBox1.IsSystemPasswordChar = false;
            this.CostumeCurrentShopTextBox1.Lines = new string[0];
            this.CostumeCurrentShopTextBox1.Location = new System.Drawing.Point(652, 7);
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
            this.CostumeCurrentShopTextBox1.SkinTxt.WaterText = "";
            this.CostumeCurrentShopTextBox1.SupplierID = null;
            this.CostumeCurrentShopTextBox1.TabIndex = 2;
            this.CostumeCurrentShopTextBox1.TabStop = true;
            this.CostumeCurrentShopTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CostumeCurrentShopTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CostumeCurrentShopTextBox1.WaterText = "";
            this.CostumeCurrentShopTextBox1.WordWrap = true;
            this.CostumeCurrentShopTextBox1.CostumeSelected += new CJBasic.Action<JGNet.CostumeItem, bool>(this.CostumeCurrentShopTextBox1_CostumeSelected);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(618, 13);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "款号";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(213, 13);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(44, 17);
            this.skinLabel3.TabIndex = 7;
            this.skinLabel3.Text = "供应商";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinTextBox_OrderID
            // 
            this.skinTextBox_OrderID.AutoSize = true;
            this.skinTextBox_OrderID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_OrderID.BorderColor = System.Drawing.Color.White;
            this.skinTextBox_OrderID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTextBox_OrderID.Location = new System.Drawing.Point(432, 13);
            this.skinTextBox_OrderID.Name = "skinTextBox_OrderID";
            this.skinTextBox_OrderID.Size = new System.Drawing.Size(32, 17);
            this.skinTextBox_OrderID.TabIndex = 7;
            this.skinTextBox_OrderID.Text = "店铺";
            this.skinTextBox_OrderID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(3, 10);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "备注：";
            // 
            // skinTextBox_Remarks
            // 
            this.skinTextBox_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Remarks.DownBack = null;
            this.skinTextBox_Remarks.Icon = null;
            this.skinTextBox_Remarks.IconIsButton = false;
            this.skinTextBox_Remarks.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.IsPasswordChat = '\0';
            this.skinTextBox_Remarks.IsSystemPasswordChar = false;
            this.skinTextBox_Remarks.Lines = new string[0];
            this.skinTextBox_Remarks.Location = new System.Drawing.Point(50, 5);
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
            this.skinTextBox_Remarks.Size = new System.Drawing.Size(400, 28);
            // 
            // 
            // 
            this.skinTextBox_Remarks.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Remarks.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Remarks.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Remarks.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Remarks.SkinTxt.Name = "BaseText";
            this.skinTextBox_Remarks.SkinTxt.Size = new System.Drawing.Size(390, 18);
            this.skinTextBox_Remarks.SkinTxt.TabIndex = 0;
            this.skinTextBox_Remarks.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.SkinTxt.WaterText = "";
            this.skinTextBox_Remarks.TabIndex = 6;
            this.skinTextBox_Remarks.TabStop = true;
            this.skinTextBox_Remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Remarks.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.WaterText = "";
            this.skinTextBox_Remarks.WordWrap = true;
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.numericTextBoxMoney);
            this.skinPanel3.Controls.Add(this.skinLabel5);
            this.skinPanel3.Controls.Add(this.baseButtonPick);
            this.skinPanel3.Controls.Add(this.baseButtonHang);
            this.skinPanel3.Controls.Add(this.skinCheckBoxPrint);
            this.skinPanel3.Controls.Add(this.BaseButtonConfirm);
            this.skinPanel3.Controls.Add(this.skinTextBox_Remarks);
            this.skinPanel3.Controls.Add(this.skinLabel2);
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel3.Location = new System.Drawing.Point(0, 337);
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.Size = new System.Drawing.Size(1160, 40);
            this.skinPanel3.TabIndex = 5;
            // 
            // numericTextBoxMoney
            // 
            this.numericTextBoxMoney.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBoxMoney.DecimalPlaces = 0;
            this.numericTextBoxMoney.DownBack = null;
            this.numericTextBoxMoney.Icon = null;
            this.numericTextBoxMoney.IconIsButton = false;
            this.numericTextBoxMoney.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxMoney.IsPasswordChat = '\0';
            this.numericTextBoxMoney.IsSystemPasswordChar = false;
            this.numericTextBoxMoney.Lines = new string[0];
            this.numericTextBoxMoney.Location = new System.Drawing.Point(530, 5);
            this.numericTextBoxMoney.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBoxMoney.MaxLength = 29;
            this.numericTextBoxMoney.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBoxMoney.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBoxMoney.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxMoney.MouseBack = null;
            this.numericTextBoxMoney.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBoxMoney.Multiline = false;
            this.numericTextBoxMoney.Name = "numericTextBoxMoney";
            this.numericTextBoxMoney.NormlBack = null;
            this.numericTextBoxMoney.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBoxMoney.ReadOnly = false;
            this.numericTextBoxMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBoxMoney.ShowZero = false;
            this.numericTextBoxMoney.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.numericTextBoxMoney.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTextBoxMoney.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTextBoxMoney.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTextBoxMoney.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTextBoxMoney.SkinTxt.MaxLength = 29;
            this.numericTextBoxMoney.SkinTxt.Name = "BaseText";
            this.numericTextBoxMoney.SkinTxt.Size = new System.Drawing.Size(120, 18);
            this.numericTextBoxMoney.SkinTxt.TabIndex = 0;
            this.numericTextBoxMoney.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxMoney.SkinTxt.WaterText = "";
            this.numericTextBoxMoney.TabIndex = 30;
            this.numericTextBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBoxMoney.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBoxMoney.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBoxMoney.WaterText = "";
            this.numericTextBoxMoney.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(455, 11);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(68, 17);
            this.skinLabel5.TabIndex = 29;
            this.skinLabel5.Text = "付款金额：";
            // 
            // baseButtonPick
            // 
            this.baseButtonPick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonPick.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonPick.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonPick.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonPick.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonPick.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonPick.Location = new System.Drawing.Point(998, 5);
            this.baseButtonPick.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonPick.Name = "baseButtonPick";
            this.baseButtonPick.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonPick.Size = new System.Drawing.Size(75, 32);
            this.baseButtonPick.TabIndex = 28;
            this.baseButtonPick.Text = "提单";
            this.baseButtonPick.UseVisualStyleBackColor = false;
            this.baseButtonPick.Click += new System.EventHandler(this.baseButtonPick_Click);
            // 
            // baseButtonHang
            // 
            this.baseButtonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonHang.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonHang.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonHang.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonHang.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonHang.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonHang.Location = new System.Drawing.Point(917, 5);
            this.baseButtonHang.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonHang.Name = "baseButtonHang";
            this.baseButtonHang.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonHang.Size = new System.Drawing.Size(75, 32);
            this.baseButtonHang.TabIndex = 27;
            this.baseButtonHang.Text = "挂单";
            this.baseButtonHang.UseVisualStyleBackColor = false;
            this.baseButtonHang.Click += new System.EventHandler(this.baseButtonHang_Click);
            // 
            // skinCheckBoxPrint
            // 
            this.skinCheckBoxPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinCheckBoxPrint.AutoSize = true;
            this.skinCheckBoxPrint.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxPrint.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxPrint.DownBack = null;
            this.skinCheckBoxPrint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxPrint.Location = new System.Drawing.Point(863, 10);
            this.skinCheckBoxPrint.MouseBack = null;
            this.skinCheckBoxPrint.Name = "skinCheckBoxPrint";
            this.skinCheckBoxPrint.NormlBack = null;
            this.skinCheckBoxPrint.SelectedDownBack = null;
            this.skinCheckBoxPrint.SelectedMouseBack = null;
            this.skinCheckBoxPrint.SelectedNormlBack = null;
            this.skinCheckBoxPrint.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxPrint.TabIndex = 25;
            this.skinCheckBoxPrint.Text = "打印";
            this.skinCheckBoxPrint.UseVisualStyleBackColor = false;
            // 
            // BaseButtonConfirm
            // 
            this.BaseButtonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButtonConfirm.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonConfirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonConfirm.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonConfirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonConfirm.Location = new System.Drawing.Point(1079, 5);
            this.BaseButtonConfirm.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonConfirm.Name = "BaseButtonConfirm";
            this.BaseButtonConfirm.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonConfirm.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonConfirm.TabIndex = 7;
            this.BaseButtonConfirm.Text = "确认(F4)";
            this.BaseButtonConfirm.UseVisualStyleBackColor = false;
            this.BaseButtonConfirm.Click += new System.EventHandler(this.BaseButton_Inbound_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.costumeNameDataGridViewTextBoxColumn,
            this.BrandName,
            this.dataGridViewTextBoxColumn2,
            this.Price,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.sumCountDataGridViewTextBoxColumn,
            this.SumCostMoney,
            this.Remarks});
            this.dataGridView1.DataSource = this.costumeStoreBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 183);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // costumeStoreBindingSource
            // 
            this.costumeStoreBindingSource.DataSource = typeof(JGNet.CostumeStore);
            // 
            // skinPanel6
            // 
            this.skinPanel6.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel6.Controls.Add(this.baseButton1);
            this.skinPanel6.Controls.Add(this.skinLabel6);
            this.skinPanel6.Controls.Add(this.BaseButton2);
            this.skinPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel6.Location = new System.Drawing.Point(0, 183);
            this.skinPanel6.Name = "skinPanel6";
            this.skinPanel6.Size = new System.Drawing.Size(1160, 37);
            this.skinPanel6.TabIndex = 3;
            // 
            // baseButton1
            // 
            this.baseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(998, 2);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 13;
            this.baseButton1.Text = "清空";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.Red;
            this.skinLabel6.Location = new System.Drawing.Point(3, 10);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(164, 17);
            this.skinLabel6.TabIndex = 12;
            this.skinLabel6.Text = "下表的成本价和数量可以修改";
            this.skinLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BaseButton2
            // 
            this.BaseButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton2.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton2.Location = new System.Drawing.Point(1079, 2);
            this.BaseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton2.Name = "BaseButton2";
            this.BaseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton2.Size = new System.Drawing.Size(75, 32);
            this.BaseButton2.TabIndex = 4;
            this.BaseButton2.Text = "添加(F3)";
            this.BaseButton2.UseVisualStyleBackColor = false;
            this.BaseButton2.Click += new System.EventHandler(this.BaseButton_Add_Click);
            // 
            // outboundDetailBindingSource
            // 
            this.outboundDetailBindingSource.DataSource = typeof(JGNet.BoundDetail);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.Column1,
            this.dataGridViewTextBoxColumn15,
            this.Year,
            this.Season,
            this.colorNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.CostPrice,
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
            this.xL6DataGridViewTextBoxColumn,
            this.SumCount,
            this.SumCost,
            this.SumMoney,
            this.Comment,
            this.Column2});
            this.dataGridView2.DataSource = this.outboundDetailBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1160, 337);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDoubleClick);
            this.dataGridView2.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValidated);
            this.dataGridView2.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView2_CellValidating);
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
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
            // Column1
            // 
            this.Column1.DataPropertyName = "CostumeName";
            this.Column1.HeaderText = "商品名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "BrandName";
            this.dataGridViewTextBoxColumn15.HeaderText = "品牌";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 54;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "年份";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 54;
            // 
            // Season
            // 
            this.Season.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Season.DataPropertyName = "Season";
            this.Season.HeaderText = "季节";
            this.Season.Name = "Season";
            this.Season.ReadOnly = true;
            this.Season.Width = 54;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 54;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "吊牌价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 66;
            // 
            // CostPrice
            // 
            this.CostPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "成本价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Width = 66;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "F";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.Width = 36;
            // 
            // xSDataGridViewTextBoxColumn
            // 
            this.xSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xSDataGridViewTextBoxColumn.DataPropertyName = "XS";
            this.xSDataGridViewTextBoxColumn.HeaderText = "XS";
            this.xSDataGridViewTextBoxColumn.Name = "xSDataGridViewTextBoxColumn";
            this.xSDataGridViewTextBoxColumn.Width = 42;
            // 
            // sDataGridViewTextBoxColumn
            // 
            this.sDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sDataGridViewTextBoxColumn.DataPropertyName = "S";
            this.sDataGridViewTextBoxColumn.HeaderText = "S";
            this.sDataGridViewTextBoxColumn.Name = "sDataGridViewTextBoxColumn";
            this.sDataGridViewTextBoxColumn.Width = 36;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.mDataGridViewTextBoxColumn.DataPropertyName = "M";
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.Width = 36;
            // 
            // lDataGridViewTextBoxColumn
            // 
            this.lDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lDataGridViewTextBoxColumn.DataPropertyName = "L";
            this.lDataGridViewTextBoxColumn.HeaderText = "L";
            this.lDataGridViewTextBoxColumn.Name = "lDataGridViewTextBoxColumn";
            this.lDataGridViewTextBoxColumn.Width = 36;
            // 
            // xLDataGridViewTextBoxColumn
            // 
            this.xLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xLDataGridViewTextBoxColumn.DataPropertyName = "XL";
            this.xLDataGridViewTextBoxColumn.HeaderText = "XL";
            this.xLDataGridViewTextBoxColumn.Name = "xLDataGridViewTextBoxColumn";
            this.xLDataGridViewTextBoxColumn.Width = 42;
            // 
            // xL2DataGridViewTextBoxColumn
            // 
            this.xL2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL2DataGridViewTextBoxColumn.DataPropertyName = "XL2";
            this.xL2DataGridViewTextBoxColumn.HeaderText = "2XL";
            this.xL2DataGridViewTextBoxColumn.Name = "xL2DataGridViewTextBoxColumn";
            this.xL2DataGridViewTextBoxColumn.Width = 48;
            // 
            // xL3DataGridViewTextBoxColumn
            // 
            this.xL3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL3DataGridViewTextBoxColumn.DataPropertyName = "XL3";
            this.xL3DataGridViewTextBoxColumn.HeaderText = "3XL";
            this.xL3DataGridViewTextBoxColumn.Name = "xL3DataGridViewTextBoxColumn";
            this.xL3DataGridViewTextBoxColumn.Width = 48;
            // 
            // xL4DataGridViewTextBoxColumn
            // 
            this.xL4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL4DataGridViewTextBoxColumn.DataPropertyName = "XL4";
            this.xL4DataGridViewTextBoxColumn.HeaderText = "4XL";
            this.xL4DataGridViewTextBoxColumn.Name = "xL4DataGridViewTextBoxColumn";
            this.xL4DataGridViewTextBoxColumn.Width = 48;
            // 
            // xL5DataGridViewTextBoxColumn
            // 
            this.xL5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL5DataGridViewTextBoxColumn.DataPropertyName = "XL5";
            this.xL5DataGridViewTextBoxColumn.HeaderText = "5XL";
            this.xL5DataGridViewTextBoxColumn.Name = "xL5DataGridViewTextBoxColumn";
            this.xL5DataGridViewTextBoxColumn.Width = 48;
            // 
            // xL6DataGridViewTextBoxColumn
            // 
            this.xL6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.xL6DataGridViewTextBoxColumn.DataPropertyName = "XL6";
            this.xL6DataGridViewTextBoxColumn.HeaderText = "6XL";
            this.xL6DataGridViewTextBoxColumn.Name = "xL6DataGridViewTextBoxColumn";
            this.xL6DataGridViewTextBoxColumn.Width = 48;
            // 
            // SumCount
            // 
            this.SumCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumCount.DataPropertyName = "SumCount";
            this.SumCount.HeaderText = "数量";
            this.SumCount.Name = "SumCount";
            this.SumCount.ReadOnly = true;
            this.SumCount.Width = 54;
            // 
            // SumCost
            // 
            this.SumCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumCost.DataPropertyName = "SumCost";
            this.SumCost.HeaderText = "总成本";
            this.SumCost.Name = "SumCost";
            this.SumCost.ReadOnly = true;
            this.SumCost.Width = 66;
            // 
            // SumMoney
            // 
            this.SumMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumMoney.DataPropertyName = "SumMoney";
            this.SumMoney.HeaderText = "总金额";
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.ReadOnly = true;
            this.SumMoney.Width = 66;
            // 
            // Comment
            // 
            this.Comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "备注";
            this.Comment.Name = "Comment";
            this.Comment.Width = 54;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "删除";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 45);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinPanel6);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinPanel3);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 605);
            this.skinSplitContainer1.SplitterDistance = 220;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 1;
            this.skinSplitContainer1.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CostumeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "款号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeNameDataGridViewTextBoxColumn.Width = 160;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "品牌";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ColorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "颜色";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "吊牌价";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CostPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "成本价";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "F";
            this.dataGridViewTextBoxColumn14.HeaderText = "F";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 36;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "XS";
            this.dataGridViewTextBoxColumn4.HeaderText = "XS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 42;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "S";
            this.dataGridViewTextBoxColumn5.HeaderText = "S";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 36;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "M";
            this.dataGridViewTextBoxColumn6.HeaderText = "M";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 36;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "L";
            this.dataGridViewTextBoxColumn7.HeaderText = "L";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 36;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "XL";
            this.dataGridViewTextBoxColumn8.HeaderText = "XL";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 42;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "XL2";
            this.dataGridViewTextBoxColumn9.HeaderText = "2XL";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 48;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "XL3";
            this.dataGridViewTextBoxColumn10.HeaderText = "3XL";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 48;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "XL4";
            this.dataGridViewTextBoxColumn11.HeaderText = "4XL";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 48;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "XL5";
            this.dataGridViewTextBoxColumn12.HeaderText = "5XL";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 48;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "XL6";
            this.dataGridViewTextBoxColumn13.HeaderText = "6XL";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 48;
            // 
            // sumCountDataGridViewTextBoxColumn
            // 
            this.sumCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sumCountDataGridViewTextBoxColumn.DataPropertyName = "SumCount";
            this.sumCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.sumCountDataGridViewTextBoxColumn.Name = "sumCountDataGridViewTextBoxColumn";
            this.sumCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumCountDataGridViewTextBoxColumn.Width = 54;
            // 
            // SumCostMoney
            // 
            this.SumCostMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SumCostMoney.DataPropertyName = "SumCostMoney";
            this.SumCostMoney.HeaderText = "总成本";
            this.SumCostMoney.Name = "SumCostMoney";
            this.SumCostMoney.ReadOnly = true;
            this.SumCostMoney.Width = 66;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "备注";
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 54;
            // 
            // ReturnOrderCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "ReturnOrderCtrl";
            this.Load += new System.EventHandler(this.ReturnOrderCtrl_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumeStoreBindingSource)).EndInit();
            this.skinPanel6.ResumeLayout(false);
            this.skinPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outboundDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel_OutboundOrderID;
        private System.Windows.Forms.BindingSource outboundDetailBindingSource;
        private CCWin.SkinControl.SkinLabel skinTextBox_OrderID;
        private System.Windows.Forms.Panel skinPanel2;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private  JGNet.Common.TextBox skinTextBox_Remarks;
        private System.Windows.Forms.Panel skinPanel3;
        private CostumeFromShopTextBox CostumeCurrentShopTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Panel skinPanel5;
        private System.Windows.Forms.BindingSource costumeStoreBindingSource;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Panel skinPanel6;
        private DataGridView dataGridView2;
        private ShopComboBox skinComboBoxShopID;
        private SupllierComboBox skinComboBoxSupplierID;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn outboundOrderIDDataGridViewTextBoxColumn;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private ImageHelp imageHelp1;
        private Common.Components.BaseButton BaseButton2;
        private Common.Components.BaseButton BaseButtonConfirm;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxPrint;
        private DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private BaseButton baseButton1;
        private BaseButton baseButtonPick;
        private BaseButton baseButtonHang;
        private NumericTextBox numericTextBoxMoney;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Season;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CostPrice;
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
        private DataGridViewTextBoxColumn SumCount;
        private DataGridViewTextBoxColumn SumCost;
        private DataGridViewTextBoxColumn SumMoney;
        private DataGridViewTextBoxColumn Comment;
        private DataGridViewLinkColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn BrandName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn sumCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn SumCostMoney;
        private DataGridViewTextBoxColumn Remarks;
    }
}
