using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NUBIFIE_Web_Portal.Data;
using NUBIFIE_Web_Portal.Models;

namespace NUBIFIE_Web_Portal.Controllers
{
    public class MemberRegistrationController : Controller
    {
        public readonly ApplicationDbContext _db;

        public MemberRegistrationController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<MMO>> GetMMOAsync()
        {
            return await _db.MMO.Where(n => n.Active == true).ToListAsync();
        }

        public async Task<List<LGA>> GetLGAByStateIdAsync(int stateId)
        {
            return await _db.LGA.Where(l => l.StateId == stateId).ToListAsync();
        }

        public class MyViewModel
        {
            public MemberRegistration ObjMR { get; set; }
            public List<SelectListItem> MMO { get; set; }
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register()
        {
            Console.WriteLine("Register GET method hit");
            var mmo = await GetMMOAsync();
            var mmoSelectList = mmo.Select(s => new SelectListItem
            {
                Value = s.Code,
                Text = s.Name
            }).ToList();

            var viewModel = new MyViewModel
            {
                ObjMR = new MemberRegistration(),
                MMO = mmoSelectList
            };

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetLGA(int stateId)
        {
            var lgas = await GetLGAByStateIdAsync(stateId);
            return Json(lgas);
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MyViewModel viewModel)
        {
            Console.WriteLine("Create POST method hit");
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            if (ModelState.IsValid)
            {
                _db.MemeberRegistrations.Add(viewModel.ObjMR);
                _db.SaveChanges();
                return RedirectToAction("Success");
            }

            viewModel.MMO = (await GetMMOAsync()).ConvertAll(m => new SelectListItem
            {
                Text = m.Name,
                Value = m.Code
            });
            return View("Register", viewModel);
            //return RedirectToAction("Register");     //Redirect to an error page
        }

        public IActionResult Edit()
        {
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(MemberRegistration obj)
        {
            if (ModelState.IsValid)
            {

            }
            return View(obj);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
