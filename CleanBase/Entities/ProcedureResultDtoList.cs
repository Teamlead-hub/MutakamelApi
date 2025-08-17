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
    public class ProcedureResultListDto:EntityRoot
    {
        public List<Dictionary<string, object>> Result { get; set; } = new List<Dictionary<string, object>>();

    }
}
