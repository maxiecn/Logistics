using System.Collections.Generic;

namespace Model
{
    public class CommonConst
    {
        public static string BILL_STATUS_RECEIVED = "000";
        public static string BILL_STATUS_RETURN = "005";
        public static string BILL_STATUS_SEND = "010";
        public static string BILL_STATUS_STOCKIN = "020";
        public static string BILL_STATUS_STOCKOUT = "030";
        public static string BILL_STATUS_TRANSED = "040";
        public static string BILL_STATUS_SENDTOKD100 = "050";
        public static string BILL_STATUS_SENDTOKD100ERR = "060";

        public static List<string> BILL_STATUS = new List<string>
        {
            "000",
            "005",
            "010",
            "020",
            "030",
            "040",
            "050",
            "060"
        };

        public static List<string> BILL_STATUS_NAME = new List<string>
        {
            "已收货",
            "已退货",
            "已发货",
            "已入库",
            "已出库",
            "已转运",
            "已转运",
            "已转运"
        };
    }
}