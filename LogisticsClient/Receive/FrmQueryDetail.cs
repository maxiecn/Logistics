using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Receive
{
    public partial class FrmQueryDetail : Form
    {
        public FrmQueryDetail(string billID)
        {
            InitializeComponent();

            GetBaseInfo(billID);
        }

        private void GetBaseInfo(string billID)
        {
            List<KeyValuePair<string,string>> paras = new List<KeyValuePair<string, string>>();
            paras.Add(new KeyValuePair<string, string>("_billid", billID));
            QueryListResult bills = WebCall.GetMethod<QueryListResult>("Query/QueryList", paras);
            if (bills.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                dgBase.DataSource = bills.Data;
            }
        }

        private void dgBase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBase.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_BILL"));
                return;
            }
            else
            {
                int rowIndex = dgBase.SelectedCells[0].RowIndex;
                string billID = dgBase.Rows[rowIndex].Cells["BillID"].Value.ToString();
                List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
                paras.Add(new KeyValuePair<string, string>("_billid", billID));
                List<Operation> details = WebCall.GetMethod<List<Operation>>("Query/QueryDetail", paras);
                dgDetail.DataSource = details;
            }
        }
    }
}
