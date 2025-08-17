using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class TrackingBatchesDetails : EntityRoot
    {
        public string? InvVoucherId { get; set; }
        public string? methodOfUse { get; set; }
        [NotMapped]
        public string? BatchNo { get; set; }
        [NotMapped]
        public string? CustomerId { get; set; }
        [NotMapped]
        public string? CustomerName { get; set; }
        [NotMapped]
        public decimal? PhoneNo { get; set; }
        [NotMapped]
        public string? signature { get; set; }

        [NotMapped]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }

        public TrackingBatches? TrackingBatches { get; set; }

        public string? TrackingBatchesId { get; set; }
    }
}
