using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace doublebattery.Controllers.Resources
{
    public class BrandResource
    {
        public int Id { get; set; }
        public string BrandId { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }

        public BrandResource()
        {
            Models = new Collection<ModelResource>();
        }
    }
}