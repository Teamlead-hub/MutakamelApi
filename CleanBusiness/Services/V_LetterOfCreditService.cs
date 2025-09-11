using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Services
{
    public class V_LetterOfCreditService : RootService<V_LetterOfCredit>, IV_LetterOfCredit
    {
        public V_LetterOfCreditService(IRepository<V_LetterOfCredit> repository) : base(repository) { }
    
    }
}
