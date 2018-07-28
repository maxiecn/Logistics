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

namespace LogisticsAPI.Controllers.Receive{
    public class QueryController : Controller
    {
        public ActionResult GetAllGoods(string _senderName)
        {
            using (var db = new LogisticsContext())
            {
                //var customers =
                    //db.T_Customer.Where()
                        //.ToList();
                var ctx = from customer in db.T_Customer
                    join transcomp in db.T_TransCompany on customer.TransID equals transcomp.TransCompanyID into tempa
                    from a in tempa.DefaultIfEmpty()
                    select new HintInputDto
                    {
                        SenderName = customer.SenderName,
                        SenderTel = customer.SenderTel,
                        ReceiverName = customer.CustomerName,
                        ReceiverTel = customer.Tel,
                        ReceiverAddress = customer.Address,
                        TransCompID = customer.TransID,
                        TransCompName = a.TransCompanyName
                    };
                var customers = ctx.Where(a => a.SenderName.Contains(_senderName) || a.ReceiverName.Contains(_senderName) || a.SenderTel.Contains(_senderName) || a.ReceiverTel.Contains(_senderName)).ToList();
                return Content(AppUtils.JsonSerializer(customers));
            }
        }

        public ActionResult GetAllGoodsByRole(bool showDetail)
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
                            select new ReceiveBill
                            {
                                BillID = goods.BillID,
                                Password = !showDetail ? "" : goods.Password,
                                SenderName = goods.SenderName,
                                SenderTel = !showDetail ? "" : goods.SenderTel,
                                ReceiverName = goods.ReceiverName,
                                ReceiverTel = !showDetail ? "" : goods.ReceiverTel,
                                ReceiverAddress = !showDetail ? "" : goods.ReceiverAddress,
                                GoodsType = !showDetail ? 0 : goods.GoodsType,
                                GoodsTypeName = !showDetail ? "" : a.GoodsTypeName,
                                Measure = goods.Measure,
                                Amount = goods.Amount,
                                PackingType = !showDetail ? 0 : goods.PackingType,
                                PackingTypeName = !showDetail ? "" : c.PackingTypeName,
                                Price = !showDetail ? 0 : goods.Price,
                                RecorderID = !showDetail ? 0 : goods.RecorderID,
                                RecorderName = !showDetail ? "" : d.UserName,
                                RecordTime = goods.RecordTime,
                                TransCompID = goods.TransCompID,
                                TransCompName = e.TransCompanyName,
                                TransBill = goods.TransBill,
                                TransTime = !showDetail ? null : goods.TransTime,
                                TransRecorderID = !showDetail ? 0 : goods.TransRecoderID,
                                TransRecorderName = !showDetail ? "" : g.UserName,
                                ModifyTime = !showDetail ? null : goods.ModifyTime,
                                StoreID = goods.StoreID,
                                StoreName = f.StoreName,
                                PriceType = !showDetail ? 0 : goods.PriceType,
                                PriceTypeName = !showDetail ? "" : b.PriceName,
                                Status = goods.Status,
                                StatusName = h.StatusName,
                                PayType = !showDetail ? 0 : i.PayID,
                                PayTypeName = !showDetail ? "" : i.PayName,
                                Remark = !showDetail ? "" : goods.Remark,
                                ChinaPrice = !showDetail ? 0 : goods.ChinaPrice,
                                PackingPrice = !showDetail ? 0 : goods.PackingPrice,
                                InsurancePrice = !showDetail ? 0 : goods.InsurancePrice,
                                SumPrice = !showDetail ? 0 : goods.SumPrice
                            };
                var GoodsList = Goods.ToList();
                if (!showDetail)
                {
                    DateTime dt = DateTime.Now.AddDays(-60);
                    GoodsList = (from goods in Goods
                        where goods.RecordTime > dt
                        select goods).ToList();
                    //GoodsList = Goods.Where(a => a.)).ToList();
                }
                return Content(AppUtils.JsonSerializer(GoodsList));
            }
        }

        [HttpPost]
        public ActionResult CountMoney(MoneyCountPara para)
        {
            using (LogisticsContext db = new LogisticsContext())
            {
                DateTime start = Convert.ToDateTime(para.startTime);
                DateTime end = Convert.ToDateTime(para.endTime);
                var money = from goods in db.T_Goods                            
                            where goods.RecordTime >= start && goods.RecordTime <= end
                            group goods by new
                            {
                                goods.PayType,
                                goods.StoreID
                            } into c
                            select new                            
                            {
                                StoreID = c.Key.StoreID,
                                PayTypeID = c.Key.PayType,
                                MoneySum = c.Sum(a => a.SumPrice)
                            };
                var result = from m in money
                             join stores in db.T_Store on m.StoreID equals stores.StoreID into tempa
                            from a in tempa.DefaultIfEmpty()
                             join paytypes in db.T_PayType on m.PayTypeID equals paytypes.PayID into tempb
                             from b in tempb.DefaultIfEmpty()
                            select new CountMoneyDto
                            {
                                StoreName = a.StoreName,
                                PayTypeName = b.PayName,
                                MoneySum = m.MoneySum
                            };
                string s = AppUtils.JsonSerializer(result.ToList());
                return Content(s);
            }
        }

        public ActionResult QueryList(string _billID)
        {
            QueryListResult result = new QueryListResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = String.Empty,
                Data = null
            };

            try
            {
                using (var db = new LogisticsContext())
                {
                    var Goods = from goods in db.T_Goods
                        join types in db.T_GoodsType on goods.GoodsType equals types.GoodsTypeID into tempa
                        from a in tempa.DefaultIfEmpty()
                        join packages in db.T_PackingType on goods.PackingType equals packages.PackingTypeID into tempc
                        from c in tempc.DefaultIfEmpty()
                        join transcomps in db.T_TransCompany on goods.TransCompID equals transcomps.TransCompanyID into
                            tempe
                        from e in tempe.DefaultIfEmpty()
                        select new QueryDetailDto
                        {
                            BillID = goods.BillID,
                            SenderName = goods.SenderName,
                            ReceiverName = goods.ReceiverName,
                            Measure = goods.Measure,
                            Amount = goods.Amount,
                            PackingTypeName = c.PackingTypeName,
                            TransCompName = e.TransCompanyName,
                        };
                    var selectGoods = Goods.Where(a => a.BillID.Contains(_billID)).ToList();
                    result.Data = selectGoods;
                    result.Code = SystemConst.MSG_SUCCESS;
                }
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return Content(AppUtils.JsonSerializer(result));
        }

        public ActionResult QueryDetail(string _billID)
        {
            var db = new LogisticsContext();
            var result =
                (from transinfo in db.T_TransRecord.Where(a => a.BillID.Equals(_billID)).OrderBy(a => a.OperTime)
                 select new Operation
                 {
                     时间 = transinfo.OperTime,
                     货物状态 = transinfo.OperAction
                 }).ToList();
            return Content(AppUtils.JsonSerializer(result));
        }

        public ActionResult QueryWithPassword(string _billID,string _password)
        {
            var db = new LogisticsContext();

            var bill = db.T_Goods.Where(a => a.BillID.Substring(7,5).Equals(_billID) && a.Password.Equals(_password)).ToList();
            if (bill.Count==0)
            {
                Operation op = new Operation
                {
                    时间 = DateTime.Now,
                    货物状态 = "没有对应单号,请重新查询"
                };
                List<Operation> ops = new List<Operation>();
                ops.Add(op);
                return Content(AppUtils.JsonSerializer(ops));
            }
            else
            {
                T_Goods selectedGoods = bill[0];
                var transbill = selectedGoods.TransBill;
                var result =
                    (from transinfo in db.T_TransRecord.Where(a => a.BillID.Equals(selectedGoods.BillID)).OrderBy(a => a.OperTime)
                        select new Operation
                        {
                            时间 = transinfo.OperTime,
                            货物状态 = transinfo.OperAction
                        }).ToList();
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        public ActionResult QueryBaseWithPassword(string _billID, string _password)
        {
            var db = new LogisticsContext();

            var bill = db.T_Goods.Where(a => a.BillID.Substring(7, 5).Equals(_billID) && a.Password.Equals(_password)).ToList();
            if (bill.Count == 0)
            {
                //Operation op = new Operation
                //{
                //    时间 = DateTime.Now,
                //    货物状态 = "没有对应单号,请重新查询"
                //};
                //List<Operation> ops = new List<Operation>();
                //ops.Add(op);
                return Content("{}");
            }
            else
            {
                T_Goods selectedGoods = bill[0];
                string packingName = db.T_PackingType.FirstOrDefault(a => a.PackingTypeID == selectedGoods.PackingType)
                        .PackingTypeName;
                AppQueryDto appQueryDto = new AppQueryDto
                {
                    发货单号 = selectedGoods.BillID,
                    发货人姓名 = selectedGoods.SenderName.Substring(0, 1) + "***",
                    收货人姓名 = selectedGoods.ReceiverName.Substring(0, 1) + "***",
                    重量 = selectedGoods.Measure.ToString(),
                    总件数 = selectedGoods.Amount.ToString(),
                    是否打木架 = packingName == null ? string.Empty : packingName,
                    客户指定转运方 = selectedGoods.TransCompName,
                    starttime = selectedGoods.RecordTime.ToString()
                };
                var transInfos =
                    (from transinfo in db.T_TransRecord.Where(a => a.BillID.Equals(selectedGoods.BillID)).OrderBy(a => a.OperTime)
                     select new Operation
                     {
                         时间 = transinfo.OperTime,
                         货物状态 = transinfo.OperAction
                     }).ToList();
                appQueryDto.transinfo = transInfos;
                return Content(AppUtils.JsonSerializer(appQueryDto));
            }
        }


        public ActionResult QueryPayResult()
        {
            using (LogisticsContext db = new LogisticsContext())
            {
                var payAmounts = db.T_PayAmount.ToList();
                List<QueryPayResultDto> result = new List<QueryPayResultDto>();
                foreach (T_PayAmount payAmount in payAmounts)
                {
                    QueryPayResultDto queryPayResult = new QueryPayResultDto
                    {
                        PayID = payAmount.PayID,
                        PayDate = payAmount.PayDate,
                        MoneyAmount = payAmount.MoneyAmount,
                        Remark = payAmount.Remark
                    };
                    List<String> bills = AppUtils.JsonDeserialize<List<String>>(payAmount.BillIDs);
                    for (int i = 0;i < bills.Count;i++)
                    {
                        queryPayResult.BillIDs += bills[i];
                        if (i < bills.Count - 1)
                        {
                            queryPayResult.BillIDs += ",";
                        }
                    }
                    result.Add(queryPayResult);
                }
                return Content(AppUtils.JsonSerializer(result.OrderByDescending(a => a.PayDate)));
            }
        }

        public ActionResult QueryKD()
        {
            using (var db = new LogisticsContext())
            {
                var goods =
                    db.T_Goods.Where(a => a.TransTime < DateTime.Now && a.Status.Equals(CommonConst.BILL_STATUS_TRANSED))
                        .ToList();
                foreach (var goodse in goods)
                {
                    goodse.Status = CommonConst.BILL_STATUS_SENDTOKD100;
                    db.T_Goods.Attach(goodse);
                    db.Entry(goodse).State = EntityState.Modified;
                    db.SaveChanges();
                }
                return Content(AppUtils.JsonSerializer(goods));
            }
        }
    }
}
