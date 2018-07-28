using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class ImportInfo
    {
        [DisplayName("发货人")]
        public string senderName { get; set; }

        [DisplayName("发货人电话")]
        public string senderTel { get; set; }

        [DisplayName("收货人")]
        public string receiverName { get; set; }

        [DisplayName("收货人电话")]
        public string receiverTel { get; set; }

        [DisplayName("收货人地址")]
        public string receiverAddress { get; set; }

        [DisplayName("转运公司")]
        public string tranCompName { get; set; }

        [DisplayName("货物类型")]
        public string goodsTypeName { get; set; }

        [DisplayName("数量")]
        public string amount { get; set; }

        [DisplayName("重量/体积")]
        public string measure { get; set; }

        [DisplayName("收费类型")]
        public string unitPrice { get; set; }

        [DisplayName("国际运费")]
        public string price { get; set; }

        [DisplayName("打包方式")]
        public string packingtypeName { get; set; }

        [DisplayName("支付方式")]
        public string paytypeName { get; set; }

        [DisplayName("国内运费")]
        public string chinaprice { get; set; }

        [DisplayName("打包费")]
        public string packingprice { get; set; }

        [DisplayName("保险费")]
        public string insurance { get; set; }

        [DisplayName("总价")]
        public string sumprice { get; set; }

        [DisplayName("备注")]
        public string remark { get; set; }

        [DisplayName("货物名称")]
        public string goodsname { get; set; }
    }
}
