using Application.Interface;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService ProdutoService) : base(ProdutoService)
        {
            _produtoService = ProdutoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
