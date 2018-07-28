using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc.Html;
using Logistics.Models;
using LogisticsAPI.Models;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsAPI.Controllers.BaseData
{
    public class GoodsTypeController : ApiController
    {
        public List<GoodsTypeDto> Get()
        {
            using (var db = new LogisticsContext())
            {
                var typelist = (from type in db.T_GoodsType
                    select new GoodsTypeDto
                    {
                        GoodsTypeID = type.GoodsTypeID,
                        GoodsTypeName = type.GoodsTypeName
                    }).ToList();
                return typelist;
            }
        }

        public WebResult Post(GoodsTypeDto dto)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            using (var db = new LogisticsContext())
            {
                T_GoodsType goodsType = new T_GoodsType()
                {
                    GoodsTypeName = dto.GoodsTypeName
                };
                try
                {
                    db.T_GoodsType.Add(goodsType);
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