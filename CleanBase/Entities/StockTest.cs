
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class StockTest : EntityRoot
    {
        public string? LabTestId { get; set; }

        [NotMapped]
        public string? TestName { get; set; }

        [NotMapped]
        public string? TestCode { get; set; }
        public string? StockSpecId { get; set; }
        public StockSpec? StockSpec { get; set; }

    }
}
