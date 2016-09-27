﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class AutoInfracaoRepository : RepositoryBase<AutoInfracao>, IAutoInfracaoRepository
    {
        public IEnumerable<AutoInfracao> BuscarPorId(int AutoInfracaoId)
        {
            return Db.AutoInfracoes.Where(p => p.AutoInfracaoId == AutoInfracaoId);
        }
    }
}
