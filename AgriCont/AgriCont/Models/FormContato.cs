using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriCont.Models
{
    
    public class FormContato
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nome Completo(*)")]
        [StringLength(100)]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "E-mail(*)")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Telefone(*)")]
        [StringLength(12)]
        [Required]
        public string Telefone { get; set; }

        [Display(Name = "Por favor, digite uma mensagem(*)")]
        [StringLength(500)]
        [Required]
        public string Message { get; set; }
    }
}
