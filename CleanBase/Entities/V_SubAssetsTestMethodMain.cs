namespace CleanBase.Entities
{
    public class V_SubAssetsTestMethodMain : EntityRoot
    {
        public string? MaintenanceTestMethodMainId { get; set; }
        public string? TestNameAr { get; set; }
        public string? TestNameEn { get; set; }
        public string? SubAssetsId { get; set; }
        public V_SubAssets? SubAssets { get; set; }
        public List<V_SubAssetsTestMethodSub> SubAssetsTestMethodSub { get; set; } = new List<V_SubAssetsTestMethodSub>();
    }
}
