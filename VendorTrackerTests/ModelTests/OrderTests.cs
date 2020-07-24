using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetQuantityInput_ReturnsQuantityInput_Int()
    {
      int testOrder = 5;
      Order newOrder = new Order(testOrder);
      int result = newOrder.Quantity;
      Assert.AreEqual(testOrder, result);
    }
  }
}