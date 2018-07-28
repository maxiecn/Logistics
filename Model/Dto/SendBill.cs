using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class SendBill
    {
        public string BillID { get; set; }
        public int? RecorderID { get; set; }
        public string RecorderName { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
