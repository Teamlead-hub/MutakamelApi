using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class PosOperators : EntityRoot
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? UserEmail { get; set; }
        public int? UserIsActive { get; set; }
        public List<PosOperatorsdet> det { get; set; } = new List<PosOperatorsdet>();

    }
}
