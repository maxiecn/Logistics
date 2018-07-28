using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Logistics.Models;
using LogisticsAPI.Models;
using LogisticsAPI.Utils;
using Model;
using Model.CallResult;
using Model.Dto;

namespace LogisticsAPI.Controllers.BaseData
{
    public class UsersController : Controller
    {
        public ActionResult Get()
        {
            var context = new LogisticsContext();
            var users = (from user in context.T_Users
                join store in context.T_Store on user.StoreID equals store.StoreID into temp
                from i in temp.DefaultIfEmpty()
                select new UserDto
                {
                    UserID = user.UserID,
                    UserName = user.UserName,
                    LoginName = user.LoginName,
                    Password = string.Empty,
                    StoreID = user.StoreID,
                    StoreName = user.StoreID == 0 ? DataConst.HEAD : i.StoreName,
                    Status = user.Status,
                    isEnable = user.Status.Equals(DataConst.ENABLE),
                }).ToList();
            return Content(AppUtils.JsonSerializer(users));
        }

        public ActionResult GetRoles()
        {
            var context = new LogisticsContext();
            var roles = context.T_Roles.ToList();
            return Content(AppUtils.JsonSerializer(roles));
        }

        [HttpPost]
        public ActionResult AddNewUser(UserDto newUser)
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
                    if (db.T_Users.Where(a=>a.LoginName==newUser.LoginName).ToList().Count>0)
                    {
                        result.Message = "登录名重复，请重新设置";
                        return Content(AppUtils.JsonSerializer(result));
                    }
                    Guid guid = Guid.NewGuid();
                    string password = guid.ToString().Replace("-", "").Substring(0, 6);
                    T_Users user = new T_Users
                    {
                        UserName = newUser.UserName,
                        LoginName = newUser.LoginName,
                        Password = ServerUtils.SHA1Hash(password),
                        Status = DataConst.ENABLE,
                        StoreID = newUser.StoreID
                    };
                    db.T_Users.Add(user);
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Message = password;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ModifyUser(UserDto user)
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
                    T_Users theUser = db.T_Users.FirstOrDefault(a => a.UserID == user.UserID);
                    theUser.UserName = user.UserName;
                    theUser.StoreID = user.StoreID;
                    db.T_Users.Attach(theUser);
                    db.Entry(theUser).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ResetPassword(UserDto user)
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
                    Guid guid = Guid.NewGuid();
                    string password = guid.ToString().Replace("-", "").Substring(0, 6);
                    var selectUser = db.T_Users.FirstOrDefault(x => x.UserID == user.UserID);
                    selectUser.Password = ServerUtils.SHA1Hash(password);
                    db.T_Users.Attach(selectUser);
                    db.Entry(selectUser).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Message = password;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }

        [HttpPost]
        public ActionResult ChangeEnable(UserDto user)
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
                    var selectUser = db.T_Users.FirstOrDefault(x => x.UserID == user.UserID);
                    selectUser.Status = selectUser.Status.Equals(DataConst.ENABLE) ? DataConst.DISABLE : DataConst.ENABLE;
                    db.T_Users.Attach(selectUser);
                    db.Entry(selectUser).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }
        
        [HttpPost]
        public ActionResult ChangePassword(UserDto user)
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
                    var selectUser = db.T_Users.FirstOrDefault(x => x.UserID == user.UserID);
                    selectUser.Password = ServerUtils.SHA1Hash(user.Password);
                    db.T_Users.Attach(selectUser);
                    db.Entry(selectUser).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result.Code = SystemConst.MSG_SUCCESS;
                    result.Message = user.Password;
                }
                catch (Exception exception)
                {
                    result.Message = exception.Message;
                }
                return Content(AppUtils.JsonSerializer(result));
            }
        }
    }
}