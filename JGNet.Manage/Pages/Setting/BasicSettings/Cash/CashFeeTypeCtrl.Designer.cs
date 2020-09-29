namespace JGNet.Manage.Pages.BasicSettings.Costume
{
    partial class CashFeeTypeCtrl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBoxFeeType = new CCWin.SkinControl.SkinComboBox();
            this.skinTextBoxName = new JGNet.Common.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 607);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.skinComboBoxFeeType);
            this.skinPanel1.Controls.Add(this.skinTextBoxName);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 43);
            this.skinPanel1.TabIndex = 4;
            // 
            // BaseButton3
            // 
            this.BaseButton3.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(378, 5);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 2;
            this.BaseButton3.Text = "添加";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.BaseButtonAdd_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 13);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "费用类型";
            // 
            // skinComboBoxFeeType
            // 
            this.skinComboBoxFeeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxFeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxFeeType.FormattingEnabled = true;
            this.skinComboBoxFeeType.Location = new System.Drawing.Point(65, 10);
            this.skinComboBoxFeeType.Name = "skinComboBoxFeeType";
            this.skinComboBoxFeeType.Size = new System.Drawing.Size(121, 22);
            this.skinComboBoxFeeType.TabIndex = 0;
            this.skinComboBoxFeeType.WaterText = "";
            this.skinComboBoxFeeType.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxFeeType_SelectedIndexChanged);
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
            this.skinTextBoxName.Location = new System.Drawing.Point(190, 7);
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
            this.skinTextBoxName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxName.SkinTxt.Name = "BaseText";
            this.skinTextBoxName.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBoxName.SkinTxt.TabIndex = 0;
            this.skinTextBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.SkinTxt.WaterText = "名称";
            this.skinTextBoxName.TabIndex = 1;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "名称";
            this.skinTextBoxName.WordWrap = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Key";
            this.Column1.HeaderText = "名称";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 1080;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "删除";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Text = "删除";
            this.Column2.UseColumnTextForLinkValue = true;
            this.Column2.Width = 40;
            // 
            // CashFeeTypeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "CashFeeTypeCtrl";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private  JGNet.Common.TextBox skinTextBoxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel skinPanel1;
        private CCWin.SkinControl.SkinComboBox skinComboBoxFeeType;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private Common.Components.BaseButton BaseButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}
