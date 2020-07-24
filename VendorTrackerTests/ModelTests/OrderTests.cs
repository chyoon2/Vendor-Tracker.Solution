using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
    Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order(5);
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
    [TestMethod]
    public void GetList_ReturnsEmptyList_OrderList()
    {
      int test = 0;
      Order newOrder = new Order(test);
      List<Order> newList = new List<Order> {newOrder};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
     [TestMethod]
    public void GetAll_ReturnsItems_ItemList()
    {
      int test1 = 1;
      int test2 = 2;
      Order newOrder1 = new Order(test1);
      Order newOrder2 = new Order(test2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      foreach(Order x in newList)
      {
        Console.WriteLine(x.Quantity);
      }
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}