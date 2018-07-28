using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FakePrinter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report rpt = new Report();
            rpt.Load(@".\print.frx");
            rpt.SetParameterValue("单号", textBox1.Text);
            rpt.SetParameterValue("发货人", textBox2.Text);
            rpt.SetParameterValue("发货人电话",textBox3.Text);
            rpt.SetParameterValue("货物品名",textBox4.Text );
            rpt.SetParameterValue("包装类型",textBox5.Text );
            rpt.SetParameterValue("总件数", textBox6.Text);
            rpt.SetParameterValue("重量体积", textBox7.Text);
            rpt.SetParameterValue("国际运费", textBox8.Text);
            rpt.SetParameterValue("国内运费", textBox9.Text);
            rpt.SetParameterValue("包装费", textBox10.Text);
            rpt.SetParameterValue("保险费", textBox20.Text);
            rpt.SetParameterValue("运费总额", textBox19.Text);
            rpt.SetParameterValue("付款方式", textBox18.Text);
            rpt.SetParameterValue("转运方式", textBox17.Text);
            rpt.SetParameterValue("特别备注", textBox16.Text);
            rpt.SetParameterValue("制单人", textBox15.Text);
            rpt.SetParameterValue("日期", textBox14.Text);
            rpt.SetParameterValue("收货人", textBox13.Text);
            rpt.SetParameterValue("收货地址", textBox12.Text);
            rpt.SetParameterValue("收货人电话",textBox11.Text );
            rpt.SetParameterValue("密码", textBox21.Text);
            rpt.Show();
            rpt.Dispose();
        }
    }
}
