using CleanBase.Entities;
using System.Text.Json.Serialization;

namespace CleanBase
{
    public class EntityRoot : IEntityRoot
    {
        public string? Id { get; set; }
        public byte[]? Rowversion { get; set; }

    }


}
