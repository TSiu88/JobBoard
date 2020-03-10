using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using JobBoard.Models;

namespace JobBoard
{
  class Program
  {
  public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}
