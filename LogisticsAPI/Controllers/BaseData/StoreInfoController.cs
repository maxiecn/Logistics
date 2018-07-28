using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Logistics.Models;
using LogisticsAPI.Models;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsAPI.Controllers.BaseData
{
    public class StoreInfoController : ApiController
    {
        public List<StoreDto> Get()
        {
            using (var db = new LogisticsContext())
            {
                var stores = (from store in db.T_Store
                    select new StoreDto
                    {
                        StoreID = store.StoreID,
                        StoreName = store.StoreName
                    }).ToList();
                return stores;
            }
        }

        public WebResult Post(StoreDto store)
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
                    T_Store newStore = new T_Store
                    {
                        StoreName = store.StoreName
                    };
                    db.T_Store.Add(newStore);
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                }
            }
            catch (Exception exception)
            {
                result.Message = exception.Message;
            }


            return result;
        }
    }
}
