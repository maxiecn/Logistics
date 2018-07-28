using System;
using System.Configuration;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using LogisticsClient.AppUtils;
using LogisticsClient.Manage;
using LogisticsClient.Query;
using LogisticsClient.Receive;
using LogisticsClient.Store;
using LogisticsClient.Transfer;

namespace LogisticsClient
{
    public partial class FrmMain : RibbonForm
    {
        private readonly FrmLogin frmLogin = new FrmLogin();
        private Form activeForm;


        public FrmMain()
        {
            InitializeComponent();
            frmLogin.frmParent = this;
            //从网络获取sun的ip
            getIPFromWeb();
            frmLogin.ShowDialog();
        }

        public void getIPFromWeb()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var result = client.GetAsync(new Uri(
                        "http://www.thaiyuda.com:114/IP/get",
                        UriKind.Absolute))
                        .Result.Content.ReadAsStringAsync()
                        .Result;
                    Configuration config =
                        System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.AppSettings.Settings["url"].Value = result;
                    config.Save();
                }
                catch(Exception)
                {
                    MessageBox.Show("无法连接服务器，如有需要，请手动修改IP");
                }
                WebCall.LoadUrl();
            }
        }
        
        public void checkFunctions()
        {
            pnlContent.Controls.Clear();
            rPManage.Visible = AppUtils.AppUtils.HasAuth("MAIN_MANAGE");
            rPReceive.Visible = AppUtils.AppUtils.HasAuth("MAIN_RECEIVE");
            rPStock.Visible = AppUtils.AppUtils.HasAuth("MAIN_STOCK");
            rpTrans.Visible = AppUtils.AppUtils.HasAuth("MAIN_TRANSPORT");
            rPQuery.Visible = AppUtils.AppUtils.HasAuth("MAIN_QUERY");
            Menu_CountMoney.Visibility = (AppUtils.AppUtils.HasAuth("QUERY_COUNT")
                ? BarItemVisibility.Always
                : BarItemVisibility.Never);
            MenuItem_PayResult.Visibility = (AppUtils.AppUtils.HasAuth("QUERY_PAYRESULT")
                ? BarItemVisibility.Always
                : BarItemVisibility.Never);
        }

        private void MenuItem_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void MenuItem_Logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Hide();
            frmLogin.ShowDialog();
            Show();
        }

        private void Menu_User_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmUserManager());
        }

        private void ribbon_SelectedPageChanged(object sender, EventArgs e)
        {
            Menu_Search.Visibility = BarItemVisibility.Never;
            if (ribbon.SelectedPage == rPReceive)
            {
                ChangeWindow(new FrmReceiveMain());
            }
            else if (ribbon.SelectedPage == rPStock)
            {
                ChangeWindow(new FrmStoreMain());
            }
            else if (ribbon.SelectedPage == rpTrans)
            {
                ChangeWindow(new FrmTransfer());
            }
            else if (ribbon.SelectedPage == rPQuery)
            {
                ChangeWindow(new FrmQueryMain());
            }
        }

        private void ChangeWindow(Form frm)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(frm);
            activeForm = frm;
            frm.Show();
        }

        private void Menu_ReceiveGoods_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmAddReceive().ShowDialog();
            (activeForm as FrmReceiveMain).RefreshData(1);
        }

        private void btnReturn_ItemClick(object sender, ItemClickEventArgs e)
        {
            (activeForm as FrmReceiveMain).ReturnGoods();
        }

        private void Menu_EditReceive_ItemClick(object sender, ItemClickEventArgs e)
        {
            (activeForm as FrmReceiveMain).ModifyGoods();
        }

        private void Menu_SendGoods_ItemClick(object sender, ItemClickEventArgs e)
        {
            (activeForm as FrmReceiveMain).SendGoods();
        }

        private void Menu_TransComp_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmTransCompany());
        }

        private void Menu_Input_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmStoreMain());
        }

        private void Menu_Output_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmStoreToKM().ShowDialog();
        }

        private void Menu_Trans_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmTransfer());
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Import_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "运单|*.xls;*.xlsx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                new FrmImport(fileDialog.FileName).ShowDialog();
                ChangeWindow(new FrmReceiveMain());
            }
        }

        private void Menu_GoodsType_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmStore());
        }

        private void MenuItem_ExportToStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            (activeForm as FrmReceiveMain).ExportToStock();
        }

        private void MenuItem_ExportToKM_ItemClick(object sender, ItemClickEventArgs e)
        {
            (activeForm as FrmStoreMain).ExportToKM();
        }

        private void Menu_Fee_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmFee());
        }

        private void Menu_Auth_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmFunctions());
        }

        private void MenuItem_StoreInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmStoreInfo());
        }

        private void Menu_ReceiveMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            (activeForm as FrmReceiveMain).ReceiveMoney();
        }

        private void Menu_BackToStore_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new Transfer.FrmBackBills()).ShowDialog();
            (activeForm as FrmTransfer).RefreshData();
        }

        private void Menu_BackToStore_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            (new Store.FrmBackBills()).ShowDialog();
            (activeForm as FrmStoreMain).RefreshData();
        }

        private void Menu_EditTrans_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Menu_ImportTransfer_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "转运单|*.xls;*.xlsx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                new FrmImportTrans(fileDialog.FileName,false).ShowDialog();
                ChangeWindow(new FrmTransfer());
            }
        }

        private void Menu_CountMoney_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmCountMoney());
        }

        private void Menu_BillQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmQueryMain());
        }

        private void Menu_Search_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void MenuItem_ChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmChangePassword().ShowDialog();
        }

        private void MenuItem_PayResult_ItemClick(object sender, ItemClickEventArgs e)
        {
            ChangeWindow(new FrmPayResult());
        }

        private void Menu_ExportQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            (activeForm as FrmQueryMain).Export();
        }

        private void Menu_ClearTrans_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "转运单|*.xls;*.xlsx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                new FrmImportTrans(fileDialog.FileName, true).ShowDialog();
                ChangeWindow(new FrmTransfer());
            }
        }

        private void Menu_ExportStockOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            ExcelOper.ExportStockOut();
        }
    }
}