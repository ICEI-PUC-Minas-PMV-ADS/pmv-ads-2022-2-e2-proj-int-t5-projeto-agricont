using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriCont.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "Obrigatório informar a Razão Social!")]
        public string? RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        [Required(ErrorMessage = "Obrigatório informar o Nome Fantasia!")]
        public string? NomeFantasia { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "Obrigatório informar o CNPJ!")]
        public string? Cnpj { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Logradouro!")]
        public string? Logradouro { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessage = "Obrigatório informar o Número!")]
        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Obrigatório informar o CEP!")]
        public string? Cep { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Telefone!")]
        public string? Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Obrigatório informar o Email!")]
        public string? Email { get; set; }
    }
}