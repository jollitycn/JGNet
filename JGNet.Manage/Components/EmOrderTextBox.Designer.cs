namespace JGNet.Manage
{
    partial class EmOrderTextBox
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(150, 150);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // EmOrderTextBox
            // 
            this.Lines = new string[0];
            // 
            // 
            // 
            this.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.SkinTxt.Name = "BaseText";
            this.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.SkinTxt.TabIndex = 0;
            this.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.SkinTxt.WaterText = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
    }
}
