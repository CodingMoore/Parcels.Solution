using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;
using System;
using System.Collections.Generic;

namespace Parcels.Test
{
  [TestClass]
  public class ParcelTests : IDisposable
  {
    public void Dispose()
    {
      Parcel.ClearAll();
    }

    [TestMethod]

    public void ParcelConstructor_CreateInstanceOfParcel_True()
    {
      Parcel box = new Parcel(5, 6, 7, 10);
      Assert.AreEqual(typeof(Parcel), box.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_True()
    {
      // Arrange
      List<Parcel> newList = new List<Parcel> { };
      Parcel newItem = new Parcel(9, 10, 11, 12);
      newList.Add(newItem);
      // Act
      List<Parcel> result = Parcel.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearsAllItems_True()
    {
      // Arrange
      Parcel newItem0 = new Parcel(2, 3, 4, 5);
      Parcel newItem1 = new Parcel(5, 6, 7, 8);
      List<Parcel> newList = new List<Parcel> {  };

      // Act
      Parcel.ClearAll();
      List<Parcel> result = Parcel.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]

    public void ParcelConstructor_ReturnProperties_True()
    {
      Parcel box = new Parcel(5, 6, 7, 10);
      Assert.AreEqual(5, box.GetLength());
      Assert.AreEqual(6, box.GetWidth());
      Assert.AreEqual(7, box.GetHeight());
      Assert.AreEqual(10, box.GetWeight());
    } 

    [TestMethod]
    public void ParcelSetters_UpdatePropertyValues_True()
    {
      Parcel box = new Parcel(5, 6, 7, 10);
      box.SetLength(1);
      box.SetWidth(2);
      box.SetHeight(3);
      box.SetWeight(4);
      Assert.AreEqual(1, Parcel.GetAll()[0].GetLength());
      Assert.AreEqual(2, Parcel.GetAll()[0].GetWidth());
      Assert.AreEqual(3, Parcel.GetAll()[0].GetHeight());
      Assert.AreEqual(4, Parcel.GetAll()[0].GetWeight());
    }

    [TestMethod]
    public void ParcelConstructor_AddToPackages_True()
    {
      Parcel box = new Parcel(7, 8, 9, 10);
      Assert.AreEqual(7, Parcel.GetAll()[0].GetLength());
    }

    [TestMethod]
    public void Volume_ReturnParcelVolume_True()
    {
      Parcel box = new Parcel(3, 4, 5, 10);
      Assert.AreEqual(60, box.Volume());
    }

    [TestMethod]
    public void CalcShip_CalcShippingCost_True()
    {
      Parcel box = new Parcel(7, 8, 9, 10);
      Parcel box1 = new Parcel(1, 1, 1, 1);
      Assert.AreEqual(16, box.CalcShip());
      Assert.AreEqual(5, box1.CalcShip());

    }

    [TestMethod]
    public void BoxNum_CreateUniqueIdForParcel_True()
    {
      Parcel box = new Parcel(5, 6, 7, 10);
      Parcel box2 = new Parcel(1, 2, 3, 11);
      Parcel box3 = new Parcel(1, 2, 3, 11);
      Parcel box4 = new Parcel(1, 2, 3, 11);
      Parcel box5 = new Parcel(1, 2, 3, 11);
      Parcel box6 = new Parcel(1, 2, 3, 11);
      Assert.AreEqual("Box6", box6.GetName());
    }
  }
}
