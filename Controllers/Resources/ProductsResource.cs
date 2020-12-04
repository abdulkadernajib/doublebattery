using System;
using doublebattery.Core;

namespace doublebattery.Controllers.Resources
{
    public class ProductsResource
    {
        public int Id { get; set; }

        public string Sku { get; set; }

        public BrandResource Brand { get; set; }
        public ModelResource Model { get; set; }

        public string ColorChildId { get; set; }

        public string SizeChildId { get; set; }

        public string BrandColorName { get; set; } //Done

        public string BrandSizeName { get; set; } //Done

        public KeyValuePair FrameColor { get; set; } //Done
        public KeyValuePair TempleColor { get; set; } //Done

        public KeyValuePair LensColor { get; set; } //Done

        public KeyValuePair Size { get; set; }

        public KeyValuePair FrameMaterial { get; set; } //Done
        public KeyValuePair TempleMaterial { get; set; } //Done

        public KeyValuePair LensMaterial { get; set; } //Done

        public KeyValuePair IdealFor { get; set; } //Done

        public KeyValuePair Category { get; set; } //Done

        public KeyValuePair Style { get; set; } //Done

        public KeyValuePair FrameType { get; set; }  //Done

        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdate { get; set; }

        public int LensWidth { get; set; }
        public int LensHeight { get; set; }
        public int BridgeSize { get; set; }
        public int TempleLength { get; set; }

    }
}