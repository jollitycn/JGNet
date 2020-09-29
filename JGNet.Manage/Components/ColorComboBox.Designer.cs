using System;

namespace JGNet.Manage
{
    partial class ColorComboBox
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
            this.skinLabelAdd = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_Color = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // skinLabelAdd
            // 
            this.skinLabelAdd.AutoSize = true;
            this.skinLabelAdd.BackColor = System.Drawing.Color.Transparent;
            this.skinLabelAdd.BorderColor = System.Drawing.Color.White;
            this.skinLabelAdd.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabelAdd.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.skinLabelAdd.Location = new System.Drawing.Point(168, 0);
            this.skinLabelAdd.Name = "skinLabelAdd";
            this.skinLabelAdd.Size = new System.Drawing.Size(26, 26);
            this.skinLabelAdd.TabIndex = 1;
            this.skinLabelAdd.Text = "+";
            this.skinLabelAdd.Click += new System.EventHandler(this.skinLabelAdd_Click);
            // 
            // skinComboBox_Color
            // 
            this.skinComboBox_Color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinComboBox_Color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_Color.FormattingEnabled = true;
            this.skinComboBox_Color.Location = new System.Drawing.Point(3, 2);
            this.skinComboBox_Color.Name = "skinComboBox_Color";
            this.skinComboBox_Color.Size = new System.Drawing.Size(164, 22);
            this.skinComboBox_Color.TabIndex = 14;
            this.skinComboBox_Color.WaterText = "";
            this.skinComboBox_Color.SelectionChangeCommitted += new System.EventHandler(this.skinComboBox_Color_SelectionChangeCommitted);
            this.skinComboBox_Color.TextUpdate += new System.EventHandler(this.skinComboBox_Color_TextUpdate);
            // 
            // ColorComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinComboBox_Color);
            this.Controls.Add(this.skinLabelAdd);
            this.Name = "ColorComboBox";
            this.Size = new System.Drawing.Size(192, 27);
            this.Load += new System.EventHandler(this.ColorComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinLabel skinLabelAdd;
        private CCWin.SkinControl.SkinComboBox skinComboBox_Color;
    }
}
