using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class SubCategory:EntityRoot
    {
        public string? SubcatName { get; set; }
        public string? SubcatNameEn { get; set; }
        public string? CategoryId { get; set; }

        [NotMapped]
        public string? CatName { get; set; }

        [NotMapped]
        public string? CatNameEn { get; set; }
    }
}
