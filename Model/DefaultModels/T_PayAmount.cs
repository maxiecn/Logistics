using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_PayAmount
    {
        [Key]
        public int PayID { get; set; }

        public string BillIDs { get; set; }

        public int MoneyAmount { get; set; }

        public DateTime PayDate { get; set; }
        public string Remark { get; set; }
    }
}
