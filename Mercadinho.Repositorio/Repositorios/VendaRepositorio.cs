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
    public class VendaRepositorio : BaseRepositorio<Venda>, IVendaRepositorio
    {
        public VendaRepositorio(MercadinhoContexto mercadinhoContexto) : base(mercadinhoContexto)
        {
        }

        public async Task<Venda[]> ObterTodasVendas()
        {
            IQueryable<Venda> query = MercadinhoContexto.Vendas;

            //query = query.AsNoTracking().OrderBy(v => v.IdVenda);

            query = query.Include(p => p.Vendedor)
                .ThenInclude(pe => pe.Vendas)
                .ThenInclude(kj => kj.Produto)
                .OrderBy(p => p.IdVenda);

            return await query.ToArrayAsync();
        }

        public Task<Venda> RealizarVenda(Venda venda)
        {

           
        }
    }
}
