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
    public void GetAll_ReturnsAllShipmentObjects_ShipmentList()
    {
      // Arrange
      string name01 = "Ground";
      string name02 = "Express";
      Shipment newShipment1 = new Shipment(name01);
      Shipment newShipment2 = new Shipment(name02);
      List<Shipment> newList = new List<Shipment> { newShipment1, newShipment2 };

      // Act
      List<Shipment> result = Shipment.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetName_ReturnNameOfShipment_True()
    {
      string name = "Ground";
      Shipment newShipment = new Shipment(name);
      Assert.AreEqual(name, Shipment.GetAll()[0].Name);
    }
    
    [TestMethod]
    public void GetId_ReturnsShipmentId_Int()
    {
      //Arrange
      string name = "Test Shipment";
      Shipment newShipment = new Shipment(name);

      // Act
      int result = newShipment.Id;

      // Assert
      Assert.AreEqual(1, result);
    }


  }
}