namespace NUBIFIE_Web_Portal.Models
{
    public class NewsViewModel
    {
        public IEnumerable<NewsDetailsModel> NewsItems { get; set; }
        public Pagination Pagination { get; set; }
    }

    public class EventViewModel
    {
        public IEnumerable<Event> EventsItems { get; set; }
        public Pagination Pagination { get; set; }
    }

    public class ActivityViewModel
    {
        public IEnumerable<Activity_> ActivityItems { get; set; }
        public Pagination Pagination { get; set; }
    }

    public class Pagination
    {
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / ItemsPerPage);
    }
}
