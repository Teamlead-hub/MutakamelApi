namespace CleanBase.Entities
{
    public class V_StockSpec : EntityRoot
    {
        public string? Specid { get; set; }
        public string? SpecName { get; set; }
        public string? JordanSpec { get; set; }
        public string? FactorySpec { get; set; }
        public string? StockId { get; set; }
        public V_stock? Stock { get; set; }
        public List<V_StockTest> StockTest { get; set; } = new List<V_StockTest>();
    }
}
