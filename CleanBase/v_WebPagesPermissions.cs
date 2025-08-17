using CleanBase.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase
{
    public class v_WebPagesPermissions : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int Mid { get; set; }
        public string? UsersGroupNo { get; set; }
        public string? GroupsNameAr { get; set; }
        public string? GroupsNameEn { get; set; }
        public string? WebPageNo { get; set; }
        public string? page_nameAr { get; set; }
        public string? page_nameEn { get; set; }

        public List<V_WebPagesPermissionsDet> Det { get; set; } = new List<V_WebPagesPermissionsDet>();
        public List<V_WebpagesSignatures> Sig { get; set; } = new List<V_WebpagesSignatures>();

    }
}
