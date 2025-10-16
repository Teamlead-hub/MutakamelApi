using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class LoginPosDet : EntityRoot
    {
        public string? PosOperatorsId { get; set; }
        public string? OperationAllowed { get; set; }
        public LoginPos LoginPos { get; set; }
    }
}
