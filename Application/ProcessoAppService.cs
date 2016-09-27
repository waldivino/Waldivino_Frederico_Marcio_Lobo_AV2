using Application.Interface;
using Domain.Entities;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Application
{
    public class ProcessoAppService : AppServiceBase<Processo>, IProcessoAppService
    {
        private readonly IProcessoService _processoService;

        public ProcessoAppService(IProcessoService ProcessoService) : base(ProcessoService)
        {
            _processoService = ProcessoService;
        }

        public IEnumerable<Processo> BuscarPorId(int ProcessoId)
        {
            return _processoService.BuscarPorId(ProcessoId);
        }
    }
}
