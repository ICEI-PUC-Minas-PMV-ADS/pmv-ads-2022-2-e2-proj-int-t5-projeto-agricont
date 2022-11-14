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
    public class InformaticasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InformaticasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Informaticas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Informaticas.Include(i => i.Empresa);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Informaticas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Informaticas == null)
            {
                return NotFound();
            }

            var informatica = await _context.Informaticas
                .Include(i => i.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (informatica == null)
            {
                return NotFound();
            }

            return View(informatica);
        }

        // GET: Informaticas/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cep");
            return View();
        }

        // POST: Informaticas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumNotaFiscal,DataEmissao,ValorProduto,DescricaoProduto,Seguradora,NumApolice,ValorSeguro,Tipo,status,DataBaixa,MotivoBaixa,ValorDepreciacao,DataManutencao,DescricaoManutencao,ManutencaoSoftware,NumeroSerie,EmpresaId")] Informatica informatica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(informatica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cep", informatica.EmpresaId);
            return View(informatica);
        }

        // GET: Informaticas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Informaticas == null)
            {
                return NotFound();
            }

            var informatica = await _context.Informaticas.FindAsync(id);
            if (informatica == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cep", informatica.EmpresaId);
            return View(informatica);
        }

        // POST: Informaticas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumNotaFiscal,DataEmissao,ValorProduto,DescricaoProduto,Seguradora,NumApolice,ValorSeguro,Tipo,status,DataBaixa,MotivoBaixa,ValorDepreciacao,DataManutencao,DescricaoManutencao,ManutencaoSoftware,NumeroSerie,EmpresaId")] Informatica informatica)
        {
            if (id != informatica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(informatica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InformaticaExists(informatica.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cep", informatica.EmpresaId);
            return View(informatica);
        }

        // GET: Informaticas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Informaticas == null)
            {
                return NotFound();
            }

            var informatica = await _context.Informaticas
                .Include(i => i.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (informatica == null)
            {
                return NotFound();
            }

            return View(informatica);
        }

        // POST: Informaticas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Informaticas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Informaticas'  is null.");
            }
            var informatica = await _context.Informaticas.FindAsync(id);
            if (informatica != null)
            {
                _context.Informaticas.Remove(informatica);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InformaticaExists(int id)
        {
          return _context.Informaticas.Any(e => e.Id == id);
        }
    }
}
