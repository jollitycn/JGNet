using JGNet.Common;
using JGNet.Common.Components;

namespace JGNet.Manage
{
    partial class CashRecordInsertCtrl
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel2 = new System.Windows.Forms.Panel();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinTextBox_Remarks = new JGNet.Common.TextBox();
            this.skinTextBox_MoneyCash = new JGNet.Common.NumericTextBox();
            this.skinComboBox_FeeDetailType = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBox_FeeType = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(551, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(88, 26);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "现金记录";
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.skinLabel1);
            this.skinPanel2.Controls.Add(this.BaseButton1);
            this.skinPanel2.Controls.Add(this.skinTextBox_Remarks);
            this.skinPanel2.Controls.Add(this.skinTextBox_MoneyCash);
            this.skinPanel2.Controls.Add(this.skinComboBox_FeeDetailType);
            this.skinPanel2.Controls.Add(this.skinComboBox_FeeType);
            this.skinPanel2.Controls.Add(this.skinLabel6);
            this.skinPanel2.Controls.Add(this.skinLabel4);
            this.skinPanel2.Controls.Add(this.skinLabel3);
            this.skinPanel2.Controls.Add(this.skinLabel2);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel2.Location = new System.Drawing.Point(0, 0);
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.Size = new System.Drawing.Size(1160, 650);
            this.skinPanel2.TabIndex = 2;
            // 
            // BaseButton1
            // 
            this.BaseButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(558, 244);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 6;
            this.BaseButton1.Text = "保存";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // skinTextBox_Remarks
            // 
            this.skinTextBox_Remarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Remarks.DownBack = null;
            this.skinTextBox_Remarks.Icon = null;
            this.skinTextBox_Remarks.IconIsButton = false;
            this.skinTextBox_Remarks.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.IsPasswordChat = '\0';
            this.skinTextBox_Remarks.IsSystemPasswordChar = false;
            this.skinTextBox_Remarks.Lines = new string[0];
            this.skinTextBox_Remarks.Location = new System.Drawing.Point(359, 144);
            this.skinTextBox_Remarks.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Remarks.MaxLength = 32767;
            this.skinTextBox_Remarks.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Remarks.MouseBack = null;
            this.skinTextBox_Remarks.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Remarks.Multiline = false;
            this.skinTextBox_Remarks.Name = "skinTextBox_Remarks";
            this.skinTextBox_Remarks.NormlBack = null;
            this.skinTextBox_Remarks.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Remarks.ReadOnly = false;
            this.skinTextBox_Remarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Remarks.Size = new System.Drawing.Size(496, 28);
            // 
            // 
            // 
            this.skinTextBox_Remarks.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Remarks.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Remarks.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Remarks.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Remarks.SkinTxt.Name = "BaseText";
            this.skinTextBox_Remarks.SkinTxt.Size = new System.Drawing.Size(486, 18);
            this.skinTextBox_Remarks.SkinTxt.TabIndex = 0;
            this.skinTextBox_Remarks.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.SkinTxt.WaterText = "";
            this.skinTextBox_Remarks.TabIndex = 4;
            this.skinTextBox_Remarks.TabStop = true;
            this.skinTextBox_Remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Remarks.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.WaterText = "";
            this.skinTextBox_Remarks.WordWrap = true;
            this.skinTextBox_Remarks.Paint += new System.Windows.Forms.PaintEventHandler(this.skinTextBox_Remarks_Paint);
            // 
            // skinTextBox_MoneyCash
            // 
            this.skinTextBox_MoneyCash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_MoneyCash.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_MoneyCash.DecimalPlaces = 0;
            this.skinTextBox_MoneyCash.DownBack = null;
            this.skinTextBox_MoneyCash.Icon = null;
            this.skinTextBox_MoneyCash.IconIsButton = false;
            this.skinTextBox_MoneyCash.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_MoneyCash.IsPasswordChat = '\0';
            this.skinTextBox_MoneyCash.IsSystemPasswordChar = false;
            this.skinTextBox_MoneyCash.Lines = new string[0];
            this.skinTextBox_MoneyCash.Location = new System.Drawing.Point(359, 110);
            this.skinTextBox_MoneyCash.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_MoneyCash.MaxLength = 32767;
            this.skinTextBox_MoneyCash.MaxNum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.skinTextBox_MoneyCash.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_MoneyCash.MinNum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinTextBox_MoneyCash.MouseBack = null;
            this.skinTextBox_MoneyCash.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_MoneyCash.Multiline = false;
            this.skinTextBox_MoneyCash.Name = "skinTextBox_MoneyCash";
            this.skinTextBox_MoneyCash.NormlBack = null;
            this.skinTextBox_MoneyCash.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_MoneyCash.ReadOnly = false;
            this.skinTextBox_MoneyCash.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_MoneyCash.ShowZero = false;
            this.skinTextBox_MoneyCash.Size = new System.Drawing.Size(496, 28);
            // 
            // 
            // 
            this.skinTextBox_MoneyCash.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_MoneyCash.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_MoneyCash.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_MoneyCash.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_MoneyCash.SkinTxt.Name = "BaseText";
            this.skinTextBox_MoneyCash.SkinTxt.Size = new System.Drawing.Size(486, 18);
            this.skinTextBox_MoneyCash.SkinTxt.TabIndex = 0;
            this.skinTextBox_MoneyCash.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_MoneyCash.SkinTxt.WaterText = "";
            this.skinTextBox_MoneyCash.TabIndex = 2;
            this.skinTextBox_MoneyCash.TabStop = true;
            this.skinTextBox_MoneyCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_MoneyCash.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.skinTextBox_MoneyCash.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_MoneyCash.WaterText = "";
            this.skinTextBox_MoneyCash.WordWrap = true;
            // 
            // skinComboBox_FeeDetailType
            // 
            this.skinComboBox_FeeDetailType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBox_FeeDetailType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_FeeDetailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_FeeDetailType.FormattingEnabled = true;
            this.skinComboBox_FeeDetailType.Location = new System.Drawing.Point(359, 82);
            this.skinComboBox_FeeDetailType.Name = "skinComboBox_FeeDetailType";
            this.skinComboBox_FeeDetailType.Size = new System.Drawing.Size(496, 22);
            this.skinComboBox_FeeDetailType.TabIndex = 1;
            this.skinComboBox_FeeDetailType.WaterText = "";
            // 
            // skinComboBox_FeeType
            // 
            this.skinComboBox_FeeType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinComboBox_FeeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_FeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_FeeType.FormattingEnabled = true;
            this.skinComboBox_FeeType.Location = new System.Drawing.Point(359, 54);
            this.skinComboBox_FeeType.Name = "skinComboBox_FeeType";
            this.skinComboBox_FeeType.Size = new System.Drawing.Size(496, 22);
            this.skinComboBox_FeeType.TabIndex = 0;
            this.skinComboBox_FeeType.WaterText = "";
            this.skinComboBox_FeeType.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_FeeType_SelectedIndexChanged);
            // 
            // skinLabel6
            // 
            this.skinLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(321, 152);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 0;
            this.skinLabel6.Text = "备注";
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(321, 118);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "金额";
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(321, 87);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "明细";
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(321, 59);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "类型";
            // 
            // CashRecordInsertCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinPanel2);
            this.Name = "CashRecordInsertCtrl";
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Panel skinPanel2;
        private  JGNet.Common.TextBox skinTextBox_Remarks;
        private CCWin.SkinControl.SkinComboBox skinComboBox_FeeDetailType;
        private CCWin.SkinControl.SkinComboBox skinComboBox_FeeType;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private Common.Components.BaseButton BaseButton1;
        private NumericTextBox skinTextBox_MoneyCash;
    }
}
