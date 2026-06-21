using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class Activity_
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ActivityTitle { get; set; }
        [Required]
        public string ActivityContent { get; set; }
        public string ActivityUrl { get; set; }
        public string ActivityCoverPicAddress { get; set; } = "~/news/Image/empty_frame.jpg";
        public DateTime ActivityDate { get; set; } = DateTime.Now;
        [Required]
        public int ActivityDisplayPriority { get; set; }
        [Required]
        public string ActivityCoverPicCaption { get; set; }
        public int ActivityViewFrequency { get; set; }
    }
}
