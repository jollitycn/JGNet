namespace JGNet.Manage
{
    partial class ColorPictureListForm
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
            this.BaseButton_OK = new JGNet.Common.Components.BaseButton();
            this.BaseButton_Cancel = new JGNet.Common.Components.BaseButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // BaseButton_OK
            // 
            this.BaseButton_OK.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_OK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_OK.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_OK.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_OK.Location = new System.Drawing.Point(192, 284);
            this.BaseButton_OK.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_OK.Name = "BaseButton_OK";
            this.BaseButton_OK.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_OK.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_OK.TabIndex = 2;
            this.BaseButton_OK.Text = "确认";
            this.BaseButton_OK.UseVisualStyleBackColor = false;
            this.BaseButton_OK.Click += new System.EventHandler(this.BaseButton_OK_Click);
            // 
            // BaseButton_Cancel
            // 
            this.BaseButton_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton_Cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton_Cancel.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton_Cancel.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton_Cancel.Location = new System.Drawing.Point(273, 284);
            this.BaseButton_Cancel.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton_Cancel.Name = "BaseButton_Cancel";
            this.BaseButton_Cancel.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton_Cancel.Size = new System.Drawing.Size(75, 32);
            this.BaseButton_Cancel.TabIndex = 3;
            this.BaseButton_Cancel.Text = "取消";
            this.BaseButton_Cancel.UseVisualStyleBackColor = false;
            this.BaseButton_Cancel.Click += new System.EventHandler(this.BaseButton_Cancel_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(7, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(550, 247);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ColorPictureListForm
            // 
            this.AcceptButton = this.BaseButton_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 323);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BaseButton_Cancel);
            this.Controls.Add(this.BaseButton_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorPictureListForm";
            this.Text = "图片列表";
            this.Load += new System.EventHandler(this.ColorPictureListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Common.Components.BaseButton BaseButton_OK;
        private Common.Components.BaseButton BaseButton_Cancel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}