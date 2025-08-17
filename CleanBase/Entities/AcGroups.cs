using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class AcGroups : EntityRoot
    {
        public string? AcGroups_Name { get; set; }
        public decimal? Lastserial { get; set; }
        public string? BalanceSheet { get; set; }
        [NotMapped]
        public string? level1 { get; set; }
        [NotMapped]
        public string? level1_Name { get; set; }
        [NotMapped]
        public string? level2 { get; set; }
        [NotMapped]
        public string? level2_Name { get; set; }
        [NotMapped]
        public string? level3 { get; set; }
        [NotMapped]
        public string? level3_Name { get; set; }
    }
}
