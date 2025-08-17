using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class QueryGeneric
    {
        public string? Table { get; set; }
        public string[]? Columns { get; set; }
        public string? Where { get; set; }
        public string? OrderBy { get; set; }
        public int? Page { get; set; }
        public int? PageSize { get; set; }
    }

}
