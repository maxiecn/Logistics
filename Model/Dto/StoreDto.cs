using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class StoreDto
    {
        [DisplayName("门店编号")]
        public int StoreID { get; set; }

        [DisplayName("门店名称")]
        public string StoreName { get; set; }

        public override string ToString()
        {
            return StoreName;
        }
    }
}
