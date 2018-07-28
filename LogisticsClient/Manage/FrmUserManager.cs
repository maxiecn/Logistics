using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logistics.Models;
using LogisticsClient.AppUtils;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Manage
{
    public partial class FrmUserManager : Form
    {
        public FrmUserManager()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            RefreshData();
        }

        private void RefreshData()
        {
            var storeDtos = WebCall.GetMethod<List<StoreDto>>("api/StoreInfo/get", null);
            var source = new List<string>();
            source.Add(DataConst.HEAD);
            foreach (var storeDto in storeDtos)
            {
                source.Add(storeDto.StoreName);
            }
            ((DataGridViewComboBoxColumn)dgUsers.Columns["storeNameDataGridViewTextBoxColumn"]).DataSource = source;

            var users = WebCall.GetMethod<List<UserDto>>("Users/get", null);
            dgUsers.DataSource = users;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            new FrmAddUser().ShowDialog();
            RefreshData();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {

            if (dgUsers.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_USER"));
                return;
            }
            else
            {
                int rowIndex = dgUsers.SelectedCells[0].RowIndex;
                UserDto userDto = new UserDto()
                {
                    UserID = Convert.ToInt32(dgUsers.Rows[rowIndex].Cells["userIDDataGridViewTextBoxColumn"].Value)
                };
                string str_result = WebCall.PostMethod<UserDto>("Users/ChangeEnable", userDto);
                WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(LangBase.GetString("MODIFY_SUCCESS"));
                    RefreshData();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }

        private void btnModify_Click(object sender, System.EventArgs e)
        {
            if (dgUsers.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_USER"));
                return;
            }
            else
            {
                int rowIndex = dgUsers.SelectedCells[0].RowIndex;
                UserDto userDto = new UserDto();
                userDto.UserID = Convert.ToInt16(dgUsers.Rows[rowIndex].Cells["userIDDataGridViewTextBoxColumn"].Value);
                userDto.UserName = dgUsers.Rows[rowIndex].Cells["userNameDataGridViewTextBoxColumn"].Value.ToString();
                userDto.LoginName = dgUsers.Rows[rowIndex].Cells["loginNameDataGridViewTextBoxColumn"].Value.ToString();
                userDto.StoreID = Convert.ToInt16(dgUsers.Rows[rowIndex].Cells["storeIDDataGridViewTextBoxColumn"].Value);
                userDto.StoreName = dgUsers.Rows[rowIndex].Cells["storeNameDataGridViewTextBoxColumn"].Value.ToString();
                new FrmAddUser(userDto).ShowDialog();
                RefreshData();
            }
        }

        private void btnResetPassword_Click(object sender, System.EventArgs e)
        {
            if (dgUsers.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_USER"));
                return;
            }
            else
            {
                int rowIndex = dgUsers.SelectedCells[0].RowIndex;
                UserDto userDto = new UserDto()
                {
                    UserID = Convert.ToInt32(dgUsers.Rows[rowIndex].Cells["userIDDataGridViewTextBoxColumn"].Value)
                };
                string str_result = WebCall.PostMethod<UserDto>("Users/ResetPassword", userDto);
                WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(LangBase.GetString("MODIFY_SUCCESS") + "," + LangBase.GetString("RND_USER_PASSWORD") +
                                    ":" + result.Message + "," + LangBase.GetString("HINT_MODIFY_PASSWORD"));
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }
    }
}