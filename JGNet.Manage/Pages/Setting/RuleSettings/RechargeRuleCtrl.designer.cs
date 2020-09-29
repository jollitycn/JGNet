using System.Windows.Forms;

namespace JGNet.Manage
{
    partial class RechargeRuleCtrl
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
            this.BaseButton2 = new JGNet.Common.Components.BaseButton();
            this.numericUpDownRecharge = new JGNet.Common.NumericTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.numericUpDownDonate = new JGNet.Common.NumericTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.dataGridViewRuleExpression = new System.Windows.Forms.DataGridView();
            this.ruleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel3 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn4 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRuleExpression)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleBindingSource)).BeginInit();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseButton2
            // 
            this.BaseButton2.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton2.Location = new System.Drawing.Point(398, 5);
            this.BaseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton2.Name = "BaseButton2";
            this.BaseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton2.Size = new System.Drawing.Size(75, 32);
            this.BaseButton2.TabIndex = 4;
            this.BaseButton2.Text = "添加";
            this.BaseButton2.UseVisualStyleBackColor = false;
            this.BaseButton2.Click += new System.EventHandler(this.BaseButton2_Click);
            // 
            // numericUpDownRecharge
            // 
            this.numericUpDownRecharge.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownRecharge.DecimalPlaces = 0;
            this.numericUpDownRecharge.DownBack = null;
            this.numericUpDownRecharge.Icon = null;
            this.numericUpDownRecharge.IconIsButton = false;
            this.numericUpDownRecharge.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownRecharge.IsPasswordChat = '\0';
            this.numericUpDownRecharge.IsSystemPasswordChar = false;
            this.numericUpDownRecharge.Lines = new string[0];
            this.numericUpDownRecharge.Location = new System.Drawing.Point(65, 7);
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
            this.numericUpDownRecharge.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.numericUpDownRecharge.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownRecharge.SkinTxt.Name = "BaseText";
            this.numericUpDownRecharge.SkinTxt.TabIndex = 0;
            this.numericUpDownRecharge.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownRecharge.SkinTxt.WaterText = "";
            this.numericUpDownRecharge.TabIndex = 2;
            this.numericUpDownRecharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericUpDownRecharge.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownRecharge.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownRecharge.WaterText = "";
            this.numericUpDownRecharge.WordWrap = true;
            this.numericUpDownRecharge.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownRecharge_Validating);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(6, 13);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 47;
            this.skinLabel1.Text = "充值金额";
            // 
            // numericUpDownDonate
            // 
            this.numericUpDownDonate.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownDonate.DecimalPlaces = 0;
            this.numericUpDownDonate.DownBack = null;
            this.numericUpDownDonate.Icon = null;
            this.numericUpDownDonate.IconIsButton = false;
            this.numericUpDownDonate.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericUpDownDonate.IsPasswordChat = '\0';
            this.numericUpDownDonate.IsSystemPasswordChar = false;
            this.numericUpDownDonate.Lines = new string[0];
            this.numericUpDownDonate.Location = new System.Drawing.Point(265, 7);
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
            this.numericUpDownDonate.Size = new System.Drawing.Size(130, 28);
            // 
            // 
            // 
            this.numericUpDownDonate.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.numericUpDownDonate.SkinTxt.Name = "BaseText";
            this.numericUpDownDonate.SkinTxt.TabIndex = 0;
            this.numericUpDownDonate.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownDonate.SkinTxt.WaterText = "";
            this.numericUpDownDonate.TabIndex = 3;
            this.numericUpDownDonate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericUpDownDonate.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownDonate.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericUpDownDonate.WaterText = "";
            this.numericUpDownDonate.WordWrap = true;
            this.numericUpDownDonate.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownDonate_Validating);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(203, 13);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 47;
            this.skinLabel2.Text = "赠送金额";
            // 
            // dataGridViewRuleExpression
            // 
            this.dataGridViewRuleExpression.AllowUserToAddRows = false;
            this.dataGridViewRuleExpression.AllowUserToDeleteRows = false;
            this.dataGridViewRuleExpression.AllowUserToOrderColumns = true;
            this.dataGridViewRuleExpression.AutoGenerateColumns = false;
            this.dataGridViewRuleExpression.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRuleExpression.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewLinkColumn4});
            this.dataGridViewRuleExpression.DataSource = this.ruleBindingSource;
            this.dataGridViewRuleExpression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRuleExpression.Location = new System.Drawing.Point(5, 47);
            this.dataGridViewRuleExpression.MultiSelect = false;
            this.dataGridViewRuleExpression.Name = "dataGridViewRuleExpression";
            this.dataGridViewRuleExpression.RowTemplate.Height = 23;
            this.dataGridViewRuleExpression.Size = new System.Drawing.Size(955, 498);
            this.dataGridViewRuleExpression.TabIndex = 5;
            this.dataGridViewRuleExpression.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRuleExpression_CellClick);
            this.dataGridViewRuleExpression.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRuleExpression_CellValueChanged);
            // 
            // ruleBindingSource
            // 
            this.ruleBindingSource.DataSource = typeof(JGNet.Rule);
            // 
            // skinPanel3
            // 
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.Controls.Add(this.BaseButton2);
            this.skinPanel3.Controls.Add(this.numericUpDownRecharge);
            this.skinPanel3.Controls.Add(this.skinLabel1);
            this.skinPanel3.Controls.Add(this.numericUpDownDonate);
            this.skinPanel3.Controls.Add(this.skinLabel2);
            this.skinPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel3.Location = new System.Drawing.Point(5, 5);
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.Size = new System.Drawing.Size(955, 42);
            this.skinPanel3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RechargeMoney";
            this.dataGridViewTextBoxColumn5.HeaderText = "充值金额";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 520;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DonateMoney";
            this.dataGridViewTextBoxColumn6.HeaderText = "赠送金额";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 550;
            // 
            // dataGridViewLinkColumn4
            // 
            this.dataGridViewLinkColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewLinkColumn4.HeaderText = "删除";
            this.dataGridViewLinkColumn4.Name = "dataGridViewLinkColumn4";
            this.dataGridViewLinkColumn4.ReadOnly = true;
            this.dataGridViewLinkColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLinkColumn4.Text = "删除";
            this.dataGridViewLinkColumn4.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn4.Width = 40;
            // 
            // RechargeRuleCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dataGridViewRuleExpression);
            this.Controls.Add(this.skinPanel3);
            this.Name = "RechargeRuleCtrl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(965, 550);
            this.Load += new System.EventHandler(this.RechargeRuleCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRuleExpression)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleBindingSource)).EndInit();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Components.BaseButton BaseButton2;
        private Common.NumericTextBox numericUpDownRecharge;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.NumericTextBox numericUpDownDonate;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private DataGridView dataGridViewRuleExpression;
        private Panel skinPanel3;
        private BindingSource ruleBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewLinkColumn dataGridViewLinkColumn4;
    }
}
