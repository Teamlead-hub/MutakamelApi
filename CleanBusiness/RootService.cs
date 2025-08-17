using CleanBase;
using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation;
using CleanOperation.Declarations;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System.Data.Common;
using System.Linq.Expressions;

namespace CleanBusiness
{
    public class RootService<T> : CleanAspects, IRootService<T> where T : class, IEntityRoot
    {
        public readonly IRepository<T> _repository;
        public RootService(IRepository<T> repository)
        {
            _repository = repository;
        }
        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }

        public void Delete(List<T> entities)
        {
            _repository.Delete(entities);
        }

        public async Task<IEnumerable<T>> Execute(string storedProcedureName, Dictionary<string, object> parameters)
        {
            if (string.IsNullOrWhiteSpace(storedProcedureName))
            {
                throw new ArgumentNullException(nameof(storedProcedureName));
            }

            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            return await _repository.Execute(storedProcedureName, parameters);
        }

        public async Task<IEnumerable<T?>> ExecuteAsync<T>(string storedProcedureName, Dictionary<string, object> parameters)
        {
            if (string.IsNullOrWhiteSpace(storedProcedureName))
            {
                throw new ArgumentNullException(nameof(storedProcedureName));
            }

            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            // Directly call the underlying repository's ExecuteAsync method for database execution
            return await _repository.ExecuteAsync<T>(storedProcedureName, parameters);
        }

        public T? Get(string id, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includedNavigations = null)
        {
            return _repository.Get(id, includedNavigations);
        }

        public T? Get(Expression<Func<T, bool>> query, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includedNavigations = null)
        {
            return _repository.Get(query, includedNavigations);
        }

        public async Task<T?> GetAsync(string id, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includedNavigations = null)
        {
            return await _repository.GetAsync(id, includedNavigations);
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> query, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includedNavigations = null)
        {
            return await _repository.GetAsync(query, includedNavigations);
        }

        public T Insert(T entity)
        {
            return _repository.Insert(entity);
        }

        public List<T> Insert(List<T> entities)
        {
            return _repository.Insert(entities);
        }

        public async Task<T?> InsertAsync(T entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task InsertAsync(List<T> entities)
        {
            await _repository.InsertAsync(entities);
        }

        public IQueryable<T?> Query()
        {
            return _repository.Query();
        }

        public EntityEntry<T> Update(T entity)
        {
            return _repository.Update(entity);
        }

        public void Update(List<T> entities)
        {
            _repository.Update(entities);
        }

        public async Task<T?> DeleteAsync(T entity)
        {
            return await _repository.DeleteAsync(entity);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _repository.SaveChangesAsync();
        }

        public async Task<DbTransaction> BeginTransactionAsync()
        {
            return await _repository.BeginTransactionAsync();
        }

        public async Task<bool> ExecuteWithTransactionAsync(Func<Task> action)
        {
            using (var transaction = await BeginTransactionAsync())
            {
                try
                {
                    await action();
                    await transaction.CommitAsync();
                    return true;
                }
                catch
                {
                    await transaction.RollbackAsync();
                    return false;
                }
            }
        }

        EntityEntry<T> IRepository<T>.UpdateWithChildrenn(T entity)
        {
            return _repository.UpdateWithChildrenn(entity);
        }

        Task<T?> IRepository<T>.FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _repository.FirstOrDefaultAsync(predicate);
        }
   
    }
}
