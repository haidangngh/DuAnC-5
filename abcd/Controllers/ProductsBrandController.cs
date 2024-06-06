using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace abcd.Controllers
{
    public class ProductsBrandController : Controller
    {
        // GET: ProductsBrandController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductsBrandController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsBrandController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsBrandController/Create
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

        // GET: ProductsBrandController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsBrandController/Edit/5
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

        // GET: ProductsBrandController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsBrandController/Delete/5
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
