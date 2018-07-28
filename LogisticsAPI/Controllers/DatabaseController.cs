using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Logistics.Models;
using LogisticsAPI.Models;
using Model;
using Model.CallResult;
using Model.DefaultModels;

namespace LogisticsAPI.Controllers
{
    public class DatabaseController : Controller
    {
        public ActionResult InitDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<LogisticsContext>());
            var context = new LogisticsContext();
            context.Database.Initialize(true);
            context.SaveChanges();
            InitDemoData();
            return Content("create database success");
        }

        public ActionResult InitFunctions()
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            using (var context = new LogisticsContext())
            {
                try
                {
                    string[] names = { "管理工具", "收货门店", "仓库管理", "转运管理", "查询统计" };
                    string[] codes =
                {
                    "MAIN_MANAGE", "MAIN_RECEIVE", "MAIN_STOCK", "MAIN_TRANSPORT", "MAIN_QUERY"
                };
                    for (int i = 0; i < names.Count(); i++)
                    {
                        var function = new T_Functions
                        {
                            Name = names[i],
                            Code = codes[i],
                            ParentID = 0
                        };
                        context.T_Functions.Add(function);
                    }
                    context.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        /// <summary>
        ///     初始化测试数据
        /// </summary>
        private void InitDemoData()
        {
            InitStore();
            InitTransComp();
            InitGoodsType();
            InitPackingType();
            InitPriceType();
            InitUsers();
            InitStatus();
            InitPayType();
            T_Role.Init(new LogisticsContext());
        }

        private void InitPayType()
        {
            using (var context = new LogisticsContext())
            {
                string[] s = { "现金" , "汇款" };
                foreach (var name in s)
                {
                    var payType = new T_PayType();
                    payType.PayName = name;
                    context.T_PayType.Add(payType);
                }
                context.SaveChanges();
            }
        }

        private void InitStore()
        {
            using (var context = new LogisticsContext())
            {
                string[] s = {"一号店", "六号店", "八号店"};
                foreach (var name in s)
                {
                    var store = new T_Store();
                    store.StoreName = "泰宇达" + name;
                    context.T_Store.Add(store);
                }
                context.SaveChanges();
            }
        }

        private void InitTransComp()
        {
            using (var db = new LogisticsContext())
            {
                string[] name = {"顺丰速运", "德邦物流", "国通快递", "惠达专线","韵达快运"};
                string[] code = {"shunfeng", "debangwuliu", "guotongkuaidi", "guotongkuaidi","yunda"};
                int[] length = {12,9,10,10,13};

                for (var index = 0; index < name.Length; index++)
                {
                    var company = new T_TransCompany();
                    company.TransCompanyName = name[index];
                    company.TransCompanyCode = code[index];
                    company.BillLength = length[index];
                    db.T_TransCompany.Add(company);
                }
                db.SaveChanges();
            }
        }

        private void InitGoodsType()
        {
            using (var context = new LogisticsContext())
            {
                string[] s = {"佛像", "化妆品", "其他"};
                foreach (var name in s)
                {
                    var goodsType = new T_GoodsType();
                    goodsType.GoodsTypeName = name;
                    context.T_GoodsType.Add(goodsType);
                }
                context.SaveChanges();
            }
        }

        private void InitPackingType()
        {
            using (var context = new LogisticsContext())
            {
                string[] s = {"木架", "麻袋", "其他"};
                foreach (var name in s)
                {
                    var packingType = new T_PackingType();
                    packingType.PackingTypeName = name;
                    context.T_PackingType.Add(packingType);
                }
                context.SaveChanges();
            }
        }

        private void InitPriceType()
        {
            using (var context = new LogisticsContext())
            {
                int[] unit = {200, 150, 300, 250};
                string[] name = { "重量单价200", "体积单价150", "体积单价300", "重量单价250"};
                for (var i = 0; i < unit.Length; i++)
                {
                    var priceInfo = new T_PriceInfo();
                    priceInfo.UnitPrice = unit[i];
                    priceInfo.PriceName = name[i];
                    context.T_PriceInfo.Add(priceInfo);
                }
                context.SaveChanges();
            }
        }

        private void InitUsers()
        {
            using (var db = new LogisticsContext())
            {
                for (var i = 1; i < 4; i++)
                {
                    var user = new T_Users();
                    user.UserName = string.Format("user_{0}", i);
                    user.LoginName = string.Format("u{0}", i);
                    user.Password = "123";
                    user.Status = "0";
                    user.RoleID = i;
                    db.T_Users.Add(user);
                }
                db.SaveChanges();
            }
        }

        private void InitStatus()
        {
            using (var db = new LogisticsContext())
            {
                for (var i = 0; i < CommonConst.BILL_STATUS.Count; i++)
                {
                    var status = new T_Status();
                    status.StatusID = CommonConst.BILL_STATUS[i];
                    status.StatusName = CommonConst.BILL_STATUS_NAME[i];
                    db.T_Status.Add(status);
                }
                db.SaveChanges();
            }
        }
    }
}