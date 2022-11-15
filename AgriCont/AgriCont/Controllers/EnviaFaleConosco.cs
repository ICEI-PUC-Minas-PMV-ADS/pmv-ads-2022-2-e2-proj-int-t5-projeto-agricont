using AgriCont.Models;
using AgriCont.Services;
using Microsoft.AspNetCore.Mvc;

namespace AgriCont.Controllers
{
    public class EnviaFaleConosco : Controller
    {
        private readonly IEmail _email;

        public EnviaFaleConosco(IEmail email)
        {
            _email = email;
        }

        public IActionResult FaleConosco()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FaleConosco(string nome, string email, string mensagem, string telefone)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    bool v = _email.EnviarEmail(email, nome, mensagem, telefone);

                    if (v)
                    {
                       
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Envio falhou. Por favor, tente novamente.";
                    }
                   
                }

                return RedirectToAction("FaleConosco");

            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = "Envio falhou!";
                return View("FaleConosco");
            }

        }
        public void EnviarEmail(Email username, string v, FormFaleConosco mensagem)
        {
            throw new NotImplementedException();
        }

        public bool EnviarEmail(string nome, string email, string mensagem, string telefone)
        {
            throw new NotImplementedException();
        }
    }
}
