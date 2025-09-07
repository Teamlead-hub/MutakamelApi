
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
    public class SupplierInfo : EntityRoot
    {
        public string? SupplierName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? IdentityNo { get; set; }
        public string? TelNumber { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartDate { get; set; }
        public string? Risks { get; set; }
        public string? Services { get; set; }

        public string? ManagerPhoneNo { get; set; }
        public string? SalesMangerPhoneNo { get; set; }
        public string? SalesRepPhoneNo { get; set; }

        public List<SupContactInfo> SupContactInfo { get; set; } = new List<SupContactInfo>();
        public List<SupContractInfo> SupContractInfo { get; set; } = new List<SupContractInfo>();
        public List<SupEvaluationInfo> SupEvaluationInfo { get; set; } = new List<SupEvaluationInfo>();
        // public List<SupComplaintInfo> supComplaintInfo { get; set; } = new List<SupComplaintInfo>();
    }

}




