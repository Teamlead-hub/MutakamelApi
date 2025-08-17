using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ConsumableType : EntityRoot
    {
        public string? ConsumableTypeName { get; set; }
        public string? ConsumableTypeNameAr { get; set; }
    }
}
