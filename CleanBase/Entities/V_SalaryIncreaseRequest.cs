using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_SalaryIncreaseRequest : EntityRoot
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This should be here
        public int RequsetNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? RequestDate { get; set; }
        public string? EmployeesId { get; set; }
        public string? EmployeeName { get; set; }
        public decimal? SalaryTotal { get; set; }
       
        public string? Reason { get; set; }
        public int? DirectManagerApproval { get; set; }
        public string? DirectManagerNote { get; set; }
        public int? HrApproval { get; set; }
        public string? HrNote { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ApprovalDate { get; set; }  
        public decimal? IncreaseValue { get; set; }
    }
}
