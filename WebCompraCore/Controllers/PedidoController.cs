using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebCompraCore.Models;
using WebCompraCore.Models.ViewModels;

namespace WebCompraCore.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IDataService _dataService;
        public PedidoController(IDataService dataService)
        {
            _dataService = dataService;
        }

        public IActionResult Carrosel()
        {
            List<Produto> produtos = _dataService.GetProdutos(); 

            return View(produtos);
        }

        public IActionResult Carrinho()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }

       
        public IActionResult Resumo()
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();

            return View(viewModel);
        }

        private CarrinhoViewModel GetCarrinhoViewModel()
        {
            List<Produto> produtos = this._dataService.GetProdutos();

            var itensCarrinho = this._dataService.GetItensPedido();
            

            CarrinhoViewModel viewModel = new CarrinhoViewModel(itensCarrinho);
            return viewModel;
        }

    }
}