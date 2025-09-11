
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
    public class Customer : EntityRoot
    {
        public string? CustomerName { get; set; }
        public string? mobile { get; set; }
        public string? CustCatgnNo { get; set; }
        [NotMapped]
        public string? customerCatgname { get; set; }
        public string? classificationNo { get; set; }
        [NotMapped]
        public string? classificationName { get; set; }
        public string? CityNo { get; set; }
        [NotMapped]
        public string? Cityname { get; set; }
        public string? AreaNo { get; set; }
        [NotMapped]
        public string? AreaName { get; set; }
        public int? Taxable { get; set; }
        public int? DiscType { get; set; }
        public decimal? Disc { get; set; }
        public string? Points { get; set; }
        public int? PaymentDays { get; set; }
        public string? CreditLimit { get; set; }
        public string? BalanceCredit { get; set; }
        [NotMapped]
        public decimal? FinalDisc { get; set; }
        [NotMapped]
        public int? FinalDiscType { get; set; }

        public List<CustomerContact>? CustomerContact { get; set; } = new List<CustomerContact>();


    }

}
