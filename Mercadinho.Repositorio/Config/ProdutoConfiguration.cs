using Mercadinho.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.IdProduto);

            builder
                .Property(p => p.PrecoUnitario)
                .IsRequired();

            builder
                .Property(p => p.Quantidade)
                .IsRequired();

            builder
                .HasMany(p => p.Vendas)
                .WithOne(v => v.Produto);
        }
    }
}
