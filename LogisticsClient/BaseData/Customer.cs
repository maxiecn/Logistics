using System.Collections.Generic;
using LogisticsClient.AppUtils;
using Model;

namespace LogisticsClient.BaseData
{
    public class Customer
    {
        private static List<T_Customer> Customers = new List<T_Customer>();

        public static List<T_Customer> GetAll()
        {
            Refresh();
            return Customers;
        }

        public static void Refresh()
        {
            Customers = WebCall.GetMethod<List<T_Customer>>("api/Customer/get", null);
        }
    }
}