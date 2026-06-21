using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUBIFIE_Web_Portal.Data;
using NUBIFIE_Web_Portal.Models;

namespace NUBIFIE_Web_Portal.Controllers
{
    public class Activity_Controller : Controller
    {
        private readonly ApplicationDbContext _db;

        public Activity_Controller(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10)
        {
            var objActivities = await _db.Activities
                .OrderByDescending(n => n.ActivityDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var totalItems = await _db.Activities.CountAsync();

            var model = new ActivityViewModel
            {
                ActivityItems = objActivities,
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

            var activityDetails = await _db.Activities.FirstOrDefaultAsync(n => n.Id == Id);

            if (activityDetails == null)
            {
                return NotFound();
            }

            var activityPictures = _db.ActivityPictures.Where(n => n.ActivityId == Id).ToList();
            var viewModel = new ActivityDetailsViewModel
            {
                ActivityDetails = activityDetails,
                ActivityPictures = activityPictures
            };

            return View(viewModel);
        }
    }
}
