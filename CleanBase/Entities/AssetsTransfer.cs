using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CleanBase.Entities
{
    public class AssetsTransfer : EntityRoot
    {
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly? TransferDate { get; set; }
        public string? AssetsId { get; set; }
        [NotMapped]
        public string? Asset_Desc { get; set; }
        public string? OldStoreId { get; set; }
        [NotMapped]
        public string? OldStoreName { get; set; }
        public string? NewStoreId { get; set; }
        [NotMapped]
        public string? NewStoreName { get; set; }
        public string? OldSectionId { get; set; }
        [NotMapped]
        public string? OldSectionName { get; set; }
        public string? NewSectionId { get; set; }
        [NotMapped]
        public string? NewSectionName { get; set; }
        public string? Notes { get; set; }
        public string? TransferReason { get; set; }



    }
}
