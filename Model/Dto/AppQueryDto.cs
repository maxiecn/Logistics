using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CallResult;

namespace Model.Dto
{
    public class AppQueryDto
    {
        public string 发货单号 { get; set; }
        public string 发货人姓名 { get; set; }
        public string 收货人姓名 { get; set; }
        public string 重量 { get; set; }
        public string 总件数 { get; set; }
        public string 是否打木架 { get; set; }
        public string 客户指定转运方 { get; set; }
        public string starttime { get; set; }

        public List<Operation> transinfo
        {
            get;
            set;
        }
    }
}
