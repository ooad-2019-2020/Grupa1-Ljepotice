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
    public class KorisnikDBsController : Controller
    {
        private readonly BeautyCentarContext _context;

        public KorisnikDBsController(BeautyCentarContext context)
        {
            _context = context;
        }

        // GET: KorisnikDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Korisnik.ToListAsync());
        }

        // GET: KorisnikDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnikDB = await _context.Korisnik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (korisnikDB == null)
            {
                return NotFound();
            }

            return View(korisnikDB);
        }

        // GET: KorisnikDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: KorisnikDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ime,prezime,email,password")] KorisnikDB korisnikDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(korisnikDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(korisnikDB);
        }

        // GET: KorisnikDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnikDB = await _context.Korisnik.FindAsync(id);
            if (korisnikDB == null)
            {
                return NotFound();
            }
            return View(korisnikDB);
        }

        // POST: KorisnikDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,prezime,email,password")] KorisnikDB korisnikDB)
        {
            if (id != korisnikDB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(korisnikDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KorisnikDBExists(korisnikDB.ID))
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
            return View(korisnikDB);
        }

        // GET: KorisnikDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnikDB = await _context.Korisnik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (korisnikDB == null)
            {
                return NotFound();
            }

            return View(korisnikDB);
        }

        // POST: KorisnikDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var korisnikDB = await _context.Korisnik.FindAsync(id);
            _context.Korisnik.Remove(korisnikDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KorisnikDBExists(int id)
        {
            return _context.Korisnik.Any(e => e.ID == id);
        }

        public IActionResult PodaciOKlijentu()
        {
            return View();
        }
    }
}
