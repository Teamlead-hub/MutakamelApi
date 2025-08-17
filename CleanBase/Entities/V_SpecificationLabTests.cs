

namespace CleanBase.Entities
{
    public class V_SpecificationLabTests : EntityRoot
    {
        public string? LabTestsId { get; set; }
        public string? TestName { get; set; }
        public string? Testcode { get; set; }
        public string? SpecificationsId { get; set; }
        public V_Specifications? Specifications { get; set; }
    }
}
      