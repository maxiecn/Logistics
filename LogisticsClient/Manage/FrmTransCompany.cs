using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logistics.Models;
using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Manage
{
    public partial class FrmTransCompany : Form{
        public FrmTransCompany()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            RefreshData();
        }

        private void RefreshData()
        {
            var users = WebCall.GetMethod<List<TransCompDto>>("api/TransCompany", null);
            dgTrans.DataSource = users;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmAddTransCompany().ShowDialog();
            RefreshData();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgTrans.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_USER"));
                return;
            }
            else
            {
                int rowIndex = dgTrans.SelectedCells[0].RowIndex;
                TransCompDto transCompDto = new TransCompDto();
                transCompDto.TransID = Convert.ToInt16(dgTrans.Rows[rowIndex].Cells[0].Value);
                transCompDto.TransCompName = dgTrans.Rows[rowIndex].Cells[1].Value.ToString();
                transCompDto.TransCode = dgTrans.Rows[rowIndex].Cells[2].Value.ToString();
                transCompDto.BillLength =
                    Convert.ToInt16(dgTrans.Rows[rowIndex].Cells[3].Value.ToString());
                new FrmAddTransCompany(transCompDto).ShowDialog();
                RefreshData();
            }
        }
    }
}
