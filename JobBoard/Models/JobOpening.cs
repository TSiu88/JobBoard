using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; set; }
    public string Salary { get; set; }
    public string Description { get; set; }

    public Contact Contact { get; set; }
    private static List<JobOpening> _instances = new List<JobOpening>() {};
    public JobOpening(string title, string salary, string description, Contact contact)
    {
      Title = title;
      Salary = salary;
      Description = description;
      Contact = contact;
      _instances.Add(this);
    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}