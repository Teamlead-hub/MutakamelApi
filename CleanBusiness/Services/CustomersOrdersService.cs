using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;


namespace CleanBusiness.Services
{
    public class CustomersOrdersService : RootService<CustomersOrders>, ICustomersOrdersService
    {
        public CustomersOrdersService(IRepository<CustomersOrders> repository) : base(repository)
        { }
    }
}
