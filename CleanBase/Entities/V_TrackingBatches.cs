using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_TrackingBatches : EntityRoot
    {
        public string? BatchNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? FirstSaleDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? LastUpateDate { get; set; }

        public List<V_TrackingBatchesDetails> TrackingBatchesDetails { get; set; } = new List<V_TrackingBatchesDetails>();
    }
}
