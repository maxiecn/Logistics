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

namespace LogisticsClient.Store
{
    public partial class FrmStoreToKM : Form{
        public FrmStoreToKM()
        {
            InitializeComponent();
            refreshDate();
        }

        private void refreshDate(){
            chkGoods.Items.Clear();
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            var goods = WebCall.GetMethod<List<ReceiveBill>>("store/StoreToSend", paras);
            foreach (var good in goods)
            {
                chkGoods.Items.Add(string.Format("{0}:{1}-{2}", good.BillID, good.GoodsTypeName, good.Amount));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            List<string> billIdList = new List<string>();
            for (var i = 0; i < chkGoods.Items.Count; i++)
            {
                if (chkGoods.GetItemChecked(i))
                {
                    string[] splitStrings = chkGoods.GetItemText(chkGoods.Items[i]).Trim().Split(':');
                    if (splitStrings.Length > 0) 
                        billIdList.Add(splitStrings[0]);
                }
            }
            WebResult result =
                AppUtils.AppUtils.JsonDeserialize<WebResult>(WebCall.PostMethod("Store/SendToKM", billIdList));
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                MessageBox.Show(string.Format(LangBase.GetString("SEND_SUCCESS"), result.Message));
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void FrmStoreToKM_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkGoods.Items.Count; i++)
            {
                this.chkGoods.SetItemChecked(i, true);
            }
        }
    }
}
