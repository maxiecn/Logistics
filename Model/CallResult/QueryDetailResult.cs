using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Model.Dto;

namespace Model.CallResult
{
    public class QueryDetailResult : WebResult
    {
        public List<Operation> Data { get; set; }
    }

    public class Operation
    {
        [DisplayName("操作时间")]
        public DateTime 时间
        {
            get;
            set;
        }

        [DisplayName("操作内容")]
        public string 货物状态
        {
            get;
            set;
        }
    }
}
