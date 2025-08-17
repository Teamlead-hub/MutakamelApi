using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Asset_Purchase : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? PurDate { get; set; }
        public string? Note { get; set; }
        public string? Supplier_No { get; set; }
        [NotMapped]
        public string? SupplierName { get; set; }
        public string? SupplierInvoiceNo { get; set; }
        public string? Account_No { get; set; }
        [NotMapped]
        public string? Accounts_Name { get; set; }
        public int? Posted { get; set; }
        public List<Asset_PurchaseDet> PurchaseDet { get; set; } = new List<Asset_PurchaseDet>();

    }
}
