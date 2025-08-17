using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class v_AcGroups : EntityRoot
    {
        public string? AcGroups_Name { get; set; }
        public decimal? Lastserial { get; set; }
        public string? BalanceSheet { get; set; }
        public string? level1 { get; set; }
        public string? level1_Name { get; set; }
        public string? level2 { get; set; }
        public string? level2_Name { get; set; }
        public string? level3 { get; set; }
        public string? level3_Name { get; set; }



    }
}
