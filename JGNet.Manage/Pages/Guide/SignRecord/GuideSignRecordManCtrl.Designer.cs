using JGNet.Common.Components;
using System.Windows.Forms;

namespace JGNet.Common.Pages.Guide.SignRecord
{
    partial class GuideSignRecordManCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuideSignRecordManCtrl));
            this.skinPanelQuery = new System.Windows.Forms.Panel();
            this.quickDateSelector1 = new JGNet.Common.Components.QuickDateSelector(this.components);
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.BaseButton1 = new JGNet.Common.Components.BaseButton();
            this.guideComboBox1 = new JGNet.Common.GuideComboBox();
            this.skinLabel_operator = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_signType = new CCWin.SkinControl.SkinComboBox();
            this.skinComboBoxShopID = new JGNet.Common.ShopComboBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.signRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skinSplitContainer2 = new CCWin.SkinControl.SkinSplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.ShopNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuideName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAbsentMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinPanelQuery.SuspendLayout();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signRecordBindingSource)).BeginInit();
            this.skinSplitContainer2.Panel1.SuspendLayout();
            this.skinSplitContainer2.Panel2.SuspendLayout();
            this.skinSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanelQuery
            // 
            this.skinPanelQuery.AutoSize = true;
            this.skinPanelQuery.BackColor = System.Drawing.Color.Transparent;
            this.skinPanelQuery.Controls.Add(this.quickDateSelector1);
            this.skinPanelQuery.Controls.Add(this.BaseButton1);
            this.skinPanelQuery.Controls.Add(this.guideComboBox1);
            this.skinPanelQuery.Controls.Add(this.skinLabel_operator);
            this.skinPanelQuery.Controls.Add(this.skinComboBox_signType);
            this.skinPanelQuery.Controls.Add(this.skinComboBoxShopID);
            this.skinPanelQuery.Controls.Add(this.dateTimePicker_End);
            this.skinPanelQuery.Controls.Add(this.dateTimePicker_Start);
            this.skinPanelQuery.Controls.Add(this.skinLabel3);
            this.skinPanelQuery.Controls.Add(this.skinLabel5);
            this.skinPanelQuery.Controls.Add(this.skinLabel6);
            this.skinPanelQuery.Controls.Add(this.skinLabel7);
            this.skinPanelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanelQuery.Location = new System.Drawing.Point(0, 0);
            this.skinPanelQuery.Name = "skinPanelQuery";
            this.skinPanelQuery.Size = new System.Drawing.Size(1160, 39);
            this.skinPanelQuery.TabIndex = 0;
            // 
            // quickDateSelector1
            // 
            this.quickDateSelector1.Arrow = System.Drawing.Color.Black;
            this.quickDateSelector1.Back = System.Drawing.Color.White;
            this.quickDateSelector1.BackRadius = 4;
            this.quickDateSelector1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.quickDateSelector1.Base = System.Drawing.Color.Transparent;
            this.quickDateSelector1.BaseFore = System.Drawing.Color.Black;
            this.quickDateSelector1.BaseForeAnamorphosis = false;
            this.quickDateSelector1.BaseForeAnamorphosisBorder = 4;
            this.quickDateSelector1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.quickDateSelector1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.quickDateSelector1.BaseHoverFore = System.Drawing.Color.White;
            this.quickDateSelector1.BaseItemAnamorphosis = true;
            this.quickDateSelector1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemBorderShow = true;
            this.quickDateSelector1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("quickDateSelector1.BaseItemDown")));
            this.quickDateSelector1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("quickDateSelector1.BaseItemMouse")));
            this.quickDateSelector1.BaseItemNorml = null;
            this.quickDateSelector1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BaseItemRadius = 4;
            this.quickDateSelector1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.BindTabControl = null;
            this.quickDateSelector1.Dock = System.Windows.Forms.DockStyle.None;
            this.quickDateSelector1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.quickDateSelector1.EndDateTimePicker = this.dateTimePicker_End;
            this.quickDateSelector1.Fore = System.Drawing.Color.Black;
            this.quickDateSelector1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.quickDateSelector1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.quickDateSelector1.HoverFore = System.Drawing.Color.White;
            this.quickDateSelector1.ItemAnamorphosis = true;
            this.quickDateSelector1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemBorderShow = true;
            this.quickDateSelector1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.quickDateSelector1.ItemRadius = 4;
            this.quickDateSelector1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Location = new System.Drawing.Point(830, 5);
            this.quickDateSelector1.Name = "quickDateSelector1";
            this.quickDateSelector1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.Size = new System.Drawing.Size(32, 25);
            this.quickDateSelector1.SkinAllColor = true;
            this.quickDateSelector1.StartDateTimePicker = this.dateTimePicker_Start;
            this.quickDateSelector1.TabIndex = 122;
            this.quickDateSelector1.Text = "quickDateSelector1";
            this.quickDateSelector1.TitleAnamorphosis = true;
            this.quickDateSelector1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.quickDateSelector1.TitleRadius = 4;
            this.quickDateSelector1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.quickDateSelector1.PickerValueChanged += new CJBasic.Action<object, System.EventArgs>(this.BaseButton_search_Click);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.CustomFormat = "";
            this.dateTimePicker_End.Location = new System.Drawing.Point(694, 7);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker_End.TabIndex = 4;
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(525, 7);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(130, 21);
            this.dateTimePicker_Start.TabIndex = 3;
            // 
            // BaseButton1
            // 
            this.BaseButton1.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton1.Location = new System.Drawing.Point(882, 4);
            this.BaseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton1.Name = "BaseButton1";
            this.BaseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton1.Size = new System.Drawing.Size(75, 32);
            this.BaseButton1.TabIndex = 5;
            this.BaseButton1.Text = "查询";
            this.BaseButton1.UseVisualStyleBackColor = false;
            this.BaseButton1.Click += new System.EventHandler(this.BaseButton_search_Click);
            // 
            // guideComboBox1
            // 
            this.guideComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guideComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guideComboBox1.FormattingEnabled = true;
            this.guideComboBox1.Location = new System.Drawing.Point(218, 6);
            this.guideComboBox1.Name = "guideComboBox1";
            this.guideComboBox1.ShopID = null;
            this.guideComboBox1.Size = new System.Drawing.Size(142, 22);
            this.guideComboBox1.TabIndex = 1;
            this.guideComboBox1.WaterText = "";
            // 
            // skinLabel_operator
            // 
            this.skinLabel_operator.AutoSize = true;
            this.skinLabel_operator.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_operator.BorderColor = System.Drawing.Color.White;
            this.skinLabel_operator.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_operator.Location = new System.Drawing.Point(184, 9);
            this.skinLabel_operator.Name = "skinLabel_operator";
            this.skinLabel_operator.Size = new System.Drawing.Size(32, 17);
            this.skinLabel_operator.TabIndex = 24;
            this.skinLabel_operator.Text = "导购";
            // 
            // skinComboBox_signType
            // 
            this.skinComboBox_signType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_signType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_signType.FormattingEnabled = true;
            this.skinComboBox_signType.Location = new System.Drawing.Point(404, 6);
            this.skinComboBox_signType.Name = "skinComboBox_signType";
            this.skinComboBox_signType.Size = new System.Drawing.Size(80, 22);
            this.skinComboBox_signType.TabIndex = 2;
            this.skinComboBox_signType.WaterText = "";
            // 
            // skinComboBoxShopID
            // 
            this.skinComboBoxShopID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxShopID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxShopID.FormattingEnabled = true;
            this.skinComboBoxShopID.Location = new System.Drawing.Point(38, 6);
            this.skinComboBoxShopID.Name = "skinComboBoxShopID";
            this.skinComboBoxShopID.Size = new System.Drawing.Size(142, 22);
            this.skinComboBoxShopID.TabIndex = 0;
            this.skinComboBoxShopID.WaterText = "";
            this.skinComboBoxShopID.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxShopID_SelectedIndexChanged);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(366, 9);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(32, 17);
            this.skinLabel3.TabIndex = 16;
            this.skinLabel3.Text = "类型";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(3, 9);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(32, 17);
            this.skinLabel5.TabIndex = 16;
            this.skinLabel5.Text = "店铺";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(659, 9);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(32, 17);
            this.skinLabel6.TabIndex = 18;
            this.skinLabel6.Text = "结束";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(490, 9);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(32, 17);
            this.skinLabel7.TabIndex = 19;
            this.skinLabel7.Text = "开始";
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.CollapsePanel = CCWin.SkinControl.CollapsePanel.Panel2;
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(0, 39);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.dataGridViewMain);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinSplitContainer2);
            this.skinSplitContainer1.Panel2Collapsed = true;
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160, 611);
            this.skinSplitContainer1.SplitterDistance = 722;
            this.skinSplitContainer1.TabIndex = 1;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToOrderColumns = true;
            this.dataGridViewMain.AutoGenerateColumns = false;
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShopNameColumn,
            this.GuideName,
            this.SignTypeName,
            this.Column1,
            this.signedTimeDataGridViewTextBoxColumn,
            this.ColumnAbsentMinutes});
            this.dataGridViewMain.DataSource = this.signRecordBindingSource;
            this.dataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowTemplate.Height = 23;
            this.dataGridViewMain.Size = new System.Drawing.Size(1160, 611);
            this.dataGridViewMain.TabIndex = 6;
            // 
            // signRecordBindingSource
            // 
            this.signRecordBindingSource.DataSource = typeof(JGNet.SignRecord);
            // 
            // skinSplitContainer2
            // 
            this.skinSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer2.Name = "skinSplitContainer2";
            this.skinSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer2.Panel1
            // 
            this.skinSplitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.skinSplitContainer2.Panel1.Controls.Add(this.skinLabel1);
            // 
            // skinSplitContainer2.Panel2
            // 
            this.skinSplitContainer2.Panel2.Controls.Add(this.skinLabel2);
            this.skinSplitContainer2.Panel2Collapsed = true;
            this.skinSplitContainer2.Size = new System.Drawing.Size(96, 100);
            this.skinSplitContainer2.SplitterDistance = 75;
            this.skinSplitContainer2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.skinLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skinLabel1.Location = new System.Drawing.Point(0, 0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "考勤照片";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.skinLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skinLabel2.Location = new System.Drawing.Point(0, 0);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "考勤时间";
            // 
            // ShopNameColumn
            // 
            this.ShopNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ShopNameColumn.DataPropertyName = "ShopName";
            this.ShopNameColumn.HeaderText = "店铺";
            this.ShopNameColumn.Name = "ShopNameColumn";
            this.ShopNameColumn.ReadOnly = true;
            this.ShopNameColumn.Width = 240;
            // 
            // GuideName
            // 
            this.GuideName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GuideName.DataPropertyName = "GuideName";
            this.GuideName.HeaderText = "导购";
            this.GuideName.Name = "GuideName";
            this.GuideName.ReadOnly = true;
            this.GuideName.Width = 240;
            // 
            // SignTypeName
            // 
            this.SignTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SignTypeName.DataPropertyName = "SignTypeName";
            this.SignTypeName.HeaderText = "类型";
            this.SignTypeName.Name = "SignTypeName";
            this.SignTypeName.ReadOnly = true;
            this.SignTypeName.Width = 200;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "ReferTime";
            this.Column1.HeaderText = "参考时间";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // signedTimeDataGridViewTextBoxColumn
            // 
            this.signedTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.signedTimeDataGridViewTextBoxColumn.DataPropertyName = "SignedTime";
            this.signedTimeDataGridViewTextBoxColumn.HeaderText = "考勤时间";
            this.signedTimeDataGridViewTextBoxColumn.Name = "signedTimeDataGridViewTextBoxColumn";
            this.signedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.signedTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // ColumnAbsentMinutes
            // 
            this.ColumnAbsentMinutes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnAbsentMinutes.DataPropertyName = "AbsentMinutes";
            this.ColumnAbsentMinutes.HeaderText = "迟到早退";
            this.ColumnAbsentMinutes.Name = "ColumnAbsentMinutes";
            this.ColumnAbsentMinutes.ReadOnly = true;
            this.ColumnAbsentMinutes.Width = 78;
            // 
            // GuideSignRecordManCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Controls.Add(this.skinPanelQuery);
            this.Name = "GuideSignRecordManCtrl";
            this.Load += new System.EventHandler(this.GuideSignRecordManCtr_Load);
            this.skinPanelQuery.ResumeLayout(false);
            this.skinPanelQuery.PerformLayout();
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            this.skinSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signRecordBindingSource)).EndInit();
            this.skinSplitContainer2.Panel1.ResumeLayout(false);
            this.skinSplitContainer2.Panel1.PerformLayout();
            this.skinSplitContainer2.Panel2.ResumeLayout(false);
            this.skinSplitContainer2.Panel2.PerformLayout();
            this.skinSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel skinPanelQuery;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.BindingSource signRecordBindingSource;
        private ShopComboBox skinComboBoxShopID;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel_operator; 
        private CCWin.SkinControl.SkinComboBox skinComboBox_signType;
        private CCWin.SkinControl.SkinLabel skinLabel3; 
        private Common.GuideComboBox guideComboBox1;
        private Common.Components.BaseButton BaseButton1;
        private QuickDateSelector quickDateSelector1;
        private DataGridViewTextBoxColumn ShopNameColumn;
        private DataGridViewTextBoxColumn GuideName;
        private DataGridViewTextBoxColumn SignTypeName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn signedTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ColumnAbsentMinutes;
    }
}
