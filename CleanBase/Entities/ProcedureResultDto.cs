using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanBase.Entities
{
    [Keyless]
    public class ProcedureResultDto:EntityRoot
    {
       public string? Result { get; set; } // This holds the result of your stored procedure
    }
}
