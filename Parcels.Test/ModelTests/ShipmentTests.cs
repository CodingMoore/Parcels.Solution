using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;
using System;
using System.Collections.Generic;

namespace Shipments.Test
{
  [TestClass]
  public class ShipmentTests : IDisposable
  {
    public void Dispose()
    {
      Shipment.ClearAll();
    }

    [TestMethod]
    public void ShipmentConstructor_CreateInstanceofShipment_True()
    {
      Shipment shipType = new Shipment("Express");
      Assert.AreEqual(typeof(Shipment), shipType.GetType());
    }

    [TestMethod]
    public void ShipmentConstructor_ReturnNameOfShipment_True()
    {
      string shipName = "Ground";
      Shipment shipType = new Shipment(shipName);
      Assert.AreEqual(shipName, Shipment.GetAll()[0].Name);
    }
    
  }
}