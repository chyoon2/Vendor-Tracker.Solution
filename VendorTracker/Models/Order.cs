using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public int Quantity{get; set;}
    // public int Id { get; }
    private static List<Order> _instances = new List<Order>{};

    public Order(int userInput)
    {
      Quantity = userInput;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}