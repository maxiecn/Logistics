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

            var goodsTax = Tax.GetAll();
            dgTax.DataSource = goodsTax;
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

        private void btnAddTax_Click(object sender, EventArgs e)
        {
            new FrmAddTax().ShowDialog();
            ReloadData();
        }

        private void dgTax_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            ModifyTax();
        }

        private void ModifyTax()
        {
            if (dgTax.SelectedCells.Count == 0)
            {
                MessageBox.Show(LangBase.GetString("NOT_SELECT_TAX"));
                return;
            }
            else
            {
                int rowIndex = dgTax.SelectedCells[0].RowIndex;
                TaxDto modifyTaxDto = new TaxDto();
                modifyTaxDto.GoodsID = Convert.ToInt16(dgTax.Rows[rowIndex].Cells["GoodsID"].Value);
                modifyTaxDto.GoodsName = dgTax.Rows[rowIndex].Cells["GoodsName"].Value.ToString();
                modifyTaxDto.Price = Convert.ToInt16(dgTax.Rows[rowIndex].Cells["Price"].Value);
                modifyTaxDto.TaxRate = Convert.ToInt16(dgTax.Rows[rowIndex].Cells["TaxRate"].Value);
                FrmAddTax fmodify = new FrmAddTax(modifyTaxDto);
                fmodify.ShowDialog();
                ReloadData();
            }
        }
    }
}
