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
    public class ZVanSalesDetailsService : RootService<ZVanSalesDetails>, IZVanSalesDetailsService
    {
        public ZVanSalesDetailsService(IRepository<ZVanSalesDetails> repository) : base(repository)
        { }
    }
}
