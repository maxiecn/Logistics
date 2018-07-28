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

namespace LogisticsClient.Manage
{
    public partial class FrmAddFee : Form
    {
        public FrmAddFee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBillLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
                if (e.KeyChar > '9' || e.KeyChar < '0')
                    e.Handled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPriceInfoName.Text.Trim().Equals(string.Empty) || txtUnitPrice.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(LangBase.GetString("VALID_INFO_ADD_COMPANY"));
                return;
            }

            PriceInfoDto priceInfoDto = new PriceInfoDto()
            {
                PriceName = txtPriceInfoName.Text.Trim(),
                UnitPrice = Convert.ToInt16(txtUnitPrice.Text.Trim())
            };
            string str_result = WebCall.PostMethod<PriceInfoDto>("api/PriceInfo", priceInfoDto);
            WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                MessageBox.Show(LangBase.GetString("ADD_SUCCESS"));
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
