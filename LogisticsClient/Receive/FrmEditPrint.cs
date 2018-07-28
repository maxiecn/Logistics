using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;
using FastReport.Design.StandardDesigner;

namespace LogisticsClient.Receive
{
    public partial class FrmEditPrint : Form
    {
        private DesignerControl designer;

        public FrmEditPrint()
        {
            InitializeComponent();
            designer = new DesignerControl();
            Report report = new Report();
            designer.Report = report;
            designer.Dock = DockStyle.Fill;
            designer.RefreshLayout();
            this.Controls.Add(designer);
        }
    }
}
