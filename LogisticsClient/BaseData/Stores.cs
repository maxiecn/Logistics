using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogisticsClient.AppUtils;
using Model.Dto;

namespace LogisticsClient.BaseData
{
    public class Stores
    {
        private static List<StoreDto> stores = new List<StoreDto>();

        public static List<StoreDto> GetAll()
        {
            Refresh();
            return stores;
        }

        public static void Refresh()
        {
            stores = WebCall.GetMethod<List<StoreDto>>("api/StoreInfo/get", null);
        }
    }
}
