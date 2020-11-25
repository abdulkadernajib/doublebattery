using System;
using System.ComponentModel.DataAnnotations;

namespace doublebattery.Controllers.Resources
{
    public class ModelResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(3)]
        public string ModelId { get; set; }
        [Required]
        [StringLength(50)]
        public string BrandModelId { get; set; }
        public int BrandId { get; set; }


    }
}