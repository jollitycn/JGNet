using CCWin.SkinControl;

namespace JGNet.Common.Components
{
    partial class SizeGroupSelector
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.skinFlowLayoutPanel2 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.尺码1 = new System.Windows.Forms.CheckBox();
            this.skinFlowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(17, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(107, 21);
            this.radioButton1.TabIndex = 113;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // skinFlowLayoutPanel2
            // 
            this.skinFlowLayoutPanel2.AutoScroll = true;
            this.skinFlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinFlowLayoutPanel2.Controls.Add(this.尺码1);
            this.skinFlowLayoutPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel2.DownBack = null;
            this.skinFlowLayoutPanel2.Location = new System.Drawing.Point(17, 39);
            this.skinFlowLayoutPanel2.MouseBack = null;
            this.skinFlowLayoutPanel2.Name = "skinFlowLayoutPanel2";
            this.skinFlowLayoutPanel2.NormlBack = null;
            this.skinFlowLayoutPanel2.Size = new System.Drawing.Size(597, 61);
            this.skinFlowLayoutPanel2.TabIndex = 114;
            // 
            // 尺码1
            // 
            this.尺码1.AutoSize = true;
            this.尺码1.Location = new System.Drawing.Point(3, 3);
            this.尺码1.Name = "尺码1";
            this.尺码1.Size = new System.Drawing.Size(78, 16);
            this.尺码1.TabIndex = 0;
            this.尺码1.Text = "checkBox1";
            this.尺码1.UseVisualStyleBackColor = true;
            // 
            // SizeGroupSelector
            // 
            this.AllowDrop = true;
            this.AutoSize = true;
            this.Controls.Add(this.skinFlowLayoutPanel2);
            this.Controls.Add(this.radioButton1);
            this.MinimumSize = new System.Drawing.Size(80, 64);
            this.Name = "SizeGroupSelector";
            this.Size = new System.Drawing.Size(874, 149);
            this.Load += new System.EventHandler(this.SizeGroupSelector_Load);
            this.skinFlowLayoutPanel2.ResumeLayout(false);
            this.skinFlowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private SkinFlowLayoutPanel skinFlowLayoutPanel2;
        private System.Windows.Forms.CheckBox 尺码1;
    }
}
