using Logistics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class TaxDto
    {
        [Key]
        [DisplayName("商品编号")]
        public int GoodsID
        {
            get; set;
        }

        [DisplayName("商品名称")]
        public string GoodsName
        {
            get; set;
        }

        [DisplayName("海关定价")]
        public int Price
        {
            get; set;
        }

        [DisplayName("税率")]
        public int TaxRate
        {
            get; set;
        }

        public override string ToString()
        {
            return GoodsName + ":" + Price.ToString() + "-" + TaxRate.ToString();
            ;
        }
    }
}
