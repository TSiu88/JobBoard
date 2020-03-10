using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/")]
    public ActionResult HomePage() {
      JobOpening myJobOpening = new JobOpening("property");
      myJobOpening.Property = "Lina";
      return View(myJobOpening);
    }
  }
}