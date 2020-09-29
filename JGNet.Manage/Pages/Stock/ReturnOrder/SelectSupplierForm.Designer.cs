namespace JGNet.Common.Components
{
    partial class SelectSupplierForm
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
            this.BaseButton_Cancel = new JGNet.Common.Components.BaseButton();
            this.skinComboBoxSupplier = new JGNet.Common.Components.SupllierComboBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.baseButton_confirm = new JGNet.Common.Components.BaseButton();
            this.SuspendLayout();
            // 
            // BaseButton_Cancel
            // 
            this.BaseButton_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseButton_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Cancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Cancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Cancel.Location = new System.Drawing.Point(168, 108);
            this.BaseButton_Cancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Cancel.Name = "BaseButton_Cancel";
            this.BaseButton_Cancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Cancel.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Cancel.TabIndex = 3;
            this.BaseButton_Cancel.Text = "取消";
            this.BaseButton_Cancel.UseVisualStyleBackColor = false;
            this.BaseButton_Cancel.Click += new System.EventHandler(this.BaseButton_Cancel_Click);
            // 
            // skinComboBoxSupplier
            // 
            this.skinComboBoxSupplier.AutoSize = true;
            this.skinComboBoxSupplier.BackColor = System.Drawing.Color.Transparent;
            this.skinComboBoxSupplier.HideAll = true;
            this.skinComboBoxSupplier.Location = new System.Drawing.Point(68, 32);
            this.skinComboBoxSupplier.Name = "skinComboBoxSupplier";
            this.skinComboBoxSupplier.SelectedItem = null;
            this.skinComboBoxSupplier.SelectedValue = null;
            this.skinComboBoxSupplier.ShowAdd = true;
            this.skinComboBoxSupplier.Size = new System.Drawing.Size(175, 26);
            this.skinComboBoxSupplier.TabIndex = 118;
            this.skinComboBoxSupplier.Title = null;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(18, 37);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(44, 17);
            this.skinLabel5.TabIndex = 119;
            this.skinLabel5.Text = "供应商";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(21, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(222, 38);
            this.richTextBox1.TabIndex = 121;
            this.richTextBox1.Text = "为该单选择供应商，确定后将自动绑定该供应商账套信息";
            // 
            // baseButton_confirm
            // 
            this.baseButton_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.baseButton_confirm.BackColor = System.Drawing.Color.Transparent;
            this.baseButton_confirm.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.baseButton_confirm.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.baseButton_confirm.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.baseButton_confirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseButton_confirm.Location = new System.Drawing.Point(87, 108);
            this.baseButton_confirm.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.baseButton_confirm.Name = "baseButton_confirm";
            this.baseButton_confirm.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.baseButton_confirm.Size = new System.Drawing.Size(75, 32);
            this.baseButton_confirm.TabIndex = 3;
            this.baseButton_confirm.Text = "确定";
            this.baseButton_confirm.UseVisualStyleBackColor = false;
            this.baseButton_confirm.Click += new System.EventHandler(this.BaseButton1_Click);
            // 
            // SelectSupplierForm
            // 
            this.AcceptButton = this.BaseButton_Cancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 149);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.skinComboBoxSupplier);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.baseButton_confirm);
            this.Controls.Add(this.BaseButton_Cancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectSupplierForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "绑定供应商";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton_Cancel;
        private SupllierComboBox skinComboBoxSupplier;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private BaseButton baseButton_confirm;
    }
}