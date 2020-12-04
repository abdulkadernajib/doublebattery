using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace doublebattery.Models
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        public string Sku { get; set; }

        public Model Model { get; set; }
        [Required]
        public int ModelId { get; set; } //Done

        [Required]
        public string ColorChildId { get; set; }

        [Required]
        public string SizeChildId { get; set; }

        [Required]
        public string BrandColorName { get; set; } //Done

        [Required]
        public string BrandSizeName { get; set; } //Done

        public Color FrameColor { get; set; } //Done
        public int FrameColorId { get; set; } //Done
        public int TempleColorId { get; set; } //Done

        public LensColor LensColor { get; set; } //Done
        public int LensColorId { get; set; } //Done

        public Size Size { get; set; }
        public int SizeId { get; set; }

        public FrameMaterial FrameMaterial { get; set; }
        public int FrameMaterialId { get; set; } //Done
        public int TempleMaterialId { get; set; } //Done

        public LensMaterial LensMaterial { get; set; } //Done
        public int LensMaterialId { get; set; } //Done

        public IdealFor IdealFor { get; set; } //Done
        [Required]
        public int IdealForId { get; set; } //Done

        public Category Category { get; set; } //Done
        [Required]
        public int CategoryId { get; set; } //Done

        public Style Style { get; set; } //Done
        public int StyleId { get; set; } //Done

        public FrameType FrameType { get; set; }  //Done
        public int FrameTypeId { get; set; }  //Done

        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdate { get; set; }

        public int LensWidth { get; set; }
        public int LensHeight { get; set; }
        public int BridgeSize { get; set; }
        public int TempleLength { get; set; }



    }
}