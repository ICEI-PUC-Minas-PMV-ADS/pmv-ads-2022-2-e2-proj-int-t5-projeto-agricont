using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AgriCont.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Número da Nota Fiscal (*)")]
        [Required(ErrorMessage = "Obrigatório o número da nota fiscal!")]
        public int NumNotaFiscal { get; set; }

        [Display(Name = "Data de Emissão (*)")]
        [Required(ErrorMessage = "Obrigatório informar a Data de emissão!")]
        public DateTime DataEmissao { get; set; }

        [Display(Name = "Valor do Veiculo (*)")]
        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorProduto { get; set; }

        [Required(ErrorMessage = "Obrigatório a Descrição do veículo!")]
        [Display(Name = "Descrição do Veículo (*)")]
        public string DescricaoProduto { get; set; }

        [Display(Name ="Ano do Veículo (*)")]
        [Required(ErrorMessage ="Obrigatório informar o ano do veículo!")]
        public int AnoVeiculo { get; set; }

        [Display(Name = "Chassi (*)")]
        [Required(ErrorMessage = "Obrigatório informar o Chassi!")]
        public string NumeroChassi { get; set; }

        [Display(Name = "Seguradora")]
        public string? NomeSeguradora { get; set; }

        [Display(Name = "Número da Apólice")]
        public string? NumeroApolice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Valor do Seguro")]
        public decimal? ValorSeguro { get; set; }

        [Display(Name = "Penhorado?")]
        public Penhorado1 Tipo { get; set; }

        [Display(Name = "Status")]
        public Status2 status { get; set; }

        [Display(Name = "Data da Baixa")]
        public DateTime? DataBaixa { get; set; }

        [Display(Name = "Motivo da Baixa")]
        public string? MotivoBaixa { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Valor da Depreciação")]
        public Decimal? ValorDepreciacao { get; set; }

        [Display(Name = "Data da Manutenção")]
        public DateTime? DataManutencao { get; set; }

        [Display(Name = "Descrição da Manutenção")]
        public string? DescricaoManutencao { get; set; }

        [Display(Name = "Código da Empresa")]
        public int EmpresaId { get; set; }

        [ForeignKey("EmpresaId")]
        public Empresa? Empresa { get; set; }
    }
}
