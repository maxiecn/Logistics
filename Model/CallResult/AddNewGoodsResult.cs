using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.CallResult
{
    public class AddNewGoodsResult : WebResult
    {
        public QueryCondition Data { get; set; }
    }

    public class QueryCondition
    {
        public string BillID { get; set; }
        public string Password { get; set; }
    }
}
