using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_OverTimeMain:EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EntryDate { get; set; }
        public int? TheMonth { get; set; }
        public int? PostFlag { get; set; }
        public List<V_OverTimeDetails> Det { get; set; } = new List<V_OverTimeDetails>();

    }
}
