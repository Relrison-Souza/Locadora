using Locadora.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locadora.Controllers
{
    public class EmprestimoController : Controller
    {
        public static List<Filme> lsfilme = new List<Filme>();
        public ActionResult Index()
        {
            return View(lsfilme);
        }

        // GET: EmprestimoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmprestimoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmprestimoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filme Objeto)
        {
            lsfilme.Add(Objeto);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmprestimoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmprestimoController/Edit/5
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

        // GET: EmprestimoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmprestimoController/Delete/5
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
