using System.Data.Entity;
using Logistics.Models;
using Model;
using Model.DefaultModels;

namespace LogisticsAPI.Models
{
    public class LogisticsContext : DbContext
    {
        public LogisticsContext()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<T_Goods> T_Goods { get; set; }

        public virtual DbSet<T_GoodsTrans> T_GoodsTrans { get; set; }

        public virtual DbSet<T_GoodsTransDetail> T_GoodsTransDetail { get; set; }

        public virtual DbSet<T_GoodsType> T_GoodsType { get; set; }

        public virtual DbSet<T_PackingType> T_PackingType { get; set; }

        public virtual DbSet<T_PriceInfo> T_PriceInfo { get; set; }

        public virtual DbSet<T_Store> T_Store { get; set; }

        public virtual DbSet<T_TransCompany> T_TransCompany { get; set; }

        public virtual DbSet<T_TransRecord> T_TransRecord { get; set; }

        public virtual DbSet<T_Users> T_Users { get; set; }

        public virtual DbSet<T_Customer> T_Customer { get; set; }
        public virtual DbSet<T_Role> T_Roles { get; set; }
        public virtual DbSet<T_Status> T_Status { get; set; }

        public virtual DbSet<T_Log> T_Logs { get; set; }

        public virtual DbSet<T_TransToKM> T_TransToKM { get; set; }
        public virtual DbSet<T_TransToKMDetail> T_TransToKMDetail { get; set; }

        public virtual DbSet<T_PayType> T_PayType { get; set; }

        public virtual DbSet<T_Functions> T_Functions { get; set; }
        public virtual DbSet<T_UserFunction> T_UserFunctions { get; set; }
        public virtual DbSet<T_PayAmount> T_PayAmount { get; set; }

        public virtual DbSet<T_Transinfos> T_Transinfos { get; set; }

        public virtual DbSet<T_IP> T_IP { get; set; }
        public virtual DbSet<T_Tax> T_Tax
        {
            get;set;
        }
    }
}