using CCWin.SkinControl;
using System;

namespace JGNet.Manage.Pages.Setting.BasicSettings.Costume
{
    partial class SizeGroupSelectForm
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
            this.BaseButton3 = new JGNet.Common.Components.BaseButton();
            this.baseButton1 = new JGNet.Common.Components.BaseButton();
            this.skinPanel1 = new SkinPanel();
            this.skinFlowLayoutPanel2 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.skinComboBoxSizeGroup = new CCWin.SkinControl.SkinComboBox();
            this.panel1 = new SkinPanel();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.skinPanel1.SuspendLayout();
            this.skinFlowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseButton3
            // 
            this.BaseButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BaseButton3.BackColor = System.Drawing.SystemColors.Control;
            this.BaseButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton3.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton3.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton3.Location = new System.Drawing.Point(250, 7);
            this.BaseButton3.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton3.Name = "BaseButton3";
            this.BaseButton3.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton3.Size = new System.Drawing.Size(75, 32);
            this.BaseButton3.TabIndex = 18;
            this.BaseButton3.Text = "确定";
            this.BaseButton3.UseVisualStyleBackColor = false;
            this.BaseButton3.Click += new System.EventHandler(this.button1_Click);
            // 
            // baseButton1
            // 
            this.baseButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.baseButton1.BackColor = System.Drawing.SystemColors.Control;
            this.baseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton1.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton1.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton1.Location = new System.Drawing.Point(331, 7);
            this.baseButton1.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton1.Name = "baseButton1";
            this.baseButton1.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton1.Size = new System.Drawing.Size(75, 32);
            this.baseButton1.TabIndex = 19;
            this.baseButton1.Text = "取消";
            this.baseButton1.UseVisualStyleBackColor = false;
            this.baseButton1.Click += new System.EventHandler(this.baseButton1_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.baseButton1);
            this.skinPanel1.Controls.Add(this.BaseButton3);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.Location = new System.Drawing.Point(4, 137);
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.Size = new System.Drawing.Size(652, 42);
            this.skinPanel1.TabIndex = 20;
            // 
            // skinFlowLayoutPanel2
            // 
            this.skinFlowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinFlowLayoutPanel2.Controls.Add(this.skinComboBoxSizeGroup);
            this.skinFlowLayoutPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinFlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinFlowLayoutPanel2.DownBack = null;
            this.skinFlowLayoutPanel2.Location = new System.Drawing.Point(4, 28);
            this.skinFlowLayoutPanel2.MouseBack = null;
            this.skinFlowLayoutPanel2.Name = "skinFlowLayoutPanel2";
            this.skinFlowLayoutPanel2.NormlBack = null;
            this.skinFlowLayoutPanel2.Size = new System.Drawing.Size(652, 29);
            this.skinFlowLayoutPanel2.TabIndex = 22;
            // 
            // skinComboBoxSizeGroup
            // 
            this.skinComboBoxSizeGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinComboBoxSizeGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBoxSizeGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBoxSizeGroup.FormattingEnabled = true;
            this.skinComboBoxSizeGroup.Location = new System.Drawing.Point(3, 3);
            this.skinComboBoxSizeGroup.Name = "skinComboBoxSizeGroup";
            this.skinComboBoxSizeGroup.Size = new System.Drawing.Size(164, 22);
            this.skinComboBoxSizeGroup.TabIndex = 194;
            this.skinComboBoxSizeGroup.WaterText = "";
            this.skinComboBoxSizeGroup.SelectedIndexChanged += new System.EventHandler(this.skinComboBoxSizeGroup_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 80);
            this.panel1.TabIndex = 23;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(409, 48);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(84, 16);
            this.checkBox11.TabIndex = 22;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(311, 48);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(84, 16);
            this.checkBox10.TabIndex = 21;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(213, 48);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(78, 16);
            this.checkBox9.TabIndex = 20;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(115, 48);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(78, 16);
            this.checkBox8.TabIndex = 19;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(17, 48);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(78, 16);
            this.checkBox7.TabIndex = 18;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(507, 14);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(78, 16);
            this.checkBox6.TabIndex = 17;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(409, 14);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 16);
            this.checkBox5.TabIndex = 16;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(311, 14);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 16);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(213, 14);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 16);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(115, 14);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 16);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SizeGroupSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(660, 183);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinFlowLayoutPanel2);
            this.Controls.Add(this.skinPanel1);
            this.Name = "SizeGroupSelectForm";
            this.Text = "添加尺码组";
            this.Load += new System.EventHandler(this.SizeForm_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinFlowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Common.Components.BaseButton BaseButton3;
        private Common.Components.BaseButton baseButton1;
        private SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel2;
        private CCWin.SkinControl.SkinComboBox skinComboBoxSizeGroup;
        private SkinPanel panel1;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}