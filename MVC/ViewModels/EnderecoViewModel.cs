using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Preencha o campo Número.")]
        [MaxLength(50, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Numero { get; set; }
              
        [MaxLength(50, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Preencha o campo Bairro.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Preencha o campo CEP.")]
        [MaxLength(9, ErrorMessage = "Máximo de {0} caracteres.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "O CEP deverá estar no formato 00000-000")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Preencha o campo Minicípio.")]
        [MaxLength(200, ErrorMessage = "Máximo de {0} caracteres.")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Preencha o campo UF.")]
        public string UnidadeFederativa { get; set; }

    }
}