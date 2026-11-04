using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;

namespace CleanBusiness.Services
{
    public class V_WeeklyPlanDetEmployeesService : RootService<V_WeeklyPlanDetEmployees>, IV_WeeklyPlanDetEmployeesService
    {
        public V_WeeklyPlanDetEmployeesService(IRepository<V_WeeklyPlanDetEmployees> repository) : base(repository)
        { }
    }
}
