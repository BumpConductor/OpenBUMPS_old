using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using OpenBUMPS.Models;

namespace OpenBUMPS.Controllers
{
    public class BUMPsController : Controller
    {
        private ApplicationDbContext _context;

        public BUMPsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: BUMPs
        public IActionResult Index()
        {
            return View(_context.BUMP.ToList());
        }

        // GET: BUMPs/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BUMP bUMP = _context.BUMP.Single(m => m.ID == id);
            if (bUMP == null)
            {
                return HttpNotFound();
            }

            return View(bUMP);
        }

        // GET: BUMPs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BUMPs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Modified by Ken to protect against over-posting
        public IActionResult Create(BUMP bUMP)
        {
            if (ModelState.IsValid)
            {
                _context.BUMP.Add(bUMP);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bUMP);
        }

        // GET: BUMPs/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BUMP bUMP = _context.BUMP.Single(m => m.ID == id);
            if (bUMP == null)
            {
                return HttpNotFound();
            }
            return View(bUMP);
        }

        // POST: BUMPs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        // Modified by Ken to protect against over-posting
        public IActionResult Edit(BUMP bUMP)
        {
            if (ModelState.IsValid)
            {
                _context.Update(bUMP);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bUMP);
        }

        // GET: BUMPs/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            BUMP bUMP = _context.BUMP.Single(m => m.ID == id);
            if (bUMP == null)
            {
                return HttpNotFound();
            }

            return View(bUMP);
        }

        // POST: BUMPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            BUMP bUMP = _context.BUMP.Single(m => m.ID == id);
            _context.BUMP.Remove(bUMP);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
