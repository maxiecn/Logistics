using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.About;
using Logistics.Models;
using LogisticsClient.AppUtils;
using LogisticsClient.BaseData;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsClient.Receive
{
    public partial class FrmImport : Form
    {
        private string filename;
        private List<ImportInfo> infos = null;

        public FrmImport(String file)
        {
            InitializeComponent();
            filename = file;
            infos = ExcelOper.ImportExcel(file);
            dgImport.DataSource = infos;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, Lang.LangBase.GetString("CONFIRM_IMPORT"), "", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                var goods = GoodsType.GetAll();
                var priceInfos = PriceInfo.GetAll();
                var packingTypes = PackingType.GetAll();
                var payTypes = PayType.GetAll();
                var transCompanies = TransCompany.GetAll();

                int billMax = 20;

                List<ReceiveDto> receiveDtos = new List<ReceiveDto>();
                foreach (var importInfo in infos)
                {
                    int goodsTypeID = 0;
                    foreach (var goodsType in goods)
                    {
                        if (goodsType.GoodsTypeName.Equals(importInfo.goodsTypeName))
                        {
                            goodsTypeID = goodsType.GoodsTypeID;
                            break;
                        }
                    }

                    //int priceTypeID = 0;
                    //foreach (PriceInfoDto priceInfo in priceInfos)
                    //{
                    //    if (priceInfo.PriceName.Equals(importInfo.priceType))
                    //    {
                    //        priceTypeID = priceInfo.PriceID;
                    //        break;
                    //    }
                    //}

                    int packingTypeID = 0;
                    foreach (var packingType in packingTypes)
                    {
                        if (packingType.PackingTypeName.Equals(importInfo.packingtypeName))
                        {
                            packingTypeID = packingType.PackingTypeID;
                            break;
                        }
                    }

                    int transCompID = 0;
                    foreach (var transCompany in transCompanies)
                    {
                        if (transCompany.TransCompName.Equals(importInfo.tranCompName))
                        {
                            transCompID = transCompany.TransID;
                            break;
                        }
                    }

                    int payTypeID = 0;
                    foreach (var payType in payTypes)
                    {
                        if (payType.PayName.Equals(importInfo.paytypeName))
                        {
                            payTypeID = payType.PayID;
                            break;
                        }
                    }

                    float measure = 0;
                    try
                    {
                        measure = Convert.ToSingle(importInfo.measure);
                    }
                    catch (Exception)
                    {
                        measure = 0;
                    }

                    int price = 0;
                    try
                    {
                        price = Convert.ToInt32(importInfo.price);
                    }
                    catch (Exception)
                    {
                        price = 0;
                    }

                    int amount = 0;
                    try
                    {
                        amount = Convert.ToInt32(importInfo.amount);
                    }
                    catch (Exception)
                    {
                        amount = 0;
                    }

                    int chinaPrice = 0;
                    try
                    {
                        chinaPrice = Convert.ToInt32(importInfo.chinaprice);
                    }
                    catch (Exception)
                    {
                        chinaPrice = 0;
                    }

                    int packingPrice = 0;
                    try
                    {
                        packingPrice = Convert.ToInt32(importInfo.packingprice);
                    }
                    catch (Exception)
                    {
                        packingPrice = 0;
                    }

                    int insurance = 0;
                    try
                    {
                        insurance = Convert.ToInt32(importInfo.insurance);
                    }
                    catch (Exception)
                    {
                        insurance = 0;
                    }

                    int sum = 0;
                    try
                    {
                        sum = Convert.ToInt32(importInfo.sumprice);
                    }
                    catch (Exception)
                    {
                        sum = 0;
                    }

                    ReceiveDto rd = new ReceiveDto
                    {
                        StoreID = Configure.StoreID,
                        RecorderID = Configure.UserID,
                        SenderName = importInfo.senderName,
                        SenderTel = importInfo.senderTel,
                        ReceiverName = importInfo.receiverName,
                        ReceiverTel = importInfo.receiverTel,
                        ReceiverAddress = importInfo.receiverAddress,
                        GoodsType = goodsTypeID,
                        Measure = measure,
                        UnitPrice =
                            Convert.ToInt32(importInfo.unitPrice.Trim().Equals(string.Empty)
                                ? "0"
                                : importInfo.unitPrice),
                        PackingType = packingTypeID,
                        Price = price,
                        Amount = amount,
                        PayType = payTypeID,
                        Remark = importInfo.remark,
                        ChinaPrice = chinaPrice,
                        PackingPrice = packingPrice,
                        InsurancePrice = insurance,
                        SumPrice = sum,
                        TransID = transCompID,
                        TransName = importInfo.tranCompName,
                        GoodsName = importInfo.goodsname
                    };
                    receiveDtos.Add(rd);
                }


                int hasResolve = 0;
                List<ReceiveDto> solveBills = new List<ReceiveDto>();

                if (receiveDtos.Count <= billMax)
                {
                    for (int i = hasResolve; i < receiveDtos.Count; i++)
                    {
                        solveBills.Add(receiveDtos[i]);
                    }
                    uploadBills(solveBills);
                }
                else
                {
                    for (int i = 0; i < receiveDtos.Count; i++)
                    {
                        solveBills.Add(receiveDtos[i]);
                        if ((i + 1)%billMax == 0)
                        {
                            uploadBills(solveBills);
                            solveBills.Clear();
                        }
                    }
                    if (solveBills.Count > 0)
                        uploadBills(solveBills);
                }
            }
        }

        private void uploadBills(List<ReceiveDto> solveBills)
        {
            string str_result = WebCall.PostMethod<List<ReceiveDto>>("receive/ImportGoods", solveBills);
            ImportNewGoodsResult result = AppUtils.AppUtils.JsonDeserialize<ImportNewGoodsResult>(str_result);
            if (result.Code.Equals(SystemConst.MSG_SUCCESS))
            {
                string msg = string.Empty;
                foreach (var querycondition in result.Data)
                {
                    msg += querycondition.BillID + ":" + querycondition.Password + "\n";
                }
                MessageBox.Show(msg);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
