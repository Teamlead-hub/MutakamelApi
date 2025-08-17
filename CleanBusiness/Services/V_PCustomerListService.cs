using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;


namespace CleanBusiness.Services
{
    public class V_PCustomerListService : RootService<V_PCustomerList>, IV_PCustomerListService
    {
        public V_PCustomerListService(IRepository<V_PCustomerList> repository) : base(repository)
        { }
    }
}
