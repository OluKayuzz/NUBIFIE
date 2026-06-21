using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class ActivityPicture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ActivityId { get; set; }
        public string ActivityPictureAddress { get; set; } = "~/news/Image/empty_frame.jpg";
        public string PictureCaption { get; set; }
    }
}
