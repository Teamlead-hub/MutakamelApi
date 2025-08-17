using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ZVanSalesMain : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Date { get; set; }
        public string? Time { get; set; }
        public string? PInvvocuherId { get; set; }

        public string? DriversId { get; set; }
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string? STOREId { get; set; }
        public string? StoreName { get; set; }
        public string? ToStore { get; set; }
        public string? ToStoreName { get; set; }
        public int? RoundEndFlag { get; set; }
        public string? RoundStart { get; set; }
        public string? RoundEnd { get; set; }

        public List<V_ZVanSalesDetails> ItemsDetails { get; set; } = new List<V_ZVanSalesDetails>();
        public List<V_ZVanSalesOrders> SalesOrders { get; set; } = new List<V_ZVanSalesOrders>();
        public List<V_ZVanSalesPayment> Payments { get; set; } = new List<V_ZVanSalesPayment>();
    }
}

