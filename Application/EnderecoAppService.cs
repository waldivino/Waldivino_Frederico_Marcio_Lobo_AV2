using Application.Interface;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService EnderecoService) : base(EnderecoService)
        {
            _enderecoService = EnderecoService;
        }

        public IEnumerable<Endereco> BuscarPorNome(string nome)
        {
            return _enderecoService.BuscarPorNome(nome);
        }
    }
}
