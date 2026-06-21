using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class Sector
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}
