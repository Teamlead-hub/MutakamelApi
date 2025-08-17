using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class Category:EntityRoot
    {
        public string? CatName { get; set; }
        public string? CatNameEn { get; set; }
    }
}
