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
    public class HocsinhsController : Controller
    {
        private readonly acomptec_qlthptContext _context = new acomptec_qlthptContext();


        // GET: Hocsinhs
        public async Task<IActionResult> Index()
        {
            var acomptec_qlthptContext = _context.Hocsinh.Include(h => h.DantocDtMaNavigation).Include(h => h.KhenthuongKtMaNavigation).Include(h => h.KhoiKhoiMaNavigation).Include(h => h.KyluatKlMaNavigation).Include(h => h.LopLopMaNavigation).Include(h => h.QuanhuyenQhMaNavigation).Include(h => h.TinhthanhTtMaNavigation).Include(h => h.XaphuongXpMaNavigation);
            return View(await acomptec_qlthptContext.ToListAsync());
        }

        // GET: Hocsinhs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocsinh = await _context.Hocsinh
                .Include(h => h.DantocDtMaNavigation)
                .Include(h => h.KhenthuongKtMaNavigation)
                .Include(h => h.KhoiKhoiMaNavigation)
                .Include(h => h.KyluatKlMaNavigation)
                .Include(h => h.LopLopMaNavigation)
                .Include(h => h.QuanhuyenQhMaNavigation)
                .Include(h => h.TinhthanhTtMaNavigation)
                .Include(h => h.XaphuongXpMaNavigation)
                .FirstOrDefaultAsync(m => m.HsMa == id);
            if (hocsinh == null)
            {
                return NotFound();
            }

            return View(hocsinh);
        }

        // GET: Hocsinhs/Create
        public IActionResult Create()
        {
            ViewData["DantocDtMa"] = new SelectList(_context.Dantoc, "DtMa", "DtMa");
            ViewData["KhenthuongKtMa"] = new SelectList(_context.Khenthuong, "KtMa", "KtMa");
            ViewData["KhoiKhoiMa"] = new SelectList(_context.Khoi, "KhoiMa", "KhoiMa");
            ViewData["KyluatKlMa"] = new SelectList(_context.Kyluat, "KlMa", "KlMa");
            ViewData["LopLopMa"] = new SelectList(_context.Lop, "LopMa", "LopMa");
            ViewData["QuanhuyenQhMa"] = new SelectList(_context.Quanhuyen, "QhMa", "QhMa");
            ViewData["TinhthanhTtMa"] = new SelectList(_context.Tinhthanh, "TtMa", "TtMa");
            ViewData["XaphuongXpMa"] = new SelectList(_context.Xaphuong, "XpMa", "XpMa");
            return View();
        }

        // POST: Hocsinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HsMa,HsHoten,HsGioitinh,HsNgaysinh,HsTongiao,TinhthanhTtMa,XaphuongXpMa,KyluatKlMa,KhenthuongKtMa,QuanhuyenQhMa,DantocDtMa,LopLopMa,KhoiKhoiMa")] Hocsinh hocsinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hocsinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DantocDtMa"] = new SelectList(_context.Dantoc, "DtMa", "DtMa", hocsinh.DantocDtMa);
            ViewData["KhenthuongKtMa"] = new SelectList(_context.Khenthuong, "KtMa", "KtMa", hocsinh.KhenthuongKtMa);
            ViewData["KhoiKhoiMa"] = new SelectList(_context.Khoi, "KhoiMa", "KhoiMa", hocsinh.KhoiKhoiMa);
            ViewData["KyluatKlMa"] = new SelectList(_context.Kyluat, "KlMa", "KlMa", hocsinh.KyluatKlMa);
            ViewData["LopLopMa"] = new SelectList(_context.Lop, "LopMa", "LopMa", hocsinh.LopLopMa);
            ViewData["QuanhuyenQhMa"] = new SelectList(_context.Quanhuyen, "QhMa", "QhMa", hocsinh.QuanhuyenQhMa);
            ViewData["TinhthanhTtMa"] = new SelectList(_context.Tinhthanh, "TtMa", "TtMa", hocsinh.TinhthanhTtMa);
            ViewData["XaphuongXpMa"] = new SelectList(_context.Xaphuong, "XpMa", "XpMa", hocsinh.XaphuongXpMa);
            return View(hocsinh);
        }

        // GET: Hocsinhs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocsinh = await _context.Hocsinh.FindAsync(id);
            if (hocsinh == null)
            {
                return NotFound();
            }
            ViewData["DantocDtMa"] = new SelectList(_context.Dantoc, "DtMa", "DtMa", hocsinh.DantocDtMa);
            ViewData["KhenthuongKtMa"] = new SelectList(_context.Khenthuong, "KtMa", "KtMa", hocsinh.KhenthuongKtMa);
            ViewData["KhoiKhoiMa"] = new SelectList(_context.Khoi, "KhoiMa", "KhoiMa", hocsinh.KhoiKhoiMa);
            ViewData["KyluatKlMa"] = new SelectList(_context.Kyluat, "KlMa", "KlMa", hocsinh.KyluatKlMa);
            ViewData["LopLopMa"] = new SelectList(_context.Lop, "LopMa", "LopMa", hocsinh.LopLopMa);
            ViewData["QuanhuyenQhMa"] = new SelectList(_context.Quanhuyen, "QhMa", "QhMa", hocsinh.QuanhuyenQhMa);
            ViewData["TinhthanhTtMa"] = new SelectList(_context.Tinhthanh, "TtMa", "TtMa", hocsinh.TinhthanhTtMa);
            ViewData["XaphuongXpMa"] = new SelectList(_context.Xaphuong, "XpMa", "XpMa", hocsinh.XaphuongXpMa);
            return View(hocsinh);
        }

        // POST: Hocsinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HsMa,HsHoten,HsGioitinh,HsNgaysinh,HsTongiao,TinhthanhTtMa,XaphuongXpMa,KyluatKlMa,KhenthuongKtMa,QuanhuyenQhMa,DantocDtMa,LopLopMa,KhoiKhoiMa")] Hocsinh hocsinh)
        {
            if (id != hocsinh.HsMa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hocsinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HocsinhExists(hocsinh.HsMa))
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
            ViewData["DantocDtMa"] = new SelectList(_context.Dantoc, "DtMa", "DtMa", hocsinh.DantocDtMa);
            ViewData["KhenthuongKtMa"] = new SelectList(_context.Khenthuong, "KtMa", "KtMa", hocsinh.KhenthuongKtMa);
            ViewData["KhoiKhoiMa"] = new SelectList(_context.Khoi, "KhoiMa", "KhoiMa", hocsinh.KhoiKhoiMa);
            ViewData["KyluatKlMa"] = new SelectList(_context.Kyluat, "KlMa", "KlMa", hocsinh.KyluatKlMa);
            ViewData["LopLopMa"] = new SelectList(_context.Lop, "LopMa", "LopMa", hocsinh.LopLopMa);
            ViewData["QuanhuyenQhMa"] = new SelectList(_context.Quanhuyen, "QhMa", "QhMa", hocsinh.QuanhuyenQhMa);
            ViewData["TinhthanhTtMa"] = new SelectList(_context.Tinhthanh, "TtMa", "TtMa", hocsinh.TinhthanhTtMa);
            ViewData["XaphuongXpMa"] = new SelectList(_context.Xaphuong, "XpMa", "XpMa", hocsinh.XaphuongXpMa);
            return View(hocsinh);
        }

        // GET: Hocsinhs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocsinh = await _context.Hocsinh
                .Include(h => h.DantocDtMaNavigation)
                .Include(h => h.KhenthuongKtMaNavigation)
                .Include(h => h.KhoiKhoiMaNavigation)
                .Include(h => h.KyluatKlMaNavigation)
                .Include(h => h.LopLopMaNavigation)
                .Include(h => h.QuanhuyenQhMaNavigation)
                .Include(h => h.TinhthanhTtMaNavigation)
                .Include(h => h.XaphuongXpMaNavigation)
                .FirstOrDefaultAsync(m => m.HsMa == id);
            if (hocsinh == null)
            {
                return NotFound();
            }

            return View(hocsinh);
        }

        // POST: Hocsinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hocsinh = await _context.Hocsinh.FindAsync(id);
            _context.Hocsinh.Remove(hocsinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HocsinhExists(string id)
        {
            return _context.Hocsinh.Any(e => e.HsMa == id);
        }
    }
}
