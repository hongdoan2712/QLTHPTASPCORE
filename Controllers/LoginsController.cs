using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLTHPT.Models;
using Microsoft.AspNetCore.Http;

namespace QLTHPT.Controllers
{
    public class LoginsController : Controller
    {
       



         private readonly acomptec_qlthptContext _context = new acomptec_qlthptContext();

        // // GET: Logins
         public async Task<IActionResult> Index()
        {
            return View();
        }

        // // GET: Logins/Details/5
        public async Task<IActionResult> Details(string id)
         {
           if (id == null)
            {
                return NotFound();
            }

          var login = await _context.Login
           .FirstOrDefaultAsync(m => m.UserName == id);
            if (login == null)
            {
              return NotFound();
            }

           return View(login);
        }

        // // GET: Logins/Create
        public IActionResult Create()
        {
            return View();
         }

        // // POST: Logins/Create
        // // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Create([Bind("UserName,PassWord")] Login login)
         {
             if (ModelState.IsValid)
             {
                _context.Add(login);
                await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
             }
            return View(login);
         }

        // // GET: Logins/Edit/5
         public async Task<IActionResult> Edit(string id)
         {
            if (id == null)
             {
                return NotFound();
            }

            var login = await _context.Login.FindAsync(id);
            if (login == null)
            {
                return NotFound();
             }
           return View(login);
        }

        // // POST: Logins/Edit/5
        // // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         [HttpPost]
         [ValidateAntiForgeryToken]
         public async Task<IActionResult> Login(string id, [Bind("UserName,PassWord")] Login login)
         {
            if (id == null)
            {
                return NotFound();
            }

            var canbo = await _context.Canbo
                .Include(c => c.CoquanCqMaNavigation)
                .Include(c => c.KhenthuongcbKtcbMaNavigation)
                .Include(c => c.KyluatcbKlcbMaNavigation)
                .FirstOrDefaultAsync(m => m.CbMa == login.UserName && m.MatKhau = login.PassWord);
            if (canbo != null)
            {
                return RedirectToAction("Index", "Homes", new { area = "Admin" });
            }else{
                return RedirectToAction("Index", "Logins", new { area = "Admin" });
            }
         }

        // // POST: Logins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var login = await _context.Login.FindAsync(id);
            _context.Login.Remove(login);
             await _context.SaveChangesAsync();
             return RedirectToAction(nameof(Index));
         }

        private bool LoginExists(string id)
        {
            return _context.Login.Any(e => e.UserName == id);
        }
    }
}
