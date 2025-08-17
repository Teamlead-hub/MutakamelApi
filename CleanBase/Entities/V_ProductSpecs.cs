using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductSpecs : EntityRoot
    {
        public string? Specid { get; set; }
        public string? SpecName { get; set; }
        public string? JordanSpec { get; set; }
        public string? FactorySpec { get; set; }
        public string? ProductId { get; set; }
        public V_Products? Product { get; set; }
        public List<V_Productstest>? Productstest { get; set; } = new List<V_Productstest>();

    }
}
