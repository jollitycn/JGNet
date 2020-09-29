using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.ForManage;
using CCWin;
using JGNet.Core;
using System.Reflection;
using JGNet.Common.Core; 
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Core.InteractEntity;
using JGNet.Common.Core.Util;
using JGNet.Core.Const; 
using CJBasic.Helpers;
using JGNet.Core.Tools;

namespace JGNet.Manage.Pages
{
    public partial class PrintSettingCtrl : BaseModifyUserControl
    {

        public PrintSettingCtrl()
        {
            InitializeComponent();
            //imageList1.Images.Add();
           
            MenuPermission = RolePermissionMenuEnum.打印设置;
        }

        List<TreeNode> allNodes = null;
        private void PrintSettingCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
            addImageList();
            listBox1.DrawMode = DrawMode.OwnerDrawFixed; //     在控件中的所有元素均为手动绘制，并具有相同的大小。
                                                       
            SetTemplateType(); 
            listBox1.DrawItem += listBox1_DrawItem;
        }
        private void addImageList()
        {

            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.销售退货单1);
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.采购进货单);
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.采购退货单);
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.调拨单1);
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.盘点单);
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.批发发货);
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.批发退货);
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.补货申请单);
            //this.imageList1.Images.Add(global::JGNet.Manage.Properties.Resources.日结存);

            imageList1.Images.SetKeyName(0, "销售退货单1");
            imageList1.Images.SetKeyName(1, "采购进货单");
            imageList1.Images.SetKeyName(2, "采购退货单");
            imageList1.Images.SetKeyName(3, "调拨单1");
            imageList1.Images.SetKeyName(4, "盘点单");
            imageList1.Images.SetKeyName(5, "批发发货");
            imageList1.Images.SetKeyName(6, "批发退货");
            imageList1.Images.SetKeyName(7, "补货申请单");
            imageList1.Images.SetKeyName(8, "日结存");
        }

        private void SetTemplateType()
        {
            List<ListItem<PrintTemplateType>> list = new List<ListItem<PrintTemplateType>>();
            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.Retail), PrintTemplateType.Retail));
            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.PurchaseIn), PrintTemplateType.PurchaseIn));
            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.PurchaseOut), PrintTemplateType.PurchaseOut));
            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.AllocateOrder), PrintTemplateType.AllocateOrder));
            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.CheckStoreOrder), PrintTemplateType.CheckStoreOrder));
            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.PfOrder), PrintTemplateType.PfOrder));
            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.PfTOrder), PrintTemplateType.PfTOrder));

            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.ReplenishOrder), PrintTemplateType.ReplenishOrder));
            list.Add(new ListItem<PrintTemplateType>(Core.Tools.EnumHelper.GetDescription(PrintTemplateType.DayReport), PrintTemplateType.DayReport));

             

            this.listBox1.DisplayMember = "Key";
            this.listBox1.ValueMember = "Value";
            this.listBox1.DataSource = list;
            
        }
        private List<TreeNode> getTypeAll()
        {
            List<TreeNode> nodes = new List<TreeNode>();
            //  InteractResult<List<TreeModel>> infos = CommonGlobalCache.ServerProxy.GetRetailDistributionTree();
            //   list.Add(new ListItem<SupplierAccountRecordPayType>(EnumHelper.GetDescription(SupplierAccountRecordPayType.All), SupplierAccountRecordPayType.All));
            //rootNode.ImageIndex = 0;
            //rootNode.Expand();

            /*  List<ListItem<PfAccountRecordType>> list = new List<ListItem<PfAccountRecordType>>();
              list.Add(new ListItem<PfAccountRecordType>(EnumHelper.GetDescription(PfAccountRecordType.All), PfAccountRecordType.All));*/
            //TreeNode level1 = new TreeNode(JGNet.Core.Tools.EnumHelper.GetDescription(PrintTemplateType.Retail));

            //  level1.Tag = PrintTemplateType.Retail;             
            //  nodes.Add(level1);

            // TreeNode level2 = new TreeNode(JGNet.Core.Tools.EnumHelper.GetDescription(PrintTemplateType.PurchaseIn));
            //level2.Tag = PrintTemplateType.PurchaseIn;
            //  nodes.Add(level2);
            //   return nodes;
            return new List<TreeNode>();
        }


        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;

        private void Initialize()
        {
          //  skinTreeViewPermisson.Nodes.AddRange(PermissonUtil.GetTreeNodes().ToArray());
           // allNodes = WinformUIUtil.GetAllTreeNodes(skinTreeViewPermisson.Nodes);
         //   skinTreeViewPermisson.Nodes[0].FirstNode.ExpandAll(); 

            //List<UserInfo> adminList =  new List<UserInfo>();

            //foreach (var item in CommonGlobalCache.UserInfoList)
            //{
            //    if (item.State == 0)
            //    {
            //        if (item == CommonGlobalCache.GetSupperUserInfo()) { continue; }
            //        adminList.Add(item);
            //    }
            //}
            //adminList.Insert(0, CommonGlobalCache.GetSupperUserInfo());
          //  LoadRoles();


        }


        private void LoadRoles()
        {
          /*  InteractResult<List<Role>> result = GlobalCache.ServerProxy.GetRoles();
            switch (result.ExeResult)
            {
                case ExeResult.Success:
                    dataGridViewPagingSumCtrl.BindingDataSource( DataGridViewUtil.ListToBindingList(result.Data));
                    break;
                case ExeResult.Error:
                    GlobalMessageBox.Show(result.Msg);
                    break;
                default:
                    break;
            }*/
        }


        Role user;

        private void ResetNodeCheck(bool nodeChecked)
        {
            foreach (var item in allNodes)
            {
                item.Checked = nodeChecked;
            }
        }
        

        private String GetPermissonTag(TreeNode item)
        {
            String value = string.Empty;
            if (item != null && item.Tag is RolePermissionEnum)
            {
                value = GetPermissonOnlyTag(item);
            }
            else if (item != null && item.Tag is RolePermissionMenuEnum)
            {
                value = GetPermissonMenuTag(item);
            }
            return value;
        }

        private String GetPermissonMenuTag(TreeNode item)
        {
            String tagStr = string.Empty;
            if (item.Tag is RolePermissionMenuEnum)
            {
                if (item.Nodes != null && item.Nodes.Count > 0)
                {
                    if (item.Nodes[0].Tag is RolePermissionMenuEnum)
                    {
                        tagStr = string.Empty + (int)item.Tag + (int)RolePermissionEnum.查看;
                    }
                    else
                    {
                        tagStr = string.Empty + (int)item.Tag;
                    }
                }
                else
                {
                    tagStr =  string.Empty + (int)item.Tag + (int)RolePermissionEnum.查看; 
                }
            }
            return tagStr;
        }

        private String GetPermissonOnlyTag(TreeNode item)
        {
            String tagStr = string.Empty;
            if (item.Tag is RolePermissionEnum)
            {
                tagStr = ((int)(RolePermissionEnum)item.Tag).ToString();
                if (item.Parent != null)
                {

                    TreeNode menuNode = item.Parent;
                    while (menuNode.Tag is RolePermissionEnum)
                    {
                        menuNode = menuNode.Parent;
                    }
                    tagStr = GetPermissonOnlyTag(menuNode) + tagStr;
                }
            }
            else if (item.Tag is RolePermissionMenuEnum)
            {
                tagStr = ((int)(RolePermissionMenuEnum)item.Tag).ToString();

            }
            return tagStr;
        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            base.TabPage_Close?.Invoke(this.CurrentTabPage, this.SourceCtrlType);
        }

        private List<int> GetPermisson()
        {
            List<int> permission = new List<int>();
            bool hasChecked = false;
            foreach (var item in allNodes)
            {
                if (item.Checked)
                {
                    hasChecked = true;
                    String value = GetPermissonTag(item);
                    int tag = int.Parse(value);
                    if (!permission.Contains(tag))
                    {
                        permission.Add(tag);
                    }
                }
            }

            if (!hasChecked)
            {
                permission = null;
            }

            return permission;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void CheckNode(TreeNode node)
        {
          //  this.skinTreeViewPermisson.AfterCheck -= this.skinTreeViewPermisson_AfterCheck;
            CheckParentNode(node);
            CheckChildNode(node);
          //  this.skinTreeViewPermisson.AfterCheck += this.skinTreeViewPermisson_AfterCheck;
        }

        private void CheckParentNode(TreeNode node)
        {
        
        }

        private void CheckChildNode(TreeNode node)
        {
        
        }

        private void skinTreeViewPermisson_AfterCheck(object sender, TreeViewEventArgs e)
        {
        
        }

        private void baseButtonSave_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
                DataGridView view = sender as DataGridView;
                Role role = view.Rows[e.RowIndex].DataBoundItem as Role;
            
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) { return; }
            if (e.Value == null) { return; }
          /*  if (e.ColumnIndex == ColumnDelete.Index)
            {
                DataGridView view = sender as DataGridView;
                Role role = view.Rows[e.RowIndex].DataBoundItem as Role;
                if (role.AutoID == SystemDefault.DefaultAdminRole)
                {
                    e.Value = null;
                }
            }*/
        }

        private void baseButtonNew_Click(object sender, EventArgs e)
        {
        }
        private void SetUpShopView(List<string> list)
        {
            //设置系统变量

            List<string> keyValues = list;
            
         
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintTemplateType selectType = (PrintTemplateType)this.listBox1.SelectedValue;

            //if (selectType == PrintTemplateType.PurchaseIn)
            //{
               
                
            //}
            switch (selectType)
            {
                case PrintTemplateType.Retail:

                    PrintOfSaleReturnTemplate tSaleReturn = new PrintOfSaleReturnTemplate();
                    tSaleReturn.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tSaleReturn);
                    break;
                case  PrintTemplateType.PurchaseIn:
                    PrintOfPurchaseStock tPurchaseStock = new PrintOfPurchaseStock();
                    tPurchaseStock.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tPurchaseStock);
                    //   tPurchaseStock.Size.Height = this.Height;
                    break;
                case PrintTemplateType.PurchaseOut:
                    PrintOfPurchaseStockReturn tPurchaseReturnStock = new PrintOfPurchaseStockReturn();
                    tPurchaseReturnStock.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tPurchaseReturnStock);

                    break;


                case PrintTemplateType.AllocateOrder:
                    PrintOfAllocateBill tPAllocateBill = new PrintOfAllocateBill();
                    tPAllocateBill.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tPAllocateBill);
                    break;

                case PrintTemplateType.CheckStoreOrder:
                    PrintOfCheckStore tCheckStoreBill = new PrintOfCheckStore();
                    tCheckStoreBill.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tCheckStoreBill);
                    
                    break;

                case PrintTemplateType.PfOrder:

                    PrintOfPfSendBill tPPfSendBill = new PrintOfPfSendBill();
                    tPPfSendBill.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tPPfSendBill);
                    
                    break;

                case PrintTemplateType.PfTOrder:

                    PrintOfPtSendBill tPPtSendBill = new PrintOfPtSendBill();
                    tPPtSendBill.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tPPtSendBill);

                    break;

                case PrintTemplateType.ReplenishOrder:

                    PrintOFreplenishBill tPFreplenishBill = new PrintOFreplenishBill();
                    tPFreplenishBill.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tPFreplenishBill);
                    break;

                case PrintTemplateType.DayReport:
                    PrintOfBalanceOnThatDay tBalanceDay = new PrintOfBalanceOnThatDay();
                    tBalanceDay.Dock = DockStyle.Fill;
                    this.skinSplitContainer1.Panel2.Controls.Clear();
                    this.skinSplitContainer1.Panel2.Controls.Add(tBalanceDay);
                    
                    break;
                default:
                    break;


            }

                // InteractResult<PrintTemplateInfo> ptempInfo = GlobalCache.ServerProxy.GetPrintTemplateInfo(selectType);
                //if (ptempInfo.ExeResult == ExeResult.Success)
                //{
                //ptempInfo.Data.SystemVariable
                //dataGridViewPagingSumCtrl.BindingDataSource(ptempInfo.Data.SystemVariables);
                //                this.dataGridView1.DataSource = ptempInfo.Data.SystemVariables;
                //   SetUpShopView(ptempInfo.Data.SystemVariables);
                //  this.dataGridView2.DataSource = ptempInfo.Data.PrintColumnInfos;
                //}
                //else
                //{
                //    ShowMessage(ptempInfo.Msg);
                //}

                //GetPrintTemplateInfo
                //SavePrintTemplateInfo
            }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.Black;
            Color RowBackColorSel = Color.FromArgb(150, 200, 250);//选择项目颜色
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = new SolidBrush(RowBackColorSel);
            }
            else
            {
                myBrush = new SolidBrush(Color.White);
            }
            e.Graphics.FillRectangle(myBrush, e.Bounds);
            e.DrawFocusRectangle();//焦点框

            //绘制图标
            Image image = imageList1.Images[e.Index];
            Graphics graphics = e.Graphics;
            Rectangle bound = e.Bounds;
            Rectangle imgRec = new Rectangle(
                bound.X,
                bound.Y,
                bound.Height,
                bound.Height);
            Rectangle textRec = new Rectangle(
                imgRec.Right,
                bound.Y,
                bound.Width - imgRec.Right,
                bound.Height);
            if (image != null)
            {
                e.Graphics.DrawImage(
                    image,
                    imgRec,
                    0,
                    0,
                    image.Width,
                    image.Height,
                    GraphicsUnit.Pixel);
                //绘制字体
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black), textRec, stringFormat);
            }
        }
    }
}
