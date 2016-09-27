using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Domain.Services
{
    public class ProcessoService : ServiceBase<Processo>, IProcessoService
    {
        private readonly IProcessoRepository _processoRepository;

        public ProcessoService(IProcessoRepository processoRepository) : base(processoRepository)
        {
            _processoRepository = processoRepository;
        }

        public IEnumerable<Processo> BuscarPorId(int ProcessoId)
        {
            return _processoRepository.BuscarPorId(ProcessoId);
        }
    }
}
