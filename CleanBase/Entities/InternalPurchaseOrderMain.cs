using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class InternalPurchaseOrderMain : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? OrderDate { get; set; }
        public string? ResponsiblePerson { get; set; }
        public string? Section {get; set; }
        public string? ExperimentNo {get; set; }
        public string? ExperimentName {get; set; }
        public decimal? Total { get; set; }
        public List<InternalPurchaseOrderDet> InternalPurchaseOrderDet { get; set; } = new List<InternalPurchaseOrderDet>();

    }
}

  
      
     
   
     
     