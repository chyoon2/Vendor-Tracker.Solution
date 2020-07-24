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
    private static List<Order> _orderList = new List<Order>{};

    public Order(int userPrice, string userDate, string userDescription, string userTitle)
    {
      Price = userPrice;
      Date = userDate;
      Description = userDescription;
      Title = userTitle;
      _orderList.Add(this);
      Id = _orderList.Count;
    }
    public static List<Order> GetAll()
    {
      return _orderList;
    }
    // public static Category Find(int searchId)
    // {
    //   return _orderList[searchId-1];
    // }
    public static void ClearAll()
    {
      _orderList.Clear();
    }
  }
}