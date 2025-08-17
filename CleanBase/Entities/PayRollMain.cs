using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PayRollMain : EntityRoot
    {
        public decimal? BasicSal { get; set; }
        public decimal? SocSec { get; set; }
        public decimal? Tax { get; set; }
        public decimal? fund { get; set; }
        public decimal? health { get; set; }

        public List<PayRollMonthly> Det { get; set; } = new List<PayRollMonthly>();

    }
}
