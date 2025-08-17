using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanBase.Entities
{
    public class V_RawMaterialEquation : EntityRoot
    {
       public string? ExperimentName { get; set; }

       [JsonConverter(typeof(DateOnlyJsonConverter))]
       public DateOnly? ExperimentStratDate { get; set; } 
       public string? ResearcherInCharge { get; set; }
       public string? ResearcherName { get; set; } 
       public string? LabName { get; set; } 
       public string? StockId { get; set; } 
       public string? ArabicName { get; set; }
       public string? EnglishName { get; set; } 
       public decimal? UsedQuantity { get; set; } 
       public decimal? PurityLevel { get; set; } 
       public string? BatchNo { get; set; } 
       public string? StepsFollowed { get; set; } 
       public string? Equipments { get; set; } 
       public string? ExperimentalConditions { get; set; } 
       public string? Results { get; set; } 
       public string? Conclusions { get; set; } 
    }
}
