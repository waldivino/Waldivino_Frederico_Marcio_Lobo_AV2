using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            Enderecos = new List<Endereco>();
        }
        public int FornecedorId { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        //public List<Endereco> Enderecos { get; set; }
        public string InscricaoMunicipal { get; set; }
        public Decimal ReceitaBruta { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
    }
}
