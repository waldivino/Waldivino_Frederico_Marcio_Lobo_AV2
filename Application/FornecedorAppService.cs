using Application.Interface;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application
{
    public class FornecedorAppService : AppServiceBase<Fornecedor>, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IFornecedorService FornecedorService) : base(FornecedorService)
        {
            _fornecedorService = FornecedorService;
        }

        public IEnumerable<Fornecedor> BuscarPorNome(string nome)
        {
            return _fornecedorService.BuscarPorNome(nome);
        }
    }
}
