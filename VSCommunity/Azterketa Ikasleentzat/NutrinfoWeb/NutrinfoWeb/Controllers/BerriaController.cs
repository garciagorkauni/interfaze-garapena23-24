using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NutrinfoWeb.Models;
using NutrinfoWeb.Services;

namespace NutrinfoWeb.Controllers
{
    [Authorize]
    public class BerriaController : Controller
    {
        private readonly IBerriaService _berriaService;
        public BerriaController(IBerriaService berriaService)
        {
            _berriaService = berriaService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IndexCreate([Bind("Titularra, Deskripzioa, Nabarmena")] Berria berria)
        {
            if (ModelState.IsValid)
            {

                berria.Autorea = HttpContext.User.Identity.Name;
                berria.Data = DateTime.Now;
                await _berriaService.BerriaSortu(berria);

                return RedirectToAction("Index", "Home");
            }
            return View(berria);
        }


        // GET: BerriaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BerriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BerriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BerriaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BerriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BerriaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BerriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
