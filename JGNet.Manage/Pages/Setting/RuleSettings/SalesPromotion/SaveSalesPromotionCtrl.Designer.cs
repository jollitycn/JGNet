using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    partial class SaveSalesPromotionCtrl
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
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeginDate = new System.Windows.Forms.DateTimePicker();
            this.skinTextBox_Name = new JGNet.Common.TextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxPromotionType = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_Remarks = new JGNet.Common.TextBox();
            this.skinCheckBox_Enabled = new CCWin.SkinControl.SkinCheckBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabelCostume = new CCWin.SkinControl.SkinLabel();
            this.BaseButton2 = new JGNet.Common.Components.BaseButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxShop = new System.Windows.Forms.GroupBox();
            this.dataGridViewShop = new System.Windows.Forms.DataGridView();
            this.groupBoxRule = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.discountRuleCtrl1 = new JGNet.Manage.Pages.RuleSettings.SalesPromotion.DiscountRuleCtrl();
            this.mjRuleCtrl1 = new JGNet.Manage.Pages.RuleSettings.SalesPromotion.MJRuleCtrl();
            this.skinPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.groupBoxShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).BeginInit();
            this.groupBoxRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.dateTimePickerEndDate);
            this.skinPanel1.Controls.Add(this.dateTimePickerBeginDate);
            this.skinPanel1.Controls.Add(this.skinTextBox_Name);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel11);
            this.skinPanel1.Controls.Add(this.skinComboBoxPromotionType);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel9);
            this.skinPanel1.Controls.Add(this.skinTextBox_Remarks);
            this.skinPanel1.Controls.Add(this.skinCheckBox_Enabled);
            this.skinPanel1.Controls.Add(this.skinLabel8);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 211);
            this.skinPanel1.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(647, 122);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(164, 21);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // dateTimePickerBeginDate
            // 
            this.dateTimePickerBeginDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerBeginDate.Location = new System.Drawing.Point(409, 122);
            this.dateTimePickerBeginDate.Name = "dateTimePickerBeginDate";
            this.dateTimePickerBeginDate.Size = new System.Drawing.Size(164, 21);
            this.dateTimePickerBeginDate.TabIndex = 2;
            // 
            // skinTextBox_Name
            // 
            this.skinTextBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Name.DownBack = null;
            this.skinTextBox_Name.Icon = null;
            this.skinTextBox_Name.IconIsButton = false;
            this.skinTextBox_Name.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Name.IsPasswordChat = '\0';
            this.skinTextBox_Name.IsSystemPasswordChar = false;
            this.skinTextBox_Name.Lines = new string[0];
            this.skinTextBox_Name.Location = new System.Drawing.Point(409, 88);
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
            this.skinTextBox_Name.Size = new System.Drawing.Size(402, 28);
            // 
            // 
            // 
            this.skinTextBox_Name.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Name.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Name.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Name.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Name.SkinTxt.Name = "BaseText";
            this.skinTextBox_Name.SkinTxt.Size = new System.Drawing.Size(392, 18);
            this.skinTextBox_Name.SkinTxt.TabIndex = 0;
            this.skinTextBox_Name.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Name.SkinTxt.WaterText = "";
            this.skinTextBox_Name.TabIndex = 1;
            this.skinTextBox_Name.TabStop = true;
            this.skinTextBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Name.WaterText = "";
            this.skinTextBox_Name.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(341, 94);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 148;
            this.skinLabel2.Text = "活动名称";
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(585, 122);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 145;
            this.skinLabel1.Text = "结束时间";
            // 
            // skinLabel11
            // 
            this.skinLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.Location = new System.Drawing.Point(341, 122);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(56, 17);
            this.skinLabel11.TabIndex = 143;
            this.skinLabel11.Text = "开始时间";
            // 
            // skinComboBoxPromotionType
            // 
            this.skinComboBoxPromotionType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBoxPromotionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxPromotionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxPromotionType.FormattingEnabled = true;
            this.skinComboBoxPromotionType.Location = new System.Drawing.Point(409, 59);
            this.skinComboBoxPromotionType.Name = "skinComboBoxPromotionType";
            this.skinComboBoxPromotionType.Size = new System.Drawing.Size(402, 22);
            this.skinComboBoxPromotionType.TabIndex = 0;
            this.skinComboBoxPromotionType.WaterText = "";
            this.skinComboBoxPromotionType.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxPromotionType_SelectedIndexChanged);
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Red;
            this.skinLabel4.Location = new System.Drawing.Point(466, 179);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(288, 17);
            this.skinLabel4.TabIndex = 141;
            this.skinLabel4.Text = "备注： 如果销售商品已经享受此规则，则不能修改。";
            // 
            // skinLabel9
            // 
            this.skinLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(341, 62);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(56, 17);
            this.skinLabel9.TabIndex = 141;
            this.skinLabel9.Text = "促销类型";
            // 
            // skinTextBox_Remarks
            // 
            this.skinTextBox_Remarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Remarks.DownBack = null;
            this.skinTextBox_Remarks.Icon = null;
            this.skinTextBox_Remarks.IconIsButton = false;
            this.skinTextBox_Remarks.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.IsPasswordChat = '\0';
            this.skinTextBox_Remarks.IsSystemPasswordChar = false;
            this.skinTextBox_Remarks.Lines = new string[0];
            this.skinTextBox_Remarks.Location = new System.Drawing.Point(409, 145);
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
            this.skinTextBox_Remarks.Size = new System.Drawing.Size(402, 28);
            // 
            // 
            // 
            this.skinTextBox_Remarks.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Remarks.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Remarks.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Remarks.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Remarks.SkinTxt.Name = "BaseText";
            this.skinTextBox_Remarks.SkinTxt.Size = new System.Drawing.Size(392, 18);
            this.skinTextBox_Remarks.SkinTxt.TabIndex = 0;
            this.skinTextBox_Remarks.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.SkinTxt.WaterText = "";
            this.skinTextBox_Remarks.TabIndex = 4;
            this.skinTextBox_Remarks.TabStop = true;
            this.skinTextBox_Remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Remarks.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.WaterText = "";
            this.skinTextBox_Remarks.WordWrap = true;
            // 
            // skinCheckBox_Enabled
            // 
            this.skinCheckBox_Enabled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBox_Enabled.AutoSize = true;
            this.skinCheckBox_Enabled.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox_Enabled.Checked = true;
            this.skinCheckBox_Enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox_Enabled.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox_Enabled.DownBack = null;
            this.skinCheckBox_Enabled.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox_Enabled.Location = new System.Drawing.Point(409, 177);
            this.skinCheckBox_Enabled.MouseBack = null;
            this.skinCheckBox_Enabled.Name = "skinCheckBox_Enabled";
            this.skinCheckBox_Enabled.NormlBack = null;
            this.skinCheckBox_Enabled.SelectedDownBack = null;
            this.skinCheckBox_Enabled.SelectedMouseBack = null;
            this.skinCheckBox_Enabled.SelectedNormlBack = null;
            this.skinCheckBox_Enabled.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBox_Enabled.TabIndex = 5;
            this.skinCheckBox_Enabled.Text = "启用";
            this.skinCheckBox_Enabled.UseVisualStyleBackColor = false;
            // 
            // skinLabel8
            // 
            this.skinLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(365, 179);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 136;
            this.skinLabel8.Text = "状态";
            // 
            // skinLabel6
            // 
            this.skinLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(365, 151);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 137;
            this.skinLabel6.Text = "备注";
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(551, 15);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(88, 26);
            this.skinLabel3.TabIndex = 135;
            this.skinLabel3.Text = "促销规则";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.BaseButton3);
            this.groupBox3.Controls.Add(this.skinLabelCostume);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1160, 80);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参与促销的商品";
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(1076, 28);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 9;
            this.BaseButton3.Text = "设置";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabelCostume
            // 
            this.skinLabelCostume.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skinLabelCostume.AutoSize = true;
            this.skinLabelCostume.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelCostume.BorderColor = System.Drawing.Color.White;
            this.skinLabelCostume.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelCostume.Location = new System.Drawing.Point(6, 28);
            this.skinLabelCostume.Name = "skinLabelCostume";
            this.skinLabelCostume.Size = new System.Drawing.Size(188, 17);
            this.skinLabelCostume.TabIndex = 150;
            this.skinLabelCostume.Text = "没有商品参与该促销活动，请添加";
            // 
            // BaseButton2
            // 
            this.BaseButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BaseButton2.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton2.Location = new System.Drawing.Point(545, 2);
            this.BaseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton2.Name = "BaseButton2";
            this.BaseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton2.Size = new System.Drawing.Size(75, 32);
            this.BaseButton2.TabIndex = 10;
            this.BaseButton2.Text = "保存";
            this.BaseButton2.UseVisualStyleBackColor = false;
            this.BaseButton2.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BaseButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 38);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 118);
            this.panel1.TabIndex = 2;
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.IsSplitterFixed = true;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 211);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.groupBoxShop);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.groupBoxRule);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 321);
            this.skinSplitContainer1.SplitterDistance = 572;
            this.skinSplitContainer1.TabIndex = 1;
            this.skinSplitContainer1.TabStop = false;
            // 
            // groupBoxShop
            // 
            this.groupBoxShop.Controls.Add(this.dataGridViewShop);
            this.groupBoxShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxShop.Location = new System.Drawing.Point(0, 0);
            this.groupBoxShop.Name = "groupBoxShop";
            this.groupBoxShop.Size = new System.Drawing.Size(572, 321);
            this.groupBoxShop.TabIndex = 1;
            this.groupBoxShop.TabStop = false;
            this.groupBoxShop.Text = "店铺设置";
            // 
            // dataGridViewShop
            // 
            this.dataGridViewShop.AllowUserToAddRows = false;
            this.dataGridViewShop.AllowUserToDeleteRows = false;
            this.dataGridViewShop.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5});
            this.dataGridViewShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShop.Location = new System.Drawing.Point(3, 17);
            this.dataGridViewShop.MultiSelect = false;
            this.dataGridViewShop.Name = "dataGridViewShop";
            this.dataGridViewShop.RowTemplate.Height = 23;
            this.dataGridViewShop.Size = new System.Drawing.Size(566, 301);
            this.dataGridViewShop.TabIndex = 7;
            // 
            // groupBoxRule
            // 
            this.groupBoxRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRule.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRule.Name = "groupBoxRule";
            this.groupBoxRule.Size = new System.Drawing.Size(584, 321);
            this.groupBoxRule.TabIndex = 2;
            this.groupBoxRule.TabStop = false;
            this.groupBoxRule.Text = "规则明细";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "店铺名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 445;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "Selected";
            this.Column5.FalseValue = "false";
            this.Column5.HeaderText = "是否参与";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Resizable= System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.TrueValue = "true";
            this.Column5.Width = 80;
            // 
            // groupBoxRule
            // 
            this.groupBoxRule.Controls.Add(this.discountRuleCtrl1);
            this.groupBoxRule.Controls.Add(this.mjRuleCtrl1);
            this.groupBoxRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRule.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRule.Name = "groupBoxRule";
            this.groupBoxRule.Size = new System.Drawing.Size(583, 321);
            this.groupBoxRule.TabIndex = 2;
            this.groupBoxRule.TabStop = false;
            this.groupBoxRule.Text = "规则明细";
            // 
            // discountRuleCtrl1
            // 
            this.discountRuleCtrl1.AutoSize = true;
            this.discountRuleCtrl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.discountRuleCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountRuleCtrl1.Location = new System.Drawing.Point(3, 17);
            this.discountRuleCtrl1.Name = "discountRuleCtrl1";
            this.discountRuleCtrl1.Result = null;
            this.discountRuleCtrl1.Size = new System.Drawing.Size(475, 201);
            this.discountRuleCtrl1.TabIndex = 8;
            // 
            // mjRuleCtrl1
            // 
            this.mjRuleCtrl1.AutoSize = true;
            this.mjRuleCtrl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mjRuleCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mjRuleCtrl1.Location = new System.Drawing.Point(3, 17);
            this.mjRuleCtrl1.Name = "mjRuleCtrl1";
            this.mjRuleCtrl1.Result = null;
            this.mjRuleCtrl1.Size = new System.Drawing.Size(475, 201);
            this.mjRuleCtrl1.TabIndex = 0;
            // 
            // SaveSalesPromotionCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "SaveSalesPromotionCtrl";
            this.Load += new System.EventHandler(this.SaveSalesPromotionCtrl_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.groupBoxRule.ResumeLayout(false);
            this.groupBoxRule.PerformLayout();
            this.skinSplitContainer1.ResumeLayout(false);
            this.groupBoxShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinComboBox skinComboBoxPromotionType;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private JGNet.Common.TextBox skinTextBox_Remarks;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox_Enabled;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private JGNet.Common.TextBox skinTextBox_Name;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private CCWin.SkinControl.SkinLabel skinLabelCostume;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginDate;
        private Common.Components.BaseButton BaseButton3;
        private Common.Components.BaseButton BaseButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private SplitContainer skinSplitContainer1;
        private System.Windows.Forms.GroupBox groupBoxShop;
        private System.Windows.Forms.DataGridView dataGridViewShop;
        private System.Windows.Forms.GroupBox groupBoxRule;
        private RuleSettings.SalesPromotion.DiscountRuleCtrl discountRuleCtrl1;
        private RuleSettings.SalesPromotion.MJRuleCtrl mjRuleCtrl1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewCheckBoxColumn Column5;
    }
}
