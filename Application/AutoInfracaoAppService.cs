using Application.Interface;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application
{
    public class AutoInfracaoAppService : AppServiceBase<AutoInfracao>, IAutoInfracaoAppService
    {
        private readonly IAutoInfracaoService _autoInfracaoService;

        public AutoInfracaoAppService(IAutoInfracaoService AutoInfracaoService) : base(AutoInfracaoService)
        {
            _autoInfracaoService = AutoInfracaoService;
        }

        public IEnumerable<AutoInfracao> BuscarPorId(int AutoInfracaoId)
        {
            return _autoInfracaoService.BuscarPorId(AutoInfracaoId);
        }
    }
}
