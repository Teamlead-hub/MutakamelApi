using CleanBase.Entities;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CleanBase.Entities
{
    public class SampleTestDet : EntityRoot

    {
      
        public string? ItemNo { get; set; }
        public string? ItemName { get; set; }
        public string? SampletestMainId { get; set; }
        public string? ProductSpecsId { get; set; }
        [NotMapped]
        public string? SpecName { get; set; }
        public string? ProductTestId { get; set; }
        [NotMapped] 
        public string? TestName { get; set; }

        public string? LabTestResulteId { get; set; }
        [NotMapped]
        public string? TestResulteName { get; set; }
        public string? TestMethodsId { get; set; }
        [NotMapped]
        public string? TestmethodName { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? Qty {  get; set; }
        public string? Note { get; set; }
        public string? FactorySpec { get; set; }
        public string? JordanSpec { get; set; }
        public SampletestMain? SampletestMain { get; set; }
    }
}



       