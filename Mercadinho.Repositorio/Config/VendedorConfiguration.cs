using Mercadinho.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Repositorio.Config
{
    public class VendedorConfiguration : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.HasKey(v => v.IdVendedor);

            builder
                .Property(v => v.Nome)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasMany(v => v.Vendas)
                .WithOne(ve => ve.Vendedor);



        }
    }
}
