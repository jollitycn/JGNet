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
using JGNet.Common.Core.Util;
using JGNet.Core.InteractEntity;
using System.IO;
using JGNet.Core.Const;
using JGNet.Common.Components;

namespace JGNet.Manage.Pages
{
    public partial class OptionCtrl : BaseUserControl
    {
        DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        public OptionCtrl()
        {
            InitializeComponent();
             MenuPermission= RolePermissionMenuEnum.系统设置;

        }

        private void LoadGuideReturnVisitConfig()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                visitPara = GlobalCache.ServerProxy.GetGuideReturnVisitPara();
                numericUpDownRetail.Value = visitPara.Retail;
                numericUpDownBirthdayAdvanceRemind.Value = visitPara.BirthdayAdvanceRemind;
                numericUpDownAnniversaryAdvanceRemind.Value = visitPara.AnniversaryAdvanceRemind;
                numericUpDownActiveMember.Value = visitPara.ActiveMember;
                numericUpDownLossMember.Value = visitPara.LossMember;
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }

        GuideReturnVisitPara visitPara = null;

        private void UploadPhoto()
        {
            //有切换图片//原来有图片被删除了，才更新图片,与该image无关
            if (photo != null)
            {
                UpdateEMallPhotoPara para = new UpdateEMallPhotoPara()
                {
                    BusinessAccountID = GlobalCache.BusinessAccount.ID,
                    //从picbox获取bytes
                    Logo = GetPhoto()
                };
                GlobalCache.EMallServerProxy.UpdateEMallMiniProgramImg(para);
            }
        }

        private byte[] GetPhoto()
        {

            byte[] photo = null;
            Image image = this.pictureBox1.Image;
            if (image != null)
            {
                MemoryStream stream = new MemoryStream();
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                photo = stream.ToArray();

            }
            return photo;
        }


