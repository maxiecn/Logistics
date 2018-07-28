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

namespace LogisticsClient.Receive
{
    public partial class FrmCheckReceiveMoney : Form
    {
        private List<MoneyDisplay> bills;
        private DateTime dtReceive;
        private string remark;
        public FrmCheckReceiveMoney(List<MoneyDisplay> _bills,DateTime _dtReceive,string _remark)
        {
            InitializeComponent();
            bills = _bills;
            dtReceive = _dtReceive;
            remark = _remark;
            dgReceiveMoney.DataSource = bills;
            int sum = 0;
            foreach (var moneyDisplay in _bills)
            {
                sum += moneyDisplay.price;
            }
            lblSum.Text = sum.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<string> billIdList = new List<string>();
            foreach (MoneyDisplay moneyDisplay in bills)
            {
                billIdList.Add(moneyDisplay.bill);
            }

            MoneyReceivePara para = new MoneyReceivePara();
            para.billIdList = billIdList;
            para.User = Configure.UserID;
            para.receiveTime = dtReceive;
            para.remark = remark;
            WebResult result =
                AppUtils.AppUtils.JsonDeserialize<WebResult>(WebCall.PostMethod("Receive/ReceiveMoney", para));
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                MessageBox.Show(string.Format(LangBase.GetString("RECORD_SUCCESS"), result.Message));
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
