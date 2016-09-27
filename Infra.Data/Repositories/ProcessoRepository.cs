using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class ProcessoRepository : RepositoryBase<Processo>, IProcessoRepository
    {
        public IEnumerable<Processo> BuscarPorId(int ProcessoId)
        {
            return Db.Processos.Where(p => p.ProcessoId == ProcessoId);
        }
    }
}
