using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class CustomerClassification: EntityRoot
    {
        public string? classificationName { get; set; }
        public int? DiscType { get; set; }
        public decimal? Disc { get; set; }

    }
}
