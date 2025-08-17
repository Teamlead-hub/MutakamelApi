
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class TestMethods : EntityRoot
    {
        [NotMapped]
        public string? TestName { get; set; }
        public string? MethodName { get; set; }
    }
}
