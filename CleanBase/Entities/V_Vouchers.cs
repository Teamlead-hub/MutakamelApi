using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_Vouchers:EntityRoot
    {
        public string? Vouchers_No { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Vouchers_EntryDate { get; set; }
        public string? Vouchers_Type { get; set; }
        public string? Vouchers_RefNo { get; set; }
        public string? Vouchers_Details { get; set; }
        public int? Vouchers_Posted { get; set; }
        public string? VoucherFType { get; set; }
        public string? VoucherTypeDesc { get; set; }
        public string? Vouchers_Benifiet { get; set; }
        public List<V_Trans> Trans { get; set; } = new List<V_Trans>();
    }
}
