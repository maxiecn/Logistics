using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_Log
    {
        [Key]
        public int ID { get; set; }

        public int OperID { get; set; }
        public DateTime OperTime { get; set; }

        public string Operation { get; set; }
    }
}
