using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class LoginPos : EntityRoot
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public List<LoginPosDet> det { get; set; } = new List<LoginPosDet>();

    }
}
