using System.Collections.Generic;
using Logistics.Models;
using LogisticsClient.AppUtils;
using Model.Dto;

namespace LogisticsClient.BaseData
{
    public class GoodsType
    {
        private static List<GoodsTypeDto> GoodsTypes = new List<GoodsTypeDto>();

        public static List<GoodsTypeDto> GetAll()
        {
            Refresh();
            return GoodsTypes;
        }

        public static void Refresh()
        {
            GoodsTypes = WebCall.GetMethod<List<GoodsTypeDto>>("api/GoodsType/get", null);
        }
    }
}