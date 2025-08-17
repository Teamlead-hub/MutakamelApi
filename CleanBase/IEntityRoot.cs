using System.ComponentModel.DataAnnotations;

namespace CleanBase
{
    public interface IEntityRoot
    {
        string Id { get; set; }
        [Timestamp]
        byte[] Rowversion { get; set; }
    }
}
