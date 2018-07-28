using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class BackToStockGoods
    {
        [DisplayName("单号")]
        public string BillID { get; set; }
        [DisplayName("货物名称")]
        public string GoodsTypeName { get; set; }

        public BackToStockGoods(TransferBill transferBill)
        {
            BillID = transferBill.BillID;
            GoodsTypeName = transferBill.GoodsTypeName;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", BillID, GoodsTypeName);
        }
    }
}
