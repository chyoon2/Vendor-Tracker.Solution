using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name{get; set;}
    public string Description{get; set;}
    public int Id {get;}
    private static List<Vendor> _vendorList = new List<Vendor>{};
    public List<Order> OrdersPerVendorList {get; set;}

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendorList.Add(this);
      Id = _vendorList.Count;
      OrdersPerVendorList = new List<Order>{};
    }

    public void AddOrder(Order order)
    {
      OrdersPerVendorList.Add(order);
    }

    public static List<Vendor> GetAllVendors()
    {
      return _vendorList;
    }
    public static Vendor FindId(int searchId)
    {
      return _vendorList[searchId-1];
    }
    public static void ClearAll()
    {
      _vendorList.Clear();
    }
  }
}