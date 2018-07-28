using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class ReceiveDto
    {
        public string BillID { get; set; }
        public string SenderName { get; set; }
        public string SenderTel { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverTel { get; set; }
        public string ReceiverAddress { get; set; }
        public int GoodsType { get; set; }
        //public float Volume { get; set; }
        //public float Weight { get; set; }

        public string GoodsName { get; set; }

        public float Measure { get; set; }
        public int Amount { get; set; }
        public int PackingType { get; set; }
        public int Price { get; set; }
        public Nullable<int> ChinaPrice { get; set; }
        public Nullable<int> PackingPrice { get; set; }
        public Nullable<int> InsurancePrice { get; set; }
        public Nullable<int> SumPrice { get; set; }
        public int RecorderID { get; set; }

        [Display(Name = "收货时间")]
        public DateTime RecordTime
        {
            get; set; 
        }

        public Nullable<int> UnitPrice { get; set; }

        public int StoreID { get; set; }
        public int PriceType { get; set; }

        public string DecryptBillID { get; set; }

        public int PayType { get; set; }
        public string Remark { get; set; }
        public int TransID { get; set; }

        public string TransName { get; set; }

        public bool hasReceiveMoney
        {
            get;
            set;
        }
        public int MoneyReceiver
        {
            get;
            set;
        }

        public string MoneyReceiverName { get; set; }

        public string MoneyReceiveTime { get; set; }

        public int BillFee { get; set; }

        public string IdCard
        {
            get; set;
        }

        public int CIQPrice
        {
            get; set;
        }

        public int TaxRate
        {
            get; set;
        }

        public int TaxPrice
        {
            get; set;
        }
    }
}
