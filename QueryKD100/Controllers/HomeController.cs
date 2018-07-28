using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using QueryKD100.Models;

namespace QueryKD100.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Query(string transBill)
        {
            ThaiyudaEntities db = new ThaiyudaEntities();
            var result = db.T_Transinfos.Where(a => a.BillID.Equals(transBill)).FirstOrDefault();
            if (result==null)
            {
                return Content(JsonSerializer(new List<TransData>()));
            }
            var TransInfos = JsonDeserialize<TransResult>(result.TransInfo);
            string s = JsonSerializer(TransInfos.lastResult.data);
            return Content(JsonSerializer(TransInfos.lastResult.data));
        }

        public static string JsonSerializer<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }

        public static T JsonDeserialize<T>(string jsonString)
        {
            var list = (T) JsonConvert.DeserializeObject(jsonString, typeof (T));
            return list;
        }
    }
}
