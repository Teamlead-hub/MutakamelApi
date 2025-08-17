using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class webpagesUsers : EntityRoot
    {
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPassword { get; set; }
        public string? WebPagesGroupsno { get; set; }
        public int? UserIsActive { get; set; }
      

    }
}
