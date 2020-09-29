using CCWin.SkinControl;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class OffLineCustomerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OffLineCustomerListForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pfCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.BaseButtonEdit = new JGNet.Common.Components.BaseButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WithdrawMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfCustomerBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
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
            this.Column2,
            this.Column3,
            this.WithdrawMoney,
            this.ColumnEdit});
            this.dataGridView1.DataSource = this.pfCustomerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(728, 404);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pfCustomerBindingSource
            // 
            this.pfCustomerBindingSource.DataSource = typeof(JGNet.PfCustomer);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.BaseButtonEdit);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 432);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(728, 35);
            this.skinPanel1.TabIndex = 7;
            // 
            // BaseButtonEdit
            // 
            this.BaseButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonEdit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonEdit.DownBack = ((System.Drawing.Image)(resources.GetObject("BaseButtonEdit.DownBack")));
            this.BaseButtonEdit.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonEdit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonEdit.Location = new System.Drawing.Point(650, 3);
            this.BaseButtonEdit.MouseBack = ((System.Drawing.Image)(resources.GetObject("BaseButtonEdit.MouseBack")));
            this.BaseButtonEdit.Name = "BaseButtonEdit";
            this.BaseButtonEdit.NormlBack = ((System.Drawing.Image)(resources.GetObject("BaseButtonEdit.NormlBack")));
            this.BaseButtonEdit.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonEdit.TabIndex = 5;
            this.BaseButtonEdit.Text = "关闭";
            this.BaseButtonEdit.UseVisualStyleBackColor = false;
            this.BaseButtonEdit.Click += new System.EventHandler(this.BaseButtonEdit_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "客户编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "客户名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Password";
            this.Column3.HeaderText = "密码";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // WithdrawMoney
            // 
            this.WithdrawMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WithdrawMoney.DataPropertyName = "WithdrawMoney";
            this.WithdrawMoney.HeaderText = "回款金额";
            this.WithdrawMoney.Name = "WithdrawMoney";
            this.WithdrawMoney.ReadOnly = true;
            this.WithdrawMoney.Width = 150;
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
            // OffLineCustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 471);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OffLineCustomerListForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "下线客户";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfCustomerBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private SkinPanel skinPanel1;
        private Common.Components.BaseButton BaseButtonEdit;
        private BindingSource pfCustomerBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn WithdrawMoney;
        private DataGridViewLinkColumn ColumnEdit;
    }
}