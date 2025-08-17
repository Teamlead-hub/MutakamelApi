using Ardalis.GuardClauses;
using CleanBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Declarations
{
    public interface IV_webpagesUsers : IRootService<V_webpagesUsers>
    {
        Task<string> CreateToken(V_webpagesUsers entity); // Interface method to generate token

    }

}
