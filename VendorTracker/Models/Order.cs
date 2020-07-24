using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public int Quantity{get; set;}
    public int Id { get; }
    public Order(int userInput)
    {
      Quantity = userInput;
    }
  }
}