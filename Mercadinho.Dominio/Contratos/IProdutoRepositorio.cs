using Mercadinho.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Dominio.Contratos
{
    public interface IProdutoRepositorio: IBaseRepositorio<Produto>
    {
        Task<Produto[]> ObterTodosProdutos();

        Task<Produto> ObterProdutoPorId(int id);
    }
}
