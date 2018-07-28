using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class MoneyReceivePara
    {
        public List<string> billIdList { get; set; }
        public int User { get; set; }

        public DateTime receiveTime { get; set; }

        public string remark { get; set; }
    }

    public class MoneyCountPara
    {
        public string startTime
        {
            get;
            set;
        }

        public string endTime
        {
            get;
            set;
        }
    }
}
