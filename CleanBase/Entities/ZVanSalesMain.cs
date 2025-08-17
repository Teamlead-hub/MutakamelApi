using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ZVanSalesMain : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date { get; set; }
        public string? Time { get; set; }
        public string? PInvvocuherId { get; set; }


        [NotMapped]
        public string? DriversId { get; set; }
        [NotMapped]
        public string? AreaId { get; set; }
        [NotMapped]
        public string? AreaName { get; set; }
        [NotMapped]
        public string? STOREId { get; set; }
        [NotMapped]
        public string? StoreName { get; set; }
        [NotMapped]
        public string? ToStore { get; set; }
        [NotMapped]
        public string? ToStoreName { get; set; }
        [NotMapped]
        public int? RoundEndFlag { get; set; }
        [NotMapped]
        public string? RoundStart { get; set; }
        [NotMapped]
        public string? RoundEnd { get; set; }

        public List<ZVanSalesDetails> ItemsDetails { get; set; } = new List<ZVanSalesDetails>();
        public List<ZVanSalesOrders> SalesOrders { get; set; } = new List<ZVanSalesOrders>();
        public List<ZVanSalesPayment> Payments { get; set; } = new List<ZVanSalesPayment>();
    }
}

