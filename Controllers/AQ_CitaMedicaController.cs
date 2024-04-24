using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AnahiQuezada_Examen1P.Data;
using AnahiQuezada_Examen1P.Models;

namespace AnahiQuezada_Examen1P.Controllers
{
    public class AQ_CitaMedicaController : Controller
    {
        private readonly AnahiQuezada_Examen1PContext _context;

        public AQ_CitaMedicaController(AnahiQuezada_Examen1PContext context)
        {
            _context = context;
        }

        // GET: AQ_CitaMedica
        public async Task<IActionResult> Index()
        {
            return View(await _context.AQ_CitaMedica.ToListAsync());
        }

        // GET: AQ_CitaMedica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aQ_CitaMedica = await _context.AQ_CitaMedica
                .FirstOrDefaultAsync(m => m.AQ_Id == id);
            if (aQ_CitaMedica == null)
            {
                return NotFound();
            }

            return View(aQ_CitaMedica);
        }

        // GET: AQ_CitaMedica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AQ_CitaMedica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AQ_Id,AQ_Nombre,AQ_Urgente,AQ_Precio,AQ_Fecha")] AQ_CitaMedica aQ_CitaMedica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aQ_CitaMedica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aQ_CitaMedica);
        }

        // GET: AQ_CitaMedica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aQ_CitaMedica = await _context.AQ_CitaMedica.FindAsync(id);
            if (aQ_CitaMedica == null)
            {
                return NotFound();
            }
            return View(aQ_CitaMedica);
        }

        // POST: AQ_CitaMedica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AQ_Id,AQ_Nombre,AQ_Urgente,AQ_Precio,AQ_Fecha")] AQ_CitaMedica aQ_CitaMedica)
        {
            if (id != aQ_CitaMedica.AQ_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aQ_CitaMedica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AQ_CitaMedicaExists(aQ_CitaMedica.AQ_Id))
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
            return View(aQ_CitaMedica);
        }

        // GET: AQ_CitaMedica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aQ_CitaMedica = await _context.AQ_CitaMedica
                .FirstOrDefaultAsync(m => m.AQ_Id == id);
            if (aQ_CitaMedica == null)
            {
                return NotFound();
            }

            return View(aQ_CitaMedica);
        }

        // POST: AQ_CitaMedica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aQ_CitaMedica = await _context.AQ_CitaMedica.FindAsync(id);
            if (aQ_CitaMedica != null)
            {
                _context.AQ_CitaMedica.Remove(aQ_CitaMedica);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AQ_CitaMedicaExists(int id)
        {
            return _context.AQ_CitaMedica.Any(e => e.AQ_Id == id);
        }
    }
}
