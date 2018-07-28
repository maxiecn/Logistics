using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class Kuaidi100
    {
        public class BaseResult
        {
            public Transinfo lastResult
            {
                get;
                set;
            }
        }

        public class Transinfo
        {
            public string com
            {
                get;
                set;
            }

            public string nu
            {
                get;
                set;
            }
        }
    }
}
