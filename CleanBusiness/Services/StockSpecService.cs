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
    public class StockSpecService : RootService<StockSpec>, IStockSpecService
    {
        public StockSpecService(IRepository<StockSpec> repository) : base(repository)
        { }
    }
}
