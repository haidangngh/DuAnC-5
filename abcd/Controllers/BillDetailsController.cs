using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace abcd.Controllers
{
    public class BillDetailsController : Controller
    {
        // GET: BillDetailsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BillDetailsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BillDetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BillDetailsController/Create
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

        // GET: BillDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BillDetailsController/Edit/5
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

        // GET: BillDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BillDetailsController/Delete/5
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
