using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PetShop.Web.MVC.Controllers {
    public class MonthlyLedgerController : Controller {
        // GET: MonthlyLedger
        public ActionResult MonthlyLedger() {
            return View();
        }

        // GET: MonthlyLedger/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: MonthlyLedger/Create
        public ActionResult Create() {
            return View();
        }

        // POST: MonthlyLedger/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(MonthlyLedger));
            } catch {
                return View();
            }
        }

        // GET: MonthlyLedger/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: MonthlyLedger/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: MonthlyLedger/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: MonthlyLedger/Delete/5
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
