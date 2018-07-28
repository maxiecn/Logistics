using LogisticsClient.AppUtils;
using Model;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogisticsClient.Query
{
    public partial class FrmCountMoney : Form
    {
        public FrmCountMoney()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MoneyCountPara para = new MoneyCountPara()
            {
                startTime = dtPickerStart.Value.Date.ToString(),
                endTime = dtPickerEnd.Value.Date.AddDays(1).ToString()
            };
            string str_result = WebCall.PostMethod<MoneyCountPara>("Query/CountMoney", para);
            List<CountMoneyDto> result = AppUtils.AppUtils.JsonDeserialize<List<CountMoneyDto>>(str_result);
            var sum = result.Sum(a => a.MoneySum);
            var storeSum = from money in result
                           group money by new
                           {
                               money.StoreName
                           } into c
                           select new CountMoneyDto
                           {
                               StoreName = c.Key.StoreName,
                               PayTypeName = "总额",
                               MoneySum = c.Sum(a => a.MoneySum)
                           };
            result.AddRange(storeSum.ToList());
            result.Add(new CountMoneyDto
            {
                StoreName = "全部",
                PayTypeName = "总额",
                MoneySum = sum
            });
            dgMoney.DataSource = result;
        }
    }
}
