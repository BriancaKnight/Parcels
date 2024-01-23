using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Home() { return View(); }

    [Route("")]
  }
}