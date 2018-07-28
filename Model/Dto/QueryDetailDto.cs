using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class QueryDetailDto
    {
        [DisplayName("单号")]
        public string BillID
        {
            get;
            set;
        }
        
        [DisplayName("发货人姓名")]
        public string SenderName
        {
            get;
            set;
        }

        [DisplayName("收货人姓名")]
        public string ReceiverName { get; set; }


        [DisplayName("体积/重量")]
        public float? Measure
        {
            get;
            set;
        }

        [DisplayName("数量")]
        public int? Amount
        {
            get;
            set;
        }

        [DisplayName("打包类型")]
        public string PackingTypeName
        {
            get;
            set;
        }
        [DisplayName("转运公司名称")]
        public string TransCompName
        {
            get;
            set;
        }
    }

    public class QueryInfoDetailDto
    {
        public DateTime OperTime { get; set; }

        public string OperAction { get; set; }
    }
}
