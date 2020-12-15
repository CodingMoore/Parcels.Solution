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

    public void ParcelConstructor_ReturnProperties_True()
    {
      Parcel box = new Parcel(5, 6, 7, 10);
      Assert.AreEqual(5, box.Length);
      Assert.AreEqual(6, box.Width);
      Assert.AreEqual(7, box.Height);
      Assert.AreEqual(11, box.Weight);

    } 
  }
}