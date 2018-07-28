using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.AppUtils;
using Model.DefaultModels;
using Model.Dto;

namespace LogisticsClient.Query
{
    public partial class FrmPayResult : Form
    {
        public FrmPayResult()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);

            var list = WebCall.GetMethod<List<QueryPayResultDto>>("query/querypayresult", null);
            dgPayResult.DataSource = list;
        }
    }
}
