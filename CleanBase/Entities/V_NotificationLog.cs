using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace CleanBase.Entities
{
    public class V_NotificationLog : EntityRoot
    {
        public string? FromUsersId { get; set; }
        public string? FromUserName { get; set; }
        public string? ToUsersId { get; set; }
        public string? ToUserName { get; set; }
        public string? NotificationMsg { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? NotificationDate { get; set; }
        public string? NotificationTime { get; set; }
        public int? IsRead { get; set; }
    }
}
