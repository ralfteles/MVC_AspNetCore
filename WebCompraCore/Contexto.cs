using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCompraCore.Models;

namespace WebCompraCore
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
