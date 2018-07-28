using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_IP
    {
        [Key]
        public String ipkey { get; set; }
        public String ipvalue
        {
            get;
            set;
        }
    }
}
