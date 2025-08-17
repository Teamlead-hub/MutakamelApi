using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class AssetStore :EntityRoot
    {
        public string? StoreName { get; set; }
        public string? StoreNameEn { get; set; }
    }
}
