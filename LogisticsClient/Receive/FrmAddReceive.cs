using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Logistics.Models;
using LogisticsClient.AppUtils;
using LogisticsClient.BaseData;
using LogisticsClient.Lang;
using Model;
using Model.CallResult;
using Model.DefaultModels;
using Model.Dto;
using System.IO;

namespace LogisticsClient.Receive
{
    public partial class FrmAddReceive : Form
    {
        public bool isModify = false;
        private string ModifyID = string.Empty;
        private ListBox hintWindow = null;
        private List<HintInputDto> _hints;

        public bool couldModify { get; set; }

        public List<HintInputDto> hints
        {
            get { return _hints; }
            set
            {
                _hints = value;
                hintWindow.Items.Clear();
                foreach (var good in _hints)
                {
                    hintWindow.Items.Add(good.SenderName + "/" +
                                        good.SenderTel + "/" +
                                        good.ReceiverName + "/" +
                                        good.ReceiverTel + "/" +
                                        good.ReceiverAddress);
                }

                if (hintWindow.Items.Count != 0)
                {
                    hintWindow.Top = txtSenderName.Top + txtSenderName.Height;
                    hintWindow.Left = txtSenderName.Left;
                    hintWindow.AutoSize = true;
                    hintWindow.Visible = true;
                }
                else
                {
                    hintWindow.Visible = false;
                }
            }
        }

        public FrmAddReceive()
        {
            InitializeComponent();
            InitBase();
        }

        public FrmAddReceive(ReceiveDto receive)
        {
            InitializeComponent();
            InitBase();
            isModify = true;

            DateTime dt = DateTime.Now.AddDays(-7);
            this.couldModify = receive.RecordTime > dt;

            if (AppUtils.AppUtils.HasAuth("RECEIVE_FOREVERMODIFY") || (couldModify))
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }

            btnAdd.Text = LangBase.GetString("BUTTON_MODIFY");

            ModifyID = receive.BillID;
            txtSenderName.Text = receive.SenderName;
            txtSenderTel.Text = receive.SenderTel;
            txtReceiverName.Text = receive.ReceiverName;
            txtReceiverAddress.Text = receive.ReceiverAddress;
            txtReceiverTel.Text = receive.ReceiverTel;
            txtMeasure.Text = receive.Measure.ToString();
            txtRemark.Text = receive.Remark;
            numAmount.Value = receive.Amount;
            txtChinaPrice.Text = receive.ChinaPrice.ToString();
            txtInsurance.Text = receive.InsurancePrice.ToString();
            txtPackingPrice.Text = receive.PackingPrice.ToString();
            txtSum.Text = receive.SumPrice.ToString();
            txtUnitPrice.Text = receive.UnitPrice.ToString();
            txtGoodsName.Text = receive.GoodsName;
            txtBillFee.Text = receive.BillFee.ToString();
            txtPrice.Text = receive.Price.ToString();
            txtIdCard.Text = receive.IdCard;
            txtCIQPrice.Text = receive.CIQPrice.ToString();
            txtTaxPrice.Text = receive.TaxPrice.ToString();
            txtTaxRate.Text = receive.TaxRate.ToString();
            txtDetail.Text = receive.Detail;
            txtCIQAddress.Text = receive.CIQAddress;
            btnCardFront.Tag = receive.IdCardFront;
            ShowPic(btnCardFront, btnCardFront.Tag.ToString());
            btnCardBack.Tag = receive.IdCardBack;
            ShowPic(btnCardBack, btnCardBack.Tag.ToString());

            foreach (var goodstypes in cbxGoodsType.Items)
            {
                if ((goodstypes as GoodsTypeDto).GoodsTypeID == receive.GoodsType)
                    cbxGoodsType.SelectedItem = goodstypes;
            }

            foreach (var price in cbxPriceType.Items)
            {
                if ((price as PriceInfoDto).PriceID == receive.PriceType)
                    cbxPriceType.SelectedItem = price;
            }

            foreach (var packing in cbxPackingType.Items)
            {
                if ((packing as T_PackingType).PackingTypeID == receive.PackingType)
                    cbxPackingType.SelectedItem = packing;
            }

            foreach (var paytype in cbxPayType.Items)
            {
                if ((paytype as T_PayType).PayID == receive.PayType)
                    cbxPayType.SelectedItem = paytype;
            }
            //cbxPayType.Enabled = false;
            //chkHasReceiveMoney.Checked = receive.hasReceiveMoney;
            chkHasReceiveMoney.Enabled = cbxPayType.Text.Equals("汇款");
            //chkHasReceiveMoney.Checked = cbxPayType.Text.Equals("现金");
            chkHasReceiveMoney.Checked = receive.hasReceiveMoney;

