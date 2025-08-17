using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Declarations
{
    public interface IGenericListUpdater<TParentEntity, TChildEntity>
        where TParentEntity : class
        where TChildEntity : class
    {
        Task UpdateListAsync(int parentId, List<TChildEntity> newItems);
    }

}
