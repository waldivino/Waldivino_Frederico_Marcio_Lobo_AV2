using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class AutoInfracaoService : ServiceBase<AutoInfracao>, IAutoInfracaoService
    {
        private readonly IAutoInfracaoRepository _autoInfracaoRepository;

        public AutoInfracaoService(IAutoInfracaoRepository autoInfracaoRepository) : base(autoInfracaoRepository)
        {
            _autoInfracaoRepository = autoInfracaoRepository;
        }

        public IEnumerable<AutoInfracao> BuscarPorId(int AutoInfracaoId)
        {
            return _autoInfracaoRepository.BuscarPorId(AutoInfracaoId);
        }
    }
}
