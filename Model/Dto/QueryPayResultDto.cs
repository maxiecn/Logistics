using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class QueryPayResultDto
    {
        [DisplayName("编号")]
        public int PayID
        {
            get;
            set;
        }

        [DisplayName("支付订单")]
        public string BillIDs
        {
            get;
            set;
        }

        [DisplayName("支付总额")]
        public int MoneyAmount
        {
            get;
            set;
        }

        [DisplayName("支付时间")]
        public DateTime PayDate
        {
            get;
            set;
        }

        [DisplayName("备注")]
        public string Remark
        {
            get;
            set;
        }
    }
}
