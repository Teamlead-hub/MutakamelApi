using CleanBase;
using CleanOperation.Declarations;

namespace CleanBusiness.Declarations
{
    public interface IRootService<T> : IRepository<T> where T : class, IEntityRoot
    {
   
    }
}
