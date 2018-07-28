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
    public partial class FrmBackToStoreDetail : Form
    {
        private List<BackToStockGoods> bills;
        public FrmBackToStoreDetail(List<BackToStockGoods> billList)
        {
            InitializeComponent();
            bills = billList;
            dgDetails.DataSource = bills;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认将这些单据退回仓库?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                List<string> billIdList = new List<string>();
                foreach (var backToStockGoodse in bills)
                {
                    billIdList.Add(backToStockGoodse.BillID);
                }

                WebResult result =
                    AppUtils.AppUtils.JsonDeserialize<WebResult>(WebCall.PostMethod("Transfer/BackToStore", billIdList));
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(Lang.LangBase.GetString("BACK_SUCCESS"));
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
}
