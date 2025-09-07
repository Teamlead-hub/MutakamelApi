using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class WebpagesSignatures:EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int TransId { get; set; }
        [NotMapped]
        public string? PersonName { get; set; }
        public int? OrderBySig { get; set; }
        [NotMapped]
        public string? JobName { get; set; }
        public string? ResponsiblePerson { get; set; }
        public int? WebPagesPermissionsId { get; set; }
        public string? WebPageNo { get; set; }
        public WebPagesPermissions? WebPagesPermissions { get; set; }
    }
}
