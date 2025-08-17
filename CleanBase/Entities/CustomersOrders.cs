using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class CustomersOrders : EntityRoot
    {
        public string? InvVoucherId { get; set; }
        public Pinvvoucher? InvVoucher { get; set; }
        public string? CustomerOrderId { get; set; }
    }
}

