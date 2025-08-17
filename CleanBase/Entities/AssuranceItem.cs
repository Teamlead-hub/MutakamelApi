using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class AssuranceItem:EntityRoot
    {
        public string? AssuranceItemDesc { get; set; }
        public decimal? Amounts { get; set; }
       
    }
}
