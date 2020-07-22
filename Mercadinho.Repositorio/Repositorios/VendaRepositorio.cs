using Mercadinho.Dominio.Contratos;
using Mercadinho.Dominio.Entidades;
using Mercadinho.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Repositorio.Repositorios
{
    public class VendaRepositorio : BaseRepositorio<Venda>, IVendaRepositorio
    {
        public VendaRepositorio(MercadinhoContexto mercadinhoContexto) : base(mercadinhoContexto)
        {
        }


    }
}