            //chkHasReceiveMoney.Enabled = false;

            //foreach (var trans in cbxTrans.Items)
            //{
            //    if ((trans as TransCompDto).TransID == receive.TransID)
            //        cbxTrans.SelectedItem = trans;
            //}
            cbxTrans.Text = receive.TransName;
        }

        private void ShowPic(Button btn, String pic)
        {
            if (pic == null)
                return;
            if (!pic.Equals(string.Empty))
            {
                Stream picSteam = WebCall.GetPic(pic);
                btn.BackgroundImage = Image.FromStream(picSteam);
                picSteam.Close();
            }
        }

        private void InitBase()
        {
            var goods = GoodsType.GetAll();
            cbxGoodsType.DataSource = goods;

            var priceInfos = PriceInfo.GetAll();
            cbxPriceType.DataSource = priceInfos;
            string default_pt = Configure.configure().load("default_pt");
            if (default_pt != "")
            {
                int selectIndex = Convert.ToInt16(default_pt);
                if (selectIndex < cbxPriceType.Items.Count)
                    cbxPriceType.SelectedIndex = selectIndex;
            }

            var packingTypes = PackingType.GetAll();
            cbxPackingType.DataSource = packingTypes;

            var payTypes = PayType.GetAll();
            cbxPayType.DataSource = payTypes;
            if (cbxPayType.Items.Count != 0)
                cbxPayType.SelectedIndex = 0;

            var transCompanies = TransCompany.GetAll();
            foreach (TransCompDto transCompany in transCompanies)
            {
                cbxTrans.Items.Add(transCompany);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AppUtils.AppUtils.CheckText(txtSenderName, "NoSender"))
                return;

            if (!AppUtils.AppUtils.CheckText(txtSenderTel, "NoSenderTel"))
                return;

            if (!AppUtils.AppUtils.CheckText(txtReceiverName, "NoReceiver")) return;

            if (!AppUtils.AppUtils.CheckText(txtReceiverTel, "NoReceiverTel"))
                return;

            if (!AppUtils.AppUtils.CheckText(txtReceiverAddress, "NoReceiverAddr"))
                return;

            if (!AppUtils.AppUtils.CheckText(cbxGoodsType, "NoGoodsType"))
                return;

            if (cbxTrans.Text.Equals(string.Empty))
            {
                MessageBox.Show("没有选择转运公司");
                return;
            }

            if (txtMeasure.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(LangBase.GetString("NoVolumeOrWeight"));
                return;
            }

            //if (!CheckText(cbxPriceType, "NoPriceType"))
            //    return;
            if (txtUnitPrice.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(LangBase.GetString("NoUnitPrice"));
            }

            if (!AppUtils.AppUtils.CheckText(cbxPackingType, "NoPackingType"))
                return;

            if (!AppUtils.AppUtils.CheckText(txtPrice, "NoPrice"))
                return;

            FillEmptyText(txtMeasure);
            FillEmptyText(txtChinaPrice);
            FillEmptyText(txtPackingPrice);
            FillEmptyText(txtInsurance);
            FillEmptyText(txtBillFee);
            FillEmptyText(txtCIQPrice);
            FillEmptyText(txtTaxRate);
            FillEmptyText(txtTaxPrice);

            ReceiveDto rd = new ReceiveDto
            {
                StoreID = Configure.StoreID,
                RecorderID = Configure.UserID,
                SenderName = txtSenderName.Text,
                SenderTel = txtSenderTel.Text,
                ReceiverName = txtReceiverName.Text,
                ReceiverTel = txtReceiverTel.Text,
                ReceiverAddress = txtReceiverAddress.Text,
                GoodsType = (cbxGoodsType.SelectedItem as GoodsTypeDto).GoodsTypeID,
                GoodsName = txtGoodsName.Text.Trim().Equals(string.Empty)?cbxGoodsType.Text:txtGoodsName.Text.Trim(),
                Measure = Convert.ToSingle(txtMeasure.Text),
                PriceType = (cbxPriceType.SelectedItem as PriceInfoDto).PriceID,
                PackingType = (cbxPackingType.SelectedItem as T_PackingType).PackingTypeID,
                Price = Convert.ToInt32(txtPrice.Text),
                Amount = Convert.ToInt16(numAmount.Value),
                PayType = (cbxPayType.SelectedItem as T_PayType).PayID,
                Remark = txtRemark.Text,
                UnitPrice = Convert.ToInt32(txtUnitPrice.Text),
                ChinaPrice = Convert.ToInt32(txtChinaPrice.Text),
                PackingPrice = Convert.ToInt32(txtPackingPrice.Text),
                InsurancePrice = Convert.ToInt32(txtInsurance.Text),
                SumPrice = Convert.ToInt32(txtSum.Text),
                TransID = cbxTrans.SelectedIndex == -1 ? 0 : (cbxTrans.SelectedItem as TransCompDto).TransID,
                TransName = cbxTrans.Text,
                hasReceiveMoney = chkHasReceiveMoney.Checked,
                MoneyReceiver = Configure.UserID,
                BillFee = Convert.ToInt32(txtBillFee.Text),
                IdCard = txtIdCard.Text,
                CIQPrice = Convert.ToInt16(txtCIQPrice.Text),
                TaxPrice = Convert.ToInt16(txtTaxPrice.Text),
                TaxRate = Convert.ToInt16(txtTaxRate.Text),
                CIQAddress = txtCIQAddress.Text,
                IdCardFront = btnCardFront.Tag.ToString(),
                IdCardBack = btnCardBack.Tag.ToString(),
                Detail = txtDetail.Text
            };

            Configure.configure().save("default_pt",cbxPriceType.SelectedIndex.ToString());
            
            if (isModify)
            {
                rd.BillID = ModifyID;
                string str_result = WebCall.PostMethod<ReceiveDto>("receive/ModifyGoods", rd);
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
                string str_result = WebCall.PostMethod<ReceiveDto>("receive/AddGoods", rd);
                AddNewGoodsResult result = AppUtils.AppUtils.JsonDeserialize<AddNewGoodsResult>(str_result);
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    MessageBox.Show(LangBase.GetString("ADD_SUCCESS"));
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }

       

        private void txtVolumn_TextChanged(object sender, EventArgs e)
        {
            CaluPrice();
        }

        private void CaluPrice()
        {
            //if (cbxPriceType.SelectedIndex == -1)
            //return;

            //var priceInfo = cbxPriceType.SelectedItem as PriceInfoDto;

            if (txtUnitPrice.Text.Trim().Equals(string.Empty))
                return;


            if (txtMeasure.Text.Equals(string.Empty))
            {
                txtPrice.Text = string.Empty;
                return;
            }

            int billfee = emptyPrice(txtBillFee);

            txtPrice.Text = (Math.Ceiling(Convert.ToDouble(txtMeasure.Text))*Convert.ToInt32(txtUnitPrice.Text) + billfee).ToString();

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            CaluPrice();
        }

        private void cbxPriceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CaluPrice();
            if (cbxPriceType.SelectedIndex==-1)
                return;
            var priceInfo = cbxPriceType.SelectedItem as PriceInfoDto;
            txtUnitPrice.Text = priceInfo.UnitPrice.ToString();
        }

