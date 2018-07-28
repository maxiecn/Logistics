using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Logistics.Models;
using LogisticsAPI.Models;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsAPI.Controllers
{
    public class PriceInfoController : ApiController
    {
        public List<PriceInfoDto> Get()
        {
            using (var db = new LogisticsContext())
            {
                var result = (from priceInfo in db.T_PriceInfo
                    select new PriceInfoDto
                    {
                        PriceID = priceInfo.PriceID,
                        PriceName = priceInfo.PriceName,
                        UnitPrice = priceInfo.UnitPrice
                    }).ToList();
                return result;
            }
        }

        public WebResult Post(PriceInfoDto dto)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            using (var db = new LogisticsContext())
            {
                T_PriceInfo priceInfo = new T_PriceInfo()
                {
                    PriceName = dto.PriceName,
                    UnitPrice = dto.UnitPrice
                };
                try
                {
                    db.T_PriceInfo.Add(priceInfo);
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                }
                catch (Exception ex)
                {
                    result.Message = ex.Message;
                }
                return result;
            }
        }
    }
}