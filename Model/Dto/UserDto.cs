using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Logistics.Models;

namespace Model.Dto
{
    public class UserDto
    {
        [DisplayName("用户编号")]
        public int UserID { get; set; }

        [DisplayName("用户姓名")]
        public string UserName { get; set; }

        [DisplayName("登录名")]
        public string LoginName { get; set; }

        [DisplayName("密码")]
        public string Password { get; set; }

        [DisplayName("状态")]
        public string Status { get; set; }

        [DisplayName("可用")]
        public bool isEnable { get; set; }

        [DisplayName("所属店面")]
        public string StoreName { get; set; }

        [DisplayName("店面编号")]
        public int StoreID { get; set; }
    }
}
