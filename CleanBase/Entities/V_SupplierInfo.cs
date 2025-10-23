
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
    public class V_SupplierInfo : EntityRoot
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
        public string? TaxNo { get; set; }
        public string? Accounts_No { get; set; }

        public List<V_SupContactInfo> SupContactInfo { get; set; } = new List<V_SupContactInfo>();
        public List<V_SupContractInfo> SupContractInfo { get; set; } = new List<V_SupContractInfo>();
        public List<V_SupEvaluationInfo> SupEvaluationInfo { get; set; } = new List<V_SupEvaluationInfo>();

    }

}
