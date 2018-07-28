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
    public partial class FrmReceiveMoney : Form
    {
        public FrmReceiveMoney(List<ReceiveBill> goods)
        {
            InitializeComponent();
            foreach (var receiveBill in goods)
            {
                lstBills.Items.Add(new MoneyDisplay(receiveBill));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<MoneyDisplay> bills = new List<MoneyDisplay>();
            for (var i = 0; i < lstBills.Items.Count; i++)
            {
                if (lstBills.GetItemChecked(i))
                {
                    bills.Add((lstBills.Items[i] as MoneyDisplay));
                }
            }
            if (new FrmCheckReceiveMoney(bills,dpMoneyReceive.Value,txtRemark.Text).ShowDialog()==DialogResult.OK)
            {
                this.Close();
            }
        }
    }

    public class MoneyDisplay
    {
        [DisplayName("单号")]
        public string bill { get; set; }

        [DisplayName("金额")]
        public int price
        {
            get;
            set;}

        [DisplayName("发货人")]
        public string sendername
        {
            get;
            set;
        }
        public MoneyDisplay(ReceiveBill bill)
        {
            this.bill = bill.BillID;
            this.price = Convert.ToInt32(bill.SumPrice);
            this.sendername = bill.SenderName;
        }

        public override string ToString()
        {
            return bill + " - " + sendername + "-" + price.ToString();
        }
    }
}
