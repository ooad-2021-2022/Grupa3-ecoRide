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
    public class PocetniZaslonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PocetniZaslonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PocetniZaslon
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Izvjestaj.Include(i => i.Korisnik);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PocetniZaslon/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvjestaj = await _context.Izvjestaj
                .Include(i => i.Korisnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (izvjestaj == null)
            {
                return NotFound();
            }

            return View(izvjestaj);
        }

        // GET: PocetniZaslon/Create
        public IActionResult Create()
        {
            ViewData["KorisnikID"] = new SelectList(_context.Korisnik, "Id", "Id");
            return View();
        }

        // POST: PocetniZaslon/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BrojPotrosenihKalorija,UstedaNovca,SmanjenjeEmisijeCO2,KorisnikID")] Izvjestaj izvjestaj)
        {
            if (ModelState.IsValid)
            {
                _context.Add(izvjestaj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KorisnikID"] = new SelectList(_context.Korisnik, "Id", "Id", izvjestaj.KorisnikID);
            return View(izvjestaj);
        }

        // GET: PocetniZaslon/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvjestaj = await _context.Izvjestaj.FindAsync(id);
            if (izvjestaj == null)
            {
                return NotFound();
            }
            ViewData["KorisnikID"] = new SelectList(_context.Korisnik, "Id", "Id", izvjestaj.KorisnikID);
            return View(izvjestaj);
        }

        // POST: PocetniZaslon/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BrojPotrosenihKalorija,UstedaNovca,SmanjenjeEmisijeCO2,KorisnikID")] Izvjestaj izvjestaj)
        {
            if (id != izvjestaj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(izvjestaj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IzvjestajExists(izvjestaj.Id))
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
            ViewData["KorisnikID"] = new SelectList(_context.Korisnik, "Id", "Id", izvjestaj.KorisnikID);
            return View(izvjestaj);
        }

        // GET: PocetniZaslon/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var izvjestaj = await _context.Izvjestaj
                .Include(i => i.Korisnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (izvjestaj == null)
            {
                return NotFound();
            }

            return View(izvjestaj);
        }

        // POST: PocetniZaslon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var izvjestaj = await _context.Izvjestaj.FindAsync(id);
            _context.Izvjestaj.Remove(izvjestaj);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IzvjestajExists(int id)
        {
            return _context.Izvjestaj.Any(e => e.Id == id);
        }
    }
}
