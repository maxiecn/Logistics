using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class HintInputDto
    {
        [DisplayName("发货人")]
        public string SenderName { get; set; }
        [DisplayName("发货人电话")]
        public string SenderTel { get; set; }
        [DisplayName("收货人")]
        public string ReceiverName { get; set; }
        [DisplayName("收货人电话")]
        public string ReceiverTel { get; set; }
        [DisplayName("收货人地址")]
        public string ReceiverAddress { get; set; }

        public int? TransCompID { get; set; }
        [DisplayName("转运公司")]
        public string TransCompName { get; set; }
    }
}
