using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_Transinfos
    {
        [Key, Column(Order = 1)]
        public String BillID { get; set; }

        [Key, Column(Order = 2)]
        public String Company { get; set; }

        public String TransInfo { get ; set; }
    }
}
