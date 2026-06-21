namespace NUBIFIE_Web_Portal.Models
{
    public class EventDetailsViewModel
    {
        public Event EventDetails { get; set; }
        public IEnumerable<EventPicture> EventPictures { get; set; }
    }
}
