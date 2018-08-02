using Logistics.Models;
using LogisticsAPI.Models;
using Model;
using Model.CallResult;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace LogisticsAPI.Controllers.BaseData
{
    public class TaxController : ApiController
    {
        public List<T_Tax> Get(string goodsName)
        {
            using (var db = new LogisticsContext())
            {
                if (goodsName == null || goodsName.Trim().Equals(""))
                    return db.T_Tax.ToList();
                else
                    return db.T_Tax.Where(a => a.GoodsName.Equals(goodsName)).ToList();
            }
        }

        public WebResult Post(TaxDto dto)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            using (var db = new LogisticsContext())
            {
                try
                {
                    if (dto.GoodsID == 0)
                    {
                        T_Tax tax = new T_Tax()
                        {
                            GoodsName = dto.GoodsName,
                            Price = dto.Price,
                            TaxRate = dto.TaxRate
                        };
                        db.T_Tax.Add(tax);
                        db.SaveChanges();
                        result.Code = SystemConst.MSG_SUCCESS;
                    }
                    else
                    {
                        T_Tax tax = db.T_Tax.Where(a => a.GoodsID == dto.GoodsID).FirstOrDefault();
                        tax.GoodsName = dto.GoodsName;
                        tax.Price = dto.Price;
                        tax.TaxRate = dto.TaxRate;
                        db.T_Tax.Attach(tax);
                        db.Entry(tax).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        result.Code = SystemConst.MSG_SUCCESS;
                    }
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
