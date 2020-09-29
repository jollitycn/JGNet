using JGNet.Common.Components;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class EarlyStageAccountRecordCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarlyStageAccountRecordCtrl));
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_SupplierID = new JGNet.Common.Components.SupllierComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButtonEnd = new JGNet.Common.Components.BaseButton();
            this.baseButtonRefresh = new JGNet.Common.Components.BaseButton();
            this.numericTextBox1 = new JGNet.Common.NumericTextBox();
            this.BaseButtonEdit = new JGNet.Common.Components.BaseButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cashRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(232, 9);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(80, 17);
            this.skinLabel7.TabIndex = 118;
            this.skinLabel7.Text = "期初记账金额";
            // 
            // skinComboBox_SupplierID
            // 
            this.skinComboBox_SupplierID.AutoSize = true;
            this.skinComboBox_SupplierID.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_SupplierID.EnabledSupplier = false;
            this.skinComboBox_SupplierID.HideAll = true;
            this.skinComboBox_SupplierID.Location = new System.Drawing.Point(58, 4);
            this.skinComboBox_SupplierID.Name = "skinComboBox_SupplierID";
            this.skinComboBox_SupplierID.SelectedItem = null;
            this.skinComboBox_SupplierID.SelectedValue = null;
            this.skinComboBox_SupplierID.ShowAdd = true;
            this.skinComboBox_SupplierID.Size = new System.Drawing.Size(175, 26);
            this.skinComboBox_SupplierID.TabIndex = 0;
            this.skinComboBox_SupplierID.Title = null;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(8, 9);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 117;
            this.skinLabel1.Text = "供应商";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButtonEnd);
            this.skinPanel1.Controls.Add(this.baseButtonRefresh);
            this.skinPanel1.Controls.Add(this.numericTextBox1);
            this.skinPanel1.Controls.Add(this.BaseButtonEdit);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinComboBox_SupplierID);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 35);
            this.skinPanel1.TabIndex = 4;
            // 
            // baseButtonEnd
            // 
            this.baseButtonEnd.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonEnd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonEnd.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonEnd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonEnd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonEnd.Location = new System.Drawing.Point(554, 2);
            this.baseButtonEnd.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonEnd.Name = "baseButtonEnd";
            this.baseButtonEnd.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonEnd.Size = new System.Drawing.Size(75, 32);
            this.baseButtonEnd.TabIndex = 144;
            this.baseButtonEnd.Text = "录入完毕";
            this.baseButtonEnd.UseVisualStyleBackColor = false;
            this.baseButtonEnd.Click += new System.EventHandler(this.baseButton3_Click);
            // 
            // baseButtonRefresh
            // 
            this.baseButtonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonRefresh.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonRefresh.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonRefresh.DownBack")));
            this.baseButtonRefresh.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonRefresh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("baseButtonRefresh.Image")));
            this.baseButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.baseButtonRefresh.Location = new System.Drawing.Point(635, 2);
            this.baseButtonRefresh.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonRefresh.MouseBack")));
            this.baseButtonRefresh.Name = "baseButtonRefresh";
            this.baseButtonRefresh.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonRefresh.NormlBack")));
            this.baseButtonRefresh.Size = new System.Drawing.Size(75, 32);
            this.baseButtonRefresh.TabIndex = 1;
            this.baseButtonRefresh.Text = "刷新";
            this.baseButtonRefresh.UseVisualStyleBackColor = false;
            this.baseButtonRefresh.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBox1.DecimalPlaces = 0;
            this.numericTextBox1.DownBack = null;
            this.numericTextBox1.Icon = null;
            this.numericTextBox1.IconIsButton = false;
            this.numericTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBox1.IsPasswordChat = '\0';
            this.numericTextBox1.IsSystemPasswordChar = false;
            this.numericTextBox1.Lines = new string[0];
            this.numericTextBox1.Location = new System.Drawing.Point(315, 2);
            this.numericTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBox1.MaxLength = 32767;
            this.numericTextBox1.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBox1.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBox1.MouseBack = null;
            this.numericTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBox1.Multiline = false;
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.NormlBack = null;
            this.numericTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBox1.ReadOnly = false;
            this.numericTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBox1.ShowZero = false;
            this.numericTextBox1.Size = new System.Drawing.Size(142, 28);
            // 
            // 
            // 
            this.numericTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTextBox1.SkinTxt.Name = "BaseText";
            this.numericTextBox1.SkinTxt.Size = new System.Drawing.Size(132, 18);
            this.numericTextBox1.SkinTxt.TabIndex = 0;
            this.numericTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBox1.SkinTxt.WaterText = "";
            this.numericTextBox1.TabIndex = 119;
            this.numericTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBox1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBox1.WaterText = "";
            this.numericTextBox1.WordWrap = true;
            // 
            // BaseButtonEdit
            // 
            this.BaseButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonEdit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonEdit.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonEdit.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonEdit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonEdit.Location = new System.Drawing.Point(473, 2);
            this.BaseButtonEdit.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonEdit.Name = "BaseButtonEdit";
            this.BaseButtonEdit.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonEdit.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonEdit.TabIndex = 4;
            this.BaseButtonEdit.Text = "编辑";
            this.BaseButtonEdit.UseVisualStyleBackColor = false;
            this.BaseButtonEdit.Click += new System.EventHandler(this.BaseButtonSaveAccount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.paymentBalanceDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cashRecordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 615);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cashRecordBindingSource
            // 
            this.cashRecordBindingSource.DataSource = typeof(JGNet.Supplier);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "供应商";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 372;
            // 
            // paymentBalanceDataGridViewTextBoxColumn
            // 
            this.paymentBalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.paymentBalanceDataGridViewTextBoxColumn.DataPropertyName = "PaymentBalance";
            this.paymentBalanceDataGridViewTextBoxColumn.HeaderText = "应付结余";
            this.paymentBalanceDataGridViewTextBoxColumn.Name = "paymentBalanceDataGridViewTextBoxColumn";
            this.paymentBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentBalanceDataGridViewTextBoxColumn.ToolTipText = "负数表示欠供应商的货款";
            this.paymentBalanceDataGridViewTextBoxColumn.Width = 373;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "LastAccountTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "记账日期";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 372;
            // 
            // EarlyStageAccountRecordCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "EarlyStageAccountRecordCtrl";
            this.Load += new System.EventHandler(this.SupplierAccountSearchCtrl_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cashRecordBindingSource;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private SupllierComboBox skinComboBox_SupplierID;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Panel skinPanel1;
        private Common.Components.BaseButton BaseButtonEdit;
        private Common.NumericTextBox numericTextBox1;
        private DataGridView dataGridView1;
        private Common.Components.BaseButton baseButtonRefresh;
        private Common.Components.BaseButton baseButtonEnd;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn paymentBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
    }
}
