using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting.Native;
using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePwd()
        {
            if (txtPassword.Text.IsEmpty() || !txtPassword.Text.Equals(txtPasswordR.Text))
            {
                MessageBox.Show(LangBase.GetString("INVALID_PASSWORD"));
                return;
            }

            UserDto userDto = new UserDto()
            {
                UserID = Configure.UserID,
                Password = txtPassword.Text
            };
            string str_result = WebCall.PostMethod<UserDto>("Users/ChangePassword", userDto);
            WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                MessageBox.Show(LangBase.GetString("MODIFY_SUCCESS"));
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ChangePwd();
        }
    }
}
