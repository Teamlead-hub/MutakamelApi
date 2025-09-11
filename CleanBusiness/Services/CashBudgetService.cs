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
    public class CashBudgetService : RootService<CashBudget>, ICashBudgetService
    {
        public CashBudgetService(IRepository<CashBudget> repository) : base(repository) { }

    }
}
