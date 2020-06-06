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
    public class UplatnicaDBsController : Controller
    {
        private readonly BeautyCentarContext _context;

        public UplatnicaDBsController(BeautyCentarContext context)
        {
            _context = context;
        }

        // GET: UplatnicaDBs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Uplatnica.ToListAsync());
        }

        // GET: UplatnicaDBs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uplatnicaDB = await _context.Uplatnica
                .FirstOrDefaultAsync(m => m.ID == id);
            if (uplatnicaDB == null)
            {
                return NotFound();
            }

            return View(uplatnicaDB);
        }

        // GET: UplatnicaDBs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UplatnicaDBs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,klijent,nazivTretmana,brojRacuna,cijenaTretmana,nacinPlacanja")] UplatnicaDB uplatnicaDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(uplatnicaDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(uplatnicaDB);
        }

        // GET: UplatnicaDBs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uplatnicaDB = await _context.Uplatnica.FindAsync(id);
            if (uplatnicaDB == null)
            {
                return NotFound();
            }
            return View(uplatnicaDB);
        }

        // POST: UplatnicaDBs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,klijent,nazivTretmana,brojRacuna,cijenaTretmana,nacinPlacanja")] UplatnicaDB uplatnicaDB)
        {
            if (id != uplatnicaDB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uplatnicaDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UplatnicaDBExists(uplatnicaDB.ID))
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
            return View(uplatnicaDB);
        }

        // GET: UplatnicaDBs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uplatnicaDB = await _context.Uplatnica
                .FirstOrDefaultAsync(m => m.ID == id);
            if (uplatnicaDB == null)
            {
                return NotFound();
            }

            return View(uplatnicaDB);
        }

        // POST: UplatnicaDBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uplatnicaDB = await _context.Uplatnica.FindAsync(id);
            _context.Uplatnica.Remove(uplatnicaDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UplatnicaDBExists(int id)
        {
            return _context.Uplatnica.Any(e => e.ID == id);
        }
    }
}
