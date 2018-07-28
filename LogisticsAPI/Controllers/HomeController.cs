using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Logistics.Models;
using LogisticsAPI.Controllers.Receive;
using LogisticsAPI.Models;
using LogisticsAPI.Utils;
using Model;
using Model.CallResult;
using Model.Dto;
using Newtonsoft.Json;

namespace LogisticsAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Query(string bill, string pwd)
        {
            List<Operation> list = new List<Operation>();
            if (bill.Length != 5 && pwd.Length != 4)
            {
                Operation op = new Operation
                {
                    时间 = DateTime.Now,
                    货物状态 = "订单号或密码错误"
                };
                list.Add(op);
            }
            else
            {
                List<KeyValuePair<string, string>> paramlist = new List<KeyValuePair<string, string>>();
                paramlist.Add(new KeyValuePair<string, string>("_billID", bill));
                paramlist.Add(new KeyValuePair<string, string>("_password", pwd));
                var db = new LogisticsContext();

                var _bill = db.T_Goods.Where(a => a.BillID.Substring(7, 5).Equals(bill) && a.Password.Equals(pwd)).ToList();
                if (_bill.Count == 0)
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
                    T_Goods selectedGoods = _bill[0];
                    var transbill = selectedGoods.TransBill;
                    var result =
                        (from transinfo in db.T_TransRecord.Where(a => a.BillID.Equals(selectedGoods.BillID)).OrderBy(a => a.OperTime)
                         select new Operation
                         {
                             时间 = transinfo.OperTime,
                             货物状态 = transinfo.OperAction
                         }).ToList();
                    foreach (Operation operation in result)
                    {
                        list.Add(operation);
                    }
                    //return Content(AppUtils.JsonSerializer(result));
                }

                //判断是否已转运
                var lastMsg = list[list.Count - 1];
                if (lastMsg.货物状态.Contains("转运单号"))
                {
                    string transBill = lastMsg.货物状态.Substring(lastMsg.货物状态.IndexOf("转运单号")).Replace("转运单号", "");

                    var result = db.T_Transinfos.Where(a => a.BillID.Equals(transBill)).FirstOrDefault();
                    List<TransData> translist = new List<TransData>();
                    if (result != null)
                    {
                        var TransInfos = AppUtils.JsonDeserialize<TransResult>(result.TransInfo);

                        for (int i = TransInfos.lastResult.data.Count - 1; i >= 0; i--)
                        {
                            TransData transInfo = TransInfos.lastResult.data[i];
                            list.Add(new Operation
                            {
                                时间 = Convert.ToDateTime(transInfo.time),
                                货物状态 = transInfo.context
                            });
                        }
                    }
                }
            }
            //ViewData["DataList"] = list;
            //return View();
            return Content(AppUtils.JsonSerializer(list));
        }
    }

}