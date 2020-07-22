using Mercadinho.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Repositorio.Config
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(v => v.IdVenda);

            builder.Property(v => v.DataPedido)
                .IsRequired();
                

            builder
                .Property(v => v.Quantidade)
                .IsRequired();
                
        }
    }
}
