using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class LGA
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        //[Required]
        //[StringLength(10)]
        //public string Prf { get; set; }
        [Required]
        [StringLength(10)]
        public int StateId { get; set; }
    }
}
