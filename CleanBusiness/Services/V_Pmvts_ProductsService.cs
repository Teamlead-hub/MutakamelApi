using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;


namespace CleanBusiness.Services
{
    public class V_Pmvts_ProductsService : RootService<V_Pmvts_Products>, IV_Pmvts_ProductsService
    {
        public V_Pmvts_ProductsService(IRepository<V_Pmvts_Products> repository) : base(repository)
        { }
    }
}
