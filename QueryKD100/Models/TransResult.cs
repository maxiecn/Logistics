using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueryKD100.Models
{
    public class TransResult
    {
        public String status { get; set; }
        public String billstatus
        {
            get;
            set;
        }
        public String message
        {
            get;
            set;
        }
        public LastResult lastResult
        {
            get;
            set;
        }
    }

    public class LastResult
    {
        public String message { get; set; }
        public String nu { get; set; }
        public String ischeck { get; set; }
        public String condition { get; set; }
        public String com { get; set; }
        public String status { get; set; }
        public String state { get; set; }
        public List<TransData> data { get; set; }
    }


    public class TransData
    {
        public String time { get; set; }
        public String ftime { get; set; }
        public String context { get; set; }
    }
}