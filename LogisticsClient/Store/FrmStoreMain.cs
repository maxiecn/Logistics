using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Logistics.Models;
using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Store
{
    public partial class FrmStoreMain: Form
    {

        public FrmStoreMain()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            RefreshData();
        }

        public void RefreshData()
        {
            var goods = WebCall.GetMethod<List<SendBill>>("store/GetBills", null);
            dgStore.DataSource = goods;
        }

        private void dgStore_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BillDetail();
        }
        
        public void BillDetail()
        {
            if (dgStore.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_BILL"));
                return;}
            else
            {
                int rowIndex = dgStore.SelectedCells[0].RowIndex;
                string BillID = dgStore.Rows[rowIndex].Cells["BillID"].Value.ToString();
                List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
                KeyValuePair<string, string> bill = new KeyValuePair<string, string>("billid", BillID);
                param.Add(bill);
                var goods = WebCall.GetMethod<List<SendBillDetail>>("store/GetBillDetail", param);
                new FrmSendDetail(BillID, goods).ShowDialog();
                RefreshData();
            }
        }

        public void ExportToKM()
        {
            List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> bill = new KeyValuePair<string, string>("storeID", "0");
            param.Add(bill);
            var goods = WebCall.GetMethod<List<ReceiveBill>>("Send/GetAllGoods", param);
            ExcelOper.ExportToKM(goods);
        }
    }
}