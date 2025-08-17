using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_SearchProductPackaging : EntityRoot
    {
        public string? ProductId { get; set; }
        public string? StockId { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? TaxRatio { get;set; }

    }
}
