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
    public class TretmenController : Controller
    {
        private readonly BeautyCentarContext _context;

        public TretmenController(BeautyCentarContext context)
        {
            _context = context;
        }

        // GET: Tretmen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tretman.ToListAsync());
        }

        // GET: Tretmen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tretman = await _context.Tretman
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tretman == null)
            {
                return NotFound();
            }

            return View(tretman);
        }

        // GET: Tretmen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tretmen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,naziv,cijena,kategorijaTretmana,opisTretmana")] Tretman tretman)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tretman);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tretman);
        }

        // GET: Tretmen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tretman = await _context.Tretman.FindAsync(id);
            if (tretman == null)
            {
                return NotFound();
            }
            return View(tretman);
        }

        // POST: Tretmen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,naziv,cijena,kategorijaTretmana,opisTretmana")] Tretman tretman)
        {
            if (id != tretman.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tretman);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TretmanExists(tretman.ID))
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
            return View(tretman);
        }

        // GET: Tretmen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tretman = await _context.Tretman
                .FirstOrDefaultAsync(m => m.ID == id);
            if (tretman == null)
            {
                return NotFound();
            }

            return View(tretman);
        }

        // POST: Tretmen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tretman = await _context.Tretman.FindAsync(id);
            _context.Tretman.Remove(tretman);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TretmanExists(int id)
        {
            return _context.Tretman.Any(e => e.ID == id);
        }
    }
}
