using Ardalis.GuardClauses;
using CleanBase;
using CleanBase.Entities;
using CleanOperation.Declarations;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using System.Text.Json;
using System.Linq;

namespace CleanOperation.DataAccess
{
    public class Repository<T> : RepoAspects, IRepository<T> where T : class, IEntityRoot
    {
        private readonly AppDataContext _dataContext;

        public Repository(AppDataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
            Guard.Against.Null(_dataContext);
        }

        public void Delete(T entity)
        {
            Guard.Against.Null(entity, nameof(entity), "Please provide an entity");
            Aspect(() =>
            {
                _dataContext.Remove(entity);
            });
        }


        //public void Delete(string id)
        //{
        //    Guard.Against.NullOrEmpty(id);
        //    Aspect(() =>
        //    {
        //        string sql = "DELETE FROM stock WHERE Id = @Id";
        //        _dataContext.Database.ExecuteSqlRaw(sql, new SqlParameter("@Id", id));
        //    });
        //}

        public void Delete(string id)
        {
            Guard.Against.NullOrEmpty(id);
            Aspect(() =>
            {
                var item = Get(id);
                _dataContext.Remove(item);
            });
        }

        public void Delete(List<T> entities)
        {
            Guard.Against.Null(entities);
            Aspect(() =>
            {
                entities.ForEach(e => Delete(e.Id));
            });
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

            // Convert parameters to SQL parameters
            var sqlParameters = parameters.Select(param =>
            {
                if (param.Value is JsonElement jsonElement)
                {
                    switch (jsonElement.ValueKind)
                    {
                        case JsonValueKind.String:
                            return new SqlParameter(param.Key, (object)jsonElement.GetString() ?? DBNull.Value);
                        case JsonValueKind.Number:
                            return new SqlParameter(param.Key, jsonElement.GetInt32());
                        case JsonValueKind.True:
                        case JsonValueKind.False:
                            return new SqlParameter(param.Key, jsonElement.GetBoolean());
                        default:
                            return new SqlParameter(param.Key, DBNull.Value);
                    }
                }

                return new SqlParameter(param.Key, param.Value ?? DBNull.Value);
            }).ToArray();

            // Construct raw SQL command
            var rawSql = $"EXEC {storedProcedureName} {string.Join(", ", parameters.Keys)}";

            var rawResult = new List<Dictionary<string, object>>();

            await using (var command = _dataContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = rawSql;
                command.Parameters.AddRange(sqlParameters);

                if (command.Connection.State != System.Data.ConnectionState.Open)
                {
                    await command.Connection.OpenAsync();
                }

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        // Create a dictionary to hold the column name and value pairs for each row
                        var resultDictionary = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var columnName = reader.GetName(i);
                            var columnValue = reader.IsDBNull(i) ? null : reader.GetValue(i);

                            resultDictionary[columnName] = columnValue;
                        }

                        // Add the row to the list
                        rawResult.Add(resultDictionary);
                    }
                }
            }

            // Create a new instance of T (ProcedureResultDto)
            var resultDto = Activator.CreateInstance<T>();

            // If the resultDto is ProcedureResultDto, assign the result list to the Result property
            if (resultDto is ProcedureResultListDto procedureResultDto)
            {
                procedureResultDto.Result = rawResult; // Store the list of results inside the Result property
            }

            return new List<T> { resultDto }; // Return the result wrapped in a list of T
        }

        async Task<IEnumerable<T>> IRepository<T>.Execute(string storedProcedureName, Dictionary<string, object> parameters)
        {
            if (string.IsNullOrWhiteSpace(storedProcedureName))
            {
                throw new ArgumentNullException(nameof(storedProcedureName));
            }

            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            // Convert parameters to SQL parameters
            var sqlParameters = parameters.Select(param =>
            {
                if (param.Value is JsonElement jsonElement)
                {
                    switch (jsonElement.ValueKind)
                    {
                        case JsonValueKind.String:
                            return new SqlParameter(param.Key, (object)jsonElement.GetString() ?? DBNull.Value);
                        case JsonValueKind.Number:
                            return new SqlParameter(param.Key, jsonElement.GetInt32());
                        case JsonValueKind.True:
                        case JsonValueKind.False:
                            return new SqlParameter(param.Key, jsonElement.GetBoolean());
                        default:
                            return new SqlParameter(param.Key, DBNull.Value);
                    }
                }

                return new SqlParameter(param.Key, param.Value ?? DBNull.Value);
            }).ToArray();

            // Execute the stored procedure and handle the result based on the type
            var rawSql = $"EXEC {storedProcedureName} {string.Join(", ", parameters.Keys)}";

            // Case 1: If T is a class, assume it's an object and return list or single object

            var result = await _dataContext.Set<T>().FromSqlRaw(rawSql, sqlParameters).ToListAsync();

            // Create a new instance of T (ProcedureResultDto)
            var resultDto = Activator.CreateInstance<T>();

            if (resultDto is ProcedureResultDto procedureResultDto)
            {
                procedureResultDto.Result = result.ToString() ; // Store the list of results inside the Result property
            }

            return result;
        }
  
        public T? Get(string id, Func<IQueryable<T>, IIncludableQueryable<T, object>>? navigations = null)
        {
            Guard.Against.NullOrEmpty(id);
            return Aspect(() =>
            {
                var query = _dataContext.Set<T>().AsQueryable();
                if (navigations != null)
                {
                    query = navigations.Invoke(query);
                }
                return query.FirstOrDefault(y => y.Id == id);
            });
        }

        public T? Get(Expression<Func<T, bool>> query, Func<IQueryable<T>, IIncludableQueryable<T, object>>? navigations = null)
        {
            Guard.Against.Null(query);
            return Aspect(() =>
            {
                var querable = _dataContext.Set<T>().AsQueryable();
                if (navigations != null)
                {
                    querable = navigations.Invoke(querable);
                }
                return querable.FirstOrDefault(query);
            });
        }

        public async Task<T?> GetAsync(string id, Func<IQueryable<T>, IIncludableQueryable<T, object>>? navigations = null)
        {
            Guard.Against.NullOrEmpty(id);
            return await AspectAsync(async () =>
            {
                var query = _dataContext.Set<T>().AsQueryable();
                if (navigations != null)
                {
                    query = navigations.Invoke(query);
                }
                return await query.FirstOrDefaultAsync(y => y.Id == id);
            });
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> query, Func<IQueryable<T>, IIncludableQueryable<T, object>>? navigations = null)
        {
            Guard.Against.Null(query);
            return await AspectAsync(async () =>
            {
                var querable = _dataContext.Set<T>().AsQueryable();
                if (navigations != null)
                {
                    querable = navigations.Invoke(querable);
                }
                return await querable.FirstOrDefaultAsync(query);
            });
        }

        public T Insert(T entity)
        {
            Guard.Against.Null(entity);
            return Aspect(() =>
            {
                _dataContext.Add(entity);
                return entity;
            });
        }

        public List<T> Insert(List<T> entities)
        {
            Guard.Against.NullOrEmpty(entities);
            return Aspect(() =>
            {
                _dataContext.AddRange(entities);
                return entities;
            });
        }

        public async Task<T?> InsertAsync(T entity)
        {
            Guard.Against.Null(entity);
            return await AspectAsync(async () =>
            {
                await _dataContext.AddAsync(entity);
                return entity;
            });
        }

        public async Task InsertAsync(List<T> entities)
        {
            Guard.Against.NullOrEmpty(entities);
            await AspectVoidAsync(async () =>
            {
                await _dataContext.AddRangeAsync(entities);
            });
        }

        public IQueryable<T?> Query()
        {
            return _dataContext.Set<T>().AsQueryable();
        }

        public EntityEntry<T> Update(T entity)
        {
            Guard.Against.Null(entity);
            return Aspect(() =>
            {
                var entry = _dataContext.Update(entity);
                return entry;
            });

        }

        public void Update(List<T> entities)
        {
            Guard.Against.NullOrEmpty(entities);
            Aspect(() =>
            {
                entities.ForEach(e => _dataContext.Update(e));
            });
        }

        public async Task<T?> DeleteAsync(T entity)
        {
            if (entity != null)
            {
                _dataContext.Set<T>().Remove(entity); 
                await SaveChangesAsync(); 
                return entity;
            }
            return null;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dataContext.SaveChangesAsync();
        }

        public async Task<DbTransaction> BeginTransactionAsync()
        {
            // Ensure the context is not disposed and there is no current transaction
            if (_dataContext.Database.CurrentTransaction != null)
            {
                throw new InvalidOperationException("There is already an active transaction.");
            }

            var connection = _dataContext.Database.GetDbConnection();
            await connection.OpenAsync();
            var transaction = await connection.BeginTransactionAsync();

            _dataContext.Database.UseTransaction(transaction);
            return transaction;
        }

        //----------------------- Update with Children -----------------------//

        //EntityEntry<T> IRepository<T>.UpdateWithChildrenn(T entity)
        //{
        //    Guard.Against.Null(entity);

        //    return Aspect(() =>
        //    {
        //        // Find all collection properties in the entity (excluding strings)
        //        var collectionProperties = typeof(T).GetProperties()
        //            .Where(p => typeof(IEnumerable<object>).IsAssignableFrom(p.PropertyType) && p.PropertyType != typeof(string));

        //        foreach (var collectionProperty in collectionProperties)
        //        {
        //            // Get the current collection from the entity
        //            var currentCollection = collectionProperty.GetValue(entity) as IEnumerable<object>;

        //            if (currentCollection != null)
        //            {
        //                // Load existing collection entries in the context
        //                var existingCollection = _dataContext.Entry(entity)
        //                    .Collection(collectionProperty.Name)
        //                    .Query();

        //                // Remove existing entries
        //                foreach (var item in existingCollection)
        //                {
        //                    _dataContext.Remove(item);
        //                }

        //                // Add new entries from the expanded OData entity
        //                foreach (var newItem in currentCollection)
        //                {
        //                    _dataContext.Add(newItem);
        //                }
        //            }
        //        }

        //        // Update the main entity
        //        var entry = _dataContext.Update(entity);
        //        return entry;
        //    });
        //}

        //public EntityEntry<T> UpdateWithChildrenn(T entity)
        //{
        //    Guard.Against.Null(entity);

        //    return Aspect(() =>
        //    {
        //        void ProcessCollection(object parent, IEnumerable<object> currentCollection, string collectionName)
        //        {
        //            // Load the existing collection from the database
        //            var existingCollection = _dataContext.Entry(parent)
        //                .Collection(collectionName)
        //                .Query()
        //                .Cast<object>()
        //                .ToList();

        //            // Remove items not in the new collection
        //            var itemsToRemove = existingCollection
        //                .Where(existingItem => !currentCollection.Any(newItem => AreEqual(existingItem, newItem)))
        //                .ToList();

        //            foreach (var itemToRemove in itemsToRemove)
        //            {
        //                if (_dataContext.Entry(itemToRemove).State == EntityState.Detached)
        //                {
        //                    _dataContext.Attach(itemToRemove);
        //                }

        //                _dataContext.Entry(itemToRemove).State = EntityState.Deleted;
        //            }

        //            // Add or update new items
        //            foreach (var newItem in currentCollection)
        //            {
        //                // Check if the entity already exists in the database
        //                var existingItem = existingCollection.FirstOrDefault(existing => AreEqual(existing, newItem));

        //                if (existingItem != null)
        //                {
        //                    // Update scalar properties of the existing item
        //                    _dataContext.Entry(existingItem).CurrentValues.SetValues(newItem);

        //                    // Update the parent-child relationship explicitly
        //                    SetParentForChild(parent, existingItem);

        //                    // Process nested collections
        //                    ProcessNestedCollections(existingItem, newItem);
        //                }
        //                else
        //                {
        //                    // New entity - ensure parent relationship and add it
        //                    SetParentForChild(parent, newItem);
        //                    _dataContext.Entry(newItem).State = EntityState.Added;

        //                    // Process nested collections for the new item
        //                    ProcessNestedCollections(parent, newItem);
        //                }
        //            }
        //        }

        //        void ProcessNestedCollections(object parent, object newItem)
        //        {
        //            // Process nested collections within the new item
        //            var childProperties = newItem.GetType().GetProperties()
        //                .Where(p => typeof(IEnumerable<object>).IsAssignableFrom(p.PropertyType) && p.PropertyType != typeof(string));

        //            foreach (var childProperty in childProperties)
        //            {
        //                var nestedCollection = childProperty.GetValue(newItem) as IEnumerable<object>;
        //                if (nestedCollection != null)
        //                {
        //                    ProcessCollection(newItem, nestedCollection, childProperty.Name);
        //                }
        //            }
        //        }

        //        void SetParentForChild(object parent, object child)
        //        {
        //            // Explicitly set the parent-child relationship
        //            var parentProperty = child.GetType().GetProperties()
        //                .FirstOrDefault(p => p.PropertyType.IsAssignableFrom(parent.GetType()));

        //            if (parentProperty != null)
        //            {
        //                parentProperty.SetValue(child, parent);
        //            }
        //        }

        //        // Process top-level collections in the entity
        //        var collectionProperties = typeof(T).GetProperties()
        //            .Where(p => typeof(IEnumerable<object>).IsAssignableFrom(p.PropertyType) && p.PropertyType != typeof(string));

        //        foreach (var collectionProperty in collectionProperties)
        //        {
        //            var currentCollection = collectionProperty.GetValue(entity) as IEnumerable<object>;

        //            if (currentCollection != null)
        //            {
        //                ProcessCollection(entity, currentCollection, collectionProperty.Name);
        //            }
        //        }

        //        // Update the main entity
        //        var entry = _dataContext.Update(entity);

        //        if (entry.State == EntityState.Detached)
        //        {
        //            _dataContext.Attach(entity);
        //        }

        //        entry.State = EntityState.Modified;

        //        return entry;
        //    });
        //}

        //private bool AreEqual(object existingItem, object newItem)
        //{
        //    // Compare items by their primary key or unique identifier
        //    var existingId = existingItem.GetType().GetProperty("Id")?.GetValue(existingItem);
        //    var newId = newItem.GetType().GetProperty("Id")?.GetValue(newItem);
        //    return Equals(existingId, newId);
        //}

        //-----------------------------  New Update -------------------------

        public EntityEntry<T> UpdateWithChildrenn(T entity)
        {
            Guard.Against.Null(entity);

            return Aspect(() =>
            {
                void ProcessCollection(object parent, IEnumerable<object> currentCollection, string collectionName)
                {
                    // Load the existing collection from the database
                    var existingCollection = _dataContext.Entry(parent)
                        .Collection(collectionName)
                        .Query()
                        .Cast<object>()
                        .ToList();

                    // Remove all existing items
                    foreach (var existingItem in existingCollection)
                    {
                        if (_dataContext.Entry(existingItem).State == EntityState.Detached)
                        {
                            _dataContext.Attach(existingItem);
                        }

                        _dataContext.Entry(existingItem).State = EntityState.Deleted;
                    }

                    // Insert new items
                    foreach (var newItem in currentCollection)
                    {
                        // Ensure the parent relationship before adding the new item
                        SetParentForChild(parent, newItem);

                        // Mark new item as added
                        if (!_dataContext.ChangeTracker.Entries().Any(e => e.Entity == newItem))
                        {
                            _dataContext.Entry(newItem).State = EntityState.Added;
                        }

                        // Process nested collections for the new item
                        ProcessNestedCollections(parent, newItem);
                    }
                }

                void ProcessNestedCollections(object parent, object newItem)
                {
                    // Process nested collections within the new item
                    var childProperties = newItem.GetType().GetProperties()
                        .Where(p => typeof(IEnumerable<object>).IsAssignableFrom(p.PropertyType) && p.PropertyType != typeof(string));

                    foreach (var childProperty in childProperties)
                    {
                        var nestedCollection = childProperty.GetValue(newItem) as IEnumerable<object>;
                        if (nestedCollection != null)
                        {
                            ProcessCollection(newItem, nestedCollection, childProperty.Name);
                        }
                    }
                }

                void SetParentForChild(object parent, object child)
                {
                    // Explicitly set the parent-child relationship
                    var parentProperty = child.GetType().GetProperties()
                        .FirstOrDefault(p => p.PropertyType.IsAssignableFrom(parent.GetType()));

                    if (parentProperty != null)
                    {
                        parentProperty.SetValue(child, parent);
                    }
                }

                // Process top-level collections in the entity
                var collectionProperties = typeof(T).GetProperties()
                    .Where(p => typeof(IEnumerable<object>).IsAssignableFrom(p.PropertyType) && p.PropertyType != typeof(string));

                foreach (var collectionProperty in collectionProperties)
                {
                    var currentCollection = collectionProperty.GetValue(entity) as IEnumerable<object>;

                    if (currentCollection != null)
                    {
                        ProcessCollection(entity, currentCollection, collectionProperty.Name);
                    }
                }

                // Update the main entity
                var entry = _dataContext.Update(entity);

                if (entry.State == EntityState.Detached)
                {
                    _dataContext.Attach(entity);
                }

                entry.State = EntityState.Modified;

                return entry;
            });
        }


        private bool AreEqual(object existingItem, object newItem)
        {
            // Compare items by their primary key or unique identifier
            var existingId = existingItem.GetType().GetProperty("Id")?.GetValue(existingItem);
            var newId = newItem.GetType().GetProperty("Id")?.GetValue(newItem);
            return Equals(existingId, newId);
        }

        public Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _dataContext.Set<T>().FirstOrDefaultAsync(predicate);
        }
    }
}
