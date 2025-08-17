using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_ProductOrderWages:EntityRoot
    {
        public V_ProductOrder? ProductOrder { get; set; }
        public string? ProductOrderId { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? HourRate { get; set; }
        public string? Hours { get; set; }
    }
}
