using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_Productstest : EntityRoot
    {
        public string? LabTestId { get; set; }
        public string? Testcode { get; set; }
        public string? TestName { get; set; }
        public string? ProductSpecsId { get; set; }
        public V_ProductSpecs? ProductSpecs { get; set; }
    }
}
