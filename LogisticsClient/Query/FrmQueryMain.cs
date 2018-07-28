using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Controls;
using Logistics.Models;
using LogisticsClient.AppUtils;
using LogisticsClient.BaseData;
using Model;
using Model.DefaultModels;
using Model.Dto;

namespace LogisticsClient.Query
{
    public partial class FrmQueryMain : Form
    {
        private List<TransCompDto> companies;
        private List<T_PayType> paytypes;
        List<ReceiveBill> goods = new List<ReceiveBill>();

        public FrmQueryMain()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            GetTransCompanies();
            GetPayTypes();
            InitAdv();
            RefreshData();
            if (!AppUtils.AppUtils.HasAuth("QUERY_DETAIL_COLUMN"))
            {
                ((DataGridViewTextBoxColumn) dgBills.Columns["ColPassword"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["SenderTel"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["ReceiverTel"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["ReceiverAddress"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["GoodsTypeName"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["PriceTypeName"]).Visible = false;
                ((DataGridViewComboBoxColumn) dgBills.Columns["ColPayType"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["Price"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["ChinaPrice"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["PackingPrice"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["InsurancePrice"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["SumPrice"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["PackingType"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["ReceiveOper"]).Visible = false;
                //((DataGridViewTextBoxColumn) dgBills.Columns["TransBillID"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["TransTime"]).Visible = false;
                ((DataGridViewTextBoxColumn) dgBills.Columns["TransOper"]).Visible = false;
            }

            btnAdvance.Visible = AppUtils.AppUtils.HasAuth("ADV_QUERY");
        }

        private void InitAdv()
        {
            dtEnd.Value = DateTime.Today;

            var goodsTypes = GoodsType.GetAll();
            foreach (var goodsTypeDto in goodsTypes)
            {
                cbxGoodsType.Items.Add(goodsTypeDto);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int startPrice = 0, startMeasure = 0;
            int endPrice = Int32.MaxValue, endMeasure = Int32.MaxValue;
            if (!txtPriceStart.Text.Equals(string.Empty))
                startPrice = Convert.ToInt32(txtPriceStart.Text);
            if (!txtPriceEnd.Text.Equals(string.Empty))
                endPrice = Convert.ToInt32(txtPriceEnd.Text);
            if (!txtMeasureStart.Text.Equals(string.Empty))
                startMeasure = Convert.ToInt32(txtMeasureStart.Text);
            if (!txtMeasureEnd.Text.Equals(string.Empty))
                endMeasure = Convert.ToInt32(txtMeasureEnd.Text);


            var filterGoods = (from g in goods
                where g.BillID.Contains(txtBillID.Text.Trim()) && g.GoodsTypeName.Contains(cbxGoodsType.Text)
                 && g.SenderName.Contains(txtCustomerName.Text) && g.RecordTime >= dtStart.Value && g.RecordTime <= dtEnd.Value.AddDays(1)
                 && g.SumPrice >= startPrice && g.SumPrice <= endPrice && g.Measure >= startMeasure && g.Measure <= endMeasure
                select g).ToList();
            dgBills.DataSource = filterGoods;
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
            ((DataGridViewComboBoxColumn)dgBills.Columns["ColTransComp"]).DataSource = companiesList;
        }

        public void RefreshData()
        {
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            paras.Add(new KeyValuePair<string, string>("showDetail",
                AppUtils.AppUtils.HasAuth("QUERY_DETAIL_COLUMN").ToString()));
            goods = WebCall.GetMethod<List<ReceiveBill>>("Query/GetAllGoodsByRole", paras);
            dgBills.DataSource = goods;
        }
        private void btnAdvance_Click(object sender, EventArgs e)
        {
            //pnlAdv.Visible = !pnlAdv.Visible;
            FrmAdvCondition fr = new FrmAdvCondition(goods,dgBills);
            if (fr.ShowDialog() == DialogResult.Yes)
            {
                dgBills.DataSource = fr.goods;
                goods = fr.goods;
            }
        }

        private void checkNum(object sender, KeyPressEventArgs e)
        {
            string s = "0123456789";
            if (e.KeyChar!=(char)Keys.Back && s.IndexOf(e.KeyChar)==-1)
            {
                e.Handled = true;
            }
        }

        public void Export()
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog()==DialogResult.OK)
            {
                ExcelOper.ExportDG(sv.FileName,dgBills);
            }
        }
    }
}
