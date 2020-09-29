namespace JGNet.Manage
{
    partial class ReceivedPaymentsCtrl
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
            this.guideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retailDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.textBoxAmount = new JGNet.Common.NumericTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.skinComboBox_PfCustomer = new JGNet.Common.PfCustomerTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            ((System.ComponentModel.ISupportInitialize)(this.guideBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guideBindingSource
            // 
            this.guideBindingSource.DataSource = typeof(JGNet.Guide);
            // 
            // retailDetailBindingSource
            // 
            this.retailDetailBindingSource.DataSource = typeof(JGNet.RetailDetail);
            // 
            // skinPanel1
            // 
            this.skinPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.textBoxAmount);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.dateTimePicker_End);
            this.skinPanel1.Controls.Add(this.skinComboBox_PfCustomer);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Location = new System.Drawing.Point(8, 8);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 650);
            this.skinPanel1.TabIndex = 80;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAmount.BackColor = System.Drawing.Color.Transparent;
            this.textBoxAmount.DecimalPlaces = 0;
            this.textBoxAmount.DownBack = null;
            this.textBoxAmount.Icon = null;
            this.textBoxAmount.IconIsButton = false;
            this.textBoxAmount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxAmount.IsPasswordChat = '\0';
            this.textBoxAmount.IsSystemPasswordChar = false;
            this.textBoxAmount.Lines = new string[0];
            this.textBoxAmount.Location = new System.Drawing.Point(508, 149);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAmount.MaxLength = 99999;
            this.textBoxAmount.MaxNum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.textBoxAmount.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxAmount.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxAmount.MouseBack = null;
            this.textBoxAmount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxAmount.Multiline = false;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.NormlBack = null;
            this.textBoxAmount.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxAmount.ReadOnly = false;
            this.textBoxAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAmount.ShowZero = false;
            this.textBoxAmount.Size = new System.Drawing.Size(206, 28);
            // 
            // 
            // 
            this.textBoxAmount.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.textBoxAmount.SkinTxt.MaxLength = 99999;
            this.textBoxAmount.SkinTxt.Name = "BaseText";
            this.textBoxAmount.SkinTxt.TabIndex = 0;
            this.textBoxAmount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxAmount.SkinTxt.WaterText = "";
            this.textBoxAmount.TabIndex = 165;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxAmount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textBoxAmount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxAmount.WaterText = "";
            this.textBoxAmount.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(413, 188);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(92, 17);
            this.skinLabel1.TabIndex = 92;
            this.skinLabel1.Text = "录入回款时间：";
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_End.Location = new System.Drawing.Point(508, 186);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(206, 21);
            this.dateTimePicker_End.TabIndex = 91;
            // 
            // skinComboBox_PfCustomer
            // 
            this.skinComboBox_PfCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinComboBox_PfCustomer.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBox_PfCustomer.CheckPfCustomer = false;
            this.skinComboBox_PfCustomer.DownBack = null;
            this.skinComboBox_PfCustomer.HideEmpty = false;
            this.skinComboBox_PfCustomer.Icon = null;
            this.skinComboBox_PfCustomer.IconIsButton = false;
            this.skinComboBox_PfCustomer.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinComboBox_PfCustomer.IsPasswordChat = '\0';
            this.skinComboBox_PfCustomer.IsSystemPasswordChar = false;
            this.skinComboBox_PfCustomer.Lines = new string[0];
            this.skinComboBox_PfCustomer.Location = new System.Drawing.Point(508, 117);
            this.skinComboBox_PfCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.skinComboBox_PfCustomer.MaxLength = 32767;
            this.skinComboBox_PfCustomer.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinComboBox_PfCustomer.MouseBack = null;
            this.skinComboBox_PfCustomer.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinComboBox_PfCustomer.Multiline = false;
            this.skinComboBox_PfCustomer.Name = "skinComboBox_PfCustomer";
            this.skinComboBox_PfCustomer.NormlBack = null;
            this.skinComboBox_PfCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.skinComboBox_PfCustomer.ReadOnly = false;
            this.skinComboBox_PfCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinComboBox_PfCustomer.Size = new System.Drawing.Size(206, 28);
            // 
            // 
            // 
            this.skinComboBox_PfCustomer.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.skinComboBox_PfCustomer.SkinTxt.Name = "BaseText";
            this.skinComboBox_PfCustomer.SkinTxt.TabIndex = 0;
            this.skinComboBox_PfCustomer.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinComboBox_PfCustomer.SkinTxt.WaterText = "输入编号/名称并回车";
            this.skinComboBox_PfCustomer.TabIndex = 0;
            this.skinComboBox_PfCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinComboBox_PfCustomer.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinComboBox_PfCustomer.WaterText = "输入编号/名称并回车";
            this.skinComboBox_PfCustomer.WordWrap = true;
            this.skinComboBox_PfCustomer.ItemSelected += new System.Action<JGNet.PfCustomer>(this.textBoxCustomer_ItemSelected);
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(413, 155);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(92, 17);
            this.skinLabel2.TabIndex = 89;
            this.skinLabel2.Text = "录入回款金额：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(408, 120);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(97, 17);
            this.skinLabel4.TabIndex = 90;
            this.skinLabel4.Text = "客户编号/名称：";
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(535, 241);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "保存";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButton3_Click);
            // 
            // ReceivedPaymentsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.skinPanel1);
            this.Name = "ReceivedPaymentsCtrl";
            ((System.ComponentModel.ISupportInitialize)(this.guideBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource retailDetailBindingSource;
        private System.Windows.Forms.BindingSource guideBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enabled;
        private System.Windows.Forms.Panel skinPanel1;
        private Common.Components.BaseButton BaseButton3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private Common.PfCustomerTextBox skinComboBox_PfCustomer;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private Common.NumericTextBox textBoxAmount;
    }
}
