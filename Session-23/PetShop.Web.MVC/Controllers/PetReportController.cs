using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetShop.Web.MVC.Controllers {
    public class PetReportController : Controller {
        // GET: PetReport
        public ActionResult PetReport() {
            return View();
        }

        // GET: PetReport/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: PetReport/Create
        public ActionResult Create() {
            return View();
        }

        // POST: PetReport/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(PetReport));
            } catch {
                return View();
            }
        }

        // GET: PetReport/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: PetReport/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: PetReport/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: PetReport/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
