using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Logistics.Models;
using LogisticsAPI.Models;
using LogisticsClient.AppUtils;
using Model;
using Model.CallResult;
using Model.Dto;
using Newtonsoft.Json;
using Utils;

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
            
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            paras.Add(new KeyValuePair<string, string>("bill", bill));
            paras.Add(new KeyValuePair<string, string>("pwd", pwd));
            List<Operation> list = WebCall.GetMethod<List<Operation>>("Home/Query", paras);
            ViewData["DataList"] = list;
            return View();
        }
    }

}