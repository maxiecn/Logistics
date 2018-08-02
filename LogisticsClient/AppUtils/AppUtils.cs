using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit.API.Word;
using Newtonsoft.Json;
using LogisticsClient.Lang;

namespace LogisticsClient.AppUtils
{
    public class AppUtils
    {
        public static void ResolveForm(Form f)
        {
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
        }
        public static T JsonDeserialize<T>(string jsonString)
        {
            var list = (T) JsonConvert.DeserializeObject(jsonString, typeof (T));
            return list;
        }

        public static string JsonSerializer<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }

        public static bool HasAuth(string authName)
        {
            if (Configure.UserID == -1)
                return true;
            return Configure.Functions.IndexOf(authName) != -1;
        }

        public static Type GetFieldName(string fieldName)
        {
            List<String> stringList = new List<String>()
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



            List<String> datetimeList = new List<string>()
            {
                "RecordTime",
                "TransTime",
                "ModifyTime"
            };

            List<String> numberList = new List<string>()
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
            else if (datetimeList.IndexOf(fieldName.Trim()) != -1)
                return typeof (DateTime);
            else
                return typeof (string);
        }

        public static object GetInfo<T>(T p, string name)
        {
            return p.GetType().GetProperty(name).GetValue(p, null);
        }

        public static bool CheckText(Control ctl, string message)
        {
            if (ctl.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show(LangBase.GetString(message));
                return false;
            }
            return true;
        }
    }
}
