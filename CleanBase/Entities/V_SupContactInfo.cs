
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanBase.Entities;


namespace CleanBase.Entities
{
    public class V_SupContactInfo : EntityRoot
    {

        public string? ContactName { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactMethod { get; set; }
        public string? ContactTitle { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ContactDate { get; set; }
       

        public string? SupplierInfoId { get; set; }
        public string? JobName { get; set; }
        public string? Email { get; set; }
        public V_SupplierInfo? SupplierInfo { get; set; }
    }

}
