using Mercadinho.Dominio.Contratos;
using Mercadinho.Dominio.Entidades;
using Mercadinho.Repositorio.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Repositorio.Repositorios
{
    public class VendedorRepositorio : BaseRepositorio<Vendedor>, IVendedorRepositorio
    {
        public VendedorRepositorio(MercadinhoContexto mercadinhoContexto) : base(mercadinhoContexto)
        {
        }

        public async Task<Vendedor[]> ObterTodosVendedores()
        {
            IQueryable<Vendedor> query = MercadinhoContexto.Vendedores;

            query = query.AsNoTracking().OrderBy(v => v.IdVendedor);

            return await query.ToArrayAsync();
        }


        public async Task<Vendedor> ObterVendedorPorId(int id)
        {
            IQueryable<Vendedor> query = MercadinhoContexto.Vendedores;

            query = query.AsNoTracking()
                .OrderBy(v => v.IdVendedor)
                .Where(v => v.IdVendedor == id);

            return await query.FirstOrDefaultAsync();
        }


        public IList<Vendedor> Obtervendedor()
        {
            //var vendedores = MercadinhoContexto.Vendedores.Select(v=> v.IdVendedor  v.Nome);

            var vendedores = MercadinhoContexto.Vendedores.FromSql(" SELECT * FROM vendedores").ToList();

            return vendedores;
        }

    }
}
