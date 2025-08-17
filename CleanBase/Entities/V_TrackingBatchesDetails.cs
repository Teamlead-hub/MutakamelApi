using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_TrackingBatchesDetails : EntityRoot
    {
        public string? InvVoucherId { get; set; }
        public string? methodOfUse { get; set; }
        public string? BatchNo { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public decimal? PhoneNo { get; set; }
        public string? signature { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }
        public V_TrackingBatches? TrackingBatches { get; set; }
        public string? TrackingBatchesId { get; set; }
    }
}
