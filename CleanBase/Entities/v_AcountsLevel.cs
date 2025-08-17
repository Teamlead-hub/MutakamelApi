using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class v_AcountsLevel:EntityRoot
    {
        public string? id_description { get; set; }      
        public string? parentGroupId { get; set; }
       
    }
}
