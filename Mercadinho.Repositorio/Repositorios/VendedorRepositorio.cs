using Mercadinho.Dominio.Contratos;
using Mercadinho.Dominio.Entidades;
using Mercadinho.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Repositorio.Repositorios
{
    public class VendedorRepositorio : BaseRepositorio<Vendedor>, IVendedorRepositorio
    {
        public VendedorRepositorio(MercadinhoContexto mercadinhoContexto) : base(mercadinhoContexto)
        {
        }


    }
}
