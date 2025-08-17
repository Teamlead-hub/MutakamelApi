using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class ProductOrderWages:EntityRoot
    {
        public ProductOrder? ProductOrder { get; set; }
        public string? ProductOrderId { get; set; }
        public string? EmployeeId { get; set; }
        [NotMapped]
        public string? EmployeeName { get; set; }
        public string? HourRate { get; set; }
        public string? Hours { get; set; }

    }
}
