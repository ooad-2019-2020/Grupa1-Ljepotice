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
    public class ZaposlenikDBsController : Controller
    {
        private readonly BeautyCentarContext _context;

        public ZaposlenikDBsController(BeautyCentarContext context)
        {
            _context = context;
        }

        // GET: ZaposlenikDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zaposlenik.ToListAsync());
        }

        // GET: ZaposlenikDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zaposlenikDB = await _context.Zaposlenik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (zaposlenikDB == null)
            {
                return NotFound();
            }

            return View(zaposlenikDB);
        }

        // GET: ZaposlenikDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZaposlenikDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ime,prezime,username,password,tipKozmeticara")] ZaposlenikDB zaposlenikDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zaposlenikDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zaposlenikDB);
        }

        // GET: ZaposlenikDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zaposlenikDB = await _context.Zaposlenik.FindAsync(id);
            if (zaposlenikDB == null)
            {
                return NotFound();
            }
            return View(zaposlenikDB);
        }

        // POST: ZaposlenikDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ime,prezime,username,password,tipKozmeticara")] ZaposlenikDB zaposlenikDB)
        {
            if (id != zaposlenikDB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zaposlenikDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZaposlenikDBExists(zaposlenikDB.ID))
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
            return View(zaposlenikDB);
        }

        // GET: ZaposlenikDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zaposlenikDB = await _context.Zaposlenik
                .FirstOrDefaultAsync(m => m.ID == id);
            if (zaposlenikDB == null)
            {
                return NotFound();
            }

            return View(zaposlenikDB);
        }

        // POST: ZaposlenikDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zaposlenikDB = await _context.Zaposlenik.FindAsync(id);
            _context.Zaposlenik.Remove(zaposlenikDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZaposlenikDBExists(int id)
        {
            return _context.Zaposlenik.Any(e => e.ID == id);
        }
    }
}
