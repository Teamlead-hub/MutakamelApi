using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosVoidDetails : EntityRoot
    {
        public string? ItemNo { get; set; }

        [Column(TypeName = "numeric(27, 3)")]
        public decimal? Qty { get; set; }

        [Column(TypeName = "numeric(27, 3)")]
        public decimal? RetailPrice { get; set; }

        public string? BarCode { get; set; }

        public DateTime? VoidDate { get; set; }

        public DateTime? VoidTime { get; set; }

        public string? OperatorId { get; set; }

        public string? SuperOperatorId { get; set; }

        public string? PosId { get; set; }

        public string? StoreNo { get; set; }

        public string? ZFile { get; set; }
    }
}
