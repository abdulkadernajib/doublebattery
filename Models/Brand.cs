using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace doublebattery.Models
{
    [Table("Brands")]
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        [StringLength(3)]
        public string BrandId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }

        public Brand()
        {
            Models = new Collection<Model>();
        }
    }
}