using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_TransToKMDetail
    {
        [Key, Column(Order = 1)]
        public string BillID
        {
            get;
            set;
        }
        [Key, Column(Order = 2)]
        public string GoodsID
        {
            get;
            set;
        }
        public string GoodsStatu
        {
            get;
            set;
        }
        public Nullable<int> ReceiverID
        {
            get;
            set;
        }
        public Nullable<System.DateTime> ReceiveTime
        {
            get;
            set;
        }
    }
}
