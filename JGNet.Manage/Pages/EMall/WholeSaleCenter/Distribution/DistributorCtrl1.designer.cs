namespace JGNet.Manage
{
    partial class DistributorCtrl1
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.guideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxName = new JGNet.Common.TextBox();
            this.RuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonateMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccruedCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WithdrawCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOffline = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnNewOffline = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guideBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RuleName,
            this.DonateMoney,
            this.AccruedCommission,
            this.RemainingCommission,
            this.WithdrawCommission,
            this.ColumnOffline,
            this.ColumnEdit,
            this.ColumnNewOffline});
            this.dataGridView.DataSource = this.guideBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 35);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1160, 615);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // guideBindingSource
            // 
            this.guideBindingSource.DataSource = typeof(JGNet.Distributor);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinTextBoxName);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 35);
            this.skinPanel1.TabIndex = 2;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(234, 1);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 2;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButtonQuery_Click);
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(315, 1);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 3;
            this.BaseButton3.Text = "添加";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButtonAdd_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 9);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(61, 17);
            this.skinLabel1.TabIndex = 97;
            this.skinLabel1.Text = "编号/姓名";
            // 
            // skinTextBoxName
            // 
            this.skinTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxName.DownBack = null;
            this.skinTextBoxName.Icon = null;
            this.skinTextBoxName.IconIsButton = false;
            this.skinTextBoxName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.IsPasswordChat = '\0';
            this.skinTextBoxName.IsSystemPasswordChar = false;
            this.skinTextBoxName.Lines = new string[0];
            this.skinTextBoxName.Location = new System.Drawing.Point(67, 4);
            this.skinTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxName.MaxLength = 32767;
            this.skinTextBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxName.MouseBack = null;
            this.skinTextBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.Multiline = false;
            this.skinTextBoxName.Name = "skinTextBoxName";
            this.skinTextBoxName.NormlBack = null;
            this.skinTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxName.ReadOnly = false;
            this.skinTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxName.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.skinTextBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxName.SkinTxt.Name = "BaseText";
            this.skinTextBoxName.SkinTxt.Size = new System.Drawing.Size(154, 18);
            this.skinTextBoxName.SkinTxt.TabIndex = 0;
            this.skinTextBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.SkinTxt.WaterText = "编号/姓名";
            this.skinTextBoxName.TabIndex = 0;
            this.skinTextBoxName.TabStop = true;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "编号/姓名";
            this.skinTextBoxName.WordWrap = true;
            // 
            // RuleName
            // 
            this.RuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RuleName.DataPropertyName = "ID";
            this.RuleName.HeaderText = "编号";
            this.RuleName.Name = "RuleName";
            this.RuleName.ReadOnly = true;
            this.RuleName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RuleName.Width = 155;
            // 
            // DonateMoney
            // 
            this.DonateMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonateMoney.DataPropertyName = "Name";
            this.DonateMoney.HeaderText = "姓名";
            this.DonateMoney.Name = "DonateMoney";
            this.DonateMoney.ReadOnly = true;
            this.DonateMoney.Width = 154;
            // 
            // AccruedCommission
            // 
            this.AccruedCommission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AccruedCommission.DataPropertyName = "AccruedCommission";
            this.AccruedCommission.HeaderText = "累计佣金";
            this.AccruedCommission.Name = "AccruedCommission";
            this.AccruedCommission.ReadOnly = true;
            this.AccruedCommission.Width = 155;
            // 
            // RemainingCommission
            // 
            this.RemainingCommission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RemainingCommission.DataPropertyName = "RemainingCommission";
            this.RemainingCommission.HeaderText = "可提现佣金";
            this.RemainingCommission.Name = "RemainingCommission";
            this.RemainingCommission.ReadOnly = true;
            this.RemainingCommission.Width = 154;
            // 
            // WithdrawCommission
            // 
            this.WithdrawCommission.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WithdrawCommission.DataPropertyName = "WithdrawCommission";
            this.WithdrawCommission.HeaderText = "已提现佣金";
            this.WithdrawCommission.Name = "WithdrawCommission";
            this.WithdrawCommission.ReadOnly = true;
            this.WithdrawCommission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WithdrawCommission.Width = 155;
            // 
            // ColumnOffline
            // 
            this.ColumnOffline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnOffline.DataPropertyName = "PfCustomerCount";
            this.ColumnOffline.HeaderText = "下线客户";
            this.ColumnOffline.Name = "ColumnOffline";
            this.ColumnOffline.ReadOnly = true;
            this.ColumnOffline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnOffline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnOffline.Width = 154;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEdit.HeaderText = "编辑";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEdit.Text = "编辑";
            this.ColumnEdit.UseColumnTextForLinkValue = true;
            this.ColumnEdit.Width = 35;
            // 
            // ColumnNewOffline
            // 
            this.ColumnNewOffline.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnNewOffline.HeaderText = "新增下线";
            this.ColumnNewOffline.Name = "ColumnNewOffline";
            this.ColumnNewOffline.ReadOnly = true;
            this.ColumnNewOffline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNewOffline.Text = "新增下线";
            this.ColumnNewOffline.UseColumnTextForLinkValue = true;
            this.ColumnNewOffline.Width = 155;
            // 
            // DistributorCtrl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.skinPanel1);
            this.Name = "DistributorCtrl1";
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guideBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private JGNet.Common.TextBox skinTextBoxName;
        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource guideBindingSource;
        private Common.Components.BaseButton BaseButton1;
        private Common.Components.BaseButton BaseButton3;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonateMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccruedCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn WithdrawCommission;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnOffline;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnNewOffline;
    }
}
