namespace JGNet.Manage
{
    partial class LevelSettingCtrl1
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
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinTextBox_Percent = new JGNet.Common.NumericTextBox();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(365, 197);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(92, 17);
            this.skinLabel2.TabIndex = 66;
            this.skinLabel2.Text = "佣金抽成比例：";
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinTextBox_Percent);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160,650);
            this.skinPanel1.TabIndex = 79;
            // 
            // skinTextBox_Percent
            // 
            this.skinTextBox_Percent.AutoSize = true;
            this.skinTextBox_Percent.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Percent.DecimalPlaces = 0;
            this.skinTextBox_Percent.DownBack = null;
            this.skinTextBox_Percent.Icon = null;
            this.skinTextBox_Percent.IconIsButton = false;
            this.skinTextBox_Percent.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Percent.IsPasswordChat = '\0';
            this.skinTextBox_Percent.IsSystemPasswordChar = false;
            this.skinTextBox_Percent.Lines = new string[0];
            this.skinTextBox_Percent.Location = new System.Drawing.Point(498, 191);
            this.skinTextBox_Percent.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Percent.MaxLength = 4;
            this.skinTextBox_Percent.MaxNum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.skinTextBox_Percent.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Percent.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinTextBox_Percent.MouseBack = null;
            this.skinTextBox_Percent.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Percent.Multiline = true;
            this.skinTextBox_Percent.Name = "skinTextBox_Percent";
            this.skinTextBox_Percent.NormlBack = null;
            this.skinTextBox_Percent.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Percent.ReadOnly = false;
            this.skinTextBox_Percent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Percent.ShowZero = false;
            this.skinTextBox_Percent.Size = new System.Drawing.Size(108, 29);
            // 
            // 
            // 
            this.skinTextBox_Percent.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.skinTextBox_Percent.SkinTxt.MaxLength = 4;
            this.skinTextBox_Percent.SkinTxt.Multiline = true;
            this.skinTextBox_Percent.SkinTxt.Name = "BaseText";
            this.skinTextBox_Percent.SkinTxt.Size = new System.Drawing.Size(100, 18);
            this.skinTextBox_Percent.SkinTxt.TabIndex = 0;
            this.skinTextBox_Percent.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Percent.SkinTxt.WaterText = "";
            this.skinTextBox_Percent.TabIndex = 164;
            this.skinTextBox_Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Percent.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinTextBox_Percent.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Percent.WaterText = "";
            this.skinTextBox_Percent.WordWrap = true;
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(440, 349);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "保存";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(463, 197);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 66;
            this.skinLabel3.Text = "一级";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(605, 197);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(19, 17);
            this.skinLabel1.TabIndex = 66;
            this.skinLabel1.Text = "%";
            // 
            // LevelSettingCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel1);
            this.Name = "LevelSettingCtrl";
            this.Load += new System.EventHandler(this.ChangePasswordAdminUserCtrl_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.Panel skinPanel1;
        private Common.Components.BaseButton BaseButton3;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private Common.NumericTextBox skinTextBox_Percent;
    }
}
