using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class WebPagesPermissionsDet :EntityRoot
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }

        [NotMapped]
        public string? UsersGroupNo { get; set; }
        [NotMapped]
        public string? GroupsNameAr { get; set; }
        [NotMapped]
        public string? GroupsNameEn { get; set; }
        [NotMapped]
        public string? WebPageNo { get; set; }
        [NotMapped]
        public string? page_nameAr { get; set; }
        [NotMapped]
        public string? page_nameEn { get; set; }
        public string? WebOperationsNo { get; set; }
        [NotMapped]
        public string? OperationNameAr { get; set; }
        [NotMapped]
        public string? OperationNameEn { get; set; }
        public int? AllowValue { get; set; }
        
        public int? WebPagesPermissionsId { get; set; }


        public string? WebPagesUsersId { get; set; }
        [NotMapped]
        public string? WebPagesUsersName { get; set; }
        public string? NotificationMsg { get; set; }

        public WebPagesPermissions? WebPagesPermissions { get; set; }
    }
}
