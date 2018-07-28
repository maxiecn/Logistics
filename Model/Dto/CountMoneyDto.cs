using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class CountMoneyDto
    {
        [DisplayName("店铺名称")]
        public string StoreName
        {
            get;
            set;
        }

        [DisplayName("付款方式")]
        public string PayTypeName
        {
            get;
            set;
        }

        [DisplayName("总额")]
        public int? MoneySum
        {
            get;
            set;
        }
    }
}
