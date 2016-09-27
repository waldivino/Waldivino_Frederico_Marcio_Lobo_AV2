using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Infra.Data.EntityConfig
{
    class ProcessoConfiguration : EntityTypeConfiguration<Processo>
    {
        public ProcessoConfiguration()
        {
            HasKey(p => p.ProcessoId);

            Property(p => p.ProcessoId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
