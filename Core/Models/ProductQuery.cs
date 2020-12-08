using doublebattery.Extension;

namespace doublebattery.Core.Models
{
    public class ProductQuery : IQueryObject
    {
        public int? BrandId { get; set; }
        public int? ModelId { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAssending { get; set; }


    }
}