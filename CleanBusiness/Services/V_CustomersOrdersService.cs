using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;


namespace CleanBusiness.Services
{
    public class V_CustomersOrdersService : RootService<V_CustomersOrders>, IV_CustomersOrdersService
    {
        public V_CustomersOrdersService(IRepository<V_CustomersOrders> repository) : base(repository)
        { }
    }
}
