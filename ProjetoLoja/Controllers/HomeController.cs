using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoLoja.Models;
using ProjetoLoja.Repository;

namespace ProjetoBrinquedos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProdutoRepository _produtoRepository;

        public HomeController(ILogger<HomeController> logger, ProdutoRepository produtoRepositorio)
        {
            _logger = logger;
            _produtoRepository = produtoRepositorio;
        }
        public async Task<IActionResult> Index()
        {
            return View();
            var produtos = await _produtoRepository.TodosProdutos();
            return View(produtos);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}