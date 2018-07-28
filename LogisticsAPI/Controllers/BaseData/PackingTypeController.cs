using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Logistics.Models;
using LogisticsAPI.Models;

namespace LogisticsAPI.Controllers
{
    public class PackingTypeController : ApiController
    {
        public List<T_PackingType> Get()
        {
            using (var db = new LogisticsContext())
            {
                return db.T_PackingType.ToList();
            }
        }
    }
}