using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrdersControllers : Controllers
  {
    [HttpGet(/vendors/{id}/order/{orderId})]
    //showing the details of one order
    public ActionResult Show(int id, int orderId)
    {
      Vendor newVendor = Vendor.FindId(id);
      Order newOrder = Order.FindId(orderId);
      Dictionary<string, object> model = new Dictionary<string,object>(){};
      model.Add("order", newOrder);
      model.Add("vendor", newOrder);
      return View (model)
    }
    [HttpGet(/vendors/{id}/orders/new)]
    public ActionResult New(int id)
    {
      Vendor newVendor = Vendor.FindId(id);
      return View(newVendor);
    }
  }
}