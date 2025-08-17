using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Allowance : EntityRoot
    {
        public string? AllowName { get; set; }
        public int? AllowType { get; set; }
        public int? AllowActive { get; set; }

    }
}
