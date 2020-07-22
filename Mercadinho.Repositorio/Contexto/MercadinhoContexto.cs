using Mercadinho.Dominio.Entidades;
using Mercadinho.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Repositorio.Contexto
{
    public class MercadinhoContexto: DbContext
    {
        public MercadinhoContexto (DbContextOptions options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new VendaConfiguration());
            modelBuilder.ApplyConfiguration(new VendedorConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
