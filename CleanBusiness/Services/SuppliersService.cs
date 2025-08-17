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

    public class SuppliersService : RootService<Suppliers>, ISuppliersService

    {
        public SuppliersService(IRepository<Suppliers> repository) : base(repository)
        { }
    }
}
