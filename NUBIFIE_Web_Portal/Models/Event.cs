using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EventTitle { get; set; }
        [Required]
        public string EventContent { get; set; }
        public string EventUrl { get; set; }
        public string EventCoverPicAddress { get; set; } = "~/news/Image/empty_frame.jpg";
        public DateTime EventDate { get; set; } = DateTime.Now;
        [Required]
        public int EventDisplayPriority { get; set; }
        [Required]
        public string EventCoverPicCaption { get; set; }
        public int EventViewFrequency { get; set; }
    }
}
