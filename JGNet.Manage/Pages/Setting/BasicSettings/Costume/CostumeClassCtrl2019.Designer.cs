using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    partial class CostumeClassCtrl2019
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostumeClassCtrl2019));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.baseButtonImport = new JGNet.Common.Components.BaseButton();
            this.baseButtonDownTemplate = new JGNet.Common.Components.DownTemplateButton();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinTreeViewClass = new CCWin.SkinControl.SkinTreeView();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.刪除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新增ToolStripMenuItem.Text = "新增子类";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改ToolStripMenuItem.Text = "编辑";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刪除ToolStripMenuItem.Text = "删除";
            this.刪除ToolStripMenuItem.Click += new System.EventHandler(this.刪除ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "红.png");
            this.imageList1.Images.SetKeyName(1, "绿.png");
            this.imageList1.Images.SetKeyName(2, "黄.png");
            this.imageList1.Images.SetKeyName(3, "蓝.png");
            // 
            // baseButtonImport
            // 
            this.baseButtonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonImport.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonImport.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonImport.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButtonImport.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonImport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonImport.Location = new System.Drawing.Point(1000, 6);
            this.baseButtonImport.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButtonImport.Name = "baseButtonImport";
            this.baseButtonImport.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButtonImport.Size = new System.Drawing.Size(75, 32);
            this.baseButtonImport.TabIndex = 149;
            this.baseButtonImport.Text = "导入";
            this.baseButtonImport.UseVisualStyleBackColor = false;
            this.baseButtonImport.Click += new System.EventHandler(this.baseButtonImport_Click);
            // 
            // baseButtonDownTemplate
            // 
            this.baseButtonDownTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButtonDownTemplate.BackColor = System.Drawing.Color.Transparent;
            this.baseButtonDownTemplate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButtonDownTemplate.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.DownBack")));
            this.baseButtonDownTemplate.DownName = null;
            this.baseButtonDownTemplate.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButtonDownTemplate.FileName = "类别.xls";
            this.baseButtonDownTemplate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButtonDownTemplate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseButtonDownTemplate.Location = new System.Drawing.Point(920, 6);
            this.baseButtonDownTemplate.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.MouseBack")));
            this.baseButtonDownTemplate.Name = "baseButtonDownTemplate";
            this.baseButtonDownTemplate.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButtonDownTemplate.NormlBack")));
            this.baseButtonDownTemplate.Size = new System.Drawing.Size(75, 32);
            this.baseButtonDownTemplate.TabIndex = 150;
            this.baseButtonDownTemplate.Text = "下载模板";
            this.baseButtonDownTemplate.UseVisualStyleBackColor = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.baseButtonDownTemplate);
            this.skinPanel1.Controls.Add(this.baseButtonImport);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(1160, 44);
            this.skinPanel1.TabIndex = 76;
            // 
            // baseButton1
            // 
            this.baseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.DownBack")));
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(1081, 5);
            this.baseButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.MouseBack")));
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("baseButton1.NormlBack")));
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 151;
            this.baseButton1.Text = "导出";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.skinTreeViewClass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 606);
            this.panel1.TabIndex = 77;
            // 
            // skinTreeViewClass
            // 
            this.skinTreeViewClass.ContextMenuStrip = this.contextMenuStrip1;
            this.skinTreeViewClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTreeViewClass.ImageIndex = 0;
            this.skinTreeViewClass.ImageList = this.imageList1;
            this.skinTreeViewClass.Indent = 25;
            this.skinTreeViewClass.ItemHeight = 25;
            this.skinTreeViewClass.Location = new System.Drawing.Point(0, 0);
            this.skinTreeViewClass.Name = "skinTreeViewClass";
            this.skinTreeViewClass.PathSeparator = "-";
            this.skinTreeViewClass.SelectedImageIndex = 0;
            this.skinTreeViewClass.Size = new System.Drawing.Size(1160, 606);
            this.skinTreeViewClass.TabIndex = 76;
            this.skinTreeViewClass.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.skinTreeViewClass_NodeMouseClick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Red;
            this.skinLabel1.Location = new System.Drawing.Point(19, 14);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(152, 17);
            this.skinLabel1.TabIndex = 161;
            this.skinLabel1.Text = "（右键点击进行相关操作）";
            // 
            // CostumeClassCtrl2019
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinPanel1);
            this.Name = "CostumeClassCtrl2019";
            this.Load += new System.EventHandler(this.PermissonCtrl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

            }


        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 新增ToolStripMenuItem;
        private ToolStripMenuItem 修改ToolStripMenuItem;
        private ToolStripMenuItem 刪除ToolStripMenuItem;
        private ImageList imageList1;
        private Common.Components.BaseButton baseButtonImport;
        private Common.Components.DownTemplateButton baseButtonDownTemplate;
        private Panel skinPanel1;
        private Panel panel1;
        private CCWin.SkinControl.SkinTreeView skinTreeViewClass;
        private Common.Components.BaseButton baseButton1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}
