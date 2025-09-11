using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public  class V_LcDocs :EntityRoot
    {     
        public string? DocName { get; set; }

        public int? flag { get; set; }

        public string? LetterOfCreditId { get; set; }
        public string? DocNo { get; set; }
        public V_LetterOfCredit? letterOfCredit { get; set; }
    }
}
