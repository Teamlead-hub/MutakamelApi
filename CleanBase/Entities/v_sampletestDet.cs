
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanBase.Entities;
using System.Reflection;


namespace CleanBase.Entities
{
    public class v_sampletestDet : EntityRoot
    {
        public string? ItemNo { get; set; }
        public string? ItemName { get; set; }
        public string? SampletestMainId { get; set; }
        public string? ProductSpecsId { get; set; }
        public string? SpecName { get; set; }
        public string? ProductTestId { get; set; }
        public string? TestName { get; set; }
        public string? LabTestResulteId { get; set; }
        public string? TestResulteName { get; set; }
        public string? TestMethodsId { get; set; }
        public string? TestmethodName { get; set; }
        public string? UnitId { get; set; }
        public string? UnitName { get; set; }
        public decimal? Qty { get; set; }
        public string? Note { get; set; }

        public  string ? FactorySpec { get; set; }
        public string? JordanSpec { get; set; }
        public v_sampletestmain? SampletestMain { get; set; }
       

      
    } 

}
