using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ExecuteRequest
    {
        public string StoredProcedureName { get; set; } // Name of the stored procedure to execute
        public Dictionary<string, object> Parameters { get; set; } // Key-value pairs of parameters for the stored procedure
    }

}
