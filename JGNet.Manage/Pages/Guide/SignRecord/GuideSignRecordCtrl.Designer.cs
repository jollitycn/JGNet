using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
    partial class GuideSignRecordCtrl
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
            this.skinSplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinPictureBox2 = new CCWin.SkinControl.SkinPictureBox();
            this.skinPanel1 = new System.Windows.Forms.Panel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel_settingTime = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel_time = new CCWin.SkinControl.SkinLabel();
            this.BaseButton_sign = new  Common.Components.BaseButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skinFlowLayoutPanel_signType = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.skinRadioButton1 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton2 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton3 = new CCWin.SkinControl.SkinRadioButton();
            this.skinRadioButton4 = new CCWin.SkinControl.SkinRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guideComboBox1 = new JGNet.Common.GuideComboBox();
            this.skinLabel_operator = new CCWin.SkinControl.SkinLabel();
            this.skinLabel_Shop = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox2)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.skinFlowLayoutPanel_signType.SuspendLayout();
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
            this.skinSplitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.panel2);
            this.skinSplitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.skinSplitContainer1.Panel2.Controls.Add(this.panel1);
            this.skinSplitContainer1.Size = new System.Drawing.Size(1160,650);
            this.skinSplitContainer1.SplitterDistance = 586;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.skinPictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 550);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "摄像头";
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPictureBox1.Image = global::JGNet.Manage.Properties.Resources._81021343970475;
            this.skinPictureBox1.Location = new System.Drawing.Point(3, 17);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(580, 530);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox1.TabIndex = 135;
            this.skinPictureBox1.TabStop = false;
            this.skinPictureBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.skinPictureBox2);
            this.panel2.Controls.Add(this.skinPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 425);
            this.panel2.TabIndex = 19;
            // 
            // skinPictureBox2
            // 
            this.skinPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinPictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPictureBox2.Image = global::JGNet.Manage.Properties.Resources._81021343970475;
            this.skinPictureBox2.Location = new System.Drawing.Point(0, 0);
            this.skinPictureBox2.Name = "skinPictureBox2";
            this.skinPictureBox2.Size = new System.Drawing.Size(370, 252);
            this.skinPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.skinPictureBox2.TabIndex = 139;
            this.skinPictureBox2.TabStop = false;
            this.skinPictureBox2.Visible = false;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel_settingTime);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLabel_time);
            this.skinPanel1.Controls.Add(this.BaseButton_sign);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.Location = new System.Drawing.Point(0, 252);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(370, 173);
            this.skinPanel1.TabIndex = 138;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(3, 16);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(107, 25);
            this.skinLabel4.TabIndex = 137;
            this.skinLabel4.Text = "当前时间：";
            // 
            // skinLabel_settingTime
            // 
            this.skinLabel_settingTime.AutoSize = true;
            this.skinLabel_settingTime.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_settingTime.BorderColor = System.Drawing.Color.White;
            this.skinLabel_settingTime.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.skinLabel_settingTime.ForeColor = System.Drawing.Color.Black;
            this.skinLabel_settingTime.Location = new System.Drawing.Point(116, 41);
            this.skinLabel_settingTime.Name = "skinLabel_settingTime";
            this.skinLabel_settingTime.Size = new System.Drawing.Size(238, 25);
            this.skinLabel_settingTime.TabIndex = 137;
            this.skinLabel_settingTime.Text = "2001-10-10 hh：mm：ss";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.skinLabel2.ForeColor = System.Drawing.Color.Black;
            this.skinLabel2.Location = new System.Drawing.Point(3, 41);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(107, 25);
            this.skinLabel2.TabIndex = 137;
            this.skinLabel2.Text = "规定时间：";
            // 
            // skinLabel_time
            // 
            this.skinLabel_time.AutoSize = true;
            this.skinLabel_time.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_time.BorderColor = System.Drawing.Color.White;
            this.skinLabel_time.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.skinLabel_time.ForeColor = System.Drawing.Color.Black;
            this.skinLabel_time.Location = new System.Drawing.Point(116, 16);
            this.skinLabel_time.Name = "skinLabel_time";
            this.skinLabel_time.Size = new System.Drawing.Size(238, 25);
            this.skinLabel_time.TabIndex = 137;
            this.skinLabel_time.Text = "2001-10-10 hh：mm：ss";
            // 
            // BaseButton_sign
            // 
            this.BaseButton_sign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BaseButton_sign.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_sign.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_sign.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_sign.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_sign.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_sign.Location = new System.Drawing.Point(154, 111);
            this.BaseButton_sign.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_sign.Name = "BaseButton_sign";
            this.BaseButton_sign.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_sign.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_sign.TabIndex = 5;
            this.BaseButton_sign.Text = "签到";
            this.BaseButton_sign.UseVisualStyleBackColor = false;
            this.BaseButton_sign.Click += new System.EventHandler(this.BaseButton_sign_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.skinFlowLayoutPanel_signType);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 49);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "打卡类型";
            // 
            // skinFlowLayoutPanel_signType
            // 
            this.skinFlowLayoutPanel_signType.BackColor = System.Drawing.Color.Transparent;
            this.skinFlowLayoutPanel_signType.Controls.Add(this.skinRadioButton1);
            this.skinFlowLayoutPanel_signType.Controls.Add(this.skinRadioButton2);
            this.skinFlowLayoutPanel_signType.Controls.Add(this.skinRadioButton3);
            this.skinFlowLayoutPanel_signType.Controls.Add(this.skinRadioButton4);
            this.skinFlowLayoutPanel_signType.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel_signType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinFlowLayoutPanel_signType.DownBack = null;
            this.skinFlowLayoutPanel_signType.Location = new System.Drawing.Point(3, 17);
            this.skinFlowLayoutPanel_signType.MouseBack = null;
            this.skinFlowLayoutPanel_signType.Name = "skinFlowLayoutPanel_signType";
            this.skinFlowLayoutPanel_signType.NormlBack = null;
            this.skinFlowLayoutPanel_signType.Size = new System.Drawing.Size(364, 29);
            this.skinFlowLayoutPanel_signType.TabIndex = 0;
            // 
            // skinRadioButton1
            // 
            this.skinRadioButton1.AutoSize = true;
            this.skinRadioButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton1.Checked = true;
            this.skinRadioButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton1.DownBack = null;
            this.skinRadioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton1.Location = new System.Drawing.Point(3, 3);
            this.skinRadioButton1.MouseBack = null;
            this.skinRadioButton1.Name = "skinRadioButton1";
            this.skinRadioButton1.NormlBack = null;
            this.skinRadioButton1.SelectedDownBack = null;
            this.skinRadioButton1.SelectedMouseBack = null;
            this.skinRadioButton1.SelectedNormlBack = null;
            this.skinRadioButton1.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButton1.TabIndex = 1;
            this.skinRadioButton1.TabStop = true;
            this.skinRadioButton1.Text = "早班上班";
            this.skinRadioButton1.UseVisualStyleBackColor = false;
            this.skinRadioButton1.CheckedChanged += new System.EventHandler(this.skinRadioButton_CheckedChanged);
            // 
            // skinRadioButton2
            // 
            this.skinRadioButton2.AutoSize = true;
            this.skinRadioButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton2.DownBack = null;
            this.skinRadioButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton2.Location = new System.Drawing.Point(83, 3);
            this.skinRadioButton2.MouseBack = null;
            this.skinRadioButton2.Name = "skinRadioButton2";
            this.skinRadioButton2.NormlBack = null;
            this.skinRadioButton2.SelectedDownBack = null;
            this.skinRadioButton2.SelectedMouseBack = null;
            this.skinRadioButton2.SelectedNormlBack = null;
            this.skinRadioButton2.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButton2.TabIndex = 2;
            this.skinRadioButton2.TabStop = true;
            this.skinRadioButton2.Text = "早班下班";
            this.skinRadioButton2.UseVisualStyleBackColor = false;
            this.skinRadioButton2.CheckedChanged += new System.EventHandler(this.skinRadioButton_CheckedChanged);
            // 
            // skinRadioButton3
            // 
            this.skinRadioButton3.AutoSize = true;
            this.skinRadioButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton3.DownBack = null;
            this.skinRadioButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton3.Location = new System.Drawing.Point(163, 3);
            this.skinRadioButton3.MouseBack = null;
            this.skinRadioButton3.Name = "skinRadioButton3";
            this.skinRadioButton3.NormlBack = null;
            this.skinRadioButton3.SelectedDownBack = null;
            this.skinRadioButton3.SelectedMouseBack = null;
            this.skinRadioButton3.SelectedNormlBack = null;
            this.skinRadioButton3.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButton3.TabIndex = 3;
            this.skinRadioButton3.TabStop = true;
            this.skinRadioButton3.Text = "晚班上班";
            this.skinRadioButton3.UseVisualStyleBackColor = false;
            this.skinRadioButton3.CheckedChanged += new System.EventHandler(this.skinRadioButton_CheckedChanged);
            // 
            // skinRadioButton4
            // 
            this.skinRadioButton4.AutoSize = true;
            this.skinRadioButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinRadioButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinRadioButton4.DownBack = null;
            this.skinRadioButton4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinRadioButton4.Location = new System.Drawing.Point(243, 3);
            this.skinRadioButton4.MouseBack = null;
            this.skinRadioButton4.Name = "skinRadioButton4";
            this.skinRadioButton4.NormlBack = null;
            this.skinRadioButton4.SelectedDownBack = null;
            this.skinRadioButton4.SelectedMouseBack = null;
            this.skinRadioButton4.SelectedNormlBack = null;
            this.skinRadioButton4.Size = new System.Drawing.Size(74, 21);
            this.skinRadioButton4.TabIndex = 4;
            this.skinRadioButton4.TabStop = true;
            this.skinRadioButton4.Text = "晚班下班";
            this.skinRadioButton4.UseVisualStyleBackColor = false;
            this.skinRadioButton4.CheckedChanged += new System.EventHandler(this.skinRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guideComboBox1);
            this.panel1.Controls.Add(this.skinLabel_operator);
            this.panel1.Controls.Add(this.skinLabel_Shop);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 76);
            this.panel1.TabIndex = 17;
            // 
            // guideComboBox1
            // 
            this.guideComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guideComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guideComboBox1.FormattingEnabled = true;
            this.guideComboBox1.Location = new System.Drawing.Point(100, 40);
            this.guideComboBox1.Name = "guideComboBox1";
            this.guideComboBox1.ShopID = null;
            this.guideComboBox1.Size = new System.Drawing.Size(80, 22);
            this.guideComboBox1.TabIndex = 0;
            this.guideComboBox1.WaterText = "";
            // 
            // skinLabel_operator
            // 
            this.skinLabel_operator.AutoSize = true;
            this.skinLabel_operator.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_operator.BorderColor = System.Drawing.Color.White;
            this.skinLabel_operator.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_operator.Location = new System.Drawing.Point(38, 45);
            this.skinLabel_operator.Name = "skinLabel_operator";
            this.skinLabel_operator.Size = new System.Drawing.Size(56, 17);
            this.skinLabel_operator.TabIndex = 18;
            this.skinLabel_operator.Text = "签到人：";
            // 
            // skinLabel_Shop
            // 
            this.skinLabel_Shop.AutoSize = true;
            this.skinLabel_Shop.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_Shop.BorderColor = System.Drawing.Color.White;
            this.skinLabel_Shop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_Shop.Location = new System.Drawing.Point(100, 17);
            this.skinLabel_Shop.Name = "skinLabel_Shop";
            this.skinLabel_Shop.Size = new System.Drawing.Size(69, 17);
            this.skinLabel_Shop.TabIndex = 16;
            this.skinLabel_Shop.Text = "skinLabel1";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(26, 17);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 17;
            this.skinLabel1.Text = "所属店铺：";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GuideSignRecordCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinSplitContainer1);
            this.Name = "GuideSignRecordCtrl";
            this.Load += new System.EventHandler(this.GuideSignRecordCtrl_Load);
            this.Controls.SetChildIndex(this.skinSplitContainer1, 0);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
           
            this.skinSplitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox2)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.skinFlowLayoutPanel_signType.ResumeLayout(false);
            this.skinFlowLayoutPanel_signType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private  SplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinLabel skinLabel_operator;
        private CCWin.SkinControl.SkinLabel skinLabel_Shop;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Panel panel2;
        private Common.Components.BaseButton BaseButton_sign;
        private CCWin.SkinControl.SkinLabel skinLabel_time;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel_signType;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton1;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton2;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton3;
        private CCWin.SkinControl.SkinRadioButton skinRadioButton4;
        private System.Windows.Forms.Panel skinPanel1;
        private Common.GuideComboBox guideComboBox1;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox2;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel_settingTime;
    }
}
