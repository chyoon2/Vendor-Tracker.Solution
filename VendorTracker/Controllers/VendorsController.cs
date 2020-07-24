using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
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
    public ActionResult Create(string title, string description)
    {
      Vendor newVendor = new Vendor(title, description);
      return RedirectToAction("Index", newVendor);
    }
  }
}