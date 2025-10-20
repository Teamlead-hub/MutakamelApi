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
    public class V_AssetsCatService : RootService<V_AssetsCat>, IV_AssetsCat
    {
        public V_AssetsCatService(IRepository<V_AssetsCat> repository) : base(repository)
        { }
    }
}
