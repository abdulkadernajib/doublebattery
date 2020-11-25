using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace doublebattery.Models
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Product> Product { get; set; }

        public Color()
        {
            Product = new Collection<Product>();
        }
    }


}
