using Mercadinho.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho.Dominio.Contratos
{
    public interface IVendedorRepositorio:IBaseRepositorio<Vendedor>
    {
        IList<Vendedor> Obtervendedor();

        Task<Vendedor[]> ObterTodosVendedores();

        Task<Vendedor> ObterVendedorPorId(int id);
    }
}
