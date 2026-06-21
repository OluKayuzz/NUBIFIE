using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NUBIFIE_Web_Portal.Data;
using NUBIFIE_Web_Portal.Models;

namespace NUBIFIE_Web_Portal.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MenuController(ApplicationDbContext db)
        {
            _db = db;
        }

        public class MyViewModel
        {
            public IEnumerable<SysOption> ObjSysOptionList { get; set; }
            public IEnumerable<NACM> ObjNACMList { get; set; }
            public IEnumerable<NSS_ZCS> ObjNSS_ZCSList { get; set; }
        }

        public IActionResult Index()
        {
            IEnumerable<SysOption> objSysOptionList = _db.SysOptions.ToList();

            var viewModel = new MyViewModel
            {
                ObjSysOptionList = objSysOptionList
            };

            return View(viewModel);
        }

        public IActionResult Objective()
        {
            IEnumerable<SysOption> objSysOptionList = _db.SysOptions.ToList();

            var viewModel = new MyViewModel
            {
                ObjSysOptionList = objSysOptionList
            };

            return View(viewModel);
        }

        public IActionResult Mission()
        {
            IEnumerable<SysOption> objSysOptionList = _db.SysOptions.ToList();

            var viewModel = new MyViewModel
            {
                ObjSysOptionList = objSysOptionList
            };

            return View(viewModel);
        }

        public IActionResult Partner()
        {
            return View();
        }

        public IActionResult NACM()
        {
            IEnumerable<SysOption> objSysOptionList = _db.SysOptions.ToList();
            IEnumerable<NACM> objNACMList = _db.NACM.Where(n => n.Active == true).OrderBy(n => n.OrderList).ToList();

            var viewModel = new MyViewModel
            {
                ObjSysOptionList = objSysOptionList,
                ObjNACMList = objNACMList
            };

            return View(viewModel);
        }

        public IActionResult NSS_ZCS()
        {
            IEnumerable<SysOption> objSysOptionList = _db.SysOptions.ToList();
            IEnumerable<NSS_ZCS> ObjNSS_ZCSList = _db.NSS_ZCS.Where(n => n.Active == true).OrderBy(n => n.OrderList).ToList();

            var viewModel = new MyViewModel
            {
                ObjSysOptionList = objSysOptionList,
                ObjNSS_ZCSList = ObjNSS_ZCSList
            };

            return View(viewModel);
        }

        public async Task<IActionResult> EventTitle(int pageNumber = 1, int pageSize = 10)
        {
            var objEvents = await _db.Events
                .OrderByDescending(n => n.EventTitle)
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

            return View("Events", model);
        }

        public async Task<IActionResult> EventDate(int pageNumber = 1, int pageSize = 10)
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

            return View("Events", model);
        }

        public async Task<IActionResult> EventTopView(int pageNumber = 1, int pageSize = 10)
        {
            var objEvents = await _db.Events
                .OrderByDescending(n => n.EventViewFrequency)
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

            return View("Events", model);
        }

        public async Task<IActionResult> ActivityTitle(int pageNumber = 1, int pageSize =10)
        {
            var objActivities = await _db.Activities
                .OrderByDescending(n => n.ActivityTitle)
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

            return View("Activities", model);
        }

        public async Task<IActionResult> ActivityDate(int pageNumber = 1, int pageSize = 10)
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

            return View("Activities", model);
        }

        public async Task<IActionResult> ActivityTopView(int pageNumber = 1, int pageSize = 10)
        {
            var objActivities = await _db.Activities
                .OrderByDescending(n => n.ActivityViewFrequency)
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

            return View("Activities", model);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
