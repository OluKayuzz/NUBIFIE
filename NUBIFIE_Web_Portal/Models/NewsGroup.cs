using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class NewsGroup
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
    }
}
