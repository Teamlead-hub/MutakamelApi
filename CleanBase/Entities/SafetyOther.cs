
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CleanBase.Entities
{
    public class SafetyOther : EntityRoot
    {

     public string?ProductName{ get; set; }
     public string?SafetyType{ get; set; }
     [JsonConverter(typeof(DateOnlyJsonConverter))]
     public DateOnly?LastReviewDate{ get; set; }
     public string?AdditionalInformation{ get; set; }


        

    } 

}
