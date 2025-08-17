using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Banks:EntityRoot
    {
        public string? BankName { get; set; }
        public string? BankAccountNo { get; set; }

    }
}
