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
    public class RezervacijaDBsController : Controller
    {
        private readonly BeautyCentarContext _context;

        public RezervacijaDBsController(BeautyCentarContext context)
        {
            _context = context;
        }

        // GET: RezervacijaDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rezervacija.ToListAsync());
        }

        // GET: RezervacijaDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaDB = await _context.Rezervacija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rezervacijaDB == null)
            {
                return NotFound();
            }

            return View(rezervacijaDB);
        }

        // GET: RezervacijaDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RezervacijaDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,vrijemeRezervacije,imeIPrezime,odabraniTretman,tipPlacanja")] RezervacijaDB rezervacijaDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rezervacijaDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rezervacijaDB);
        }

        // GET: RezervacijaDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaDB = await _context.Rezervacija.FindAsync(id);
            if (rezervacijaDB == null)
            {
                return NotFound();
            }
            return View(rezervacijaDB);
        }

        // POST: RezervacijaDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,vrijemeRezervacije,imeIPrezime,odabraniTretman,tipPlacanja")] RezervacijaDB rezervacijaDB)
        {
            if (id != rezervacijaDB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rezervacijaDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RezervacijaDBExists(rezervacijaDB.ID))
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
            return View(rezervacijaDB);
        }

        // GET: RezervacijaDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rezervacijaDB = await _context.Rezervacija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (rezervacijaDB == null)
            {
                return NotFound();
            }

            return View(rezervacijaDB);
        }

        // POST: RezervacijaDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rezervacijaDB = await _context.Rezervacija.FindAsync(id);
            _context.Rezervacija.Remove(rezervacijaDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RezervacijaDBExists(int id)
        {
            return _context.Rezervacija.Any(e => e.ID == id);
        }
    }
}
