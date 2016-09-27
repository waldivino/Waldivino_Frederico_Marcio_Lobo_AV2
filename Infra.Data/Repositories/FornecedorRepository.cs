using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
        public IEnumerable<Fornecedor> BuscarPorNome(string nome)
        {
            return Db.Fornecedores.Where(p => p.RazaoSocial == nome);
        }
    }
}
