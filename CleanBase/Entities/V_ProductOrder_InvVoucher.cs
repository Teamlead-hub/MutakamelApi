using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrder_InvVoucher : EntityRoot
    {
        public string? ProductOrderId { get; set; }
        public string? VchrNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? OrderDate { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? VchrDate { get; set; }
        public string? ProductId { get; set; }
        public string? vchrtype { get; set; }
        public string? ProductName { get; set; }
        public string? ManagerName { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Density { get; set; }
        public string? ProductOrderBatch { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? DateProduct { get; set; }
        public string? ProductOrderReportId { get; set; }
        public string? BatchNo { get; set; }
        public int? RecordUsed { get; set; }

        public List<V_ProductOrder_mvts> mvts { get; set; }=new List<V_ProductOrder_mvts>();
    }
}
