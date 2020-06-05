using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Implementacija.Models;

namespace Implementacija.Controllers
{
    public class FormaZaTretmanDBsController : Controller
    {
        private readonly BeautyCentarContext _context;

        public FormaZaTretmanDBsController(BeautyCentarContext context)
        {
            _context = context;
        }

        // GET: FormaZaTretmanDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormaZaTretman.ToListAsync());
        }

        // GET: FormaZaTretmanDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaZaTretmanDB = await _context.FormaZaTretman
                .FirstOrDefaultAsync(m => m.ID == id);
            if (formaZaTretmanDB == null)
            {
                return NotFound();
            }

            return View(formaZaTretmanDB);
        }

        // GET: FormaZaTretmanDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormaZaTretmanDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,klijent,tretman,odabranaZona,rezultatTretmana,tehnikaRada,dodatneNapomene")] FormaZaTretmanDB formaZaTretmanDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaZaTretmanDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formaZaTretmanDB);
        }

        // GET: FormaZaTretmanDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaZaTretmanDB = await _context.FormaZaTretman.FindAsync(id);
            if (formaZaTretmanDB == null)
            {
                return NotFound();
            }
            return View(formaZaTretmanDB);
        }

        // POST: FormaZaTretmanDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,klijent,tretman,odabranaZona,rezultatTretmana,tehnikaRada,dodatneNapomene")] FormaZaTretmanDB formaZaTretmanDB)
        {
            if (id != formaZaTretmanDB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaZaTretmanDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormaZaTretmanDBExists(formaZaTretmanDB.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(formaZaTretmanDB);
        }

        // GET: FormaZaTretmanDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaZaTretmanDB = await _context.FormaZaTretman
                .FirstOrDefaultAsync(m => m.ID == id);
            if (formaZaTretmanDB == null)
            {
                return NotFound();
            }

            return View(formaZaTretmanDB);
        }

        // POST: FormaZaTretmanDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaZaTretmanDB = await _context.FormaZaTretman.FindAsync(id);
            _context.FormaZaTretman.Remove(formaZaTretmanDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormaZaTretmanDBExists(int id)
        {
            return _context.FormaZaTretman.Any(e => e.ID == id);
        }
    }
}
