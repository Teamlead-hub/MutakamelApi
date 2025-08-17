using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;


namespace CleanBusiness.Services
{
    public class V_Pmvts_BatchesService : RootService<V_Pmvts_Batches>, IV_Pmvts_BatchesService
    {
        public V_Pmvts_BatchesService(IRepository<V_Pmvts_Batches> repository) : base(repository)
        { }
    }
}
