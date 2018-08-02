using LogisticsClient.BaseData;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogisticsClient.Receive
{
    public partial class FrmTaxAssitant : Form
    {
        List<TaxDto> allTax = null;
        List<TaxDto> listTax = null;
        public TaxDto selectDto = null;
        public FrmTaxAssitant()
        {
            InitializeComponent();
            allTax = Tax.GetAll();
            listTax = allTax;
            lstTax.DataSource = listTax;
        }

        private void lstTax_DoubleClick(object sender, EventArgs e)
        {
            selectDto = listTax[lstTax.SelectedIndex];
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            listTax = allTax.Where(a => a.GoodsName.Contains(txtFilter.Text)).ToList();
            lstTax.DataSource = listTax;
        }
    }
}
