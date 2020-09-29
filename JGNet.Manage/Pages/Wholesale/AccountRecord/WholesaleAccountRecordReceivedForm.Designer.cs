namespace JGNet.Manage.Components
{
    partial class WholesaleAccountRecordReceivedForm
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
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinRadioButtonBalance = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButtonCash = new CCWin.SkinControl.SkinRadioButton();
            this.SuspendLayout();
            // 
            // BaseButton_Search
            // 
            this.BaseButton_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton_Search.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Search.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Search.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Search.Location = new System.Drawing.Point(83, 144);
            this.BaseButton_Search.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Search.Name = "BaseButton_Search";
            this.BaseButton_Search.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Search.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Search.TabIndex = 3;
            this.BaseButton_Search.Text = "确定";
            this.BaseButton_Search.UseVisualStyleBackColor = false;
            this.BaseButton_Search.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(16, 40);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 84;
            this.skinLabel1.Text = "收款方式：";
            // 
            // skinRadioButtonBalance
            // 
            this.skinRadioButtonBalance.AutoSize = true;
            this.skinRadioButtonBalance.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonBalance.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonBalance.DownBack = null;
            this.skinRadioButtonBalance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonBalance.Location = new System.Drawing.Point(53, 71);
            this.skinRadioButtonBalance.MouseBack = null;
            this.skinRadioButtonBalance.Name = "skinRadioButtonBalance";
            this.skinRadioButtonBalance.NormlBack = null;
            this.skinRadioButtonBalance.SelectedDownBack = null;
            this.skinRadioButtonBalance.SelectedMouseBack = null;
            this.skinRadioButtonBalance.SelectedNormlBack = null;
            this.skinRadioButtonBalance.Size = new System.Drawing.Size(50, 21);
            this.skinRadioButtonBalance.TabIndex = 85;
            this.skinRadioButtonBalance.Tag = "sexRadio";
            this.skinRadioButtonBalance.Text = "余额";
            this.skinRadioButtonBalance.UseVisualStyleBackColor = false;
            this.skinRadioButtonBalance.CheckedChanged += new System.EventHandler(this.skinRadioButtonBalance_CheckedChanged);
            // 
            // skinRadioButtonCash
            // 
            this.skinRadioButtonCash.AutoSize = true;
            this.skinRadioButtonCash.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonCash.Checked = true;
            this.skinRadioButtonCash.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonCash.DownBack = null;
            this.skinRadioButtonCash.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonCash.Location = new System.Drawing.Point(53, 98);
            this.skinRadioButtonCash.MouseBack = null;
            this.skinRadioButtonCash.Name = "skinRadioButtonCash";
            this.skinRadioButtonCash.NormlBack = null;
            this.skinRadioButtonCash.SelectedDownBack = null;
            this.skinRadioButtonCash.SelectedMouseBack = null;
            this.skinRadioButtonCash.SelectedNormlBack = null;
            this.skinRadioButtonCash.Size = new System.Drawing.Size(50, 21);
            this.skinRadioButtonCash.TabIndex = 85;
            this.skinRadioButtonCash.TabStop = true;
            this.skinRadioButtonCash.Tag = "sexRadio";
            this.skinRadioButtonCash.Text = "其他";
            this.skinRadioButtonCash.UseVisualStyleBackColor = false;
            this.skinRadioButtonCash.CheckedChanged += new System.EventHandler(this.skinRadioButtonCash_CheckedChanged);
            // 
            // WholesaleAccountRecordReceivedForm
            // 
            this.AcceptButton = this.BaseButton_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 183);
            this.Controls.Add(this.skinRadioButtonCash);
            this.Controls.Add(this.skinRadioButtonBalance);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.BaseButton_Search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WholesaleAccountRecordReceivedForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Search;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonBalance;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonCash;
    }
}