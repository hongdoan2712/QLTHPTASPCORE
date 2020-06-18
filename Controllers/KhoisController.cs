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
    public class KhoisController : Controller
    {
        private readonly acomptec_qlthptContext _context = new acomptec_qlthptContext();

        public KhoisController(acomptec_qlthptContext context)
        {
            _context = context;
        }

        // GET: Khois
        public async Task<IActionResult> Index()
        {
            return View(await _context.Khoi.ToListAsync());
        }

        // GET: Khois/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoi = await _context.Khoi
                .FirstOrDefaultAsync(m => m.KhoiMa == id);
            if (khoi == null)
            {
                return NotFound();
            }

            return View(khoi);
        }

        // GET: Khois/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Khois/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KhoiMa,KhoiTen")] Khoi khoi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khoi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khoi);
        }

        // GET: Khois/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoi = await _context.Khoi.FindAsync(id);
            if (khoi == null)
            {
                return NotFound();
            }
            return View(khoi);
        }

        // POST: Khois/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KhoiMa,KhoiTen")] Khoi khoi)
        {
            if (id != khoi.KhoiMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khoi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoiExists(khoi.KhoiMa))
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
            return View(khoi);
        }

        // GET: Khois/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoi = await _context.Khoi
                .FirstOrDefaultAsync(m => m.KhoiMa == id);
            if (khoi == null)
            {
                return NotFound();
            }

            return View(khoi);
        }

        // POST: Khois/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var khoi = await _context.Khoi.FindAsync(id);
            _context.Khoi.Remove(khoi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoiExists(string id)
        {
            return _context.Khoi.Any(e => e.KhoiMa == id);
        }
    }
}
