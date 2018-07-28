using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogisticsAPI.Models;
using LogisticsClient.AppUtils;
using Model.DefaultModels;
using Model.Dto;
using Utils;

namespace LogisticsAPI.Controllers
{
    public class KuaidiController : Controller
    {
        //
        // GET: /Kuaidi/

        public ActionResult Index(String param)
        {
            List<KeyValuePair<string, string>> paras = new List<KeyValuePair<string, string>>();
            paras.Add(new KeyValuePair<string, string>("param", param));
            String output = WebCall.GetMethod<String>("Kuaidi/Index", paras);
            return Content(output);
        }

    }
}
