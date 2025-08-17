using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MaterialInvoice : EntityRoot
    {
        public string? StockId { get; set; }
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public decimal? Week1 { get; set; }
        public decimal? Week2 { get; set; }
        public decimal? Week3 { get; set; }
        public decimal? Week4 { get; set; }
        public decimal? Total { get; set; }
    }
}
