using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class SendBillDetail
    {
        public string GoodsID { get; set; }

        public string Status { get; set; }
    }

    public class StockInParam
    {
        public StockInBaseInfo baseInfo { get; set; }

        public List<String> billList { get; set; }
    }
}
