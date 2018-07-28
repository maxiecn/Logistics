using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class FunctionDto
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public int ParentID { get; set; }
    }
}
