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
    public class MaquinariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaquinariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Maquinarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Maquinarios.Where(m => m.EmpresaId == int.Parse(User.Claims.ElementAt(1).Value)).ToListAsync());
        }

        // GET: Maquinarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Maquinarios == null)
            {
                return NotFound();
            }

            var maquinario = await _context.Maquinarios
                .Include(m => m.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maquinario == null)
            {
                return NotFound();
            }

            return View(maquinario);
        }

        // GET: Maquinarios/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id");
            return View();
        }

        // POST: Maquinarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NumNotaFiscal,DataEmissao,ValorProduto,DescricaoProduto,Seguradora,NumApolice,ValorSeguro,Tipo,status,DataBaixa,MotivoBaixa,ValorDepreciacao,DataManutencao,DescricaoManutencao,Tamanho,TipoEquipamento,EmpresaId")] Maquinario maquinario)
        {
            var nome = User.Identity.Name;
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Nome == nome);

            if (maquinario.EmpresaId != user.EmpresaId)
            {
                ViewData["MensagemErro"] = $"Por favor, verificar o Id da Empresa e tentar novamente!";
                return View();
            }

            if (ModelState.IsValid)
            {
                _context.Add(maquinario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cnpj", maquinario.EmpresaId);
            return View(maquinario);
        }

        // GET: Maquinarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Maquinarios == null)
            {
                return NotFound();
            }

            var maquinario = await _context.Maquinarios.FindAsync(id);
            if (maquinario == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cnpj", maquinario.EmpresaId);
            return View(maquinario);
        }

        // POST: Maquinarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NumNotaFiscal,DataEmissao,ValorProduto,DescricaoProduto,Seguradora,NumApolice,ValorSeguro,Tipo,status,DataBaixa,MotivoBaixa,ValorDepreciacao,DataManutencao,DescricaoManutencao,Tamanho,TipoEquipamento,EmpresaId")] Maquinario maquinario)
        {
            var nome = User.Identity.Name;
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Nome == nome);

            if (maquinario.EmpresaId != user.EmpresaId)
            {
                ViewData["MensagemErro"] = $"Por favor, verificar Id da Empresa e tentar novamente.";
                return View();
            }
            if (id != maquinario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(maquinario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaquinarioExists(maquinario.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cnpj", maquinario.EmpresaId);
            return View(maquinario);
        }

        // GET: Maquinarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Maquinarios == null)
            {
                return NotFound();
            }

            var maquinario = await _context.Maquinarios
                .Include(m => m.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (maquinario == null)
            {
                return NotFound();
            }

            return View(maquinario);
        }

        // POST: Maquinarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Maquinarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Maquinarios'  is null.");
            }
            var maquinario = await _context.Maquinarios.FindAsync(id);
            if (maquinario != null)
            {
                _context.Maquinarios.Remove(maquinario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MaquinarioExists(int id)
        {
          return _context.Maquinarios.Any(e => e.Id == id);
        }
    }
}
