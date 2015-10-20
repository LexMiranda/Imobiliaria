
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using Imobiliaria.Domain.Entities;

namespace Imobiliaria.Infra.Data.EntityConfig
{
    public class ImovelConfiguration: EntityTypeConfiguration<Imovel>
    {
        public ImovelConfiguration()
        {
            HasKey(i => i.ImovelId);
            Property(i => i.Tipo)
                .IsRequired()
                .HasMaxLength(250);
            Property(i => i.Quartos)
                .IsRequired();
            

        }

    }
}
