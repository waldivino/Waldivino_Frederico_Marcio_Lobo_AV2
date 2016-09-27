using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.EntityConfig
{
    class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {
            HasKey(f => f.FornecedorId);

            Property(f => f.FornecedorId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
                        
            Property(f => f.Cnpj).IsRequired().HasMaxLength(14);

            Property(f => f.RazaoSocial).IsRequired().HasMaxLength(200);

            Property(f => f.InscricaoMunicipal).HasMaxLength(8);

            Property(f => f.ReceitaBruta).IsRequired();
        }
    }
}
