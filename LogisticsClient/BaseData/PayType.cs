using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logistics.Models;
using LogisticsClient.AppUtils;
using Model.DefaultModels;

namespace LogisticsClient.BaseData
{
    public class PayType
    {
        private static List<T_PayType> PackingTypes = new List<T_PayType>();

        public static List<T_PayType> GetAll()
        {
                Refresh();
            return PackingTypes;
        }

        public static void Refresh()
        {
            PackingTypes = WebCall.GetMethod<List<T_PayType>>("api/PayType/get", null);
        }
    }
}
