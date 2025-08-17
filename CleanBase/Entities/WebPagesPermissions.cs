using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class WebPagesPermissions :EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int Mid { get; set; }
        public string? UsersGroupNo { get; set; }
        [NotMapped]
        public string? GroupsNameAr { get; set; }
        [NotMapped]
        public string? GroupsNameEn { get; set; }
        public string? WebPageNo { get; set; }
        [NotMapped]
        public string? page_nameAr { get; set; }
        [NotMapped]
        public string? page_nameEn { get; set; }

        public List<WebPagesPermissionsDet> Det { get; set; } = new List<WebPagesPermissionsDet>();
        public List<WebpagesSignatures> Sig { get; set; } = new List<WebpagesSignatures>();


    }
}
