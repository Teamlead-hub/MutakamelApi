using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Productstest : EntityRoot
    {
        public string? LabTestId { get; set; }

        [NotMapped]
        public string? Testcode { get; set; }

        [NotMapped]
        public string? TestName { get; set; }

        public string? ProductSpecsId { get; set; }
        public ProductSpecs? ProductSpecs { get; set; }
    }
}
