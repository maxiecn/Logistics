using System;
using System.ComponentModel;

namespace Model
{
    public class ReceiveBill
    {
       
        
        [DisplayName("收货时间")]
        public DateTime? RecordTime { get; set; }

        [DisplayName("单号")]
        public string BillID { get; set; }

        [DisplayName("密码")]
        public string Password { get; set; }

        public int CustomerID { get; set; }

        [DisplayName("发货人姓名")]
        public string SenderName { get; set; }

        [DisplayName("发货人电话")]
        public string SenderTel { get; set; }

        [DisplayName("货物类型")]
        public string GoodsTypeName { get; set; }

        [DisplayName("货物名称")]
        public string GoodsName
        {
            get;
            set;
        }

        [DisplayName("体积/重量")]
        public float? Measure { get; set; }

        [DisplayName("数量")]
        public int? Amount { get; set; }


        [DisplayName("打包类型")]
        public string PackingTypeName { get; set; }

        [DisplayName("单价")]
        public Nullable<int> UnitPrice { get; set; }

        [DisplayName("面单费")]
        public int BillFee { get; set; }

        [DisplayName("国际运费")]
        public int? Price { get; set; }

        [DisplayName("国内运费")]
        public Nullable<int> ChinaPrice { get; set; }

        [DisplayName("打包费")]
        public Nullable<int> PackingPrice { get; set; }

        [DisplayName("保险")]
        public Nullable<int> InsurancePrice { get; set; }

        [DisplayName("总价")]
        public Nullable<int> SumPrice { get; set; }



        [DisplayName("收货人姓名")]
        public string ReceiverName { get; set; }

        [DisplayName("收货人电话")]
        public string ReceiverTel { get; set; }

        [DisplayName("收货人地址")]
        public string ReceiverAddress { get; set; }

        [DisplayName("货物类型")]
        public int? GoodsType { get; set; }





        [DisplayName("打包类型")]
        public int? PackingType { get; set; }



        [DisplayName("操作人编号")]
        public int? RecorderID { get; set; }

        [DisplayName("经办人姓名")]
        public string RecorderName { get; set; }


        [DisplayName("转运公司编号")]
        public int? TransCompID { get; set; }

        [DisplayName("转运公司名称")]
        public string TransCompName { get; set; }

        [DisplayName("转运单号")]
        public string TransBill { get; set; }

        [DisplayName("转运时间")]
        public DateTime? TransTime { get; set; }

        [DisplayName("转运经办人编号")]
        public int? TransRecorderID { get; set; }

        [DisplayName("转运经办人姓名")]
        public string TransRecorderName { get; set; }

        [DisplayName("最后操作时间")]
        public DateTime? ModifyTime { get; set; }

        [DisplayName("收货商店编号")]
        public int? StoreID { get; set; }

        [DisplayName("收货商店名称")]
        public string StoreName { get; set; }

        [DisplayName("收费方式编号")]
        public int? PriceType { get; set; }

        [DisplayName("收费方式")]
        public string PriceTypeName { get; set; }

        [DisplayName("状态编号")]
        public string Status { get; set; }

        [DisplayName("状态")]
        public string StatusName { get; set; }

        [DisplayName("支付方式编号")]
        public int PayType { get; set; }

        [DisplayName("支付方式")]
        public string PayTypeName { get; set; }

        [DisplayName("备注")]
        public string Remark { get; set; }



        [DisplayName("已收款")]
        public string hasReceiveMoneyDisplay
        {
            get { return hasReceiveMoney ? "已收款" : "未收款"; }
        }

        public bool hasReceiveMoney { get; set; }

        [DisplayName("收款人编号")]
        public int MoneyReceiver { get; set; }

        [DisplayName("收款人姓名")]
        public string MoneyReceiverName { get; set; }

        [DisplayName("收款时间")]
        public DateTime? MoneyReceiveTime { get; set; }

        [DisplayName("收款备注")]
        public string MoneyReceiveRemark { get; set; }

        [DisplayName("身份证号")]
        public string IdCard
        {
            get; set;
        }

        [DisplayName("认定价格")]
        public int CIQPrice
        {
            get; set;
        }

        [DisplayName("税率")]
        public int TaxRate
        {
            get; set;
        }

        [DisplayName("税额")]
        public int TaxPrice
        {
            get; set;
        }
    }
}