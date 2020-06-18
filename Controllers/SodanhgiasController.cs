using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLTHPT.Models;

namespace QLTHPT.Controllers
{
    public class SodanhgiasController : Controller
    {
        private readonly acomptec_qlthptContext _context = new acomptec_qlthptContext();

        public SodanhgiasController(acomptec_qlthptContext context)
        {
            _context = context;
        }

        // GET: Sodanhgias
        public async Task<IActionResult> Index()
        {
            var acomptec_qlthptContext = _context.Sodanhgia.Include(s => s.NamhocNhMaNavigation);
            return View(await acomptec_qlthptContext.ToListAsync());
        }

        // GET: Sodanhgias/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sodanhgia = await _context.Sodanhgia
                .Include(s => s.NamhocNhMaNavigation)
                .FirstOrDefaultAsync(m => m.SdgMa == id);
            if (sodanhgia == null)
            {
                return NotFound();
            }

            return View(sodanhgia);
        }

        // GET: Sodanhgias/Create
        public IActionResult Create()
        {
            ViewData["NamhocNhMa"] = new SelectList(_context.Namhoc, "NhMa", "NhMa");
            return View();
        }

        // POST: Sodanhgias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SdgMa,SdgDiem,SdgGhichu,NamhocNhMa")] Sodanhgia sodanhgia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sodanhgia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NamhocNhMa"] = new SelectList(_context.Namhoc, "NhMa", "NhMa", sodanhgia.NamhocNhMa);
            return View(sodanhgia);
        }

        // GET: Sodanhgias/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sodanhgia = await _context.Sodanhgia.FindAsync(id);
            if (sodanhgia == null)
            {
                return NotFound();
            }
            ViewData["NamhocNhMa"] = new SelectList(_context.Namhoc, "NhMa", "NhMa", sodanhgia.NamhocNhMa);
            return View(sodanhgia);
        }

        // POST: Sodanhgias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SdgMa,SdgDiem,SdgGhichu,NamhocNhMa")] Sodanhgia sodanhgia)
        {
            if (id != sodanhgia.SdgMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sodanhgia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SodanhgiaExists(sodanhgia.SdgMa))
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
            ViewData["NamhocNhMa"] = new SelectList(_context.Namhoc, "NhMa", "NhMa", sodanhgia.NamhocNhMa);
            return View(sodanhgia);
        }

        // GET: Sodanhgias/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sodanhgia = await _context.Sodanhgia
                .Include(s => s.NamhocNhMaNavigation)
                .FirstOrDefaultAsync(m => m.SdgMa == id);
            if (sodanhgia == null)
            {
                return NotFound();
            }

            return View(sodanhgia);
        }

        // POST: Sodanhgias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var sodanhgia = await _context.Sodanhgia.FindAsync(id);
            _context.Sodanhgia.Remove(sodanhgia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SodanhgiaExists(string id)
        {
            return _context.Sodanhgia.Any(e => e.SdgMa == id);
        }
    }
}
