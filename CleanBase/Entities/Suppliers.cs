
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanBase.Entities
{
    public class Suppliers : EntityRoot
    {
        public string? SupplierName { get; set; }
        public string? CommercialName { get; set; }
        public string? TaxNo { get; set; }
        public string? Address { get; set; }
        public string? Tel { get; set; }
        public string? ManagerPhoneNo { get; set; }
        public string? SalesMangerPhoneNo { get; set; }
        public string? SalesRepPhoneNo { get; set; }
        public string? Email { get; set; }
        public string? ContactPerson { get; set; }
    }

}
