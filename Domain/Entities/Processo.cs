using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Processo
    {
        public int ProcessoId { get; set; }
        //public Fornecedor Fornecedor { get; set; }
        public StringBuilder RelatoFiscalizacao { get; set; }
        public DateTime DataRelato { get; set; }
        public string FiscalResponsavel { get; set;}

    }
}
