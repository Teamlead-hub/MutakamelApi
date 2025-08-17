

using System.ComponentModel.DataAnnotations.Schema;

namespace CleanBase.Entities
{
    public class SpecificationLabTests : EntityRoot
    {
        public string? LabTestsId { get; set; }
        [NotMapped]
        public string? TestName { get; set; }
        [NotMapped]
        public string? Testcode { get; set; }

        public string? SpecificationsId { get; set; }
        public Specifications? Specifications { get; set; }
    }
}
      