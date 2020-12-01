using System.ComponentModel.DataAnnotations;

namespace doublebattery.Controllers.Resources
{
    public class SaveProductResource
    {
        public int Id { get; set; }
        public string Sku { get; set; }

        public int ModelId { get; set; } //Done

        public string BrandColorName { get; set; } //Done
        public int FrameColorId { get; set; } //Done
        public int TempleColorId { get; set; } //Done

        public int LensColorId { get; set; } //Done

        public string BrandSizeName { get; set; } //Done
        public int SizeId { get; set; }

        public int FrameMaterialId { get; set; } //Done
        public int TempleMaterialId { get; set; } //Done

        public int LensMaterialId { get; set; } //Done

        public int IdealForId { get; set; } //Done

        public int CategoryId { get; set; } //Done

        public int StyleId { get; set; } //Done

        public int FrameTypeId { get; set; }  //Done

        public int LensWidth { get; set; }
        public int LensHeight { get; set; }
        public int BridgeSize { get; set; }
        public int TempleLength { get; set; }

        public string ColorChildId { get; set; } //Done
        public string SizeChildId { get; set; } //Done


    }
}