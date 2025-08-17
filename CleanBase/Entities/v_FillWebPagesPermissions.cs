using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class v_FillWebPagesPermissions:EntityRoot
    {
        public string? UsersGroupNo { get; set; }
        public string? GroupsNameAr { get; set; }
        public string? GroupsNameEn { get; set; }
        public string? WebPageNo { get; set; }
        public string? page_nameAr { get; set; }
        public string? page_nameEn { get; set; }
        public int? ViewInMenu { get; set; }

        public string? pageurl { get; set; }
        public string? pageIcon { get; set; }

        public int? OrderInMenu { get; set; }
        public string? WebOperationsNo { get; set; }
        public string? OperationNameAr { get; set; }
        public string? OperationNameEn { get; set; }
        public string? NotificationMsg { get; set; }
        public string? WebPagesUsersId { get; set; }
        public int? AllowValue { get; set; }

        public int? WebPagesPermissionsId { get; set; }

    }
}
