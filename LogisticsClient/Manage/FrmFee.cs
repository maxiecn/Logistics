using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.BaseData;

namespace LogisticsClient.Manage
{
    public partial class FrmFee : Form
    {
        public FrmFee()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            ReloadData();
        }

        private void ReloadData()
        {
            var priceInfos = PriceInfo.GetAll();
            dgFee.DataSource = priceInfos;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new FrmAddFee().ShowDialog();
            ReloadData();
        }
    }
}
