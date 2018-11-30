using Microsoft.AspNetCore.Mvc;
using WordCounterMVC.Models;

namespace WordCounterMVC.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() 
    { 
      return View(); 
    }

  }
}
