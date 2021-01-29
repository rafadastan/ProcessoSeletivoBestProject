using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBestProject.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBestProject.Infra.Data.Mappings
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(c => c.IdContato);

            builder.Property(c => c.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(c => c.Telefone)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(c => c.Celular)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
