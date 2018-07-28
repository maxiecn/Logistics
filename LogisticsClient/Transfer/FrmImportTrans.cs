using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.AppUtils;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Transfer
{
    public partial class FrmImportTrans : Form
    {
        private string filename;
        private List<ImportTrans> infos = null;

        public FrmImportTrans(string file, bool isClear)
        {
            InitializeComponent();
            filename = file;
            if (isClear)
                infos = ExcelOper.ImportClearInfos(file);
            else
            {
                infos = ExcelOper.ImportTransForExcel(file);
            }
            chkClear.Checked = isClear;

            if (!isClear)
            {
                foreach (var importTranse in infos)
                {
                    if (importTranse.TransBillID == null || importTranse.TransBillID.Trim().Equals(string.Empty))
                        continue;
                    lstImport.Items.Add(importTranse.BillID + ":" + importTranse.TransBillID);
                }
            }
            else
            {
                foreach (var importTranse in infos)
                {
                    lstImport.Items.Add(importTranse.BillID);
                } 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            string str_result = "";
            if (chkClear.Checked)
            {
                str_result = WebCall.PostMethod<List<ImportTrans>>("Transfer/ClearTransInfos", infos);
            }
            else
            {
                str_result = WebCall.PostMethod<List<ImportTrans>>("Transfer/ImportTransInfos", infos);
            }
            WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                //string msg = string.Empty;
                //foreach (var querycondition in result.Data)
                //{
                //    msg += querycondition.BillID + ":" + querycondition.Password + "\n";
                //}
                //MessageBox.Show(msg);
                MessageBox.Show(Lang.LangBase.GetString("IMPORT_TRANS_SUCCESS"));
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
