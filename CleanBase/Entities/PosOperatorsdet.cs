using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosOperatorsdet : EntityRoot
    {
        public string? PosOperatorsId { get; set; }
        public string? PosOperationsId { get; set; }
        public int? allowed { get; set; }
        public PosOperators posOperators { get; set; }
    }
}
