using LogisticsClient.AppUtils;
using Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogisticsClient.BaseData
{
    public class Tax
    {
        private static List<TaxDto> Taxs = new List<TaxDto>();

        public static List<TaxDto> GetAll()
        {
            Refresh();
            return Taxs;
        }

        public static void Refresh()
        {
            List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
            param.Add(new KeyValuePair<string, string>("goodsname", ""));
            Taxs = WebCall.GetMethod<List<TaxDto>>("api/Tax/get", param);
        }
    }
}
