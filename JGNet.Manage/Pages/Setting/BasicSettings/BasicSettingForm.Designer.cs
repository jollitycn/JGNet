namespace JGNet.Manage.Components
{
    partial class BasicSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicSettingForm));
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage4 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage5 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage6 = new CCWin.SkinControl.SkinTabPage();
            this.skinPanel1.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.Location = new System.Drawing.Point(4, 552);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(887, 39);
            this.skinPanel1.TabIndex = 7;
            // 
            // baseButton1
            // 
            this.baseButton1.BackColor = System.Drawing.Color.Transparent;
            this.baseButton1.BackgroundImage = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(398, 6);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 2;
            this.baseButton1.Text = "关闭";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.skinTabControl1.Controls.Add(this.skinTabPage4);
            this.skinTabControl1.Controls.Add(this.skinTabPage5);
            this.skinTabControl1.Controls.Add(this.skinTabPage6);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 28);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = null;
            this.skinTabControl1.PageArrowHover = null;
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(887, 524);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.skinTabControl1.TabIndex = 8;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(887, 488);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "品牌";
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.White;
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(887, 488);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "类别";
            // 
            // skinTabPage4
            // 
            this.skinTabPage4.BackColor = System.Drawing.Color.White;
            this.skinTabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage4.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage4.Name = "skinTabPage4";
            this.skinTabPage4.Size = new System.Drawing.Size(887, 488);
            this.skinTabPage4.TabIndex = 3;
            this.skinTabPage4.TabItemImage = null;
            this.skinTabPage4.Text = "颜色";
            // 
            // skinTabPage5
            // 
            this.skinTabPage5.BackColor = System.Drawing.Color.White;
            this.skinTabPage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage5.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage5.Name = "skinTabPage5";
            this.skinTabPage5.Size = new System.Drawing.Size(887, 488);
            this.skinTabPage5.TabIndex = 4;
            this.skinTabPage5.TabItemImage = null;
            this.skinTabPage5.Text = "尺码";
            // 
            // skinTabPage6
            // 
            this.skinTabPage6.BackColor = System.Drawing.Color.White;
            this.skinTabPage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage6.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage6.Name = "skinTabPage6";
            this.skinTabPage6.Size = new System.Drawing.Size(887, 488);
            this.skinTabPage6.TabIndex = 5;
            this.skinTabPage6.TabItemImage = null;
            this.skinTabPage6.Text = "季节";
            // 
            // BasicSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 595);
            this.Controls.Add(this.skinTabControl1);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BasicSettingForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "基础资料";
            this.Load += new System.EventHandler(this.BasicSettingForm_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel skinPanel1;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private CCWin.SkinControl.SkinTabPage skinTabPage4;
        private Common.Components.BaseButton baseButton1;
        private CCWin.SkinControl.SkinTabPage skinTabPage5;
        private CCWin.SkinControl.SkinTabPage skinTabPage6;
    }
}