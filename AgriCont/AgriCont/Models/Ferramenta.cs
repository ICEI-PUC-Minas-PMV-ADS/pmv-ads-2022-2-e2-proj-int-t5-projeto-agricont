﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriCont.Models
{
    [Table("Ferramentas")]

    public class Ferramenta
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Número da Nota Fiscal (*)")]
        [Required(ErrorMessage = "Obrigatório o número da nota fiscal!")]
        public int? NumNotaFiscal { get; set; }

        [Display(Name = "Data de Emissão (*)")]
        [Required(ErrorMessage = "Obrigatório informar a Data de emissão!")]
        public DateTime? DataEmissao { get; set; }

        [Display(Name = "Valor do Produto (*)")]
        [Required(ErrorMessage = "Obrigatório informar o valor do produto!")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ValorProduto { get; set; }

        [Required(ErrorMessage = "Obrigatório a Descrição do produto!")]
        [Display(Name = "Descrição do Produto (*)")]
        public string? DescricaoProduto { get; set; }
        
        [Display(Name = "Seguradora")]
        public string? Seguradora { get; set; }

        [Display(Name = "Número da Apólice")]
        public string? NumApolice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Valor do Seguro")]
        public decimal ValorSeguro { get; set; }

        [Display(Name = "Penhorado?")]
        public Penhorado Tipo { get; set; }

        [Display(Name = "Status")]
        public Status1 status { get; set; }

        [Display(Name = "Data da Baixa")]
        public DateTime DataBaixa { get; set; }

        [Display(Name = "Motivo da Baixa")]
        public string? MotivoBaixa { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Valor da Depreciação")]
        public Decimal ValorDepreciacao { get; set; }

        [Display(Name = "Data da Manutenção")]
        public DateTime? DataManutencao { get; set; }

        [Display(Name = "Descrição da Manutenção")]
        public string? DescricaoManutencao { get; set; }

        [Display(Name = "Composição do Material")]
        public string? ComposicaoMaterial { get; set; }

        public string? Marca { get; set; }


        public int EmpresaId { get; set; }
        [ForeignKey("EmpresaId")]

        public Empresa? Empresa { get; set; }


    }


    public enum Penhorado
    {

        Sim,
        Não
    }

    public enum Status1
    {

        Ativo,
        Inativo
    }
}
