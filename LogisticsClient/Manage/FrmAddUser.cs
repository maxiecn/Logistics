using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Manage
{
    public partial class FrmAddUser : Form
    {
        private int userID = 0;
        private bool isModify = false;
        public FrmAddUser()
        {
            InitializeComponent();
            initStores();
        }

        public FrmAddUser(UserDto user)
        {
            InitializeComponent();
            initStores();
            userID = user.UserID;
            txtUserName.Text = user.UserName;
            txtLoginName.Text = user.LoginName;
            txtLoginName.Enabled = false;
            cbxStore.Text = user.StoreName;
            isModify = true;
        }

        private void initStores()
        {
            var storeDtos = WebCall.GetMethod<List<StoreDto>>("api/StoreInfo/get", null);
            cbxStore.Items.Add(new StoreDto
            {
                StoreID = 0,
                StoreName = DataConst.HEAD
            });
            foreach (var storeDto in storeDtos)
            {
                cbxStore.Items.Add(storeDto);
            }
            cbxStore.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Equals(string.Empty) || txtLoginName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(LangBase.GetString("VALID_INFO_ADD_COMPANY"));
                return;
            }

            if (isModify)
            {
                UserDto userDto = new UserDto()
                {
                    UserID = userID,
                    UserName = txtUserName.Text.Trim(),
                    StoreID = (cbxStore.SelectedItem as StoreDto).StoreID
                };
                string str_result = WebCall.PostMethod<UserDto>("Users/ModifyUser", userDto);
                WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(LangBase.GetString("MODIFY_SUCCESS"));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
            else
            {
                UserDto userDto = new UserDto()
                {
                    UserName = txtUserName.Text.Trim(),
                    LoginName = txtLoginName.Text.Trim(),
                    StoreID = (cbxStore.SelectedItem as StoreDto).StoreID
                };
                string str_result = WebCall.PostMethod<UserDto>("Users/AddNewUser", userDto);
                WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(LangBase.GetString("ADD_SUCCESS") + "," + LangBase.GetString("RND_USER_PASSWORD") +
                                    ":" + result.Message + "," + LangBase.GetString("HINT_MODIFY_PASSWORD"));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }
    }
}
