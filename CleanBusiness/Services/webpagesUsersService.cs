using Ardalis.GuardClauses;
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
    public class webpagesUsersService : RootService<webpagesUsers>, IwebpagesUsers
    {
        public webpagesUsersService(IRepository<webpagesUsers> repository) : base(repository)
        {
           
        }
    }
}
