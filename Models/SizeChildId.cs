using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using doublebattery.Models;

namespace doublebattery.Models
{
[Table("SizeChildIds")]
public class SizeChildId
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    public ICollection<Product> Product { get; set; }

    public SizeChildId()
    {
        Product = new Collection<Product>();
    }
}
}