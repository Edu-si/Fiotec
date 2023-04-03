using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Cpf)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(c => c.DataAplicacao)
                .IsRequired()
                .HasColumnType("datetime");

           
            builder.ToTable("Cliente");
        }
    }
}
