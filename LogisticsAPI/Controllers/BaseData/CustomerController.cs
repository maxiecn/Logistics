using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using LogisticsAPI.Models;
using Model;

namespace LogisticsAPI.Controllers.BaseData
{
    public class CustomerController : ApiController
    {
        public List<T_Customer> Get()
        {
            using (var db = new LogisticsContext())
            {
                return db.T_Customer.ToList();
            }
        }

        [HttpPost]public void Post(List<T_Customer> customers)
        {
            using (var db = new LogisticsContext())
            {
                foreach (T_Customer goods in customers)
                {
                    var exsitedCustomer = db.T_Customer.Where(a => a.SenderName == goods.SenderName && a.SenderTel == goods.SenderTel && a.CustomerName == goods.CustomerName && a.Tel == goods.Tel && a.Address == goods.Address).ToList();
                    if (exsitedCustomer.Count == 0)
                    {
                        T_Customer customer = new T_Customer
                        {
                            SenderName = goods.SenderName,
                            SenderTel = goods.SenderTel,
                            CustomerName = goods.CustomerName,
                            Tel = goods.Tel,
                            Address = goods.Address,
                            TransID = goods.TransID == null ? 0 : Convert.ToInt16(goods.TransID)
                        };
                        db.T_Customer.Add(customer);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}