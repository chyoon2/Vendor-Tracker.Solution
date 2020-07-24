using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    // public void Dispose()
    // {
    // Order.ClearAll();
    // }
    [TestMethod]
    public void GetObject_ReturnsVendorInstance_Vendor()
    {
    Vendor newVendor = new Vendor();
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}