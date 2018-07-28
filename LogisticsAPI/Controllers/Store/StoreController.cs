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

namespace LogisticsAPI.Controllers.Store
{
    public class StoreController : Controller
    {
        public ActionResult GetBills()
        {
            using (var db = new LogisticsContext())
            {
                var billlist = from j in db.T_GoodsTrans
                    join u in db.T_Users on j.RecorderID equals u.UserID into temp
                    from a in temp
                    select new SendBill
                    {
                        BillID = j.BillID,
                        RecorderID = j.RecorderID,
                        RecorderName = a.UserName,
                        CreateTime = j.RecordTime
                    };
                var result = new List<SendBill>();
                var transdetails = db.T_GoodsTransDetail.ToList();

                foreach (var sendBill in billlist)
                {
                    if (transdetails.Where(a => a.BillID == sendBill.BillID && a.GoodsStatu == null).ToList().Count != 0)
                        result.Add(sendBill);
                }

                return Content(AppUtils.JsonSerializer(result));
            }
        }

        public ActionResult GetBillDetail(string billid)
        {
            using (var db = new LogisticsContext())
            {
                var goodsList = db.T_GoodsTransDetail.Where(a => a.BillID == billid && a.GoodsStatu == null).ToList();
                return Content(AppUtils.JsonSerializer(goodsList.ToList()));
            }
        }

        [HttpPost]
        public ActionResult StoreIn(StockInParam stockInParam)
        {
            StockInBaseInfo baseInfo = stockInParam.baseInfo;
            List<string> billList = stockInParam.billList;
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = String.Empty
            };
            try
            {
                using (var db = new LogisticsContext())
                {
                    var bills =
                        db.T_GoodsTransDetail.Where(a => a.BillID == baseInfo.TransID && billList.Contains(a.GoodsID));
                    
                    foreach (T_GoodsTransDetail detail in bills)
                    {
                        detail.ReceiverID = baseInfo.ReceiverID;
                        detail.GoodsStatu = CommonConst.BILL_STATUS_STOCKIN;
                        detail.ReceiveTime = DateTime.Now;
                        db.Entry(detail).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();

                    var goods = db.T_Goods.Where(a => billList.Contains(a.BillID));
                    foreach (var good in goods)
                    {
                        good.Status = CommonConst.BILL_STATUS_STOCKIN;
                        db.Entry(good).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();

                    result.Code = SystemConst.MSG_SUCCESS;
                    return Content(AppUtils.JsonSerializer(result));
                }
            }catch (Exception exception)
            {
                result.Message = exception.Message;
            }return Content(AppUtils.JsonSerializer(result));
        }

        public ActionResult StoreToSend()
        {
            using (var db = new LogisticsContext())
            {
                var Goods = from goods in db.T_Goods
                    join types in db.T_GoodsType on goods.GoodsType equals types.GoodsTypeID into tempa
                    from a in tempa.DefaultIfEmpty()
                    where goods.Status == CommonConst.BILL_STATUS_STOCKIN
                    select new ReceiveBill
                    {
                        BillID = goods.BillID,
                        GoodsType = goods.GoodsType,
                        GoodsTypeName = a.GoodsTypeName,
                        Amount = goods.Amount,
                    };
                var GoodsList = Goods.ToList();
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

        public ActionResult SendToKM(List<string> billIdList)
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
                    var maxbill = db.T_TransToKM.Select(ez => ez.BillID).Max();
                    var trans = new T_TransToKM();
                    var today = DateTime.Now.ToString("yyyyMMdd");
                    if (maxbill != null && maxbill.Contains(today))
                        trans.BillID = (Convert.ToInt64(maxbill) + 1).ToString();
                    else
                    {
                        trans.BillID = today + "0001";
                    }

                    trans.RecorderID = 1;
                    trans.RecordTime = DateTime.Now;

                    db.T_TransToKM.Add(trans);
                    for (var i = 0; i < billIdList.Count; i++)
                    {
                        var detail = new T_TransToKMDetail();
                        detail.BillID = trans.BillID;
                        detail.GoodsID = billIdList[i];
                        db.T_TransToKMDetail.Add(detail);

                        var transRecord = new T_TransRecord
                        {
                            BillID = detail.GoodsID,
                            OperTime = DateTime.Now,
                            OperAction = "发往昆明中转站"
                        };
                        db.T_TransRecord.Add(transRecord);

                        var goodsid = billIdList[i];
                        var goodIndb = db.T_Goods.FirstOrDefault(x => x.BillID == goodsid);
                        goodIndb.Status = CommonConst.BILL_STATUS_STOCKOUT;
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

        public ActionResult BackToStore(List<string> bills)
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
                    //检测
                    var toKm = db.T_Goods.Where(a => bills.Contains(a.BillID)).ToList();
                    foreach (var goodse in toKm)
                    {
                        if (goodse.Status != CommonConst.BILL_STATUS_STOCKIN)
                        {
                            result.Message += goodse.BillID + "/";
                        }
                        else
                        {
                            goodse.Status = CommonConst.BILL_STATUS_RECEIVED;
                            db.T_Goods.Attach(goodse);
                            db.Entry(goodse).State = System.Data.Entity.EntityState.Modified;

                            T_TransRecord transRecord = new T_TransRecord
                            {
                                BillID = goodse.BillID,
                                OperTime = DateTime.Now,
                                OperAction = "退回门店"
                            };
                            db.T_TransRecord.Add(transRecord);
                            db.SaveChanges();
                        }
                    }
                    if (result.Message.Equals(string.Empty))
                    {
                        result.Code = SystemConst.MSG_SUCCESS;
                    }
                    else
                    {
                        result.Message = result.Message.Substring(0, result.Message.Length - 1) + "状态异常";
                    }
                }
            }
            catch (Exception exception)
            {
                result.Message = exception.Message;
            }
            return Content(AppUtils.JsonSerializer(result));
        }
    }
}
