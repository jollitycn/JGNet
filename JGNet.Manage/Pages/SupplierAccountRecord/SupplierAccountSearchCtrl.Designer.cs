using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class SupplierAccountSearchCtrl
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
            this.baseButton3 = new JGNet.Common.Components.BaseButton();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cashRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton3);
            this.skinPanel1.Controls.Add(this.baseButton2);
            this.skinPanel1.Controls.Add(this.BaseButton1);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 42);
            this.skinPanel1.TabIndex = 4;
            this.skinPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.skinPanel1_Paint);
            // 
            // baseButton3
            // 
            this.baseButton3.BackColor = System.Drawing.Color.Transparent;
            this.baseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton3.Location = new System.Drawing.Point(229, 4);
            this.baseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton3.Name = "baseButton3";
            this.baseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton3.Size = new System.Drawing.Size(75, 32);
            this.baseButton3.TabIndex = 6;
            this.baseButton3.Text = "刷新";
            this.baseButton3.UseVisualStyleBackColor = false;
            this.baseButton3.Click += new System.EventHandler(this.baseButton3_Click);
            // 
            // baseButton2
            // 
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(117, 4);
            this.baseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton2.Size = new System.Drawing.Size(106, 32);
            this.baseButton2.TabIndex = 5;
            this.baseButton2.Text = "往来账明细";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(5, 4);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(106, 32);
            this.BaseButton1.TabIndex = 4;
            this.BaseButton1.Text = "添加付款记录";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButtonSaveAccount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.paymentBalanceDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.Column2});
            this.dataGridView1.DataSource = this.cashRecordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 608);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cashRecordBindingSource
            // 
            this.cashRecordBindingSource.DataSource = typeof(JGNet.Supplier);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(JGNet.SupplierAccountRecord);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "供应商";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 400;
            // 
            // paymentBalanceDataGridViewTextBoxColumn
            // 
            this.paymentBalanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.paymentBalanceDataGridViewTextBoxColumn.DataPropertyName = "PaymentBalance";
            this.paymentBalanceDataGridViewTextBoxColumn.HeaderText = "应付结余";
            this.paymentBalanceDataGridViewTextBoxColumn.Name = "paymentBalanceDataGridViewTextBoxColumn";
            this.paymentBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentBalanceDataGridViewTextBoxColumn.ToolTipText = "负数表示欠供应商的货款";
            this.paymentBalanceDataGridViewTextBoxColumn.Width = 400;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "LastAccountTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "最后记账日期";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 360;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "查询";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "查询";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // SupplierAccountSearchCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "SupplierAccountSearchCtrl";
            this.Load += new System.EventHandler(this.SupplierAccountSearchCtrl_Load);
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cashRecordBindingSource;
        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Common.Components.BaseButton BaseButton1;
        private DataGridView dataGridView1;
        private Common.Components.BaseButton baseButton2;
        private Common.Components.BaseButton baseButton3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn paymentBalanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Column2;
    }
}
