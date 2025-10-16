using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_CompanyInfo:EntityRoot
    {
        public string? CompanyName { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? SalesTaxNo { get; set; }
        public string? City { get; set; }

        public string? MainStoreIP { get; set; }
        public int? OpenDrawerBYCom { get; set; }
        public string? ComNo { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Note1 { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string? Note2 { get; set; }

        public string? Currency { get; set; }
        public string? Posno { get; set; }
        public string? StoreNo { get; set; }
        

    }
}
