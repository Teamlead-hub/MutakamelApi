
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanBase.Entities;


namespace CleanBase.Entities
{
    public class v_sampletestmain : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? Entrydate { get; set; }
        public string? SuppInv { get; set; }
        public string? Issueno { get; set; }
        public string? ProductOrder { get; set; }
        public string? BatchNo { get; set; }
        public string? StockTypeId { get; set; }
        public string? StockDesc { get; set; }
        public string? ItemNo {  get; set; }
        public string? ItemName { get; set; }
        public string? PersonTester { get; set; }
        public string? PurchaseOrderMainId { get; set; }
        public string? ReceivingNo { get; set; }
        public int? SelectType { get; set; }
        public string? MixReportNo { get; set; }

        public string? ResulteReportNo { get; set; }
        public string? ReceivingReadyMaterialsNo { get; set; }
        public string? Type { get; set; }

        public List<v_sampletestDet> SampleTestDet { get; set; } = new List<v_sampletestDet>();

    }

}




