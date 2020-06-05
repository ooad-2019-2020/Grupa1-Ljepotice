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
    public class FormaZaTestDBsController : Controller
    {
        private readonly BeautyCentarContext _context;

        public FormaZaTestDBsController(BeautyCentarContext context)
        {
            _context = context;
        }

        // GET: FormaZaTestDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormaZaTest.ToListAsync());
        }

        // GET: FormaZaTestDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaZaTestDB = await _context.FormaZaTest
                .FirstOrDefaultAsync(m => m.ID == id);
            if (formaZaTestDB == null)
            {
                return NotFound();
            }

            return View(formaZaTestDB);
        }

        // GET: FormaZaTestDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormaZaTestDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,tipKoze,odabranaZona,rezultat,klijent")] FormaZaTestDB formaZaTestDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaZaTestDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formaZaTestDB);
        }

        // GET: FormaZaTestDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaZaTestDB = await _context.FormaZaTest.FindAsync(id);
            if (formaZaTestDB == null)
            {
                return NotFound();
            }
            return View(formaZaTestDB);
        }

        // POST: FormaZaTestDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,tipKoze,odabranaZona,rezultat,klijent")] FormaZaTestDB formaZaTestDB)
        {
            if (id != formaZaTestDB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaZaTestDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormaZaTestDBExists(formaZaTestDB.ID))
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
            return View(formaZaTestDB);
        }

        // GET: FormaZaTestDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaZaTestDB = await _context.FormaZaTest
                .FirstOrDefaultAsync(m => m.ID == id);
            if (formaZaTestDB == null)
            {
                return NotFound();
            }

            return View(formaZaTestDB);
        }

        // POST: FormaZaTestDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formaZaTestDB = await _context.FormaZaTest.FindAsync(id);
            _context.FormaZaTest.Remove(formaZaTestDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormaZaTestDBExists(int id)
        {
            return _context.FormaZaTest.Any(e => e.ID == id);
        }
    }
}
