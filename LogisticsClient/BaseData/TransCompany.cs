using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logistics.Models;
using LogisticsClient.AppUtils;
using Model.Dto;

namespace LogisticsClient.BaseData
{
    public class TransCompany
    {
        private static List<TransCompDto> TransCompanies = new List<TransCompDto>();

        public static List<TransCompDto> GetAll()
        {
            Refresh();
            return TransCompanies;
        }

        public static void Refresh()
        {
            TransCompanies = WebCall.GetMethod<List<TransCompDto>>("api/TransCompany/get", null);
        }
    }
}
