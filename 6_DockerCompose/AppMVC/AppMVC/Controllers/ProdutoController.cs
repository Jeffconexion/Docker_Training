using AppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace AppMVC.Controllers
{
  public class ProdutoController : Controller
  {
    private IRepository repository;
    private string message;
    public ProdutoController(IRepository repo, IConfiguration config)
    {
      repository = repo;
      message = config["MESSAGE"] ?? "ASP NET CORE MVC - DOCKER";
    }
    public IActionResult Index()
    {
      ViewBag.Message = message;
      return View(repository.Produtos);
    }
  }
}
