using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUBIFIE_Web_Portal.Data;
using NUBIFIE_Web_Portal.Models;
using System.Diagnostics;
using System.Linq;

namespace NUBIFIE_Web_Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public class MyViewModel
        {
            public IEnumerable<SysOption> ObjSysOptionList { get; set; }
            public IEnumerable<NewsDetailsModel> ObjNewsList { get; set; }
            public IEnumerable<Event> ObjEventList { get; set; }
            public IEnumerable<Activity_> ObjActivityList { get; set; }
        }

        public IActionResult Index()
        {
            IEnumerable<SysOption> objSysOptionList = _db.SysOptions.ToList();
            IEnumerable<Event> objEventList = _db.Events.OrderByDescending(n=>n.EventDate).Take(3).ToList();
            IEnumerable<Activity_> objActivityList = _db.Activities.OrderByDescending(n=>n.ActivityDate).Take(6).ToList();

            var orderedNewsList = _db.News
                .Join(_db.NewsGroup,
                      news => news.NewsGroupId,
                      group => group.Id,
                      (news, group) => new NewsDetailsModel
                      {
                          Id = news.Id,
                          NewsTitle = news.NewsTitle,
                          NewsContent = news.NewsContent,
                          NewsUrl = news.NewsUrl,
                          NewsAudioAddress = news.NewsAudioAddress,
                          NewsVideoAddress = news.NewsVideoAddress,
                          NewsCoverPicAddress = news.NewsCoverPicAddress,
                          NewsDisplayPriority = news.NewsDisplayPriority,
                          NewsAudioCaption = news.NewsAudioCaption,
                          NewsVideoCaption = news.NewsVideoCaption,
                          NewsCoverPicCaption = news.NewsCoverPicCaption,
                          NewsHasAudio = news.NewsHasAudio,
                          NewsHasVideo = news.NewsHasVideo,
                          NewsSource = news.NewsSource,
                          NewsSourceImgAddress = news.NewsSourceImgAddress,
                          NewViewFrequency = news.NewViewFrequency,
                          NewsDate = news.NewsDate,
                          Category = group.Category
                      })
                .OrderByDescending(n => n.NewsDate)
                .ToList();

            var viewModel = new MyViewModel
            {
                ObjSysOptionList = objSysOptionList,
                ObjNewsList = orderedNewsList,
                ObjEventList = objEventList,
                ObjActivityList = objActivityList
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
