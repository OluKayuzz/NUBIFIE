namespace NUBIFIE_Web_Portal.Models
{
    public class NewsDetailsViewModel
    {
        public NewsDetailsModel NewsDetail { get; set; }
        public IEnumerable<NewsDetailsModel> OrderedByDate { get; set; }
        public IEnumerable<NewsDetailsModel> OrderedByViewFrequency { get; set; }
    }
}
