using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class UpdateShopPriceAndSalePriceForm
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
            this.BaseButton_Search = new JGNet.Common.Components.BaseButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxSalePrice = new JGNet.Common.TextBox();
            this.skinTextBoxPrice = new JGNet.Common.TextBox();
            this.baseButtonCancel = new JGNet.Common.Components.BaseButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelCustomer = new CCWin.SkinControl.SkinLabel();
            this.dataGridViewRole = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.店铺 = new CCWin.SkinControl.SkinLabel();
            this.skinCheckBoxNew = new CCWin.SkinControl.SkinCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).BeginInit();
            this.SuspendLayout();
            // 
            // BaseButton_Search
            // 
            this.BaseButton_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BaseButton_Search.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Search.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Search.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Search.Location = new System.Drawing.Point(169, 367);
            this.BaseButton_Search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Search.Name = "BaseButton_Search";
            this.BaseButton_Search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Search.TabIndex = 3;
            this.BaseButton_Search.Text = "确定";
            this.BaseButton_Search.UseVisualStyleBackColor = false;
            this.BaseButton_Search.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(262, 82);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 83;
            this.skinLabel2.Text = "售价：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(23, 81);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 84;
            this.skinLabel1.Text = "吊牌价：";
            // 
            // skinTextBoxSalePrice
            // 
            this.skinTextBoxSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxSalePrice.DownBack = null;
            this.skinTextBoxSalePrice.Icon = null;
            this.skinTextBoxSalePrice.IconIsButton = false;
            this.skinTextBoxSalePrice.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxSalePrice.IsPasswordChat = '\0';
            this.skinTextBoxSalePrice.IsSystemPasswordChar = false;
            this.skinTextBoxSalePrice.Lines = new string[0];
            this.skinTextBoxSalePrice.Location = new System.Drawing.Point(309, 77);
            this.skinTextBoxSalePrice.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxSalePrice.MaxLength = 32767;
            this.skinTextBoxSalePrice.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxSalePrice.MouseBack = null;
            this.skinTextBoxSalePrice.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxSalePrice.Multiline = true;
            this.skinTextBoxSalePrice.Name = "skinTextBoxSalePrice";
            this.skinTextBoxSalePrice.NormlBack = null;
            this.skinTextBoxSalePrice.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxSalePrice.ReadOnly = false;
            this.skinTextBoxSalePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxSalePrice.Size = new System.Drawing.Size(184, 34);
            // 
            // 
            // 
            this.skinTextBoxSalePrice.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxSalePrice.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxSalePrice.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxSalePrice.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxSalePrice.SkinTxt.Multiline = true;
            this.skinTextBoxSalePrice.SkinTxt.Name = "BaseText";
            this.skinTextBoxSalePrice.SkinTxt.Size = new System.Drawing.Size(174, 24);
            this.skinTextBoxSalePrice.SkinTxt.TabIndex = 0;
            this.skinTextBoxSalePrice.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxSalePrice.SkinTxt.WaterText = "名称";
            this.skinTextBoxSalePrice.TabIndex = 1;
            this.skinTextBoxSalePrice.TabStop = true;
            this.skinTextBoxSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxSalePrice.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxSalePrice.WaterText = "名称";
            this.skinTextBoxSalePrice.WordWrap = true;
            // 
            // skinTextBoxPrice
            // 
            this.skinTextBoxPrice.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxPrice.DownBack = null;
            this.skinTextBoxPrice.Icon = null;
            this.skinTextBoxPrice.IconIsButton = false;
            this.skinTextBoxPrice.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPrice.IsPasswordChat = '\0';
            this.skinTextBoxPrice.IsSystemPasswordChar = false;
            this.skinTextBoxPrice.Lines = new string[0];
            this.skinTextBoxPrice.Location = new System.Drawing.Point(82, 77);
            this.skinTextBoxPrice.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxPrice.MaxLength = 32767;
            this.skinTextBoxPrice.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxPrice.MouseBack = null;
            this.skinTextBoxPrice.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPrice.Multiline = true;
            this.skinTextBoxPrice.Name = "skinTextBoxPrice";
            this.skinTextBoxPrice.NormlBack = null;
            this.skinTextBoxPrice.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxPrice.ReadOnly = false;
            this.skinTextBoxPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxPrice.Size = new System.Drawing.Size(173, 34);
            // 
            // 
            // 
            this.skinTextBoxPrice.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxPrice.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxPrice.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxPrice.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxPrice.SkinTxt.Multiline = true;
            this.skinTextBoxPrice.SkinTxt.Name = "BaseText";
            this.skinTextBoxPrice.SkinTxt.Size = new System.Drawing.Size(163, 24);
            this.skinTextBoxPrice.SkinTxt.TabIndex = 0;
            this.skinTextBoxPrice.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPrice.SkinTxt.WaterText = "编号";
            this.skinTextBoxPrice.TabIndex = 0;
            this.skinTextBoxPrice.TabStop = true;
            this.skinTextBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxPrice.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPrice.WaterText = "编号";
            this.skinTextBoxPrice.WordWrap = true;
            // 
            // baseButtonCancel
            // 
            this.baseButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.baseButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonCancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonCancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonCancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonCancel.Location = new System.Drawing.Point(250, 367);
            this.baseButtonCancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonCancel.Name = "baseButtonCancel";
            this.baseButtonCancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.baseButtonCancel.TabIndex = 3;
            this.baseButtonCancel.Text = "取消";
            this.baseButtonCancel.UseVisualStyleBackColor = false;
            this.baseButtonCancel.Click += new System.EventHandler(this.baseButtonCancel_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(35, 50);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(44, 17);
            this.skinLabel4.TabIndex = 85;
            this.skinLabel4.Text = "款号：";
            // 
            // skinLabelCustomer
            // 
            this.skinLabelCustomer.AutoSize = true;
            this.skinLabelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelCustomer.BorderColor = System.Drawing.Color.White;
            this.skinLabelCustomer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelCustomer.Location = new System.Drawing.Point(79, 50);
            this.skinLabelCustomer.Name = "skinLabelCustomer";
            this.skinLabelCustomer.Size = new System.Drawing.Size(0, 17);
            this.skinLabelCustomer.TabIndex = 86;
            // 
            // dataGridViewRole
            // 
            this.dataGridViewRole.AllowUserToAddRows = false;
            this.dataGridViewRole.AllowUserToDeleteRows = false;
            this.dataGridViewRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRole.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5});
            this.dataGridViewRole.Location = new System.Drawing.Point(82, 138);
            this.dataGridViewRole.Name = "dataGridViewRole";
            this.dataGridViewRole.RowTemplate.Height = 23;
            this.dataGridViewRole.Size = new System.Drawing.Size(411, 214);
            this.dataGridViewRole.TabIndex = 133;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "店铺";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "Selected";
            this.Column5.FalseValue = "false";
            this.Column5.HeaderText = "选择";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.TrueValue = "true";
            this.Column5.Width = 54;
            // 
            // 店铺
            // 
            this.店铺.AutoSize = true;
            this.店铺.BackColor = System.Drawing.Color.Transparent;
            this.店铺.BorderColor = System.Drawing.Color.White;
            this.店铺.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.店铺.Location = new System.Drawing.Point(23, 138);
            this.店铺.Name = "店铺";
            this.店铺.Size = new System.Drawing.Size(44, 17);
            this.店铺.TabIndex = 134;
            this.店铺.Text = "款号：";
            // 
            // skinCheckBoxNew
            // 
            this.skinCheckBoxNew.AutoSize = true;
            this.skinCheckBoxNew.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxNew.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxNew.DownBack = null;
            this.skinCheckBoxNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxNew.Location = new System.Drawing.Point(442, 113);
            this.skinCheckBoxNew.MouseBack = null;
            this.skinCheckBoxNew.Name = "skinCheckBoxNew";
            this.skinCheckBoxNew.NormlBack = null;
            this.skinCheckBoxNew.SelectedDownBack = null;
            this.skinCheckBoxNew.SelectedMouseBack = null;
            this.skinCheckBoxNew.SelectedNormlBack = null;
            this.skinCheckBoxNew.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxNew.TabIndex = 135;
            this.skinCheckBoxNew.Text = "全选";
            this.skinCheckBoxNew.UseVisualStyleBackColor = false;
            this.skinCheckBoxNew.CheckedChanged += new System.EventHandler(this.skinCheckBoxNew_CheckedChanged);
            // 
            // UpdateShopPriceAndSalePriceForm
            // 
            this.AcceptButton = this.BaseButton_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = true;
            this.ClientSize = new System.Drawing.Size(532, 421);
            this.Controls.Add(this.skinCheckBoxNew);
            this.Controls.Add(this.店铺);
            this.Controls.Add(this.dataGridViewRole);
            this.Controls.Add(this.skinLabelCustomer);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBoxSalePrice);
            this.Controls.Add(this.skinTextBoxPrice);
            this.Controls.Add(this.baseButtonCancel);
            this.Controls.Add(this.BaseButton_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateShopPriceAndSalePriceForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "修改价格";
            this.Load += new System.EventHandler(this.UpdateShopPriceAndSalePriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Search;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.TextBox skinTextBoxSalePrice;
        private Common.TextBox skinTextBoxPrice;
        private Common.Components.BaseButton baseButtonCancel;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabelCustomer;
        private DataGridView dataGridViewRole;
        private CCWin.SkinControl.SkinLabel 店铺;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxNew;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewCheckBoxColumn Column5;
    }
}