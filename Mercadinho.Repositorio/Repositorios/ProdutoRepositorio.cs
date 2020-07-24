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
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(MercadinhoContexto mercadinhoContexto) : base(mercadinhoContexto)
        {
        }

        public async Task<Produto> ObterProdutoPorId(int id)
        {
            IQueryable<Produto> query = MercadinhoContexto.Produtos;

            query = query.AsNoTracking()
               .OrderBy(p => p.IdProduto)
               .Where(p => p.IdProduto == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Produto[]> ObterTodosProdutos()
        {
            IQueryable<Produto> query = MercadinhoContexto.Produtos;

            query = query.AsNoTracking().OrderBy(p => p.IdProduto);

            return await query.ToArrayAsync();
        }
    }
}
