using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class BackToStoreGoods
    {
        [DisplayName("单号")]
        public string BillID
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

        [DisplayName("货物数量")]
        public string Amount
        {
            get;
            set;
        }

        public BackToStoreGoods(ReceiveBill receiveBill)
        {
            BillID = receiveBill.BillID;
            GoodsTypeName = receiveBill.GoodsTypeName;
            Amount = receiveBill.Amount.ToString();
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}-{2}", this.BillID, this.GoodsTypeName, this.Amount);
        }
    }
}
