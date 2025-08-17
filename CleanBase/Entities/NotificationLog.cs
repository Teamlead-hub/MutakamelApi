using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class NotificationLog : EntityRoot
    {
        public string? FromUsersId { get; set; }

        [NotMapped]
        public string? FromUserName { get; set; }

        public string? ToUsersId { get; set; }

        [NotMapped]
        public string? ToUserName { get; set; }

        public string? NotificationMsg { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? NotificationDate { get; set; }
        public string? NotificationTime { get; set; }
        public int? IsRead { get; set; }
    }
}
