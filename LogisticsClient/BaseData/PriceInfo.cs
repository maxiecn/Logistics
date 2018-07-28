using System.Collections.Generic;
using Logistics.Models;
using LogisticsClient.AppUtils;
using Model.Dto;

namespace LogisticsClient.BaseData
{
    public class PriceInfo
    {
        private static List<PriceInfoDto> PriceInfos = new List<PriceInfoDto>();

        public static List<PriceInfoDto> GetAll()
        {
            Refresh();
            return PriceInfos;
        }

        public static void Refresh()
        {
            PriceInfos = WebCall.GetMethod<List<PriceInfoDto>>("api/PriceInfo/get", null);
        }
    }
}