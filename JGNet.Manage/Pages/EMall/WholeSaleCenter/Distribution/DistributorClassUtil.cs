using JGNet.Common;
using JGNet.Core.InteractEntity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JGNet.Manage.Pages
{
     class DistributorClassUtil
    {
       private static int num = 0;
        public static List<TreeNode> GetTreeNodes( out TreeNode node, string SelectItemName = "")
        {
            node = new TreeNode();
            List<TreeNode> nodes = new List<TreeNode>();
            InteractResult<List<TreeModel>> infos = null;

            TreeNode rootNode = new TreeNode("所有分销人员");
            rootNode.ImageIndex = 0;
            rootNode.Expand();
            //if (CommonGlobalCache.DistributorList == null || CommonGlobalCache.DistributorList.Count<=0)
            //{
                infos = CommonGlobalCache.ServerProxy.GetRetailDistributionTree();

                if (infos.ExeResult == ExeResult.Success)
            {
                if (infos.Data != null && infos.Data.Count > 0)
                {
                    getTreeView(rootNode, infos.Data,out node, SelectItemName);
                }
            }
            //}
            //else
            //{
            //    getTreeView(rootNode, CommonGlobalCache.DistributorList,out node,SelectItemName);
            //}
            nodes.Add(rootNode);
            //  return nodes;


            return nodes;
        }

        public static void getTreeView(TreeNode rootNode,List<TreeModel> list,out TreeNode node, string SelectItemName) {
            node = new TreeNode();
            foreach (TreeModel item in list)
            {
                TreeNode level1 = new TreeNode(item.Name +"/"+ item.ID + "(" + item.AccruedCommission + ")");

                level1.Tag = item;
                if (SelectItemName != "" && (item.Name == SelectItemName || item.ID == SelectItemName)) { node = level1; }
                if (item.Childrens != null)
                {

                    // GetChildrenTreeNodes(item.Childrens);

                    foreach (TreeModel smallClass in item.Childrens)
                    {
                        TreeNode level2 = new TreeNode(smallClass.Name + "/" + smallClass.ID + "(" + smallClass.AccruedCommission + ")");
                        // level2.ImageIndex = 2;
                        level2.Tag = smallClass;

                        if (SelectItemName != "" && (smallClass.Name == SelectItemName || smallClass.ID == SelectItemName)) { node = level2; }
                        if (smallClass.Childrens != null)
                        {
                            foreach (TreeModel subSmallClass in smallClass.Childrens)
                            {
                                TreeNode level3 = new TreeNode(subSmallClass.Name + "/" + subSmallClass.ID + "(" + subSmallClass.AccruedCommission + ")");
                                //  level3.ImageIndex = 3;
                                level3.Tag = subSmallClass;
                                if (SelectItemName != "" && (subSmallClass.Name == SelectItemName || subSmallClass.ID == SelectItemName)) { node = level3; }
                                if (subSmallClass.Childrens != null)
                                {
                                    foreach (TreeModel subClassFour in subSmallClass.Childrens)
                                    {

                                        TreeNode level4 = new TreeNode(subClassFour.Name + "/" + subClassFour.ID + "(" + subClassFour.AccruedCommission + ")");
                                        level4.Tag = subClassFour;
                                        if (SelectItemName != "" && (subClassFour.Name == SelectItemName || subClassFour.ID == SelectItemName)) { node = level4; }
                                        if (subClassFour.Childrens != null)
                                        {
                                            foreach (TreeModel subClassFive in subClassFour.Childrens)
                                            {
                                                TreeNode level5 = new TreeNode(subClassFive.Name + "/" + subClassFive.ID + "(" + subClassFive.AccruedCommission + ")");
                                                level5.Tag = subClassFive;
                                                if (SelectItemName != "" && (subClassFive.Name == SelectItemName || subClassFive.ID == SelectItemName)) { node = level5; }
                                                if (subClassFive.Childrens != null)
                                                {
                                                    foreach (TreeModel subClassSix in subClassFive.Childrens)
                                                    {
                                                        TreeNode level6 = new TreeNode(subClassSix.Name + "/" + subClassSix.ID + "(" + subClassSix.AccruedCommission + ")");
                                                        level6.Tag = subClassSix;
                                                        if (SelectItemName != "" && (subClassSix.Name == SelectItemName || subClassSix.ID == SelectItemName)) { node = level6; }
                                                        if (subClassSix.Childrens != null)
                                                        {
                                                            foreach (TreeModel subClassSeven in subClassSix.Childrens)
                                                            {
                                                                TreeNode level7 = new TreeNode(subClassSeven.Name + "/" + subClassSeven.ID + "(" + subClassSeven.AccruedCommission + ")");
                                                                level7.Tag = subClassSeven;
                                                                if (SelectItemName != "" && (subClassSeven.Name == SelectItemName || subClassSeven.ID == SelectItemName)) { node = level7; }
                                                                if (subClassSeven.Childrens != null)
                                                                {
                                                                    foreach (TreeModel subClassEight in subClassSeven.Childrens)
                                                                    {
                                                                        TreeNode level8 = new TreeNode(subClassEight.Name + "/" + subClassEight.ID + "(" + subClassEight.AccruedCommission + ")");
                                                                        level8.Tag = subClassEight;
                                                                        if (SelectItemName != "" && (subClassEight.Name == SelectItemName || subClassEight.ID == SelectItemName)) { node = level8; }
                                                                        if (subClassEight.Childrens != null)
                                                                        {
                                                                            foreach (TreeModel subClassNine in subClassEight.Childrens)
                                                                            {
                                                                                TreeNode level9 = new TreeNode(subClassNine.Name + "/" + subClassNine.ID + "(" + subClassNine.AccruedCommission + ")");
                                                                                level9.Tag = subClassNine;
                                                                                if (SelectItemName != "" && (subClassNine.Name == SelectItemName || subClassNine.ID == SelectItemName)) { node = level9; }
                                                                                if (subClassNine.Childrens != null)
                                                                                {
                                                                                    foreach (TreeModel subClassTen in subClassNine.Childrens)
                                                                                    {
                                                                                        TreeNode level10 = new TreeNode(subClassTen.Name + "/" + subClassTen.ID + "(" + subClassTen.AccruedCommission + ")");
                                                                                        level10.Tag = subClassTen;
                                                                                        if (SelectItemName != "" && (subClassTen.Name == SelectItemName || subClassTen.ID == SelectItemName)) { node = level10; }
                                                                                        foreach (TreeModel subClassEleven in subClassTen.Childrens)
                                                                                        {
                                                                                            TreeNode level11 = new TreeNode(subClassEleven.Name + "/" + subClassEleven.ID + "(" + subClassEleven.AccruedCommission + ")");
                                                                                            level11.Tag = subClassEleven;
                                                                                            if (SelectItemName != "" && (subClassEleven.Name == SelectItemName || subClassEleven.ID == SelectItemName)) { node = level11; }
                                                                                            level10.Nodes.Add(level11);
                                                                                        }
                                                                                        level9.Nodes.Add(level10);
                                                                                    }
                                                                                }
                                                                                level8.Nodes.Add(level9);
                                                                            }
                                                                        }
                                                                        level7.Nodes.Add(level8);
                                                                    }
                                                                }
                                                                level6.Nodes.Add(level7);

                                                            }
                                                        }

                                                        level5.Nodes.Add(level6);
                                                    }
                                                }

                                                level4.Nodes.Add(level5);

                                            }


                                        }
                                        level3.Nodes.Add(level4);


                                    }
                                }
                                level2.Nodes.Add(level3);

                            }
                        }
                        level1.Nodes.Add(level2);
                    }

                }
                rootNode.Nodes.Add(level1);
            }
        }
        /*  public static List<TreeNode> GetChildrenTreeNodes(List<TreeModel> SubTreeModel)
          {
              List<TreeNode> nodes = new List<TreeNode>();
              foreach (TreeModel smallClass in SubTreeModel)
              {
                  TreeNode level2 = new TreeNode(smallClass.Name);
                  level2.ImageIndex = 2;
                  level2.Tag = smallClass;
                  foreach (TreeModel subSmallClass in smallClass.Childrens)
                  {
                      TreeNode level3 = new TreeNode(subSmallClass.Name);
                      level3.ImageIndex = 3;
                      level3.Tag = subSmallClass;
                      level2.Nodes.Add(level3);
                  }

              }
              return nodes;
          }*/


        /*    public static void bindTree()
            {
                AddTree(null,null);
            }
            public static void AddTree(List<TreeModel> Parent, TreeNode treeModel ) {
                if (Parent != null)
                {
                    foreach (TreeModel subClassEleven in Parent)
                    {
                        TreeNode levelA = new TreeNode(subClassEleven.Name + "(" + subClassEleven.AccruedCommission + ")");
                        levelA.Tag = subClassEleven; 
                        AddTree(subClassEleven.Childrens,levelA);
                        treeModel.Nodes.Add(levelA);
                    }
                }
                else
                {
                    //第一次进入
                    foreach (TreeModel item in getDistriData())
                    {

                    }
                }
            }
            public static List<TreeModel> getDistriData() {


                InteractResult<List<TreeModel>> infos = CommonGlobalCache.ServerProxy.GetRetailDistributionTree();
                if (infos.ExeResult == ExeResult.Success && infos != null && infos.Data.Count > 0) {
                    return infos.Data;
                }
                return new List<TreeModel>();
            }
            */
        public static void getPFTreeView(TreeNode rootNode, List<TreeModel> list,out TreeNode node ,string SelectItemName) {
            node = new TreeNode();
            foreach (TreeModel item in list)
            {
                TreeNode level1 = new TreeNode(item.Name + "/" + item.Phone + "(" + item.AccruedCommission + ")");

                level1.Tag = item;
                if (SelectItemName != "" && (item.Name == SelectItemName || item.Phone == SelectItemName)) { node = level1; }
                if (item.Childrens != null)
                {
                    foreach (TreeModel smallClass in item.Childrens)
                    {
                        TreeNode level2 = new TreeNode(smallClass.Name + "/" + smallClass.Phone + "(" + smallClass.AccruedCommission + ")");
                        // level2.ImageIndex = 2;
                        level2.Tag = smallClass;
                        if (SelectItemName != "" && (smallClass.Name == SelectItemName || smallClass.Phone == SelectItemName)) { node = level2; }
                        if (smallClass.Childrens != null)
                        {
                            foreach (TreeModel subSmallClass in smallClass.Childrens)
                            {
                                TreeNode level3 = new TreeNode(subSmallClass.Name + "/" + subSmallClass.Phone + "(" + subSmallClass.AccruedCommission + ")");
                                //  level3.ImageIndex = 3;
                                level3.Tag = subSmallClass;
                                if (SelectItemName != "" && (subSmallClass.Name == SelectItemName || subSmallClass.Phone == SelectItemName)) { node = level3; }
                                if (subSmallClass.Childrens != null)
                                {
                                    foreach (TreeModel subClassFour in subSmallClass.Childrens)
                                    {

                                        TreeNode level4 = new TreeNode(subClassFour.Name + "/" + subClassFour.Phone + "(" + subClassFour.AccruedCommission + ")");
                                        level4.Tag = subClassFour;
                                        if (SelectItemName != "" && (subClassFour.Name == SelectItemName || subClassFour.Phone == SelectItemName)) { node = level4; }
                                        if (subClassFour.Childrens != null)
                                        {
                                            foreach (TreeModel subClassFive in subClassFour.Childrens)
                                            {
                                                TreeNode level5 = new TreeNode(subClassFive.Name + "/" + subClassFive.Phone + "(" + subClassFive.AccruedCommission + ")");
                                                level5.Tag = subClassFive;
                                                if (SelectItemName != "" && (subClassFive.Name == SelectItemName || subClassFive.Phone == SelectItemName)) { node = level5; }
                                                if (subClassFive.Childrens != null)
                                                {
                                                    foreach (TreeModel subClassSix in subClassFive.Childrens)
                                                    {
                                                        TreeNode level6 = new TreeNode(subClassSix.Name + "/" + subClassSix.Phone + "(" + subClassSix.AccruedCommission + ")");
                                                        level6.Tag = subClassSix;
                                                        if (SelectItemName != "" && (subClassSix.Name == SelectItemName || subClassSix.Phone == SelectItemName)) { node = level6; }
                                                        if (subClassSix.Childrens != null)
                                                        {
                                                            foreach (TreeModel subClassSeven in subClassSix.Childrens)
                                                            {
                                                                TreeNode level7 = new TreeNode(subClassSeven.Name + "/" + subClassSeven.Phone + "(" + subClassSeven.AccruedCommission + ")");
                                                                level7.Tag = subClassSeven;
                                                                if (SelectItemName != "" && (subClassSeven.Name == SelectItemName || subClassSeven.Phone == SelectItemName)) { node = level7; }
                                                                if (subClassSeven.Childrens != null)
                                                                {
                                                                    foreach (TreeModel subClassEight in subClassSeven.Childrens)
                                                                    {
                                                                        TreeNode level8 = new TreeNode(subClassEight.Name + "/" + subClassEight.Phone + "(" + subClassEight.AccruedCommission + ")");
                                                                        level8.Tag = subClassEight;
                                                                        if (SelectItemName != "" && (subClassEight.Name == SelectItemName || subClassEight.Phone == SelectItemName)) { node = level8; }
                                                                        if (subClassEight.Childrens != null)
                                                                        {
                                                                            foreach (TreeModel subClassNine in subClassEight.Childrens)
                                                                            {
                                                                                TreeNode level9 = new TreeNode(subClassNine.Name + "/" + subClassNine.Phone + "(" + subClassNine.AccruedCommission + ")");
                                                                                level9.Tag = subClassNine;
                                                                                if (SelectItemName != "" && (subClassNine.Name == SelectItemName || subClassNine.Phone == SelectItemName)) { node = level9; }
                                                                                if (subClassNine.Childrens != null)
                                                                                {
                                                                                    foreach (TreeModel subClassTen in subClassNine.Childrens)
                                                                                    {
                                                                                        TreeNode level10 = new TreeNode(subClassTen.Name + "/" + subClassTen.Phone + "(" + subClassTen.AccruedCommission + ")");
                                                                                        level10.Tag = subClassTen;

                                                                                        if (SelectItemName != "" && (subClassTen.Name == SelectItemName || subClassTen.Phone == SelectItemName)) { node = level10; }
                                                                                        foreach (TreeModel subClassEleven in subClassTen.Childrens)
                                                                                        {
                                                                                            TreeNode level11 = new TreeNode(subClassEleven.Name + "/" + subClassEleven.Phone + "(" + subClassEleven.AccruedCommission + ")");
                                                                                            level11.Tag = subClassEleven;

                                                                                            if (SelectItemName != "" && (subClassEleven.Name == SelectItemName || subClassEleven.Phone == SelectItemName)) { node = level11; }
                                                                                            level10.Nodes.Add(level11);
                                                                                        }
                                                                                        level9.Nodes.Add(level10);
                                                                                    }
                                                                                }
                                                                                level8.Nodes.Add(level9);
                                                                            }
                                                                        }
                                                                        level7.Nodes.Add(level8);
                                                                    }
                                                                }
                                                                level6.Nodes.Add(level7);

                                                            }
                                                        }

                                                        level5.Nodes.Add(level6);
                                                    }
                                                }

                                                level4.Nodes.Add(level5);

                                            }


                                        }
                                        level3.Nodes.Add(level4);


                                    }
                                }
                                level2.Nodes.Add(level3);

                            }
                        }
                        level1.Nodes.Add(level2);
                    }

                }
                rootNode.Nodes.Add(level1);
            }
        }
        public static List<TreeNode> GetPfTreeNodes(out TreeNode node, string SelectItemName = "")
        {
            node = new TreeNode();
            List<TreeNode> nodes = new List<TreeNode>();
            InteractResult<List<TreeModel>> infos=null;
            TreeNode rootNode = new TreeNode("所有分销客户");
            rootNode.ImageIndex = 0;
            rootNode.Expand();
            //if (CommonGlobalCache.DistributorPFList == null || CommonGlobalCache.DistributorList.Count <= 0)
            //{ 
              infos = CommonGlobalCache.ServerProxy.GetPfDistributionTree();
                if (infos.ExeResult == ExeResult.Success)
                {
                    if (infos != null && infos.Data.Count > 0)
                    {
                        getPFTreeView(rootNode,infos.Data, out node, SelectItemName);
                    }
                }
            //}
            //else
            //{
            //    getPFTreeView(rootNode, CommonGlobalCache.DistributorPFList, out node, SelectItemName);
            //}
           
         
            nodes.Add(rootNode);

            return nodes;
        }
        
    }
}