        public InteractResult BaseButtonSave_Click(object sender, EventArgs e)
        {
            InteractResult allResults = new InteractResult();
            try
            { 
                //客户回访设置
                visitPara.Retail = decimal.ToInt32(numericUpDownRetail.Value);
                visitPara.BirthdayAdvanceRemind = decimal.ToInt32(numericUpDownBirthdayAdvanceRemind.Value);
                visitPara.AnniversaryAdvanceRemind = decimal.ToInt32(numericUpDownAnniversaryAdvanceRemind.Value);
                visitPara.ActiveMember = decimal.ToInt32(numericUpDownActiveMember.Value);
                visitPara.LossMember = decimal.ToInt32(numericUpDownLossMember.Value);
                UpdateResult result = GlobalCache.ServerProxy.UpdateGuideReturnVisitPara(visitPara);
                switch (result)
                {
                    case UpdateResult.Success:
                        allResults.ExeResult = ExeResult.Success;
                        // GlobalMessageBox.Show("保存成功！");
                        break;
                    case UpdateResult.Error:
                        allResults.ExeResult = ExeResult.Error;
                        allResults.Msg = "内部错误！";

                        //GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                };

                if (allResults.ExeResult == ExeResult.Error)
                {
                    return allResults;
                }



                //  SetConfig(OptionConfiguration.OPTION_CONFIGURATION_KEY_BALANCE_ROUND, skinCheckBoxBalanceRound.Checked.ToString());
                SetConfig(OptionConfiguration.OPTION_CONFIGURATION_KEY_REPORT_SHOW_ZERO, skinCheckBoxReportShowZero.Checked.ToString());
               // SetConfig(OptionConfiguration.OPTION_CONFIGURATION_KEY_DIFFERENT_IN_CHECKSTORE, skinCheckBoxShowDifferentInCheckStore.Checked.ToString());

                
                config.Save();
                String paraValue = this.skinCheckBoxX_SeeMyself.Checked ? "1" : "0";
                GlobalUtil.SaveParameters(ParameterConfigKey.X_SeeMyself, paraValue);
                GlobalUtil.SaveParameters(ParameterConfigKey.RetailBalanceRound, this.skinCheckBoxBalanceRound.Checked ? "1" : "0");
                GlobalUtil.SaveParameters(ParameterConfigKey.AllocateInDirectly, skinCheckBoxAllocateInboundDirectly.Checked ? "1" : "0");

                paraValue = this.skinCheckBoxOutNotZeroStore.Checked ? "1" : "0";
                GlobalUtil.SaveParameters(ParameterConfigKey.LimitCostumeStore, paraValue);
                GlobalUtil.SaveParameters(ParameterConfigKey.LockSalePriceForSale, this.skinCheckBoxLockSalePriceForSaling.Checked ? "1" : "0");
                
              //  GlobalUtil.SaveParameters(ParameterConfigKey.SeeOwnShopMember, this.skinCheckBoxSeeOwnShopMember.Checked ? "1" : "0");
              //   GlobalUtil.SaveParameters(ParameterConfigKey.NotShowBrand, this.skinCheckBoxNotShowBrand.Checked ? "1" : "0");
                GlobalUtil.SaveParameters(ParameterConfigKey.AutoCostPrice, this.skinCheckBoxAutoCostPrice.Checked ? "1" : "0");
                GlobalUtil.SaveParameters(ParameterConfigKey.PfPriceRound, this.skinCheckBoxGetRound.Checked ? "1" : "0");
              //  GlobalUtil.SaveParameters(ParameterConfigKey.PrintCount,this.numericUpDownPrintCount.Text);

                //GlobalMessageBox.Show("保存成功！");
                CommonGlobalCache.ReInitConfig(new String[] {
                    ParameterConfigKey.X_SeeMyself,
                    ParameterConfigKey.ShowSizeName,
                    ParameterConfigKey.AutoCostPrice,
                    ParameterConfigKey.NotShowBrand,
                     ParameterConfigKey.RetailBalanceRound,
                  //  ParameterConfigKey.SeeOwnShopMember,
                   ParameterConfigKey.LimitCostumeStore,
                   ParameterConfigKey.LockSalePriceForSale,
                   ParameterConfigKey.DefaultSizeGroup,
                    ParameterConfigKey.PrintCount,
                   ParameterConfigKey.AllocateInDirectly,
                    ParameterConfigKey.PfPriceRound
                }
                );

                if (allResults.ExeResult == ExeResult.Error)
                {
                    return allResults;
                }


                if (CommonGlobalCache.BusinessAccount.OnlineEnabled)
                {
                    UploadPhoto();
                }

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
            catch (Exception ex)
            {
                allResults.ExeResult = ExeResult.Error;
                allResults.Msg = ex.Message;
            }

            return allResults;
        }

        private void SetConfig(String optionKey, String value)
        {
            Option keyValue = config?.Options?.Find(t => t.Key == optionKey);
            if (keyValue != null)
            {
                keyValue.Value = value;
            }
            else
            {
                keyValue = new Option(optionKey, value);
                if (config.Options == null)
                {
                    config.Options = new List<Option>();
                }
                config.Options.Add(keyValue);
            }
        }

        OptionConfiguration config = null;
        private void OptionCtrl_Load(object sender, EventArgs e)
        {
        }

        public void Init()
        {
            LoadLocalConfig();
            LoadConfig();
            LoadGuideReturnVisitConfig(); 
            if (CommonGlobalCache.BusinessAccount.OnlineEnabled)
            {
                LoadEmallPhoto();
            }
            else
            {
                this.panelPhoto.Visible = false;
            }
        }

        private void LoadEmallPhoto()
        {
            byte[] imageByte = GlobalCache.ServerProxy.GetEMallMiniProgramImg();
            this.pictureBox1.Image = imageByte == null ? null : CCWin.SkinControl.ImageHelper.Convert(imageByte);
        }

        private void LoadConfig()
        {
            skinCheckBoxX_SeeMyself.Checked = GlobalCache.GuideSeeMyself == "1";
            skinCheckBoxOutNotZeroStore.Checked = GlobalCache.LimitCostumeStore == "1";
            skinCheckBoxLockSalePriceForSaling.Checked = GlobalCache.GetParameter(ParameterConfigKey.LockSalePriceForSale).ParaValue == "1"; 
            skinCheckBoxAllocateInboundDirectly.Checked = GlobalCache.GetParameter(ParameterConfigKey.AllocateInDirectly).ParaValue == "1";

            skinCheckBoxGetRound.Checked = GlobalCache.GetParameter(ParameterConfigKey.PfPriceRound).ParaValue == "1";
            //  skinCheckBoxSeeOwnShopMember.Checked = GlobalCache.SeeOwnShopMember == "1";
            //  skinCheckBoxNotShowBrand.Checked = GlobalCache.GetParameter(ParameterConfigKey.NotShowBrand).ParaValue == "1";
            skinCheckBoxAutoCostPrice.Checked = GlobalCache.GetParameter(ParameterConfigKey.AutoCostPrice).ParaValue == "1";
            skinCheckBoxBalanceRound.Checked = GlobalCache.GetParameter(ParameterConfigKey.RetailBalanceRound).ParaValue == "1";
          //  skinCheckBoxBalanceRound.Checked = GlobalCache.GetParameter(ParameterConfigKey.RetailBalanceRound).ParaValue == "1";
            // numericUpDownPrintCount.Text= GlobalCache.GetParameter(ParameterConfigKey.PrintCount).ParaValue;

        }

        private void LoadLocalConfig()
        {
            try
            {
                config = OptionConfiguration.Load(OptionConfiguration.GetConfigPath()) as OptionConfiguration;
            }
            catch (Exception ex)
            {
                GlobalUtil.WriteLog(ex);
            }
            if (config != null)
            {
                foreach (var item in config.Options)
                {
                    switch (item.Key)
                    {
                        case OptionConfiguration.OPTION_CONFIGURATION_KEY_REPORT_SHOW_ZERO:
                            skinCheckBoxReportShowZero.Checked = bool.Parse(item.Value);
                            break;
                        //case OptionConfiguration.OPTION_CONFIGURATION_KEY_BALANCE_ROUND:
                        //    skinCheckBoxBalanceRound.Checked = bool.Parse(item.Value);
                        //    break;

                        case OptionConfiguration.OPTION_CONFIGURATION_KEY_DIFFERENT_IN_CHECKSTORE:
                           // skinCheckBoxShowDifferentInCheckStore.Checked = bool.Parse(item.Value);
                            break;
                        case ParameterConfigKey.AutoCostPrice:
                            skinCheckBoxAutoCostPrice.Checked = bool.Parse(item.Value);
                            break;
                        default:
                            break;
                    }
                }
                //
            }
            else
            {
                config = new OptionConfiguration();
                config.Options = new List<Option>();
            }
        }

        private Byte[] photo { get; set; }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = CJBasic.Helpers.FileHelper.GetFileToOpen2("请选择要上传的图片", "提示", ".jpg", ".png", "jpeg", ".bmp");
                if (String.IsNullOrEmpty(path))
                {
                    photo = null;
                    return;
                }

                if (GlobalUtil.EngineUnconnectioned(this)) { return; }
                Image img = Image.FromFile(path);
                MemoryStream stream = new MemoryStream();
                Image map = JGNet.Core.ImageHelper.GetNewSizeImage(img, 128);
                map.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                photo = stream.ToArray();
                if (photo.Length > 1048576)
                {
                    GlobalMessageBox.Show("图片不能超过1M");
                    return;
                }
                // 2097152

                this.pictureBox1.Image = map;
                //  stream = new MemoryStream();
                //  map.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                //  photo = stream.ToArray();
                // this.pictureBox1.Image = map;
                //Image img2 = Image.FromStream(stream);
            }
            catch (Exception ex) { GlobalUtil.ShowError(ex); }
            finally
            {
                GlobalUtil.UnLockPage(this);
            }
        }
          
    }
}
