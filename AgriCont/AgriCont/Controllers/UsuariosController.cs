using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgriCont.Models;
using BCrypt.Net;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.WebEncoders.Testing;

namespace AgriCont.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha")] Usuario usuario)
        {          
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Email == usuario.Email);

            if (user == null)
            {
                TempData["MensagemErro"] = $"Usuário e/ou Senha inválidos!";
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, user.Senha);

            if (isSenhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim("EmpresaId", user.EmpresaId.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Role, user.Perfil.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return RedirectToAction("Index", "Relatorios");
            }

            TempData["MensagemErro"] = $"Usuário e/ou Senha inválidos!";
            return View();
        } 

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<bool> Email(Usuario usuario)
        {
            try
            {
                string senha = Guid.NewGuid().ToString().Substring(0, 8);
                usuario.GerarNovaSenha(senha);

                MailMessage mail = new MailMessage()
                {
                    From = new MailAddress("agricontweb@gmail.com", "AgriCont")
                };

                mail.To.Add(new MailAddress(usuario.Email));

                mail.Subject = "Alteração de senha - Agricont";

                mail.Body = "Sua nova senha é " + senha + ".";
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                _context.Update(usuario);
                await _context.SaveChangesAsync();


                //outras opções
                //mail.Attachments.Add(new Attachment(arquivo));
                //

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential("agricontwebb@gmail.com", "ggcwxwokkfbkjlbq");
                    smtp.EnableSsl = true;
                    smtp.Timeout = 20_000;
                    await smtp.SendMailAsync(mail);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public IActionResult EditPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditPassword([Bind("Email,EmpresaId")] Usuario usuario)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(usuario.Email) && (usuario.EmpresaId > 0))
                {
                    var user = await _context.Usuarios.Include(u => u.Empresa).FirstOrDefaultAsync(m => m.Email.ToUpper() == usuario.Email.ToUpper() && m.EmpresaId == usuario.EmpresaId);

                    

                    if (user != null)
                    {
                        await Email(user);
                        //if (await Email(user))
                        //{
                        TempData["MensagemSucesso"] = $"Enviamos uma nova senha no email cadastrado, clique em 'voltar' para ir a tela de login.";
                        }
                        else
                        {
                            TempData["MensagemErro"] = $"Não foi possível redefinir senha. Favor checkar os dados informados.";
                        }
                    //}
                }
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível redefinir senha. Favor tentar novamente.";

            }
            return View();
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            if(User.IsInRole("Admin"))
            {
                return View(await _context.Usuarios.Where(u => u.EmpresaId == int.Parse(User.Claims.ElementAt(1).Value)).ToListAsync());
            }else
            return View(await _context.Usuarios.Where(u => u.Id == int.Parse(User.Claims.ElementAt(2).Value)).ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cnpj");
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Senha,EmpresaId,Perfil")] Usuario usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Login));
                }
                ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cnpj", usuario.EmpresaId);
                return View(usuario);
            }
            catch
            {
                TempData["MensagemErro"] = $"Ocorreu um erro inesperado. Por favor, verifique os dados.";
                return View();
            }
        }


        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cnpj", usuario.EmpresaId);
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Senha,EmpresaId,Perfil")] Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Cnpj", usuario.EmpresaId);
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .Include(u => u.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Usuarios'  is null.");
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
          return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
