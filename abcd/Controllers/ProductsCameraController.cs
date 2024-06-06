using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace abcd.Controllers
{
    public class ProductsCameraController : Controller
    {
        // GET: ProductsCameraController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductsCameraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsCameraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsCameraController/Create
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

        // GET: ProductsCameraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsCameraController/Edit/5
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

        // GET: ProductsCameraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsCameraController/Delete/5
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
