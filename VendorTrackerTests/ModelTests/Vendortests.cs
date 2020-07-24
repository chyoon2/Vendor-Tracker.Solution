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
    // Vendor.ClearAll();
    // }
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
  }
}