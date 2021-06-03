using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Alfa.Data;
using Alfa.Models;

namespace Alfa.Controllers
{
    public class ScreenTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScreenTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ScreenTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Screen.ToListAsync());
        }

        // GET: ScreenTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenType = await _context.Screen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (screenType == null)
            {
                return NotFound();
            }

            return View(screenType);
        }

        // GET: ScreenTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScreenTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Model")] ScreenType screenType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screenType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screenType);
        }

        // GET: ScreenTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenType = await _context.Screen.FindAsync(id);
            if (screenType == null)
            {
                return NotFound();
            }
            return View(screenType);
        }

        // POST: ScreenTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Model")] ScreenType screenType)
        {
            if (id != screenType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(screenType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScreenTypeExists(screenType.Id))
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
            return View(screenType);
        }

        // GET: ScreenTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenType = await _context.Screen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (screenType == null)
            {
                return NotFound();
            }

            return View(screenType);
        }

        // POST: ScreenTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var screenType = await _context.Screen.FindAsync(id);
            _context.Screen.Remove(screenType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScreenTypeExists(int id)
        {
            return _context.Screen.Any(e => e.Id == id);
        }
    }
}
