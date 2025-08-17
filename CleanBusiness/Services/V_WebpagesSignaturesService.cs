using CleanBase;
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
    public class V_WebpagesSignaturesService : RootService<V_WebpagesSignatures>, IV_WebpagesSignatures
    {
        public V_WebpagesSignaturesService(IRepository<V_WebpagesSignatures> repository) : base(repository)
        {
        }
    }
}
