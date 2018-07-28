using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class PriceInfoDto
    {
        [DisplayName("收费类型编号")]
        public int PriceID
        {
            get;
            set;
        }

        [DisplayName("收费类型编号")]
        public string PriceName
        {
            get;
            set;
        }

        [DisplayName("单价")]
        public Nullable<int> UnitPrice
        {
            get;
            set;
        }

        public override string ToString()
        {
            return PriceName;
        }
    }
}
