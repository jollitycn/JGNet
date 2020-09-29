
using CCWin;
using JGNet.Common;
using JGNet.Common.Components;
using JGNet.Common.Core;
using JGNet.Common.Core.Util;
using JGNet.Core;
using JGNet.Core.Const;
using JGNet.Core.InteractEntity;
using JGNet.Manage;
using JGNet.Manage;
using JGNet.Manage.Models;
using CJBasic.Loggers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace JGNet.Manage
{
    public partial class GiftTicketRichForm : BaseForm
    {

        public event CJBasic.Action<string, EventArgs> TicketChanged;
        public event CJBasic.Action<GiftTicket, EventArgs> ItemSelected;
        private List<GiftTicket> ValidatedTickets;
        private List<GiftTicket> GiftTicketList;
        private List<RetailDetail> MatchRetails;
        private List<RetailDetail> AllRetailDetailList;
        private DataGridViewPagingSumCtrl dataGridViewPagingSumCtrl;
        private List<GiftTicketMatch> matches;
        private decimal OrderSumMoney;

        public GiftTicketRichForm(List<GiftTicket> validatedTickets,
            List<RetailDetail> allRetailDetailList,
           GiftTicketMatch[] matchesArr,decimal totalMoney)
        {
            InitializeComponent();
            dataGridViewPagingSumCtrl = new DataGridViewPagingSumCtrl(dataGridView1);
            dataGridViewPagingSumCtrl.Initialize();
            OrderSumMoney = totalMoney;


            if (matchesArr != null) { 
            this.matches = new List<GiftTicketMatch>(matchesArr);
            }
            ValidatedTickets = validatedTickets;
            AllRetailDetailList = allRetailDetailList;
            Initialize();

        }

    private void Initialize()
    {
        try
        {
            if (ValidatedTickets != null && ValidatedTickets.Count > 0)
            {
                this.GiftTicketList = new List<GiftTicket>();
                this.MatchRetails = new List<RetailDetail>();
                    /* if (matches != null)
                     {
                         foreach (var item in matches)
                         {
                             if (item.Ticket == null) {
                                // GiftTicketList.Add(new GiftTicket() {
                                 //    CostumeID = item.Retail.CostumeID, EffectDate = SystemDefault.DateTimeNull, ExpiredDate = SystemDefault.DateTimeNull
                               //  });
                             }
                             else { 
                                 GiftTicketList.Add(item.Ticket);
                         }
                             MatchRetails.Add(item.Retail);


                             //this.MatchRetails = matchRetails;
                         }
                     }*/
                    if (CommonGlobalCache.CostumeGiftTicketInfo != null)
                    {
                        if (CommonGlobalCache.CostumeGiftTicketInfo.IsUse)
                        {

                            foreach (GiftTicket giftItem in ValidatedTickets)
                            {
                                foreach (RetailDetail detail in AllRetailDetailList)
                                {
                                    //if (CommonGlobalCache.CostumeGiftTicketInfo.CostumeIDs.Exists(t => t.ToUpper() == detail.CostumeID.ToUpper()))
                                    //{
                                    bool isCanUseTicket = detail.CanUseTickets;
                                    if (DateTime.Now >= giftItem.EffectDate && giftItem.ExpiredDate >= DateTime.Now)
                                    { //满足条件

                                        if (giftItem.IsAnd)
                                        {
                                            //if (item.Discount >= ticket.MinDiscount 
                                            //     && ticket.MinDiscount!=0 &&  
                                            //     ticket.MinMoney != 0 
                                            //    && item.SumMoney / item.BuyCount >= ticket.MinMoney)

                                            if (detail.Discount >= giftItem.MinDiscount
                                      &&
                                      giftItem.MinMoney != 0 && !detail.IsBuyout
                                     && OrderSumMoney >= Convert.ToDecimal(giftItem.MinMoney))
                                            {
                                                GiftTicketList.Add(giftItem);
                                                //满足折扣
                                                // item.MatchGiftTickets += ticket.ID + ",";
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            if ((detail.Discount >= giftItem.MinDiscount && detail.IsBuyout)

                                  || (!detail.IsBuyout && OrderSumMoney >= Convert.ToDecimal(giftItem.MinMoney)))
                                            {
                                                GiftTicketList.Add(giftItem);
                                                //满足折扣
                                                // item.MatchGiftTickets += ticket.ID + ",";
                                                break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            //优惠价设置了不参与优惠券商品
                            foreach (GiftTicket giftItem in ValidatedTickets)
                            {
                            decimal totalMoney = OrderSumMoney;
                                foreach (RetailDetail detail in AllRetailDetailList)
                                {
                                    String cId = CommonGlobalCache.CostumeGiftTicketInfo.CostumeIDs.Find(t => t == detail.CostumeID);
                                    if (String.IsNullOrEmpty(cId))
                                    {

                                        bool isCanUseTicket = detail.CanUseTickets;
                                        if (DateTime.Now >= giftItem.EffectDate && giftItem.ExpiredDate >= DateTime.Now)
                                        { //满足条件

                                            if (giftItem.IsAnd)
                                            {
                                                //if (item.Discount >= ticket.MinDiscount 
                                                //     && ticket.MinDiscount!=0 &&  
                                                //     ticket.MinMoney != 0 
                                                //    && item.SumMoney / item.BuyCount >= ticket.MinMoney)

                                                if (detail.Discount >= giftItem.MinDiscount
                                          &&
                                          giftItem.MinMoney != 0 && !detail.IsBuyout
                                         && totalMoney >= Convert.ToDecimal(giftItem.MinMoney))
                                                {
                                                    GiftTicketList.Add(giftItem);
                                                    //满足折扣
                                                    // item.MatchGiftTickets += ticket.ID + ",";
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                if ((detail.Discount >= giftItem.MinDiscount && detail.IsBuyout)

                                      || (!detail.IsBuyout && totalMoney >= Convert.ToDecimal(giftItem.MinMoney)))
                                                {
                                                    GiftTicketList.Add(giftItem);
                                                    //满足折扣
                                                    // item.MatchGiftTickets += ticket.ID + ",";
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        totalMoney =totalMoney- detail.SumMoney;
                                    }
                                }
                            }
                        }
                    }
                effectDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
                expiredDateDataGridViewTextBoxColumn.DefaultCellStyle.Format = DateTimeUtil.DEFAULT_DATE_FORMAT;
                this.BindingDataSource();
            }
        }
        catch (Exception ee)
        {
            GlobalUtil.ShowError(ee);
        }
    }

        //绑定数据源
        private void BindingDataSource()
        {
            try
            {
                this.dataGridView1.DataSource = null;
                List<GiftTicket> temp = new List<GiftTicket>();
                int tempDenomination = 0;
                if (this.GiftTicketList != null && this.GiftTicketList.Count != 0)
                {
                    //根据面额大小择优排序
                    for (int i = 0; i < GiftTicketList.Count - 1; ++i)
                    {
                        tempDenomination = i;
                        for (int j = i + 1; j < GiftTicketList.Count; ++j)
                        {
                            if (GiftTicketList[j].Denomination > GiftTicketList[tempDenomination].Denomination)
                                tempDenomination = j;
                        }
                        GiftTicket t = GiftTicketList[tempDenomination];
                        GiftTicketList[tempDenomination] = GiftTicketList[i];
                        GiftTicketList[i] = t;
                        // Console.WriteLine("{0}",list[i]);
                    }

                    temp.AddRange(GiftTicketList);
                }
                //foreach (var item in AllRetailDetailList)
                //{
                //    if (!MatchRetails.Contains(item))
                //    {
                //        temp.Add(new GiftTicket() { CostumeID = item.CostumeID, EffectDate = SystemDefault.DateTimeNull, ExpiredDate = SystemDefault.DateTimeNull });
                //    }
                //}
                this.dataGridView1.DataSource = temp;
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }

        }
        private void ConfirmSelectCell(GiftTicket ticket)
        {
            if (this.ItemSelected != null)
            {
                this.ItemSelected(ticket, null);
            }
            this.DialogResult = DialogResult.OK;
        }
        //点击确认按钮
        private void BaseButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridView1.DataSource == null)
                {
                    return;
                }
                if (dataGridView1.Rows.Count > 0)
                {
                    int index = this.dataGridView1.SelectedCells[0].RowIndex;
                    this.ConfirmSelectCell(this.GiftTicketList[index]);
                }
                    this.DialogResult = DialogResult.OK;
              
            }
            catch (Exception ee)
            {
                CommonGlobalUtil.ShowError(ee);
            }
        }

        //点击取消按钮
        private void BaseButton_Quit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              if (!DataGridViewUtil.CheckPerrmisson(this, sender, e)) { return; } 
            try
            {
                // MessageBox.Show(string.Format("当前点中的是第{0}列，第{1}行", e.ColumnIndex, e.RowIndex));
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                List<GiftTicket> memberList = (List<GiftTicket>)this.dataGridView1.DataSource;
                    GiftTicket gifTicket = memberList[e.RowIndex];

                //switch (this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                //{
                //    case "选择优惠券":
                //        if (!String.IsNullOrEmpty(memberList[e.RowIndex].ID))
                //        {
                //            ChooseGiftTicket(e.RowIndex);
                //        }
                //        break;
                //    default:
                //        break;
                //}
                }
        }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
}

        //  private String costumeID = string.Empty;
        GiftTicketMatch match;
        private int index = -1;
        private void ChooseGiftTicket(int index)
        {
            try
            {
                //  costumeID = ticket.CostumeID;
                this.match = matches[index];
                this.index = index;
                List<GiftTicket> canChooseTickets = new List<GiftTicket>();


                foreach (var item in ValidatedTickets)
                {
                    //匹配条件才能添加
                    String[] retailMatchTickets = MatchRetails[index].MatchGiftTickets.Split(',');
                    List<String> retailMatchTicketList = new List<string>(retailMatchTickets);


                    if (!GiftTicketList.Exists(t => t.ID == item.ID) && retailMatchTicketList.Contains(item.ID))
                    {
                        canChooseTickets.Add(item);
                    }
                }

                //把自己加进去
                canChooseTickets.Add(match.Ticket);
                ChooseGiftTicketForm form = new ChooseGiftTicketForm(canChooseTickets);
                form.ItemSelected += Form_ItemSelected;
                form.ShowDialog();
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
        }

        private void Form_ItemSelected(GiftTicket ticket, EventArgs t2)
        {
            try
            {
                if (ticket != null)
            {
                 //重新设置匹配
             /*   ticket.CostumeID = match.Retail.CostumeID;
                match.Retail.GiftTickets = ticket.ID;
                match.Ticket = ticket;
                // List<GiftTicket> memberList = (List<GiftTicket>)this.dataGridView1.DataSource;

                //match
                //重新设置match




                GiftTicketList[index] = ticket;
                BindingDataSource(); */
            }
        }
        catch (Exception ee)
        {
            GlobalUtil.ShowError(ee);
        }
}

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    if (e.Value == null) { return; }
                    DataGridView view = sender as DataGridView;
                    GiftTicket tickets = view.Rows[e.RowIndex].DataBoundItem as GiftTicket;

                    //if (e.ColumnIndex == effectDateDataGridViewTextBoxColumn.Index)
                    //{
                    //    if (tickets.EffectDate == SystemDefault.DateTimeNull)
                    //    {
                    //        e.Value = null;
                    //    }
                    //}
                    //else if (e.ColumnIndex == expiredDateDataGridViewTextBoxColumn.Index)
                    //{
                    //    if (tickets.ExpiredDate == SystemDefault.DateTimeNull)
                    //    {
                    //        e.Value = null;
                    //    }
                    //}
                    //else 
                    //if (e.ColumnIndex == Denomination.Index || e.ColumnIndex == denominationDataGridViewTextBoxColumn.Index)
                    //{
                    //    if (String.IsNullOrEmpty(tickets?.ID))
                    //    {
                    //        e.Value = null;
                    //    }
                    //}
                }
            }
            catch (Exception ee)
            {
                GlobalUtil.ShowError(ee);
            }
}

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ConfirmSelectCell(this.GiftTicketList[e.RowIndex]);
        }
    }
}
