using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCompraCore.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, decimal preco) : this(nome, preco)
        {
            this.Id = id;

        }

        public Produto(string nome, decimal preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

    }
}
