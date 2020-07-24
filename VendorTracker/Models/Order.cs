using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public int Price{get; set;}
    public string Date {get; set;}
    public string Title {get; set;}
    public string Description{get; set;}
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};

    public Order(int userPrice, string userDate, string userDescription, string userTitle)
    {
      Price = userPrice;
      Date = userDate;
      Description = userDescription;
      Title = userTitle;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}