using System;

namespace JobBoard.Models
{
  public class Item
  {
    public string Property { get; set; }
    public Item(string property)
    {
      Property = property;
    }
  }
}