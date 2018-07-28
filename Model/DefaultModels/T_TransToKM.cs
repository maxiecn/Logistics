using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_TransToKM
    {
        [Key]
        public string BillID
        {
            get;
            set;
        }
        public Nullable<int> RecorderID
        {
            get;
            set;
        }
        public Nullable<System.DateTime> RecordTime
        {
            get;
            set;
        }
    }
}
