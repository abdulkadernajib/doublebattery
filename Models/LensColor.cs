using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using doublebattery.Models;

[Table("LensColors")]
public class LensColor
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    public ICollection<Product> Product { get; set; }

    public LensColor()
    {
        Product = new Collection<Product>();
    }
}
