using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriCont.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome (*)")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string? Nome { get; set; }

        [Display(Name = "E-mail (*)")]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|org|net|gov|br)$", ErrorMessage="Por favor, digite um e-mail válido!")]
        public string? Email { get; set; }

        [Display(Name = "Senha (*)")]
        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [Display(Name = "Código da Empresa (*)")]
        [Required(ErrorMessage = "Obrigatório informar o código da empresa!")]
        public int EmpresaId { get; set; }

        [ForeignKey("EmpresaId")]
        public Empresa? Empresa { get; set; }

        [Display(Name = "Perfil (*)")]
        [Required(ErrorMessage = "Obrigatório Informar o perfil!")]
        public Perfil Perfil { get; set; }
    }

        public enum Perfil
    {
        Admin,
        User
    }
}

