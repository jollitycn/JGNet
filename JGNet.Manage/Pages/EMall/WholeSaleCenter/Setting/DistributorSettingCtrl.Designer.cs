namespace JGNet.Manage.Pages
{
    partial class DistributorSettingCtrl
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
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinRadioButtonBuyout = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButtonSale = new CCWin.SkinControl.SkinRadioButton();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(264, 151);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 10;
            this.BaseButton3.Text = "保存";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // skinLabel9
            // 
            this.skinLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(159, 57);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(80, 17);
            this.skinLabel9.TabIndex = 74;
            this.skinLabel9.Text = "佣金打款方式";
            // 
            // skinRadioButtonBuyout
            // 
            this.skinRadioButtonBuyout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinRadioButtonBuyout.AutoSize = true;
            this.skinRadioButtonBuyout.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonBuyout.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonBuyout.DownBack = null;
            this.skinRadioButtonBuyout.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonBuyout.Location = new System.Drawing.Point(344, 57);
            this.skinRadioButtonBuyout.MouseBack = null;
            this.skinRadioButtonBuyout.Name = "skinRadioButtonBuyout";
            this.skinRadioButtonBuyout.NormlBack = null;
            this.skinRadioButtonBuyout.SelectedDownBack = null;
            this.skinRadioButtonBuyout.SelectedMouseBack = null;
            this.skinRadioButtonBuyout.SelectedNormlBack = null;
            this.skinRadioButtonBuyout.Size = new System.Drawing.Size(98, 21);
            this.skinRadioButtonBuyout.TabIndex = 101;
            this.skinRadioButtonBuyout.Tag = "sexRadio";
            this.skinRadioButtonBuyout.Text = "后台主动打款";
            this.skinRadioButtonBuyout.UseVisualStyleBackColor = false;
            // 
            // skinRadioButtonSale
            // 
            this.skinRadioButtonSale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinRadioButtonSale.AutoSize = true;
            this.skinRadioButtonSale.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButtonSale.Checked = true;
            this.skinRadioButtonSale.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButtonSale.DownBack = null;
            this.skinRadioButtonSale.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButtonSale.Location = new System.Drawing.Point(255, 57);
            this.skinRadioButtonSale.MouseBack = null;
            this.skinRadioButtonSale.Name = "skinRadioButtonSale";
            this.skinRadioButtonSale.NormlBack = null;
            this.skinRadioButtonSale.SelectedDownBack = null;
            this.skinRadioButtonSale.SelectedMouseBack = null;
            this.skinRadioButtonSale.SelectedNormlBack = null;
            this.skinRadioButtonSale.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButtonSale.TabIndex = 102;
            this.skinRadioButtonSale.TabStop = true;
            this.skinRadioButtonSale.Tag = "sexRadio";
            this.skinRadioButtonSale.Text = "申请提现";
            this.skinRadioButtonSale.UseVisualStyleBackColor = false;
            // 
            // skinLabel15
            // 
            this.skinLabel15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel15.ForeColor = System.Drawing.Color.Gray;
            this.skinLabel15.Location = new System.Drawing.Point(451, 59);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(164, 17);
            this.skinLabel15.TabIndex = 181;
            this.skinLabel15.Text = "（此设置只针对批发流程）   ";
            // 
            // DistributorSettingCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinLabel15);
            this.Controls.Add(this.skinRadioButtonBuyout);
            this.Controls.Add(this.skinRadioButtonSale);
            this.Controls.Add(this.BaseButton3);
            this.Controls.Add(this.skinLabel9);
            this.Name = "DistributorSettingCtrl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton3;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonBuyout;
        private CCWin.SkinControl.SkinRadioButton skinRadioButtonSale;
        private CCWin.SkinControl.SkinLabel skinLabel15;
    }
}
