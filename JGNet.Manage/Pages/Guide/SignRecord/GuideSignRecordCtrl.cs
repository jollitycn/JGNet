using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Common.Core;  
using CCWin.SkinControl;
using JGNet.Common.Core.Util;
using CCWin;
using System.Globalization;
using JGNet.Common;
using JGNet.Manage;
using JGNet.Core.InteractEntity;

namespace JGNet.Manage.Pages
{
    public partial class GuideSignRecordCtrl : BaseModifyUserControl
    {
        List<SkinRadioButton> radios = new List<SkinRadioButton>();
        
        /// <summary>
        /// 选中的参考时间
        /// </summary>
        private DateTime reFerTime;

        public GuideSignRecordCtrl()
        {
            InitializeComponent();
            MenuPermission=RolePermissionMenuEnum.考勤签到;
        }

        private void GuideSignRecordCtrl_Load(object sender, EventArgs e)
        {
            this.Initialize();

        }

        private void Initialize()
        {
            this.skinLabel_time.Text = DateTime.Now.ToString(DateTimeUtil.FULL_DATETIME_FORMAT);
            this.skinRadioButton1.Checked = false;
            this.skinRadioButton1.Checked = true;
            this.skinLabel_Shop.Text = GlobalCache.CurrentShop.Name;
            this.guideComboBox1.Initialize(Common.GuideComboBoxInitializeType.Normal, GlobalCache.CurrentShopID);
            if (CommonGlobalCache.CurrentUser.Type == UserInfoType.Guide)
            {
                this.guideComboBox1.SelectedValue = GlobalCache.CurrentUserID;
            }
            LoadSignType();
            this.timer1.Enabled = true;
        }

        private void LoadSignType()
        {
            //String[] signType = new String[]
            //    {"早班上班","早班下班","晚班上班","晚班下班"};
            radios = new List<SkinRadioButton>();
            //for (int i = 0; i < signType.Length; i++)
            //{
            //    SkinRadioButton radio = new SkinRadioButton();
            //    radio.Name = "signType" + i;
            //    radio.Text = signType[i];
            //    radio.Font = skinLabel_Shop.Font;
            //    radios.Add(radio);
            //}
            radios.Add(skinRadioButton1);
            radios.Add(skinRadioButton2);
            radios.Add(skinRadioButton3);
            radios.Add(skinRadioButton4);
            radios[0].Checked = true;

            skinFlowLayoutPanel_signType.Controls.AddRange(radios.ToArray());
        }

        private void BaseButton_sign_Click(object sender, EventArgs e)
        {
            try
            {

                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                JGNet.SignRecord para = new JGNet.SignRecord()
                {
                    GuideID = ValidateUtil.CheckEmptyValue(this.guideComboBox1.SelectedValue),
                    ShopID = GlobalCache.CurrentShopID,
                    Photo = null,
                    SignedTime = DateTime.Now,
                    ReferTime = this.reFerTime,
                    SignType = GetSignTypeValue(),
                   // AbsentMinutes = (int)Math.Round(DateTimeHelper.CompareMinutes(DateTime.Now, reFerTime))
                     
                };
                para.AbsentMinutes = (int)Math.Round(DateTimeUtil.CompareMinutes(DateTime.Now, reFerTime));
                switch (para.SignType)
                {
                    case 0:
                    case 2:
                        //上班,正值表示早到
                        para.AbsentMinutes = para.AbsentMinutes > 0 ? 0 : Math.Abs(para.AbsentMinutes);

                        break;
                    case 1:
                    case 3:
                        //下班,正值表示早退
                        para.AbsentMinutes = para.AbsentMinutes > 0 ? para.AbsentMinutes : 0;
                        break;
                }


                SignResult result = GlobalCache.ServerProxy.Sign(para);
                switch (result)
                {
                    case SignResult.Success:
                        GlobalMessageBox.Show("签到成功！");
                        break;
                    case SignResult.IsSign:
                        GlobalMessageBox.Show("重复签到！");
                        break;
                    case SignResult.Error:
                        GlobalMessageBox.Show("内部错误！");
                        break;
                    default:
                        break;
                }
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

        private byte GetSignTypeValue()
        {
            byte value = 0;
            for (int i = 0; i < radios.Count; i++)
            {
                if (radios[i].Checked)
                {
                    value = (byte)i;
                    break;
                }
            }
            return value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                this.skinLabel_time.Text = DateTime.Now.ToString(DateTimeUtil.FULL_DATETIME_FORMAT);
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo
                {
                    ShortDatePattern = DateTimeUtil.FULL_DATETIME_FORMAT
                };

                 reFerTime = Convert.ToDateTime(skinLabel_settingTime.Text, dtFormat);

                DateTime time = Convert.ToDateTime(skinLabel_time.Text, dtFormat);


                //要区分上班、下班时间
                switch (GetSignTypeValue())
                {
                    case 0:
                    case 2:
                        //上班,正值表示早到 
                        if (time.CompareTo(reFerTime) < 0)
                        {
                            skinLabel_time.ForeColor = Color.Green;
                        }
                        else
                        {
                            skinLabel_time.ForeColor = Color.Red;
                        }
                        break;
                    case 1:
                    case 3:
                        //下班,正值表示早退
                        if (time.CompareTo(reFerTime) > 0)
                        {
                            skinLabel_time.ForeColor = Color.Green;
                        }
                        else
                        {
                            skinLabel_time.ForeColor = Color.Red;
                        }
                        break;
                } 
              
            }
            catch (Exception ex) {
                timer1.Enabled = false;
                GlobalUtil.ShowError(ex);
            }
        }

        private void skinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            String time = null;
            if (skinRadioButton1.Checked)
            {
                time = GlobalCache.CurrentShop.ForeShiftStartTime;
            }
            else if (skinRadioButton2.Checked)
            {
                time = GlobalCache.CurrentShop.ForeShiftEndTime;
            }
            else if (skinRadioButton3.Checked)
            {
                time = GlobalCache.CurrentShop.NightShiftStartTime;
            }
            else
            {
                time = GlobalCache.CurrentShop.NightShiftEndTime;
            }
            skinLabel_settingTime.Text = DateTime.Now.ToString(DateTimeUtil.DEFAULT_DATE_FORMAT)+ " " + time + ":00";
           
        }
         
    }
}
