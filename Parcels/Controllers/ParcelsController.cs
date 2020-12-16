using Microsoft.AspNetCor.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controllers
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcels> allParcels = Parcel.GetAll();
      return View();
    }
    
    [HttpGet("/parcels/new")]
    public ActionResult New()
    {
      return view();
    }

    [HttpPost("/parcels")]
  
    public ActionResult Create(string stringLength, string stringWidth, string stringHeight, string stringWeight)
    {
      int length = int.Parse(stringLength);
      int width = int.Parse(stringWidth);
      int height = int.Parse(stringHeight);
      int weight = int.Parse(stringWeight);

      Parcel box = new Parcel(length, width, height, weight);
      return RedirectToAction("Index");
    }
    
  }

}
