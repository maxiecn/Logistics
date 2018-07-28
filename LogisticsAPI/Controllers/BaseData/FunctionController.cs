using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LogisticsAPI.Models;
using Model;
using Model.CallResult;
using Model.DefaultModels;
using Model.Dto;

namespace LogisticsAPI.Controllers.BaseData
{
    public class FunctionController : ApiController
    {
        public List<FunctionDto> Get()
        {
            using (var db = new LogisticsContext())
            {
                var functions = from function in db.T_Functions
                    select new FunctionDto
                    {
                        ID = function.ID,
                        Name = function.Name,
                        Code = function.Code,
                        ParentID = function.ParentID
                    };
                return functions.ToList();
            }
        }

        public List<String> Get(int user)
        {
            using (var db = new LogisticsContext())
            {
                var functions = from function in db.T_UserFunctions
                    where function.UserID == user
                    select new FunctionDto
                    {
                        ID = function.FunctionID
                    };
                List<String> result = new List<string>();
                foreach (var functionDto in functions)
                {
                    result.Add(functionDto.ID.ToString());
                }
                return result;
            }
        }

        public WebResult Post(ModifyFunctionPara para)
        {
            WebResult result = new WebResult
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = string.Empty
            };
            try
            {
                using (var db = new LogisticsContext())
                {
                    List<T_UserFunction> functionsToDel =
                        db.T_UserFunctions.Where(a => a.UserID == para.user.UserID).ToList();
                    db.T_UserFunctions.RemoveRange(functionsToDel);
                    db.SaveChanges();

                    foreach (var function in para.functions)
                    {
                        T_UserFunction uf = new T_UserFunction
                        {
                            UserID = para.user.UserID,
                            FunctionID = function.ID
                        };
                        db.T_UserFunctions.Add(uf);
                    }
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
