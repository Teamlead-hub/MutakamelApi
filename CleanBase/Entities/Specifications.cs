using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Specifications:EntityRoot
    {
        public string? SpecName { get; set; }
        public string? JordanSpec { get; set; }
        public string? FactorySpec { get; set; }

        public string? SpecType {  get; set; }

        public List<SpecificationLabTests> SpecificationLabTests { get; set; } =new  List<SpecificationLabTests>();
    }
}
