using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Logistics.Models;
using LogisticsAPI.Models;
using LogisticsAPI.Utils;
using Model;
using Model.CallResult;
using Model.DefaultModels;
using Model.Dto;

namespace LogisticsAPI.Controllers.Receive
{
    public class ReceiveController : Controller
    {
        public ActionResult GetSumCount(int storeID)
        {
            PageCount result = new PageCount
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty,
                Data = 0
            };
            using (var db = new LogisticsContext())
            {
                var Goods = db.T_Goods;
                if (storeID == 0)
                {
                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Data = Goods.Count();
                }
                else
                {
                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Data = Goods.Where(a => a.StoreID == storeID).Count();
                }
            }
            return Content(AppUtils.JsonSerializer(result));
        }

        //
        // GET: /Receive/
        public ActionResult GetAllGoods(int storeID)
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
                                IdCard = goods.IdCard,
                                CIQPrice = goods.CIQPrice,
                                TaxRate = goods.TaxRate,
                                TaxPrice = goods.TaxPrice
                            };
                List<ReceiveBill> GoodsList;
                if (storeID == 0)
                    GoodsList = Goods.ToList();
                else
                    GoodsList = Goods.Where(a => a.StoreID == storeID).ToList();
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

        public ActionResult GetAllGoodsByRole(int storeID)
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
                                GoodsName = goods.GoodsName,
                                BillFee = goods.BillFee,
                                IdCard = goods.IdCard,
                                CIQPrice = goods.CIQPrice,
                                TaxRate = goods.TaxRate,
                                TaxPrice = goods.TaxPrice
                            };
                DateTime dt = DateTime.Now.AddDays(-90);
                List<ReceiveBill> GoodsList;
                if (storeID == 0)
                    GoodsList = Goods.OrderByDescending(a=>a.RecordTime).ToList();
                else
                    GoodsList = Goods.Where(a => a.StoreID == storeID && (a.RecordTime > dt || (a.PayType==2 && !a.hasReceiveMoney ))).OrderByDescending(a=>a.RecordTime).ToList();
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

        public ActionResult GetAllGoodsByPage(int storeID,int page)
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
                        TransCompName = e.TransCompanyName,
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
                    }).OrderByDescending(a => a.RecordTime).ToList();
                             //OrderBy(a => a.BillID).ToList();
                
                List<ReceiveBill> GoodsList;
                int PageSize = 50;
                int CurPage = page;
                if (storeID == 0)
                    GoodsList = Goods.Take(PageSize * CurPage).Skip(PageSize * (CurPage - 1)).ToList();
                else
                    GoodsList = Goods.Where(a => a.StoreID == storeID).Take(PageSize * CurPage).Skip(PageSize * (CurPage - 1)).ToList();
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

        public ActionResult SearchGoodsByPage(int storeID, int page, string keyword)
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
                                 TransCompName = e.TransCompanyName,
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
                             }).Where(a => a.BillID.Contains(keyword)).OrderByDescending(a=>a.RecordTime).ToList();

                List<ReceiveBill> GoodsList;
                int PageSize = 50;
                int CurPage = page;
                if (storeID == 0)
                    GoodsList = Goods.Take(PageSize * CurPage).Skip(PageSize * (CurPage - 1)).ToList();
                else
                    GoodsList = Goods.Where(a => a.StoreID == storeID).Take(PageSize * CurPage).Skip(PageSize * (CurPage - 1)).ToList();
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

        [HttpPost]
        public ActionResult AddGoods(ReceiveDto receiveInfo)
        {
            AddNewGoodsResult result = new AddNewGoodsResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty,
                Data = null
            };
            try
            {
                using (var db = new LogisticsContext())
                {
                    int seq = 0;

                    var lastGoods =
                        db.T_Goods.Where(a => a.StoreID == receiveInfo.StoreID).OrderByDescending(a => a.Seq).FirstOrDefault();
                    if (lastGoods!=null)
                    {
                        seq = lastGoods.Seq;
                    }
                    seq++;
                    string billSeq = seq.ToString().PadLeft(5, '0');

                    T_Goods goods = new T_Goods
                    {
                        BillID =
                            string.Format("TUD-C{0}-{1}{2}", billSeq.Substring(0, billSeq.Length - 4),
                                receiveInfo.StoreID.ToString(), billSeq.Substring(billSeq.Length - 4)),
                        Password = ServerUtils.MakePassword(),
                        SenderName = receiveInfo.SenderName,
                        SenderTel = receiveInfo.SenderTel,
                        ReceiverName = receiveInfo.ReceiverName,
                        ReceiverTel = receiveInfo.ReceiverTel,
                        ReceiverAddress = receiveInfo.ReceiverAddress,
                        GoodsType = receiveInfo.GoodsType,
                        GoodsName = receiveInfo.GoodsName,
                        Measure = receiveInfo.Measure,
                        PriceType = receiveInfo.PriceType,
                        PackingType = receiveInfo.PackingType,
                        Price = receiveInfo.Price,
                        Amount = receiveInfo.Amount,
                        RecordTime = DateTime.Now,
                        Status = CommonConst.BILL_STATUS_RECEIVED,
                        RecorderID = receiveInfo.RecorderID,
                        StoreID = receiveInfo.StoreID,
                        PayType = receiveInfo.PayType,
                        Remark = receiveInfo.Remark,
                        ChinaPrice = receiveInfo.ChinaPrice,
                        PackingPrice = receiveInfo.PackingPrice,
                        InsurancePrice = receiveInfo.InsurancePrice,
                        SumPrice = receiveInfo.SumPrice,
                        TransCompID = receiveInfo.TransID,
                        TransCompName = receiveInfo.TransName,
                        hasReceiveMoney = receiveInfo.hasReceiveMoney,
                        MoneyReceiver = receiveInfo.MoneyReceiver,
                        UnitPrice = receiveInfo.UnitPrice,
                        Seq = seq,
                        BillFee = receiveInfo.BillFee,
                        IdCard = receiveInfo.IdCard,
                        CIQPrice = receiveInfo.CIQPrice,
                        TaxPrice = receiveInfo.TaxPrice,
                        TaxRate = receiveInfo.TaxRate
                    };
                    if (receiveInfo.hasReceiveMoney)
                        goods.MoneyReceiveTime = DateTime.Now;
                    db.T_Goods.Add(goods);
                    db.SaveChanges();

                    var store = db.T_Store.FirstOrDefault(a => a.StoreID == receiveInfo.StoreID);
                    string storeName = "泰宇达";
                    if (store != null)
                        storeName += store.StoreName;

                    T_TransRecord transRecord = new T_TransRecord
                    {
                        BillID = goods.BillID,
                        OperTime = DateTime.Now,
                        OperAction = storeName + "收货成功"
                    };
                    db.T_TransRecord.Add(transRecord);
                    db.SaveChanges();

                    var exsitedCustomer = db.T_Customer.Where(a => a.SenderName == goods.SenderName && a.SenderTel == goods.SenderTel && a.CustomerName == goods.ReceiverName && a.Tel == goods.ReceiverTel && a.Address == goods.ReceiverAddress).ToList();
                    if (exsitedCustomer.Count == 0)
                    {
                        T_Customer customer = new T_Customer
                        {
                            SenderName = goods.SenderName,
                            SenderTel = goods.SenderTel,
                            CustomerName = goods.ReceiverName,
                            Tel = goods.ReceiverTel,
                            Address = goods.ReceiverAddress,
                            TransID = goods.TransCompID == null ? 0 : Convert.ToInt16(goods.TransCompID)
                        };
                        db.T_Customer.Add(customer);
                        db.SaveChanges();
                    }

                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Data = new QueryCondition
                    {
                        BillID = goods.BillID,
                        Password = goods.Password
                    };
                    return Content(AppUtils.JsonSerializer(result));
                }
            }
            catch (Exception exception)
            {
                result.Message = exception.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ModifyGoods(ReceiveDto receiveInfo)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty,
            };
            try
            {
                using (var db = new LogisticsContext())
                {
                    T_Goods goods = db.T_Goods.FirstOrDefault(a => a.BillID == receiveInfo.BillID);

                    goods.SenderName = receiveInfo.SenderName;
                    goods.SenderTel = receiveInfo.SenderTel;
                    goods.ReceiverName = receiveInfo.ReceiverName;
                    goods.ReceiverTel = receiveInfo.ReceiverTel;
                    goods.ReceiverAddress = receiveInfo.ReceiverAddress;
                    goods.GoodsType = receiveInfo.GoodsType;
                    goods.GoodsName = receiveInfo.GoodsName;
                    goods.Measure = receiveInfo.Measure;
                    goods.PriceType = receiveInfo.PriceType;
                    goods.PackingType = receiveInfo.PackingType;
                    goods.Price = receiveInfo.Price;
                    goods.Amount = receiveInfo.Amount;
                    goods.ModifyTime = DateTime.Now;
                    //goods.Status = CommonConst.BILL_STATUS_RECEIVED;
                    goods.RecorderID = receiveInfo.RecorderID;
                    goods.PayType = receiveInfo.PayType;
                    goods.Remark = receiveInfo.Remark;
                    goods.ChinaPrice = receiveInfo.ChinaPrice;
                    goods.PackingPrice = receiveInfo.PackingPrice;
                    goods.InsurancePrice = receiveInfo.InsurancePrice;
                    goods.SumPrice = receiveInfo.SumPrice;
                    goods.TransCompID = receiveInfo.TransID;
                    goods.TransCompName = receiveInfo.TransName;
                    goods.hasReceiveMoney = receiveInfo.hasReceiveMoney;
                    goods.MoneyReceiver = receiveInfo.MoneyReceiver;
                    goods.BillFee = receiveInfo.BillFee;
                    goods.IdCard = receiveInfo.IdCard;
                    goods.CIQPrice = receiveInfo.CIQPrice;
                    goods.TaxPrice = receiveInfo.TaxPrice;
                    goods.TaxRate = receiveInfo.TaxRate;
                    if (receiveInfo.MoneyReceiveTime!=null && !receiveInfo.MoneyReceiveTime.Equals(string.Empty))
                    {
                        goods.MoneyReceiveTime = Convert.ToDateTime(receiveInfo.MoneyReceiveTime);
                    }
                    goods.UnitPrice = receiveInfo.UnitPrice;
                    db.T_Goods.Attach(goods);
                    db.Entry(goods).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    var exsitedCustomer = db.T_Customer.Where(a => a.SenderName == goods.SenderName && a.SenderTel == goods.SenderTel && a.CustomerName == goods.ReceiverName && a.Tel == goods.ReceiverTel && a.Address == goods.ReceiverAddress).ToList();
                    if (exsitedCustomer.Count == 0)
                    {
                        T_Customer customer = new T_Customer
                        {
                            SenderName = goods.SenderName,
                            SenderTel = goods.SenderTel,
                            CustomerName = goods.ReceiverName,
                            Tel = goods.ReceiverTel,
                            Address = goods.ReceiverAddress,
                            TransID = goods.TransCompID == null ? 0 : Convert.ToInt16(goods.TransCompID)
                        };
                        db.T_Customer.Add(customer);
                        db.SaveChanges();
                    }

                    result.Code = SystemConst.MSG_SUCCESS;
                    return Content(AppUtils.JsonSerializer(result));
                }
            }catch (Exception exception)
            {
                result.Message = exception.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ReturnGoods(ReceiveDto receiveInfo)
        {
            WebResult result = new WebResult 
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            try
            {
                using (var db = new LogisticsContext())
                {
                    T_Goods goods = db.T_Goods.FirstOrDefault(a => a.BillID == receiveInfo.BillID);
                    goods.ModifyTime = DateTime.Now;
                    goods.Status = CommonConst.BILL_STATUS_RETURN;
                    db.T_Goods.Attach(goods);
                    db.Entry(goods).State = System.Data.Entity.EntityState.Modified;

                    T_Log log = new T_Log
                    {
                        OperID = receiveInfo.RecorderID,
                        OperTime = DateTime.Now,
                        Operation = string.Format("订单{0}退回客户",goods.BillID)
                    };
                    db.T_Logs.Add(log);

                    db.SaveChanges();
                }
                result.Code = SystemConst.MSG_SUCCESS;
                return Content(AppUtils.JsonSerializer(result));
            }
            catch (Exception exception)
            {
                result.Message = exception.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ImportGoods(List<ReceiveDto> receiveInfos)
        {
            ImportNewGoodsResult result = new ImportNewGoodsResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty,
                Data = null
            };
            try
            {
                using (var db = new LogisticsContext())
                {
                    List<QueryCondition> conditions = new List<QueryCondition>();
                    foreach (var receiveInfo in receiveInfos)
                    {
                        int seq = 0;

                        var lastGoods =
                            db.T_Goods.Where(a => a.StoreID == receiveInfo.StoreID)
                                .OrderByDescending(a => a.Seq)
                                .FirstOrDefault();
                        if (lastGoods != null)
                        {
                            seq = lastGoods.Seq;
                        }
                        seq++;
                        string billSeq = seq.ToString().PadLeft(5, '0');

                        T_Goods goods = new T_Goods
                        {
                            BillID =
                                string.Format("TUD-C{0}-{1}{2}", billSeq.Substring(0, billSeq.Length - 4),
                                    receiveInfo.StoreID.ToString(), billSeq.Substring(billSeq.Length - 4)),
                            //T_Goods goods = new T_Goods
                            //{
                            //    BillID = ServerUtils.EncodeBill(Convert.ToInt32(strMax)),
                            Password = ServerUtils.MakePassword(),
                            SenderName = receiveInfo.SenderName,
                            SenderTel = receiveInfo.SenderTel,
                            ReceiverName = receiveInfo.ReceiverName,
                            ReceiverTel = receiveInfo.ReceiverTel,
                            ReceiverAddress = receiveInfo.ReceiverAddress,
                            GoodsType = receiveInfo.GoodsType,
                            Measure = receiveInfo.Measure,
                            PriceType = receiveInfo.PriceType,
                            PackingType = receiveInfo.PackingType,
                            Price = receiveInfo.Price,
                            UnitPrice = receiveInfo.UnitPrice,
                            Amount = receiveInfo.Amount,
                            RecordTime = DateTime.Now,
                            Status = CommonConst.BILL_STATUS_RECEIVED,
                            RecorderID = receiveInfo.RecorderID,
                            StoreID = receiveInfo.StoreID,
                            PayType = receiveInfo.PayType == 0 ? 2 : receiveInfo.PayType,
                            Remark = receiveInfo.Remark,
                            ChinaPrice = receiveInfo.ChinaPrice,
                            PackingPrice = receiveInfo.PackingPrice,
                            InsurancePrice = receiveInfo.InsurancePrice,
                            SumPrice = receiveInfo.SumPrice,
                            TransCompID = receiveInfo.TransID,
                            TransCompName = receiveInfo.TransName,
                            Seq = seq,
                            GoodsName = receiveInfo.GoodsName
                        };
                        db.T_Goods.Add(goods);

                        T_TransRecord transRecord = new T_TransRecord
                        {
                            BillID = goods.BillID,
                            OperTime = DateTime.Now,
                            OperAction = "收货成功"
                        };
                        db.T_TransRecord.Add(transRecord);
                        db.SaveChanges();
                        //var exsitedCustomer =
                        //    db.T_Customer.Where(
                        //        a =>
                        //            a.SenderName == goods.SenderName && a.SenderTel == goods.SenderTel &&
                        //            a.CustomerName == goods.ReceiverName && a.Tel == goods.ReceiverTel &&
                        //            a.Address == goods.ReceiverAddress).ToList();
                        //if (exsitedCustomer.Count == 0)
                        //{
                        //    T_Customer customer = new T_Customer
                        //    {
                        //        SenderName = goods.SenderName,
                        //        SenderTel = goods.SenderTel,
                        //        CustomerName = goods.ReceiverName,
                        //        Tel = goods.ReceiverTel,
                        //        Address = goods.ReceiverAddress,
                        //        TransID = goods.TransCompID == null ? 0 : Convert.ToInt16(goods.TransCompID)
                        //    };
                        //    db.T_Customer.Add(customer);
                        //    db.SaveChanges();
                        //}
                        db.SaveChanges();
                        conditions.Add(new QueryCondition
                        {
                            BillID = goods.BillID,
                            Password = goods.Password
                        });
                    }
                    


                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Data = conditions;
                    return Content(AppUtils.JsonSerializer(result));
                }
            }
            catch (Exception exception)
            {
                result.Message = exception.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ReceiveMoney(MoneyReceivePara para)
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
                    //var goods = db.T_Goods.Where(a => para.billIdList.IndexOf(a.BillID) != -1);
                    int sum = 0;
                    foreach (var billID in para.billIdList)
                    {
                        var goodse = db.T_Goods.FirstOrDefault(x => x.BillID == billID);
                        goodse.MoneyReceiver = para.User;
                        goodse.MoneyReceiveTime = para.receiveTime;
                        sum += Convert.ToInt32(goodse.SumPrice);
                        goodse.MoneyRemark = para.remark;
                        goodse.hasReceiveMoney = true;
                        db.T_Goods.Attach(goodse);
                        db.Entry(goodse).State = System.Data.Entity.EntityState.Modified;
                    }
                    db.SaveChanges();

                    T_PayAmount payAmount = new T_PayAmount
                    {
                        BillIDs = AppUtils.JsonSerializer(para.billIdList),
                        MoneyAmount = sum,
                        PayDate = para.receiveTime,
                        Remark = para.remark
                    };
                    db.T_PayAmount.Add(payAmount);
                    db.SaveChanges();

                    result.Code = SystemConst.MSG_SUCCESS;
                    return Content(AppUtils.JsonSerializer(result));
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult DeleteBill(SendBill sendBill)
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
                    T_Goods selectGoods = db.T_Goods.FirstOrDefault(a => a.BillID == sendBill.BillID);

                    if (selectGoods == null)
                    {
                        result.Message = "订单不存在，请刷新";
                        return Content(AppUtils.JsonSerializer(result));
                    }

                    if (!selectGoods.Status.Equals(CommonConst.BILL_STATUS_RECEIVED))
                    {
                        result.Message = "订单不是已接收状态，不允许删除";
                        return Content(AppUtils.JsonSerializer(result));
                    }

                    int storeID = Convert.ToInt16(sendBill.BillID.Substring(7, 1));
                    string goodsID =
                        (from s in db.T_Goods.Where(a => a.StoreID == storeID)
                            select s.BillID).Max();

                    if (goodsID!=sendBill.BillID)
                    {
                        result.Message = "此订单不是本店最后一份订单，请刷新";
                    }
                    else
                    {
                        db.T_Goods.Attach(selectGoods);
                        db.T_Goods.Remove(selectGoods);
                        db.SaveChanges();

                        var transinfos = db.T_TransRecord.Where(a => a.BillID.Equals(sendBill.BillID));
                        foreach (T_TransRecord transRecord in transinfos)
                        {
                            db.T_TransRecord.Attach(transRecord);
                            db.T_TransRecord.Remove(transRecord);
                        }
                        db.SaveChanges();

                        result.Code = SystemConst.MSG_SUCCESS;

                        T_Log log = new T_Log
                        {
                            OperID = Convert.ToInt32(sendBill.RecorderID),
                            OperTime = DateTime.Now,
                            Operation = string.Format("{0}:{1}",SystemConst.LOG_DELETE,sendBill.BillID)
                        };
                        db.T_Logs.Add(log);
                        db.SaveChanges();
                    }
                    return Content(AppUtils.JsonSerializer(result));
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                return Content(AppUtils.JsonSerializer(result));
            }
        }
    }
}