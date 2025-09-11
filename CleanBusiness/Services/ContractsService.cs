using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.DataAccess;
using CleanOperation.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Services
{
    public class ContractsService : RootService<Contracts>, IContracts
    {

        public ContractsService(IRepository<Contracts> repository) : base(repository)
        {
        }

    }
}
