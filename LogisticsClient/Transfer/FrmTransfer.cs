using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logistics.Models;
using LogisticsClient.AppUtils;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Transfer
{
    public partial class FrmTransfer : Form
    {
        private List<T_TransCompany> companies;

        public FrmTransfer()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            GetTransCompanies();
            RefreshData();
        }

        private void GetTransCompanies()
        {
            companies = WebCall.GetMethod<List<T_TransCompany>>("api/TransCompany/get", null);
            var companiesList = new List<string>();
            foreach (var company in companies)
            {
                companiesList.Add(company.TransCompanyName);
            }
            ((DataGridViewComboBoxColumn)dgBills.Columns["ColTransComp"]).DataSource = companiesList;
        }

        public void RefreshData()
        {
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            var goods = WebCall.GetMethod<List<TransferBill>>("transfer/GetAllGoods", paras);
            dgBills.DataSource = goods;
        }

        private void dgBills_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string BillID = dgBills.Rows[e.RowIndex].Cells["BillID"].Value.ToString();
            string TransBill = dgBills.Rows[e.RowIndex].Cells["TransBill"].Value.ToString();
            TransParam param = new TransParam
            {
                billid = BillID,
                transid = TransBill,
                uid = Configure.UserID
            };
            WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(WebCall.PostMethod("Transfer/UpdateTransInfo", param));
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                RefreshData();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void dgBills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            int rowIndex = dgBills.SelectedCells[0].RowIndex;
            string billID = dgBills.Rows[rowIndex].Cells["BillID"].Value.ToString();
            string transID = dgBills.Rows[rowIndex].Cells["TransBill"].Value == null
                ? string.Empty
                : dgBills.Rows[rowIndex].Cells["TransBill"].Value.ToString();
            new FrmModifyTrans(billID, transID).ShowDialog();
            RefreshData();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            var goods = WebCall.GetMethod<List<TransferBill>>("transfer/GetAllGoods", paras);
            var filterGoods = goods.Where(a => (a.BillID==null?string.Empty:a.BillID).Contains(txtBillID.Text) || (a.TransBill==null?string.Empty:a.TransBill).Contains(txtBillID.Text)).ToList();
            dgBills.DataSource = filterGoods;
        }

       
    }
}
