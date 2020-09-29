using JGNet.Common.Components;
using System.Collections.Generic;

namespace JGNet.Manage
{
    partial class SupplierAccountRecordSearchCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierAccountRecordSearchCtrl));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cashRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinComboBoxSupplier = new JGNet.Common.Components.SupllierComboBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_FeeType = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AdminUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.accountTypeDataGridViewTextBoxColumn,
            this.accountMoneyDataGridViewTextBoxColumn,
            this.paymentBalanceDataGridViewTextBoxColumn,
            this.sourceOrderIDDataGridViewTextBoxColumn,
            this.AdminUserID,
            this.remarksDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dataGridView1.DataSource = this.cashRecordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 334);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // cashRecordBindingSource
            // 
            this.cashRecordBindingSource.DataSource = typeof(JGNet.SupplierAccountRecord);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.quickDateSelector1);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Controls.Add(this.skinComboBoxSupplier);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinComboBox_FeeType);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.dateTimePicker_Start);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 36);
            this.skinPanel1.TabIndex = 1;
            // 
            // quickDateSelector1
            // 
            this.quickDateSelector1.Arrow = System.Drawing.Color.Black;
            this.quickDateSelector1.Back = System.Drawing.Color.White;
            this.quickDateSelector1.BackRadius = 4;
            this.quickDateSelector1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.quickDateSelector1.Base = System.Drawing.Color.Transparent;
            this.quickDateSelector1.BaseFore = System.Drawing.Color.Black;
            this.quickDateSelector1.BaseForeAnamorphosis = false;
            this.quickDateSelector1.BaseForeAnamorphosisBorder = 4;
            this.quickDateSelector1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.quickDateSelector1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.quickDateSelector1.BaseHoverFore = System.Drawing.Color.White;
            this.quickDateSelector1.BaseItemAnamorphosis = true;
            this.quickDateSelector1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemBorderShow = true;
            this.quickDateSelector1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("quickDateSelector1.BaseItemDown")));
            this.quickDateSelector1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("quickDateSelector1.BaseItemMouse")));
            this.quickDateSelector1.BaseItemNorml = null;
            this.quickDateSelector1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemRadius = 4;
            this.quickDateSelector1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BindTabControl = null;
            this.quickDateSelector1.Dock = System.Windows.Forms.DockStyle.None;
            this.quickDateSelector1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.quickDateSelector1.EndDateTimePicker = this.dateTimePicker_End;
            this.quickDateSelector1.Fore = System.Drawing.Color.Black;
            this.quickDateSelector1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.quickDateSelector1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.quickDateSelector1.HoverFore = System.Drawing.Color.White;
            this.quickDateSelector1.ItemAnamorphosis = true;
            this.quickDateSelector1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemBorderShow = true;
            this.quickDateSelector1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemRadius = 4;
            this.quickDateSelector1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Location = new System.Drawing.Point(779, 6);
            this.quickDateSelector1.Name = "quickDateSelector1";
            this.quickDateSelector1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Size = new System.Drawing.Size(32, 25);
            this.quickDateSelector1.SkinAllColor = true;
            this.quickDateSelector1.StartDateTimePicker = this.dateTimePicker_Start;
            this.quickDateSelector1.TabIndex = 130;
            this.quickDateSelector1.Text = "quickDateSelector1";
            this.quickDateSelector1.TitleAnamorphosis = true;
            this.quickDateSelector1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.quickDateSelector1.TitleRadius = 4;
            this.quickDateSelector1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.PickerValueChanged += new CJBasic.Action<object, System.EventArgs>(this.BaseButton_Search_Click);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(644, 8);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker_End.TabIndex = 3;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(470, 8);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker_Start.TabIndex = 2;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(826, 2);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 4;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Search_Click);
            // 
            // skinComboBoxSupplier
            // 
            this.skinComboBoxSupplier.AutoSize = true;
            this.skinComboBoxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxSupplier.EnabledSupplier = false;
            this.skinComboBoxSupplier.HideAll = true;
            this.skinComboBoxSupplier.Location = new System.Drawing.Point(53, 6);
            this.skinComboBoxSupplier.Name = "skinComboBoxSupplier";
            this.skinComboBoxSupplier.SelectedItem = null;
            this.skinComboBoxSupplier.SelectedValue = null;
            this.skinComboBoxSupplier.ShowAdd = true;
            this.skinComboBoxSupplier.Size = new System.Drawing.Size(175, 26);
            this.skinComboBoxSupplier.TabIndex = 0;
            this.skinComboBoxSupplier.Title = null;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(3, 11);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(44, 17);
            this.skinLabel5.TabIndex = 117;
            this.skinLabel5.Text = "供应商";
            // 
            // skinComboBox_FeeType
            // 
            this.skinComboBox_FeeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_FeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_FeeType.FormattingEnabled = true;
            this.skinComboBox_FeeType.Location = new System.Drawing.Point(296, 7);
            this.skinComboBox_FeeType.Name = "skinComboBox_FeeType";
            this.skinComboBox_FeeType.Size = new System.Drawing.Size(130, 22);
            this.skinComboBox_FeeType.TabIndex = 1;
            this.skinComboBox_FeeType.WaterText = "";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(234, 10);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 114;
            this.skinLabel4.Text = "记账类型";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(606, 10);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 16;
            this.skinLabel3.Text = "结束";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(432, 10);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 17;
            this.skinLabel2.Text = "开始";
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.CollapsePanel = CCWin.SkinControl.CollapsePanel.Panel2;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 36);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            this.skinSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 614);
            this.skinSplitContainer1.SplitterDistance = 334;
            this.skinSplitContainer1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "SupplierName";
            this.Column1.HeaderText = "供应商";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // accountTypeDataGridViewTextBoxColumn
            // 
            this.accountTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.accountTypeDataGridViewTextBoxColumn.DataPropertyName = "AccountTypeName";
            this.accountTypeDataGridViewTextBoxColumn.HeaderText = "记账类型";
            this.accountTypeDataGridViewTextBoxColumn.Name = "accountTypeDataGridViewTextBoxColumn";
            this.accountTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // accountMoneyDataGridViewTextBoxColumn
            // 
            this.accountMoneyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.accountMoneyDataGridViewTextBoxColumn.DataPropertyName = "AccountMoney";
            this.accountMoneyDataGridViewTextBoxColumn.HeaderText = "记账金额";
            this.accountMoneyDataGridViewTextBoxColumn.Name = "accountMoneyDataGridViewTextBoxColumn";
            this.accountMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountMoneyDataGridViewTextBoxColumn.Width = 120;
            // 
            // paymentBalanceDataGridViewTextBoxColumn
            // 
            this.paymentBalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.paymentBalanceDataGridViewTextBoxColumn.DataPropertyName = "PaymentBalance";
            this.paymentBalanceDataGridViewTextBoxColumn.HeaderText = "应付结余";
            this.paymentBalanceDataGridViewTextBoxColumn.Name = "paymentBalanceDataGridViewTextBoxColumn";
            this.paymentBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentBalanceDataGridViewTextBoxColumn.Width = 120;
            // 
            // sourceOrderIDDataGridViewTextBoxColumn
            // 
            this.sourceOrderIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sourceOrderIDDataGridViewTextBoxColumn.DataPropertyName = "SourceOrderID";
            this.sourceOrderIDDataGridViewTextBoxColumn.HeaderText = "来源单据";
            this.sourceOrderIDDataGridViewTextBoxColumn.Name = "sourceOrderIDDataGridViewTextBoxColumn";
            this.sourceOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceOrderIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sourceOrderIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sourceOrderIDDataGridViewTextBoxColumn.Width = 160;
            // 
            // AdminUserID
            // 
            this.AdminUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AdminUserID.DataPropertyName = "AdminUserName";
            this.AdminUserID.HeaderText = "操作人";
            this.AdminUserID.Name = "AdminUserID";
            this.AdminUserID.ReadOnly = true;
            this.AdminUserID.Width = 118;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 150;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "日期";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 118;
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
            this.ColumnEdit.Width = 40;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDelete.HeaderText = "删除";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "删除";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // SupplierAccountRecordSearchCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "SupplierAccountRecordSearchCtrl";
            this.Load += new System.EventHandler(this.SupplierAccountRecordSearchCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinComboBox skinComboBox_FeeType;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.BindingSource cashRecordBindingSource;
        private SupllierComboBox skinComboBoxSupplier;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private Common.Components.BaseButton BaseButton1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private Common.Components.QuickDateSelector quickDateSelector1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn sourceOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
    }
}
