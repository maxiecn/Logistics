using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FastReport;
using Logistics.Models;
using LogisticsClient.AppUtils;
using LogisticsClient.BaseData;
using LogisticsClient.Lang;
using LogisticsClient.Query;
using Microsoft.Office.Interop.Excel;
using Model;
using Model.CallResult;
using Model.DefaultModels;
using Model.Dto;
using DataTable = Microsoft.Office.Interop.Excel.DataTable;
using SortOrder = System.Data.SqlClient.SortOrder;

namespace LogisticsClient.Receive
{
    public partial class FrmReceiveMain : Form
    {
        private List<TransCompDto> companies;
        private List<T_PayType> paytypes;
        private List<ReceiveBill> goods;
        private List<ReceiveBill> filterGoods;
        private bool filterMoney = false;
        private bool hassent;
        private int page = 1;
        private int pageAmount = 50;
        private bool isDesc = false;

        public bool HasSent
        {
            get { return hassent; }
            set
            {
                hassent = value;
            }
        }

        private bool notsent;
        public bool NotSent
        {
            get { return notsent; }
            set
            {
                notsent = value;
            }
        }


        public FrmReceiveMain()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            //GetTransCompanies();
            GetPayTypes();
            GetDataSource();
            GetPages();
            if (AppUtils.AppUtils.HasAuth("RECEIVE_ MULTISTORE"))
            {
                cbxStore.Visible = true;
                GetStores();
            }
            else
            {
                cbxStore.Visible = false;
            }
            SetDataGrid();
            HasSent = false;
            NotSent = false;
        }

        private void GetStores()
        {
            var storeDtos = Stores.GetAll();
            StoreDto store = new StoreDto()
            {
                StoreID = 0,
                StoreName = LangBase.GetString("ALLSTORE")
            };
            storeDtos.Insert(0,store);
            foreach (StoreDto storeDto in storeDtos)
            {
                cbxStore.Items.Add(storeDto);
            }
        }

