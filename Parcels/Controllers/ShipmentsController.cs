using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers //this matches project name
{
public class ShipmentsController : Controller  //class name matches name of model
  {
  [HttpGet("/Shipments/new")]
  public ActionResult New()
    {
    return View();
    }


    [HttpGet("/shipments/new")]
    public ActionResult New()
    List<Shipment> myList = Shipment.GetAll()
    {
      return View(myList);
    }

    [HttpPost("/shipments/items")]
    public ActionResult Create(int idVal, int length, int width, int height, int weight)
    {
      Parcel parcel = new Parcel(length, width, height, weight);
      Shipment.GetAll()[idVal].Parcels.Add(parcel);
      // Dictionary<string, object> model = new Dictionary<string, object>();
      // Category foundCategory = Category.Find(categoryId);
      // Item newItem = new Item(itemDescription);
      // foundCategory.AddItem(newItem);
      // List<Item> categoryItems = foundCategory.Items;
      // model.Add("items", categoryItems);
      // model.Add("category", foundCategory);
      // return View("Show", model);
    }
  }
}
