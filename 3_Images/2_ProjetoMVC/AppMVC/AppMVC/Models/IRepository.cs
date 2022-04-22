using System.Collections.Generic;

namespace AppMVC.Models
{
  public interface IRepository
  {
    IEnumerable<Produto> Produtos { get; }
  }
}
