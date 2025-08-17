
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace CleanBase.Entities
{
    public class VouchersType : EntityRoot
    {
        public string? VoucherTypeDesc { get; set; }
        public string? VoucherTypeDescEn { get; set; }
    }
}
