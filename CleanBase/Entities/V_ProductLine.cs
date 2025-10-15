using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductLine : EntityRoot
    {
        public string? ProductLineName { get; set; }
        public string? FactoryId { get; set;}
        public string? FactoryName { get; set; }

    }
}
