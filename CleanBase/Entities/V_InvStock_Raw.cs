using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_InvStock_Raw : EntityRoot
    {
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public string? unit { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Packaging { get; set; }
    }
}
