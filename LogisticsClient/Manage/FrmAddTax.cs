using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogisticsClient.Manage
{
    public partial class FrmAddTax : Form
    {
        private bool isModify = false;
        private TaxDto originTaxDto = new TaxDto
        {
            GoodsID = 0
        };
        public FrmAddTax()
        {
            InitializeComponent();
        }

        public FrmAddTax(TaxDto dto)
        {
            InitializeComponent();
            txtGoodsName.Text = dto.GoodsName;
            txtPrice.Text = dto.Price.ToString();
            txtTax.Text = dto.TaxRate.ToString();
            originTaxDto.GoodsID = dto.GoodsID;
            isModify = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!AppUtils.AppUtils.CheckText(txtGoodsName, "NO_GOODS_NAME"))
                return;
            if (!AppUtils.AppUtils.CheckText(txtPrice, "NO_CIQ_PRICE"))
                return;
            if (!AppUtils.AppUtils.CheckText(txtTax, "NO_CIQ_RATE"))
                return;

            TaxDto taxDto = new TaxDto
            {
                GoodsID = isModify ? originTaxDto.GoodsID : 0,
                GoodsName = txtGoodsName.Text,
                Price = Convert.ToInt16(txtPrice.Text),
                TaxRate = Convert.ToInt16(txtTax.Text)
            };

            string str_result = WebCall.PostMethod<TaxDto>("api/Tax", taxDto);
            WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                MessageBox.Show(LangBase.GetString(isModify ? "MODIFY_SUCCESS" : "ADD_SUCCESS"));
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
            this.Close();
        }
    }
}
