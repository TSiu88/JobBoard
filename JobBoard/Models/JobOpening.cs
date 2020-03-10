using System;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Property { get; set; }
    public JobOpening(string property)
    {
      Property = property;
    }
  }
}