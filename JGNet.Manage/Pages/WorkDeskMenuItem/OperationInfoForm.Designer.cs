namespace JGNet.Manage.Components
{
    partial class OperationInfoForm
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
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinLabelSummaryCount = new CCWin.SkinControl.SkinLabel();
            this.skinLabelTotalMemberBalance = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelTotalCostInStore = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelTotalPriceInStore = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelPaymentBalanceSum = new CCWin.SkinControl.SkinLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(208, 190);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 2;
            this.BaseButton1.Text = "确定";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // skinLabelSummaryCount
            // 
            this.skinLabelSummaryCount.AutoSize = true;
            this.skinLabelSummaryCount.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelSummaryCount.BorderColor = System.Drawing.Color.White;
            this.skinLabelSummaryCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelSummaryCount.Location = new System.Drawing.Point(143, 55);
            this.skinLabelSummaryCount.Name = "skinLabelSummaryCount";
            this.skinLabelSummaryCount.Size = new System.Drawing.Size(15, 17);
            this.skinLabelSummaryCount.TabIndex = 22;
            this.skinLabelSummaryCount.Text = "0";
            // 
            // skinLabelTotalMemberBalance
            // 
            this.skinLabelTotalMemberBalance.AutoSize = true;
            this.skinLabelTotalMemberBalance.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelTotalMemberBalance.BorderColor = System.Drawing.Color.White;
            this.skinLabelTotalMemberBalance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelTotalMemberBalance.Location = new System.Drawing.Point(143, 133);
            this.skinLabelTotalMemberBalance.Name = "skinLabelTotalMemberBalance";
            this.skinLabelTotalMemberBalance.Size = new System.Drawing.Size(15, 17);
            this.skinLabelTotalMemberBalance.TabIndex = 23;
            this.skinLabelTotalMemberBalance.Text = "0";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(69, 55);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 24;
            this.skinLabel2.Text = "库存总量：";
            // 
            // skinLabelTotalCostInStore
            // 
            this.skinLabelTotalCostInStore.AutoSize = true;
            this.skinLabelTotalCostInStore.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelTotalCostInStore.BorderColor = System.Drawing.Color.White;
            this.skinLabelTotalCostInStore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelTotalCostInStore.Location = new System.Drawing.Point(143, 107);
            this.skinLabelTotalCostInStore.Name = "skinLabelTotalCostInStore";
            this.skinLabelTotalCostInStore.Size = new System.Drawing.Size(15, 17);
            this.skinLabelTotalCostInStore.TabIndex = 25;
            this.skinLabelTotalCostInStore.Text = "0";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(57, 133);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(80, 17);
            this.skinLabel4.TabIndex = 26;
            this.skinLabel4.Text = "会员总余额：";
            // 
            // skinLabelTotalPriceInStore
            // 
            this.skinLabelTotalPriceInStore.AutoSize = true;
            this.skinLabelTotalPriceInStore.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelTotalPriceInStore.BorderColor = System.Drawing.Color.White;
            this.skinLabelTotalPriceInStore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelTotalPriceInStore.Location = new System.Drawing.Point(143, 81);
            this.skinLabelTotalPriceInStore.Name = "skinLabelTotalPriceInStore";
            this.skinLabelTotalPriceInStore.Size = new System.Drawing.Size(15, 17);
            this.skinLabelTotalPriceInStore.TabIndex = 27;
            this.skinLabelTotalPriceInStore.Text = "0";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(57, 107);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(80, 17);
            this.skinLabel3.TabIndex = 28;
            this.skinLabel3.Text = "库存总成本：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(57, 81);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(80, 17);
            this.skinLabel1.TabIndex = 29;
            this.skinLabel1.Text = "库存总价值：";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(33, 159);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(104, 17);
            this.skinLabel5.TabIndex = 26;
            this.skinLabel5.Text = "欠供应商的货款：";
            // 
            // skinLabelPaymentBalanceSum
            // 
            this.skinLabelPaymentBalanceSum.AutoSize = true;
            this.skinLabelPaymentBalanceSum.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelPaymentBalanceSum.BorderColor = System.Drawing.Color.White;
            this.skinLabelPaymentBalanceSum.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelPaymentBalanceSum.Location = new System.Drawing.Point(143, 159);
            this.skinLabelPaymentBalanceSum.Name = "skinLabelPaymentBalanceSum";
            this.skinLabelPaymentBalanceSum.Size = new System.Drawing.Size(15, 17);
            this.skinLabelPaymentBalanceSum.TabIndex = 23;
            this.skinLabelPaymentBalanceSum.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OperationInfoForm
            // 
            this.AcceptButton = this.BaseButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 229);
            this.ControlBox = false;
            this.Controls.Add(this.skinLabelSummaryCount);
            this.Controls.Add(this.skinLabelPaymentBalanceSum);
            this.Controls.Add(this.skinLabelTotalMemberBalance);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabelTotalCostInStore);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabelTotalPriceInStore);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.BaseButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationInfoForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "实时运营信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Components.BaseButton BaseButton1;
        private CCWin.SkinControl.SkinLabel skinLabelSummaryCount;
        private CCWin.SkinControl.SkinLabel skinLabelTotalMemberBalance;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabelTotalCostInStore;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabelTotalPriceInStore;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabelPaymentBalanceSum;
        private System.Windows.Forms.Timer timer1;
    }
}