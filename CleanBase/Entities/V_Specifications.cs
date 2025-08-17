using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_Specifications:EntityRoot
    {
        public string? SpecName { get; set; }
        public string? JordanSpec { get; set; }
        public string? FactorySpec { get; set; }
        public string? SpecType { get; set; }

        public List<V_SpecificationLabTests> SpecificationLabTests { get; set; } =new  List<V_SpecificationLabTests>();
    }
}
