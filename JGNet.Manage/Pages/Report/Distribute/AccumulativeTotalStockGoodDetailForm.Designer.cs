using CCWin.SkinControl;
using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Common
{
    partial class AccumulativeTotalStockGoodDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccumulativeTotalStockGoodDetailForm));
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_RetailDetail = new System.Windows.Forms.DataGridView();
            this.purchaseOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.baseButton2 = new JGNet.Common.Components.BaseButton();
            this.skinComboBox_Type = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.InboundOrderID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RetailDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.skinPanel3.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 326);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView_RetailDetail
            // 
            this.dataGridView_RetailDetail.AllowUserToAddRows = false;
            this.dataGridView_RetailDetail.AllowUserToDeleteRows = false;
            this.dataGridView_RetailDetail.AutoGenerateColumns = false;
            this.dataGridView_RetailDetail.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_RetailDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InboundOrderID,
            this.CreateTime,
            this.Type,
            this.Count,
            this.UserName,
            this.Remarks});
            this.dataGridView_RetailDetail.DataSource = this.purchaseOrderBindingSource;
            this.dataGridView_RetailDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_RetailDetail.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_RetailDetail.MultiSelect = false;
            this.dataGridView_RetailDetail.Name = "dataGridView_RetailDetail";
            this.dataGridView_RetailDetail.ReadOnly = true;
            this.dataGridView_RetailDetail.RowTemplate.Height = 23;
            this.dataGridView_RetailDetail.Size = new System.Drawing.Size(699, 326);
            this.dataGridView_RetailDetail.TabIndex = 3;
            this.dataGridView_RetailDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RetailDetail_CellClick);
            // 
            // purchaseOrderBindingSource
            // 
            this.purchaseOrderBindingSource.DataSource = typeof(JGNet.Core.InteractEntity.OrderInfo);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.baseButton2);
            this.panel1.Controls.Add(this.skinComboBox_Type);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 10);
            this.panel1.TabIndex = 4;
            // 
            // baseButton2
            // 
            this.baseButton2.BackColor = System.Drawing.Color.Transparent;
            this.baseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton2.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.DownBack")));
            this.baseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton2.Location = new System.Drawing.Point(204, 16);
            this.baseButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.MouseBack")));
            this.baseButton2.Name = "baseButton2";
            this.baseButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton2.NormlBack")));
            this.baseButton2.Size = new System.Drawing.Size(75, 32);
            this.baseButton2.TabIndex = 12;
            this.baseButton2.Text = "查询";
            this.baseButton2.UseVisualStyleBackColor = false;
            this.baseButton2.Click += new System.EventHandler(this.baseButton2_Click);
            // 
            // skinComboBox_Type
            // 
            this.skinComboBox_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_Type.FormattingEnabled = true;
            this.skinComboBox_Type.Location = new System.Drawing.Point(48, 18);
            this.skinComboBox_Type.Name = "skinComboBox_Type";
            this.skinComboBox_Type.Size = new System.Drawing.Size(136, 22);
            this.skinComboBox_Type.TabIndex = 10;
            this.skinComboBox_Type.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(13, 21);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 11;
            this.skinLabel1.Text = "类型";
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.BaseButton1);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(0, 336);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(699, 44);
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
            this.BaseButton1.Location = new System.Drawing.Point(621, 9);
            this.BaseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.MouseBack")));
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("BaseButton1.NormlBack")));
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 4;
            this.BaseButton1.Text = "关闭";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_Quit_Click);
            // 
            // InboundOrderID
            // 
            this.InboundOrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InboundOrderID.DataPropertyName = "ID";
            this.InboundOrderID.HeaderText = "单据编号";
            this.InboundOrderID.Name = "InboundOrderID";
            this.InboundOrderID.ReadOnly = true;
            this.InboundOrderID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InboundOrderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InboundOrderID.Width = 110;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "日期";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Width = 110;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "类型";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "数量";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 60;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserName.DataPropertyName = "EntryUserName";
            this.UserName.HeaderText = "制单人";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 90;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "备注";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // AccumulativeTotalStockGoodDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 412);
            this.Controls.Add(this.skinPanel1);
            this.Name = "AccumulativeTotalStockGoodDetailForm";
            this.Text = "累计进货明细";
            this.skinPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RetailDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SkinPanel skinPanel1;
        private SkinPanel skinPanel3;
        private Common.Components.BaseButton BaseButton1;
        private DataGridView dataGridView_RetailDetail;
        private DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private BindingSource purchaseOrderBindingSource;
        private Panel panel2;
        private Panel panel1;
        private SkinComboBox skinComboBox_Type;
        private SkinLabel skinLabel1;
        private BaseButton baseButton2;
        private DataGridViewLinkColumn InboundOrderID;
        private DataGridViewTextBoxColumn CreateTime;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Remarks;
    }
}