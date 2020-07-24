using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> displayList = Vendor.GetAllVendors();
      return View(displayList);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.FindId(id);
      List<Order> vendorOrders = selectedVendor.OrdersPerVendorList;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int id, int price, string date, string description, string title)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Order newOrder = new Order(price, date, description, title);
      Vendor foundVendor = Vendor.FindId(id);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.OrdersPerVendorList;
      model.Add("vendor", foundVendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
  }
}