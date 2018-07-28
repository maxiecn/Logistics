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

namespace LogisticsClient.Transfer
{
    public partial class FrmModifyTrans : Form
    {
        public FrmModifyTrans(string billID,string transID)
        {
            InitializeComponent();
            txtBill.Text = billID;
            txtBill.Enabled = false;
            txtTransID.Text = transID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TransParam param = new TransParam
            {
                billid = txtBill.Text,
                transid = txtTransID.Text,
                uid = Configure.UserID
            };
            string str_result = WebCall.PostMethod<TransParam>("Transfer/UpdateTransInfo", param);
            WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                MessageBox.Show(LangBase.GetString("MODIFY_SUCCESS"));
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
