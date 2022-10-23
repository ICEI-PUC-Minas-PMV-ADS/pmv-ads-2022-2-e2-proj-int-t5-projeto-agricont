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
    public class FerramentasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FerramentasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ferramentas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ferramentas.Include(f => f.Empresa);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Ferramentas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ferramentas == null)
            {
                return NotFound();
            }

            var ferramenta = await _context.Ferramentas
                .Include(f => f.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ferramenta == null)
            {
                return NotFound();
            }

            return View(ferramenta);
        }

        // GET: Ferramentas/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id");
            return View();
        }

        // POST: Ferramentas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumNotaFiscal,DataEmissao,ValorProduto,DescricaoProduto,Seguradora,NumApolice,ValorSeguro,Tipo,status,DataBaixa,MotivoBaixa,ValorDepreciacao,DataManutencao,DescricaoManutencao,ComposicaoMaterial,Marca,EmpresaId")] Ferramenta ferramenta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ferramenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cep", ferramenta.EmpresaId);
            return View(ferramenta);
        }

        // GET: Ferramentas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ferramentas == null)
            {
                return NotFound();
            }

            var ferramenta = await _context.Ferramentas.FindAsync(id);
            if (ferramenta == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cep", ferramenta.EmpresaId);
            return View(ferramenta);
        }

        // POST: Ferramentas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumNotaFiscal,DataEmissao,ValorProduto,DescricaoProduto,Seguradora,NumApolice,ValorSeguro,Tipo,status,DataBaixa,MotivoBaixa,ValorDepreciacao,DataManutencao,DescricaoManutencao,ComposicaoMaterial,Marca,EmpresaId")] Ferramenta ferramenta)
        {
            if (id != ferramenta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ferramenta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FerramentaExists(ferramenta.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cep", ferramenta.EmpresaId);
            return View(ferramenta);
        }

        // GET: Ferramentas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ferramentas == null)
            {
                return NotFound();
            }

            var ferramenta = await _context.Ferramentas
                .Include(f => f.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ferramenta == null)
            {
                return NotFound();
            }

            return View(ferramenta);
        }

        // POST: Ferramentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ferramentas == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ferramentas'  is null.");
            }
            var ferramenta = await _context.Ferramentas.FindAsync(id);
            if (ferramenta != null)
            {
                _context.Ferramentas.Remove(ferramenta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FerramentaExists(int id)
        {
          return _context.Ferramentas.Any(e => e.Id == id);
        }
    }
}
