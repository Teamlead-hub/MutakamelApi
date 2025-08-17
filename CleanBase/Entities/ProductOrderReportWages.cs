using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrderReportWages : EntityRoot
    {
        public string? ProductOrderReportId { get; set; }
        public ProductOrderReport? ProductOrderReport { get; set; }
        public string? EmployeeId { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        public string? HourRate { get; set; }
        public string? Hours { get; set; }
    }
}
