using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dto
{
    public class ModifyFunctionPara
    {
        public UserDto user { get; set; }
        public List<FunctionDto> functions { get; set; }
    }
}
