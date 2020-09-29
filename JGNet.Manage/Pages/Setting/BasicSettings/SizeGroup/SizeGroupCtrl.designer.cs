namespace JGNet.Common
{
    partial class SizeGroupCtrl
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
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinPanelSendGift = new System.Windows.Forms.Panel();
            this.sizeGroupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfXSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfXLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfXL2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfXL3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfXL4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfXL5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfXL6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource3)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.dataGridView1);
            this.skinPanel2.Controls.Add(this.skinPanel1);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1231, 650);
            this.skinPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sizeGroupNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.nameOfFDataGridViewTextBoxColumn,
            this.nameOfXSDataGridViewTextBoxColumn,
            this.nameOfSDataGridViewTextBoxColumn,
            this.nameOfMDataGridViewTextBoxColumn,
            this.nameOfLDataGridViewTextBoxColumn,
            this.nameOfXLDataGridViewTextBoxColumn,
            this.nameOfXL2DataGridViewTextBoxColumn,
            this.nameOfXL3DataGridViewTextBoxColumn,
            this.nameOfXL4DataGridViewTextBoxColumn,
            this.nameOfXL5DataGridViewTextBoxColumn,
            this.nameOfXL6DataGridViewTextBoxColumn,
            this.enabledDataGridViewCheckBoxColumn,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridView1.DataSource = this.memberBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1231, 610);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // memberBindingSource3
            // 
            this.memberBindingSource3.DataSource = typeof(JGNet.SizeGroup);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1231, 40);
            this.skinPanel1.TabIndex = 52;
            // 
            // baseButton1
            // 
            this.baseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(1120, 5);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 150;
            this.baseButton1.Text = "导出";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(1029, 5);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "添加";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton3_Click);
            // 
            // skinPanelSendGift
            // 
            this.skinPanelSendGift.AutoSize = true;
            this.skinPanelSendGift.BackColor = System.Drawing.Color.Transparent;
            this.skinPanelSendGift.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanelSendGift.Location = new System.Drawing.Point(0, 0);
            this.skinPanelSendGift.Name = "skinPanelSendGift";
            this.skinPanelSendGift.Size = new System.Drawing.Size(1231, 0);
            this.skinPanelSendGift.TabIndex = 0;
            // 
            // sizeGroupNameDataGridViewTextBoxColumn
            // 
            this.sizeGroupNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeGroupNameDataGridViewTextBoxColumn.DataPropertyName = "ShowName";
            this.sizeGroupNameDataGridViewTextBoxColumn.FillWeight = 90F;
            this.sizeGroupNameDataGridViewTextBoxColumn.HeaderText = "尺码组名称";
            this.sizeGroupNameDataGridViewTextBoxColumn.Name = "sizeGroupNameDataGridViewTextBoxColumn";
            this.sizeGroupNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeGroupNameDataGridViewTextBoxColumn.Width = 90;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.FillWeight = 90F;
            this.commentDataGridViewTextBoxColumn.HeaderText = "说明";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameOfFDataGridViewTextBoxColumn
            // 
            this.nameOfFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfFDataGridViewTextBoxColumn.DataPropertyName = "NameOfF";
            this.nameOfFDataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfFDataGridViewTextBoxColumn.HeaderText = "尺码1";
            this.nameOfFDataGridViewTextBoxColumn.MinimumWidth = 4;
            this.nameOfFDataGridViewTextBoxColumn.Name = "nameOfFDataGridViewTextBoxColumn";
            this.nameOfFDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfFDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfXSDataGridViewTextBoxColumn
            // 
            this.nameOfXSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfXSDataGridViewTextBoxColumn.DataPropertyName = "NameOfXS";
            this.nameOfXSDataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfXSDataGridViewTextBoxColumn.HeaderText = "尺码2";
            this.nameOfXSDataGridViewTextBoxColumn.Name = "nameOfXSDataGridViewTextBoxColumn";
            this.nameOfXSDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfXSDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfSDataGridViewTextBoxColumn
            // 
            this.nameOfSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfSDataGridViewTextBoxColumn.DataPropertyName = "NameOfS";
            this.nameOfSDataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfSDataGridViewTextBoxColumn.HeaderText = "尺码3";
            this.nameOfSDataGridViewTextBoxColumn.Name = "nameOfSDataGridViewTextBoxColumn";
            this.nameOfSDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfSDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfMDataGridViewTextBoxColumn
            // 
            this.nameOfMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfMDataGridViewTextBoxColumn.DataPropertyName = "NameOfM";
            this.nameOfMDataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfMDataGridViewTextBoxColumn.HeaderText = "尺码4";
            this.nameOfMDataGridViewTextBoxColumn.Name = "nameOfMDataGridViewTextBoxColumn";
            this.nameOfMDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfMDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfLDataGridViewTextBoxColumn
            // 
            this.nameOfLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfLDataGridViewTextBoxColumn.DataPropertyName = "NameOfL";
            this.nameOfLDataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfLDataGridViewTextBoxColumn.HeaderText = "尺码5";
            this.nameOfLDataGridViewTextBoxColumn.Name = "nameOfLDataGridViewTextBoxColumn";
            this.nameOfLDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfLDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfXLDataGridViewTextBoxColumn
            // 
            this.nameOfXLDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfXLDataGridViewTextBoxColumn.DataPropertyName = "NameOfXL";
            this.nameOfXLDataGridViewTextBoxColumn.HeaderText = "尺码6";
            this.nameOfXLDataGridViewTextBoxColumn.Name = "nameOfXLDataGridViewTextBoxColumn";
            this.nameOfXLDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfXLDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfXL2DataGridViewTextBoxColumn
            // 
            this.nameOfXL2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfXL2DataGridViewTextBoxColumn.DataPropertyName = "NameOfXL2";
            this.nameOfXL2DataGridViewTextBoxColumn.HeaderText = "尺码7";
            this.nameOfXL2DataGridViewTextBoxColumn.Name = "nameOfXL2DataGridViewTextBoxColumn";
            this.nameOfXL2DataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfXL2DataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfXL3DataGridViewTextBoxColumn
            // 
            this.nameOfXL3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfXL3DataGridViewTextBoxColumn.DataPropertyName = "NameOfXL3";
            this.nameOfXL3DataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfXL3DataGridViewTextBoxColumn.HeaderText = "尺码8";
            this.nameOfXL3DataGridViewTextBoxColumn.Name = "nameOfXL3DataGridViewTextBoxColumn";
            this.nameOfXL3DataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfXL3DataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfXL4DataGridViewTextBoxColumn
            // 
            this.nameOfXL4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfXL4DataGridViewTextBoxColumn.DataPropertyName = "NameOfXL4";
            this.nameOfXL4DataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfXL4DataGridViewTextBoxColumn.HeaderText = "尺码9";
            this.nameOfXL4DataGridViewTextBoxColumn.Name = "nameOfXL4DataGridViewTextBoxColumn";
            this.nameOfXL4DataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfXL4DataGridViewTextBoxColumn.Width = 60;
            // 
            // nameOfXL5DataGridViewTextBoxColumn
            // 
            this.nameOfXL5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfXL5DataGridViewTextBoxColumn.DataPropertyName = "NameOfXL5";
            this.nameOfXL5DataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfXL5DataGridViewTextBoxColumn.HeaderText = "尺码10";
            this.nameOfXL5DataGridViewTextBoxColumn.Name = "nameOfXL5DataGridViewTextBoxColumn";
            this.nameOfXL5DataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfXL5DataGridViewTextBoxColumn.Width = 66;
            // 
            // nameOfXL6DataGridViewTextBoxColumn
            // 
            this.nameOfXL6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameOfXL6DataGridViewTextBoxColumn.DataPropertyName = "NameOfXL6";
            this.nameOfXL6DataGridViewTextBoxColumn.FillWeight = 90F;
            this.nameOfXL6DataGridViewTextBoxColumn.HeaderText = "尺码11";
            this.nameOfXL6DataGridViewTextBoxColumn.Name = "nameOfXL6DataGridViewTextBoxColumn";
            this.nameOfXL6DataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfXL6DataGridViewTextBoxColumn.Width = 66;
            // 
            // enabledDataGridViewCheckBoxColumn
            // 
            this.enabledDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.FalseValue = "False";
            this.enabledDataGridViewCheckBoxColumn.HeaderText = "启用";
            this.enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
            this.enabledDataGridViewCheckBoxColumn.ReadOnly = true;
            this.enabledDataGridViewCheckBoxColumn.TrueValue = "True";
            this.enabledDataGridViewCheckBoxColumn.Width = 35;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnEdit.HeaderText = "编辑";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Text = "编辑";
            this.ColumnEdit.UseColumnTextForLinkValue = true;
            this.ColumnEdit.Width = 40;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDelete.DataPropertyName = "DisplayName";
            this.ColumnDelete.HeaderText = "删除";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "删除";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // SizeGroupCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanelSendGift);
            this.Name = "SizeGroupCtrl";
            this.Size = new System.Drawing.Size(1231, 650);
            this.Load += new System.EventHandler(this.SizeGroupCtrl_Load);
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource3)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel skinPanelSendGift;
        private System.Windows.Forms.Panel skinPanel2;
        private System.Windows.Forms.BindingSource memberBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel skinPanel1;
        private Components.BaseButton BaseButton3;
        private Components.BaseButton baseButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeGroupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfXSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfXLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfXL2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfXL3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfXL4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfXL5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfXL6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
    }
}
