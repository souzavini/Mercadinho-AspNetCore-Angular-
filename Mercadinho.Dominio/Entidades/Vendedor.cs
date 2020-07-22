using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Dominio.Entidades
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
