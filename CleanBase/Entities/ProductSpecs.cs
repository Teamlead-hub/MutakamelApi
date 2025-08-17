using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductSpecs : EntityRoot
    {
        public string? Specid {  get; set; }

        [NotMapped]
        public string? SpecName {  get; set; }

        [NotMapped]
        public string? JordanSpec {  get; set; }

        [NotMapped]
        public string? FactorySpec {  get; set; }

        public string? ProductId {  get; set; }
        public Products? Product {  get; set; }
        public List<Productstest>? Productstest { get; set; } = new List<Productstest>();

    }
}