        private void SetDataGrid()
        {
            for (int i = 0; i < dgBills.ColumnCount; i++)
            {
                dgBills.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            dgBills.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
        }

        private void GetPages()
        {
            pageCount.Maximum = filterGoods.Count == 0 ? 1 : (filterGoods.Count / pageAmount) + 1;
        }
        
        private void GetPayTypes()
        {
            paytypes = WebCall.GetMethod<List<T_PayType>>("api/PayType/get", null);
            var paylist = new List<string>();
            foreach (var paytype in paytypes)
            {
                paylist.Add(paytype.PayName);
            }
            ((DataGridViewComboBoxColumn)dgBills.Columns["ColPayType"]).DataSource = paylist;
        }

        private void GetTransCompanies()
        {
            companies = WebCall.GetMethod<List<TransCompDto>>("api/TransCompany/get", null);
            var companiesList = new List<string>();
            foreach (var company in companies)
            {
                companiesList.Add(company.TransCompName);
            }
            ((DataGridViewComboBoxColumn) dgBills.Columns["ColTransComp"]).DataSource = companiesList;
        }

        public void RefreshData(int page)
        {
            GetDataSource(); //刷新数据
            List<ReceiveBill> pageGoods;
            if (Configure.StoreID == 0)
                pageGoods = goods.Take(pageAmount * page).Skip(pageAmount * (page - 1)).ToList();
            else
                pageGoods = goods.Where(a => a.StoreID == Configure.StoreID).Take(pageAmount * page).Skip(pageAmount * (page - 1)).ToList();
            dgBills.DataSource = pageGoods;
        }

        public void GetDataSource()
        {
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            paras.Add(new KeyValuePair<string, string>("storeID", Configure.StoreID.ToString()));
            goods = WebCall.GetMethod<List<ReceiveBill>>("receive/GetAllGoodsByRole", paras);
            filterGoods = goods;
            dgBills.DataSource = filterGoods;
        }

        public void ReturnGoods()
        {
            if (dgBills.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_BILL"));
                return;
            }
            else
            {
                if (MessageBox.Show(LangBase.GetString("COMFIRM_RETURN_BILL"), string.Empty, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int rowIndex = dgBills.SelectedCells[0].RowIndex;
                    string billID = dgBills.Rows[rowIndex].Cells["BillID"].Value.ToString();
                    ReceiveDto receiveInfo = new ReceiveDto
                    {
                        BillID = billID,
                        RecorderID = Configure.UserID
                    };
                    string str_result = WebCall.PostMethod<ReceiveDto>("receive/ReturnGoods", receiveInfo);
                    WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
                    if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                    {
                        MessageBox.Show(LangBase.GetString("ADD_SUCCESS"));
                        RefreshData(1);
                    }
                    else
                    {
                        MessageBox.Show(result.Message);
                    }
                }
            }
        }

        internal void ModifyGoods()
        {
            if (dgBills.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_BILL"));
                return;
            }
            else
            {
                int rowIndex = dgBills.SelectedCells[0].RowIndex;
                ReceiveDto modifReceiveDto = new ReceiveDto();
                modifReceiveDto.BillID = dgBills.Rows[rowIndex].Cells["BillID"].Value.ToString();
                modifReceiveDto.SenderName = dgBills.Rows[rowIndex].Cells["SenderName"].Value.ToString();
                modifReceiveDto.SenderTel = dgBills.Rows[rowIndex].Cells["SenderTel"].Value.ToString();
                modifReceiveDto.ReceiverName = dgBills.Rows[rowIndex].Cells["ReceiverName"].Value.ToString();
                modifReceiveDto.ReceiverTel = dgBills.Rows[rowIndex].Cells["ReceiverTel"].Value.ToString();
                modifReceiveDto.ReceiverAddress = dgBills.Rows[rowIndex].Cells["ReceiverAddress"].Value.ToString();
                modifReceiveDto.Measure = Convert.ToSingle(dgBills.Rows[rowIndex].Cells["Measure"].Value.ToString());
                //Weight = Convert.ToSingle(dgBills.Rows[rowIndex].Cells["Weight"].Value.ToString());
                modifReceiveDto.Amount = Convert.ToInt16(dgBills.Rows[rowIndex].Cells["Amount"].Value.ToString());
                modifReceiveDto.GoodsType = Convert.ToInt16(dgBills.Rows[rowIndex].Cells["GoodsTypeID"].Value.ToString());
                modifReceiveDto.PriceType = Convert.ToInt16(dgBills.Rows[rowIndex].Cells["PriceTypeID"].Value.ToString());
                modifReceiveDto.PackingType =
                    Convert.ToInt16(dgBills.Rows[rowIndex].Cells["PackingTypeID"].Value.ToString());
                modifReceiveDto.PayType = Convert.ToInt16(dgBills.Rows[rowIndex].Cells["PayTypeID"].Value.ToString());
                modifReceiveDto.Remark = dgBills.Rows[rowIndex].Cells["Remark"].Value == null ? "" : dgBills.Rows[rowIndex].Cells["Remark"].Value.ToString();
                modifReceiveDto.ChinaPrice = Convert.ToInt32(dgBills.Rows[rowIndex].Cells["ChinaPrice"].Value.ToString());
                modifReceiveDto.InsurancePrice =
                    Convert.ToInt32(dgBills.Rows[rowIndex].Cells["InsurancePrice"].Value.ToString());
                modifReceiveDto.PackingPrice =
                    Convert.ToInt32(dgBills.Rows[rowIndex].Cells["PackingPrice"].Value.ToString());
                //modifReceiveDto.hasReceiveMoney = dgBills.Rows[rowIndex].Cells["colHasReceiveMoney"].Value.ToString().Equals("已收款");
                modifReceiveDto.GoodsName = dgBills.Rows[rowIndex].Cells["GoodsName"].Value == null
                    ? ""
                    : dgBills.Rows[rowIndex].Cells["GoodsName"].Value.ToString();
                modifReceiveDto.Price = Convert.ToInt32(dgBills.Rows[rowIndex].Cells["Price"].Value.ToString()); 
                modifReceiveDto.SumPrice = Convert.ToInt32(dgBills.Rows[rowIndex].Cells["SumPrice"].Value.ToString());
                modifReceiveDto.BillFee = Convert.ToInt32(dgBills.Rows[rowIndex].Cells["BillFee"].Value.ToString());
                modifReceiveDto.TransID = Convert.ToInt16(dgBills.Rows[rowIndex].Cells["ColTransID"].Value.ToString());
                modifReceiveDto.hasReceiveMoney = Convert.ToBoolean(dgBills.Rows[rowIndex].Cells["hasReceiveMoney"].Value);
                modifReceiveDto.UnitPrice = Convert.ToInt32(dgBills.Rows[rowIndex].Cells["ColUnitPrice"].Value.ToString());
                modifReceiveDto.RecordTime = Convert.ToDateTime(dgBills.Rows[rowIndex].Cells["ColRecordTime"].Value);
                modifReceiveDto.TransName = dgBills.Rows[rowIndex].Cells["ColTransComp"].Value == null
                    ? ""
                    : dgBills.Rows[rowIndex].Cells["ColTransComp"].Value.ToString();
                modifReceiveDto.IdCard = dgBills.Rows[rowIndex].Cells["IdCard"].Value.ToString();
                modifReceiveDto.CIQPrice = Convert.ToInt16(dgBills.Rows[rowIndex].Cells["CIQPrice"].Value);
                modifReceiveDto.TaxRate = Convert.ToInt16(dgBills.Rows[rowIndex].Cells["TaxRate"].Value);
                modifReceiveDto.TaxPrice = Convert.ToInt16(dgBills.Rows[rowIndex].Cells["TaxPrice"].Value);
                FrmAddReceive fmodify = new FrmAddReceive(modifReceiveDto);
                fmodify.ShowDialog();
                RefreshData(1);
            }
        }

        private void dgBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex==-1)
            {
                return;
            }
            ModifyGoods();
        }

