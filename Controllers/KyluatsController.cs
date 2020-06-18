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
    public class KyluatsController : Controller
    {
        private readonly acomptec_qlthptContext _context = new acomptec_qlthptContext();

        public KyluatsController(acomptec_qlthptContext context)
        {
            _context = context;
        }

        // GET: Kyluats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kyluat.ToListAsync());
        }

        // GET: Kyluats/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kyluat = await _context.Kyluat
                .FirstOrDefaultAsync(m => m.KlMa == id);
            if (kyluat == null)
            {
                return NotFound();
            }

            return View(kyluat);
        }

        // GET: Kyluats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kyluats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KlMa,KlHinhthuc,KlNgaykyluat")] Kyluat kyluat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kyluat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kyluat);
        }

        // GET: Kyluats/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kyluat = await _context.Kyluat.FindAsync(id);
            if (kyluat == null)
            {
                return NotFound();
            }
            return View(kyluat);
        }

        // POST: Kyluats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KlMa,KlHinhthuc,KlNgaykyluat")] Kyluat kyluat)
        {
            if (id != kyluat.KlMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kyluat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KyluatExists(kyluat.KlMa))
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
            return View(kyluat);
        }

        // GET: Kyluats/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kyluat = await _context.Kyluat
                .FirstOrDefaultAsync(m => m.KlMa == id);
            if (kyluat == null)
            {
                return NotFound();
            }

            return View(kyluat);
        }

        // POST: Kyluats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var kyluat = await _context.Kyluat.FindAsync(id);
            _context.Kyluat.Remove(kyluat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KyluatExists(string id)
        {
            return _context.Kyluat.Any(e => e.KlMa == id);
        }
    }
}
