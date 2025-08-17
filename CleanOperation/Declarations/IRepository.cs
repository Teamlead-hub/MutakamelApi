using CleanBase;
using CleanBase.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System.Data.Common;
using System.Linq.Expressions;

namespace CleanOperation.Declarations
{
    public interface IRepository<T> where T : class, IEntityRoot
    {
        T? Get(string id, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includedNavigations = null);
        T? Get(Expression<Func<T, bool>> query, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includedNavigations = null);
        T Insert(T entity);
        EntityEntry<T> Update(T entity);
        void Delete(T entity);
        void Delete(string id);
        Task<T?> GetAsync(string id, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includedNavigations = null);
        Task<T?> GetAsync(Expression<Func<T, bool>> query, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includedNavigations = null);
        Task<T?> InsertAsync(T entity);
        List<T> Insert(List<T> entities);
        Task InsertAsync(List<T> entity);
        void Update(List<T> entities);
        void Delete(List<T> entities);
        IQueryable<T?> Query();
        //Task<IEnumerable<T>> ExecuteAsync(string storedProcedureName, Dictionary<string, object> parameters);
        Task<IEnumerable<T?>> ExecuteAsync<T>(string storedProcedureName, Dictionary<string, object> parameters);
        Task<IEnumerable<T>> Execute(string storedProcedureName, Dictionary<string, object> parameters);
        Task<T?> DeleteAsync(T entity);
        Task<int> SaveChangesAsync(); // Add this line
        Task<DbTransaction> BeginTransactionAsync(); // Add this line
        EntityEntry<T> UpdateWithChildrenn(T entity);
        Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }

}
