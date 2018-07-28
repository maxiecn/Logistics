using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogisticsClient.AppUtils;
using LogisticsClient.BaseData;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Manage
{
    public partial class FrmStore : Form
    {
        public FrmStore()
        {
            InitializeComponent();
            AppUtils.AppUtils.ResolveForm(this);
            ReloadData();
        }

        private void ReloadData()
        {
            var goodstypes = GoodsType.GetAll();
            dgTypes.DataSource = goodstypes;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmInput input = new FrmInput();
            input.InfoName = Lang.LangBase.GetString("NEW_GOODSTYPE");
            input.ShowDialog();

            if (input.info.Trim().Equals(string.Empty))
            {
                return;
            }

            GoodsTypeDto goodsTypeDto = new GoodsTypeDto()
            {
                GoodsTypeName = input.info.Trim()
            };
            string str_result = WebCall.PostMethod<GoodsTypeDto>("api/GoodsType", goodsTypeDto);
            WebResult result = AppUtils.AppUtils.JsonDeserialize<WebResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                MessageBox.Show(LangBase.GetString("ADD_SUCCESS"));
                ReloadData();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
