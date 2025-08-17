
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
    public class LabTestResulte : EntityRoot
    {

        public string? ResulteName { get; set; }
        public string? ResulteCode { get; set; }
        public string? ResulteNote { get; set; }
    }

}
