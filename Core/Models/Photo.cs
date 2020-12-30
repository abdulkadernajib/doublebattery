using System.ComponentModel.DataAnnotations;

namespace doublebattery.Core.Models
{
    public class Photo
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string FileName { get; set; }
        public int ProductId { get; set; }
    }
}