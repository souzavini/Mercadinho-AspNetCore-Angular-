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

            query = query.AsNoTracking()
                .Include(p => p.Produto)
                .ThenInclude(ve => ve.Vendas)
                .ThenInclude(vend => vend.Vendedor)
                .OrderBy(p => p.ProdutoIdProduto);

            return await query.ToArrayAsync();

        }

        public Task<Venda> RealizarVenda(Venda venda)
        {
            throw new NotImplementedException();
        }



    }
}
