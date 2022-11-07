using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgriCont.Models;

namespace AgriCont.Controllers
{
    public class FormContatosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormContatosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FormContatos
        public async Task<IActionResult> Index()
        {
              return View(await _context.FormContato.ToListAsync());
        }

        // GET: FormContatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FormContato == null)
            {
                return NotFound();
            }

            var formContato = await _context.FormContato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formContato == null)
            {
                return NotFound();
            }

            return View(formContato);
        }

        // GET: FormContatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormContatos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,email,Telefone,Message")] FormContato formContato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formContato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formContato);
        }

        // GET: FormContatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FormContato == null)
            {
                return NotFound();
            }

            var formContato = await _context.FormContato.FindAsync(id);
            if (formContato == null)
            {
                return NotFound();
            }
            return View(formContato);
        }

        // POST: FormContatos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,email,Telefone,Message")] FormContato formContato)
        {
            if (id != formContato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formContato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormContatoExists(formContato.Id))
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
            return View(formContato);
        }

        // GET: FormContatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FormContato == null)
            {
                return NotFound();
            }

            var formContato = await _context.FormContato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formContato == null)
            {
                return NotFound();
            }

            return View(formContato);
        }

        // POST: FormContatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FormContato == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FormContato'  is null.");
            }
            var formContato = await _context.FormContato.FindAsync(id);
            if (formContato != null)
            {
                _context.FormContato.Remove(formContato);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormContatoExists(int id)
        {
          return _context.FormContato.Any(e => e.Id == id);
        }
    }
}
