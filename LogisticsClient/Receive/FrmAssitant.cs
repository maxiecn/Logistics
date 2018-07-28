﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.AppUtils;
using Model.Dto;

namespace LogisticsClient.Receive
{
    public partial class FrmAssitant : Form
    {
        private List<HintInputDto> hints;
        public HintInputDto ResultDto;
        public FrmAssitant()
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtKeyword.Text.Trim().Equals(string.Empty))
            {
                List<KeyValuePair<string, string>> paramlist = new List<KeyValuePair<string, string>>();
                paramlist.Add(new KeyValuePair<string, string>("_senderName", txtKeyword.Text.Trim()));
                hints = WebCall.GetMethod<List<HintInputDto>>("Query/GetAllGoods", paramlist);
                dgHint.DataSource = hints;
            }
        }

        private void dgHint_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgHint.SelectedCells.Count != 0)
            {
                ResultDto = hints[dgHint.SelectedCells[0].RowIndex];
                DialogResult = System.Windows.Forms.DialogResult.Yes;
                this.Close();
            }
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }
    }
}
