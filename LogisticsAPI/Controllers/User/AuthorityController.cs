using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LogisticsAPI.Models;
using LogisticsAPI.Utils;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsAPI.Controllers.User
{
    public class AuthorityController : Controller
    {
        [HttpPost]
        public ActionResult Login(LoginPara para)
        {
            LoginResult result = new LoginResult()
            {
                Code = SystemConst.MSG_ERR_UNKNOWN,
                Message = String.Empty
            };

            using (var db = new LogisticsContext())
            {
                var user =
                    db.T_Users.Where(a => a.LoginName == para.username && a.Status.Equals(DataConst.ENABLE))
                        .FirstOrDefault();
                if (user!=null && ServerUtils.SHA1Hash(para.password).Equals(user.Password))
                {
                    var fx = (from userFunction in db.T_UserFunctions
                        join function in db.T_Functions on userFunction.FunctionID equals function.ID
                        where userFunction.UserID == user.UserID
                        select function).ToList();

                    List<String> selectfunction = new List<string>();
                    foreach (var function in fx)
                    {
                        selectfunction.Add(function.Code.ToString());
                    }

                    LoginDto loginResult = new LoginDto
                    {
                        UserID = user.UserID,
                        UserName = user.UserName,
                        Functions = selectfunction,
                        StoreID = user.StoreID
                    };
                    result.Data = loginResult;
                    result.Code = SystemConst.MSG_SUCCESS;
                }
                else
                {
                    result.Message = "用户名或密码错误,请查询";
                }
            }
            return Content(AppUtils.JsonSerializer(result));
        }

        public ActionResult GetFunctions()
        {
            using (var db = new LogisticsContext())
            {
                var functions = db.T_Functions.ToList();
                return Content(AppUtils.JsonSerializer(functions));
            }
        }
    }
}
