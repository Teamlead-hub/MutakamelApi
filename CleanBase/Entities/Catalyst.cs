
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
    public class Catalyst : EntityRoot
    {

        public string? CatalystName { get; set; }
        public string ? CatalystNameAr {  get; set; }



    } 

}
