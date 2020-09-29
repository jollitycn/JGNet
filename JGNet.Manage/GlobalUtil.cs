using CCWin;
using CCWin.SkinControl;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.InteractEntity;
using JGNet.Core.Tools;
using CJBasic.Loggers;
using ESPlus.Rapid;
using System;
using System.Collections.Generic;
using System.Diagnostics;

using System.Reflection;
using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public class GlobalUtil : CommonGlobalUtil
    { 
        /// <summary>
      /// 挂单信息保存路径
      /// </summary>
        public static string HangedOrderBagPath
        {
            get
            {
                return GlobalUtil.SystemDir + "HangedOrderBag.dat";
            }
        }

        public static String GetSystemVersion()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public static void SetLogisticCompany(SkinComboBox skinTextBoxLogisticCompany)
        {
            try
            {

                //  List<CostumeClass> classes = CommonGlobalCache.CostumeClassList;
                List<EmExpressCompany> list = new List<EmExpressCompany>();

                list = GlobalCache.EMallServerProxy.GetEnabledEmExpressCompanys();
                //  list.Add(new ListItem<String>("圆通快递", "yuantong"));
                //   list.Add(new CostumeClass() { BigClass = CommonGlobalUtil.COMBOBOX_ALL });
                //   list.AddRange(classes);

                if (list != null)
                {
                    skinTextBoxLogisticCompany.DisplayMember = "ExpressCompanyName";
                    skinTextBoxLogisticCompany.ValueMember = "ExpressCompanyName";
                    skinTextBoxLogisticCompany.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }


        public static void SaveParameters(String key, String paraValue)
        {
            UpdateResult result = GlobalCache.ParameterConfig_OnChange(key, paraValue);
            switch (result)
            {
                case UpdateResult.Success:

                    //重新加载系统配置信息
                    break;
                case UpdateResult.Error:
                    //GlobalMessageBox.Show("内部错误！");
                    throw new Exception("内部错误！");
                    break;
                default:
                    break;
            }
        }



        public static string GetExpressCode(Control ctrl, string expressCompany)
        {
            String expressCode = string.Empty;
          
                List<EmExpressCompany> list = new List<EmExpressCompany>();
                list = GlobalCache.EMallServerProxy.GetEnabledEmExpressCompanys();

            if (list != null)
            {
                foreach (var item in list)
                {
                    if (item.ExpressCompanyName == expressCompany)
                    {

                        expressCode = item.ExpressCompanyID;
                    }

                }
            }
            return expressCode;
        }
         

        public static void AddSupplier(Control ctrl, SkinComboBox skinComboBox)
        {

            List<Supplier> list = (List<Supplier>)skinComboBox.DataSource;
            NewSupplierComboBoxForm addForm = new NewSupplierComboBoxForm(list);
            if (addForm.ShowDialog(ctrl) == DialogResult.OK)
            {
                if (list == null) { list = new List<Supplier>(); }
                Supplier item = addForm.Result;
                Supplier listItem = list.Find(t => t.Name == item.Name || t.ID == item.ID);
                if (listItem == null)
                {
                    item.Enabled = true;
                    item.CreateTime = DateTime.Now;
                    InteractResult result = GlobalCache.SupplierList_OnChange(item);
                    switch (result.ExeResult)
                    {
                        case ExeResult.Success:
                            skinComboBox.DataSource = null;
                            list.Add(item);
                            skinComboBox.DisplayMember = "Name";
                            skinComboBox.ValueMember = "ID";
                            skinComboBox.DataSource = list;
                            skinComboBox.SelectedIndex = list.IndexOf(item);
                            break;
                        case ExeResult.Error:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    // this.skinComboBox_SupplierID.SelectedItem = listItem;
                }

            }
        }
    }
}
