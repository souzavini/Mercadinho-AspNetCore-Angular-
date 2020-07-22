using System;
using System.Collections.Generic;
using System.Text;

namespace Mercadinho.Dominio.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public int Quantidade { get; set; }

        public decimal PrecoUnitario { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
