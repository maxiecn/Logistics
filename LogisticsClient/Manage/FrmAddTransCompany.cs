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
    public partial class FrmAddTransCompany : Form
    {
        private TransCompDto transCompDto;
        private bool isModify = false;

        public FrmAddTransCompany()
        {
            InitializeComponent();
        }

        public FrmAddTransCompany(TransCompDto transCompDto)
        {
            InitializeComponent();
            isModify = true;
            this.transCompDto = transCompDto;
            txtCompName.Text = transCompDto.TransCompName;
            txtCompCode.Text = transCompDto.TransCode;
            txtBillLength.Text = transCompDto.BillLength.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCompName.Text.Trim().Equals(string.Empty) || txtCompCode.Text.Trim().Equals(string.Empty) ||
                txtBillLength.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(LangBase.GetString("VALID_INFO_ADD_COMPANY"));
                return;
            }

            TransCompDto transDto = new TransCompDto
            {
                TransID = isModify ? transCompDto.TransID : 0,
                TransCompName = txtCompName.Text.Trim(),
                TransCode = txtCompCode.Text.Trim(),
                BillLength =
                    txtBillLength.Text.Trim().Equals(string.Empty) ? 0 : Convert.ToInt16(txtBillLength.Text.Trim())
            };
            string str_result = WebCall.PostMethod<TransCompDto>("api/TransCompany", transDto);
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

        private void txtBillLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBillLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            if (e.KeyChar > '9' || e.KeyChar < '0')
                e.Handled = true;
        }
    }
}