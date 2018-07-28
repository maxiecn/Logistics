using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class TransCompDto
    {
        [DisplayName("转运公司编号")]
        public int TransID { get; set; }

        [DisplayName("转运公司名称")]
        public string TransCompName { get; set; }

        [DisplayName("转运公司代号")]
        public string TransCode { get; set; }

        [DisplayName("运单长度")]
        public int BillLength { get; set; }

        public override string ToString()
        {
            return TransCompName;
        }
    }
}
