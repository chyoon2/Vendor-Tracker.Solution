using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrdersControllers : Controllers
  {
    [HttpGet(/vendors/{id}/order{id})]
    //showing the details of one order
    public ActionResult Show(int id)
    {

    }
    [HttpGet(/vendors/{id}/order/new)]
    public ActionResult New(int id)
    {
      Vendor newVendor = Vendor.FindId(id);
      return View(newVendor);
    }
  }
}