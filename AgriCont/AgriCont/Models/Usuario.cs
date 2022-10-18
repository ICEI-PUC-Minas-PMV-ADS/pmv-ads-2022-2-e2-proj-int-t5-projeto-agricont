using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriCont.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string? Nome { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Obrigatório informar o email!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha!")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [Display(Name = "Código da Empresa")]
        [Required(ErrorMessage = "Obrigatório informar o código da empresa!")]
        [ForeignKey("EmpresaId")]
        public Empresa? Empresa { get; set; }
    }
}

