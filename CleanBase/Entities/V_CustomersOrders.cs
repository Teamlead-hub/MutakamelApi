using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class V_CustomersOrders : EntityRoot
    {
        public string? InvVoucherId { get; set; }
        public V_Pinvvoucher? InvVoucher { get; set; }
        public string? CustomerOrderId { get; set; }
    }
}

