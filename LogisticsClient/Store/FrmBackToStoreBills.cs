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

namespace LogisticsClient.Store
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
            chkGoods.Items.Clear();
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            var goods = WebCall.GetMethod<List<ReceiveBill>>("store/StoreToSend", paras);
            foreach (var good in goods)
            {
                BackToStoreGoods backToStoreGoods = new BackToStoreGoods(good);
                chkGoods.Items.Add(backToStoreGoods);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            List<BackToStoreGoods> billIdList = new List<BackToStoreGoods>();
            for (var i = 0; i < chkGoods.Items.Count; i++)
            {
                if (chkGoods.GetItemChecked(i))
                {
                    BackToStoreGoods backToStoreGoods = (BackToStoreGoods) chkGoods.Items[i];
                    billIdList.Add(backToStoreGoods);
                }
            }
            if (new FrmBackToStoreDetail(billIdList).ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
