using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class Vouchers : EntityRoot
    {
        public string? Vouchers_No { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Vouchers_EntryDate { get; set; }
        public string? Vouchers_Type { get; set; }
        public string? Vouchers_RefNo { get; set; }
        public string? Vouchers_Details { get; set; }
        public int? Vouchers_Posted { get; set; }
        public string? VoucherFType { get; set; }

        [NotMapped]
        public string? VoucherTypeDesc { get; set; }
        public string? Vouchers_Benifiet { get; set; }
        public List<Trans> Trans { get; set; } = new List<Trans>();
    } 
}
