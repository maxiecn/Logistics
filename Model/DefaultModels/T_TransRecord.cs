using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_TransRecord
    {
        public string BillID
        {
            get;
            set;
        }

        [Key]
        public int Seq { get; set; }
        public DateTime OperTime { get; set; }

        public string OperAction { get; set; }
    }
}
