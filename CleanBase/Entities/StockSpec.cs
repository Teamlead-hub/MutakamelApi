
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CleanBase.Entities
{
    public class StockSpec : EntityRoot
    {
        public string? Specid { get; set; }
        [NotMapped]
        public string? SpecName { get; set; }

        [NotMapped]
        public string? JordanSpec { get; set; }

        [NotMapped]
        public string? FactorySpec { get; set; }

        public string? StockId { get; set; }
        public Stock? Stock { get; set; }
        public List<StockTest> StockTest { get; set; }=new List<StockTest>();
    }
}
