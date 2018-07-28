using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;
using LogisticsAPI.Models;
using Model.DefaultModels;
using Utils;
using XMLHandler;
using System.Web;

namespace QueryWeb.Controllers
{
    public class IPController : Controller
    {
        public ActionResult get()
        {
            using (var db = new LogisticsContext())
            {
                //T_IP ipInfo = db.T_IP.Where(a => a.ipkey.Equals("thaiyuda")).FirstOrDefault();
                //return Content(ipInfo.ipvalue);
                TXmlConfigHandler xml = new TXmlConfigHandler(HttpRuntime.AppDomainAppPath + "/ip.xml");
                return Content(xml.ReadValue("IP"));
            }
        }

        public ActionResult set(string ip)
        {
            TXmlConfigHandler xml = new TXmlConfigHandler(HttpRuntime.AppDomainAppPath + "/ip.xml");
            xml.WriteValue("IP", ip);
            //using (var db = new LogisticsContext())
            //{
            //    T_IP ipInfo = db.T_IP.Where(a => a.ipkey.Equals("thaiyuda")).FirstOrDefault();
            //    ipInfo.ipvalue = ip;
            //    db.T_IP.Attach(ipInfo);
            //    db.Entry(ipInfo).State = System.Data.Entity.EntityState.Modified;
            //    db.SaveChanges();
                return Content("修改成功");
            //}
        }

        public ActionResult getIP()
        {
            using (var db = new LogisticsContext())
            {
                T_IP ipInfo = db.T_IP.Where(a => a.ipkey.Equals("self")).FirstOrDefault();
                return Content(ipInfo.ipvalue);
            }
        }

        public ActionResult setIP(string ip)
        {
            using (var db = new LogisticsContext())
            {
                T_IP ipInfo = db.T_IP.Where(a => a.ipkey.Equals("self")).FirstOrDefault();
                ipInfo.ipvalue = ip;
                db.T_IP.Attach(ipInfo);
                db.Entry(ipInfo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Content("修改成功");
            } 
        }
    }
}
