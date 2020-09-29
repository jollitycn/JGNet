using CCWin.SkinControl;

namespace JGNet.Manage.Components
{
    partial class WholesaleEmOrderFinishForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNotDeliver = new System.Windows.Forms.TabPage();
            this.tabPageCancel = new System.Windows.Forms.TabPage();
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPanelLogic = new CCWin.SkinControl.SkinPanel();
            this.baseButtonSaveLogistic = new JGNet.Common.Components.BaseButton();
            this.skinTextBoxLogisticId = new JGNet.Common.TextBox();
            this.skinTextBoxLogisticCompany = new CCWin.SkinControl.SkinComboBox();
            this.skinLabelLogisticCompany = new CCWin.SkinControl.SkinLabel();
            this.skinLabelLogisticId = new CCWin.SkinControl.SkinLabel();
            this.panel2 = new CCWin.SkinControl.SkinPanel();
            this.skinPanelBtn = new CCWin.SkinControl.SkinPanel();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelReceivedInfo = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelPayState = new CCWin.SkinControl.SkinLabel();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            this.skinPanelLogic.SuspendLayout();
            this.panel2.SuspendLayout();
            this.skinPanelBtn.SuspendLayout();
            this.skinPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNotDeliver);
            this.tabControl1.Controls.Add(this.tabPageCancel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(4, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 20);
            this.tabControl1.TabIndex = 120;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageNotDeliver
            // 
            this.tabPageNotDeliver.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotDeliver.Name = "tabPageNotDeliver";
            this.tabPageNotDeliver.Size = new System.Drawing.Size(843, 0);
            this.tabPageNotDeliver.TabIndex = 6;
            this.tabPageNotDeliver.Text = "未发货";
            this.tabPageNotDeliver.UseVisualStyleBackColor = true;
            // 
            // tabPageCancel
            // 
            this.tabPageCancel.Location = new System.Drawing.Point(4, 22);
            this.tabPageCancel.Name = "tabPageCancel";
            this.tabPageCancel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCancel.Size = new System.Drawing.Size(843, 0);
            this.tabPageCancel.TabIndex = 7;
            this.tabPageCancel.Text = "已取消";
            this.tabPageCancel.UseVisualStyleBackColor = true;
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.PfCustomerDetail);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SumMoney";
            this.dataGridViewTextBoxColumn1.HeaderText = "总金额";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 808;
            // 
            // skinPanelLogic
            // 
            this.skinPanelLogic.BackColor = System.Drawing.Color.Transparent;
            this.skinPanelLogic.Controls.Add(this.baseButtonSaveLogistic);
            this.skinPanelLogic.Controls.Add(this.skinTextBoxLogisticId);
            this.skinPanelLogic.Controls.Add(this.skinTextBoxLogisticCompany);
            this.skinPanelLogic.Controls.Add(this.skinLabelLogisticCompany);
            this.skinPanelLogic.Controls.Add(this.skinLabelLogisticId);
            this.skinPanelLogic.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanelLogic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanelLogic.DownBack = null;
            this.skinPanelLogic.Location = new System.Drawing.Point(0, 0);
            this.skinPanelLogic.MouseBack = null;
            this.skinPanelLogic.Name = "skinPanelLogic";
            this.skinPanelLogic.NormlBack = null;
            this.skinPanelLogic.Size = new System.Drawing.Size(851, 121);
            this.skinPanelLogic.TabIndex = 165;
            // 
            // baseButtonSaveLogistic
            // 
            this.baseButtonSaveLogistic.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSaveLogistic.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSaveLogistic.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonSaveLogistic.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSaveLogistic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSaveLogistic.Location = new System.Drawing.Point(278, 60);
            this.baseButtonSaveLogistic.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonSaveLogistic.Name = "baseButtonSaveLogistic";
            this.baseButtonSaveLogistic.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonSaveLogistic.Size = new System.Drawing.Size(75, 32);
            this.baseButtonSaveLogistic.TabIndex = 168;
            this.baseButtonSaveLogistic.Text = "保存";
            this.baseButtonSaveLogistic.UseVisualStyleBackColor = false;
            this.baseButtonSaveLogistic.Click += new System.EventHandler(this.baseButtonSaveLogistic_Click);
            // 
            // skinTextBoxLogisticId
            // 
            this.skinTextBoxLogisticId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTextBoxLogisticId.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxLogisticId.DownBack = null;
            this.skinTextBoxLogisticId.Icon = null;
            this.skinTextBoxLogisticId.IconIsButton = false;
            this.skinTextBoxLogisticId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxLogisticId.IsPasswordChat = '\0';
            this.skinTextBoxLogisticId.IsSystemPasswordChar = false;
            this.skinTextBoxLogisticId.Lines = new string[0];
            this.skinTextBoxLogisticId.Location = new System.Drawing.Point(68, 29);
            this.skinTextBoxLogisticId.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxLogisticId.MaxLength = 32767;
            this.skinTextBoxLogisticId.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxLogisticId.MouseBack = null;
            this.skinTextBoxLogisticId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxLogisticId.Multiline = false;
            this.skinTextBoxLogisticId.Name = "skinTextBoxLogisticId";
            this.skinTextBoxLogisticId.NormlBack = null;
            this.skinTextBoxLogisticId.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxLogisticId.ReadOnly = false;
            this.skinTextBoxLogisticId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxLogisticId.Size = new System.Drawing.Size(285, 28);
            // 
            // 
            // 
            this.skinTextBoxLogisticId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxLogisticId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxLogisticId.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxLogisticId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxLogisticId.SkinTxt.Name = "BaseText";
            this.skinTextBoxLogisticId.SkinTxt.Size = new System.Drawing.Size(275, 18);
            this.skinTextBoxLogisticId.SkinTxt.TabIndex = 0;
            this.skinTextBoxLogisticId.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxLogisticId.SkinTxt.WaterText = "";
            this.skinTextBoxLogisticId.TabIndex = 167;
            this.skinTextBoxLogisticId.TabStop = true;
            this.skinTextBoxLogisticId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxLogisticId.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxLogisticId.WaterText = "";
            this.skinTextBoxLogisticId.WordWrap = true;
            // 
            // skinTextBoxLogisticCompany
            // 
            this.skinTextBoxLogisticCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTextBoxLogisticCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinTextBoxLogisticCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinTextBoxLogisticCompany.FormattingEnabled = true;
            this.skinTextBoxLogisticCompany.Location = new System.Drawing.Point(68, 4);
            this.skinTextBoxLogisticCompany.Name = "skinTextBoxLogisticCompany";
            this.skinTextBoxLogisticCompany.Size = new System.Drawing.Size(285, 22);
            this.skinTextBoxLogisticCompany.TabIndex = 166;
            this.skinTextBoxLogisticCompany.WaterText = "";
            // 
            // skinLabelLogisticCompany
            // 
            this.skinLabelLogisticCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabelLogisticCompany.AutoSize = true;
            this.skinLabelLogisticCompany.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelLogisticCompany.BorderColor = System.Drawing.Color.White;
            this.skinLabelLogisticCompany.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelLogisticCompany.Location = new System.Drawing.Point(3, 9);
            this.skinLabelLogisticCompany.Name = "skinLabelLogisticCompany";
            this.skinLabelLogisticCompany.Size = new System.Drawing.Size(56, 17);
            this.skinLabelLogisticCompany.TabIndex = 165;
            this.skinLabelLogisticCompany.Text = "物流公司";
            // 
            // skinLabelLogisticId
            // 
            this.skinLabelLogisticId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLabelLogisticId.AutoSize = true;
            this.skinLabelLogisticId.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelLogisticId.BorderColor = System.Drawing.Color.White;
            this.skinLabelLogisticId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelLogisticId.Location = new System.Drawing.Point(3, 35);
            this.skinLabelLogisticId.Name = "skinLabelLogisticId";
            this.skinLabelLogisticId.Size = new System.Drawing.Size(56, 17);
            this.skinLabelLogisticId.TabIndex = 164;
            this.skinLabelLogisticId.Text = "物流单号";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.skinPanelLogic);
            this.panel2.Controls.Add(this.skinPanelBtn);
            this.panel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.DownBack = null;
            this.panel2.Location = new System.Drawing.Point(4, 439);
            this.panel2.MouseBack = null;
            this.panel2.Name = "panel2";
            this.panel2.NormlBack = null;
            this.panel2.Size = new System.Drawing.Size(851, 121);
            this.panel2.TabIndex = 122;
            // 
            // skinPanelBtn
            // 
            this.skinPanelBtn.BackColor = System.Drawing.Color.Transparent;
            this.skinPanelBtn.Controls.Add(this.baseButtonCancel);
            this.skinPanelBtn.Controls.Add(this.baseButton1);
            this.skinPanelBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanelBtn.DownBack = null;
            this.skinPanelBtn.Location = new System.Drawing.Point(0, 0);
            this.skinPanelBtn.MouseBack = null;
            this.skinPanelBtn.Name = "skinPanelBtn";
            this.skinPanelBtn.NormlBack = null;
            this.skinPanelBtn.Size = new System.Drawing.Size(851, 121);
            this.skinPanelBtn.TabIndex = 170;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(84, 3);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 168;
            this.baseButtonCancel.Text = "作废";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(3, 3);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 168;
            this.baseButton1.Text = "发货";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.BaseButtonConfirm_Click);
            // 
            // skinPanel4
            // 
            this.skinPanel4.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel4.Controls.Add(this.dataGridView1);
            this.skinPanel4.Controls.Add(this.skinPanel3);
            this.skinPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel4.DownBack = null;
            this.skinPanel4.Location = new System.Drawing.Point(4, 48);
            this.skinPanel4.MouseBack = null;
            this.skinPanel4.Name = "skinPanel4";
            this.skinPanel4.NormlBack = null;
            this.skinPanel4.Size = new System.Drawing.Size(851, 391);
            this.skinPanel4.TabIndex = 169;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.countDataGridViewTextBoxColumn,
            this.SumMoney});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(851, 321);
            this.dataGridView1.TabIndex = 172;
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.skinLabel2);
            this.skinPanel3.Controls.Add(this.skinLabel1);
            this.skinPanel3.Controls.Add(this.skinLabel4);
            this.skinPanel3.Controls.Add(this.skinLabelReceivedInfo);
            this.skinPanel3.Controls.Add(this.skinLabel3);
            this.skinPanel3.Controls.Add(this.skinLabelPayState);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(0, 321);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(851, 70);
            this.skinPanel3.TabIndex = 171;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(65, 47);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 165;
            this.skinLabel2.Text = "付款状态";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(27, 47);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 164;
            this.skinLabel1.Text = "备注";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(4, 4);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 162;
            this.skinLabel4.Text = "收货信息";
            // 
            // skinLabelReceivedInfo
            // 
            this.skinLabelReceivedInfo.AutoSize = true;
            this.skinLabelReceivedInfo.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelReceivedInfo.BorderColor = System.Drawing.Color.White;
            this.skinLabelReceivedInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelReceivedInfo.Location = new System.Drawing.Point(66, 4);
            this.skinLabelReceivedInfo.Name = "skinLabelReceivedInfo";
            this.skinLabelReceivedInfo.Size = new System.Drawing.Size(56, 17);
            this.skinLabelReceivedInfo.TabIndex = 163;
            this.skinLabelReceivedInfo.Text = "付款状态";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(4, 25);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(56, 17);
            this.skinLabel3.TabIndex = 162;
            this.skinLabel3.Text = "付款状态";
            // 
            // skinLabelPayState
            // 
            this.skinLabelPayState.AutoSize = true;
            this.skinLabelPayState.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelPayState.BorderColor = System.Drawing.Color.White;
            this.skinLabelPayState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelPayState.Location = new System.Drawing.Point(66, 25);
            this.skinLabelPayState.Name = "skinLabelPayState";
            this.skinLabelPayState.Size = new System.Drawing.Size(56, 17);
            this.skinLabelPayState.TabIndex = 163;
            this.skinLabelPayState.Text = "付款状态";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CostumeID";
            this.dataGridViewTextBoxColumn2.HeaderText = "款号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CostumeName";
            this.dataGridViewTextBoxColumn3.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ColorName";
            this.dataGridViewTextBoxColumn4.HeaderText = "颜色";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SizeDisplayName";
            this.dataGridViewTextBoxColumn5.HeaderText = "尺码";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PfPrice";
            this.dataGridViewTextBoxColumn6.HeaderText = "批发价";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "数量";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 116;
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
            // WholesaleEmOrderFinishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 564);
            this.Controls.Add(this.skinPanel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WholesaleEmOrderFinishForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "订单详情";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EmOrderLogisticsForm_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            this.skinPanelLogic.ResumeLayout(false);
            this.skinPanelLogic.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.skinPanelBtn.ResumeLayout(false);
            this.skinPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNotDeliver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPageCancel;
        private SkinPanel skinPanelLogic;
        private Common.Components.BaseButton baseButtonSaveLogistic;
        private Common.TextBox skinTextBoxLogisticId;
        private SkinComboBox skinTextBoxLogisticCompany;
        private SkinLabel skinLabelLogisticCompany;
        private SkinLabel skinLabelLogisticId;
        private SkinPanel panel2;
        private SkinPanel skinPanelBtn;
        private Common.Components.BaseButton baseButtonCancel;
        private Common.Components.BaseButton baseButton1;
        private SkinPanel skinPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SkinPanel skinPanel3;
        private SkinLabel skinLabel4;
        private SkinLabel skinLabelReceivedInfo;
        private SkinLabel skinLabel3;
        private SkinLabel skinLabelPayState;
        private SkinLabel skinLabel2;
        private SkinLabel skinLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumMoney;
    }
}