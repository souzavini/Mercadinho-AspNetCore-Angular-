using Mercadinho.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Dominio.Contratos
{
    public interface IVendaRepositorio: IBaseRepositorio<Venda>
    {
        Task<Venda[]> ObterTodasVendas();

        Task<Venda> RealizarVenda(Venda venda);

        
    }
}
