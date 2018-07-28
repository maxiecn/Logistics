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
    public partial class FrmBackToStoreDetail : Form
    {
        private List<BackToStoreGoods> billList;
        public FrmBackToStoreDetail(List<BackToStoreGoods> bills)
        {
            InitializeComponent();
            billList = bills;
            dgBackDetail.DataSource = bills;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认将这些货品退回门店吗?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                List<String> billIDs = new List<string>();
                foreach (var backGoodse in billList)
                {
                    billIDs.Add(backGoodse.BillID);
                }
                WebResult result =
                    AppUtils.AppUtils.JsonDeserialize<WebResult>(WebCall.PostMethod("Store/BackToStore", billIDs));
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(Lang.LangBase.GetString("BACK_SUCCESS"));
                    this.DialogResult = DialogResult.OK;
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
