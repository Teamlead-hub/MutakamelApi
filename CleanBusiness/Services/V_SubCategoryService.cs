using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Services
{
    public class V_SubCategoryService : RootService<V_SubCategory>, IV_SubCategoryService
    {
        public V_SubCategoryService(IRepository<V_SubCategory> repository) : base(repository)
        { }
    }
}
