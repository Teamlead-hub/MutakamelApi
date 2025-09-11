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
    public class LetterOfCreditService : RootService<LetterOfCredit>, ILetterOfCredit
    {
        public LetterOfCreditService(IRepository<LetterOfCredit> repository) : base(repository)
        {
        }
    }
}
