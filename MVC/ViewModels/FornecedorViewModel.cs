using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class FornecedorViewModel
    {
        public FornecedorViewModel()
        {
            Enderecos = new List<Endereco>();
        }
        [Key]
        public int FornecedorId { get; set; }

        [Required(ErrorMessage = "Preencha o campo CNPJ.")]
        [MaxLength(14, ErrorMessage = "Máximo de {0} caracteres.")]
        [RegularExpression(@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)", ErrorMessage = "O CNPJ deverá estar no formato 00.000.000/0000-00")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "Preencha o campo Razão Social.")]
        [MaxLength(200, ErrorMessage = "Máximo de 200 caracteres.")]
        public string RazaoSocial { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        [MaxLength(8, ErrorMessage = "Máximo de {0} caracteres.")]
        public string InscricaoMunicipal { get; set; }

        [Required(ErrorMessage = "Preencha o campo Receita Bruta.")]
        //[MaxLength(8, ErrorMessage = "Máximo de 8 caracteres.")]
        [DataType(DataType.Currency)]
        public Decimal ReceitaBruta { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}