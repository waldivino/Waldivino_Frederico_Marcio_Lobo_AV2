using Domain.Entities;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        public IEnumerable<Endereco> BuscarPorNome(string nome)
        {
            return Db.Enderecos.Where(p => p.Logradouro == nome);
        }
    }
}
