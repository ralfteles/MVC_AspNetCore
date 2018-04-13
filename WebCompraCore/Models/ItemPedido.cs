using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCompraCore.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal SubTotal
        {
            get
            {
                return Quantidade * PrecoUnitario;
            }
        }

        public ItemPedido()
        {

        }

        public ItemPedido(int id, Produto produto, int quantidade) : this(produto,quantidade)
        {
            this.Id = id;
        }

        public ItemPedido(Produto produto, int quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitario = produto.Preco;
        }
    }
}
