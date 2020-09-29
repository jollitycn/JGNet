using CCWin.SkinControl;
using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Common
{
    partial class CustomSaleGoodDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomSaleGoodDetailForm));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.dataGridView_RetailDetail = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfCustomerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfCustomerRetailOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RetailDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfCustomerRetailOrderBindingSource)).BeginInit();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.dataGridView_RetailDetail);
            this.skinPanel1.Controls.Add(this.skinPanel3);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 28);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(699, 380);
            this.skinPanel1.TabIndex = 0;
            // 
            // dataGridView_RetailDetail
            // 
            this.dataGridView_RetailDetail.AllowUserToAddRows = false;
            this.dataGridView_RetailDetail.AllowUserToDeleteRows = false;
            this.dataGridView_RetailDetail.AutoGenerateColumns = false;
            this.dataGridView_RetailDetail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_RetailDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.pfCustomerNameDataGridViewTextBoxColumn,
            this.totalCountDataGridViewTextBoxColumn});
            this.dataGridView_RetailDetail.DataSource = this.pfCustomerRetailOrderBindingSource;
            this.dataGridView_RetailDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RetailDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_RetailDetail.MultiSelect = false;
            this.dataGridView_RetailDetail.Name = "dataGridView_RetailDetail";
            this.dataGridView_RetailDetail.ReadOnly = true;
            this.dataGridView_RetailDetail.RowTemplate.Height = 23;
            this.dataGridView_RetailDetail.Size = new System.Drawing.Size(699, 342);
            this.dataGridView_RetailDetail.TabIndex = 3;
            this.dataGridView_RetailDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RetailDetail_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "单据";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "日期";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 170;
            // 
            // pfCustomerNameDataGridViewTextBoxColumn
            // 
            this.pfCustomerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.pfCustomerNameDataGridViewTextBoxColumn.DataPropertyName = "PfCustomerName";
            this.pfCustomerNameDataGridViewTextBoxColumn.HeaderText = "客户";
            this.pfCustomerNameDataGridViewTextBoxColumn.Name = "pfCustomerNameDataGridViewTextBoxColumn";
            this.pfCustomerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pfCustomerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalCountDataGridViewTextBoxColumn
            // 
            this.totalCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalCountDataGridViewTextBoxColumn.DataPropertyName = "TotalCount";
            this.totalCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.totalCountDataGridViewTextBoxColumn.Name = "totalCountDataGridViewTextBoxColumn";
            this.totalCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCountDataGridViewTextBoxColumn.Width = 54;
            // 
            // pfCustomerRetailOrderBindingSource
            // 
            this.pfCustomerRetailOrderBindingSource.DataSource = typeof(JGNet.PfCustomerRetailOrder);
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.BaseButton1);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(0, 342);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(699, 38);
            this.skinPanel3.TabIndex = 2;
            // 
            // BaseButton1
            // 
            this.BaseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.DownBack")));
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(618, 6);
            this.BaseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.MouseBack")));
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.NormlBack")));
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 4;
            this.BaseButton1.Text = "关闭";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Quit_Click);
            // 
            // CustomSaleGoodDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 412);
            this.Controls.Add(this.skinPanel1);
            this.Name = "CustomSaleGoodDetailForm";
            this.Text = "销售明细";
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RetailDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pfCustomerRetailOrderBindingSource)).EndInit();
            this.skinPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SkinPanel skinPanel1;
        private SkinPanel skinPanel3;
        private Common.Components.BaseButton BaseButton1;
        private DataGridView dataGridView_RetailDetail;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private BindingSource pfCustomerRetailOrderBindingSource;
        private DataGridViewLinkColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pfCustomerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalCountDataGridViewTextBoxColumn;
    }
}