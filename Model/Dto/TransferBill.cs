using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class TransferBill
    {
        public string BillID { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverTel { get; set; }
        public string ReceiverAddress { get; set; }
        public int? GoodsType { get; set; }
        public string GoodsTypeName { get; set; }
        public int? TransCompID { get; set; }
        public string TransCompName { get; set; }
        public string TransBill { get; set; }
        public DateTime? TransTime { get; set; }
        public int? TransRecorderID { get; set; }
        public string TransRecorderName { get; set; }
        public DateTime? ModifyTime { get; set; }
        public string Status { get; set; }
        public string StatusName { get; set; }
    }

    public class TransParam
    {
        public int uid { get; set; }
        public string billid { get; set; }
        public string transid { get; set; }
    }
}
