using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Dto;

namespace Model.CallResult
{
    public class QueryListResult : WebResult
    {
        public List<QueryDetailDto> Data { get; set; }
    }
}
