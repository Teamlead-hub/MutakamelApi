using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class IncrementMain : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EntryDate { get; set; }
        public int? Post { get; set; }

        public List<IncrementDetails> Det { get; set; } = new List<IncrementDetails>();
    }
}
