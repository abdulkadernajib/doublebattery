using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using doublebattery.Models;

[Table("Sizes")]
public class Size
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    public ICollection<Product> Product { get; set; }

    public Size()
    {
        Product = new Collection<Product>();
    }
}
