using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers //this matches project name
{
public class ShipmentsController : Controller  //class name matches name of model
  {
  [HttpGet("/shipments")]
  public ActionResult Index()
    {
    List<Shipment> allShipments = Shipment.GetAll();
    return View(allShipments);
    }
  }
}