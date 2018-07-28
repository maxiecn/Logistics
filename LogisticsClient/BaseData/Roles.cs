using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;using LogisticsClient.AppUtils;
using Model;

namespace LogisticsClient.BaseData
{
    public class Roles
    {
        private static List<T_Role> TransCompanies = new List<T_Role>();

        public static List<T_Role> GetAll()
        {
            if (TransCompanies == null || TransCompanies.Count == 0)
            {
                Refresh();
            }
            return TransCompanies;
        }

        public static void Refresh()
        {
            TransCompanies = WebCall.GetMethod<List<T_Role>>("Users/GetRoles", null);
        }
    }
}
