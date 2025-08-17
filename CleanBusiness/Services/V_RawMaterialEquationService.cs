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

    public class V_RawMaterialEquationService : RootService<V_RawMaterialEquation>, IV_RawMaterialEquationService
    {
        public V_RawMaterialEquationService(IRepository<V_RawMaterialEquation> repository) : base(repository)
        { }

    }
}
