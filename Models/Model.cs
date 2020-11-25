using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace doublebattery.Models
{
    [Table("Models")]
    public class Model
    {
        public int Id { get; set; }
        [Required]
        [StringLength(3)]
        public string ModelId { get; set; }
        [Required]
        [StringLength(50)]
        public string BrandModelId { get; set; }

        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public DateTime CreationDate { get; set; }

    }
}