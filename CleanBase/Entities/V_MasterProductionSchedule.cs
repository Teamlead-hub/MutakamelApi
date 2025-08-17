using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class   V_MasterProductionSchedule : EntityRoot
    {
        public string? ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Year { get; set; }
        public string? Month { get; set; }
        public decimal? PercentWeek1 { get; set; }
        public decimal? PercentWeek2 { get; set; }
        public decimal? PercentWeek3 { get; set; }
        public decimal? PercentWeek4 { get; set; }
        public decimal? ProductionQty { get; set; }
        public decimal? NoOfProductions { get; set; }
        public decimal? PredictionQty { get; set; }
        public decimal? DurationInWeeks { get; set; }
        public decimal? CurrentQty { get; set; }
        public List<V_MasterProductionScheduleDet> MasterProductionScheduleDet { get; set; } = new List<V_MasterProductionScheduleDet>();
    }
}
