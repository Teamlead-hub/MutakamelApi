using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanBase.Entities
{
    public class WebPages : EntityRoot
    {
       public string? page_nameAr { get; set; } 
       public string? page_nameEn { get; set; } 
       public string? parent_No { get; set; } 
       public int? ViewInMenu { get; set; } 
       public string? url { get; set; } 
       public string? Icon { get; set; } 
       public int? OrderInMenu { get; set; } 

    }
}
