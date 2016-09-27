using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.EntityConfig
{
    class AutoInfracaoConfiguration : EntityTypeConfiguration<AutoInfracao>
    {
        public AutoInfracaoConfiguration()
        {
            HasKey(p => p.AutoInfracaoId);

            Property(p => p.AutoInfracaoId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            
        }
    }
}
