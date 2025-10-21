using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_LeadDealProducts : EntityRoot
    {
        public string? Barcode { get; set; }
        public string? StockId { get; set; }
        public string? productId { get; set; }
        public string? ArabicName { get; set; }
        public string? EnglishName { get; set; }
        public string? ProductName { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? TaxRatio { get; set; }
        public decimal? Tax { get; set; }
        public decimal? RetailPrice { get; set; }
        public decimal? Disc { get; set; }
        public decimal? DiscPerc { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalAfterDisc { get; set; }
        public decimal? NetTotal { get; set; }
        public string? UnitName { get; set; }
        public decimal? PackagingQty { get; set; }
        public string? UnitId { get; set; }
        public int? DiscType { get; set; }
        public string? BonusQty { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public decimal? PriceBeforeTax { get; set; }
        public decimal? DiscValue { get; set; }
        public string? LeadsAndDealsId { get; set; }

        public decimal? Cost { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }

        public V_LeadsAndDeals? LeadsAndDeals { get; set; }
    }
}
