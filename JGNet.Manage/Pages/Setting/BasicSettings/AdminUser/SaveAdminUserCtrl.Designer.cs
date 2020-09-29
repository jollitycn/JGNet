namespace JGNet.Manage.Pages
{
    partial class SaveAdminUserCtrl
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
            this.btn_Save = new JGNet.Common.Components.BaseButton();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_Remarks = new JGNet.Common.TextBox();
            this.skinTextBox_Name = new JGNet.Common.TextBox();
            this.skinCheckBox_State = new CCWin.SkinControl.SkinCheckBox();
            this.skinTextBox_ID = new JGNet.Common.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel_Remarks = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.dataGridViewRole = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).BeginInit();
            this.SuspendLayout();
            // 
            // skinLabel3
            // 
            this.skinLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.DarkRed;
            this.skinLabel3.Location = new System.Drawing.Point(396, 296);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(206, 17);
            this.skinLabel3.TabIndex = 89;
            this.skinLabel3.Text = "新增管理员账号初始密码为：888888";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Save.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.btn_Save.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btn_Save.Location = new System.Drawing.Point(452, 339);
            this.btn_Save.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.btn_Save.Size = new System.Drawing.Size(75, 32);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // skinLabel8
            // 
            this.skinLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(296, 152);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(32, 17);
            this.skinLabel8.TabIndex = 88;
            this.skinLabel8.Text = "状态";
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
            this.skinTextBox_Remarks.Location = new System.Drawing.Point(331, 119);
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
            this.skinTextBox_Remarks.Size = new System.Drawing.Size(346, 28);
            // 
            // 
            // 
            this.skinTextBox_Remarks.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Remarks.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Remarks.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Remarks.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Remarks.SkinTxt.Name = "BaseText";
            this.skinTextBox_Remarks.SkinTxt.Size = new System.Drawing.Size(336, 18);
            this.skinTextBox_Remarks.SkinTxt.TabIndex = 0;
            this.skinTextBox_Remarks.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.SkinTxt.WaterText = "";
            this.skinTextBox_Remarks.TabIndex = 2;
            this.skinTextBox_Remarks.TabStop = true;
            this.skinTextBox_Remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Remarks.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Remarks.WaterText = "";
            this.skinTextBox_Remarks.WordWrap = true;
            // 
            // skinTextBox_Name
            // 
            this.skinTextBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_Name.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_Name.DownBack = null;
            this.skinTextBox_Name.Icon = null;
            this.skinTextBox_Name.IconIsButton = false;
            this.skinTextBox_Name.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Name.IsPasswordChat = '\0';
            this.skinTextBox_Name.IsSystemPasswordChar = false;
            this.skinTextBox_Name.Lines = new string[0];
            this.skinTextBox_Name.Location = new System.Drawing.Point(331, 83);
            this.skinTextBox_Name.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_Name.MaxLength = 32767;
            this.skinTextBox_Name.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_Name.MouseBack = null;
            this.skinTextBox_Name.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_Name.Multiline = false;
            this.skinTextBox_Name.Name = "skinTextBox_Name";
            this.skinTextBox_Name.NormlBack = null;
            this.skinTextBox_Name.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_Name.ReadOnly = false;
            this.skinTextBox_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_Name.Size = new System.Drawing.Size(346, 28);
            // 
            // 
            // 
            this.skinTextBox_Name.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_Name.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_Name.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_Name.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_Name.SkinTxt.Name = "BaseText";
            this.skinTextBox_Name.SkinTxt.Size = new System.Drawing.Size(336, 18);
            this.skinTextBox_Name.SkinTxt.TabIndex = 0;
            this.skinTextBox_Name.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Name.SkinTxt.WaterText = "";
            this.skinTextBox_Name.TabIndex = 1;
            this.skinTextBox_Name.TabStop = true;
            this.skinTextBox_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_Name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_Name.WaterText = "";
            this.skinTextBox_Name.WordWrap = true;
            // 
            // skinCheckBox_State
            // 
            this.skinCheckBox_State.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBox_State.AutoSize = true;
            this.skinCheckBox_State.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox_State.Checked = true;
            this.skinCheckBox_State.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox_State.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox_State.DownBack = null;
            this.skinCheckBox_State.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox_State.Location = new System.Drawing.Point(331, 150);
            this.skinCheckBox_State.MouseBack = null;
            this.skinCheckBox_State.Name = "skinCheckBox_State";
            this.skinCheckBox_State.NormlBack = null;
            this.skinCheckBox_State.SelectedDownBack = null;
            this.skinCheckBox_State.SelectedMouseBack = null;
            this.skinCheckBox_State.SelectedNormlBack = null;
            this.skinCheckBox_State.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBox_State.TabIndex = 3;
            this.skinCheckBox_State.Text = "启用";
            this.skinCheckBox_State.UseVisualStyleBackColor = false;
            // 
            // skinTextBox_ID
            // 
            this.skinTextBox_ID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinTextBox_ID.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_ID.DownBack = null;
            this.skinTextBox_ID.Icon = null;
            this.skinTextBox_ID.IconIsButton = false;
            this.skinTextBox_ID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_ID.IsPasswordChat = '\0';
            this.skinTextBox_ID.IsSystemPasswordChar = false;
            this.skinTextBox_ID.Lines = new string[0];
            this.skinTextBox_ID.Location = new System.Drawing.Point(331, 48);
            this.skinTextBox_ID.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_ID.MaxLength = 32767;
            this.skinTextBox_ID.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox_ID.MouseBack = null;
            this.skinTextBox_ID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox_ID.Multiline = false;
            this.skinTextBox_ID.Name = "skinTextBox_ID";
            this.skinTextBox_ID.NormlBack = null;
            this.skinTextBox_ID.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_ID.ReadOnly = false;
            this.skinTextBox_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_ID.Size = new System.Drawing.Size(346, 28);
            // 
            // 
            // 
            this.skinTextBox_ID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox_ID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox_ID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox_ID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox_ID.SkinTxt.Name = "BaseText";
            this.skinTextBox_ID.SkinTxt.Size = new System.Drawing.Size(336, 18);
            this.skinTextBox_ID.SkinTxt.TabIndex = 0;
            this.skinTextBox_ID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_ID.SkinTxt.WaterText = "";
            this.skinTextBox_ID.TabIndex = 0;
            this.skinTextBox_ID.TabStop = true;
            this.skinTextBox_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_ID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox_ID.WaterText = "";
            this.skinTextBox_ID.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(296, 54);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 85;
            this.skinLabel1.Text = "账号";
            // 
            // skinLabel_Remarks
            // 
            this.skinLabel_Remarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel_Remarks.AutoSize = true;
            this.skinLabel_Remarks.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_Remarks.BorderColor = System.Drawing.Color.White;
            this.skinLabel_Remarks.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_Remarks.Location = new System.Drawing.Point(296, 125);
            this.skinLabel_Remarks.Name = "skinLabel_Remarks";
            this.skinLabel_Remarks.Size = new System.Drawing.Size(32, 17);
            this.skinLabel_Remarks.TabIndex = 86;
            this.skinLabel_Remarks.Text = "备注";
            // 
            // skinLabel2
            // 
            this.skinLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(296, 89);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 87;
            this.skinLabel2.Text = "名称";
            // 
            // skinLabel4
            // 
            this.skinLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(296, 184);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(32, 17);
            this.skinLabel4.TabIndex = 91;
            this.skinLabel4.Text = "角色";
            // 
            // dataGridViewRole
            // 
            this.dataGridViewRole.AllowUserToAddRows = false;
            this.dataGridViewRole.AllowUserToDeleteRows = false;
            this.dataGridViewRole.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewRole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRole.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5});
            this.dataGridViewRole.Location = new System.Drawing.Point(331, 184);
            this.dataGridViewRole.Name = "dataGridViewRole";
            this.dataGridViewRole.RowTemplate.Height = 23;
            this.dataGridViewRole.Size = new System.Drawing.Size(346, 109);
            this.dataGridViewRole.TabIndex = 92;
            this.dataGridViewRole.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewRole_CellBeginEdit);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "角色";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Selected";
            this.Column5.FalseValue = "false";
            this.Column5.HeaderText = "选择";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.TrueValue = "true";
            this.Column5.Width = 54;
            // 
            // SaveAdminUserCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewRole);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinTextBox_Remarks);
            this.Controls.Add(this.skinTextBox_Name);
            this.Controls.Add(this.skinCheckBox_State);
            this.Controls.Add(this.skinTextBox_ID);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinLabel_Remarks);
            this.Controls.Add(this.skinLabel2);
            this.Name = "SaveAdminUserCtrl";
            this.Load += new System.EventHandler(this.SaveAdminUserCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel3;
        private Common.Components.BaseButton btn_Save;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private  JGNet.Common.TextBox skinTextBox_Remarks;
        private  JGNet.Common.TextBox skinTextBox_Name;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox_State;
        private  JGNet.Common.TextBox skinTextBox_ID;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel_Remarks;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.DataGridView dataGridViewRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
    }
}
