﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IAutoInfracaoService : IServiceBase<AutoInfracao>
    {
        IEnumerable<AutoInfracao> BuscarPorId(int AutoInfracaoId);
    }
}
