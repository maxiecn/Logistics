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

namespace LogisticsClient.Store
{
    public partial class FrmSendDetail : Form
    {
        private List<SendBillDetail> goodsList;
        private List<DisplaySendBillDetail> displayList;
        private string transID;

        public FrmSendDetail(string _transID, List<SendBillDetail> _goodsList)
        {
            InitializeComponent();
            goodsList = _goodsList;
            transID = _transID;
            displayList = new List<DisplaySendBillDetail>();
            foreach (var sendBillDetail in goodsList)
            {
                displayList.Add(new DisplaySendBillDetail
                {
                    GoodsID = sendBillDetail.GoodsID,
                    Status = sendBillDetail.Status
                });
            }
            RefreshData();
        }

        private void RefreshData()
        {
            foreach (var displaySendBillDetail in displayList)
            {
                chkGoods.Items.Add(displaySendBillDetail);}
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            StockInBaseInfo baseInfo = new StockInBaseInfo
            {
                TransID = transID,
                ReceiverID = Configure.UserID
            };
            List<String> billList = new List<string>();
            for (var i = 0; i < chkGoods.Items.Count; i++)
            {
                if (chkGoods.GetItemChecked(i))
                {
                    billList.Add(chkGoods.GetItemText(chkGoods.Items[i]).Trim());
                }
            }
            StockInParam param = new StockInParam
            {
                baseInfo = baseInfo,
                billList = billList
            };
            WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(WebCall.PostMethod("Store/StoreIn", param));
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                MessageBox.Show(LangBase.GetString("STOCKIN_SUCCESS"));
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkGoods.Items.Count; i++)
            {
                this.chkGoods.SetItemChecked(i, true);
            }
        }
    }

    internal class DisplaySendBillDetail :SendBillDetail
    {
        public override string ToString()
        {
            return GoodsID;
        }
    }
}
