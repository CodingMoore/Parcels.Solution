using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;
using System.Collections.Generic;
using System;

namespace Parcels.Test
{
  [TestClass]
  public class ParcelTests : IDisposeable
  {
    public void Dispose()
    {
      Parcel.ClearAll();
    }

    [TestMethod]

    public void ParcelConstructor_CreateInstanceOfParcel_True()
    {
      Parcel Box = new Parcel(5, 6, 7);
      Assert.AreEqual(6, Parcel.GetAll()[0].Length);
    }
  }
}