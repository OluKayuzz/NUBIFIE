namespace NUBIFIE_Web_Portal.Models
{
    public class NewsDetailsModel
    {
        public int Id { get; set; }
        public string NewsTitle { get; set; }
        public string NewsContent { get; set; }
        public string NewsUrl { get; set; }
        public string NewsCoverPicAddress { get; set; }
        public bool NewsHasVideo { get; set; } = false;
        public bool NewsHasAudio { get; set; } = false;
        public string NewsVideoAddress { get; set; }
        public string NewsAudioAddress { get; set; }
        public DateTime NewsDate { get; set; }
        public string NewsSource { get; set; }
        public string NewsSourceImgAddress { get; set; }
        public int NewsDisplayPriority { get; set; }
        //public int NewsGroupId { get; set; }
        public string NewsCoverPicCaption { get; set; }
        public string NewsVideoCaption { get; set; }
        public string NewsAudioCaption { get; set; }
        public int NewViewFrequency { get; set; }
        public String Category { get; set; }
    }
}
