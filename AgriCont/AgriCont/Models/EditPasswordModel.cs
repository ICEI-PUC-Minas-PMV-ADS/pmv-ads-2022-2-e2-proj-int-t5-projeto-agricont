using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriCont.Models
{
    public class EditPasswordModel
    {

        [Display(Name = "E-mail (*)")]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|org|net|gov|br)$", ErrorMessage = "Por favor, digite um e-mail válido!")]
        public string? Email { get; set; }

        [Display(Name = "Código da Empresa (*)")]
        [Required(ErrorMessage = "Obrigatório informar o código da empresa!")]
        public int EmpresaId { get; set; }
    }
    public class EmailSettings
    {
        public String? PrimaryDomain { get; set; }
        public int PrimaryPort { get; set; }
        public String? UsernameEmail { get; set; }
        public String? UsernamePassword { get; set; }
        public String? FromEmail { get; set; }
        public String? ToEmail { get; set; }
    }
}