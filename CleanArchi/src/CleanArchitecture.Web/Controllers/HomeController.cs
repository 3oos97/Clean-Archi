using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Web.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      //hello
      //koko
      return View();
    }

    public IActionResult Error()
    {
      return View();
    }
  }
}
