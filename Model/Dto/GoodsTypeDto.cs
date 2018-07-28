using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class GoodsTypeDto
    {
        [DisplayName("编号")]
        public int GoodsTypeID
        {
            get;
            set;
        }

        [DisplayName("货物类型")]
        public string GoodsTypeName
        {
            get;
            set;
        }

        public override string ToString()
        {
            return GoodsTypeName;
        }
    }
}
