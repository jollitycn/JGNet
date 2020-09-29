namespace JGNet.Manage.Pages
{
    partial class BarCodeCtrl
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
            this.BaseButton2 = new JGNet.Common.Components.BaseButton();
            this.skinCheckBoxCostume = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxColor = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxSize = new CCWin.SkinControl.SkinCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skinCheckBoxClass = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBox2 = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxRemark = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxCostumeName = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxSalePrice = new CCWin.SkinControl.SkinCheckBox();
            this.skinCheckBoxBarcode = new CCWin.SkinControl.SkinCheckBox();
            this.SuspendLayout();
            // 
            // BaseButton2
            // 
            this.BaseButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BaseButton2.BackColor = System.Drawing.Color.Transparent;
            this.BaseButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.BaseButton2.DownBack = global::JGNet.Manage.Properties.Resources.btnDownBack;
            this.BaseButton2.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.BaseButton2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BaseButton2.Location = new System.Drawing.Point(514, 506);
            this.BaseButton2.MouseBack = global::JGNet.Manage.Properties.Resources.btnMouseBack;
            this.BaseButton2.Name = "BaseButton2";
            this.BaseButton2.NormlBack = global::JGNet.Manage.Properties.Resources.btnNormlBack;
            this.BaseButton2.Size = new System.Drawing.Size(75, 32);
            this.BaseButton2.TabIndex = 1;
            this.BaseButton2.Text = "保存";
            this.BaseButton2.UseVisualStyleBackColor = false;
            this.BaseButton2.Click += new System.EventHandler(this.BaseButtonSave_Click);
            // 
            // skinCheckBoxCostume
            // 
            this.skinCheckBoxCostume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxCostume.AutoSize = true;
            this.skinCheckBoxCostume.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxCostume.Checked = true;
            this.skinCheckBoxCostume.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxCostume.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxCostume.DownBack = null;
            this.skinCheckBoxCostume.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxCostume.Location = new System.Drawing.Point(483, 167);
            this.skinCheckBoxCostume.MouseBack = null;
            this.skinCheckBoxCostume.Name = "skinCheckBoxCostume";
            this.skinCheckBoxCostume.NormlBack = null;
            this.skinCheckBoxCostume.SelectedDownBack = null;
            this.skinCheckBoxCostume.SelectedMouseBack = null;
            this.skinCheckBoxCostume.SelectedNormlBack = null;
            this.skinCheckBoxCostume.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxCostume.TabIndex = 17;
            this.skinCheckBoxCostume.Tag = "CostumeID";
            this.skinCheckBoxCostume.Text = "款号";
            this.skinCheckBoxCostume.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxColor
            // 
            this.skinCheckBoxColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxColor.AutoSize = true;
            this.skinCheckBoxColor.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxColor.Checked = true;
            this.skinCheckBoxColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxColor.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxColor.DownBack = null;
            this.skinCheckBoxColor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxColor.Location = new System.Drawing.Point(483, 194);
            this.skinCheckBoxColor.MouseBack = null;
            this.skinCheckBoxColor.Name = "skinCheckBoxColor";
            this.skinCheckBoxColor.NormlBack = null;
            this.skinCheckBoxColor.SelectedDownBack = null;
            this.skinCheckBoxColor.SelectedMouseBack = null;
            this.skinCheckBoxColor.SelectedNormlBack = null;
            this.skinCheckBoxColor.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxColor.TabIndex = 17;
            this.skinCheckBoxColor.Tag = "ColorName";
            this.skinCheckBoxColor.Text = "颜色";
            this.skinCheckBoxColor.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxSize
            // 
            this.skinCheckBoxSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxSize.AutoSize = true;
            this.skinCheckBoxSize.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxSize.Checked = true;
            this.skinCheckBoxSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxSize.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxSize.DownBack = null;
            this.skinCheckBoxSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxSize.Location = new System.Drawing.Point(540, 194);
            this.skinCheckBoxSize.MouseBack = null;
            this.skinCheckBoxSize.Name = "skinCheckBoxSize";
            this.skinCheckBoxSize.NormlBack = null;
            this.skinCheckBoxSize.SelectedDownBack = null;
            this.skinCheckBoxSize.SelectedMouseBack = null;
            this.skinCheckBoxSize.SelectedNormlBack = null;
            this.skinCheckBoxSize.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxSize.TabIndex = 18;
            this.skinCheckBoxSize.Tag = "SizeName";
            this.skinCheckBoxSize.Text = "尺码";
            this.skinCheckBoxSize.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(399, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "条码设置：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // skinCheckBoxClass
            // 
            this.skinCheckBoxClass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxClass.AutoSize = true;
            this.skinCheckBoxClass.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxClass.Checked = true;
            this.skinCheckBoxClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxClass.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxClass.DownBack = null;
            this.skinCheckBoxClass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxClass.Location = new System.Drawing.Point(483, 221);
            this.skinCheckBoxClass.MouseBack = null;
            this.skinCheckBoxClass.Name = "skinCheckBoxClass";
            this.skinCheckBoxClass.NormlBack = null;
            this.skinCheckBoxClass.SelectedDownBack = null;
            this.skinCheckBoxClass.SelectedMouseBack = null;
            this.skinCheckBoxClass.SelectedNormlBack = null;
            this.skinCheckBoxClass.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxClass.TabIndex = 22;
            this.skinCheckBoxClass.Tag = "ClassName";
            this.skinCheckBoxClass.Text = "类别";
            this.skinCheckBoxClass.UseVisualStyleBackColor = false;
            // 
            // skinCheckBox2
            // 
            this.skinCheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBox2.AutoSize = true;
            this.skinCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBox2.Checked = true;
            this.skinCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBox2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBox2.DownBack = null;
            this.skinCheckBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBox2.Location = new System.Drawing.Point(621, 194);
            this.skinCheckBox2.MouseBack = null;
            this.skinCheckBox2.Name = "skinCheckBox2";
            this.skinCheckBox2.NormlBack = null;
            this.skinCheckBox2.SelectedDownBack = null;
            this.skinCheckBox2.SelectedMouseBack = null;
            this.skinCheckBox2.SelectedNormlBack = null;
            this.skinCheckBox2.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBox2.TabIndex = 20;
            this.skinCheckBox2.Tag = "BrandName";
            this.skinCheckBox2.Text = "商品品牌";
            this.skinCheckBox2.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxRemark
            // 
            this.skinCheckBoxRemark.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxRemark.AutoSize = true;
            this.skinCheckBoxRemark.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxRemark.Checked = true;
            this.skinCheckBoxRemark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxRemark.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxRemark.DownBack = null;
            this.skinCheckBoxRemark.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxRemark.Location = new System.Drawing.Point(621, 221);
            this.skinCheckBoxRemark.MouseBack = null;
            this.skinCheckBoxRemark.Name = "skinCheckBoxRemark";
            this.skinCheckBoxRemark.NormlBack = null;
            this.skinCheckBoxRemark.SelectedDownBack = null;
            this.skinCheckBoxRemark.SelectedMouseBack = null;
            this.skinCheckBoxRemark.SelectedNormlBack = null;
            this.skinCheckBoxRemark.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBoxRemark.TabIndex = 21;
            this.skinCheckBoxRemark.Tag = "Remarks";
            this.skinCheckBoxRemark.Text = "商品备注";
            this.skinCheckBoxRemark.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxCostumeName
            // 
            this.skinCheckBoxCostumeName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxCostumeName.AutoSize = true;
            this.skinCheckBoxCostumeName.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxCostumeName.Checked = true;
            this.skinCheckBoxCostumeName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxCostumeName.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxCostumeName.DownBack = null;
            this.skinCheckBoxCostumeName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxCostumeName.Location = new System.Drawing.Point(540, 167);
            this.skinCheckBoxCostumeName.MouseBack = null;
            this.skinCheckBoxCostumeName.Name = "skinCheckBoxCostumeName";
            this.skinCheckBoxCostumeName.NormlBack = null;
            this.skinCheckBoxCostumeName.SelectedDownBack = null;
            this.skinCheckBoxCostumeName.SelectedMouseBack = null;
            this.skinCheckBoxCostumeName.SelectedNormlBack = null;
            this.skinCheckBoxCostumeName.Size = new System.Drawing.Size(75, 21);
            this.skinCheckBoxCostumeName.TabIndex = 26;
            this.skinCheckBoxCostumeName.Tag = "CostumeName";
            this.skinCheckBoxCostumeName.Text = "商品名称";
            this.skinCheckBoxCostumeName.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxSalePrice
            // 
            this.skinCheckBoxSalePrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxSalePrice.AutoSize = true;
            this.skinCheckBoxSalePrice.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxSalePrice.Checked = true;
            this.skinCheckBoxSalePrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxSalePrice.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxSalePrice.DownBack = null;
            this.skinCheckBoxSalePrice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxSalePrice.Location = new System.Drawing.Point(540, 221);
            this.skinCheckBoxSalePrice.MouseBack = null;
            this.skinCheckBoxSalePrice.Name = "skinCheckBoxSalePrice";
            this.skinCheckBoxSalePrice.NormlBack = null;
            this.skinCheckBoxSalePrice.SelectedDownBack = null;
            this.skinCheckBoxSalePrice.SelectedMouseBack = null;
            this.skinCheckBoxSalePrice.SelectedNormlBack = null;
            this.skinCheckBoxSalePrice.Size = new System.Drawing.Size(51, 21);
            this.skinCheckBoxSalePrice.TabIndex = 27;
            this.skinCheckBoxSalePrice.Tag = "SalePrice";
            this.skinCheckBoxSalePrice.Text = "售价";
            this.skinCheckBoxSalePrice.UseVisualStyleBackColor = false;
            // 
            // skinCheckBoxBarcode
            // 
            this.skinCheckBoxBarcode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.skinCheckBoxBarcode.AutoSize = true;
            this.skinCheckBoxBarcode.BackColor = System.Drawing.Color.Transparent;
            this.skinCheckBoxBarcode.Checked = true;
            this.skinCheckBoxBarcode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skinCheckBoxBarcode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinCheckBoxBarcode.DownBack = null;
            this.skinCheckBoxBarcode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinCheckBoxBarcode.Location = new System.Drawing.Point(621, 167);
            this.skinCheckBoxBarcode.MouseBack = null;
            this.skinCheckBoxBarcode.Name = "skinCheckBoxBarcode";
            this.skinCheckBoxBarcode.NormlBack = null;
            this.skinCheckBoxBarcode.SelectedDownBack = null;
            this.skinCheckBoxBarcode.SelectedMouseBack = null;
            this.skinCheckBoxBarcode.SelectedNormlBack = null;
            this.skinCheckBoxBarcode.Size = new System.Drawing.Size(63, 21);
            this.skinCheckBoxBarcode.TabIndex = 28;
            this.skinCheckBoxBarcode.Tag = "BarCode";
            this.skinCheckBoxBarcode.Text = "条形码";
            this.skinCheckBoxBarcode.UseVisualStyleBackColor = false;
            // 
            // BarCodeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.skinCheckBoxBarcode);
            this.Controls.Add(this.skinCheckBoxCostumeName);
            this.Controls.Add(this.skinCheckBoxSalePrice);
            this.Controls.Add(this.skinCheckBoxClass);
            this.Controls.Add(this.skinCheckBox2);
            this.Controls.Add(this.skinCheckBoxRemark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinCheckBoxSize);
            this.Controls.Add(this.skinCheckBoxColor);
            this.Controls.Add(this.skinCheckBoxCostume);
            this.Controls.Add(this.BaseButton2);
            this.Name = "BarCodeCtrl";
            this.Load += new System.EventHandler(this.OptionCtrl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Common.Components.BaseButton BaseButton2;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxCostume;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxColor;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxSize;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxClass;
        private CCWin.SkinControl.SkinCheckBox skinCheckBox2;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxRemark;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxCostumeName;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxSalePrice;
        private CCWin.SkinControl.SkinCheckBox skinCheckBoxBarcode;
    }
}
