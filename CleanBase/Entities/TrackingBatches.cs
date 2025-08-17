using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class TrackingBatches : EntityRoot
    {
        public string? BatchNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? FirstSaleDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? LastUpateDate { get; set; }
        public List<TrackingBatchesDetails> TrackingBatchesDetails { get; set; } = new List<TrackingBatchesDetails>();
    }
}
