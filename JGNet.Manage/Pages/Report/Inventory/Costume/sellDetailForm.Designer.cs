using CCWin.SkinControl;
using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Common
{
    partial class sellDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sellDetailForm));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_RetailDetail = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guideNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.skinComboBox_Type = new CCWin.SkinControl.SkinComboBox();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RetailDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailOrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.panel2);
            this.skinPanel1.Controls.Add(this.panel1);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_RetailDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 302);
            this.panel2.TabIndex = 5;
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
            this.OrderType,
            this.guideNameDataGridViewTextBoxColumn,
            this.totalCountDataGridViewTextBoxColumn,
            this.stateNameDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dataGridView_RetailDetail.DataSource = this.retailOrderBindingSource;
            this.dataGridView_RetailDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RetailDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_RetailDetail.MultiSelect = false;
            this.dataGridView_RetailDetail.Name = "dataGridView_RetailDetail";
            this.dataGridView_RetailDetail.ReadOnly = true;
            this.dataGridView_RetailDetail.RowTemplate.Height = 23;
            this.dataGridView_RetailDetail.Size = new System.Drawing.Size(699, 302);
            this.dataGridView_RetailDetail.TabIndex = 3;
            this.dataGridView_RetailDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RetailDetail_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "单据编号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDataGridViewTextBoxColumn.Width = 120;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "日期";
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // OrderType
            // 
            this.OrderType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OrderType.DataPropertyName = "OrderType";
            this.OrderType.HeaderText = "类型";
            this.OrderType.Name = "OrderType";
            this.OrderType.ReadOnly = true;
            this.OrderType.Width = 50;
            // 
            // guideNameDataGridViewTextBoxColumn
            // 
            this.guideNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.guideNameDataGridViewTextBoxColumn.DataPropertyName = "EntryUserName";
            this.guideNameDataGridViewTextBoxColumn.HeaderText = "制单人";
            this.guideNameDataGridViewTextBoxColumn.Name = "guideNameDataGridViewTextBoxColumn";
            this.guideNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCountDataGridViewTextBoxColumn
            // 
            this.totalCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalCountDataGridViewTextBoxColumn.DataPropertyName = "TotalCount";
            this.totalCountDataGridViewTextBoxColumn.HeaderText = "数量";
            this.totalCountDataGridViewTextBoxColumn.Name = "totalCountDataGridViewTextBoxColumn";
            this.totalCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCountDataGridViewTextBoxColumn.Width = 80;
            // 
            // stateNameDataGridViewTextBoxColumn
            // 
            this.stateNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stateNameDataGridViewTextBoxColumn.DataPropertyName = "StateName";
            this.stateNameDataGridViewTextBoxColumn.HeaderText = "状态";
            this.stateNameDataGridViewTextBoxColumn.Name = "stateNameDataGridViewTextBoxColumn";
            this.stateNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 54;
            // 
            // retailOrderBindingSource
            // 
            this.retailOrderBindingSource.DataSource = typeof(JGNet.RetailOrder);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Controls.Add(this.baseButton2);
            this.panel1.Controls.Add(this.skinComboBox_Type);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 40);
            this.panel1.TabIndex = 4;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(11, 12);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 18;
            this.skinLabel1.Text = "类型";
            // 
            // baseButton2
            // 
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.DownBack")));
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(184, 6);
            this.baseButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.MouseBack")));
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.NormlBack")));
            this.baseButton2.Size = new System.Drawing.Size(75, 32);
            this.baseButton2.TabIndex = 17;
            this.baseButton2.Text = "查询";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // skinComboBox_Type
            // 
            this.skinComboBox_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Type.FormattingEnabled = true;
            this.skinComboBox_Type.Location = new System.Drawing.Point(42, 10);
            this.skinComboBox_Type.Name = "skinComboBox_Type";
            this.skinComboBox_Type.Size = new System.Drawing.Size(136, 22);
            this.skinComboBox_Type.TabIndex = 16;
            this.skinComboBox_Type.WaterText = "";
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
            this.BaseButton1.Location = new System.Drawing.Point(618, 5);
            this.BaseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.MouseBack")));
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.NormlBack")));
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 4;
            this.BaseButton1.Text = "关闭";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Quit_Click);
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataSource = typeof(JGNet.PurchaseOrder);
            // 
            // sellDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 412);
            this.Controls.Add(this.skinPanel1);
            this.Name = "sellDetailForm";
            this.Text = "销售明细";
            this.skinPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RetailDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailOrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SkinPanel skinPanel1;
        private SkinPanel skinPanel3;
        private Common.Components.BaseButton BaseButton1;
        private DataGridView dataGridView_RetailDetail;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private BindingSource purchaseOrderBindingSource;
        private BindingSource retailOrderBindingSource;
        private Panel panel1;
        private Panel panel2;
        private SkinLabel skinLabel1;
        private BaseButton baseButton2;
        private SkinComboBox skinComboBox_Type;
        private DataGridViewLinkColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn OrderType;
        private DataGridViewTextBoxColumn guideNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}