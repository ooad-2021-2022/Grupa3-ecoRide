using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ecoRide.Data;
using ecoRide.Models;
using Microsoft.AspNetCore.Authorization;

namespace ecoRide.Controllers
{
    [Authorize]
    public class RecenzijeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RecenzijeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Recenzije
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Recenzije.Include(r => r.Korisnik);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Recenzije/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzije = await _context.Recenzije
                .Include(r => r.Korisnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recenzije == null)
            {
                return NotFound();
            }

            return View(recenzije);
        }

        // GET: Recenzije/Create
        public IActionResult Create()
        {
            ViewData["KorisnikId"] = new SelectList(_context.Korisnik, "Id", "Id");
            return View();
        }

        // POST: Recenzije/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ocjena,Komentar,KorisnikId")] Recenzije recenzije)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recenzije);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KorisnikId"] = new SelectList(_context.Korisnik, "Id", "Id", recenzije.KorisnikId);
            return View(recenzije);
        }

        // GET: Recenzije/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzije = await _context.Recenzije.FindAsync(id);
            if (recenzije == null)
            {
                return NotFound();
            }
            ViewData["KorisnikId"] = new SelectList(_context.Korisnik, "Id", "Id", recenzije.KorisnikId);
            return View(recenzije);
        }

        // POST: Recenzije/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ocjena,Komentar,KorisnikId")] Recenzije recenzije)
        {
            if (id != recenzije.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recenzije);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecenzijeExists(recenzije.Id))
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
            ViewData["KorisnikId"] = new SelectList(_context.Korisnik, "Id", "Id", recenzije.KorisnikId);
            return View(recenzije);
        }

        // GET: Recenzije/Delete/5
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzije = await _context.Recenzije
                .Include(r => r.Korisnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recenzije == null)
            {
                return NotFound();
            }

            return View(recenzije);
        }

        // POST: Recenzije/Delete/5
        [Authorize(Roles = "Administrator")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recenzije = await _context.Recenzije.FindAsync(id);
            _context.Recenzije.Remove(recenzije);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecenzijeExists(int id)
        {
            return _context.Recenzije.Any(e => e.Id == id);
        }
    }
}
