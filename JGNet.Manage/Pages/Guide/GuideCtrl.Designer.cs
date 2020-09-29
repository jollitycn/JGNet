using JGNet.Common;

namespace JGNet.Manage.Retail

{
    partial class GuideCtrl
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.guideBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinComboBoxState = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.BaseButtonSearch = new JGNet.Common.Components.BaseButton();
            this.BaseButtonAdd = new JGNet.Common.Components.BaseButton();
            this.skinComboBoxShopID = new JGNet.Common.ShopComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBoxName = new JGNet.Common.TextBox();
            this.retailDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechargeMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonateMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enabled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleIDs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guideBindingSource)).BeginInit();
            this.skinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RuleName,
            this.RechargeMoney,
            this.DonateMoney,
            this.Enabled,
            this.birthdayDataGridViewTextBoxColumn,
            this.Column8,
            this.Column7,
            this.MobilePhone,
            this.BankCard,
            this.homeAddressDataGridViewTextBoxColumn,
            this.RoleIDs,
            this.Column2,
            this.Column12,
            this.Column5});
            this.dataGridView.DataSource = this.guideBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 35);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1160, 615);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // guideBindingSource
            // 
            this.guideBindingSource.DataSource = typeof(JGNet.Guide);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinComboBoxState);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.BaseButtonSearch);
            this.skinPanel1.Controls.Add(this.BaseButtonAdd);
            this.skinPanel1.Controls.Add(this.skinComboBoxShopID);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.skinTextBoxName);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 35);
            this.skinPanel1.TabIndex = 2;
            // 
            // skinComboBoxState
            // 
            this.skinComboBoxState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxState.FormattingEnabled = true;
            this.skinComboBoxState.Location = new System.Drawing.Point(504, 6);
            this.skinComboBoxState.Name = "skinComboBoxState";
            this.skinComboBoxState.Size = new System.Drawing.Size(164, 22);
            this.skinComboBoxState.TabIndex = 98;
            this.skinComboBoxState.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(466, 9);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 99;
            this.skinLabel2.Text = "状态";
            // 
            // BaseButtonSearch
            // 
            this.BaseButtonSearch.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonSearch.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonSearch.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonSearch.Location = new System.Drawing.Point(674, 3);
            this.BaseButtonSearch.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonSearch.Name = "BaseButtonSearch";
            this.BaseButtonSearch.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonSearch.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonSearch.TabIndex = 2;
            this.BaseButtonSearch.Text = "查询";
            this.BaseButtonSearch.UseVisualStyleBackColor = false;
            this.BaseButtonSearch.Click += new System.EventHandler(this.BaseButtonQuery_Click);
            // 
            // BaseButtonAdd
            // 
            this.BaseButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.BaseButtonAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButtonAdd.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButtonAdd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButtonAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButtonAdd.Location = new System.Drawing.Point(755, 3);
            this.BaseButtonAdd.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButtonAdd.Name = "BaseButtonAdd";
            this.BaseButtonAdd.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButtonAdd.Size = new System.Drawing.Size(75, 32);
            this.BaseButtonAdd.TabIndex = 3;
            this.BaseButtonAdd.Text = "添加";
            this.BaseButtonAdd.UseVisualStyleBackColor = false;
            this.BaseButtonAdd.Click += new System.EventHandler(this.BaseButtonAdd_Click);
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(296, 6);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(164, 22);
            this.skinComboBoxShopID.TabIndex = 1;
            this.skinComboBoxShopID.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 9);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(85, 17);
            this.skinLabel1.TabIndex = 97;
            this.skinLabel1.Text = "导购编号/姓名";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(258, 9);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 97;
            this.skinLabel6.Text = "店铺";
            // 
            // skinTextBoxName
            // 
            this.skinTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxName.DownBack = null;
            this.skinTextBoxName.Icon = null;
            this.skinTextBoxName.IconIsButton = false;
            this.skinTextBoxName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.IsPasswordChat = '\0';
            this.skinTextBoxName.IsSystemPasswordChar = false;
            this.skinTextBoxName.Lines = new string[0];
            this.skinTextBoxName.Location = new System.Drawing.Point(91, 3);
            this.skinTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxName.MaxLength = 32767;
            this.skinTextBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxName.MouseBack = null;
            this.skinTextBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.Multiline = false;
            this.skinTextBoxName.Name = "skinTextBoxName";
            this.skinTextBoxName.NormlBack = null;
            this.skinTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxName.ReadOnly = false;
            this.skinTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxName.Size = new System.Drawing.Size(164, 28);
            // 
            // 
            // 
            this.skinTextBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxName.SkinTxt.Name = "BaseText";
            this.skinTextBoxName.SkinTxt.Size = new System.Drawing.Size(154, 18);
            this.skinTextBoxName.SkinTxt.TabIndex = 0;
            this.skinTextBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.SkinTxt.WaterText = "导购编号/姓名";
            this.skinTextBoxName.TabIndex = 0;
            this.skinTextBoxName.TabStop = true;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "导购编号/姓名";
            this.skinTextBoxName.WordWrap = true;
            // 
            // retailDetailBindingSource
            // 
            this.retailDetailBindingSource.DataSource = typeof(JGNet.RetailDetail);
            // 
            // RuleName
            // 
            this.RuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RuleName.DataPropertyName = "ShopName";
            this.RuleName.HeaderText = "所属店铺";
            this.RuleName.Name = "RuleName";
            this.RuleName.ReadOnly = true;
            this.RuleName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RuleName.Width = 123;
            // 
            // RechargeMoney
            // 
            this.RechargeMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RechargeMoney.DataPropertyName = "ID";
            this.RechargeMoney.HeaderText = "导购编号";
            this.RechargeMoney.Name = "RechargeMoney";
            this.RechargeMoney.ReadOnly = true;
            this.RechargeMoney.Width = 103;
            // 
            // DonateMoney
            // 
            this.DonateMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DonateMoney.DataPropertyName = "Name";
            this.DonateMoney.HeaderText = "导购姓名";
            this.DonateMoney.Name = "DonateMoney";
            this.DonateMoney.ReadOnly = true;
            this.DonateMoney.Width = 102;
            // 
            // Enabled
            // 
            this.Enabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Enabled.DataPropertyName = "SexSign";
            this.Enabled.HeaderText = "性别";
            this.Enabled.Name = "Enabled";
            this.Enabled.ReadOnly = true;
            this.Enabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enabled.Width = 103;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "出生日期";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Width = 103;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column8.DataPropertyName = "IdentityNo";
            this.Column8.HeaderText = "身份证号码";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 103;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.DataPropertyName = "MarriagedSign";
            this.Column7.HeaderText = "婚姻状态";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.Visible = false;
            // 
            // MobilePhone
            // 
            this.MobilePhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MobilePhone.DataPropertyName = "MobilePhone";
            this.MobilePhone.HeaderText = "手机号码";
            this.MobilePhone.Name = "MobilePhone";
            this.MobilePhone.ReadOnly = true;
            this.MobilePhone.Width = 103;
            // 
            // BankCard
            // 
            this.BankCard.DataPropertyName = "BankCard";
            this.BankCard.HeaderText = "银行卡号";
            this.BankCard.Name = "BankCard";
            this.BankCard.ReadOnly = true;
            // 
            // homeAddressDataGridViewTextBoxColumn
            // 
            this.homeAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.homeAddressDataGridViewTextBoxColumn.DataPropertyName = "HomeAddress";
            this.homeAddressDataGridViewTextBoxColumn.HeaderText = "家庭地址";
            this.homeAddressDataGridViewTextBoxColumn.Name = "homeAddressDataGridViewTextBoxColumn";
            this.homeAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.homeAddressDataGridViewTextBoxColumn.Width = 102;
            // 
            // RoleIDs
            // 
            this.RoleIDs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RoleIDs.DataPropertyName = "RoleNames";
            this.RoleIDs.HeaderText = "角色";
            this.RoleIDs.Name = "RoleIDs";
            this.RoleIDs.ReadOnly = true;
            this.RoleIDs.Width = 103;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "StateSign";
            this.Column2.HeaderText = "状态";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 54;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column12.HeaderText = "修改";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column12.Text = "修改";
            this.Column12.UseColumnTextForLinkValue = true;
            this.Column12.Width = 40;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "修改密码";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Text = "修改密码";
            this.Column5.UseColumnTextForLinkValue = true;
            this.Column5.Width = 70;
            // 
            // GuideCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.skinPanel1);
            this.Name = "GuideCtrl";
            this.Load += new System.EventHandler(this.Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guideBindingSource)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retailDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource retailDetailBindingSource;
        private  JGNet.Common.TextBox skinTextBoxName;
        private System.Windows.Forms.Panel skinPanel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource guideBindingSource;
        private ShopComboBox skinComboBoxShopID;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private Common.Components.BaseButton BaseButtonSearch;
        private Common.Components.BaseButton BaseButtonAdd;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsEnabled;
        private CCWin.SkinControl.SkinComboBox skinComboBoxState;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnabledColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RechargeMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonateMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleIDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column12;
        private System.Windows.Forms.DataGridViewLinkColumn Column5;
    }
}
