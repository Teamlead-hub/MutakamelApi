using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_WebPagesPermissionsDet : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        public string? UsersGroupNo { get; set; }
        public string? GroupsNameAr { get; set; }
        public string? GroupsNameEn { get; set; }
        public string? WebPageNo { get; set; }
        public string? page_nameAr { get; set; }
        public string? page_nameEn { get; set; }
        public string? WebOperationsNo { get; set; }
        public string? OperationNameAr { get; set; }
        public string? OperationNameEn { get; set; }
        public int? AllowValue { get; set; }
        public int? WebPagesPermissionsId { get; set; }
        public string? WebPagesUsersId { get; set; }
        public string? WebPagesUsersName { get; set; }
        public string? NotificationMsg { get; set; }
        public v_WebPagesPermissions? WebPagesPermissions { get; set; }
    }
}
