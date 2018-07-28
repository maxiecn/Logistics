using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistics.Models;
using LogisticsAPI.Models;
using Model;
using Model.CallResult;
using Model.DefaultModels;
using Model.Dto;

namespace LogisticsAPI.Controllers.Transfer
{
    public class TransferController : Controller
    {
        public ActionResult GetAllGoods()
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
                    select new TransferBill
                    {
                        BillID = goods.BillID,
                        ReceiverName = goods.ReceiverName,
                        ReceiverTel = goods.ReceiverTel,
                        ReceiverAddress = goods.ReceiverAddress,
                        GoodsType = goods.GoodsType,
                        GoodsTypeName = a.GoodsTypeName,
                        TransCompID = goods.TransCompID,
                        TransCompName = e.TransCompanyName,
                        TransBill = goods.TransBill,
                        TransTime = goods.TransTime,
                        TransRecorderID = goods.TransRecoderID,
                        TransRecorderName = g.UserName,
                        ModifyTime = goods.ModifyTime,
                        Status = goods.Status,
                        StatusName = h.StatusName
                    };
                var GoodsList =
                    Goods.Where(
                        a => a.Status == CommonConst.BILL_STATUS_STOCKOUT || a.Status == CommonConst.BILL_STATUS_TRANSED || a.Status == CommonConst.BILL_STATUS_SENDTOKD100 || a.Status == CommonConst.BILL_STATUS_SENDTOKD100ERR)
                        .ToList();
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

        [HttpPost]
        public ActionResult UpdateTransInfo(TransParam param)
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
                    var goods = db.T_Goods.FirstOrDefault(x => x.BillID == param.billid);
                    goods.TransRecoderID = param.uid;
                    goods.TransBill = param.transid;
                    //List<T_TransCompany> transCompanies = db.T_TransCompany.ToList();
                    //goods.TransCompID = 0;
                    //foreach (var company in transCompanies)
                    //{
                    //    if (company.BillLength == param.transid.Length)
                    //        goods.TransCompID = company.TransCompanyID;
                    //}
                    goods.TransRecoderID = param.uid;
                    goods.TransTime = DateTime.Now;db.T_Goods.Attach(goods);
                    goods.Status = CommonConst.BILL_STATUS_TRANSED;
                    db.Entry(goods).State = System.Data.Entity.EntityState.Modified;

                    var transRecord = new T_TransRecord
                    {
                        BillID = goods.BillID,
                        OperTime = DateTime.Now,
                        OperAction =
                            string.Format("已转【{0}】转运，转运单号{1}", goods.TransCompName,
                                param.transid)
                    };
                    db.T_TransRecord.Add(transRecord);

                    db.SaveChanges();
                }
                result.Code = SystemConst.MSG_SUCCESS;
                return Content(AppUtils.JsonSerializer(result));
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ImportTransInfos(List<ImportTrans> transInfos)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = String.Empty
            };
            try
            {using (var db = new LogisticsContext())
                {
                    foreach (var importTranse in transInfos)
                    {
                        var goods = db.T_Goods.Where(x => x.BillID.Substring(7) == importTranse.BillID).ToList();
                        if (goods==null)
                        {
                            continue;
                        }
                        foreach (var goodsInfo in goods)
                        {
                            //if (goodsInfo.TransBill == null || goodsInfo.TransBill.Equals(string.Empty))
                            //{
                                goodsInfo.TransRecoderID = importTranse.TransOperID;
                                goodsInfo.TransBill = importTranse.TransBillID;
                                goodsInfo.TransTime = DateTime.Now;
                                db.T_Goods.Attach(goodsInfo);goodsInfo.Status = CommonConst.BILL_STATUS_TRANSED;
                                db.Entry(goodsInfo).State = System.Data.Entity.EntityState.Modified;
                                var transRecord = new T_TransRecord
                                {
                                    BillID = goodsInfo.BillID,
                                    OperTime = DateTime.Now,
                                    OperAction =
                                        string.Format("已转【{0}】转运，转运单号{1}", goodsInfo.TransCompName,
                                            importTranse.TransBillID)
                                };
                                db.T_TransRecord.Add(transRecord);

                                db.SaveChanges();
                            //}
                        }
                    }
                }
                result.Code = SystemConst.MSG_SUCCESS;
                return Content(AppUtils.JsonSerializer(result));
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
                        if (goodse.Status!=CommonConst.BILL_STATUS_STOCKOUT)
                        {
                            result.Message += goodse.BillID + "/";
                        }
                        else
                        {
                            goodse.Status = CommonConst.BILL_STATUS_STOCKIN;
                            db.T_Goods.Attach(goodse);
                            db.Entry(goodse).State = System.Data.Entity.EntityState.Modified; 
                            
                            T_TransRecord transRecord = new T_TransRecord
                            {
                                BillID = goodse.BillID,
                                OperTime = DateTime.Now,
                                OperAction = "退回仓库"
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

        [HttpPost]
        public ActionResult ClearTransInfos(List<ImportTrans> transInfos)
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
                    foreach (var importTranse in transInfos)
                    {
                        var goods = db.T_Goods.Where(x => x.BillID.Substring(7) == importTranse.BillID).ToList();
                        if (goods == null)
                        {
                            continue;
                        }
                        foreach (var goodsInfo in goods)
                        {
                            goodsInfo.TransRecoderID = null;
                            goodsInfo.TransBill = String.Empty;
                            goodsInfo.TransTime = null;
                            db.T_Goods.Attach(goodsInfo);
                            goodsInfo.Status = CommonConst.BILL_STATUS_STOCKOUT;
                            db.Entry(goodsInfo).State = System.Data.Entity.EntityState.Modified; //修改主表
                            //var transRecord = new T_TransRecord
                            //{
                            //    BillID = goodsInfo.BillID,
                            //    OperTime = DateTime.Now,
                            //    OperAction =
                            //        string.Format("已转【{0}】转运，转运单号{1}", goodsInfo.TransCompName,
                            //            importTranse.TransBillID)
                            //};
                            //db.T_TransRecord.Add(transRecord);
                            var transRecords =
                                db.T_TransRecord.FirstOrDefault(
                                    a => a.BillID.Equals(goodsInfo.BillID) && a.OperAction.Contains("已转"));
                            db.T_TransRecord.Remove(transRecords);
                            db.SaveChanges();
                        }
                    }
                }
                result.Code = SystemConst.MSG_SUCCESS;
                return Content(AppUtils.JsonSerializer(result));
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }
    }
}