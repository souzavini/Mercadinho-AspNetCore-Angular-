using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Dominio.Entidades
{
    public class Venda
    {
        public int IdVenda { get; set; }

        public DateTime DataPedido { get; set; }

        public int Quantidade { get; set; }

        public int ProdutoIdProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public int VendedorIdVendedor { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}
