using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPGetter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //lblIP.Text = IPOper.GetIP();
            //IPOper.WriteToServer();
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) //判断是否最小化
            {
                this.ShowInTaskbar = false; //不显示在系统任务栏
                notifyIcon1.Visible = true; //托盘图标可见
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblIP.Text = IPOper.GetIP();
            IPOper.WriteToServer();
        }
    }
}
