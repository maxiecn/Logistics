using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogisticsAPI.Models;
using Model.DefaultModels;
using Model.Dto;

namespace LogisticsAPI.Controllers
{
    public class KuaidiController : Controller
    {
        //
        // GET: /Kuaidi/

        public ActionResult Index(String param)
        {
            String output = "";
            try
            {
                //string param = "{\"status\":\"polling\",\"billstatus\":\"got\",\"message\":\"\",\"lastResult\":{\"message\":\"ok\",\"state\":\"0\",\"status\":\"200\",\"condition\":\"F00\",\"ischeck\":\"0\",\"com\":\"yuantong\",\"nu\":\"V030344422\",\"data\":[{\"context\":\"上海分拨中心/装件入车扫描 \",\"time\":\"2012-08-28 16:33:19\",\"ftime\":\"2012-08-28 16:33:19\",\"status\":\"在途\",\"areaCode\":\"310000000000\",\"areaName\":\"上海市\"},{\"context\":\"上海分拨Z中心/下车扫描 \",\"time\":\"2012-08-27 23:22:42\",\"ftime\":\"2012-08-27 23:22:42\",\"status\":\"在途\",\"areaCode\":\"310000000000\",\"areaName\":\"上海市\"}]}}";

                Kuaidi100.BaseResult ts = AppUtils.JsonDeserialize<Kuaidi100.BaseResult>(param);
                //......这里可以保存您的快递信息
                LogisticsContext db = new LogisticsContext();

                var last = db.T_Transinfos.Where(a => a.BillID.Equals(ts.lastResult.nu) && a.Company.Equals(ts.lastResult.com))
                    .FirstOrDefault();


                if (last == null)
                {
                    T_Transinfos transinfos = new T_Transinfos();
                    transinfos.BillID = ts.lastResult.nu;
                    transinfos.Company = ts.lastResult.com;
                    transinfos.TransInfo = param;
                    db.T_Transinfos.Add(transinfos);
                    db.SaveChanges();
                }
                else
                {
                    T_Transinfos tt = db.T_Transinfos.FirstOrDefault(x => x.BillID.Equals(ts.lastResult.nu) && x.Company.Equals(ts.lastResult.com));
                    tt.TransInfo = param;
                    db.T_Transinfos.Attach(tt);
                    db.Entry(tt).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                output = "{\"result\":\"true\",\"returnCode\":\"200\",\"message\":\"成功\"}";//一定要返回成功，不返回就是失败
            }
            catch (Exception ex)
            {
                output = ex.Message;
                //output = "{\"result\":\"false\",\"returnCode\":\"500\",\"message\":\"服务器错误\"}"; //如果快递信息保存失败，这里返回失败信息，过30分钟会重推
            }
            return Content(output);
        }

    }
}
