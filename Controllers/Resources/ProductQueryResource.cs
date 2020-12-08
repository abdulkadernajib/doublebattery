namespace doublebattery.Controllers.Resources
{
    public class ProductQueryResource
    {
        public int? BrandId { get; set; }
        public int? ModelId { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAssending { get; set; }

    }
}