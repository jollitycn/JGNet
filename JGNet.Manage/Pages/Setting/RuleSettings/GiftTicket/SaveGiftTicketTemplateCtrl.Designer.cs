using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    partial class SaveGiftTicketTemplateCtrl
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
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_minDiscount = new JGNet.Common.TextBox();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinPanel3 = new System.Windows.Forms.Panel();
            this.skinRadioButton1 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton2 = new CCWin.SkinControl.SkinRadioButton();
            this.BaseButton2 = new JGNet.Common.Components.BaseButton();
            this.numericTextBox_denomination = new JGNet.Common.NumericTextBox();
            this.skinTextBox_minMoney = new JGNet.Common.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelTicketDesc = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.skinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(539, 22);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(69, 26);
            this.skinLabel3.TabIndex = 135;
            this.skinLabel3.Text = "优惠券";
            // 
            // skinLabel6
            // 
            this.skinLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(322, 157);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(56, 17);
            this.skinLabel6.TabIndex = 137;
            this.skinLabel6.Text = "最低折扣";
            // 
            // skinTextBox_minDiscount
            // 
            this.skinTextBox_minDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_minDiscount.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_minDiscount.DownBack = null;
            this.skinTextBox_minDiscount.Icon = null;
            this.skinTextBox_minDiscount.IconIsButton = false;
            this.skinTextBox_minDiscount.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_minDiscount.IsPasswordChat = '\0';
            this.skinTextBox_minDiscount.IsSystemPasswordChar = false;
            this.skinTextBox_minDiscount.Lines = new string[0];
            this.skinTextBox_minDiscount.Location = new System.Drawing.Point(390, 151);
            this.skinTextBox_minDiscount.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_minDiscount.MaxLength = 32767;
            this.skinTextBox_minDiscount.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_minDiscount.MouseBack = null;
            this.skinTextBox_minDiscount.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_minDiscount.Multiline = false;
            this.skinTextBox_minDiscount.Name = "skinTextBox_minDiscount";
            this.skinTextBox_minDiscount.NormlBack = null;
            this.skinTextBox_minDiscount.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_minDiscount.ReadOnly = false;
            this.skinTextBox_minDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_minDiscount.Size = new System.Drawing.Size(402, 28);
            // 
            // 
            // 
            this.skinTextBox_minDiscount.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_minDiscount.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_minDiscount.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_minDiscount.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_minDiscount.SkinTxt.Name = "BaseText";
            this.skinTextBox_minDiscount.SkinTxt.Size = new System.Drawing.Size(392, 18);
            this.skinTextBox_minDiscount.SkinTxt.TabIndex = 0;
            this.skinTextBox_minDiscount.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_minDiscount.SkinTxt.WaterText = "输入折扣百分比，如：80(表示8折)";
            this.skinTextBox_minDiscount.TabIndex = 4;
            this.skinTextBox_minDiscount.TabStop = true;
            this.skinTextBox_minDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_minDiscount.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_minDiscount.WaterText = "输入折扣百分比，如：80(表示8折)";
            this.skinTextBox_minDiscount.WordWrap = true;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinPanel3);
            this.skinPanel1.Controls.Add(this.BaseButton2);
            this.skinPanel1.Controls.Add(this.numericTextBox_denomination);
            this.skinPanel1.Controls.Add(this.skinTextBox_minMoney);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinTextBox_minDiscount);
            this.skinPanel1.Controls.Add(this.skinLabelTicketDesc);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 650);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinPanel3
            // 
            this.skinPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinPanel3.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.skinPanel3.Controls.Add(this.skinRadioButton1);
            this.skinPanel3.Controls.Add(this.skinRadioButton2);
            this.skinPanel3.Location = new System.Drawing.Point(390, 182);
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.Size = new System.Drawing.Size(402, 28);
            this.skinPanel3.TabIndex = 150;
            // 
            // skinRadioButton1
            // 
            this.skinRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinRadioButton1.AutoSize = true;
            this.skinRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton1.Checked = true;
            this.skinRadioButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton1.DownBack = null;
            this.skinRadioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton1.Location = new System.Drawing.Point(3, 3);
            this.skinRadioButton1.MouseBack = null;
            this.skinRadioButton1.Name = "skinRadioButton1";
            this.skinRadioButton1.NormlBack = null;
            this.skinRadioButton1.SelectedDownBack = null;
            this.skinRadioButton1.SelectedMouseBack = null;
            this.skinRadioButton1.SelectedNormlBack = null;
            this.skinRadioButton1.Size = new System.Drawing.Size(122, 21);
            this.skinRadioButton1.TabIndex = 6;
            this.skinRadioButton1.TabStop = true;
            this.skinRadioButton1.Tag = "sexRadio";
            this.skinRadioButton1.Text = "满足其中一个条件";
            this.skinRadioButton1.UseVisualStyleBackColor = false;
            this.skinRadioButton1.CheckedChanged += new System.EventHandler(this.skinRadioButton1_CheckedChanged);
            // 
            // skinRadioButton2
            // 
            this.skinRadioButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinRadioButton2.AutoSize = true;
            this.skinRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton2.DownBack = null;
            this.skinRadioButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton2.Location = new System.Drawing.Point(191, 3);
            this.skinRadioButton2.MouseBack = null;
            this.skinRadioButton2.Name = "skinRadioButton2";
            this.skinRadioButton2.NormlBack = null;
            this.skinRadioButton2.SelectedDownBack = null;
            this.skinRadioButton2.SelectedMouseBack = null;
            this.skinRadioButton2.SelectedNormlBack = null;
            this.skinRadioButton2.Size = new System.Drawing.Size(158, 21);
            this.skinRadioButton2.TabIndex = 6;
            this.skinRadioButton2.TabStop = true;
            this.skinRadioButton2.Tag = "sexRadio";
            this.skinRadioButton2.Text = "两个条件都需要同时满足";
            this.skinRadioButton2.UseVisualStyleBackColor = false;
            this.skinRadioButton2.CheckedChanged += new System.EventHandler(this.skinRadioButton2_CheckedChanged);
            // 
            // BaseButton2
            // 
            this.BaseButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BaseButton2.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton2.Location = new System.Drawing.Point(536, 266);
            this.BaseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton2.Name = "BaseButton2";
            this.BaseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton2.Size = new System.Drawing.Size(75, 32);
            this.BaseButton2.TabIndex = 149;
            this.BaseButton2.Text = "保存";
            this.BaseButton2.UseVisualStyleBackColor = false;
            this.BaseButton2.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // numericTextBox_denomination
            // 
            this.numericTextBox_denomination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericTextBox_denomination.BackColor = System.Drawing.Color.Transparent;
            this.numericTextBox_denomination.DecimalPlaces = 0;
            this.numericTextBox_denomination.DownBack = null;
            this.numericTextBox_denomination.Icon = null;
            this.numericTextBox_denomination.IconIsButton = false;
            this.numericTextBox_denomination.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBox_denomination.IsPasswordChat = '\0';
            this.numericTextBox_denomination.IsSystemPasswordChar = false;
            this.numericTextBox_denomination.Lines = new string[0];
            this.numericTextBox_denomination.Location = new System.Drawing.Point(390, 87);
            this.numericTextBox_denomination.Margin = new System.Windows.Forms.Padding(0);
            this.numericTextBox_denomination.MaxLength = 32767;
            this.numericTextBox_denomination.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericTextBox_denomination.MinimumSize = new System.Drawing.Size(28, 28);
            this.numericTextBox_denomination.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBox_denomination.MouseBack = null;
            this.numericTextBox_denomination.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.numericTextBox_denomination.Multiline = false;
            this.numericTextBox_denomination.Name = "numericTextBox_denomination";
            this.numericTextBox_denomination.NormlBack = null;
            this.numericTextBox_denomination.Padding = new System.Windows.Forms.Padding(5);
            this.numericTextBox_denomination.ReadOnly = false;
            this.numericTextBox_denomination.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numericTextBox_denomination.ShowZero = false;
            this.numericTextBox_denomination.Size = new System.Drawing.Size(402, 28);
            // 
            // 
            // 
            this.numericTextBox_denomination.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericTextBox_denomination.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericTextBox_denomination.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.numericTextBox_denomination.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.numericTextBox_denomination.SkinTxt.Name = "BaseText";
            this.numericTextBox_denomination.SkinTxt.Size = new System.Drawing.Size(392, 18);
            this.numericTextBox_denomination.SkinTxt.TabIndex = 0;
            this.numericTextBox_denomination.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBox_denomination.SkinTxt.WaterText = "";
            this.numericTextBox_denomination.TabIndex = 1;
            this.numericTextBox_denomination.TabStop = true;
            this.numericTextBox_denomination.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numericTextBox_denomination.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTextBox_denomination.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.numericTextBox_denomination.WaterText = "";
            this.numericTextBox_denomination.WordWrap = true;
            this.numericTextBox_denomination.ValueChanged += new System.Action<object>(this.numericTextBox_denomination_ValueChanged);
            this.numericTextBox_denomination.Validating += new System.ComponentModel.CancelEventHandler(this.numericTextBox_denomination_Validating);
            // 
            // skinTextBox_minMoney
            // 
            this.skinTextBox_minMoney.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_minMoney.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_minMoney.DownBack = null;
            this.skinTextBox_minMoney.Icon = null;
            this.skinTextBox_minMoney.IconIsButton = false;
            this.skinTextBox_minMoney.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_minMoney.IsPasswordChat = '\0';
            this.skinTextBox_minMoney.IsSystemPasswordChar = false;
            this.skinTextBox_minMoney.Lines = new string[0];
            this.skinTextBox_minMoney.Location = new System.Drawing.Point(390, 119);
            this.skinTextBox_minMoney.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_minMoney.MaxLength = 32767;
            this.skinTextBox_minMoney.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_minMoney.MouseBack = null;
            this.skinTextBox_minMoney.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_minMoney.Multiline = false;
            this.skinTextBox_minMoney.Name = "skinTextBox_minMoney";
            this.skinTextBox_minMoney.NormlBack = null;
            this.skinTextBox_minMoney.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_minMoney.ReadOnly = false;
            this.skinTextBox_minMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_minMoney.Size = new System.Drawing.Size(402, 28);
            // 
            // 
            // 
            this.skinTextBox_minMoney.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_minMoney.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_minMoney.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_minMoney.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_minMoney.SkinTxt.Name = "BaseText";
            this.skinTextBox_minMoney.SkinTxt.Size = new System.Drawing.Size(392, 18);
            this.skinTextBox_minMoney.SkinTxt.TabIndex = 0;
            this.skinTextBox_minMoney.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_minMoney.SkinTxt.WaterText = "";
            this.skinTextBox_minMoney.TabIndex = 1;
            this.skinTextBox_minMoney.TabStop = true;
            this.skinTextBox_minMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_minMoney.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_minMoney.WaterText = "";
            this.skinTextBox_minMoney.WordWrap = true;
            this.skinTextBox_minMoney.Validating += new System.ComponentModel.CancelEventHandler(this.skinTextBox_minMoney_Validating_1);
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(310, 93);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 148;
            this.skinLabel1.Text = "优惠券面额";
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(322, 125);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 148;
            this.skinLabel2.Text = "最低金额";
            // 
            // skinLabelTicketDesc
            // 
            this.skinLabelTicketDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabelTicketDesc.AutoSize = true;
            this.skinLabelTicketDesc.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelTicketDesc.BorderColor = System.Drawing.Color.White;
            this.skinLabelTicketDesc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelTicketDesc.Location = new System.Drawing.Point(391, 221);
            this.skinLabelTicketDesc.Name = "skinLabelTicketDesc";
            this.skinLabelTicketDesc.Size = new System.Drawing.Size(23, 17);
            this.skinLabelTicketDesc.TabIndex = 137;
            this.skinLabelTicketDesc.Text = "---";
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(322, 221);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(56, 17);
            this.skinLabel4.TabIndex = 137;
            this.skinLabel4.Text = "条件描述";
            // 
            // skinLabel5
            // 
            this.skinLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(322, 188);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 17);
            this.skinLabel5.TabIndex = 137;
            this.skinLabel5.Text = "条件设置";
            // 
            // SaveGiftTicketTemplateCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel1);
            this.Name = "SaveGiftTicketTemplateCtrl";
            this.Load += new System.EventHandler(this.SaveGiftTicketTemplateCtrl_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private Common.TextBox skinTextBox_Remarks;
        private Common.TextBox skinTextBox_Name;
        private Panel skinPanel1;
        private Common.Components.BaseButton BaseButton2;
        private Common.TextBox skinTextBox_minDiscount;
        private Common.NumericTextBox numericTextBox_denomination;
        private Common.TextBox skinTextBox_minMoney;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabelTicketDesc;
        private Panel skinPanel3;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton1;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton2;
        private CCWin.SkinControl.SkinLabel skinLabel5;
    }
}
