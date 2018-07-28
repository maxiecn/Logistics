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
    public partial class FrmInput : Form
    {
        private string _infoName = "";
        public string InfoName
        {
            get { return _infoName; }
            set
            {
                _infoName = value;
                this.Text = _infoName;
            }
        }

        public string info = "";

        public FrmInput()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.info = txtInfo.Text.Trim();
            this.Close();
        }
    }
}
