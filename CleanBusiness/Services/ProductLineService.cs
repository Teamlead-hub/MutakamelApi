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
    public class ProductLineService : RootService<ProductLine>, IProductLineService
    {
        public ProductLineService(IRepository<ProductLine> repository) : base(repository)
        { }
    }
}
