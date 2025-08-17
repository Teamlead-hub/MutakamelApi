using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;


namespace CleanBusiness.Services
{
    public class V_PmvtsService : RootService<V_Pmvts>, IV_PmvtsService
    {
        public V_PmvtsService(IRepository<V_Pmvts> repository) : base(repository)
        { }
    }
}
