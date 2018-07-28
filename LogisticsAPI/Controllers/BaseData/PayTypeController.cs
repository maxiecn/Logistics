using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LogisticsAPI.Models;
using Model.DefaultModels;

namespace LogisticsAPI.Controllers.BaseData
{
    public class PayTypeController : ApiController
    {
        public List<T_PayType> Get()
        {
            using (var db = new LogisticsContext())
            {
                return db.T_PayType.ToList();
            }
        } 
    }
}
