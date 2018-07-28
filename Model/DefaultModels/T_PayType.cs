using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_PayType
    {
        [Key]
        public int PayID { get; set; }

        public string PayName { get; set; }

        public override string ToString()
        {
            return PayName;
        }
    }
}
