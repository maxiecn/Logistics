using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LogisticsClient.AppUtils
{
    public class AppUtils
    {
        public static T JsonDeserialize<T>(string jsonString)
        {
            var list = (T) JsonConvert.DeserializeObject(jsonString, typeof (T));
            return list;
        }

        public static string JsonSerializer<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }

        public static Type GetFieldName(string fieldName)
        {
            var stringList = new List<string>
            {
                "BillID",
                "Password",
                "SenderName",
                "SenderTel",
                "ReceiverName",
                "ReceiverTel",
                "ReceiverAddress",
                "GoodsTypeName",
                "PackingTypeName",
                "RecorderName",
                "TransCompName",
                "TransBill",
                "TransRecorderName",
                "StoreName",
                "PriceTypeName",
                "Status",
                "StatusName",
                "PayTypeName",
                "Remark"
            };


            var datetimeList = new List<string>
            {
                "RecordTime",
                "TransTime",
                "ModifyTime"
            };

            var numberList = new List<string>
            {
                "GoodsType",
                "Measure",
                "Amount",
                "PackingType",
                "Price",
                "RecorderID",
                "TransCompID",
                "TransRecorderID",
                "StoreID",
                "PriceType",
                "PayType",
                "ChinaPrice",
                "PackingPrice",
                "InsurancePrice",
                "SumPrice"
            };

            if (numberList.IndexOf(fieldName.Trim()) != -1)
                return typeof (float);
            if (datetimeList.IndexOf(fieldName.Trim()) != -1)
                return typeof (DateTime);
            return typeof (string);
        }

        public static object GetInfo<T>(T p, string name)
        {
            return p.GetType().GetProperty(name).GetValue(p, null);
        }
    }
}