using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Currency:EntityRoot
    {
        public string? CurrencyName { get; set; }
        public decimal?  ValueInJd{ get; set; }
        public string? CurrencySymbol { get; set;}
        public int? FlagMain { get; set;}

    }
}