        public void SendGoods()
        {
            new FrmSendToStore().ShowDialog();
            RefreshData(1);
        }

        private void btnNotSend_Click(object sender, EventArgs e)
        {
            NotSent = !NotSent;
            HasSent = false;
            if (NotSent)
            {
                DateTime date = DateTime.Now.AddDays(-3);
                var filtergoods = (from receiveBill in goods
                                   where receiveBill.Status == CommonConst.BILL_STATUS_RECEIVED
                                   select receiveBill).ToList();
                dgBills.DataSource = filtergoods;
            }
            else
            {
                dgBills.DataSource = goods;
            }
        }

        private void btnHasSent_Click(object sender, EventArgs e)
        {
            HasSent = !HasSent;
            NotSent = false;
            if (HasSent)
            {
                DateTime date = DateTime.Now.AddDays(-3);
                var filtergoods = (from receiveBill in goods
                                   where receiveBill.Status == CommonConst.BILL_STATUS_SEND // && receiveBill.RecordTime >= date 
                                   select receiveBill).ToList();
                dgBills.DataSource = filtergoods;
            }
            else
            {
                dgBills.DataSource = goods;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgBills.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_BILL"));
                return;
            }
            else
            {
                int rowIndex = dgBills.SelectedCells[0].RowIndex;
                Report rpt = new Report();
                rpt.Load(@".\Resources\print.frx");
                rpt.SetParameterValue("单号", dgBills.Rows[rowIndex].Cells["BillID"].Value.ToString().Substring(7,5));
                rpt.SetParameterValue("发货人", dgBills.Rows[rowIndex].Cells["SenderName"].Value.ToString());
                rpt.SetParameterValue("发货人电话", dgBills.Rows[rowIndex].Cells["SenderTel"].Value.ToString());
                rpt.SetParameterValue("货物品名", dgBills.Rows[rowIndex].Cells["GoodsName"].Value == null
                        ? ""
                        : dgBills.Rows[rowIndex].Cells["GoodsName"].Value.ToString());
                rpt.SetParameterValue("包装类型",dgBills.Rows[rowIndex].Cells["ColPackingName"].Value.ToString());
                rpt.SetParameterValue("总件数", dgBills.Rows[rowIndex].Cells["Amount"].Value.ToString());
                rpt.SetParameterValue("重量体积", dgBills.Rows[rowIndex].Cells["Measure"].Value.ToString());
                rpt.SetParameterValue("国际运费", Convert.ToInt32(dgBills.Rows[rowIndex].Cells["Price"].Value.ToString()));
                rpt.SetParameterValue("国内运费", Convert.ToInt32(dgBills.Rows[rowIndex].Cells["ChinaPrice"].Value.ToString()));
                rpt.SetParameterValue("包装费", Convert.ToInt32(dgBills.Rows[rowIndex].Cells["PackingPrice"].Value.ToString()));
                rpt.SetParameterValue("保险费", Convert.ToInt32(dgBills.Rows[rowIndex].Cells["InsurancePrice"].Value.ToString()));
                rpt.SetParameterValue("运费总额", Convert.ToInt32(dgBills.Rows[rowIndex].Cells["SumPrice"].Value.ToString()));
                rpt.SetParameterValue("付款方式", dgBills.Rows[rowIndex].Cells["ColPayType"].Value.ToString());
                rpt.SetParameterValue("转运方式", dgBills.Rows[rowIndex].Cells["ColTransComp"].Value.ToString());
                rpt.SetParameterValue("特别备注", dgBills.Rows[rowIndex].Cells["Remark"].Value == null ? "" : dgBills.Rows[rowIndex].Cells["Remark"].Value.ToString());
                rpt.SetParameterValue("制单人", Configure.UserName);
                rpt.SetParameterValue("日期", dgBills.Rows[rowIndex].Cells["ColRecordTime"].Value.ToString());
                rpt.SetParameterValue("收货人", dgBills.Rows[rowIndex].Cells["ReceiverName"].Value.ToString());
                rpt.SetParameterValue("收货地址", dgBills.Rows[rowIndex].Cells["ReceiverAddress"].Value.ToString());
                rpt.SetParameterValue("收货人电话", dgBills.Rows[rowIndex].Cells["ReceiverTel"].Value.ToString());
                rpt.SetParameterValue("密码", dgBills.Rows[rowIndex].Cells["ColPassword"].Value.ToString());
                rpt.Show();
                rpt.Dispose();
            }
        }

