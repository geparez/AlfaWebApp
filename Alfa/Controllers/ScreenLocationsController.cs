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
    public class ScreenLocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScreenLocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ScreenLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.ScreenLocation.ToListAsync());
        }

        // GET: ScreenLocations/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScreenLocation screenLocation = await _context.ScreenLocation
                .FirstOrDefaultAsync(m => m.SerialNumber == id);
            if (screenLocation == null)
            {
                return NotFound();
            }

            ScreenLocationView viewModel = new ScreenLocationView();
            viewModel.ScreenLocation = screenLocation;
            List<ScreenType> screentypes = await _context.ScreenType
                .WHERE 

            return View(viewModel);
        }

        // GET: ScreenLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ScreenLocations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SerialNumber")] ScreenLocation screenLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(screenLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(screenLocation);
        }

        // GET: ScreenLocations/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenLocation = await _context.ScreenLocation.FindAsync(id);
            if (screenLocation == null)
            {
                return NotFound();
            }
            return View(screenLocation);
        }

        // POST: ScreenLocations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("SerialNumber")] ScreenLocation screenLocation)
        {
            if (id != screenLocation.SerialNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(screenLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScreenLocationExists(screenLocation.SerialNumber))
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
            return View(screenLocation);
        }

        // GET: ScreenLocations/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var screenLocation = await _context.ScreenLocation
                .FirstOrDefaultAsync(m => m.SerialNumber == id);
            if (screenLocation == null)
            {
                return NotFound();
            }

            return View(screenLocation);
        }

        // POST: ScreenLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var screenLocation = await _context.ScreenLocation.FindAsync(id);
            _context.ScreenLocation.Remove(screenLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScreenLocationExists(string id)
        {
            return _context.ScreenLocation.Any(e => e.SerialNumber == id);
        }
    }
}
