using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;

namespace MVC.ViewModels
{
    public class ProcessoViewModel
    {
        [Key]
        public int ProcessoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Fornecedor.")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres.")]
        public string Fornecedor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Relato.")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres.")]
        [DataType(DataType.MultilineText)]
        public StringBuilder RelatoFiscalizacao { get; set; }

        [Required(ErrorMessage = "Preencha o campo Fiscal.")]
        [MaxLength(100, ErrorMessage = "Máximo de {0} caracteres.")]
        public string DataRelato { get; set; }

        [ScaffoldColumn(false)]
        public string FiscalResponsavel { get; set; }
        
    }
}