
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
    public class SafetyDisposal : EntityRoot
    {
      public string? ProductName { get; set; }
      public string? SafetyType { get; set; }
  
     
      public string?GeneralInformation{ get; set; }
      public string?DisposalInformation{ get; set; }
      public string?PackagingInformation{ get; set; }
      public string?WastewaterDisposal{ get; set; }

    } 

}
