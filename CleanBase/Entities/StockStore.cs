namespace CleanBase.Entities
{
    public class StockStore : EntityRoot
    {
        public string? StoreName { get; set; }
        public string? Quantity { get; set; }
        public string? StockId { get; set; }
        public Stock? Stock { get; set; }
    }
}
