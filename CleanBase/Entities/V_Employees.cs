using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_Employees : EntityRoot
    {
        public string? EmployeeName { get; set; }

        public decimal? BasicSal { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? BirthDate { get; set; }
        public int? Gender { get; set; }
        public int? SocialStatus { get; set; }
        public string? Religion { get; set; }
        public string? NationalityNo { get; set; }
        public string? NationalityName { get; set; }
        
        public string? NationalNo { get; set; }
        public string? ID_No { get; set; }

        public string? ID_Personal { get; set; }
        public string? Mobile { get; set; }
        public string? EMail { get; set; }
        public string? Address { get; set; }
        public int? ChildNo { get; set; }

        public string? DeptNo { get; set; }
        public string? DeptName { get; set; }
        public string? SectionNo { get; set; }
        public string? SectionName { get; set; }
        public string? JobNo { get; set; }
        public string? JobName { get; set; }
        public string? Previousexperience { get; set; }
        public int? EmployeeActive { get; set; }
        public string? PayAccountNo { get; set; }
        public string? payAccountName { get; set; }
        public string? QualificationNo { get; set; }
        public string? QualificationName { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartWorkDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EndWorkDate { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ResignationDate { get; set; }  
        
        public string? StartWorkTime { get; set; }       
        public string? EndWorkTime { get; set; }
        public string? ShiftNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? ContractEndDate { get; set; }

        public string? TaxNo { get; set; }
        public string? BankNo { get; set; }
        public string? BankName { get; set; }
        public string? BankAccountNo { get; set; }
        public string? Iban { get; set; }
        public int? SocSecFlag { get; set; }
        public string? SocialSecurityNo { get; set; }
        public string? AssuranceItemNo { get; set; }
        public string? AssuranceItemDesc { get; set; }
        public string? PermitNo { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? StartDateOfPermit { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? EndDateOfPermit { get; set; }

        public string? Emp_specializationsNo { get; set; }
        public string? Emp_specializationsName { get; set; }
        public List<V_EmpAllowance> Allowance { get; set; } = new List<V_EmpAllowance>();

    }
}
