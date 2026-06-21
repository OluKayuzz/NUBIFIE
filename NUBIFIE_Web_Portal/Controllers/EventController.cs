using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUBIFIE_Web_Portal.Data;
using NUBIFIE_Web_Portal.Models;

namespace NUBIFIE_Web_Portal.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EventController(ApplicationDbContext db)
        {
                _db = db;
        }

        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10)
        {
            var objEvents = await _db.Events
                .OrderByDescending(n => n.EventDate)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            var totalItems = await _db.Events.CountAsync();

            var model = new EventViewModel
            {
                EventsItems = objEvents,
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

            var eventDetails = await _db.Events.FirstOrDefaultAsync(n => n.Id == Id);

            if (eventDetails == null)
            {
                return NotFound();
            }

            var eventPictures = _db.EventsPictures.Where(n => n.EventId == Id).ToList();
            var viewModel = new EventDetailsViewModel
            {
                EventDetails = eventDetails,
                EventPictures = eventPictures
            };

            return View(viewModel);
        }
    }
}
