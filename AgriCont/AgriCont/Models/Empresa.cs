using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriCont.Models
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Razão Social (*)")]
        [Required(ErrorMessage = "Obrigatório informar a Razão Social!")]
        public string? RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia (*)")]
        [Required(ErrorMessage = "Obrigatório informar o Nome Fantasia!")]
        public string? NomeFantasia { get; set; }

        [Display(Name = "CNPJ (*)")]
        [RegularExpression(@"\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}", ErrorMessage = "Por favor, digite um CNPJ válido!")]
        [Required(ErrorMessage = "Obrigatório informar o CNPJ!")]
        public string? Cnpj { get; set; }

        [Display(Name = "Logradouro (*)")]
        [Required(ErrorMessage = "Obrigatório informar o Logradouro!")]
        public string? Logradouro { get; set; }

        [Display(Name = "Número (*)")]
        [Required(ErrorMessage = "Obrigatório informar o Número!")]
        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        [Display(Name = "CEP(*)")]
        [RegularExpression(@"\d{5}\-\d{3}", ErrorMessage = "Por favor, digite um CEP válido!")]
        [Required(ErrorMessage = "Obrigatório informar o CEP!")]
        public string? Cep { get; set; }

        [Display(Name = "Telefone (*)")]
        [RegularExpression(@"\d{2}\-\d{4}-\d{4}", ErrorMessage = "Por favor, digite um Telefone válido!")]
        [Required(ErrorMessage = "Obrigatório informar o Telefone!")]
        public string? Telefone { get; set; }

        [Display(Name = "E-mail (*)")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|org|net|gov|br)$", ErrorMessage = "Por favor, digite um e-mail válido!")]
        [Required(ErrorMessage = "Obrigatório informar o Email!")]
        public string? Email { get; set; }

        public ICollection<Ferramenta>? Ferramentas { get; set; }
        public ICollection<Informatica>? Informaticas { get; set; }
        public ICollection<Maquinario>? Maquinarios { get; set; }
        public ICollection<Veiculo>? Veiculos { get; set; }
    }
}