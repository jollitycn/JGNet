using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    partial class PermissonCtrl
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
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.baseButtonNew = new JGNet.Common.Components.BaseButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTreeViewPermisson = new CCWin.SkinControl.SkinTreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.baseButtonSave = new JGNet.Common.Components.BaseButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxRemark = new JGNet.Common.TextBox();
            this.skinTextBoxRoleName = new JGNet.Common.TextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinTreeViewPermisson);
            this.skinSplitContainer1.Panel2.Controls.Add(this.panel2);
            this.skinSplitContainer1.Panel2.Controls.Add(this.panel1);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 650);
            this.skinSplitContainer1.SplitterDistance = 340;
            this.skinSplitContainer1.SplitterWidth = 8;
            this.skinSplitContainer1.TabIndex = 72;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.ColumnDelete});
            this.dataGridView1.DataSource = this.roleBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(340, 608);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(JGNet.Role);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.baseButtonNew);
            this.panel3.Controls.Add(this.skinLabel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 42);
            this.panel3.TabIndex = 73;
            // 
            // baseButtonNew
            // 
            this.baseButtonNew.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonNew.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonNew.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonNew.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonNew.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonNew.Location = new System.Drawing.Point(3, 7);
            this.baseButtonNew.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonNew.Name = "baseButtonNew";
            this.baseButtonNew.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonNew.Size = new System.Drawing.Size(75, 32);
            this.baseButtonNew.TabIndex = 9;
            this.baseButtonNew.Text = "添加";
            this.baseButtonNew.UseVisualStyleBackColor = false;
            this.baseButtonNew.Click += new System.EventHandler(this.baseButtonNew_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(84, 15);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(200, 17);
            this.skinLabel2.TabIndex = 8;
            this.skinLabel2.Text = "提示：系统默认角色不能修改权限。";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinTreeViewPermisson
            // 
            this.skinTreeViewPermisson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skinTreeViewPermisson.CheckBoxes = true;
            this.skinTreeViewPermisson.Indent = 25;
            this.skinTreeViewPermisson.ItemHeight = 15;
            this.skinTreeViewPermisson.Location = new System.Drawing.Point(0, 42);
            this.skinTreeViewPermisson.Name = "skinTreeViewPermisson";
            this.skinTreeViewPermisson.PathSeparator = ".";
            this.skinTreeViewPermisson.Size = new System.Drawing.Size(812, 568);
            this.skinTreeViewPermisson.TabIndex = 75;
            this.skinTreeViewPermisson.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.skinTreeViewPermisson_AfterCheck);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.baseButtonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(812, 40);
            this.panel2.TabIndex = 74;
            // 
            // baseButtonSave
            // 
            this.baseButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonSave.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonSave.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonSave.Location = new System.Drawing.Point(381, 4);
            this.baseButtonSave.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonSave.Name = "baseButtonSave";
            this.baseButtonSave.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonSave.Size = new System.Drawing.Size(75, 32);
            this.baseButtonSave.TabIndex = 2;
            this.baseButtonSave.Text = "保存";
            this.baseButtonSave.UseVisualStyleBackColor = false;
            this.baseButtonSave.Click += new System.EventHandler(this.baseButtonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxRemark);
            this.panel1.Controls.Add(this.skinTextBoxRoleName);
            this.panel1.Controls.Add(this.skinLabel3);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 42);
            this.panel1.TabIndex = 72;
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.BackColor = System.Drawing.Color.Transparent;
            this.textBoxRemark.DownBack = null;
            this.textBoxRemark.Icon = null;
            this.textBoxRemark.IconIsButton = false;
            this.textBoxRemark.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxRemark.IsPasswordChat = '\0';
            this.textBoxRemark.IsSystemPasswordChar = false;
            this.textBoxRemark.Lines = new string[0];
            this.textBoxRemark.Location = new System.Drawing.Point(324, 7);
            this.textBoxRemark.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxRemark.MaxLength = 32767;
            this.textBoxRemark.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBoxRemark.MouseBack = null;
            this.textBoxRemark.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBoxRemark.Multiline = false;
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.NormlBack = null;
            this.textBoxRemark.Padding = new System.Windows.Forms.Padding(5);
            this.textBoxRemark.ReadOnly = false;
            this.textBoxRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxRemark.Size = new System.Drawing.Size(165, 28);
            // 
            // 
            // 
            this.textBoxRemark.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRemark.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRemark.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBoxRemark.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBoxRemark.SkinTxt.Name = "BaseText";
            this.textBoxRemark.SkinTxt.Size = new System.Drawing.Size(155, 18);
            this.textBoxRemark.SkinTxt.TabIndex = 0;
            this.textBoxRemark.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxRemark.SkinTxt.WaterText = "";
            this.textBoxRemark.TabIndex = 12;
            this.textBoxRemark.TabStop = true;
            this.textBoxRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxRemark.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBoxRemark.WaterText = "";
            this.textBoxRemark.WordWrap = true;
            // 
            // skinTextBoxRoleName
            // 
            this.skinTextBoxRoleName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxRoleName.DownBack = null;
            this.skinTextBoxRoleName.Icon = null;
            this.skinTextBoxRoleName.IconIsButton = false;
            this.skinTextBoxRoleName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxRoleName.IsPasswordChat = '\0';
            this.skinTextBoxRoleName.IsSystemPasswordChar = false;
            this.skinTextBoxRoleName.Lines = new string[0];
            this.skinTextBoxRoleName.Location = new System.Drawing.Point(74, 7);
            this.skinTextBoxRoleName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxRoleName.MaxLength = 32767;
            this.skinTextBoxRoleName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxRoleName.MouseBack = null;
            this.skinTextBoxRoleName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxRoleName.Multiline = false;
            this.skinTextBoxRoleName.Name = "skinTextBoxRoleName";
            this.skinTextBoxRoleName.NormlBack = null;
            this.skinTextBoxRoleName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxRoleName.ReadOnly = false;
            this.skinTextBoxRoleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxRoleName.Size = new System.Drawing.Size(165, 28);
            // 
            // 
            // 
            this.skinTextBoxRoleName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxRoleName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxRoleName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxRoleName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxRoleName.SkinTxt.Name = "BaseText";
            this.skinTextBoxRoleName.SkinTxt.Size = new System.Drawing.Size(155, 18);
            this.skinTextBoxRoleName.SkinTxt.TabIndex = 0;
            this.skinTextBoxRoleName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxRoleName.SkinTxt.WaterText = "";
            this.skinTextBoxRoleName.TabIndex = 11;
            this.skinTextBoxRoleName.TabStop = true;
            this.skinTextBoxRoleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxRoleName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxRoleName.WaterText = "";
            this.skinTextBoxRoleName.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(277, 15);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(44, 17);
            this.skinLabel3.TabIndex = 10;
            this.skinLabel3.Text = "备注：";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(3, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 8;
            this.skinLabel1.Text = "角色名称：";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarksDataGridViewTextBoxColumn.Width = 135;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDelete.DataPropertyName = "AutoID";
            this.ColumnDelete.HeaderText = "删除";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDelete.Text = "删除";
            this.ColumnDelete.UseColumnTextForLinkValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // PermissonCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Name = "PermissonCtrl";
            this.Load += new System.EventHandler(this.PermissonCtrl_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            }


        #endregion
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private Panel panel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private BindingSource roleBindingSource;
        private DataGridView dataGridView1;
        private Panel panel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private Common.Components.BaseButton baseButtonNew;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private Common.TextBox textBoxRemark;
        private Common.TextBox skinTextBoxRoleName;
        private CCWin.SkinControl.SkinTreeView skinTreeViewPermisson;
        private Panel panel2;
        private Common.Components.BaseButton baseButtonSave;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn ColumnDelete;
    }
}
