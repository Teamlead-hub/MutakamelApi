using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrderReportWages : EntityRoot
    {
        public string? ProductOrderReportId { get; set; }
        public V_ProductOrderReport? ProductOrderReport { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? HourRate { get; set; }
        public string? Hours { get; set; }
    }
}
