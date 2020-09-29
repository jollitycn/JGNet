using System;

namespace JGNet.Manage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.skinToolStrip2 = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripLabelProfile = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelOperator = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_netState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.skinLabel_TaskName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelLoad = new System.Windows.Forms.ToolStripLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.切换账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.除此之外全部关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinToolStripAnounce = new CCWin.SkinControl.SkinToolStrip();
            this.toolStripLabelAnounce = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.skinToolStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.skinToolStripAnounce.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinToolStrip1
            // 
            this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip1.AutoSize = false;
            this.skinToolStrip1.Back = System.Drawing.Color.White;
            this.skinToolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.skinToolStrip1.BackRadius = 4;
            this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip1.Base = System.Drawing.Color.Transparent;
            this.skinToolStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip1.BaseForeAnamorphosis = false;
            this.skinToolStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.BaseItemAnamorphosis = true;
            this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemBorderShow = true;
            this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
            this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
            this.skinToolStrip1.BaseItemNorml = null;
            this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BaseItemRadius = 4;
            this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.BindTabControl = null;
            this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip1.Fore = System.Drawing.Color.Black;
            this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip1.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.skinToolStrip1.ItemAnamorphosis = true;
            this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemBorderShow = true;
            this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip1.ItemRadius = 4;
            this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.skinToolStrip1.Name = "skinToolStrip1";
            this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.skinToolStrip1.ShowItemToolTips = false;
            this.skinToolStrip1.Size = new System.Drawing.Size(1192, 56);
            this.skinToolStrip1.SkinAllColor = true;
            this.skinToolStrip1.TabIndex = 0;
            this.skinToolStrip1.Text = "skinToolStrip1";
            this.skinToolStrip1.TitleAnamorphosis = true;
            this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip1.TitleRadius = 4;
            this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "销售分析.png");
            // 
            // skinToolStrip2
            // 
            this.skinToolStrip2.Arrow = System.Drawing.Color.Black;
            this.skinToolStrip2.AutoSize = false;
            this.skinToolStrip2.Back = System.Drawing.Color.White;
            this.skinToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinToolStrip2.BackRadius = 4;
            this.skinToolStrip2.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStrip2.Base = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(205)))), ((int)(((byte)(234)))));
            this.skinToolStrip2.BaseFore = System.Drawing.Color.Black;
            this.skinToolStrip2.BaseForeAnamorphosis = false;
            this.skinToolStrip2.BaseForeAnamorphosisBorder = 4;
            this.skinToolStrip2.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStrip2.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStrip2.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.BaseItemAnamorphosis = true;
            this.skinToolStrip2.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemBorderShow = true;
            this.skinToolStrip2.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemDown")));
            this.skinToolStrip2.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip2.BaseItemMouse")));
            this.skinToolStrip2.BaseItemNorml = null;
            this.skinToolStrip2.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BaseItemRadius = 4;
            this.skinToolStrip2.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.BindTabControl = null;
            this.skinToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinToolStrip2.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStrip2.Fore = System.Drawing.Color.Black;
            this.skinToolStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStrip2.HoverFore = System.Drawing.Color.White;
            this.skinToolStrip2.ItemAnamorphosis = true;
            this.skinToolStrip2.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemBorderShow = true;
            this.skinToolStrip2.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStrip2.ItemRadius = 4;
            this.skinToolStrip2.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelProfile,
            this.toolStripLabelOperator,
            this.toolStripLabel_netState,
            this.toolStripProgressBar1,
            this.skinLabel_TaskName,
            this.toolStripLabelLoad});
            this.skinToolStrip2.Location = new System.Drawing.Point(4, 693);
            this.skinToolStrip2.Name = "skinToolStrip2";
            this.skinToolStrip2.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStrip2.Size = new System.Drawing.Size(1192, 30);
            this.skinToolStrip2.SkinAllColor = false;
            this.skinToolStrip2.TabIndex = 4;
            this.skinToolStrip2.Text = "skinToolStrip2";
            this.skinToolStrip2.TitleAnamorphosis = true;
            this.skinToolStrip2.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStrip2.TitleRadius = 4;
            this.skinToolStrip2.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripLabelProfile
            // 
            this.toolStripLabelProfile.Name = "toolStripLabelProfile";
            this.toolStripLabelProfile.Size = new System.Drawing.Size(103, 27);
            this.toolStripLabelProfile.Text = "toolStripLabel13";
            // 
            // toolStripLabelOperator
            // 
            this.toolStripLabelOperator.Name = "toolStripLabelOperator";
            this.toolStripLabelOperator.Size = new System.Drawing.Size(56, 27);
            this.toolStripLabelOperator.Text = "操作员：";
            // 
            // toolStripLabel_netState
            // 
            this.toolStripLabel_netState.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel_netState.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel_netState.Name = "toolStripLabel_netState";
            this.toolStripLabel_netState.Size = new System.Drawing.Size(68, 27);
            this.toolStripLabel_netState.Text = "网络：正常";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(400, 27);
            this.toolStripProgressBar1.Step = 1;
            // 
            // skinLabel_TaskName
            // 
            this.skinLabel_TaskName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.skinLabel_TaskName.Name = "skinLabel_TaskName";
            this.skinLabel_TaskName.Size = new System.Drawing.Size(0, 27);
            // 
            // toolStripLabelLoad
            // 
            this.toolStripLabelLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelLoad.Name = "toolStripLabelLoad";
            this.toolStripLabelLoad.Size = new System.Drawing.Size(92, 27);
            this.toolStripLabelLoad.Text = "正在加载缓存：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切换账号ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 切换账号ToolStripMenuItem
            // 
            this.切换账号ToolStripMenuItem.Name = "切换账号ToolStripMenuItem";
            this.切换账号ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.切换账号ToolStripMenuItem.Text = "切换账号";
            this.切换账号ToolStripMenuItem.Click += new System.EventHandler(this.切换账号ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_Exit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "易联售-管理端";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.skinToolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 56);
            this.panel1.TabIndex = 5;
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ContextMenuStrip = this.contextMenuStrip2;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton1.ImageSize = new System.Drawing.Size(22, 24);
            this.skinButton1.Location = new System.Drawing.Point(1176, 37);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(16, 16);
            this.skinButton1.TabIndex = 1;
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.除此之外全部关闭ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(173, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem1.Text = "关闭所有窗口";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 除此之外全部关闭ToolStripMenuItem
            // 
            this.除此之外全部关闭ToolStripMenuItem.Name = "除此之外全部关闭ToolStripMenuItem";
            this.除此之外全部关闭ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.除此之外全部关闭ToolStripMenuItem.Text = "除此之外全部关闭";
            this.除此之外全部关闭ToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.HeadPalace = true;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 84);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageCloseVisble = true;
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.Size = new System.Drawing.Size(1192, 609);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.skinTabControl1.TabIndex = 1;
            this.skinTabControl1.TabePageClosing += new CCWin.SkinControl.SkinTabControl.ClosingTabePageHandler(this.skinTabControl1_TabePageClosing);
            this.skinTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.skinTabControl1_Selected);
            this.skinTabControl1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.skinTabControl1_ControlRemoved);
            // 
            // skinToolStripAnounce
            // 
            this.skinToolStripAnounce.Arrow = System.Drawing.Color.Black;
            this.skinToolStripAnounce.AutoSize = false;
            this.skinToolStripAnounce.Back = System.Drawing.Color.White;
            this.skinToolStripAnounce.BackColor = System.Drawing.Color.LightCoral;
            this.skinToolStripAnounce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.skinToolStripAnounce.BackRadius = 4;
            this.skinToolStripAnounce.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinToolStripAnounce.Base = System.Drawing.Color.LightCoral;
            this.skinToolStripAnounce.BaseFore = System.Drawing.Color.Black;
            this.skinToolStripAnounce.BaseForeAnamorphosis = false;
            this.skinToolStripAnounce.BaseForeAnamorphosisBorder = 4;
            this.skinToolStripAnounce.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinToolStripAnounce.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.skinToolStripAnounce.BaseHoverFore = System.Drawing.Color.White;
            this.skinToolStripAnounce.BaseItemAnamorphosis = true;
            this.skinToolStripAnounce.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStripAnounce.BaseItemBorderShow = true;
            this.skinToolStripAnounce.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStripAnounce.BaseItemDown")));
            this.skinToolStripAnounce.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStripAnounce.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStripAnounce.BaseItemMouse")));
            this.skinToolStripAnounce.BaseItemNorml = null;
            this.skinToolStripAnounce.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStripAnounce.BaseItemRadius = 4;
            this.skinToolStripAnounce.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStripAnounce.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStripAnounce.BindTabControl = null;
            this.skinToolStripAnounce.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinToolStripAnounce.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinToolStripAnounce.Fore = System.Drawing.Color.Black;
            this.skinToolStripAnounce.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.skinToolStripAnounce.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.skinToolStripAnounce.HoverFore = System.Drawing.Color.White;
            this.skinToolStripAnounce.ItemAnamorphosis = true;
            this.skinToolStripAnounce.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStripAnounce.ItemBorderShow = true;
            this.skinToolStripAnounce.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStripAnounce.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinToolStripAnounce.ItemRadius = 4;
            this.skinToolStripAnounce.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStripAnounce.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelAnounce,
            this.toolStripLabel1});
            this.skinToolStripAnounce.Location = new System.Drawing.Point(4, 663);
            this.skinToolStripAnounce.Name = "skinToolStripAnounce";
            this.skinToolStripAnounce.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinToolStripAnounce.Size = new System.Drawing.Size(1192, 30);
            this.skinToolStripAnounce.SkinAllColor = false;
            this.skinToolStripAnounce.TabIndex = 6;
            this.skinToolStripAnounce.Text = "skinToolStrip3";
            this.skinToolStripAnounce.TitleAnamorphosis = true;
            this.skinToolStripAnounce.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinToolStripAnounce.TitleRadius = 4;
            this.skinToolStripAnounce.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripLabelAnounce
            // 
            this.toolStripLabelAnounce.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripLabelAnounce.Name = "toolStripLabelAnounce";
            this.toolStripLabelAnounce.Size = new System.Drawing.Size(148, 27);
            this.toolStripLabelAnounce.Text = "toolStripLabelAnounce";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 27);
            this.toolStripLabel1.Text = "X";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = true;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.skinToolStripAnounce);
            this.Controls.Add(this.skinTabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinToolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 726);
            this.Name = "MainForm";
            this.Text = "设备配置客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.skinToolStrip2.ResumeLayout(false);
            this.skinToolStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.skinToolStripAnounce.ResumeLayout(false);
            this.skinToolStripAnounce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
         
        #endregion
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip2;
        
        private System.Windows.Forms.ToolStripLabel toolStripLabelOperator;
        private System.Windows.Forms.ToolStripLabel toolStripLabelProfile; 
        private System.Windows.Forms.ToolStripLabel toolStripLabel_netState;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 除此之外全部关闭ToolStripMenuItem;
        private CCWin.SkinControl.SkinToolStrip skinToolStripAnounce;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAnounce;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem 切换账号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripLabel skinLabel_TaskName;
        private System.Windows.Forms.ToolStripLabel toolStripLabelLoad;
    }
}