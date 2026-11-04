using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;

namespace CleanBusiness.Services
{
    public class V_ActiveProductionEmployeesService : RootService<V_ActiveProductionEmployees>, IV_ActiveProductionEmployeesService
    {
        public V_ActiveProductionEmployeesService(IRepository<V_ActiveProductionEmployees> repository) : base(repository) { }
    }
}
