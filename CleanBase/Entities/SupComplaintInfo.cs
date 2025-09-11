
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
    public class SupComplaintInfo : EntityRoot
    {

        public string? FromName { get; set; }
        public string? Adderss { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? SupplierInfoId { get; set; }
        public string? SupplierName { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EntryDate { get; set; }
        public string? ItemNo { get; set; }
        public string? ItemName { get; set; }
        public decimal? BatchNo { get; set; }
        public SupplierInfo? SupplierInfo { get; set; }



    }

}