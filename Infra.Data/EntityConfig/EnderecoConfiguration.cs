using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.EntityConfig
{
    class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.EnderecoId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(e => e.Logradouro).IsRequired().HasMaxLength(100);

            Property(e => e.Numero).IsRequired().HasMaxLength(50);

            Property(e => e.Complemento).HasMaxLength(50);

            Property(e => e.Bairro).IsRequired().HasMaxLength(100);

            Property(e => e.Cep).IsRequired().HasMaxLength(9);

            Property(e => e.Municipio).IsRequired().HasMaxLength(200);
        }
    }
}
