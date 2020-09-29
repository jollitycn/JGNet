namespace JGNet.Manage.Pages.RuleSettings.SalesPromotion
{
    partial class DiscountRuleCtrl
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
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.numericUpDownRecharge = new JGNet.Common.NumericTextBox();
            this.numericUpDownDonate = new JGNet.Common.NumericTextBox();
            this.dataGridViewCostume = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostume)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(214, 13);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 150;
            this.skinLabel4.Text = "折扣";
            // 
            // skinLabel5
            // 
            this.skinLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(13, 13);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 151;
            this.skinLabel5.Text = "购买数量";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.skinLabel5);
            this.panel1.Controls.Add(this.BaseButton3);
            this.panel1.Controls.Add(this.numericUpDownRecharge);
            this.panel1.Controls.Add(this.skinLabel4);
            this.panel1.Controls.Add(this.numericUpDownDonate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 40);
            this.panel1.TabIndex = 156;
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(383, 5);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "添加明细";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton2_Click);
            // 
            // numericUpDownRecharge
            // 
            this.numericUpDownRecharge.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownRecharge.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownRecharge.DecimalPlaces = 0;
            this.numericUpDownRecharge.DownBack = null;
            this.numericUpDownRecharge.Icon = null;
            this.numericUpDownRecharge.IconIsButton = false;
            this.numericUpDownRecharge.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownRecharge.IsPasswordChat = '\0';
            this.numericUpDownRecharge.IsSystemPasswordChar = false;
            this.numericUpDownRecharge.Lines = new string[0];
            this.numericUpDownRecharge.Location = new System.Drawing.Point(75, 7);
            this.numericUpDownRecharge.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownRecharge.MaxLength = 32767;
            this.numericUpDownRecharge.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDownRecharge.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericUpDownRecharge.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownRecharge.MouseBack = null;
            this.numericUpDownRecharge.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownRecharge.Multiline = false;
            this.numericUpDownRecharge.Name = "numericUpDownRecharge";
            this.numericUpDownRecharge.NormlBack = null;
            this.numericUpDownRecharge.Padding = new System.Windows.Forms.Padding(5);
            this.numericUpDownRecharge.ReadOnly = false;
            this.numericUpDownRecharge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericUpDownRecharge.ShowZero = false;
            this.numericUpDownRecharge.Size = new System.Drawing.Size(117, 28);
            // 
            // 
            // 
            this.numericUpDownRecharge.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownRecharge.SkinTxt.Name = "BaseText";
            this.numericUpDownRecharge.SkinTxt.TabIndex = 0;
            this.numericUpDownRecharge.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownRecharge.SkinTxt.WaterText = "";
            this.numericUpDownRecharge.TabIndex = 0;
            this.numericUpDownRecharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericUpDownRecharge.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownRecharge.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownRecharge.WaterText = "";
            this.numericUpDownRecharge.WordWrap = true;
            // 
            // numericUpDownDonate
            // 
            this.numericUpDownDonate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownDonate.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownDonate.DecimalPlaces = 2;
            this.numericUpDownDonate.DownBack = null;
            this.numericUpDownDonate.Icon = null;
            this.numericUpDownDonate.IconIsButton = false;
            this.numericUpDownDonate.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownDonate.IsPasswordChat = '\0';
            this.numericUpDownDonate.IsSystemPasswordChar = false;
            this.numericUpDownDonate.Lines = new string[] {
        "100"};
            this.numericUpDownDonate.Location = new System.Drawing.Point(252, 7);
            this.numericUpDownDonate.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownDonate.MaxLength = 32767;
            this.numericUpDownDonate.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDownDonate.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericUpDownDonate.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownDonate.MouseBack = null;
            this.numericUpDownDonate.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownDonate.Multiline = false;
            this.numericUpDownDonate.Name = "numericUpDownDonate";
            this.numericUpDownDonate.NormlBack = null;
            this.numericUpDownDonate.Padding = new System.Windows.Forms.Padding(5);
            this.numericUpDownDonate.ReadOnly = false;
            this.numericUpDownDonate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericUpDownDonate.ShowZero = false;
            this.numericUpDownDonate.Size = new System.Drawing.Size(110, 28);
            // 
            // 
            // 
            this.numericUpDownDonate.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownDonate.SkinTxt.Name = "BaseText";
            this.numericUpDownDonate.SkinTxt.TabIndex = 0;
            this.numericUpDownDonate.SkinTxt.Text = "100";
            this.numericUpDownDonate.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownDonate.SkinTxt.WaterText = "";
            this.numericUpDownDonate.TabIndex = 1;
            this.numericUpDownDonate.Text = "100";
            this.numericUpDownDonate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericUpDownDonate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDonate.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownDonate.WaterText = "";
            this.numericUpDownDonate.WordWrap = true;
            // 
            // dataGridViewCostume
            // 
            this.dataGridViewCostume.AllowUserToAddRows = false;
            this.dataGridViewCostume.AllowUserToDeleteRows = false;
            this.dataGridViewCostume.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCostume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCostume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewCostume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCostume.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewCostume.Name = "dataGridViewCostume";
            this.dataGridViewCostume.ReadOnly = true;
            this.dataGridViewCostume.RowTemplate.Height = 23;
            this.dataGridViewCostume.Size = new System.Drawing.Size(470, 160);
            this.dataGridViewCostume.TabIndex = 157;
            this.dataGridViewCostume.TabStop = false;
            this.dataGridViewCostume.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCostume_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Key";
            this.dataGridViewTextBoxColumn1.HeaderText = "购买数量";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn2.HeaderText = "折扣";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewLinkColumn1.HeaderText = "删除";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.ReadOnly = true;
            this.dataGridViewLinkColumn1.Text = "删除";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Key";
            this.Column2.HeaderText = "购买数量";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 211;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "Value";
            this.Column3.HeaderText = "折扣";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 211;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Text = "删除";
            this.Column4.UseColumnTextForLinkValue = true;
            this.Column4.Width = 40;
            // 
            // DiscountRuleCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewCostume);
            this.Controls.Add(this.panel1);
            this.Name = "DiscountRuleCtrl";
            this.Size = new System.Drawing.Size(470, 200);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private JGNet.Common.NumericTextBox numericUpDownRecharge;
        private JGNet.Common.NumericTextBox numericUpDownDonate;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private Common.Components.BaseButton BaseButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCostume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewLinkColumn Column4;
    }
}
