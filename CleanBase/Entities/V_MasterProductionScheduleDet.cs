using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_MasterProductionScheduleDet : EntityRoot
    {
        public string? Week { get; set; }
        public string? Year { get; set; }
        public string? Month { get; set; }
        public decimal? Prediction { get; set; }
        public decimal? PercentOfOrders { get; set; }
        public decimal? OrderQty { get; set; }
        public decimal? AvailableQty { get; set; }
        public decimal? ProductionQty { get; set; }
        public decimal? ReceivingQty { get; set; }
        public string? MasterProductionScheduleId { get; set; }
        public V_MasterProductionSchedule? MasterProductionSchedule { get; set; }
    }
}
