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
    public class RelatoriosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RelatoriosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Relatorios
        public async Task<IActionResult> Index()
        {
            string name = "";
            if (User.Identity.IsAuthenticated)
                name = User.Identity.Name;

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Nome == name);

            var empresa = await _context.Empresas
                             .Include(p => p.Informaticas)
                             .Include(p => p.Ferramentas)
                             .Include(p => p.Maquinarios)
                             .Include(p => p.Veiculos)
                             .FirstOrDefaultAsync(m => m.Id == usuario.EmpresaId);

            ViewData["empresa"] = empresa;
            return View();
        }

        // GET: Relatorios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Empresas == null)
            {
                return NotFound();
            }

            var empresa = await _context.Empresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return View(empresa);
        }

    }
}


