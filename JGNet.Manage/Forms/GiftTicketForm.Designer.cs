using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class GiftTicketForm
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
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.BaseButton2 = new JGNet.Common.Components.BaseButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denominationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denomination = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.dataGridView1);
            this.skinPanel1.Controls.Add(this.skinPanel3);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 28);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(792, 380);
            this.skinPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.iDDataGridViewTextBoxColumn,
            this.denominationDataGridViewTextBoxColumn,
            this.ticketDescriptionDataGridViewTextBoxColumn,
            this.effectDateDataGridViewTextBoxColumn,
            this.expiredDateDataGridViewTextBoxColumn,
            this.Denomination});
            this.dataGridView1.DataSource = this.memberBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(792, 342);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(JGNet.GiftTicket);
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.BaseButton2);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Location = new System.Drawing.Point(0, 342);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.Size = new System.Drawing.Size(792, 38);
            this.skinPanel3.TabIndex = 2;
            // 
            // BaseButton2
            // 
            this.BaseButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton2.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton2.Location = new System.Drawing.Point(714, 6);
            this.BaseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton2.Name = "BaseButton2";
            this.BaseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton2.Size = new System.Drawing.Size(75, 32);
            this.BaseButton2.TabIndex = 3;
            this.BaseButton2.Text = "确定";
            this.BaseButton2.UseVisualStyleBackColor = false;
            this.BaseButton2.Click += new System.EventHandler(this.BaseButton_OK_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "CostumeID";
            this.Column1.HeaderText = "款号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 107;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "优惠券编号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 107;
            // 
            // denominationDataGridViewTextBoxColumn
            // 
            this.denominationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.denominationDataGridViewTextBoxColumn.DataPropertyName = "Denomination";
            this.denominationDataGridViewTextBoxColumn.HeaderText = "面额";
            this.denominationDataGridViewTextBoxColumn.Name = "denominationDataGridViewTextBoxColumn";
            this.denominationDataGridViewTextBoxColumn.ReadOnly = true;
            this.denominationDataGridViewTextBoxColumn.Width = 107;
            // 
            // ticketDescriptionDataGridViewTextBoxColumn
            // 
            this.ticketDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ticketDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TicketDescription";
            this.ticketDescriptionDataGridViewTextBoxColumn.HeaderText = "描述";
            this.ticketDescriptionDataGridViewTextBoxColumn.Name = "ticketDescriptionDataGridViewTextBoxColumn";
            this.ticketDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketDescriptionDataGridViewTextBoxColumn.Width = 107;
            // 
            // effectDateDataGridViewTextBoxColumn
            // 
            this.effectDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.effectDateDataGridViewTextBoxColumn.DataPropertyName = "EffectDate";
            this.effectDateDataGridViewTextBoxColumn.HeaderText = "生效日期";
            this.effectDateDataGridViewTextBoxColumn.Name = "effectDateDataGridViewTextBoxColumn";
            this.effectDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.effectDateDataGridViewTextBoxColumn.Width = 107;
            // 
            // expiredDateDataGridViewTextBoxColumn
            // 
            this.expiredDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.expiredDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiredDate";
            this.expiredDateDataGridViewTextBoxColumn.HeaderText = "截止日期";
            this.expiredDateDataGridViewTextBoxColumn.Name = "expiredDateDataGridViewTextBoxColumn";
            this.expiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expiredDateDataGridViewTextBoxColumn.Width = 107;
            // 
            // Denomination
            // 
            this.Denomination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Denomination.HeaderText = "选择优惠券";
            this.Denomination.Name = "Denomination";
            this.Denomination.ReadOnly = true;
            this.Denomination.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Denomination.Text = "选择优惠券";
            this.Denomination.UseColumnTextForLinkValue = true;
            this.Denomination.Width = 107;
            // 
            // GiftTicketForm
            // 
            this.AcceptButton = this.BaseButton2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.skinPanel1);
            this.Name = "GiftTicketForm";
            this.Text = "已选优惠券";
            this.skinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.skinPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SkinPanel skinPanel1;
        private SkinPanel skinPanel3;
        private Common.Components.BaseButton BaseButton2;
        private BindingSource memberBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn denominationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ticketDescriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn effectDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expiredDateDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Denomination;
    }
}