        private void FillEmptyText(TextBox tb)
        {
            string sum = txtSum.Text;
            if (tb.Text.Trim().Equals(String.Empty))
            {
                tb.Text = "0";
            }
            txtSum.Text = sum;
        }


        private void txtVolumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char) Keys.Back ||
                e.KeyChar == (char) Keys.Delete)
            {
                e.Handled = false; //让操作生效     
                int j = 0; //记录小数点个数  
                int k = 0; //记录小数位数  
                int dotloc = -1; //记录小数点位置  
                bool flag = false; //如果有小数点就让flag值为true  
                //  
                //去除首位是0的判断，因为我们不知道用户的意图，或许ta下次要在小数点前面输入数字。  
                /* 
        if (textBox1.Text.Length == 0) 
        { 
            if (e.KeyChar == '.') 
            { 
                e.Handled = true; 
            } 
        } 
        */
                //  
                for (int i = 0; i < textBox.Text.Length; i++)
                {
                    if (textBox.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                        dotloc = i;
                    }

                    if (flag)
                    {
                        if (char.IsNumber(textBox.Text[i]) && e.KeyChar != (char) Keys.Back &&
                            e.KeyChar != (char) Keys.Delete)
                        {
                            k++;
                        }
                    }

                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            if (textBox.SelectedText.IndexOf('.') == -1)
                                e.Handled = true; //输入“.”，选取部分没有“.”操作失效  
                        }
                    }

                    if (!flag) //此处控制没有小数点时添加小数点是否满足两位小数的情况  
                    {
                        if (e.KeyChar == '.')
                        {
                            if (textBox.Text.Length - textBox.SelectionStart - textBox.SelectedText.Length > 2)
                                //the condition also can be instead of "textBox1.Text.Substring(textBox1.SelectionStart).Length-textBox1.SelectionLength>2"   
                                e.Handled = true;
                        }
                    }

                    if (k == 2)
                    {
                        if (textBox.SelectionStart > textBox.Text.IndexOf('.') && textBox.SelectedText.Length == 0 &&
                            e.KeyChar != (char) Keys.Delete && e.KeyChar != (char) Keys.Back) //如果已经有两位小数，光标在小数点右边，  
                            e.Handled = true;
                    }
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar < '0' || e.KeyChar > '9')
                    e.Handled = true;}
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            CaluSumPrice();
        }

        private void CaluSumPrice()
        {
            int price, china, insurance, packing, tax;
            price = emptyPrice(txtPrice);
            china = emptyPrice(txtChinaPrice);
            insurance = emptyPrice(txtInsurance);
            packing = emptyPrice(txtPackingPrice);
            tax = emptyPrice(txtTaxPrice);
            txtSum.Text = (price + china + insurance + packing + tax).ToString();
        }

        private int emptyPrice(TextBox tb)
        {
            return tb.Text.Trim().Equals(string.Empty) ? 0 : Convert.ToInt32(tb.Text);
        }

        void hintWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && hintWindow.SelectedIndex == 0)
            {
                hintWindow.ClearSelected();
                txtSenderName.Focus();
            }

            if (e.KeyCode  == Keys.Space && hintWindow.SelectedIndex != -1)
            {
                HintInputDto hintInput = hints[hintWindow.SelectedIndex];
                txtSenderName.Text = hintInput.SenderName;
                txtSenderTel.Text = hintInput.SenderTel;
                txtReceiverName.Text = hintInput.ReceiverName;
                txtReceiverTel.Text = hintInput.ReceiverTel;
                txtReceiverAddress.Text = hintInput.ReceiverAddress;

                //选完后清空
                hints.Clear();
                hintWindow.Items.Clear();
                hintWindow.Visible = false;
            }
        }

        private void txtSenderName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && hintWindow.Visible)
            {
                hintWindow.Focus();
            }
        }

        private void btnAssistant_Click(object sender, EventArgs e)
        {
            FrmAssitant frmAssitant = new FrmAssitant();
            if (frmAssitant.ShowDialog()==DialogResult.Yes)
            {
                HintInputDto hint = frmAssitant.ResultDto;
                txtSenderName.Text = hint.SenderName;
                txtSenderTel.Text = hint.SenderTel;
                txtReceiverName.Text = hint.ReceiverName;
                txtReceiverTel.Text = hint.ReceiverTel;
                txtReceiverAddress.Text = hint.ReceiverAddress;
                cbxTrans.Text = hint.TransCompName;
            }
        }

        private void cbxPayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkHasReceiveMoney.Enabled = cbxPayType.Text.Equals("汇款");
            chkHasReceiveMoney.Checked = cbxPayType.Text.Equals("现金");
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CaluPrice();
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSum_KeyPress(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(txtBillFee.Text.Trim().Equals(string.Empty) || txtBillFee.Text.Trim().Equals("0"));
        }

        private void txtCIQPrice_TextChanged(object sender, EventArgs e)
        {
            if (!txtCIQPrice.Text.Trim().Equals("") && !txtTaxRate.Text.Trim().Equals(""))
            {
                double price = Convert.ToInt16(txtCIQPrice.Text) * Convert.ToInt32(txtTaxRate.Text) / 100;
                txtTaxPrice.Text = Math.Ceiling(price).ToString();
            }
            else
            {
                txtTaxPrice.Text = "0";
            }
        }

        private void txtTaxPrice_TextChanged(object sender, EventArgs e)
        {
            CaluSumPrice();
        }

        private void btnCardFront_Click(object sender, EventArgs e)
        {
            Button btnPic = sender as Button;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var result = AppUtils.AppUtils.JsonDeserialize<WebResult>(WebCall.UploadFile(openFileDialog.FileName));
                if (result.Code.Equals(SystemConst.MSG_SUCCESS))
                {
                    btnPic.Tag = result.Message;
                    btnPic.BackgroundImage = Image.FromFile(openFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
        }

        private void lblToggle_Click(object sender, EventArgs e)
        {
            pnlCIQ.Visible = !pnlCIQ.Visible;
            this.Width = pnlCIQ.Visible ? 1267 : 906;
        }
    }
}