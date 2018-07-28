using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistics.Models;
using LogisticsAPI.Models;
using Model;
using Model.CallResult;
using Model.DefaultModels;
using Model.Dto;

namespace LogisticsAPI.Controllers.SendToStore
{
    public class SendController : Controller
    {
        public ActionResult GetGoodsToSend(int storeID)
        {
            using (var db = new LogisticsContext())
            {
                var Goods = from goods in db.T_Goods
                            join types in db.T_GoodsType on goods.GoodsType equals types.GoodsTypeID into tempa
                            from a in tempa.DefaultIfEmpty()
                            join priceinfo in db.T_PriceInfo on goods.PriceType equals priceinfo.PriceID into tempb
                            from b in tempb.DefaultIfEmpty()
                            join packages in db.T_PackingType on goods.PackingType equals packages.PackingTypeID into tempc
                            from c in tempc.DefaultIfEmpty()
                            join users in db.T_Users on goods.RecorderID equals users.UserID into tempd
                            from d in tempd.DefaultIfEmpty()
                            join transcomps in db.T_TransCompany on goods.TransCompID equals transcomps.TransCompanyID into
                                tempe
                            from e in tempe.DefaultIfEmpty()
                            join store in db.T_Store on goods.StoreID equals store.StoreID into tempf
                            from f in tempf.DefaultIfEmpty()
                            join transfer in db.T_Users on goods.TransRecoderID equals transfer.UserID into tempg
                            from g in tempg.DefaultIfEmpty()
                            join status in db.T_Status on goods.Status equals status.StatusID into temph
                            from h in temph.DefaultIfEmpty()
                            where h.StatusID == CommonConst.BILL_STATUS_RECEIVED
                            select new ReceiveBill
                            {
                                BillID = goods.BillID,
                                SenderName = goods.SenderName,
                                SenderTel = goods.SenderTel,
                                ReceiverName = goods.ReceiverName,
                                ReceiverTel = goods.ReceiverTel,
                                ReceiverAddress = goods.ReceiverAddress,
                                GoodsType = goods.GoodsType,
                                GoodsTypeName = a.GoodsTypeName,
                                Measure = goods.Measure,
                                Amount = goods.Amount,
                                PackingType = goods.PackingType,
                                PackingTypeName = c.PackingTypeName,
                                Price = goods.Price,
                                RecorderID = goods.RecorderID,
                                RecorderName = d.UserName,
                                RecordTime = goods.RecordTime,
                                TransCompID = goods.TransCompID,
                                TransCompName = e.TransCompanyName,
                                TransBill = goods.TransBill,
                                TransTime = goods.TransTime,
                                TransRecorderID = goods.TransRecoderID,
                                TransRecorderName = g.UserName,
                                ModifyTime = goods.ModifyTime,
                                StoreID = goods.StoreID,
                                StoreName = f.StoreName,
                                PriceType = goods.PriceType,
                                PriceTypeName = b.PriceName,
                                Status = goods.Status,
                                StatusName = h.StatusName
                            };
                var GoodsList = Goods.Where(a => a.StoreID == storeID).ToList();
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

        [HttpPost]
        public ActionResult SendToStore(List<string> billIdList)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = String.Empty
            };
            try
            {
                using (var db = new LogisticsContext())
                {
                    var maxbill = db.T_GoodsTrans.Select(ez => ez.BillID).Max();
                    var trans = new T_GoodsTrans();
                    var today = DateTime.Now.ToString("yyyyMMdd");
                    if (maxbill != null && maxbill.Contains(today))
                        trans.BillID = (Convert.ToInt64(maxbill) + 1).ToString();
                    else
                    {
                        trans.BillID = today + "0001";
                    }

                    trans.RecorderID = 1;
                    trans.RecordTime = DateTime.Now;

                    db.T_GoodsTrans.Add(trans);

                    for (var i = 0; i < billIdList.Count; i++)
                    {
                        var detail = new T_GoodsTransDetail();
                        detail.BillID = trans.BillID;
                        detail.GoodsID = billIdList[i];
                        db.T_GoodsTransDetail.Add(detail);

                        var transDetail = new T_TransRecord
                        {
                            BillID = detail.GoodsID,
                            OperTime = DateTime.Now,
                            OperAction = "发往曼谷仓库"
                        };
                        db.T_TransRecord.Add(transDetail);

                        var goodsid = billIdList[i];
                        var goodIndb = db.T_Goods.FirstOrDefault(x => x.BillID == goodsid);
                        goodIndb.Status = CommonConst.BILL_STATUS_SEND;
                        db.Entry(goodIndb).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Message = trans.BillID;
                    return Content(AppUtils.JsonSerializer(result));
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        public ActionResult GetAllGoods(int storeID)
        {
            using (var db = new LogisticsContext())
            {
                var Goods = (from goods in db.T_Goods
                            join types in db.T_GoodsType on goods.GoodsType equals types.GoodsTypeID into tempa
                            from a in tempa.DefaultIfEmpty()
                            join priceinfo in db.T_PriceInfo on goods.PriceType equals priceinfo.PriceID into tempb
                            from b in tempb.DefaultIfEmpty()
                            join packages in db.T_PackingType on goods.PackingType equals packages.PackingTypeID into tempc
                            from c in tempc.DefaultIfEmpty()
                            join users in db.T_Users on goods.RecorderID equals users.UserID into tempd
                            from d in tempd.DefaultIfEmpty()
                            join transcomps in db.T_TransCompany on goods.TransCompID equals transcomps.TransCompanyID into
                                tempe
                            from e in tempe.DefaultIfEmpty()
                            join store in db.T_Store on goods.StoreID equals store.StoreID into tempf
                            from f in tempf.DefaultIfEmpty()
                            join transfer in db.T_Users on goods.TransRecoderID equals transfer.UserID into tempg
                            from g in tempg.DefaultIfEmpty()
                            join status in db.T_Status on goods.Status equals status.StatusID into temph
                            from h in temph.DefaultIfEmpty()
                            join paytype in db.T_PayType on goods.PayType equals paytype.PayID into tempi
                            from i in tempi.DefaultIfEmpty()
                            join moneyreceiver in db.T_Users on goods.MoneyReceiver equals moneyreceiver.UserID into tempj
                            from j in tempj.DefaultIfEmpty()
                            select new ReceiveBill
                            {
                                BillID = goods.BillID,
                                Password = goods.Password,
                                SenderName = goods.SenderName,
                                SenderTel = goods.SenderTel,
                                ReceiverName = goods.ReceiverName,
                                ReceiverTel = goods.ReceiverTel,
                                ReceiverAddress = goods.ReceiverAddress,
                                GoodsType = goods.GoodsType,
                                GoodsTypeName = a.GoodsTypeName,
                                Measure = goods.Measure,
                                Amount = goods.Amount,
                                PackingType = goods.PackingType,
                                PackingTypeName = c.PackingTypeName,
                                Price = goods.Price,
                                RecorderID = goods.RecorderID,
                                RecorderName = d.UserName,
                                RecordTime = goods.RecordTime,
                                TransCompID = goods.TransCompID,
                                TransCompName = goods.TransCompName,
                                TransBill = goods.TransBill == null ? "" : goods.TransBill,
                                TransTime = goods.TransTime == null ? DateTime.MinValue : goods.TransTime,
                                TransRecorderID = goods.TransRecoderID == null ? 0 : goods.TransRecoderID,
                                TransRecorderName = g.UserName,
                                ModifyTime = goods.ModifyTime,
                                StoreID = goods.StoreID,
                                StoreName = f.StoreName,
                                PriceType = goods.PriceType,
                                PriceTypeName = b.PriceName,
                                Status = goods.Status,
                                StatusName = h.StatusName,
                                PayType = i.PayID,
                                PayTypeName = i.PayName,
                                Remark = goods.Remark,
                                ChinaPrice = goods.ChinaPrice,
                                PackingPrice = goods.PackingPrice,
                                InsurancePrice = goods.InsurancePrice,
                                SumPrice = goods.SumPrice,
                                hasReceiveMoney = goods.hasReceiveMoney,
                                MoneyReceiver = goods.MoneyReceiver,
                                MoneyReceiverName = j.UserName,
                                UnitPrice = goods.UnitPrice,
                                MoneyReceiveTime = goods.MoneyReceiveTime == null ? DateTime.MinValue : goods.MoneyReceiveTime,
                                MoneyReceiveRemark = goods.MoneyRemark,
                            }).Where(a => a.Status.Equals(CommonConst.BILL_STATUS_STOCKIN));
                List<ReceiveBill> GoodsList;
                if (storeID == 0)
                    GoodsList = Goods.ToList();
                else
                    GoodsList = Goods.Where(a => a.StoreID == storeID).ToList();
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

    }
}
