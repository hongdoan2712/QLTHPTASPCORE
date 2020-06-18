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
    public class KhenthuongsController : Controller
    {
        private readonly acomptec_qlthptContext _context = new acomptec_qlthptContext();

        public KhenthuongsController(acomptec_qlthptContext context)
        {
            _context = context;
        }

        // GET: Khenthuongs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Khenthuong.ToListAsync());
        }

        // GET: Khenthuongs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khenthuong = await _context.Khenthuong
                .FirstOrDefaultAsync(m => m.KtMa == id);
            if (khenthuong == null)
            {
                return NotFound();
            }

            return View(khenthuong);
        }

        // GET: Khenthuongs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Khenthuongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KtMa,KtThanhtich,KtNgaykhenthuong,KtGhichu")] Khenthuong khenthuong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khenthuong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khenthuong);
        }

        // GET: Khenthuongs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khenthuong = await _context.Khenthuong.FindAsync(id);
            if (khenthuong == null)
            {
                return NotFound();
            }
            return View(khenthuong);
        }

        // POST: Khenthuongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("KtMa,KtThanhtich,KtNgaykhenthuong,KtGhichu")] Khenthuong khenthuong)
        {
            if (id != khenthuong.KtMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khenthuong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhenthuongExists(khenthuong.KtMa))
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
            return View(khenthuong);
        }

        // GET: Khenthuongs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khenthuong = await _context.Khenthuong
                .FirstOrDefaultAsync(m => m.KtMa == id);
            if (khenthuong == null)
            {
                return NotFound();
            }

            return View(khenthuong);
        }

        // POST: Khenthuongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var khenthuong = await _context.Khenthuong.FindAsync(id);
            _context.Khenthuong.Remove(khenthuong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhenthuongExists(string id)
        {
            return _context.Khenthuong.Any(e => e.KtMa == id);
        }
    }
}
