﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome.")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Marca.")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres.")]
        public string Marca { get; set; }

        [Range(typeof(int), "0", "999999999")]
        [Required(ErrorMessage = "Preencha um Valor para o Produto.")]
        public int Estoque { get; set; }

    }
}