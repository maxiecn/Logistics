using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.AppUtils;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Transfer
{
    public partial class FrmBackBills : Form
    {
        public FrmBackBills()
        {
            InitializeComponent();
            getBills();
        }

        private void getBills()
        {
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            var goods = WebCall.GetMethod<List<TransferBill>>("transfer/GetAllGoods", paras);
            var notTrans = goods.Where(a => a.Status == CommonConst.BILL_STATUS_STOCKOUT).ToList();
            foreach (var good in notTrans)
            {
                BackToStockGoods backToStockGoods = new BackToStockGoods(good);
                chkGoods.Items.Add(backToStockGoods);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<BackToStockGoods> billIdList = new List<BackToStockGoods>();
            for (var i = 0; i < chkGoods.Items.Count; i++)
            {
                if (chkGoods.GetItemChecked(i))
                {
                    billIdList.Add((BackToStockGoods) chkGoods.Items[i]);
                }
            }

            if (new FrmBackToStoreDetail(billIdList).ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
