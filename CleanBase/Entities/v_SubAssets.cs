using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_SubAssets : EntityRoot
    {
        public string? AssetsNo { get; set; }
        public string? SubAssetsNameAr { get; set; }
        public string? SubAssetsNameEn { get; set; }
        public string? Asset_Desc { get; set; }
        public List<V_SubAssetsTestMethodMain> SubAssetsTestMethodMain { get; set; } = new List<V_SubAssetsTestMethodMain>();
    }
}
