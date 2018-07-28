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
    public class TransCompanyController : ApiController
    {
        private T_TransCompany transCompany;

        public List<TransCompDto> Get()
        {
            using (var db = new LogisticsContext())
            {
                var trans = (from transcomp in db.T_TransCompany
                    select new TransCompDto
                    {
                        
                        TransID = transcomp.TransCompanyID,
                        TransCompName = transcomp.TransCompanyName,
                        TransCode = transcomp.TransCompanyCode,
                        BillLength = transcomp.BillLength
                    }).ToList();
                return trans;
            }
        }

        public WebResult Post(TransCompDto dto)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            using (var db = new LogisticsContext())
            {
                if (dto.TransID == 0)
                {
                    T_TransCompany company = new T_TransCompany()
                    {
                        TransCompanyName = dto.TransCompName,
                        TransCompanyCode = dto.TransCode,
                        BillLength = dto.BillLength
                    };
                    try
                    {
                        db.T_TransCompany.Add(company);
                        db.SaveChanges();
                        result.Code = SystemConst.MSG_SUCCESS;
                    }
                    catch (Exception ex)
                    {
                        result.Message = ex.Message;
                    }
                }
                else
                {
                    try
                    {
                        T_TransCompany transCompany =
                            db.T_TransCompany.FirstOrDefault(x => x.TransCompanyID == dto.TransID);
                        transCompany.TransCompanyName = dto.TransCompName;
                        transCompany.TransCompanyCode = dto.TransCode;
                        transCompany.BillLength = dto.BillLength;
                        db.T_TransCompany.Attach(transCompany);
                        db.Entry(transCompany).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        result.Code = SystemConst.MSG_SUCCESS;
                    }
                    catch (Exception ex)
                    {
                        result.Message = ex.Message;
                    }
                }
                return result;
            }
        }
    }
}