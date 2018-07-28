using System.Collections.Generic;
using Logistics.Models;
using LogisticsClient.AppUtils;

namespace LogisticsClient.BaseData
{
    public class PackingType
    {
        private static List<T_PackingType> PackingTypes = new List<T_PackingType>();

        public static List<T_PackingType> GetAll()
        {
                Refresh();
            return PackingTypes;
        }

        public static void Refresh()
        {
            PackingTypes = WebCall.GetMethod<List<T_PackingType>>("api/PackingType/get", null);
        }
    }
}