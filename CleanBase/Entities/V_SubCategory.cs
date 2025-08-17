using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_SubCategory:EntityRoot
    {
        public string? SubcatName { get; set; }
        public string? SubcatNameEn { get; set; }
        public string? CategoryId { get; set; }
        public string? CatName { get; set; }
        public string? CatNameEn { get; set; }
    }
}
