using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
    Vendor.ClearAll();
    }
    [TestMethod]
    public void GetObject_ReturnsVendorInstance_Vendor()
    {
    Vendor newVendor = new Vendor("test", "test");
    Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetNameInput_ReturnsNameInput_String()
    {
      string testName = "test1";
      Vendor newVendor = new Vendor(testName,"");
      string result = newVendor.Name;
      Assert.AreEqual(testName, result);
    }
    [TestMethod]
    public void GetProperyDescription_ReturnsDescriptionInput_String()
    {
      string testName = "test1";
      string testDescription = "test2";
      Vendor newVendor = new Vendor(testName, testDescription);
      string result = newVendor.Description;
      Assert.AreEqual(testDescription, result);
    }
     [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test1";
      string description = "test2";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
  public void GetAll_ReturnsAllVendorObjects_VendorList()
  {
    string test1 = "test1";
    string test2 = "test2";
    Vendor newVendor1 = new Vendor(test1, test2);
    Vendor newVendor2 = new Vendor(test1, test2);
    List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
    List<Vendor> result = Vendor.GetAll();
    CollectionAssert.AreEqual(newList, result);
  }
  }
}