        private void btnEditPrint_Click(object sender, EventArgs e)
        {
            new FrmEditPrint().ShowDialog();
        }

        internal void ExportToStock()
        {
            ExcelOper.ExportToStock(dgBills);
        }

        private void btnNotReceiveMoney_Click(object sender, EventArgs e)
        {
            if (filterMoney)
            {
                dgBills.DataSource = goods;
            }
            else
            {
                var filtergoods = goods.Where(a => a.hasReceiveMoney == false).ToList();
                dgBills.DataSource = filtergoods;
            }
            filterMoney = !filterMoney;
        }

        internal void ReceiveMoney()
        {
            var filtergoods = goods.Where(a => a.hasReceiveMoney == false).ToList();
            new FrmReceiveMoney(filtergoods).ShowDialog();
            RefreshData(1);
        }

        private void pageCount_ValueChanged(object sender, EventArgs e)
        {
            page = Convert.ToInt32(pageCount.Value);
            RefreshData(page);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //RefreshData(page);
            if (!txtBillID.Text.Trim().Equals(string.Empty))
                new FrmQueryDetail(txtBillID.Text).ShowDialog();
        }

        private void dgBills_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var col = dgBills.Columns[e.ColumnIndex];
            List<ReceiveBill> ps;
            if (isDesc)
            {
                ps = (from p in filterGoods
                    orderby AppUtils.AppUtils.GetInfo(p, col.DataPropertyName)
                    select p).ToList();
            }
            else
            {
                ps = (from p in filterGoods
                      orderby AppUtils.AppUtils.GetInfo(p, col.DataPropertyName) descending 
                    select p).ToList();
            }
            isDesc = !isDesc;
            dgBills.DataSource = ps;
        }

        private void btnSearchAdv_Click(object sender, EventArgs e)
        {
            FrmAdvCondition fr = new FrmAdvCondition(goods, dgBills);
            if (fr.ShowDialog() == DialogResult.Yes)
            {
                dgBills.DataSource = fr.goods;
                filterGoods = fr.goods;
            }
        }

        private void cbxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbxStore.Visible)
            {
                return;
            }
            StoreDto storeDto = cbxStore.SelectedItem as StoreDto;
            Configure.StoreID = storeDto.StoreID;
            RefreshData(1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgBills.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_BILL"));
                return;
            }
            else
            {
                if (MessageBox.Show(LangBase.GetString("COMFIRM_DELETE_BILL"),"",MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                int rowIndex = dgBills.SelectedCells[0].RowIndex;
                SendBill deleteBill = new SendBill
                {
                    BillID = dgBills.Rows[rowIndex].Cells["BillID"].Value.ToString(),
                    RecorderID = Configure.UserID
                };
                string str_result = WebCall.PostMethod<SendBill>("receive/DeleteBill", deleteBill);
                WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(LangBase.GetString("DEL_SUCCESS"));
                    RefreshData(1);
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }

        private void dgBills_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void dgBills_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers  
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new System.Drawing.Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}