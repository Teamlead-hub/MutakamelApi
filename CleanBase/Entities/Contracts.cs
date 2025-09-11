using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Contracts : EntityRoot
    {
        public string ContractNumber { get; set; }

        public string ContractSubject { get; set; }

        public DateTime ContractDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal TotalValue { get; set; }

        public string Currency { get; set; }

        public string FirstParty { get; set; }

        public string SecondParty { get; set; }

        public string Status { get; set; }

        public string Notes { get; set; }

        public List<ContractItems> contractItems { get; set; } = new List<ContractItems>();

    }
}
