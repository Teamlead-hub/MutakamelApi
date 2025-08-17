namespace CleanBase.Entities
{
    public class V_StockStore : EntityRoot
    {
        public string? StoreName { get; set; }
        public decimal? Quantity { get; set; }
        public string? StockId { get; set; }
        public V_stock? Stock { get; set; }
    }
}
