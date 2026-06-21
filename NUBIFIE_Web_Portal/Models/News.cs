using System.ComponentModel.DataAnnotations;

namespace NUBIFIE_Web_Portal.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NewsTitle { get; set; }
        [Required]
        public string NewsContent { get; set; }
        public string NewsUrl { get; set; }
        public string NewsCoverPicAddress { get; set; } = "~/news/Image/empty_frame.jpg";
        public bool NewsHasVideo { get; set; } = false;
        public bool NewsHasAudio { get; set; } = false;
        public string NewsVideoAddress { get; set; }
        public string NewsAudioAddress { get; set; }
        public DateTime NewsDate { get; set; } = DateTime.Now;
        [Required]
        public string NewsSource { get; set; }
        public string NewsSourceImgAddress { get; set; } = "~/news/Source/blank_Person2/png";
        public int NewsDisplayPriority { get; set; }
        [Required]
        public int NewsGroupId { get; set; }
        public string NewsCoverPicCaption { get; set; }
        public string NewsVideoCaption { get;set; }
        public string NewsAudioCaption { get;set; }
        public int NewViewFrequency { get; set; }
    }
} 
