using CCWin.SkinControl;

namespace JGNet.Manage
{
    partial class TiDanForm
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
            this.dataGridView_HangedOrder = new System.Windows.Forms.DataGridView();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.hangedOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.BaseButton_Cancel = new JGNet.Common.Components.BaseButton();
            this.BaseButton_Select = new JGNet.Common.Components.BaseButton();
            this.dataGridView_Detail = new System.Windows.Forms.DataGridView();
            this.retailDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeDisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HangedOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangedOrderBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_HangedOrder
            // 
            this.dataGridView_HangedOrder.AllowUserToAddRows = false;
            this.dataGridView_HangedOrder.AllowUserToDeleteRows = false;
            this.dataGridView_HangedOrder.AutoGenerateColumns = false;
            this.dataGridView_HangedOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_HangedOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HangedOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createTimeDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.totalMoneyDataGridViewTextBoxColumn,
            this.totalCountDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView_HangedOrder.DataSource = this.hangedOrderBindingSource;
            this.dataGridView_HangedOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_HangedOrder.Location = new System.Drawing.Point(4, 28);
            this.dataGridView_HangedOrder.Name = "dataGridView_HangedOrder";
            this.dataGridView_HangedOrder.ReadOnly = true;
            this.dataGridView_HangedOrder.RowHeadersVisible = false;
            this.dataGridView_HangedOrder.RowTemplate.Height = 23;
            this.dataGridView_HangedOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_HangedOrder.Size = new System.Drawing.Size(632, 229);
            this.dataGridView_HangedOrder.TabIndex = 0;
            this.dataGridView_HangedOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_HangedOrder_CellContentClick);
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "挂单时间";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "会员卡号";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Width = 120;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "会员姓名";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalMoneyDataGridViewTextBoxColumn
            // 
            this.totalMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalMoneyDataGridViewTextBoxColumn.DataPropertyName = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.totalMoneyDataGridViewTextBoxColumn.Name = "totalMoneyDataGridViewTextBoxColumn";
            this.totalMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalMoneyDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalCountDataGridViewTextBoxColumn
            // 
            this.totalCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalCountDataGridViewTextBoxColumn.DataPropertyName = "TotalCount";
            this.totalCountDataGridViewTextBoxColumn.HeaderText = "总数量";
            this.totalCountDataGridViewTextBoxColumn.Name = "totalCountDataGridViewTextBoxColumn";
            this.totalCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCountDataGridViewTextBoxColumn.Width = 120;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MemberID";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Text = "删除";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 50;
            // 
            // hangedOrderBindingSource
            // 
            this.hangedOrderBindingSource.DataSource = typeof(JGNet.Manage.HangedOrder);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.BaseButton_Cancel);
            this.skinPanel1.Controls.Add(this.BaseButton_Select);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 530);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(632, 50);
            this.skinPanel1.TabIndex = 1;
            // 
            // BaseButton_Cancel
            // 
            this.BaseButton_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Cancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Cancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Cancel.Location = new System.Drawing.Point(554, 6);
            this.BaseButton_Cancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Cancel.Name = "BaseButton_Cancel";
            this.BaseButton_Cancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Cancel.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Cancel.TabIndex = 3;
            this.BaseButton_Cancel.Text = "取消";
            this.BaseButton_Cancel.UseVisualStyleBackColor = false;
            this.BaseButton_Cancel.Click += new System.EventHandler(this.BaseButton_Cancel_Click);
            // 
            // BaseButton_Select
            // 
            this.BaseButton_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton_Select.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Select.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Select.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Select.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Select.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Select.Location = new System.Drawing.Point(473, 6);
            this.BaseButton_Select.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Select.Name = "BaseButton_Select";
            this.BaseButton_Select.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Select.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Select.TabIndex = 2;
            this.BaseButton_Select.Text = "选择";
            this.BaseButton_Select.UseVisualStyleBackColor = false;
            this.BaseButton_Select.Click += new System.EventHandler(this.BaseButton_Select_Click);
            // 
            // dataGridView_Detail
            // 
            this.dataGridView_Detail.AllowUserToAddRows = false;
            this.dataGridView_Detail.AllowUserToDeleteRows = false;
            this.dataGridView_Detail.AutoGenerateColumns = false;
            this.dataGridView_Detail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.costumeNameDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.SizeDisplayName,
            this.buyCountDataGridViewTextBoxColumn,
            this.sumMoneyDataGridViewTextBoxColumn});
            this.dataGridView_Detail.DataSource = this.retailDetailBindingSource;
            this.dataGridView_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Detail.Location = new System.Drawing.Point(4, 257);
            this.dataGridView_Detail.Name = "dataGridView_Detail";
            this.dataGridView_Detail.ReadOnly = true;
            this.dataGridView_Detail.RowHeadersVisible = false;
            this.dataGridView_Detail.RowTemplate.Height = 23;
            this.dataGridView_Detail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Detail.Size = new System.Drawing.Size(632, 273);
            this.dataGridView_Detail.TabIndex = 1;
            // 
            // retailDetailBindingSource
            // 
            this.retailDetailBindingSource.DataSource = typeof(JGNet.RetailDetail);
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costumeNameDataGridViewTextBoxColumn
            // 
            this.costumeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeNameDataGridViewTextBoxColumn.DataPropertyName = "CostumeName";
            this.costumeNameDataGridViewTextBoxColumn.HeaderText = "服装名称";
            this.costumeNameDataGridViewTextBoxColumn.Name = "costumeNameDataGridViewTextBoxColumn";
            this.costumeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "吊牌价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SizeDisplayName
            // 
            this.SizeDisplayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SizeDisplayName.DataPropertyName = "SizeDisplayName";
            this.SizeDisplayName.HeaderText = "尺码";
            this.SizeDisplayName.Name = "SizeDisplayName";
            this.SizeDisplayName.ReadOnly = true;
            this.SizeDisplayName.Width = 90;
            // 
            // buyCountDataGridViewTextBoxColumn
            // 
            this.buyCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.buyCountDataGridViewTextBoxColumn.DataPropertyName = "BuyCount";
            this.buyCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.buyCountDataGridViewTextBoxColumn.Name = "buyCountDataGridViewTextBoxColumn";
            this.buyCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.buyCountDataGridViewTextBoxColumn.Width = 90;
            // 
            // sumMoneyDataGridViewTextBoxColumn
            // 
            this.sumMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sumMoneyDataGridViewTextBoxColumn.DataPropertyName = "SumMoney";
            this.sumMoneyDataGridViewTextBoxColumn.HeaderText = "金额";
            this.sumMoneyDataGridViewTextBoxColumn.Name = "sumMoneyDataGridViewTextBoxColumn";
            this.sumMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumMoneyDataGridViewTextBoxColumn.Width = 54;
            // 
            // TiDanForm
            // 
            this.AcceptButton = this.BaseButton_Select;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 584);
            this.Controls.Add(this.dataGridView_Detail);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.dataGridView_HangedOrder);
            this.Name = "TiDanForm";
            this.Text = "提单";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HangedOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangedOrderBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_HangedOrder;
        private SkinPanel skinPanel1;
        private System.Windows.Forms.BindingSource hangedOrderBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_Detail;
        private Common.Components.BaseButton BaseButton_Cancel;
        private Common.Components.BaseButton BaseButton_Select;
        private System.Windows.Forms.BindingSource retailDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumMoneyDataGridViewTextBoxColumn;
    }
}