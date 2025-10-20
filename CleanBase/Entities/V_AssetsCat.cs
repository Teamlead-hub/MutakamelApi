using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_AssetsCat : EntityRoot
    {
        public string? AsstCatName { get; set; }
        public decimal? Lastserial { get; set; }
        public string? AccountNo { get; set; }
        public string? AccountName { get; set; }
        public string? Exp_Account { get; set; }
        public string? Exp_Acc_name { get; set; }
        public string? Dep_Account { get; set; }
        public string? Dep_Acc_Name { get; set; }
        public string? MethodDesc { get; set; }
        public string? MethodNo { get; set; }
        public decimal? MethodPerc { get; set; }
        public int ? SerialNumberFlag { get; set; }
    }
}
