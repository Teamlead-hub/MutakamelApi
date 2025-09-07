
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanBase.Entities
{
    public class Signatures : EntityRoot
    {

        public string? Signature { get; set; }
        public string? PersonName { get; set; }
        public string? PersonId { get; set; }
        public string? RefNo { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]

        public DateOnly? Date { get; set; }
        public string? JobName { get; set; }
        public int? WebPagesPermissionsId { get; set; }
        public int? OrderBySig { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string? Note { get; set; }
        public string? WebPageNo { get; set; }
        public string? WebPagesUsersId { get; set; }



    }

}
