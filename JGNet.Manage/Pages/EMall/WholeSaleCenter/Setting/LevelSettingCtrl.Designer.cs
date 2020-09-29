using System.Windows.Forms;

namespace JGNet.Manage 
{
    partial class LevelSettingCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelSettingCtrl));
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Level = new CCWin.SkinControl.SkinComboBox();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.commissionTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.baseButtonSave = new JGNet.Common.Components.BaseButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDefaultDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionTemplateBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel10
            // 
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.Location = new System.Drawing.Point(13, 16);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(68, 17);
            this.skinLabel10.TabIndex = 19;
            this.skinLabel10.Text = "分销层级：";
            // 
            // skinComboBox_Level
            // 
            this.skinComboBox_Level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Level.FormattingEnabled = true;
            this.skinComboBox_Level.Location = new System.Drawing.Point(86, 12);
            this.skinComboBox_Level.Name = "skinComboBox_Level";
            this.skinComboBox_Level.Size = new System.Drawing.Size(178, 22);
            this.skinComboBox_Level.TabIndex = 1;
            this.skinComboBox_Level.WaterText = "";
            this.skinComboBox_Level.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_giftTicket_SelectedIndexChanged);
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.panel2);
            this.skinSplitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1193, 650);
            this.skinSplitContainer1.SplitterDistance = 712;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 181;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 595);
            this.panel2.TabIndex = 188;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.firstRateDataGridViewTextBoxColumn,
            this.rate1DataGridViewTextBoxColumn,
            this.rate2DataGridViewTextBoxColumn,
            this.rate3DataGridViewTextBoxColumn,
            this.rate4DataGridViewTextBoxColumn,
            this.rate5DataGridViewTextBoxColumn,
            this.rate6DataGridViewTextBoxColumn,
            this.rate7DataGridViewTextBoxColumn,
            this.rate8DataGridViewTextBoxColumn,
            this.rate9DataGridViewTextBoxColumn,
            this.rate10DataGridViewTextBoxColumn,
            this.isDefaultDataGridViewCheckBoxColumn,
            this.Column1,
            this.ColumnDelete});
            this.dataGridView1.DataSource = this.commissionTemplateBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(712, 595);
            this.dataGridView1.TabIndex = 186;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // commissionTemplateBindingSource
            // 
            this.commissionTemplateBindingSource.DataSource = typeof(JGNet.CommissionTemplate);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.baseButton1);
            this.panel1.Controls.Add(this.baseButtonSave);
            this.panel1.Controls.Add(this.skinComboBox_Level);
            this.panel1.Controls.Add(this.skinLabel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 55);
            this.panel1.TabIndex = 187;
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.DownBack")));
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(270, 8);
            this.baseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.MouseBack")));
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.NormlBack")));
            this.baseButton1.Size = new System.Drawing.Size(76, 32);
            this.baseButton1.TabIndex = 186;
            this.baseButton1.Text = "保存";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSave.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonSave.DownBack")));
            this.baseButtonSave.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSave.Location = new System.Drawing.Point(352, 8);
            this.baseButtonSave.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonSave.MouseBack")));
            this.baseButtonSave.Name = "baseButtonSave";
            this.baseButtonSave.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonSave.NormlBack")));
            this.baseButtonSave.Size = new System.Drawing.Size(99, 32);
            this.baseButtonSave.TabIndex = 185;
            this.baseButtonSave.Text = "新增分销模板";
            this.baseButtonSave.UseVisualStyleBackColor = false;
            this.baseButtonSave.Click += new System.EventHandler(this.baseButtonSave_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::JGNet.Manage.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 650);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "模板名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstRateDataGridViewTextBoxColumn
            // 
            this.firstRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.firstRateDataGridViewTextBoxColumn.DataPropertyName = "FirstRate";
            this.firstRateDataGridViewTextBoxColumn.HeaderText = "第一次抽成";
            this.firstRateDataGridViewTextBoxColumn.Name = "firstRateDataGridViewTextBoxColumn";
            this.firstRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstRateDataGridViewTextBoxColumn.Width = 80;
            // 
            // rate1DataGridViewTextBoxColumn
            // 
            this.rate1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate1DataGridViewTextBoxColumn.DataPropertyName = "Rate1";
            this.rate1DataGridViewTextBoxColumn.HeaderText = "一级";
            this.rate1DataGridViewTextBoxColumn.Name = "rate1DataGridViewTextBoxColumn";
            this.rate1DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate1DataGridViewTextBoxColumn.Width = 44;
            // 
            // rate2DataGridViewTextBoxColumn
            // 
            this.rate2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate2DataGridViewTextBoxColumn.DataPropertyName = "Rate2";
            this.rate2DataGridViewTextBoxColumn.HeaderText = "二级";
            this.rate2DataGridViewTextBoxColumn.Name = "rate2DataGridViewTextBoxColumn";
            this.rate2DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate2DataGridViewTextBoxColumn.Width = 44;
            // 
            // rate3DataGridViewTextBoxColumn
            // 
            this.rate3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate3DataGridViewTextBoxColumn.DataPropertyName = "Rate3";
            this.rate3DataGridViewTextBoxColumn.HeaderText = "三级";
            this.rate3DataGridViewTextBoxColumn.Name = "rate3DataGridViewTextBoxColumn";
            this.rate3DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate3DataGridViewTextBoxColumn.Width = 44;
            // 
            // rate4DataGridViewTextBoxColumn
            // 
            this.rate4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate4DataGridViewTextBoxColumn.DataPropertyName = "Rate4";
            this.rate4DataGridViewTextBoxColumn.HeaderText = "四级";
            this.rate4DataGridViewTextBoxColumn.Name = "rate4DataGridViewTextBoxColumn";
            this.rate4DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate4DataGridViewTextBoxColumn.Width = 44;
            // 
            // rate5DataGridViewTextBoxColumn
            // 
            this.rate5DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate5DataGridViewTextBoxColumn.DataPropertyName = "Rate5";
            this.rate5DataGridViewTextBoxColumn.HeaderText = "五级";
            this.rate5DataGridViewTextBoxColumn.Name = "rate5DataGridViewTextBoxColumn";
            this.rate5DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate5DataGridViewTextBoxColumn.Width = 44;
            // 
            // rate6DataGridViewTextBoxColumn
            // 
            this.rate6DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate6DataGridViewTextBoxColumn.DataPropertyName = "Rate6";
            this.rate6DataGridViewTextBoxColumn.HeaderText = "六级";
            this.rate6DataGridViewTextBoxColumn.Name = "rate6DataGridViewTextBoxColumn";
            this.rate6DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate6DataGridViewTextBoxColumn.Width = 43;
            // 
            // rate7DataGridViewTextBoxColumn
            // 
            this.rate7DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate7DataGridViewTextBoxColumn.DataPropertyName = "Rate7";
            this.rate7DataGridViewTextBoxColumn.HeaderText = "七级";
            this.rate7DataGridViewTextBoxColumn.Name = "rate7DataGridViewTextBoxColumn";
            this.rate7DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate7DataGridViewTextBoxColumn.Width = 44;
            // 
            // rate8DataGridViewTextBoxColumn
            // 
            this.rate8DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate8DataGridViewTextBoxColumn.DataPropertyName = "Rate8";
            this.rate8DataGridViewTextBoxColumn.HeaderText = "八级";
            this.rate8DataGridViewTextBoxColumn.Name = "rate8DataGridViewTextBoxColumn";
            this.rate8DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate8DataGridViewTextBoxColumn.Width = 44;
            // 
            // rate9DataGridViewTextBoxColumn
            // 
            this.rate9DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate9DataGridViewTextBoxColumn.DataPropertyName = "Rate9";
            this.rate9DataGridViewTextBoxColumn.HeaderText = "九级";
            this.rate9DataGridViewTextBoxColumn.Name = "rate9DataGridViewTextBoxColumn";
            this.rate9DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate9DataGridViewTextBoxColumn.Width = 44;
            // 
            // rate10DataGridViewTextBoxColumn
            // 
            this.rate10DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.rate10DataGridViewTextBoxColumn.DataPropertyName = "Rate10";
            this.rate10DataGridViewTextBoxColumn.HeaderText = "十级";
            this.rate10DataGridViewTextBoxColumn.Name = "rate10DataGridViewTextBoxColumn";
            this.rate10DataGridViewTextBoxColumn.ReadOnly = true;
            this.rate10DataGridViewTextBoxColumn.Width = 44;
            // 
            // isDefaultDataGridViewCheckBoxColumn
            // 
            this.isDefaultDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.isDefaultDataGridViewCheckBoxColumn.DataPropertyName = "IsDefault";
            this.isDefaultDataGridViewCheckBoxColumn.FalseValue = "False";
            this.isDefaultDataGridViewCheckBoxColumn.HeaderText = "默认";
            this.isDefaultDataGridViewCheckBoxColumn.Name = "isDefaultDataGridViewCheckBoxColumn";
            this.isDefaultDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDefaultDataGridViewCheckBoxColumn.TrueValue = "True";
            this.isDefaultDataGridViewCheckBoxColumn.Width = 44;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "编辑";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Text = "编辑";
            this.Column1.UseColumnTextForLinkValue = true;
            this.Column1.Width = 40;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDelete.HeaderText = "删除";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDelete.Text = "删除";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // LevelSettingCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Name = "LevelSettingCtrl";
            this.Size = new System.Drawing.Size(1193, 650);
            this.Load += new System.EventHandler(this.SendGiftTicketCtrl_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionTemplateBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinComboBox skinComboBox_Level;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private PictureBox pictureBox1;
        private Common.Components.BaseButton baseButtonSave;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private BindingSource commissionTemplateBindingSource;
        private Common.Components.BaseButton baseButton1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate5DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate6DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate7DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate8DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate9DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rate10DataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isDefaultDataGridViewCheckBoxColumn;
        private DataGridViewLinkColumn Column1;
        private DataGridViewLinkColumn ColumnDelete;
    }
}
