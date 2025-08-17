using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_Asset_Purchase : EntityRoot
    {
      

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? PurDate { get; set; }
        public string? Note { get; set; }
        public string? Supplier_No { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierInvoiceNo { get; set; }
        public string? Account_No { get; set; }
        public string? Accounts_Name { get; set; }
        public int? Posted { get; set; }
        public List<V_Asset_PurchaseDet> PurchaseDet { get; set; } = new List<V_Asset_PurchaseDet>();
    }
}
