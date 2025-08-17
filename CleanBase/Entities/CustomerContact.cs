using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class CustomerContact : EntityRoot
    {
        public string? ContactName { get; set; }
        public string? ContactMethod { get; set; }
        public string? ContactTitle { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ContactDate { get; set; }
        public string? ContactPhone { get; set; }
        public string? CustomerId { get; set; }
        public Customer? Customer { get; set; }

    }
}
