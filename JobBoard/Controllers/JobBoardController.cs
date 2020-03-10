using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
  public class JobBoardsController : Controller
  {
    [HttpGet("/form")]
    public ActionResult Form() { return View(); }

    [HttpPost("/jobs")]
    public ActionResult Jobs(string title, string salary, string description, string name, string email, string phoneNumber) {
      Contact myContact = new Contact(name, email, phoneNumber);
      JobOpening myJobOpening = new JobOpening(title, salary, description, myContact);
      return View(myJobOpening);
    }
  }
}