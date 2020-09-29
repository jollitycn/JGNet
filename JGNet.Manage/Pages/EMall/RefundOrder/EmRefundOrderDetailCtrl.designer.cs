using JGNet.Common;

namespace JGNet.Manage
{
    partial class EmRefundOrderDetailCtrl
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
            this.costumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skinLabel17 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel16 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelSalePrice = new CCWin.SkinControl.SkinLabel();
            this.skinLabelOrderTimeRefundAgree = new CCWin.SkinControl.SkinLabel();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelDiscountAmount = new CCWin.SkinControl.SkinLabel();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelOrderPayAmount = new CCWin.SkinControl.SkinLabel();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelOrderId = new CCWin.SkinControl.SkinLabel();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.skinLabelOrderPayTime = new CCWin.SkinControl.SkinLabel();
            this.baseButtonApplyRefund = new JGNet.Common.Components.BaseButton();
            this.baseButtonRefused = new JGNet.Common.Components.BaseButton();
            this.skinLabelMemberID = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinLabelRefundReason = new CCWin.SkinControl.SkinLabel();
            this.skinLabelExpressOrderIdText = new CCWin.SkinControl.SkinLabel();
            this.skinLabelExpressCompanyTxt = new CCWin.SkinControl.SkinLabel();
            this.skinLabelCancelOrRefund = new CCWin.SkinControl.SkinLabel();
            this.skinLabelExpressOrderId = new CCWin.SkinControl.SkinLabel();
            this.skinLabelExpressCompany = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.costumeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emOnlinePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // costumeBindingSource
            // 
            this.costumeBindingSource.DataSource = typeof(JGNet.EmRefundDetail);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 0);
            this.panel1.TabIndex = 111;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costumeIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.sizeNameDataGridViewTextBoxColumn,
            this.emOnlinePriceDataGridViewTextBoxColumn,
            this.sumCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.costumeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 516);
            this.dataGridView1.TabIndex = 112;
            // 
            // skinLabel17
            // 
            this.skinLabel17.AutoSize = true;
            this.skinLabel17.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel17.BorderColor = System.Drawing.Color.White;
            this.skinLabel17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel17.Location = new System.Drawing.Point(256, 7);
            this.skinLabel17.Name = "skinLabel17";
            this.skinLabel17.Size = new System.Drawing.Size(80, 17);
            this.skinLabel17.TabIndex = 112;
            this.skinLabel17.Text = "同意退款时间";
            // 
            // skinLabel16
            // 
            this.skinLabel16.AutoSize = true;
            this.skinLabel16.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel16.BorderColor = System.Drawing.Color.White;
            this.skinLabel16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel16.Location = new System.Drawing.Point(15, 29);
            this.skinLabel16.Name = "skinLabel16";
            this.skinLabel16.Size = new System.Drawing.Size(56, 17);
            this.skinLabel16.TabIndex = 111;
            this.skinLabel16.Text = "商品金额";
            // 
            // skinLabelSalePrice
            // 
            this.skinLabelSalePrice.AutoSize = true;
            this.skinLabelSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelSalePrice.BorderColor = System.Drawing.Color.White;
            this.skinLabelSalePrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelSalePrice.Location = new System.Drawing.Point(77, 29);
            this.skinLabelSalePrice.Name = "skinLabelSalePrice";
            this.skinLabelSalePrice.Size = new System.Drawing.Size(56, 17);
            this.skinLabelSalePrice.TabIndex = 111;
            this.skinLabelSalePrice.Text = "商品金额";
            // 
            // skinLabelOrderTimeRefundAgree
            // 
            this.skinLabelOrderTimeRefundAgree.AutoSize = true;
            this.skinLabelOrderTimeRefundAgree.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelOrderTimeRefundAgree.BorderColor = System.Drawing.Color.White;
            this.skinLabelOrderTimeRefundAgree.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelOrderTimeRefundAgree.Location = new System.Drawing.Point(342, 7);
            this.skinLabelOrderTimeRefundAgree.Name = "skinLabelOrderTimeRefundAgree";
            this.skinLabelOrderTimeRefundAgree.Size = new System.Drawing.Size(56, 17);
            this.skinLabelOrderTimeRefundAgree.TabIndex = 112;
            this.skinLabelOrderTimeRefundAgree.Text = "下单时间";
            // 
            // skinLabel18
            // 
            this.skinLabel18.AutoSize = true;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel18.Location = new System.Drawing.Point(280, 29);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(56, 17);
            this.skinLabel18.TabIndex = 111;
            this.skinLabel18.Text = "优惠金额";
            // 
            // skinLabelDiscountAmount
            // 
            this.skinLabelDiscountAmount.AutoSize = true;
            this.skinLabelDiscountAmount.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelDiscountAmount.BorderColor = System.Drawing.Color.White;
            this.skinLabelDiscountAmount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelDiscountAmount.Location = new System.Drawing.Point(342, 29);
            this.skinLabelDiscountAmount.Name = "skinLabelDiscountAmount";
            this.skinLabelDiscountAmount.Size = new System.Drawing.Size(56, 17);
            this.skinLabelDiscountAmount.TabIndex = 111;
            this.skinLabelDiscountAmount.Text = "优惠金额";
            // 
            // skinLabel19
            // 
            this.skinLabel19.AutoSize = true;
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel19.Location = new System.Drawing.Point(529, 29);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(56, 17);
            this.skinLabel19.TabIndex = 111;
            this.skinLabel19.Text = "订单总价";
            // 
            // skinLabelOrderPayAmount
            // 
            this.skinLabelOrderPayAmount.AutoSize = true;
            this.skinLabelOrderPayAmount.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelOrderPayAmount.BorderColor = System.Drawing.Color.White;
            this.skinLabelOrderPayAmount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelOrderPayAmount.Location = new System.Drawing.Point(591, 29);
            this.skinLabelOrderPayAmount.Name = "skinLabelOrderPayAmount";
            this.skinLabelOrderPayAmount.Size = new System.Drawing.Size(56, 17);
            this.skinLabelOrderPayAmount.TabIndex = 111;
            this.skinLabelOrderPayAmount.Text = "订单总价";
            // 
            // skinLabel15
            // 
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel15.Location = new System.Drawing.Point(15, 7);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(56, 17);
            this.skinLabel15.TabIndex = 114;
            this.skinLabel15.Text = "订单编号";
            // 
            // skinLabelOrderId
            // 
            this.skinLabelOrderId.AutoSize = true;
            this.skinLabelOrderId.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelOrderId.BorderColor = System.Drawing.Color.White;
            this.skinLabelOrderId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelOrderId.Location = new System.Drawing.Point(77, 7);
            this.skinLabelOrderId.Name = "skinLabelOrderId";
            this.skinLabelOrderId.Size = new System.Drawing.Size(56, 17);
            this.skinLabelOrderId.TabIndex = 114;
            this.skinLabelOrderId.Text = "订单编号";
            // 
            // skinLabel13
            // 
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel13.Location = new System.Drawing.Point(529, 7);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(56, 17);
            this.skinLabel13.TabIndex = 115;
            this.skinLabel13.Text = "付款时间";
            // 
            // skinLabelOrderPayTime
            // 
            this.skinLabelOrderPayTime.AutoSize = true;
            this.skinLabelOrderPayTime.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelOrderPayTime.BorderColor = System.Drawing.Color.White;
            this.skinLabelOrderPayTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelOrderPayTime.Location = new System.Drawing.Point(591, 7);
            this.skinLabelOrderPayTime.Name = "skinLabelOrderPayTime";
            this.skinLabelOrderPayTime.Size = new System.Drawing.Size(56, 17);
            this.skinLabelOrderPayTime.TabIndex = 115;
            this.skinLabelOrderPayTime.Text = "付款时间";
            // 
            // baseButtonApplyRefund
            // 
            this.baseButtonApplyRefund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonApplyRefund.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonApplyRefund.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonApplyRefund.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonApplyRefund.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonApplyRefund.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonApplyRefund.Location = new System.Drawing.Point(998, 99);
            this.baseButtonApplyRefund.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonApplyRefund.Name = "baseButtonApplyRefund";
            this.baseButtonApplyRefund.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonApplyRefund.Size = new System.Drawing.Size(75, 32);
            this.baseButtonApplyRefund.TabIndex = 116;
            this.baseButtonApplyRefund.Text = "同意退款";
            this.baseButtonApplyRefund.UseVisualStyleBackColor = false;
            this.baseButtonApplyRefund.Click += new System.EventHandler(this.baseButtonApplyRefund_Click);
            // 
            // baseButtonRefused
            // 
            this.baseButtonRefused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonRefused.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonRefused.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonRefused.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonRefused.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonRefused.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonRefused.Location = new System.Drawing.Point(1079, 99);
            this.baseButtonRefused.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonRefused.Name = "baseButtonRefused";
            this.baseButtonRefused.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonRefused.Size = new System.Drawing.Size(75, 32);
            this.baseButtonRefused.TabIndex = 116;
            this.baseButtonRefused.Text = "拒绝退款";
            this.baseButtonRefused.UseVisualStyleBackColor = false;
            this.baseButtonRefused.Click += new System.EventHandler(this.baseButtonRefused_Click);
            // 
            // skinLabelMemberID
            // 
            this.skinLabelMemberID.AutoSize = true;
            this.skinLabelMemberID.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelMemberID.BorderColor = System.Drawing.Color.White;
            this.skinLabelMemberID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelMemberID.Location = new System.Drawing.Point(795, 7);
            this.skinLabelMemberID.Name = "skinLabelMemberID";
            this.skinLabelMemberID.Size = new System.Drawing.Size(32, 17);
            this.skinLabelMemberID.TabIndex = 134;
            this.skinLabelMemberID.Text = "账号";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(757, 7);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 136;
            this.skinLabel8.Text = "账号";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.skinLabel8);
            this.panel2.Controls.Add(this.skinLabelMemberID);
            this.panel2.Controls.Add(this.baseButtonRefused);
            this.panel2.Controls.Add(this.baseButtonApplyRefund);
            this.panel2.Controls.Add(this.skinLabelOrderPayTime);
            this.panel2.Controls.Add(this.skinLabel13);
            this.panel2.Controls.Add(this.skinLabelOrderId);
            this.panel2.Controls.Add(this.skinLabel15);
            this.panel2.Controls.Add(this.skinLabelRefundReason);
            this.panel2.Controls.Add(this.skinLabelExpressOrderIdText);
            this.panel2.Controls.Add(this.skinLabelExpressCompanyTxt);
            this.panel2.Controls.Add(this.skinLabelCancelOrRefund);
            this.panel2.Controls.Add(this.skinLabelExpressOrderId);
            this.panel2.Controls.Add(this.skinLabelOrderPayAmount);
            this.panel2.Controls.Add(this.skinLabelExpressCompany);
            this.panel2.Controls.Add(this.skinLabel1);
            this.panel2.Controls.Add(this.skinLabel2);
            this.panel2.Controls.Add(this.skinLabel19);
            this.panel2.Controls.Add(this.skinLabelDiscountAmount);
            this.panel2.Controls.Add(this.skinLabel18);
            this.panel2.Controls.Add(this.skinLabelOrderTimeRefundAgree);
            this.panel2.Controls.Add(this.skinLabelSalePrice);
            this.panel2.Controls.Add(this.skinLabel16);
            this.panel2.Controls.Add(this.skinLabel17);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 134);
            this.panel2.TabIndex = 109;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // skinLabelRefundReason
            // 
            this.skinLabelRefundReason.AutoSize = true;
            this.skinLabelRefundReason.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelRefundReason.BorderColor = System.Drawing.Color.White;
            this.skinLabelRefundReason.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelRefundReason.Location = new System.Drawing.Point(77, 55);
            this.skinLabelRefundReason.Name = "skinLabelRefundReason";
            this.skinLabelRefundReason.Size = new System.Drawing.Size(80, 17);
            this.skinLabelRefundReason.TabIndex = 111;
            this.skinLabelRefundReason.Text = "拒绝退款原因";
            // 
            // skinLabelExpressOrderIdText
            // 
            this.skinLabelExpressOrderIdText.AutoSize = true;
            this.skinLabelExpressOrderIdText.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelExpressOrderIdText.BorderColor = System.Drawing.Color.White;
            this.skinLabelExpressOrderIdText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelExpressOrderIdText.Location = new System.Drawing.Point(591, 82);
            this.skinLabelExpressOrderIdText.Name = "skinLabelExpressOrderIdText";
            this.skinLabelExpressOrderIdText.Size = new System.Drawing.Size(56, 17);
            this.skinLabelExpressOrderIdText.TabIndex = 111;
            this.skinLabelExpressOrderIdText.Text = "订单总价";
            // 
            // skinLabelExpressCompanyTxt
            // 
            this.skinLabelExpressCompanyTxt.AutoSize = true;
            this.skinLabelExpressCompanyTxt.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelExpressCompanyTxt.BorderColor = System.Drawing.Color.White;
            this.skinLabelExpressCompanyTxt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelExpressCompanyTxt.Location = new System.Drawing.Point(342, 82);
            this.skinLabelExpressCompanyTxt.Name = "skinLabelExpressCompanyTxt";
            this.skinLabelExpressCompanyTxt.Size = new System.Drawing.Size(56, 17);
            this.skinLabelExpressCompanyTxt.TabIndex = 111;
            this.skinLabelExpressCompanyTxt.Text = "订单总价";
            // 
            // skinLabelCancelOrRefund
            // 
            this.skinLabelCancelOrRefund.AutoSize = true;
            this.skinLabelCancelOrRefund.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelCancelOrRefund.BorderColor = System.Drawing.Color.White;
            this.skinLabelCancelOrRefund.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelCancelOrRefund.Location = new System.Drawing.Point(77, 82);
            this.skinLabelCancelOrRefund.Name = "skinLabelCancelOrRefund";
            this.skinLabelCancelOrRefund.Size = new System.Drawing.Size(56, 17);
            this.skinLabelCancelOrRefund.TabIndex = 111;
            this.skinLabelCancelOrRefund.Text = "订单总价";
            // 
            // skinLabelExpressOrderId
            // 
            this.skinLabelExpressOrderId.AutoSize = true;
            this.skinLabelExpressOrderId.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelExpressOrderId.BorderColor = System.Drawing.Color.White;
            this.skinLabelExpressOrderId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelExpressOrderId.Location = new System.Drawing.Point(529, 82);
            this.skinLabelExpressOrderId.Name = "skinLabelExpressOrderId";
            this.skinLabelExpressOrderId.Size = new System.Drawing.Size(56, 17);
            this.skinLabelExpressOrderId.TabIndex = 111;
            this.skinLabelExpressOrderId.Text = "物流编号";
            // 
            // skinLabelExpressCompany
            // 
            this.skinLabelExpressCompany.AutoSize = true;
            this.skinLabelExpressCompany.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelExpressCompany.BorderColor = System.Drawing.Color.White;
            this.skinLabelExpressCompany.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelExpressCompany.Location = new System.Drawing.Point(280, 82);
            this.skinLabelExpressCompany.Name = "skinLabelExpressCompany";
            this.skinLabelExpressCompany.Size = new System.Drawing.Size(56, 17);
            this.skinLabelExpressCompany.TabIndex = 111;
            this.skinLabelExpressCompany.Text = "物流公司";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(15, 55);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 111;
            this.skinLabel1.Text = "拒绝原因";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(15, 82);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 111;
            this.skinLabel2.Text = "退款类型";
            // 
            // costumeIDDataGridViewTextBoxColumn
            // 
            this.costumeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.costumeIDDataGridViewTextBoxColumn.DataPropertyName = "CostumeID";
            this.costumeIDDataGridViewTextBoxColumn.HeaderText = "款号";
            this.costumeIDDataGridViewTextBoxColumn.Name = "costumeIDDataGridViewTextBoxColumn";
            this.costumeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.costumeIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "品牌";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.brandNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "颜色";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // sizeNameDataGridViewTextBoxColumn
            // 
            this.sizeNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sizeNameDataGridViewTextBoxColumn.DataPropertyName = "SizeDisplayName";
            this.sizeNameDataGridViewTextBoxColumn.HeaderText = "尺码";
            this.sizeNameDataGridViewTextBoxColumn.Name = "sizeNameDataGridViewTextBoxColumn";
            this.sizeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // emOnlinePriceDataGridViewTextBoxColumn
            // 
            this.emOnlinePriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.emOnlinePriceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.emOnlinePriceDataGridViewTextBoxColumn.HeaderText = "吊牌价";
            this.emOnlinePriceDataGridViewTextBoxColumn.Name = "emOnlinePriceDataGridViewTextBoxColumn";
            this.emOnlinePriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.emOnlinePriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // sumCostDataGridViewTextBoxColumn
            // 
            this.sumCostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sumCostDataGridViewTextBoxColumn.DataPropertyName = "EmOnlinePrice";
            this.sumCostDataGridViewTextBoxColumn.HeaderText = "线上价";
            this.sumCostDataGridViewTextBoxColumn.Name = "sumCostDataGridViewTextBoxColumn";
            this.sumCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.sumCostDataGridViewTextBoxColumn.Width = 66;
            // 
            // EmRefundOrderDetailCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "EmRefundOrderDetailCtrl";
            this.Load += new System.EventHandler(this.EmCostumeManageCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costumeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource costumeBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinLabel skinLabel17;
        private CCWin.SkinControl.SkinLabel skinLabel16;
        private CCWin.SkinControl.SkinLabel skinLabelSalePrice;
        private CCWin.SkinControl.SkinLabel skinLabelOrderTimeRefundAgree;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private CCWin.SkinControl.SkinLabel skinLabelDiscountAmount;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private CCWin.SkinControl.SkinLabel skinLabelOrderPayAmount;
        private CCWin.SkinControl.SkinLabel skinLabel15;
        private CCWin.SkinControl.SkinLabel skinLabelOrderId;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private CCWin.SkinControl.SkinLabel skinLabelOrderPayTime;
        private Common.Components.BaseButton baseButtonApplyRefund;
        private Common.Components.BaseButton baseButtonRefused;
        private CCWin.SkinControl.SkinLabel skinLabelMemberID;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinLabel skinLabelRefundReason;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabelCancelOrRefund;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabelExpressOrderIdText;
        private CCWin.SkinControl.SkinLabel skinLabelExpressCompanyTxt;
        private CCWin.SkinControl.SkinLabel skinLabelExpressOrderId;
        private CCWin.SkinControl.SkinLabel skinLabelExpressCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn costumeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emOnlinePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumCostDataGridViewTextBoxColumn;
    }
}
