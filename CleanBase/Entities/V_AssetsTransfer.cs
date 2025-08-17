using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class V_AssetsTransfer : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? TransferDate { get; set; }
        public string? AssetsId { get; set; }
        public string? Asset_Desc { get; set; }
        public string? OldStoreId { get; set; }
        public string? OldStoreName { get; set; }
        public string? NewStoreId { get; set; }
        public string? NewStoreName { get; set; }
        public string? OldSectionId { get; set; }
        public string? OldSectionName { get; set; }
        public string? NewSectionId { get; set; }
        public string? NewSectionName { get; set; }
        public string? Notes { get; set; }
        public string? TransferReason { get; set; }


    }
}
