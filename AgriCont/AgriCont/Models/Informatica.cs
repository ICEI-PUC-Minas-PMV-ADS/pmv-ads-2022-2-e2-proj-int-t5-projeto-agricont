using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriCont.Models
{
    [Table("Informaticas")]
    public class Informatica
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Número da Nota Fiscal (*)")]
        [Required(ErrorMessage = "Obrigatório informar a nota fiscal!")]
        public int? NumeroNotaFiscal { get; set; }

        [Display(Name = "Descrição (*)")]
        [Required(ErrorMessage = "Obrigatório informar a descrição!")]
        public string? Descricao { get; set; }

        [Display(Name = "Data de Emissão (*)")]
        [Required(ErrorMessage = "Obrigatório informar a data de emissão!")]
        public DateTime? DataEmissao { get; set; }

        [Display(Name = "Valor do Produto (*)")]
        [Required(ErrorMessage = "Obrigatório informar o valor do produto!")]
        public float ValorProduto { get; set; }

        [Display(Name = "Número da Apólice")]
        public string NumeroApolice { get; set; }

        [Display(Name = "Valor do Seguro")]
        public int ValorSeguro { get; set; }

        [Display(Name = "Seguradora")]
        public string NomeSeguradora { get; set; }

        [Display(Name = "Descrição da Manutenção")]
        public string DescricaoManutencao { get; set; }

        [Display(Name = "Data da Manutenção")]
        public string DataManutencao { get; set; }

        [Display(Name = "Valor da depreciação (*)")]
        [Required(ErrorMessage = "Obrigatório informar o valor da depreciação!")]
        public float ValorDepreciacao { get; set; }

        [Display(Name = "Motivo da Baixa")]
        public string MotivoBaixa { get; set; }

        [Display(Name = "Data da Baixa")]
        public DateTime DataBaixa { get; set; }

        [Display(Name = "Manutenção do Software")]
        public DateTime ManutencaoSoftware { get; set; }

        [Display(Name = "Número de Série (*)")]
        [Required(ErrorMessage = "Obrigatório informar o número de série!")]
        public string NumeroSerie { get; set; }

        [Display(Name = "Status")]
        public Status status { get; set; }

        [Display(Name = "Penhorado?")]
        public Penhora penhora { get; set; }

        [ForeignKey("EmpresaId")]
        public Empresa? Empresa { get; set; }

    }

    public enum Status
    {
        Ativo,
        Inativo
    }

    public enum Penhora
    {
        Sim,
        Não
    }
}
