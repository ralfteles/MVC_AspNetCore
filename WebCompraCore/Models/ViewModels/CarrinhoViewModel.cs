using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCompraCore.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public List<ItemPedido> Itens { get; set; }
        public decimal Total
        {
            get
            {
                return Itens.Sum(x => x.SubTotal);
            }
        }

        public CarrinhoViewModel(List<ItemPedido> itens)
        {
            this.Itens = itens;
        }

    }
}
