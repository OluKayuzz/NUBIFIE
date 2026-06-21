using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class EventPicture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int EventId { get; set; }
        [Required]
        public bool PictureVideo { get; set; }
        public string PictureVideoAddress { get; set; }= "~/news/Image/empty_frame.jpg";
        //public string EventVideo { get; set; }
        public string PictureVideoCaption { get; set; }
    }
}
