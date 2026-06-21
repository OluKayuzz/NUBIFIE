using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUBIFIE_Web_Portal.Data;
using NUBIFIE_Web_Portal.Models;
using System.Linq;
using System.Threading.Tasks;

namespace NUBIFIE_Web_Portal.Controllers
{
    public class NewsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public NewsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10)
        {
            var objNews = await _db.News
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
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var totalItems = await _db.News.CountAsync();

            var model = new NewsViewModel
            {
                NewsItems = objNews,
                Pagination = new Pagination
                {
                    CurrentPage = pageNumber,
                    ItemsPerPage = pageSize,
                    TotalItems = totalItems
                }
            };

            return View(model);
        }

        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var newsDetails = await _db.News
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
                .FirstOrDefaultAsync(n => n.Id == Id);

            if (newsDetails == null)
            {
                return NotFound();
            }

            var orderedByDate = await _db.News
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
                .Where(n => n.Id != Id)
                .OrderByDescending(n => n.NewsDate)
                .Take(5)
                .ToListAsync();

            var orderedByViewFrequency = await _db.News
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
                .Where(n => n.Id != Id)
                .OrderByDescending(n => n.NewViewFrequency)
                .Take(5)
                .ToListAsync();

            var viewModel = new NewsDetailsViewModel
            {
                NewsDetail = newsDetails,
                OrderedByDate = orderedByDate,
                OrderedByViewFrequency = orderedByViewFrequency
            };

            return View(viewModel);
        }
    }
}
