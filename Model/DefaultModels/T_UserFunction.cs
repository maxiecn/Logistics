using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Model.DefaultModels
{
    public class T_UserFunction
    {
        [Key, Column(Order = 1)]
        public int UserID
        {
            get;
            set;
        }

        [Key, Column(Order = 2)]
        public int FunctionID
        {
            get;
            set;
        }
    }
}
