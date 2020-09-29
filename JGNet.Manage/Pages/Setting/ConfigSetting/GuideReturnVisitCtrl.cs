using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core;
using JGNet.ForManage;
using CCWin;
using System.Reflection;
using JGNet.Common.Core;  
using JGNet.Common.Components;
using JGNet.Core.InteractEntity;
using JGNet.Common;

namespace JGNet.Manage.Pages.BasicSettings.Costume
{
    public partial class GuideReturnVisitCtrl : BaseUserControl
    {
        private List<GuideReturnVisit> list = new List<GuideReturnVisit>();
        public GuideReturnVisitCtrl()
        {
            InitializeComponent();
            new DataGridViewPagingSumCtrl(this.dataGridView1).Initialize();

        }

        private void UpdateData()
        {
            GuideReturnVisitPara config = SetUpConfig();
            UpdateResult result = GlobalCache.ServerProxy.UpdateGuideReturnVisitPara(config);
            switch (result)
            {
                case UpdateResult.Success:

                    GlobalMessageBox.Show("保存成功！");
                    break;
                case UpdateResult.Error:
                    GlobalMessageBox.Show("内部错误！");
                    break;
                default:
                    //this.dataGridView1.DataSource = list;
                    break;
            }
        }

        private GuideReturnVisitPara SetUpConfig()
        {
            GuideReturnVisitPara config = new GuideReturnVisitPara();

            return config;
        }

        private void CostumeSeasonCtrl_Load(object sender, EventArgs e)
        {
            Initialize();
        }
        private void Initialize()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = null;

            LoadConfig();
            list.Add(new GuideReturnVisit()
            {
                ConfigName = "销售回访",
                Setting = visitPara.Retail,
                Remark = "售后回访天数"
            }); list.Add(new GuideReturnVisit()
            {
                ConfigName = "生日提前提醒天数",
                Setting = visitPara.BirthdayAdvanceRemind,
                Remark = "生日提前提醒天数"
            }); list.Add(new GuideReturnVisit()
            {
                ConfigName = "活跃客户消费天数",
                Setting = visitPara.ActiveMember,
                Remark = "90天为默认值，超过90天自动变成休眠客户"
            });
            list.Add(new GuideReturnVisit()
            {
                ConfigName = "纪念日提前提醒天数",
                Setting = visitPara.AnniversaryAdvanceRemind,
                Remark = "纪念日提前提醒天数"
            }); list.Add(new GuideReturnVisit()
            {
                ConfigName = "流失客户消费天数",
                Setting = visitPara.LossMember,
                Remark = "180天为默认值，如需变动，请输入具体数字"
            });
            this.dataGridView1.DataSource = list;
        }
        GuideReturnVisitPara visitPara = null;

        private void LoadConfig()
        {



            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                visitPara = GlobalCache.ServerProxy.GetGuideReturnVisitPara();

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
        private void SaveConfig()
        {
            try
            {
                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                UpdateResult result = GlobalCache.ServerProxy.UpdateGuideReturnVisitPara(visitPara);
                switch (result)
                {
                    case UpdateResult.Success:
                        GlobalMessageBox.Show("保存成功！");
                        break;
                    case UpdateResult.Error:
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

        private void BaseButton3_Click(object sender, EventArgs e)
        {
            visitPara.Retail = this.list[0].Setting;
            visitPara.BirthdayAdvanceRemind = this.list[1].Setting;
            visitPara.ActiveMember = this.list[2].Setting;
            visitPara.AnniversaryAdvanceRemind = this.list[3].Setting;
            visitPara.LossMember = this.list[4].Setting;
            SaveConfig();
        }
    }
}
