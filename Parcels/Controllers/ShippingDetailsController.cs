using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class ShippingDetailsController : Controller
  {
    [HttpPost("/shippingDetails")]
    public ActionResult ShippingDetails(int height, int length, int width, int weight)
    {
      Package newPackage = new Package(new Dictionary<string, int> {{"height", height}, {"length", length}, {"width", width}, {"weight", weight}});
      return View("ShippingDetails");
    }
  }
}