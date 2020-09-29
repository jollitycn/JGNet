using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;

using System.Windows.Forms;
using JGNet.Core.Const;
using CCWin;
using JGNet.Core;

using CJBasic.Loggers;
using CJPlus;
using JGNet.ForManage;
using JGNet.Manage.Pages.RuleSettings;
using JGNet.Common.Core;  
using JGNet.Core.Tools;
using CCWin.SkinControl;
using JGNet.Common.Core.Util;
using System.Reflection;
using JGNet.Common.Components;
using JGNet.Manage.Components;
using System.IO;
using JGNet.Core.InteractEntity;
using QCloud.CosApi.Api;
using Newtonsoft.Json;
using JGNet.Common;
using System.Xml;
using JGNet.Common.Models;
using CJBasic.Helpers;

namespace JGNet.Manage

{


    /// <summary>
    /// 选择添加指定区域，确认后列出相同运费的区域合集，合并相同运费，为一块。编辑时候可以取消勾选确认去除不需要配置的区域，
    /// 删除
    /// </summary>

    public partial class SaveCarriageCostTemplateCtrl : BaseModifyUserControl
    {

        List<CarriageCost> list = new List<CarriageCost>();
        EmCarriageCostTemplate curTemp;
        public SaveCarriageCostTemplateCtrl(EmCarriageCostTemplate template)
        {
            InitializeComponent();
            try
            {
                new DataGridViewPagingSumCtrl(dataGridView1).Initialize();
                curTemp = template;
                Initialize();

                if (curTemp != null)
                {
                    JGNet.Core.Dev.InteractEntity.CarriageCost cost = GlobalCache.EMallServerProxy.GetCarriageCost(curTemp.AutoID);

                    this.skinComboBoxDeliveryTime.SelectedItem = cost.CarriageCostTemplate.DeliveryTime;
                    numericTextBoxDefaultCarriageCost.Value = cost.CarriageCostTemplate.DefaultCarriageCost;

                    String[] addresses = cost.CarriageCostTemplate.GoodsAddress.Split('-');
                    skinComboBoxProvince.SelectedValue = addresses[0];
                    skinComboBoxCity.SelectedValue = addresses[1];
                    skinComboBoxCityArea.SelectedValue = addresses[2];
                    skinCheckBox_State.Checked = cost.CarriageCostTemplate.IsValid;
                    skinTextBoxTitle.Text = cost.CarriageCostTemplate.Name;

                    List<CarriageCost> costs = CarriageCostUtil.GetAllCarriageCost(cost.CarriageCostDetails);
                    list = costs;
                    this.dataGridView1.DataSource = list;
                }
                else
                {
                    //设置默认的宝贝地址
                    EMall eMall = GlobalCache.EMallServerProxy.GetEMall();
                    if (eMall != null && !String.IsNullOrEmpty(eMall.ShopAddress))
                    {
                        String[] addresses = eMall.ShopAddress.Split('-');
                        skinComboBoxProvince.SelectedValue = addresses[0];
                        skinComboBoxCity.SelectedValue = addresses[1];
                        String[] detailAddress = addresses[2].Split(',');
                        skinComboBoxCityArea.SelectedValue = detailAddress[0];
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void Initialize()
        {
            try
            {
                string jsonText = File.ReadAllText(@"CitySelectForm.dat");
                resultList = (List<Zone>)JavaScriptConvert.DeserializeObject(jsonText, typeof(List<Zone>));
                List<Province> provinces = new List<Province>();
                foreach (var zone in resultList)
                {
                    provinces.AddRange(zone.Province);
                }
                skinComboBoxProvince.DisplayMember = "Name";
                skinComboBoxProvince.ValueMember = "Name";
                skinComboBoxProvince.DataSource = provinces;

                SetDeliveryTime();

            }
            catch (Exception ex)
            {
                GlobalUtil.ShowError(ex);
            }
        }

        private void skinComboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            Province p = skinComboBoxProvince.SelectedItem as Province;
            if (p == null) {
                p = skinComboBoxProvince.Items[0] as Province;
            }
            skinComboBoxCity.DisplayMember = "Name";
            skinComboBoxCity.ValueMember = "Name";
            skinComboBoxCity.DataSource = p.Sub;
            skinComboBoxCity_SelectedIndexChanged(null, null);
        }

        private void skinComboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            City p = skinComboBoxCity.SelectedItem as City;
            if (p == null)
            {
                p = skinComboBoxCity.Items[0] as City;
            }
            skinComboBoxCityArea.DisplayMember = "Name";
            skinComboBoxCityArea.ValueMember = "Name";
            skinComboBoxCityArea.DataSource = p.Sub;

        }
        private void BaseButtonSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(skinTextBoxTitle.Text))
                {
                    GlobalMessageBox.Show("请输入模板名称！");
                    skinTextBoxTitle.Focus();
                    return;
                }


                if (GlobalUtil.EngineUnconnectioned(this))
                {
                    return;
                }

                //最后记得跟resultList对比下，判断是否省份所有城市都选中了 
                Core.Dev.InteractEntity.CarriageCost para = new Core.Dev.InteractEntity.CarriageCost();
                para.CarriageCostTemplate = new EmCarriageCostTemplate()
                {
                    CreateTime = DateTime.Now,
                    DeliveryTime = (int)this.skinComboBoxDeliveryTime.SelectedValue,
                    DefaultCarriageCost = numericTextBoxDefaultCarriageCost.Value,
                    GoodsAddress = skinComboBoxProvince.SelectedValue + "-" + skinComboBoxCity.SelectedValue + "-" + skinComboBoxCityArea.SelectedValue,
                    IsValid = skinCheckBox_State.Checked,
                    LastEditTime = DateTime.Now,
                    LastOperatorUserID = GlobalCache.CurrentUserID,
                    Name = skinTextBoxTitle.Text
                };

                List<CarriageCost> costs = this.dataGridView1.DataSource as List<CarriageCost>;
                //周一实现
                para.CarriageCostDetails = CarriageCostUtil.GetEmCarriageCostDetails(costs);

                if (curTemp != null)
                {
                    para.CarriageCostTemplate.AutoID = curTemp.AutoID;
                    para.CarriageCostTemplate.CreateTime = curTemp.CreateTime;
                    foreach (var item in para.CarriageCostDetails)
                    {
                        item.TemplateID = curTemp.AutoID;
                    }

                    UpdateResult result = GlobalCache.EMallServerProxy.UpdateCarriageCost(para);
                    switch (result)
                    {
                        case UpdateResult.Success:
                            GlobalMessageBox.Show("保存成功！");
                            //TabPage_Close.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                        case UpdateResult.Error:
                            GlobalMessageBox.Show("内部错误！");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    InsertResult result = GlobalCache.EMallServerProxy.InsertCarriageCost(para);
                    switch (result)
                    {
                        case InsertResult.Success:
                            GlobalMessageBox.Show("保存成功！");
                            TabPage_Close.Invoke(this.CurrentTabPage, this.SourceCtrlType);
                            break;
                        case InsertResult.Error:
                            GlobalMessageBox.Show("内部错误！");
                            break;
                        default:
                            break;
                    }
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


        private void baseButtonAdd_Click(object sender, EventArgs e)
        {
            List<CarriageCost> costs = this.dataGridView1.DataSource as List<CarriageCost>;
            List<Zone> zones = new List<Zone>();
            if (costs != null)
            {
                foreach (CarriageCost cost in costs)
                {
                    zones.AddRange(cost.Zones);
                }
            }


            CitySelectForm form = new CitySelectForm(null);

            if (zones.Count > 0)
            {
                form.UnabledZones = zones;
            }
            form.ReturnSelected += Form_ReturnSelected;
            form.ShowDialog(this.ParentForm);
        }

        private void Form_ReturnSelected(List<Common.Models.Zone> zones, EventArgs args)
        {
            if (zones != null)
            {
                //转换成CarriageCost
                CarriageCost cost = CarriageCostUtil.ZoneToCarriageCost(zones);
                list.Add(cost);
            }
            this.dataGridView1.DataSource = null;
            if (list != null && list.Count > 0)
            {
                this.dataGridView1.DataSource = list;
            }
        }
         
        List<string> ListString = new List<string>();
        private List<Zone> resultList;//当前被绑定的源

        private void SaveCarriageCostTemplateCtrl_Load(object sender, EventArgs e)
        {
        }

        private void SetDeliveryTime()
        {
            List<int> times = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                times.Add((i + 1) * 24);
            }
            skinComboBoxDeliveryTime.DataSource = times;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                DataGridView view = sender as DataGridView;
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {

                    List<CarriageCost> smallList = (List<CarriageCost>)view.DataSource;
                    CarriageCost item = (CarriageCost)smallList[e.RowIndex];
                    switch (view.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                    {
                        case "编辑":
                            EditCarriageCost(item);
                            break;
                        case "删除":
                            if (GlobalMessageBox.Show("是否确认操作？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                            {
                                return;

                            }
                            if (GlobalUtil.EngineUnconnectioned(this))
                            {
                                return;
                            }
                            view.DataSource = null;
                            smallList.Remove(item);
                            if (smallList != null && smallList.Count > 0)
                            {
                                view.DataSource = smallList;
                            }

                            break;
                    }
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



        CarriageCost editCost = null;
        private void EditCarriageCost(CarriageCost item)
        {
            editCost = item;
            CitySelectForm form = new CitySelectForm(item.Zones);
            form.ReturnSelected += Form_EditReturnSelected;

            List<CarriageCost> costs = this.dataGridView1.DataSource as List<CarriageCost>;
            List<Zone> zones = new List<Zone>();
            if (costs != null)
            {
                foreach (CarriageCost cost in costs)
                {
                    if (cost != item)
                    {
                        zones.AddRange(cost.Zones);
                    }
                }
            }


            if (zones.Count > 0)
            {
                form.UnabledZones = zones;
            }




            form.ShowDialog(this.ParentForm);
        }



        private void Form_EditReturnSelected(List<Common.Models.Zone> zones, EventArgs args)
        {
            if (zones != null)
            {
                //转换成CarriageCost
                CarriageCost cost = CarriageCostUtil.ZoneToCarriageCost(zones);
                cost.Cost = editCost.Cost;
                int index = list.IndexOf(editCost);
                list.Remove(editCost);
                list.Insert(index, cost);
                this.dataGridView1.DataSource = null;
                if (list != null && list.Count > 0)
                {
                    this.dataGridView1.DataSource = list;
                }
                // list.Add(cost);
            }
        }
         
    }
}
