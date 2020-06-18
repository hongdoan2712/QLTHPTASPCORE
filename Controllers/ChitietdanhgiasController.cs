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
    public class ChitietdanhgiasController : Controller
    {
        private readonly acomptec_qlthptContext _context = new acomptec_qlthptContext();

        public ChitietdanhgiasController(acomptec_qlthptContext context)
        {
            _context = context;
        }

        // GET: Chitietdanhgias
        public async Task<IActionResult> Index()
        {
            var acomptec_qlthptContext = _context.Chitietdanhgia.Include(c => c.HocsinhHsMaNavigation).Include(c => c.SodanhgiaSdgMaNavigation);
            return View(await acomptec_qlthptContext.ToListAsync());
        }

        // GET: Chitietdanhgias/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietdanhgia = await _context.Chitietdanhgia
                .Include(c => c.HocsinhHsMaNavigation)
                .Include(c => c.SodanhgiaSdgMaNavigation)
                .FirstOrDefaultAsync(m => m.CtdgMa == id);
            if (chitietdanhgia == null)
            {
                return NotFound();
            }

            return View(chitietdanhgia);
        }

        // GET: Chitietdanhgias/Create
        public IActionResult Create()
        {
            ViewData["HocsinhHsMa"] = new SelectList(_context.Hocsinh, "HsMa", "HsMa");
            ViewData["SodanhgiaSdgMa"] = new SelectList(_context.Sodanhgia, "SdgMa", "SdgMa");
            return View();
        }

        // POST: Chitietdanhgias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CtdgMa,CtdgNgaydg,SodanhgiaSdgMa,HocsinhHsMa")] Chitietdanhgia chitietdanhgia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitietdanhgia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HocsinhHsMa"] = new SelectList(_context.Hocsinh, "HsMa", "HsMa", chitietdanhgia.HocsinhHsMa);
            ViewData["SodanhgiaSdgMa"] = new SelectList(_context.Sodanhgia, "SdgMa", "SdgMa", chitietdanhgia.SodanhgiaSdgMa);
            return View(chitietdanhgia);
        }

        // GET: Chitietdanhgias/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietdanhgia = await _context.Chitietdanhgia.FindAsync(id);
            if (chitietdanhgia == null)
            {
                return NotFound();
            }
            ViewData["HocsinhHsMa"] = new SelectList(_context.Hocsinh, "HsMa", "HsMa", chitietdanhgia.HocsinhHsMa);
            ViewData["SodanhgiaSdgMa"] = new SelectList(_context.Sodanhgia, "SdgMa", "SdgMa", chitietdanhgia.SodanhgiaSdgMa);
            return View(chitietdanhgia);
        }

        // POST: Chitietdanhgias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CtdgMa,CtdgNgaydg,SodanhgiaSdgMa,HocsinhHsMa")] Chitietdanhgia chitietdanhgia)
        {
            if (id != chitietdanhgia.CtdgMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitietdanhgia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitietdanhgiaExists(chitietdanhgia.CtdgMa))
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
            ViewData["HocsinhHsMa"] = new SelectList(_context.Hocsinh, "HsMa", "HsMa", chitietdanhgia.HocsinhHsMa);
            ViewData["SodanhgiaSdgMa"] = new SelectList(_context.Sodanhgia, "SdgMa", "SdgMa", chitietdanhgia.SodanhgiaSdgMa);
            return View(chitietdanhgia);
        }

        // GET: Chitietdanhgias/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietdanhgia = await _context.Chitietdanhgia
                .Include(c => c.HocsinhHsMaNavigation)
                .Include(c => c.SodanhgiaSdgMaNavigation)
                .FirstOrDefaultAsync(m => m.CtdgMa == id);
            if (chitietdanhgia == null)
            {
                return NotFound();
            }

            return View(chitietdanhgia);
        }

        // POST: Chitietdanhgias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var chitietdanhgia = await _context.Chitietdanhgia.FindAsync(id);
            _context.Chitietdanhgia.Remove(chitietdanhgia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitietdanhgiaExists(string id)
        {
            return _context.Chitietdanhgia.Any(e => e.CtdgMa == id);
        }
    }
}
