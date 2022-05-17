using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD_Caminhoes.Models;

namespace CRUD_Caminhoes.Controllers
{
    public class TrucksController : Controller
    {
        private readonly TrucksContext _context;

        public TrucksController(TrucksContext context)
        {
            _context = context;
        }

        // GET: Trucks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trucks.ToListAsync());
        }

        

        // GET: Trucks/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Trucks());
            else
                return
                    View(_context.Trucks.Find(id));
        }

        // POST: Trucks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("truckId,truckName,truckDescription,truckCreationDate")] Trucks trucks)
        {
            if (ModelState.IsValid)
            {
                if (trucks.truckId == 0)
                    _context.Add(trucks);
                else
                    _context.Update(trucks);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trucks);
        }

        // GET: Trucks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trucks = await _context.Trucks.FindAsync(id);
            if (trucks == null)
            {
                return NotFound();
            }
            return View(trucks);
        }


        // GET: Trucks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var trucks = await _context.Trucks.FindAsync(id);
            _context.Trucks.Remove(trucks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
