using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Mappings
{
    public class RelatorioMapping : IEntityTypeConfiguration<Relatorio>
    {
        public void Configure(EntityTypeBuilder<Relatorio> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.NomeSolicitante)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.QuantidadeTotal)
                .IsRequired()
                .HasColumnType("int");


            builder.ToTable("Relatorio");
        }
    }

}

