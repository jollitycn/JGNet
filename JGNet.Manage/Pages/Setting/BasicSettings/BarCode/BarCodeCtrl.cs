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
using JGNet.Core.Const;
using DataRabbit.DBAccessing;

namespace JGNet.Manage.Pages
{
    public partial class BarCodeCtrl : BaseUserControl
    {
        public BarCodeCtrl()
        {
            InitializeComponent();
        }
        //  public Action<bool> CheckChanged;
        public void BaseButtonSave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (CommonGlobalUtil.EngineUnconnectioned(this))
            //    {
            //        return;
            //    }

            String templateStr = CheckSetting();
            //if (CommonGlobalCache.BarCodeTemplate != templateStr)
            //{

            //    //确定了则清空
            //    //DeleteResult result = GlobalCache.ServerProxy.DeleteAllBarCode();
            //    //switch (result)
            //    //{
            //    //    case DeleteResult.Success:
            //    //        break;
            //    //    case DeleteResult.Error:
            //    //        GlobalMessageBox.Show("内部错误！");
            //    //        break;
            //    //    default:
            //    //        break;
            //    //}
            //}



            SaveParameters(ParameterConfigKey.BarCodeTemplate, templateStr);
            //  GlobalMessageBox.Show("保存成功！");
            CommonGlobalCache.ReInitConfig(new String[] {
                    ParameterConfigKey.BarCodeTemplate
                }
            );
            //}
            //catch (Exception ee)
            //{
            //    CommonGlobalUtil.ShowError(ee);
            //}
            //finally
            //{
            //    CommonGlobalUtil.UnLockPage(this);
            //}
        }

        private String CheckSetting()
        {
            //BarCodeTemplateEnum key = BarCodeTemplateEnum.CostumeID;

            //if (skinCheckBoxCostume.Checked && this.skinCheckBoxColor.Checked && skinCheckBoxSize.Checked)
            //{
            //    key = BarCodeTemplateEnum.CostumeIDColorNameSizeName;
            //}
            //else if (skinCheckBoxCostume.Checked && this.skinCheckBoxColor.Checked)
            //{
            //    key = BarCodeTemplateEnum.CostumeIDColorName;
            //}

            String templateStr = string.Empty;
            List<String> items = new List<string>();
            foreach (var item in this.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox box = item as CheckBox;
                    if (box.Checked)
                    {
                        items.Add(box.Tag.ToString());
                    }
                }
            }

            templateStr = JGNet.Server.Tools.DataHelper.ListToString(items);
            return templateStr;
        }

        private void SaveParameters(String key, String paraValue)
        {
            UpdateResult result = GlobalCache.ParameterConfig_OnChange(key, paraValue);
            switch (result)
            {
                case UpdateResult.Success:
                    //重新加载系统配置信息
                    break;
                case UpdateResult.Error:
                    throw new Exception("内部错误！");
                    //break;
                default:
                    break;
            }
        }

        private void OptionCtrl_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        public void LoadConfig()
        {
            String barCodeTemplate = CommonGlobalCache.GetParameter(ParameterConfigKey.BarCodeTemplate)?.ParaValue;
            List<String> list = JGNet.Server.Tools.DataHelper.StringToList(barCodeTemplate);
            foreach (var item in this.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox box = item as CheckBox;
                    box.Checked = false;
                    if (list.Contains(box.Tag.ToString()))
                    {
                        box.Checked = true;
                    } 
                }
            }
        }
    }
}
