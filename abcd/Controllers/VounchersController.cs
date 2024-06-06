using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace abcd.Controllers
{
    public class VounchersController : Controller
    {
        // GET: VounchersController
        public ActionResult Index()
        {
            return View();
        }

        // GET: VounchersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VounchersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VounchersController/Create
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

        // GET: VounchersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VounchersController/Edit/5
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

        // GET: VounchersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VounchersController/Delete/5
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
