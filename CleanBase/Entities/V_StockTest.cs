
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class V_StockTest : EntityRoot
    {
        public string? LabTestId { get; set; }
        public string? TestName { get; set; }
        public string? TestCode { get; set; }
        public string? StockSpecId { get; set; }
        public V_StockSpec? StockSpec { get; set; }
    }
}
