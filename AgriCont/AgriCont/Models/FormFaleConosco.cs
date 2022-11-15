using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AgriCont.Models
{
    [Keyless]
    public class FormFaleConosco
    {
        [Required(ErrorMessage = "Obrigatório informar o nome completo!"), Display(Name = "Nome Completo(*)")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email!"), Display(Name = "E-mail(*)"), EmailAddress]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|org|net|gov|br)$", ErrorMessage = "Por favor, digite um e-mail válido!")]
        public string Email { get; set; }

        [Display(Name = "Telefone (*)")]
        [RegularExpression(@"\d{2}\-\d{4}-\d{4}", ErrorMessage = "Por favor, digite um Telefone válido!")]
        [Required(ErrorMessage = "Obrigatório informar o Telefone!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório escrever uma mensagem!"), Display(Name = "Mensagem(*)")]
        public string Mensagem { get; set; }
    }
}
